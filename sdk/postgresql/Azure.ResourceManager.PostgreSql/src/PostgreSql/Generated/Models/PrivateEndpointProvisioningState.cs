// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.PostgreSql.Models
{
    /// <summary> State of the private endpoint connection. </summary>
    public readonly partial struct PrivateEndpointProvisioningState : IEquatable<PrivateEndpointProvisioningState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="PrivateEndpointProvisioningState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public PrivateEndpointProvisioningState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ApprovingValue = "Approving";
        private const string ReadyValue = "Ready";
        private const string DroppingValue = "Dropping";
        private const string FailedValue = "Failed";
        private const string RejectingValue = "Rejecting";

        /// <summary> Approving. </summary>
        public static PrivateEndpointProvisioningState Approving { get; } = new PrivateEndpointProvisioningState(ApprovingValue);
        /// <summary> Ready. </summary>
        public static PrivateEndpointProvisioningState Ready { get; } = new PrivateEndpointProvisioningState(ReadyValue);
        /// <summary> Dropping. </summary>
        public static PrivateEndpointProvisioningState Dropping { get; } = new PrivateEndpointProvisioningState(DroppingValue);
        /// <summary> Failed. </summary>
        public static PrivateEndpointProvisioningState Failed { get; } = new PrivateEndpointProvisioningState(FailedValue);
        /// <summary> Rejecting. </summary>
        public static PrivateEndpointProvisioningState Rejecting { get; } = new PrivateEndpointProvisioningState(RejectingValue);
        /// <summary> Determines if two <see cref="PrivateEndpointProvisioningState"/> values are the same. </summary>
        public static bool operator ==(PrivateEndpointProvisioningState left, PrivateEndpointProvisioningState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="PrivateEndpointProvisioningState"/> values are not the same. </summary>
        public static bool operator !=(PrivateEndpointProvisioningState left, PrivateEndpointProvisioningState right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="PrivateEndpointProvisioningState"/>. </summary>
        public static implicit operator PrivateEndpointProvisioningState(string value) => new PrivateEndpointProvisioningState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is PrivateEndpointProvisioningState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(PrivateEndpointProvisioningState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
