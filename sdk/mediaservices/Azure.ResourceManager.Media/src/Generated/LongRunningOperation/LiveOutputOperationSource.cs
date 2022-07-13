// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager;

namespace Azure.ResourceManager.Media
{
    internal class LiveOutputOperationSource : IOperationSource<LiveOutputResource>
    {
        private readonly ArmClient _client;

        internal LiveOutputOperationSource(ArmClient client)
        {
            _client = client;
        }

        LiveOutputResource IOperationSource<LiveOutputResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = LiveOutputData.DeserializeLiveOutputData(document.RootElement);
            return new LiveOutputResource(_client, data);
        }

        async ValueTask<LiveOutputResource> IOperationSource<LiveOutputResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = LiveOutputData.DeserializeLiveOutputData(document.RootElement);
            return new LiveOutputResource(_client, data);
        }
    }
}
