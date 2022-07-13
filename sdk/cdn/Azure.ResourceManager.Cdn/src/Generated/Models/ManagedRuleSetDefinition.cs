// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> Describes a managed rule set definition. </summary>
    public partial class ManagedRuleSetDefinition : ResourceData
    {
        /// <summary> Initializes a new instance of ManagedRuleSetDefinition. </summary>
        public ManagedRuleSetDefinition()
        {
            RuleGroups = new ChangeTrackingList<ManagedRuleGroupDefinition>();
        }

        /// <summary> Initializes a new instance of ManagedRuleSetDefinition. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="sku"> The pricing tier (defines a CDN provider, feature list and rate) of the CdnWebApplicationFirewallPolicy. </param>
        /// <param name="provisioningState"> Provisioning state of the managed rule set. </param>
        /// <param name="ruleSetType"> Type of the managed rule set. </param>
        /// <param name="ruleSetVersion"> Version of the managed rule set type. </param>
        /// <param name="ruleGroups"> Rule groups of the managed rule set. </param>
        internal ManagedRuleSetDefinition(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, CdnSku sku, string provisioningState, string ruleSetType, string ruleSetVersion, IReadOnlyList<ManagedRuleGroupDefinition> ruleGroups) : base(id, name, resourceType, systemData)
        {
            Sku = sku;
            ProvisioningState = provisioningState;
            RuleSetType = ruleSetType;
            RuleSetVersion = ruleSetVersion;
            RuleGroups = ruleGroups;
        }

        /// <summary> The pricing tier (defines a CDN provider, feature list and rate) of the CdnWebApplicationFirewallPolicy. </summary>
        internal CdnSku Sku { get; set; }
        /// <summary> Name of the pricing tier. </summary>
        public CdnSkuName? SkuName
        {
            get => Sku is null ? default : Sku.Name;
            set
            {
                if (Sku is null)
                    Sku = new CdnSku();
                Sku.Name = value;
            }
        }

        /// <summary> Provisioning state of the managed rule set. </summary>
        public string ProvisioningState { get; }
        /// <summary> Type of the managed rule set. </summary>
        public string RuleSetType { get; }
        /// <summary> Version of the managed rule set type. </summary>
        public string RuleSetVersion { get; }
        /// <summary> Rule groups of the managed rule set. </summary>
        public IReadOnlyList<ManagedRuleGroupDefinition> RuleGroups { get; }
    }
}
