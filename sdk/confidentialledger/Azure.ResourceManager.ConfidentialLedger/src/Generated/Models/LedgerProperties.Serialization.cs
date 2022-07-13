// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ConfidentialLedger.Models
{
    public partial class LedgerProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(LedgerType))
            {
                writer.WritePropertyName("ledgerType");
                writer.WriteStringValue(LedgerType.Value.ToString());
            }
            if (Optional.IsCollectionDefined(AadBasedSecurityPrincipals))
            {
                writer.WritePropertyName("aadBasedSecurityPrincipals");
                writer.WriteStartArray();
                foreach (var item in AadBasedSecurityPrincipals)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(CertBasedSecurityPrincipals))
            {
                writer.WritePropertyName("certBasedSecurityPrincipals");
                writer.WriteStartArray();
                foreach (var item in CertBasedSecurityPrincipals)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static LedgerProperties DeserializeLedgerProperties(JsonElement element)
        {
            Optional<string> ledgerName = default;
            Optional<Uri> ledgerUri = default;
            Optional<Uri> identityServiceUri = default;
            Optional<string> ledgerInternalNamespace = default;
            Optional<LedgerType> ledgerType = default;
            Optional<LedgerProvisioningState> provisioningState = default;
            Optional<IList<AadBasedSecurityPrincipal>> aadBasedSecurityPrincipals = default;
            Optional<IList<CertBasedSecurityPrincipal>> certBasedSecurityPrincipals = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("ledgerName"))
                {
                    ledgerName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("ledgerUri"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        ledgerUri = null;
                        continue;
                    }
                    ledgerUri = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("identityServiceUri"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        identityServiceUri = null;
                        continue;
                    }
                    identityServiceUri = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("ledgerInternalNamespace"))
                {
                    ledgerInternalNamespace = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("ledgerType"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    ledgerType = new LedgerType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("provisioningState"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    provisioningState = new LedgerProvisioningState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("aadBasedSecurityPrincipals"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<AadBasedSecurityPrincipal> array = new List<AadBasedSecurityPrincipal>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AadBasedSecurityPrincipal.DeserializeAadBasedSecurityPrincipal(item));
                    }
                    aadBasedSecurityPrincipals = array;
                    continue;
                }
                if (property.NameEquals("certBasedSecurityPrincipals"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<CertBasedSecurityPrincipal> array = new List<CertBasedSecurityPrincipal>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(CertBasedSecurityPrincipal.DeserializeCertBasedSecurityPrincipal(item));
                    }
                    certBasedSecurityPrincipals = array;
                    continue;
                }
            }
            return new LedgerProperties(ledgerName.Value, ledgerUri.Value, identityServiceUri.Value, ledgerInternalNamespace.Value, Optional.ToNullable(ledgerType), Optional.ToNullable(provisioningState), Optional.ToList(aadBasedSecurityPrincipals), Optional.ToList(certBasedSecurityPrincipals));
        }
    }
}
