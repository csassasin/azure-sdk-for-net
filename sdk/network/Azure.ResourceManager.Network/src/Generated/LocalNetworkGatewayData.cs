// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Network.Models;

namespace Azure.ResourceManager.Network
{
    /// <summary> A class representing the LocalNetworkGateway data model. </summary>
    public partial class LocalNetworkGatewayData : NetworkTrackedResourceData
    {
        /// <summary> Initializes a new instance of LocalNetworkGatewayData. </summary>
        public LocalNetworkGatewayData()
        {
        }

        /// <summary> Initializes a new instance of LocalNetworkGatewayData. </summary>
        /// <param name="id"> Resource ID. </param>
        /// <param name="name"> Resource name. </param>
        /// <param name="resourceType"> Resource type. </param>
        /// <param name="location"> Resource location. </param>
        /// <param name="tags"> Resource tags. </param>
        /// <param name="etag"> A unique read-only string that changes whenever the resource is updated. </param>
        /// <param name="localNetworkAddressSpace"> Local network site address space. </param>
        /// <param name="gatewayIPAddress"> IP address of local network gateway. </param>
        /// <param name="fqdn"> FQDN of local network gateway. </param>
        /// <param name="bgpSettings"> Local network gateway&apos;s BGP speaker settings. </param>
        /// <param name="resourceGuid"> The resource GUID property of the local network gateway resource. </param>
        /// <param name="provisioningState"> The provisioning state of the local network gateway resource. </param>
        internal LocalNetworkGatewayData(ResourceIdentifier id, string name, ResourceType? resourceType, AzureLocation? location, IDictionary<string, string> tags, string etag, AddressSpace localNetworkAddressSpace, string gatewayIPAddress, string fqdn, BgpSettings bgpSettings, Guid? resourceGuid, NetworkProvisioningState? provisioningState) : base(id, name, resourceType, location, tags)
        {
            Etag = etag;
            LocalNetworkAddressSpace = localNetworkAddressSpace;
            GatewayIPAddress = gatewayIPAddress;
            Fqdn = fqdn;
            BgpSettings = bgpSettings;
            ResourceGuid = resourceGuid;
            ProvisioningState = provisioningState;
        }

        /// <summary> A unique read-only string that changes whenever the resource is updated. </summary>
        public string Etag { get; }
        /// <summary> Local network site address space. </summary>
        internal AddressSpace LocalNetworkAddressSpace { get; set; }
        /// <summary> A list of address blocks reserved for this virtual network in CIDR notation. </summary>
        public IList<string> LocalNetworkAddressPrefixes
        {
            get
            {
                if (LocalNetworkAddressSpace is null)
                    LocalNetworkAddressSpace = new AddressSpace();
                return LocalNetworkAddressSpace.AddressPrefixes;
            }
        }

        /// <summary> IP address of local network gateway. </summary>
        public string GatewayIPAddress { get; set; }
        /// <summary> FQDN of local network gateway. </summary>
        public string Fqdn { get; set; }
        /// <summary> Local network gateway&apos;s BGP speaker settings. </summary>
        public BgpSettings BgpSettings { get; set; }
        /// <summary> The resource GUID property of the local network gateway resource. </summary>
        public Guid? ResourceGuid { get; }
        /// <summary> The provisioning state of the local network gateway resource. </summary>
        public NetworkProvisioningState? ProvisioningState { get; }
    }
}
