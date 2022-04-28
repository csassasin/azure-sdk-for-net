// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Storage.Models
{
    public partial class LeaseShareContent : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("action");
            writer.WriteStringValue(Action.ToString());
            if (Optional.IsDefined(LeaseId))
            {
                writer.WritePropertyName("leaseId");
                writer.WriteStringValue(LeaseId);
            }
            if (Optional.IsDefined(BreakPeriod))
            {
                writer.WritePropertyName("breakPeriod");
                writer.WriteNumberValue(BreakPeriod.Value);
            }
            if (Optional.IsDefined(LeaseDuration))
            {
                writer.WritePropertyName("leaseDuration");
                writer.WriteNumberValue(LeaseDuration.Value);
            }
            if (Optional.IsDefined(ProposedLeaseId))
            {
                writer.WritePropertyName("proposedLeaseId");
                writer.WriteStringValue(ProposedLeaseId);
            }
            writer.WriteEndObject();
        }
    }
}
