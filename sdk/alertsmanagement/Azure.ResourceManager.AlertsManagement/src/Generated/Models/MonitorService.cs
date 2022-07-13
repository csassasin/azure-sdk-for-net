// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.AlertsManagement.Models
{
    /// <summary> The MonitorService. </summary>
    public readonly partial struct MonitorService : IEquatable<MonitorService>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="MonitorService"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public MonitorService(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ApplicationInsightsValue = "Application Insights";
        private const string ActivityLogAdministrativeValue = "ActivityLog Administrative";
        private const string ActivityLogSecurityValue = "ActivityLog Security";
        private const string ActivityLogRecommendationValue = "ActivityLog Recommendation";
        private const string ActivityLogPolicyValue = "ActivityLog Policy";
        private const string ActivityLogAutoscaleValue = "ActivityLog Autoscale";
        private const string LogAnalyticsValue = "Log Analytics";
        private const string NagiosValue = "Nagios";
        private const string PlatformValue = "Platform";
        private const string ScomValue = "SCOM";
        private const string ServiceHealthValue = "ServiceHealth";
        private const string SmartDetectorValue = "SmartDetector";
        private const string VmInsightsValue = "VM Insights";
        private const string ZabbixValue = "Zabbix";

        /// <summary> Application Insights. </summary>
        public static MonitorService ApplicationInsights { get; } = new MonitorService(ApplicationInsightsValue);
        /// <summary> ActivityLog Administrative. </summary>
        public static MonitorService ActivityLogAdministrative { get; } = new MonitorService(ActivityLogAdministrativeValue);
        /// <summary> ActivityLog Security. </summary>
        public static MonitorService ActivityLogSecurity { get; } = new MonitorService(ActivityLogSecurityValue);
        /// <summary> ActivityLog Recommendation. </summary>
        public static MonitorService ActivityLogRecommendation { get; } = new MonitorService(ActivityLogRecommendationValue);
        /// <summary> ActivityLog Policy. </summary>
        public static MonitorService ActivityLogPolicy { get; } = new MonitorService(ActivityLogPolicyValue);
        /// <summary> ActivityLog Autoscale. </summary>
        public static MonitorService ActivityLogAutoscale { get; } = new MonitorService(ActivityLogAutoscaleValue);
        /// <summary> Log Analytics. </summary>
        public static MonitorService LogAnalytics { get; } = new MonitorService(LogAnalyticsValue);
        /// <summary> Nagios. </summary>
        public static MonitorService Nagios { get; } = new MonitorService(NagiosValue);
        /// <summary> Platform. </summary>
        public static MonitorService Platform { get; } = new MonitorService(PlatformValue);
        /// <summary> SCOM. </summary>
        public static MonitorService Scom { get; } = new MonitorService(ScomValue);
        /// <summary> ServiceHealth. </summary>
        public static MonitorService ServiceHealth { get; } = new MonitorService(ServiceHealthValue);
        /// <summary> SmartDetector. </summary>
        public static MonitorService SmartDetector { get; } = new MonitorService(SmartDetectorValue);
        /// <summary> VM Insights. </summary>
        public static MonitorService VmInsights { get; } = new MonitorService(VmInsightsValue);
        /// <summary> Zabbix. </summary>
        public static MonitorService Zabbix { get; } = new MonitorService(ZabbixValue);
        /// <summary> Determines if two <see cref="MonitorService"/> values are the same. </summary>
        public static bool operator ==(MonitorService left, MonitorService right) => left.Equals(right);
        /// <summary> Determines if two <see cref="MonitorService"/> values are not the same. </summary>
        public static bool operator !=(MonitorService left, MonitorService right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="MonitorService"/>. </summary>
        public static implicit operator MonitorService(string value) => new MonitorService(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is MonitorService other && Equals(other);
        /// <inheritdoc />
        public bool Equals(MonitorService other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
