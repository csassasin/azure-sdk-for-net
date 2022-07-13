// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> Flag for generating lags for the numeric features. </summary>
    public readonly partial struct FeatureLag : IEquatable<FeatureLag>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="FeatureLag"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public FeatureLag(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NoneValue = "None";
        private const string AutoValue = "Auto";

        /// <summary> No feature lags generated. </summary>
        public static FeatureLag None { get; } = new FeatureLag(NoneValue);
        /// <summary> System auto-generates feature lags. </summary>
        public static FeatureLag Auto { get; } = new FeatureLag(AutoValue);
        /// <summary> Determines if two <see cref="FeatureLag"/> values are the same. </summary>
        public static bool operator ==(FeatureLag left, FeatureLag right) => left.Equals(right);
        /// <summary> Determines if two <see cref="FeatureLag"/> values are not the same. </summary>
        public static bool operator !=(FeatureLag left, FeatureLag right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="FeatureLag"/>. </summary>
        public static implicit operator FeatureLag(string value) => new FeatureLag(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is FeatureLag other && Equals(other);
        /// <inheritdoc />
        public bool Equals(FeatureLag other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
