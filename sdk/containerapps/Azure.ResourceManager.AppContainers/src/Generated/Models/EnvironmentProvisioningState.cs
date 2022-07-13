// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.AppContainers.Models
{
    /// <summary> Provisioning state of the Environment. </summary>
    public readonly partial struct EnvironmentProvisioningState : IEquatable<EnvironmentProvisioningState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="EnvironmentProvisioningState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public EnvironmentProvisioningState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string SucceededValue = "Succeeded";
        private const string FailedValue = "Failed";
        private const string CanceledValue = "Canceled";
        private const string WaitingValue = "Waiting";
        private const string InitializationInProgressValue = "InitializationInProgress";
        private const string InfrastructureSetupInProgressValue = "InfrastructureSetupInProgress";
        private const string InfrastructureSetupCompleteValue = "InfrastructureSetupComplete";
        private const string ScheduledForDeleteValue = "ScheduledForDelete";
        private const string UpgradeRequestedValue = "UpgradeRequested";
        private const string UpgradeFailedValue = "UpgradeFailed";

        /// <summary> Succeeded. </summary>
        public static EnvironmentProvisioningState Succeeded { get; } = new EnvironmentProvisioningState(SucceededValue);
        /// <summary> Failed. </summary>
        public static EnvironmentProvisioningState Failed { get; } = new EnvironmentProvisioningState(FailedValue);
        /// <summary> Canceled. </summary>
        public static EnvironmentProvisioningState Canceled { get; } = new EnvironmentProvisioningState(CanceledValue);
        /// <summary> Waiting. </summary>
        public static EnvironmentProvisioningState Waiting { get; } = new EnvironmentProvisioningState(WaitingValue);
        /// <summary> InitializationInProgress. </summary>
        public static EnvironmentProvisioningState InitializationInProgress { get; } = new EnvironmentProvisioningState(InitializationInProgressValue);
        /// <summary> InfrastructureSetupInProgress. </summary>
        public static EnvironmentProvisioningState InfrastructureSetupInProgress { get; } = new EnvironmentProvisioningState(InfrastructureSetupInProgressValue);
        /// <summary> InfrastructureSetupComplete. </summary>
        public static EnvironmentProvisioningState InfrastructureSetupComplete { get; } = new EnvironmentProvisioningState(InfrastructureSetupCompleteValue);
        /// <summary> ScheduledForDelete. </summary>
        public static EnvironmentProvisioningState ScheduledForDelete { get; } = new EnvironmentProvisioningState(ScheduledForDeleteValue);
        /// <summary> UpgradeRequested. </summary>
        public static EnvironmentProvisioningState UpgradeRequested { get; } = new EnvironmentProvisioningState(UpgradeRequestedValue);
        /// <summary> UpgradeFailed. </summary>
        public static EnvironmentProvisioningState UpgradeFailed { get; } = new EnvironmentProvisioningState(UpgradeFailedValue);
        /// <summary> Determines if two <see cref="EnvironmentProvisioningState"/> values are the same. </summary>
        public static bool operator ==(EnvironmentProvisioningState left, EnvironmentProvisioningState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="EnvironmentProvisioningState"/> values are not the same. </summary>
        public static bool operator !=(EnvironmentProvisioningState left, EnvironmentProvisioningState right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="EnvironmentProvisioningState"/>. </summary>
        public static implicit operator EnvironmentProvisioningState(string value) => new EnvironmentProvisioningState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is EnvironmentProvisioningState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(EnvironmentProvisioningState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
