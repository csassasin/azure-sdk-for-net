// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppContainers.Models
{
    public partial class DefaultErrorResponseError
    {
        internal static DefaultErrorResponseError DeserializeDefaultErrorResponseError(JsonElement element)
        {
            Optional<string> code = default;
            Optional<string> message = default;
            Optional<string> target = default;
            Optional<IReadOnlyList<DefaultErrorResponseErrorDetailsItem>> details = default;
            Optional<string> innererror = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("code"))
                {
                    code = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("message"))
                {
                    message = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("target"))
                {
                    target = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("details"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<DefaultErrorResponseErrorDetailsItem> array = new List<DefaultErrorResponseErrorDetailsItem>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DefaultErrorResponseErrorDetailsItem.DeserializeDefaultErrorResponseErrorDetailsItem(item));
                    }
                    details = array;
                    continue;
                }
                if (property.NameEquals("innererror"))
                {
                    innererror = property.Value.GetString();
                    continue;
                }
            }
            return new DefaultErrorResponseError(code.Value, message.Value, target.Value, Optional.ToList(details), innererror.Value);
        }
    }
}
