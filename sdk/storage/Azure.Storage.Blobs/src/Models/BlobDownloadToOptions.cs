﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.IO;

namespace Azure.Storage.Blobs.Models
{
    /// <summary>
    /// Options for reading a blob to a destination.
    /// </summary>
    public class BlobDownloadToOptions
    {
        /// <summary>
        /// Request conditions for downloading.
        /// </summary>
        public BlobRequestConditions Conditions { get; set; }

        /// <summary>
        /// Progress handler for tracking download progress.
        /// </summary>
        public IProgress<long> ProgressHandler { get; set; }

        /// <summary>
        /// Transfer options for managing individual read requests.
        /// </summary>
        public StorageTransferOptions TransferOptions { get; set; }

        // TODO #27253
        ///// <summary>
        ///// Transactional hashing options for data integrity checks.
        ///// </summary>
        //public DownloadTransactionalHashingOptions TransactionalHashingOptions { get; set; }

        /// <summary>
        /// Geo-redundant (GRS) and Geo-zone-redundant (GZRS) storage accounts only.
        /// Allows client to override replication lock for read operations.
        /// </summary>
        public bool? IgnoreStrongConsistencyLock { get; set; }
    }
}
