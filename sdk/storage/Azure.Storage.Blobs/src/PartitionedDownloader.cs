﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.Storage.Blobs.Models;
using Azure.Storage.Blobs.Specialized;

namespace Azure.Storage.Blobs
{
    internal class PartitionedDownloader
    {
        /// <summary>
        /// The client used to download the blob.
        /// </summary>
        private readonly BlobBaseClient _client;

        /// <summary>
        /// The maximum number of simultaneous workers.
        /// </summary>
        private readonly int _maxWorkerCount;

        /// <summary>
        /// The size of the first range requested (which can be larger than the
        /// other ranges).
        /// </summary>
        private readonly long _initialRangeSize;

        /// <summary>
        /// The size of subsequent ranges.
        /// </summary>
        private readonly long _rangeSize;

        // TODO #27253
        //private readonly DownloadTransactionalHashingOptions _hashingOptions;

        private readonly IProgress<long> _progress;

        private readonly bool? _ignoreStrongConsistencyLock;

        public PartitionedDownloader(
            BlobBaseClient client,
            StorageTransferOptions transferOptions = default,
            // TODO #27253
            //DownloadTransactionalHashingOptions hashingOptions = default,
            IProgress<long> progress = default,
            bool? ignoreStrongConsistencyLock = default)
        {
            _client = client;

            // Set _maxWorkerCount
            if (transferOptions.MaximumConcurrency.HasValue
                && transferOptions.MaximumConcurrency > 0)
            {
                _maxWorkerCount = transferOptions.MaximumConcurrency.Value;
            }
            else
            {
                _maxWorkerCount = Constants.Blob.Block.DefaultConcurrentTransfersCount;
            }

            // Set _rangeSize
            if (transferOptions.MaximumTransferSize.HasValue
                && transferOptions.MaximumTransferSize.Value > 0)
            {
                _rangeSize = Math.Min(transferOptions.MaximumTransferSize.Value, Constants.Blob.Block.MaxDownloadBytes);
            }
            else
            {
                _rangeSize = Constants.DefaultBufferSize;
            }

            // Set _initialRangeSize
            if (transferOptions.InitialTransferSize.HasValue
                && transferOptions.InitialTransferSize.Value > 0)
            {
                _initialRangeSize = transferOptions.InitialTransferSize.Value;
            }
            else
            {
                _initialRangeSize = Constants.Blob.Block.DefaultInitalDownloadRangeSize;
            }

            // TODO #27253
            // the caller to this stream cannot defer validation, as they cannot access a returned hash
            //if (!(hashingOptions?.Validate ?? true))
            //{
            //    throw Errors.CannotDeferTransactionalHashVerification();
            //}

            //_hashingOptions = hashingOptions;
            _progress = progress;
            _ignoreStrongConsistencyLock = ignoreStrongConsistencyLock;

            /* Unlike partitioned upload, download cannot tell ahead of time if it will split and/or parallelize
             * after first call. Instead of applying progress handling to initial download stream after-the-fact,
             * wrap a given progress handler in an aggregator upfront and accept the overhead. */
            if (_progress != null && _progress is not AggregatingProgressIncrementer)
            {
                _progress = new AggregatingProgressIncrementer(_progress);
            }
        }

