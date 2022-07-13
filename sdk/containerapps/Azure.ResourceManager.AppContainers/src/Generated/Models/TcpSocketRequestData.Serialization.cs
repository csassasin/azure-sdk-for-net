// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppContainers.Models
{
    public partial class TcpSocketRequestData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Host))
            {
                writer.WritePropertyName("host");
                writer.WriteStringValue(Host);
            }
            writer.WritePropertyName("port");
            writer.WriteNumberValue(Port);
            writer.WriteEndObject();
        }

        internal static TcpSocketRequestData DeserializeTcpSocketRequestData(JsonElement element)
        {
            Optional<string> host = default;
            int port = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("host"))
                {
                    host = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("port"))
                {
                    port = property.Value.GetInt32();
                    continue;
                }
            }
            return new TcpSocketRequestData(host.Value, port);
        }
    }
}
