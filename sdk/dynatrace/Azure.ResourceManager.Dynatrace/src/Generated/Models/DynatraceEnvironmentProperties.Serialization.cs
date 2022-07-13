// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Dynatrace.Models
{
    public partial class DynatraceEnvironmentProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(UserId))
            {
                writer.WritePropertyName("userId");
                writer.WriteStringValue(UserId);
            }
            if (Optional.IsDefined(AccountInfo))
            {
                writer.WritePropertyName("accountInfo");
                writer.WriteObjectValue(AccountInfo);
            }
            if (Optional.IsDefined(EnvironmentInfo))
            {
                writer.WritePropertyName("environmentInfo");
                writer.WriteObjectValue(EnvironmentInfo);
            }
            if (Optional.IsDefined(SingleSignOnProperties))
            {
                writer.WritePropertyName("singleSignOnProperties");
                writer.WriteObjectValue(SingleSignOnProperties);
            }
            writer.WriteEndObject();
        }

        internal static DynatraceEnvironmentProperties DeserializeDynatraceEnvironmentProperties(JsonElement element)
        {
            Optional<string> userId = default;
            Optional<AccountInfo> accountInfo = default;
            Optional<EnvironmentInfo> environmentInfo = default;
            Optional<DynatraceSingleSignOnProperties> singleSignOnProperties = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("userId"))
                {
                    userId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("accountInfo"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    accountInfo = AccountInfo.DeserializeAccountInfo(property.Value);
                    continue;
                }
                if (property.NameEquals("environmentInfo"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    environmentInfo = EnvironmentInfo.DeserializeEnvironmentInfo(property.Value);
                    continue;
                }
                if (property.NameEquals("singleSignOnProperties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    singleSignOnProperties = DynatraceSingleSignOnProperties.DeserializeDynatraceSingleSignOnProperties(property.Value);
                    continue;
                }
            }
            return new DynatraceEnvironmentProperties(userId.Value, accountInfo.Value, environmentInfo.Value, singleSignOnProperties.Value);
        }
    }
}
