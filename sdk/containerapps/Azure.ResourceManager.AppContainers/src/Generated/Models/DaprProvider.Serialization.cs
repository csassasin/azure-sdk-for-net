// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppContainers.Models
{
    public partial class DaprProvider : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Enabled))
            {
                writer.WritePropertyName("enabled");
                writer.WriteBooleanValue(Enabled.Value);
            }
            if (Optional.IsDefined(AppId))
            {
                writer.WritePropertyName("appId");
                writer.WriteStringValue(AppId);
            }
            if (Optional.IsDefined(AppProtocol))
            {
                writer.WritePropertyName("appProtocol");
                writer.WriteStringValue(AppProtocol.Value.ToString());
            }
            if (Optional.IsDefined(AppPort))
            {
                writer.WritePropertyName("appPort");
                writer.WriteNumberValue(AppPort.Value);
            }
            writer.WriteEndObject();
        }

        internal static DaprProvider DeserializeDaprProvider(JsonElement element)
        {
            Optional<bool> enabled = default;
            Optional<string> appId = default;
            Optional<AppProtocol> appProtocol = default;
            Optional<int> appPort = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("enabled"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    enabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("appId"))
                {
                    appId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("appProtocol"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    appProtocol = new AppProtocol(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("appPort"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    appPort = property.Value.GetInt32();
                    continue;
                }
            }
            return new DaprProvider(Optional.ToNullable(enabled), appId.Value, Optional.ToNullable(appProtocol), Optional.ToNullable(appPort));
        }
    }
}
