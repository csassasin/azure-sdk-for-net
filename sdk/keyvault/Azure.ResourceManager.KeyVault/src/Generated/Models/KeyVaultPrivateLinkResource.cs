// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.KeyVault.Models
{
    /// <summary> A private link resource. </summary>
    public partial class KeyVaultPrivateLinkResource : KeyVaultResourceData
    {
        /// <summary> Initializes a new instance of KeyVaultPrivateLinkResource. </summary>
        public KeyVaultPrivateLinkResource()
        {
            RequiredMembers = new ChangeTrackingList<string>();
            RequiredZoneNames = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of KeyVaultPrivateLinkResource. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="location"> Azure location of the key vault resource. </param>
        /// <param name="tags"> Tags assigned to the key vault resource. </param>
        /// <param name="groupId"> Group identifier of private link resource. </param>
        /// <param name="requiredMembers"> Required member names of private link resource. </param>
        /// <param name="requiredZoneNames"> Required DNS zone names of the the private link resource. </param>
        internal KeyVaultPrivateLinkResource(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, AzureLocation? location, IReadOnlyDictionary<string, string> tags, string groupId, IReadOnlyList<string> requiredMembers, IList<string> requiredZoneNames) : base(id, name, resourceType, systemData, location, tags)
        {
            GroupId = groupId;
            RequiredMembers = requiredMembers;
            RequiredZoneNames = requiredZoneNames;
        }

        /// <summary> Group identifier of private link resource. </summary>
        public string GroupId { get; }
        /// <summary> Required member names of private link resource. </summary>
        public IReadOnlyList<string> RequiredMembers { get; }
        /// <summary> Required DNS zone names of the the private link resource. </summary>
        public IList<string> RequiredZoneNames { get; }
    }
}
