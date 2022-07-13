// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Network.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Network
{
    /// <summary> A class representing the CustomIPPrefix data model. </summary>
    public partial class CustomIPPrefixData : NetworkTrackedResourceData
    {
        /// <summary> Initializes a new instance of CustomIPPrefixData. </summary>
        public CustomIPPrefixData()
        {
            Zones = new ChangeTrackingList<string>();
            ChildCustomIPPrefixes = new ChangeTrackingList<CustomIPPrefixData>();
            PublicIPPrefixes = new ChangeTrackingList<WritableSubResource>();
        }

        /// <summary> Initializes a new instance of CustomIPPrefixData. </summary>
        /// <param name="id"> Resource ID. </param>
        /// <param name="name"> Resource name. </param>
        /// <param name="resourceType"> Resource type. </param>
        /// <param name="location"> Resource location. </param>
        /// <param name="tags"> Resource tags. </param>
        /// <param name="extendedLocation"> The extended location of the custom IP prefix. </param>
        /// <param name="etag"> A unique read-only string that changes whenever the resource is updated. </param>
        /// <param name="zones"> A list of availability zones denoting the IP allocated for the resource needs to come from. </param>
        /// <param name="cidr"> The prefix range in CIDR notation. Should include the start address and the prefix length. </param>
        /// <param name="signedMessage"> Signed message for WAN validation. </param>
        /// <param name="authorizationMessage"> Authorization message for WAN validation. </param>
        /// <param name="customIPPrefixParent"> The Parent CustomIpPrefix for IPv6 /64 CustomIpPrefix. </param>
        /// <param name="childCustomIPPrefixes"> The list of all Children for IPv6 /48 CustomIpPrefix. </param>
        /// <param name="commissionedState"> The commissioned state of the Custom IP Prefix. </param>
        /// <param name="publicIPPrefixes"> The list of all referenced PublicIpPrefixes. </param>
        /// <param name="resourceGuid"> The resource GUID property of the custom IP prefix resource. </param>
        /// <param name="failedReason"> The reason why resource is in failed state. </param>
        /// <param name="provisioningState"> The provisioning state of the custom IP prefix resource. </param>
        internal CustomIPPrefixData(ResourceIdentifier id, string name, ResourceType? resourceType, AzureLocation? location, IDictionary<string, string> tags, ExtendedLocation extendedLocation, ETag? etag, IList<string> zones, string cidr, string signedMessage, string authorizationMessage, CustomIPPrefixData customIPPrefixParent, IReadOnlyList<CustomIPPrefixData> childCustomIPPrefixes, CommissionedState? commissionedState, IReadOnlyList<WritableSubResource> publicIPPrefixes, Guid? resourceGuid, string failedReason, NetworkProvisioningState? provisioningState) : base(id, name, resourceType, location, tags)
        {
            ExtendedLocation = extendedLocation;
            ETag = etag;
            Zones = zones;
            Cidr = cidr;
            SignedMessage = signedMessage;
            AuthorizationMessage = authorizationMessage;
            CustomIPPrefixParent = customIPPrefixParent;
            ChildCustomIPPrefixes = childCustomIPPrefixes;
            CommissionedState = commissionedState;
            PublicIPPrefixes = publicIPPrefixes;
            ResourceGuid = resourceGuid;
            FailedReason = failedReason;
            ProvisioningState = provisioningState;
        }

        /// <summary> The extended location of the custom IP prefix. </summary>
        public ExtendedLocation ExtendedLocation { get; set; }
        /// <summary> A unique read-only string that changes whenever the resource is updated. </summary>
        public ETag? ETag { get; }
        /// <summary> A list of availability zones denoting the IP allocated for the resource needs to come from. </summary>
        public IList<string> Zones { get; }
        /// <summary> The prefix range in CIDR notation. Should include the start address and the prefix length. </summary>
        public string Cidr { get; set; }
        /// <summary> Signed message for WAN validation. </summary>
        public string SignedMessage { get; set; }
        /// <summary> Authorization message for WAN validation. </summary>
        public string AuthorizationMessage { get; set; }
        /// <summary> The Parent CustomIpPrefix for IPv6 /64 CustomIpPrefix. </summary>
        public CustomIPPrefixData CustomIPPrefixParent { get; set; }
        /// <summary> The list of all Children for IPv6 /48 CustomIpPrefix. </summary>
        public IReadOnlyList<CustomIPPrefixData> ChildCustomIPPrefixes { get; }
        /// <summary> The commissioned state of the Custom IP Prefix. </summary>
        public CommissionedState? CommissionedState { get; set; }
        /// <summary> The list of all referenced PublicIpPrefixes. </summary>
        public IReadOnlyList<WritableSubResource> PublicIPPrefixes { get; }
        /// <summary> The resource GUID property of the custom IP prefix resource. </summary>
        public Guid? ResourceGuid { get; }
        /// <summary> The reason why resource is in failed state. </summary>
        public string FailedReason { get; }
        /// <summary> The provisioning state of the custom IP prefix resource. </summary>
        public NetworkProvisioningState? ProvisioningState { get; }
    }
}
