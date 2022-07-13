// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.ContainerRegistry.Models
{
    /// <summary> The type of the step. </summary>
    internal readonly partial struct StepType : IEquatable<StepType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="StepType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public StepType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string DockerValue = "Docker";
        private const string FileTaskValue = "FileTask";
        private const string EncodedTaskValue = "EncodedTask";

        /// <summary> Docker. </summary>
        public static StepType Docker { get; } = new StepType(DockerValue);
        /// <summary> FileTask. </summary>
        public static StepType FileTask { get; } = new StepType(FileTaskValue);
        /// <summary> EncodedTask. </summary>
        public static StepType EncodedTask { get; } = new StepType(EncodedTaskValue);
        /// <summary> Determines if two <see cref="StepType"/> values are the same. </summary>
        public static bool operator ==(StepType left, StepType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="StepType"/> values are not the same. </summary>
        public static bool operator !=(StepType left, StepType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="StepType"/>. </summary>
        public static implicit operator StepType(string value) => new StepType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is StepType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(StepType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
