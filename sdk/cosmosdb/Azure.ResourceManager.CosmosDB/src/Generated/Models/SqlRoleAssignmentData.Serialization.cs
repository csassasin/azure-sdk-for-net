// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.CosmosDB
{
    public partial class SqlRoleAssignmentData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(RoleDefinitionId))
            {
                writer.WritePropertyName("roleDefinitionId");
                writer.WriteStringValue(RoleDefinitionId);
            }
            if (Optional.IsDefined(Scope))
            {
                writer.WritePropertyName("scope");
                writer.WriteStringValue(Scope);
            }
            if (Optional.IsDefined(PrincipalId))
            {
                writer.WritePropertyName("principalId");
                writer.WriteStringValue(PrincipalId);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static SqlRoleAssignmentData DeserializeSqlRoleAssignmentData(JsonElement element)
        {
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            Optional<string> roleDefinitionId = default;
            Optional<string> scope = default;
            Optional<string> principalId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("systemData"))
                {
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.ToString());
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("roleDefinitionId"))
                        {
                            roleDefinitionId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("scope"))
                        {
                            scope = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("principalId"))
                        {
                            principalId = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new SqlRoleAssignmentData(id, name, type, systemData, roleDefinitionId.Value, scope.Value, principalId.Value);
        }
    }
}
