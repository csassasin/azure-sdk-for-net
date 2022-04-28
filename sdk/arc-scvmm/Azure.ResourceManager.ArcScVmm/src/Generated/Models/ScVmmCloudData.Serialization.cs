// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.ArcScVmm.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.ArcScVmm
{
    public partial class ScVmmCloudData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("extendedLocation");
            writer.WriteObjectValue(ExtendedLocation);
            writer.WritePropertyName("tags");
            writer.WriteStartObject();
            foreach (var item in Tags)
            {
                writer.WritePropertyName(item.Key);
                writer.WriteStringValue(item.Value);
            }
            writer.WriteEndObject();
            writer.WritePropertyName("location");
            writer.WriteStringValue(Location);
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(InventoryItemId))
            {
                writer.WritePropertyName("inventoryItemId");
                writer.WriteStringValue(InventoryItemId);
            }
            if (Optional.IsDefined(Uuid))
            {
                writer.WritePropertyName("uuid");
                writer.WriteStringValue(Uuid);
            }
            if (Optional.IsDefined(VmmServerId))
            {
                writer.WritePropertyName("vmmServerId");
                writer.WriteStringValue(VmmServerId);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static ScVmmCloudData DeserializeScVmmCloudData(JsonElement element)
        {
            ExtendedLocation extendedLocation = default;
            IDictionary<string, string> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            Optional<string> inventoryItemId = default;
            Optional<string> uuid = default;
            Optional<string> vmmServerId = default;
            Optional<string> cloudName = default;
            Optional<CloudCapacity> cloudCapacity = default;
            Optional<IReadOnlyList<StorageQoSPolicy>> storageQoSPolicies = default;
            Optional<string> provisioningState = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("extendedLocation"))
                {
                    extendedLocation = ExtendedLocation.DeserializeExtendedLocation(property.Value);
                    continue;
                }
                if (property.NameEquals("tags"))
                {
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("location"))
                {
                    location = property.Value.GetString();
                    continue;
                }
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
                        if (property0.NameEquals("inventoryItemId"))
                        {
                            inventoryItemId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("uuid"))
                        {
                            uuid = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("vmmServerId"))
                        {
                            vmmServerId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("cloudName"))
                        {
                            cloudName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("cloudCapacity"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            cloudCapacity = CloudCapacity.DeserializeCloudCapacity(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("storageQoSPolicies"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<StorageQoSPolicy> array = new List<StorageQoSPolicy>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(StorageQoSPolicy.DeserializeStorageQoSPolicy(item));
                            }
                            storageQoSPolicies = array;
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"))
                        {
                            provisioningState = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new ScVmmCloudData(id, name, type, systemData, tags, location, extendedLocation, inventoryItemId.Value, uuid.Value, vmmServerId.Value, cloudName.Value, cloudCapacity.Value, Optional.ToList(storageQoSPolicies), provisioningState.Value);
        }
    }
}
