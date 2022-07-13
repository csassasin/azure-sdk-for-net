// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Logic.Models
{
    internal partial class ExpressionTraces
    {
        internal static ExpressionTraces DeserializeExpressionTraces(JsonElement element)
        {
            Optional<IReadOnlyList<ExpressionRoot>> inputs = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("inputs"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<ExpressionRoot> array = new List<ExpressionRoot>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ExpressionRoot.DeserializeExpressionRoot(item));
                    }
                    inputs = array;
                    continue;
                }
            }
            return new ExpressionTraces(Optional.ToList(inputs));
        }
    }
}
