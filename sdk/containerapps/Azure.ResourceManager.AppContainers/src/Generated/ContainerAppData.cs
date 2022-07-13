// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.AppContainers.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppContainers
{
    /// <summary> A class representing the ContainerApp data model. </summary>
    public partial class ContainerAppData : TrackedResourceData
    {
        /// <summary> Initializes a new instance of ContainerAppData. </summary>
        /// <param name="location"> The location. </param>
        public ContainerAppData(AzureLocation location) : base(location)
        {
            OutboundIPAddresses = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of ContainerAppData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="identity"> managed identities for the Container App to interact with other Azure services without maintaining any secrets or credentials in code. </param>
        /// <param name="provisioningState"> Provisioning state of the Container App. </param>
        /// <param name="managedEnvironmentId"> Resource ID of the Container App&apos;s environment. </param>
        /// <param name="latestRevisionName"> Name of the latest revision of the Container App. </param>
        /// <param name="latestRevisionFqdn"> Fully Qualified Domain Name of the latest revision of the Container App. </param>
        /// <param name="customDomainVerificationId"> Id used to verify domain name ownership. </param>
        /// <param name="configuration"> Non versioned Container App configuration properties. </param>
        /// <param name="template"> Container App versioned application definition. </param>
        /// <param name="outboundIPAddresses"> Outbound IP Addresses for container app. </param>
        internal ContainerAppData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, ManagedServiceIdentity identity, ContainerAppProvisioningState? provisioningState, string managedEnvironmentId, string latestRevisionName, string latestRevisionFqdn, string customDomainVerificationId, ContainerAppConfiguration configuration, ContainerAppTemplate template, IReadOnlyList<string> outboundIPAddresses) : base(id, name, resourceType, systemData, tags, location)
        {
            Identity = identity;
            ProvisioningState = provisioningState;
            ManagedEnvironmentId = managedEnvironmentId;
            LatestRevisionName = latestRevisionName;
            LatestRevisionFqdn = latestRevisionFqdn;
            CustomDomainVerificationId = customDomainVerificationId;
            Configuration = configuration;
            Template = template;
            OutboundIPAddresses = outboundIPAddresses;
        }

        /// <summary> managed identities for the Container App to interact with other Azure services without maintaining any secrets or credentials in code. </summary>
        public ManagedServiceIdentity Identity { get; set; }
        /// <summary> Provisioning state of the Container App. </summary>
        public ContainerAppProvisioningState? ProvisioningState { get; }
        /// <summary> Resource ID of the Container App&apos;s environment. </summary>
        public string ManagedEnvironmentId { get; set; }
        /// <summary> Name of the latest revision of the Container App. </summary>
        public string LatestRevisionName { get; }
        /// <summary> Fully Qualified Domain Name of the latest revision of the Container App. </summary>
        public string LatestRevisionFqdn { get; }
        /// <summary> Id used to verify domain name ownership. </summary>
        public string CustomDomainVerificationId { get; }
        /// <summary> Non versioned Container App configuration properties. </summary>
        public ContainerAppConfiguration Configuration { get; set; }
        /// <summary> Container App versioned application definition. </summary>
        public ContainerAppTemplate Template { get; set; }
        /// <summary> Outbound IP Addresses for container app. </summary>
        public IReadOnlyList<string> OutboundIPAddresses { get; }
    }
}
