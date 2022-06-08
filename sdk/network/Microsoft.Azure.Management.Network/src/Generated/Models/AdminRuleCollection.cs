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
    /// Defines the admin rule collection.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class AdminRuleCollection : ProxyResource
    {
        /// <summary>
        /// Initializes a new instance of the AdminRuleCollection class.
        /// </summary>
        public AdminRuleCollection()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AdminRuleCollection class.
        /// </summary>
        /// <param name="appliesToGroups">Groups for configuration</param>
        /// <param name="id">Resource ID.</param>
        /// <param name="name">Resource name.</param>
        /// <param name="type">Resource type.</param>
        /// <param name="etag">A unique read-only string that changes whenever
        /// the resource is updated.</param>
        /// <param name="description">A description of the admin rule
        /// collection.</param>
        /// <param name="provisioningState">The provisioning state of the
        /// resource. Possible values include: 'Succeeded', 'Updating',
        /// 'Deleting', 'Failed'</param>
        /// <param name="systemData">The system metadata related to this
        /// resource.</param>
        public AdminRuleCollection(IList<NetworkManagerSecurityGroupItem> appliesToGroups, string id = default(string), string name = default(string), string type = default(string), string etag = default(string), string description = default(string), string provisioningState = default(string), SystemData systemData = default(SystemData))
            : base(id, name, type, etag)
        {
            Description = description;
            AppliesToGroups = appliesToGroups;
            ProvisioningState = provisioningState;
            SystemData = systemData;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets a description of the admin rule collection.
        /// </summary>
        [JsonProperty(PropertyName = "properties.description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets groups for configuration
        /// </summary>
        [JsonProperty(PropertyName = "properties.appliesToGroups")]
        public IList<NetworkManagerSecurityGroupItem> AppliesToGroups { get; set; }

        /// <summary>
        /// Gets the provisioning state of the resource. Possible values
        /// include: 'Succeeded', 'Updating', 'Deleting', 'Failed'
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; private set; }

        /// <summary>
        /// Gets the system metadata related to this resource.
        /// </summary>
        [JsonProperty(PropertyName = "systemData")]
        public SystemData SystemData { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
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
        }
    }
}
