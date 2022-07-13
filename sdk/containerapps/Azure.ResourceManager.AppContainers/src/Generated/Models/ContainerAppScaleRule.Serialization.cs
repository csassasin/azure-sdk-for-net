// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppContainers.Models
{
    public partial class ContainerAppScaleRule : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name");
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(AzureQueue))
            {
                writer.WritePropertyName("azureQueue");
                writer.WriteObjectValue(AzureQueue);
            }
            if (Optional.IsDefined(Custom))
            {
                writer.WritePropertyName("custom");
                writer.WriteObjectValue(Custom);
            }
            if (Optional.IsDefined(Http))
            {
                writer.WritePropertyName("http");
                writer.WriteObjectValue(Http);
            }
            writer.WriteEndObject();
        }

        internal static ContainerAppScaleRule DeserializeContainerAppScaleRule(JsonElement element)
        {
            Optional<string> name = default;
            Optional<QueueScaleRule> azureQueue = default;
            Optional<CustomScaleRule> custom = default;
            Optional<HttpScaleRule> http = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("azureQueue"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    azureQueue = QueueScaleRule.DeserializeQueueScaleRule(property.Value);
                    continue;
                }
                if (property.NameEquals("custom"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    custom = CustomScaleRule.DeserializeCustomScaleRule(property.Value);
                    continue;
                }
                if (property.NameEquals("http"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    http = HttpScaleRule.DeserializeHttpScaleRule(property.Value);
                    continue;
                }
            }
            return new ContainerAppScaleRule(name.Value, azureQueue.Value, custom.Value, http.Value);
        }
    }
}
