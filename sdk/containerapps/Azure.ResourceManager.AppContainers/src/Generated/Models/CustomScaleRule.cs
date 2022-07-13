// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.AppContainers.Models
{
    /// <summary> Container App container Custom scaling rule. </summary>
    public partial class CustomScaleRule
    {
        /// <summary> Initializes a new instance of CustomScaleRule. </summary>
        public CustomScaleRule()
        {
            Metadata = new ChangeTrackingDictionary<string, string>();
            Auth = new ChangeTrackingList<ContainerAppScaleRuleAuth>();
        }

        /// <summary> Initializes a new instance of CustomScaleRule. </summary>
        /// <param name="customScaleRuleType">
        /// Type of the custom scale rule
        /// eg: azure-servicebus, redis etc.
        /// </param>
        /// <param name="metadata"> Metadata properties to describe custom scale rule. </param>
        /// <param name="auth"> Authentication secrets for the custom scale rule. </param>
        internal CustomScaleRule(string customScaleRuleType, IDictionary<string, string> metadata, IList<ContainerAppScaleRuleAuth> auth)
        {
            CustomScaleRuleType = customScaleRuleType;
            Metadata = metadata;
            Auth = auth;
        }

        /// <summary>
        /// Type of the custom scale rule
        /// eg: azure-servicebus, redis etc.
        /// </summary>
        public string CustomScaleRuleType { get; set; }
        /// <summary> Metadata properties to describe custom scale rule. </summary>
        public IDictionary<string, string> Metadata { get; }
        /// <summary> Authentication secrets for the custom scale rule. </summary>
        public IList<ContainerAppScaleRuleAuth> Auth { get; }
    }
}
