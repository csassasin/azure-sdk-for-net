// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.AppService.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppService
{
    public partial class NetworkFeaturesData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Kind))
            {
                writer.WritePropertyName("kind");
                writer.WriteStringValue(Kind);
            }
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static NetworkFeaturesData DeserializeNetworkFeaturesData(JsonElement element)
        {
            Optional<string> kind = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            Optional<string> virtualNetworkName = default;
            Optional<VnetInfo> virtualNetworkConnection = default;
            Optional<IReadOnlyList<RelayServiceConnectionEntityData>> hybridConnections = default;
            Optional<IReadOnlyList<HybridConnectionData>> hybridConnectionsV2 = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kind"))
                {
                    kind = property.Value.GetString();
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
                    type = new ResourceType(property.Value.GetString());
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
                        if (property0.NameEquals("virtualNetworkName"))
                        {
                            virtualNetworkName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("virtualNetworkConnection"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            virtualNetworkConnection = VnetInfo.DeserializeVnetInfo(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("hybridConnections"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<RelayServiceConnectionEntityData> array = new List<RelayServiceConnectionEntityData>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(RelayServiceConnectionEntityData.DeserializeRelayServiceConnectionEntityData(item));
                            }
                            hybridConnections = array;
                            continue;
                        }
                        if (property0.NameEquals("hybridConnectionsV2"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<HybridConnectionData> array = new List<HybridConnectionData>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(HybridConnectionData.DeserializeHybridConnectionData(item));
                            }
                            hybridConnectionsV2 = array;
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new NetworkFeaturesData(id, name, type, systemData, kind.Value, virtualNetworkName.Value, virtualNetworkConnection.Value, Optional.ToList(hybridConnections), Optional.ToList(hybridConnectionsV2));
        }
    }
}
