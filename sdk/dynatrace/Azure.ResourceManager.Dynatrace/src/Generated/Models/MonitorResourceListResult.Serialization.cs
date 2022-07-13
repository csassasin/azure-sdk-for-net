// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Dynatrace;

namespace Azure.ResourceManager.Dynatrace.Models
{
    internal partial class MonitorResourceListResult
    {
        internal static MonitorResourceListResult DeserializeMonitorResourceListResult(JsonElement element)
        {
            IReadOnlyList<MonitorResourceData> value = default;
            string nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    List<MonitorResourceData> array = new List<MonitorResourceData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MonitorResourceData.DeserializeMonitorResourceData(item));
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
            return new MonitorResourceListResult(value, nextLink);
        }
    }
}
