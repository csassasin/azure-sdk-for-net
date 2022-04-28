// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Resources.Models
{
    public partial class ArmApplicationArtifact
    {
        internal static ArmApplicationArtifact DeserializeArmApplicationArtifact(JsonElement element)
        {
            ArmApplicationArtifactName name = default;
            Uri uri = default;
            ArmApplicationArtifactType type = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    name = new ArmApplicationArtifactName(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("uri"))
                {
                    uri = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString().ToArmApplicationArtifactType();
                    continue;
                }
            }
            return new ArmApplicationArtifact(name, uri, type);
        }
    }
}
