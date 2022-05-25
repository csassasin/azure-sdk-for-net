// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Network.Models;

namespace Azure.ResourceManager.Network
{
    public partial class ConnectionMonitorData
    {
        internal static ConnectionMonitorData DeserializeConnectionMonitorData(JsonElement element)
        {
            Optional<string> etag = default;
            Optional<AzureLocation> location = default;
            Optional<IReadOnlyDictionary<string, string>> tags = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            Optional<ConnectionMonitorSource> source = default;
            Optional<ConnectionMonitorDestination> destination = default;
            Optional<bool> autoStart = default;
            Optional<int> monitoringIntervalInSeconds = default;
            Optional<IReadOnlyList<ConnectionMonitorEndpoint>> endpoints = default;
            Optional<IReadOnlyList<ConnectionMonitorTestConfiguration>> testConfigurations = default;
            Optional<IReadOnlyList<ConnectionMonitorTestGroup>> testGroups = default;
            Optional<IReadOnlyList<ConnectionMonitorOutput>> outputs = default;
            Optional<string> notes = default;
            Optional<NetworkProvisioningState> provisioningState = default;
            Optional<DateTimeOffset> startTime = default;
            Optional<string> monitoringStatus = default;
            Optional<ConnectionMonitorType> connectionMonitorType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("etag"))
                {
                    etag = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("location"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("tags"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
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
                        if (property0.NameEquals("source"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            source = ConnectionMonitorSource.DeserializeConnectionMonitorSource(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("destination"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            destination = ConnectionMonitorDestination.DeserializeConnectionMonitorDestination(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("autoStart"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            autoStart = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("monitoringIntervalInSeconds"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            monitoringIntervalInSeconds = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("endpoints"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<ConnectionMonitorEndpoint> array = new List<ConnectionMonitorEndpoint>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ConnectionMonitorEndpoint.DeserializeConnectionMonitorEndpoint(item));
                            }
                            endpoints = array;
                            continue;
                        }
                        if (property0.NameEquals("testConfigurations"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<ConnectionMonitorTestConfiguration> array = new List<ConnectionMonitorTestConfiguration>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ConnectionMonitorTestConfiguration.DeserializeConnectionMonitorTestConfiguration(item));
                            }
                            testConfigurations = array;
                            continue;
                        }
                        if (property0.NameEquals("testGroups"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<ConnectionMonitorTestGroup> array = new List<ConnectionMonitorTestGroup>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ConnectionMonitorTestGroup.DeserializeConnectionMonitorTestGroup(item));
                            }
                            testGroups = array;
                            continue;
                        }
                        if (property0.NameEquals("outputs"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<ConnectionMonitorOutput> array = new List<ConnectionMonitorOutput>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ConnectionMonitorOutput.DeserializeConnectionMonitorOutput(item));
                            }
                            outputs = array;
                            continue;
                        }
                        if (property0.NameEquals("notes"))
                        {
                            notes = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            provisioningState = new NetworkProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("startTime"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            startTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("monitoringStatus"))
                        {
                            monitoringStatus = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("connectionMonitorType"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            connectionMonitorType = new ConnectionMonitorType(property0.Value.GetString());
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new ConnectionMonitorData(id, name, type, systemData, etag.Value, Optional.ToNullable(location), Optional.ToDictionary(tags), source.Value, destination.Value, Optional.ToNullable(autoStart), Optional.ToNullable(monitoringIntervalInSeconds), Optional.ToList(endpoints), Optional.ToList(testConfigurations), Optional.ToList(testGroups), Optional.ToList(outputs), notes.Value, Optional.ToNullable(provisioningState), Optional.ToNullable(startTime), monitoringStatus.Value, Optional.ToNullable(connectionMonitorType));
        }
    }
}
