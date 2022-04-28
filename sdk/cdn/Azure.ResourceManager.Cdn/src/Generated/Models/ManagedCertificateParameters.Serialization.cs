// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Cdn.Models
{
    internal partial class ManagedCertificateParameters : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("type");
            writer.WriteStringValue(SecretType.ToString());
            writer.WriteEndObject();
        }

        internal static ManagedCertificateParameters DeserializeManagedCertificateParameters(JsonElement element)
        {
            Optional<string> subject = default;
            Optional<string> expirationDate = default;
            SecretType type = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("subject"))
                {
                    subject = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("expirationDate"))
                {
                    expirationDate = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = new SecretType(property.Value.GetString());
                    continue;
                }
            }
            return new ManagedCertificateParameters(type, subject.Value, expirationDate.Value);
        }
    }
}
