// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataFactory.Models
{
    public partial class TarGZipReadSettings : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(PreserveCompressionFileNameAsFolder))
            {
                writer.WritePropertyName("preserveCompressionFileNameAsFolder");
#if NET6_0_OR_GREATER
				writer.WriteRawValue(PreserveCompressionFileNameAsFolder);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(PreserveCompressionFileNameAsFolder.ToString()).RootElement);
#endif
            }
            writer.WritePropertyName("type");
            writer.WriteStringValue(CompressionReadSettingsType);
            foreach (var item in AdditionalProperties)
            {
                writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(item.Value.ToString()).RootElement);
#endif
            }
            writer.WriteEndObject();
        }

        internal static TarGZipReadSettings DeserializeTarGZipReadSettings(JsonElement element)
        {
            Optional<BinaryData> preserveCompressionFileNameAsFolder = default;
            string type = default;
            IDictionary<string, BinaryData> additionalProperties = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("preserveCompressionFileNameAsFolder"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    preserveCompressionFileNameAsFolder = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
            }
            additionalProperties = additionalPropertiesDictionary;
            return new TarGZipReadSettings(type, additionalProperties, preserveCompressionFileNameAsFolder.Value);
        }
    }
}
