// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> Mutable online endpoint configuration. </summary>
    public partial class PartialOnlineEndpoint
    {
        /// <summary> Initializes a new instance of PartialOnlineEndpoint. </summary>
        public PartialOnlineEndpoint()
        {
            MirrorTraffic = new ChangeTrackingDictionary<string, int>();
            Traffic = new ChangeTrackingDictionary<string, int>();
        }

        /// <summary> Percentage of traffic to be mirrored to each deployment without using returned scoring. Traffic values need to sum to utmost 50. </summary>
        public IDictionary<string, int> MirrorTraffic { get; set; }
        /// <summary> Set to &quot;Enabled&quot; for endpoints that should allow public access when Private Link is enabled. </summary>
        public PublicNetworkAccessType? PublicNetworkAccess { get; set; }
        /// <summary> Percentage of traffic from endpoint to divert to each deployment. Traffic values need to sum to 100. </summary>
        public IDictionary<string, int> Traffic { get; set; }
    }
}
