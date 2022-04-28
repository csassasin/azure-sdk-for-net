// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Resources.Models
{
    internal partial class TenantResourceProviderListResult
    {
        internal static TenantResourceProviderListResult DeserializeTenantResourceProviderListResult(JsonElement element)
        {
            Optional<IReadOnlyList<TenantResourceProvider>> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<TenantResourceProvider> array = new List<TenantResourceProvider>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(TenantResourceProvider.DeserializeTenantResourceProvider(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new TenantResourceProviderListResult(Optional.ToList(value), nextLink.Value);
        }
    }
}
