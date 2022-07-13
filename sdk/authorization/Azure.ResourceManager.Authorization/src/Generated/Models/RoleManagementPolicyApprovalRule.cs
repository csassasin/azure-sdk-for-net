// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;

namespace Azure.ResourceManager.Authorization.Models
{
    /// <summary> The role management policy approval rule. </summary>
    public partial class RoleManagementPolicyApprovalRule : RoleManagementPolicyRule
    {
        /// <summary> Initializes a new instance of RoleManagementPolicyApprovalRule. </summary>
        public RoleManagementPolicyApprovalRule()
        {
            RuleType = RoleManagementPolicyRuleType.RoleManagementPolicyApprovalRule;
        }

        /// <summary> Initializes a new instance of RoleManagementPolicyApprovalRule. </summary>
        /// <param name="id"> The id of the rule. </param>
        /// <param name="ruleType"> The type of rule. </param>
        /// <param name="target"> The target of the current rule. </param>
        /// <param name="setting"> The approval setting. </param>
        internal RoleManagementPolicyApprovalRule(ResourceIdentifier id, RoleManagementPolicyRuleType ruleType, RoleManagementPolicyRuleTarget target, ApprovalSettings setting) : base(id, ruleType, target)
        {
            Setting = setting;
            RuleType = ruleType;
        }

        /// <summary> The approval setting. </summary>
        public ApprovalSettings Setting { get; set; }
    }
}