        public async Task<Response> DownloadToAsync(
            Stream destination,
            BlobRequestConditions conditions,
            CancellationToken cancellationToken)
        {
            // Wrap the download range calls in a Download span for distributed
            // tracing
            DiagnosticScope scope = _client.ClientConfiguration.ClientDiagnostics.CreateScope($"{nameof(BlobBaseClient)}.{nameof(BlobBaseClient.DownloadTo)}");
            try
            {
                scope.Start();

                // Just start downloading using an initial range.  If it's a
                // small blob, we'll get the whole thing in one shot.  If it's
                // a large blob, we'll get its full size in Content-Range and
                // can keep downloading it in segments.
                var initialRange = new HttpRange(0, _initialRangeSize);

                BlobDownloadStreamingOptions initalStreamingOptions = new BlobDownloadStreamingOptions
                {
                    Range = initialRange,
                    Conditions = conditions,
                    ProgressHandler = _progress,
                    IgnoreStrongConsistencyLock = _ignoreStrongConsistencyLock,
                };

                Task<Response<BlobDownloadStreamingResult>> initialResponseTask =
                    _client.DownloadStreamingAsync(
                        initalStreamingOptions,
                        cancellationToken);

                Response<BlobDownloadStreamingResult> initialResponse = null;
                try
                {
                    initialResponse = await initialResponseTask.ConfigureAwait(false);
                }
                catch (RequestFailedException ex) when (ex.ErrorCode == BlobErrorCode.InvalidRange)
                {
                    BlobDownloadStreamingOptions errorStreamingOptions = new BlobDownloadStreamingOptions
                    {
                        Conditions = conditions,
                        ProgressHandler = _progress,
                        IgnoreStrongConsistencyLock= _ignoreStrongConsistencyLock,
                    };

                    initialResponse = await _client.DownloadStreamingAsync(
                        errorStreamingOptions,
                        cancellationToken)
                        .ConfigureAwait(false);
                }

                // If the initial request returned no content (i.e., a 304),
                // we'll pass that back to the user immediately
                if (initialResponse.IsUnavailable())
                {
                    return initialResponse.GetRawResponse();
                }

                // If the first segment was the entire blob, we'll copy that to
                // the output stream and finish now
                long initialLength = initialResponse.Value.Details.ContentLength;
                long totalLength = ParseRangeTotalLength(initialResponse.Value.Details.ContentRange);
                if (initialLength == totalLength)
                {
                    await CopyToAsync(
                        initialResponse,
                        destination,
                        cancellationToken)
                        .ConfigureAwait(false);
                    return initialResponse.GetRawResponse();
                }

                // Capture the etag from the first segment and construct
                // conditions to ensure the blob doesn't change while we're
                // downloading the remaining segments
                ETag etag = initialResponse.Value.Details.ETag;
                BlobRequestConditions conditionsWithEtag = conditions?.WithIfMatch(etag) ?? new BlobRequestConditions { IfMatch = etag };

                // Create a queue of tasks that will each download one segment
                // of the blob.  The queue maintains the order of the segments
                // so we can keep appending to the end of the destination
                // stream when each segment finishes.
                var runningTasks = new Queue<Task<Response<BlobDownloadStreamingResult>>>();
                runningTasks.Enqueue(initialResponseTask);
                if (_maxWorkerCount <= 1)
                {
                    // consume initial task immediately if _maxWorkerCount is 1 (or less to be safe). Otherwise loop below would have 2 concurrent tasks.
                    await ConsumeQueuedTask().ConfigureAwait(false);
                }

                // Fill the queue with tasks to download each of the remaining
                // ranges in the blob
                foreach (HttpRange httpRange in GetRanges(initialLength, totalLength))
                {
                    // Add the next Task (which will start the download but
                    // return before it's completed downloading)
                    BlobDownloadStreamingOptions downloadOptions = new BlobDownloadStreamingOptions
                    {
                        Range = httpRange,
                        Conditions = conditionsWithEtag,
                        ProgressHandler = _progress,
                        IgnoreStrongConsistencyLock = _ignoreStrongConsistencyLock
                    };

                    runningTasks.Enqueue(_client.DownloadStreamingAsync(
                        downloadOptions,
                        cancellationToken));

                    // If we have fewer tasks than alotted workers, then just
                    // continue adding tasks until we have _maxWorkerCount
                    // running in parallel
                    if (runningTasks.Count < _maxWorkerCount)
                    {
                        continue;
                    }

                    // Once all the workers are busy, wait for the first
                    // segment to finish downloading before we create more work
                    await ConsumeQueuedTask().ConfigureAwait(false);
                }

                // Wait for all of the remaining segments to download
                while (runningTasks.Count > 0)
                {
                    await ConsumeQueuedTask().ConfigureAwait(false);
                }

                return initialResponse.GetRawResponse();

                // Wait for the first segment in the queue of tasks to complete
                // downloading and copy it to the destination stream
                async Task ConsumeQueuedTask()
                {
                    // Don't need to worry about 304s here because the ETag
                    // condition will turn into a 412 and throw a proper
                    // RequestFailedException
                    using BlobDownloadStreamingResult result =
                        await runningTasks.Dequeue().ConfigureAwait(false);

                    // Even though the BlobDownloadInfo is returned immediately,
                    // CopyToAsync causes ConsumeQueuedTask to wait until the
                    // download is complete
                    await CopyToAsync(
                        result,
                        destination,
                        cancellationToken)
                        .ConfigureAwait(false);
                }
            }
            catch (Exception ex)
            {
                scope.Failed(ex);
                throw;
            }
            finally
            {
                scope.Dispose();
            }
        }

