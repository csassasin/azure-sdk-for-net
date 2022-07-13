// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.HDInsight.Models
{
    public partial class BillingResponseListResult
    {
        internal static BillingResponseListResult DeserializeBillingResponseListResult(JsonElement element)
        {
            Optional<IReadOnlyList<string>> vmSizes = default;
            Optional<IReadOnlyList<string>> vmSizesWithEncryptionAtHost = default;
            Optional<IReadOnlyList<VmSizeCompatibilityFilterV2>> vmSizeFilters = default;
            Optional<IReadOnlyList<VmSizeProperty>> vmSizeProperties = default;
            Optional<IReadOnlyList<BillingResources>> billingResources = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("vmSizes"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    vmSizes = array;
                    continue;
                }
                if (property.NameEquals("vmSizesWithEncryptionAtHost"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    vmSizesWithEncryptionAtHost = array;
                    continue;
                }
                if (property.NameEquals("vmSizeFilters"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<VmSizeCompatibilityFilterV2> array = new List<VmSizeCompatibilityFilterV2>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(VmSizeCompatibilityFilterV2.DeserializeVmSizeCompatibilityFilterV2(item));
                    }
                    vmSizeFilters = array;
                    continue;
                }
                if (property.NameEquals("vmSizeProperties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<VmSizeProperty> array = new List<VmSizeProperty>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(VmSizeProperty.DeserializeVmSizeProperty(item));
                    }
                    vmSizeProperties = array;
                    continue;
                }
                if (property.NameEquals("billingResources"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<BillingResources> array = new List<BillingResources>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(Models.BillingResources.DeserializeBillingResources(item));
                    }
                    billingResources = array;
                    continue;
                }
            }
            return new BillingResponseListResult(Optional.ToList(vmSizes), Optional.ToList(vmSizesWithEncryptionAtHost), Optional.ToList(vmSizeFilters), Optional.ToList(vmSizeProperties), Optional.ToList(billingResources));
        }
    }
}
