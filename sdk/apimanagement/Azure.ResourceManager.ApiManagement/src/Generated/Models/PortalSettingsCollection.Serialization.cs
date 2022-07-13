// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ApiManagement.Models
{
    internal partial class PortalSettingsCollection
    {
        internal static PortalSettingsCollection DeserializePortalSettingsCollection(JsonElement element)
        {
            Optional<IReadOnlyList<PortalSettingsContract>> value = default;
            Optional<long> count = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<PortalSettingsContract> array = new List<PortalSettingsContract>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(PortalSettingsContract.DeserializePortalSettingsContract(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("count"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    count = property.Value.GetInt64();
                    continue;
                }
            }
            return new PortalSettingsCollection(Optional.ToList(value), Optional.ToNullable(count));
        }
    }
}
