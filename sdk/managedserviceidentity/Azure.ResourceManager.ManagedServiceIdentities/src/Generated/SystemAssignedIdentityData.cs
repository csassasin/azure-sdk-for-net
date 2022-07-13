// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.ManagedServiceIdentities
{
    /// <summary> A class representing the SystemAssignedIdentity data model. </summary>
    public partial class SystemAssignedIdentityData : TrackedResourceData
    {
        /// <summary> Initializes a new instance of SystemAssignedIdentityData. </summary>
        /// <param name="location"> The location. </param>
        public SystemAssignedIdentityData(AzureLocation location) : base(location)
        {
        }

        /// <summary> Initializes a new instance of SystemAssignedIdentityData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="tenantId"> The id of the tenant which the identity belongs to. </param>
        /// <param name="principalId"> The id of the service principal object associated with the created identity. </param>
        /// <param name="clientId"> The id of the app associated with the identity. This is a random generated UUID by MSI. </param>
        /// <param name="clientSecretUri"> The ManagedServiceIdentity DataPlane URL that can be queried to obtain the identity credentials. </param>
        internal SystemAssignedIdentityData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, Guid? tenantId, Guid? principalId, Guid? clientId, Uri clientSecretUri) : base(id, name, resourceType, systemData, tags, location)
        {
            TenantId = tenantId;
            PrincipalId = principalId;
            ClientId = clientId;
            ClientSecretUri = clientSecretUri;
        }

        /// <summary> The id of the tenant which the identity belongs to. </summary>
        public Guid? TenantId { get; }
        /// <summary> The id of the service principal object associated with the created identity. </summary>
        public Guid? PrincipalId { get; }
        /// <summary> The id of the app associated with the identity. This is a random generated UUID by MSI. </summary>
        public Guid? ClientId { get; }
        /// <summary> The ManagedServiceIdentity DataPlane URL that can be queried to obtain the identity credentials. </summary>
        public Uri ClientSecretUri { get; }
    }
}
