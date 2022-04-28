// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.StoragePool.Models
{
    /// <summary> Request payload for create or update Disk Pool request. </summary>
    public partial class DiskPoolCreateOrUpdateContent : ResourceData
    {
        /// <summary> Initializes a new instance of DiskPoolCreateOrUpdateContent. </summary>
        /// <param name="sku"> Determines the SKU of the Disk Pool. </param>
        /// <param name="location"> The geo-location where the resource lives. </param>
        /// <param name="subnetId"> Azure Resource ID of a Subnet for the Disk Pool. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="sku"/>, <paramref name="location"/> or <paramref name="subnetId"/> is null. </exception>
        public DiskPoolCreateOrUpdateContent(StoragePoolSku sku, string location, string subnetId)
        {
            if (sku == null)
            {
                throw new ArgumentNullException(nameof(sku));
            }
            if (location == null)
            {
                throw new ArgumentNullException(nameof(location));
            }
            if (subnetId == null)
            {
                throw new ArgumentNullException(nameof(subnetId));
            }

            Sku = sku;
            Tags = new ChangeTrackingDictionary<string, string>();
            Location = location;
            ManagedByExtended = new ChangeTrackingList<string>();
            AvailabilityZones = new ChangeTrackingList<string>();
            Disks = new ChangeTrackingList<WritableSubResource>();
            SubnetId = subnetId;
            AdditionalCapabilities = new ChangeTrackingList<string>();
        }

        /// <summary> Determines the SKU of the Disk Pool. </summary>
        public StoragePoolSku Sku { get; }
        /// <summary> Resource tags. </summary>
        public IDictionary<string, string> Tags { get; }
        /// <summary> The geo-location where the resource lives. </summary>
        public string Location { get; }
        /// <summary> Azure resource id. Indicates if this resource is managed by another Azure resource. </summary>
        public string ManagedBy { get; set; }
        /// <summary> List of Azure resource ids that manage this resource. </summary>
        public IList<string> ManagedByExtended { get; }
        /// <summary> Logical zone for Disk Pool resource; example: [&quot;1&quot;]. </summary>
        public IList<string> AvailabilityZones { get; }
        /// <summary> List of Azure Managed Disks to attach to a Disk Pool. </summary>
        public IList<WritableSubResource> Disks { get; }
        /// <summary> Azure Resource ID of a Subnet for the Disk Pool. </summary>
        public string SubnetId { get; }
        /// <summary> List of additional capabilities for a Disk Pool. </summary>
        public IList<string> AdditionalCapabilities { get; }
    }
}
