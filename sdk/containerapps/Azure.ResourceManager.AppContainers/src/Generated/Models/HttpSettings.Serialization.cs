// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppContainers.Models
{
    public partial class HttpSettings : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(RequireHttps))
            {
                writer.WritePropertyName("requireHttps");
                writer.WriteBooleanValue(RequireHttps.Value);
            }
            if (Optional.IsDefined(Routes))
            {
                writer.WritePropertyName("routes");
                writer.WriteObjectValue(Routes);
            }
            if (Optional.IsDefined(ForwardProxy))
            {
                writer.WritePropertyName("forwardProxy");
                writer.WriteObjectValue(ForwardProxy);
            }
            writer.WriteEndObject();
        }

        internal static HttpSettings DeserializeHttpSettings(JsonElement element)
        {
            Optional<bool> requireHttps = default;
            Optional<HttpSettingsRoutes> routes = default;
            Optional<ForwardProxy> forwardProxy = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("requireHttps"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    requireHttps = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("routes"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    routes = HttpSettingsRoutes.DeserializeHttpSettingsRoutes(property.Value);
                    continue;
                }
                if (property.NameEquals("forwardProxy"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    forwardProxy = ForwardProxy.DeserializeForwardProxy(property.Value);
                    continue;
                }
            }
            return new HttpSettings(Optional.ToNullable(requireHttps), routes.Value, forwardProxy.Value);
        }
    }
}
