// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Network.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The network manager effective connectivity configuration
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class EffectiveConnectivityConfiguration
    {
        /// <summary>
        /// Initializes a new instance of the
        /// EffectiveConnectivityConfiguration class.
        /// </summary>
        public EffectiveConnectivityConfiguration()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// EffectiveConnectivityConfiguration class.
        /// </summary>
        /// <param name="connectivityTopology">Connectivity topology type.
        /// Possible values include: 'HubAndSpoke', 'Mesh'</param>
        /// <param name="appliesToGroups">Groups for configuration</param>
        /// <param name="id">Resource ID.</param>
        /// <param name="description">A description of the connectivity
        /// configuration.</param>
        /// <param name="hubs">List of hubItems</param>
        /// <param name="isGlobal">Flag if global mesh is supported. Possible
        /// values include: 'False', 'True'</param>
        /// <param name="provisioningState">The provisioning state of the
        /// connectivity configuration resource. Possible values include:
        /// 'Succeeded', 'Updating', 'Deleting', 'Failed'</param>
        /// <param name="deleteExistingPeering">Flag if need to remove current
        /// existing peerings. Possible values include: 'False', 'True'</param>
        /// <param name="configurationGroups">Effective configuration
        /// groups.</param>
        public EffectiveConnectivityConfiguration(string connectivityTopology, IList<ConnectivityGroupItem> appliesToGroups, string id = default(string), string description = default(string), IList<Hub> hubs = default(IList<Hub>), string isGlobal = default(string), string provisioningState = default(string), string deleteExistingPeering = default(string), IList<ConfigurationGroup> configurationGroups = default(IList<ConfigurationGroup>))
        {
            Id = id;
            Description = description;
            ConnectivityTopology = connectivityTopology;
            Hubs = hubs;
            IsGlobal = isGlobal;
            AppliesToGroups = appliesToGroups;
            ProvisioningState = provisioningState;
            DeleteExistingPeering = deleteExistingPeering;
            ConfigurationGroups = configurationGroups;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets resource ID.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets a description of the connectivity configuration.
        /// </summary>
        [JsonProperty(PropertyName = "properties.description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets connectivity topology type. Possible values include:
        /// 'HubAndSpoke', 'Mesh'
        /// </summary>
        [JsonProperty(PropertyName = "properties.connectivityTopology")]
        public string ConnectivityTopology { get; set; }

        /// <summary>
        /// Gets or sets list of hubItems
        /// </summary>
        [JsonProperty(PropertyName = "properties.hubs")]
        public IList<Hub> Hubs { get; set; }

        /// <summary>
        /// Gets or sets flag if global mesh is supported. Possible values
        /// include: 'False', 'True'
        /// </summary>
        [JsonProperty(PropertyName = "properties.isGlobal")]
        public string IsGlobal { get; set; }

        /// <summary>
        /// Gets or sets groups for configuration
        /// </summary>
        [JsonProperty(PropertyName = "properties.appliesToGroups")]
        public IList<ConnectivityGroupItem> AppliesToGroups { get; set; }

        /// <summary>
        /// Gets the provisioning state of the connectivity configuration
        /// resource. Possible values include: 'Succeeded', 'Updating',
        /// 'Deleting', 'Failed'
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; private set; }

        /// <summary>
        /// Gets or sets flag if need to remove current existing peerings.
        /// Possible values include: 'False', 'True'
        /// </summary>
        [JsonProperty(PropertyName = "properties.deleteExistingPeering")]
        public string DeleteExistingPeering { get; set; }

        /// <summary>
        /// Gets or sets effective configuration groups.
        /// </summary>
        [JsonProperty(PropertyName = "configurationGroups")]
        public IList<ConfigurationGroup> ConfigurationGroups { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (ConnectivityTopology == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ConnectivityTopology");
            }
            if (AppliesToGroups == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "AppliesToGroups");
            }
            if (AppliesToGroups != null)
            {
                foreach (var element in AppliesToGroups)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
            if (ConfigurationGroups != null)
            {
                foreach (var element1 in ConfigurationGroups)
                {
                    if (element1 != null)
                    {
                        element1.Validate();
                    }
                }
            }
        }
    }
}
