// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Cdn.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Cdn
{
    public partial class AfdOriginGroupData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(LoadBalancingSettings))
            {
                writer.WritePropertyName("loadBalancingSettings");
                writer.WriteObjectValue(LoadBalancingSettings);
            }
            if (Optional.IsDefined(HealthProbeSettings))
            {
                writer.WritePropertyName("healthProbeSettings");
                writer.WriteObjectValue(HealthProbeSettings);
            }
            if (Optional.IsDefined(TrafficRestorationTimeInMinutes))
            {
                if (TrafficRestorationTimeInMinutes != null)
                {
                    writer.WritePropertyName("trafficRestorationTimeToHealedOrNewEndpointsInMinutes");
                    writer.WriteNumberValue(TrafficRestorationTimeInMinutes.Value);
                }
                else
                {
                    writer.WriteNull("trafficRestorationTimeToHealedOrNewEndpointsInMinutes");
                }
            }
            if (Optional.IsDefined(SessionAffinityState))
            {
                writer.WritePropertyName("sessionAffinityState");
                writer.WriteStringValue(SessionAffinityState.Value.ToString());
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static AfdOriginGroupData DeserializeAfdOriginGroupData(JsonElement element)
        {
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            Optional<string> profileName = default;
            Optional<LoadBalancingSettings> loadBalancingSettings = default;
            Optional<HealthProbeSettings> healthProbeSettings = default;
            Optional<int?> trafficRestorationTimeToHealedOrNewEndpointsInMinutes = default;
            Optional<EnabledState> sessionAffinityState = default;
            Optional<AfdProvisioningState> provisioningState = default;
            Optional<AfdDeploymentStatus> deploymentStatus = default;
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
                        if (property0.NameEquals("profileName"))
                        {
                            profileName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("loadBalancingSettings"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            loadBalancingSettings = LoadBalancingSettings.DeserializeLoadBalancingSettings(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("healthProbeSettings"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            healthProbeSettings = HealthProbeSettings.DeserializeHealthProbeSettings(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("trafficRestorationTimeToHealedOrNewEndpointsInMinutes"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                trafficRestorationTimeToHealedOrNewEndpointsInMinutes = null;
                                continue;
                            }
                            trafficRestorationTimeToHealedOrNewEndpointsInMinutes = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("sessionAffinityState"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            sessionAffinityState = new EnabledState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            provisioningState = new AfdProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("deploymentStatus"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            deploymentStatus = new AfdDeploymentStatus(property0.Value.GetString());
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new AfdOriginGroupData(id, name, type, systemData, profileName.Value, loadBalancingSettings.Value, healthProbeSettings.Value, Optional.ToNullable(trafficRestorationTimeToHealedOrNewEndpointsInMinutes), Optional.ToNullable(sessionAffinityState), Optional.ToNullable(provisioningState), Optional.ToNullable(deploymentStatus));
        }
    }
}
