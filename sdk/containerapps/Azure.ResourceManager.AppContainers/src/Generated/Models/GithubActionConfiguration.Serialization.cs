// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppContainers.Models
{
    public partial class GithubActionConfiguration : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(RegistryInfo))
            {
                writer.WritePropertyName("registryInfo");
                writer.WriteObjectValue(RegistryInfo);
            }
            if (Optional.IsDefined(AzureCredentials))
            {
                writer.WritePropertyName("azureCredentials");
                writer.WriteObjectValue(AzureCredentials);
            }
            if (Optional.IsDefined(ContextPath))
            {
                writer.WritePropertyName("contextPath");
                writer.WriteStringValue(ContextPath);
            }
            if (Optional.IsDefined(Image))
            {
                writer.WritePropertyName("image");
                writer.WriteStringValue(Image);
            }
            if (Optional.IsDefined(PublishType))
            {
                writer.WritePropertyName("publishType");
                writer.WriteStringValue(PublishType);
            }
            if (Optional.IsDefined(OS))
            {
                writer.WritePropertyName("os");
                writer.WriteStringValue(OS);
            }
            if (Optional.IsDefined(RuntimeStack))
            {
                writer.WritePropertyName("runtimeStack");
                writer.WriteStringValue(RuntimeStack);
            }
            if (Optional.IsDefined(RuntimeVersion))
            {
                writer.WritePropertyName("runtimeVersion");
                writer.WriteStringValue(RuntimeVersion);
            }
            writer.WriteEndObject();
        }

        internal static GithubActionConfiguration DeserializeGithubActionConfiguration(JsonElement element)
        {
            Optional<RegistryInfo> registryInfo = default;
            Optional<AzureCredentials> azureCredentials = default;
            Optional<string> contextPath = default;
            Optional<string> image = default;
            Optional<string> publishType = default;
            Optional<string> os = default;
            Optional<string> runtimeStack = default;
            Optional<string> runtimeVersion = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("registryInfo"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    registryInfo = RegistryInfo.DeserializeRegistryInfo(property.Value);
                    continue;
                }
                if (property.NameEquals("azureCredentials"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    azureCredentials = AzureCredentials.DeserializeAzureCredentials(property.Value);
                    continue;
                }
                if (property.NameEquals("contextPath"))
                {
                    contextPath = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("image"))
                {
                    image = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("publishType"))
                {
                    publishType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("os"))
                {
                    os = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("runtimeStack"))
                {
                    runtimeStack = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("runtimeVersion"))
                {
                    runtimeVersion = property.Value.GetString();
                    continue;
                }
            }
            return new GithubActionConfiguration(registryInfo.Value, azureCredentials.Value, contextPath.Value, image.Value, publishType.Value, os.Value, runtimeStack.Value, runtimeVersion.Value);
        }
    }
}
