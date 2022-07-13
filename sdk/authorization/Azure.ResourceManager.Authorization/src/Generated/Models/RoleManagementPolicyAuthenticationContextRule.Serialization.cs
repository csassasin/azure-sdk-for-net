// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Authorization.Models
{
    public partial class RoleManagementPolicyAuthenticationContextRule : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(IsEnabled))
            {
                writer.WritePropertyName("isEnabled");
                writer.WriteBooleanValue(IsEnabled.Value);
            }
            if (Optional.IsDefined(ClaimValue))
            {
                writer.WritePropertyName("claimValue");
                writer.WriteStringValue(ClaimValue);
            }
            if (Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id");
                writer.WriteStringValue(Id);
            }
            writer.WritePropertyName("ruleType");
            writer.WriteStringValue(RuleType.ToString());
            if (Optional.IsDefined(Target))
            {
                writer.WritePropertyName("target");
                writer.WriteObjectValue(Target);
            }
            writer.WriteEndObject();
        }

        internal static RoleManagementPolicyAuthenticationContextRule DeserializeRoleManagementPolicyAuthenticationContextRule(JsonElement element)
        {
            Optional<bool> isEnabled = default;
            Optional<string> claimValue = default;
            Optional<ResourceIdentifier> id = default;
            RoleManagementPolicyRuleType ruleType = default;
            Optional<RoleManagementPolicyRuleTarget> target = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("isEnabled"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    isEnabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("claimValue"))
                {
                    claimValue = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("ruleType"))
                {
                    ruleType = new RoleManagementPolicyRuleType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("target"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    target = RoleManagementPolicyRuleTarget.DeserializeRoleManagementPolicyRuleTarget(property.Value);
                    continue;
                }
            }
            return new RoleManagementPolicyAuthenticationContextRule(id.Value, ruleType, target.Value, Optional.ToNullable(isEnabled), claimValue.Value);
        }
    }
}
