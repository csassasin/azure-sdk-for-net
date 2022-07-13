// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.KeyVault.Models
{
    /// <summary> Tells what traffic can bypass network rules. This can be &apos;AzureServices&apos; or &apos;None&apos;.  If not specified the default is &apos;AzureServices&apos;. </summary>
    public readonly partial struct ManagedHsmNetworkRuleBypassOption : IEquatable<ManagedHsmNetworkRuleBypassOption>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ManagedHsmNetworkRuleBypassOption"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ManagedHsmNetworkRuleBypassOption(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AzureServicesValue = "AzureServices";
        private const string NoneValue = "None";

        /// <summary> AzureServices. </summary>
        public static ManagedHsmNetworkRuleBypassOption AzureServices { get; } = new ManagedHsmNetworkRuleBypassOption(AzureServicesValue);
        /// <summary> None. </summary>
        public static ManagedHsmNetworkRuleBypassOption None { get; } = new ManagedHsmNetworkRuleBypassOption(NoneValue);
        /// <summary> Determines if two <see cref="ManagedHsmNetworkRuleBypassOption"/> values are the same. </summary>
        public static bool operator ==(ManagedHsmNetworkRuleBypassOption left, ManagedHsmNetworkRuleBypassOption right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ManagedHsmNetworkRuleBypassOption"/> values are not the same. </summary>
        public static bool operator !=(ManagedHsmNetworkRuleBypassOption left, ManagedHsmNetworkRuleBypassOption right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ManagedHsmNetworkRuleBypassOption"/>. </summary>
        public static implicit operator ManagedHsmNetworkRuleBypassOption(string value) => new ManagedHsmNetworkRuleBypassOption(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ManagedHsmNetworkRuleBypassOption other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ManagedHsmNetworkRuleBypassOption other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
