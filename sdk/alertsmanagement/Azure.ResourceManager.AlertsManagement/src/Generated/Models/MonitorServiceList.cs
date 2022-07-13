// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.ResourceManager.AlertsManagement.Models
{
    /// <summary> Monitor service details. </summary>
    public partial class MonitorServiceList : ServiceAlertsMetaDataProperties
    {
        /// <summary> Initializes a new instance of MonitorServiceList. </summary>
        /// <param name="data"> Array of operations. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        internal MonitorServiceList(IEnumerable<MonitorServiceDetails> data)
        {
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }

            Data = data.ToList();
            MetadataIdentifier = ServiceAlertMetadataIdentifier.MonitorServiceList;
        }

        /// <summary> Initializes a new instance of MonitorServiceList. </summary>
        /// <param name="metadataIdentifier"> Identification of the information to be retrieved by API call. </param>
        /// <param name="data"> Array of operations. </param>
        internal MonitorServiceList(ServiceAlertMetadataIdentifier metadataIdentifier, IReadOnlyList<MonitorServiceDetails> data) : base(metadataIdentifier)
        {
            Data = data;
            MetadataIdentifier = metadataIdentifier;
        }

        /// <summary> Array of operations. </summary>
        public IReadOnlyList<MonitorServiceDetails> Data { get; }
    }
}