        public Response DownloadTo(
            Stream destination,
            BlobRequestConditions conditions,
            CancellationToken cancellationToken)
        {
            // Wrap the download range calls in a Download span for distributed
            // tracing
            DiagnosticScope scope = _client.ClientConfiguration.ClientDiagnostics.CreateScope($"{nameof(BlobBaseClient)}.{nameof(BlobBaseClient.DownloadTo)}");
            try
            {
                scope.Start();

                // Just start downloading using an initial range.  If it's a
                // small blob, we'll get the whole thing in one shot.  If it's
                // a large blob, we'll get its full size in Content-Range and
                // can keep downloading it in segments.
                var initialRange = new HttpRange(0, _initialRangeSize);
                Response<BlobDownloadStreamingResult> initialResponse;

                BlobDownloadStreamingOptions initalStreamingOptions = new BlobDownloadStreamingOptions
                {
                    Range = initialRange,
                    Conditions = conditions,
                    ProgressHandler = _progress,
                    IgnoreStrongConsistencyLock = _ignoreStrongConsistencyLock
                };

                try
                {
                    initialResponse = _client.DownloadStreaming(
                        initalStreamingOptions,
                        cancellationToken);
                }
                catch (RequestFailedException ex) when (ex.ErrorCode == BlobErrorCode.InvalidRange)
                {
                    BlobDownloadStreamingOptions errorStreamingOptions = new BlobDownloadStreamingOptions
                    {
                        Conditions = conditions,
                        ProgressHandler = _progress,
                        IgnoreStrongConsistencyLock = _ignoreStrongConsistencyLock
                    };

                    initialResponse = _client.DownloadStreaming(
                        errorStreamingOptions,
                        cancellationToken);
                }

                // If the initial request returned no content (i.e., a 304),
                // we'll pass that back to the user immediately
                if (initialResponse.IsUnavailable())
                {
                    return initialResponse.GetRawResponse();
                }

                // Copy the first segment to the destination stream
                CopyTo(initialResponse, destination, cancellationToken);

                // If the first segment was the entire blob, we're finished now
                long initialLength = initialResponse.Value.Details.ContentLength;
                long totalLength = ParseRangeTotalLength(initialResponse.Value.Details.ContentRange);
                if (initialLength == totalLength)
                {
                    return initialResponse.GetRawResponse();
                }

                // Capture the etag from the first segment and construct
                // conditions to ensure the blob doesn't change while we're
                // downloading the remaining segments
                ETag etag = initialResponse.Value.Details.ETag;
                BlobRequestConditions conditionsWithEtag = conditions?.WithIfMatch(etag) ?? new BlobRequestConditions { IfMatch = etag };

                // Download each of the remaining ranges in the blob
                foreach (HttpRange httpRange in GetRanges(initialLength, totalLength))
                {
                    // Don't need to worry about 304s here because the ETag
                    // condition will turn into a 412 and throw a proper
                    // RequestFailedException
                    BlobDownloadStreamingOptions streamingOptions = new BlobDownloadStreamingOptions
                    {
                        Range = httpRange,
                        Conditions = conditionsWithEtag,
                        ProgressHandler = _progress,
                        IgnoreStrongConsistencyLock = _ignoreStrongConsistencyLock
                    };

                    Response<BlobDownloadStreamingResult> result = _client.DownloadStreaming(
                        streamingOptions,
                        cancellationToken);
                    CopyTo(result.Value, destination, cancellationToken);
                }

                return initialResponse.GetRawResponse();
            }
            catch (Exception ex)
            {
                scope.Failed(ex);
                throw;
            }
            finally
            {
                scope.Dispose();
            }
        }

        private static long ParseRangeTotalLength(string range)
        {
            if (range == null)
            {
                return 0;
            }
            int lengthSeparator = range.IndexOf("/", StringComparison.InvariantCultureIgnoreCase);
            if (lengthSeparator == -1)
            {
                throw BlobErrors.ParsingFullHttpRangeFailed(range);
            }
            return long.Parse(range.Substring(lengthSeparator + 1), CultureInfo.InvariantCulture);
        }

        private static async Task CopyToAsync(
            BlobDownloadStreamingResult result,
            Stream destination,
            CancellationToken cancellationToken)
        {
            CancellationHelper.ThrowIfCancellationRequested(cancellationToken);
            using Stream source = result.Content;

            await source.CopyToAsync(
                destination,
                Constants.DefaultDownloadCopyBufferSize,
                cancellationToken)
                .ConfigureAwait(false);
        }

        private static void CopyTo(
            BlobDownloadStreamingResult result,
            Stream destination,
            CancellationToken cancellationToken)
        {
            CancellationHelper.ThrowIfCancellationRequested(cancellationToken);
            using Stream source = result.Content;

            source.CopyTo(
                destination,
                Constants.DefaultDownloadCopyBufferSize);
        }

        private IEnumerable<HttpRange> GetRanges(long initialLength, long totalLength)
        {
            for (long offset = initialLength; offset < totalLength; offset += _rangeSize)
            {
                yield return new HttpRange(offset, Math.Min(totalLength - offset, _rangeSize));
            }
        }
    }
}
