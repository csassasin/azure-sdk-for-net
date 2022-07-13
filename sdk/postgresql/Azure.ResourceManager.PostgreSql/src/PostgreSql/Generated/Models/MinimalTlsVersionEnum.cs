// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.PostgreSql.Models
{
    /// <summary> Enforce a minimal Tls version for the server. </summary>
    public readonly partial struct MinimalTlsVersionEnum : IEquatable<MinimalTlsVersionEnum>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="MinimalTlsVersionEnum"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public MinimalTlsVersionEnum(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string TLS10Value = "TLS1_0";
        private const string TLS11Value = "TLS1_1";
        private const string TLS12Value = "TLS1_2";
        private const string TLSEnforcementDisabledValue = "TLSEnforcementDisabled";

        /// <summary> TLS1_0. </summary>
        public static MinimalTlsVersionEnum TLS10 { get; } = new MinimalTlsVersionEnum(TLS10Value);
        /// <summary> TLS1_1. </summary>
        public static MinimalTlsVersionEnum TLS11 { get; } = new MinimalTlsVersionEnum(TLS11Value);
        /// <summary> TLS1_2. </summary>
        public static MinimalTlsVersionEnum TLS12 { get; } = new MinimalTlsVersionEnum(TLS12Value);
        /// <summary> TLSEnforcementDisabled. </summary>
        public static MinimalTlsVersionEnum TLSEnforcementDisabled { get; } = new MinimalTlsVersionEnum(TLSEnforcementDisabledValue);
        /// <summary> Determines if two <see cref="MinimalTlsVersionEnum"/> values are the same. </summary>
        public static bool operator ==(MinimalTlsVersionEnum left, MinimalTlsVersionEnum right) => left.Equals(right);
        /// <summary> Determines if two <see cref="MinimalTlsVersionEnum"/> values are not the same. </summary>
        public static bool operator !=(MinimalTlsVersionEnum left, MinimalTlsVersionEnum right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="MinimalTlsVersionEnum"/>. </summary>
        public static implicit operator MinimalTlsVersionEnum(string value) => new MinimalTlsVersionEnum(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is MinimalTlsVersionEnum other && Equals(other);
        /// <inheritdoc />
        public bool Equals(MinimalTlsVersionEnum other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
