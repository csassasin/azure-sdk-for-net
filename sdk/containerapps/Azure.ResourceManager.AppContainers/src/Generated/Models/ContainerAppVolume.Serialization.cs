// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppContainers.Models
{
    public partial class ContainerAppVolume : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name");
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(StorageType))
            {
                writer.WritePropertyName("storageType");
                writer.WriteStringValue(StorageType.Value.ToString());
            }
            if (Optional.IsDefined(StorageName))
            {
                writer.WritePropertyName("storageName");
                writer.WriteStringValue(StorageName);
            }
            writer.WriteEndObject();
        }

        internal static ContainerAppVolume DeserializeContainerAppVolume(JsonElement element)
        {
            Optional<string> name = default;
            Optional<StorageType> storageType = default;
            Optional<string> storageName = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("storageType"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    storageType = new StorageType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("storageName"))
                {
                    storageName = property.Value.GetString();
                    continue;
                }
            }
            return new ContainerAppVolume(name.Value, Optional.ToNullable(storageType), storageName.Value);
        }
    }
}
