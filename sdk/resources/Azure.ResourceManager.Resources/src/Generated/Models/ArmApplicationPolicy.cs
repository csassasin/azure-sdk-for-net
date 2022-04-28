// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Resources.Models
{
    /// <summary> Managed application policy. </summary>
    public partial class ArmApplicationPolicy
    {
        /// <summary> Initializes a new instance of ArmApplicationPolicy. </summary>
        public ArmApplicationPolicy()
        {
        }

        /// <summary> Initializes a new instance of ArmApplicationPolicy. </summary>
        /// <param name="name"> The policy name. </param>
        /// <param name="policyDefinitionId"> The policy definition Id. </param>
        /// <param name="parameters"> The policy parameters. </param>
        internal ArmApplicationPolicy(string name, string policyDefinitionId, string parameters)
        {
            Name = name;
            PolicyDefinitionId = policyDefinitionId;
            Parameters = parameters;
        }

        /// <summary> The policy name. </summary>
        public string Name { get; set; }
        /// <summary> The policy definition Id. </summary>
        public string PolicyDefinitionId { get; set; }
        /// <summary> The policy parameters. </summary>
        public string Parameters { get; set; }
    }
}
