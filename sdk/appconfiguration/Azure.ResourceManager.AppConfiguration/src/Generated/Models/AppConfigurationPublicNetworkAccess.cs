// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.AppConfiguration.Models
{
    /// <summary> Control permission for data plane traffic coming from public networks while private endpoint is enabled. </summary>
    public readonly partial struct AppConfigurationPublicNetworkAccess : IEquatable<AppConfigurationPublicNetworkAccess>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="AppConfigurationPublicNetworkAccess"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public AppConfigurationPublicNetworkAccess(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string EnabledValue = "Enabled";
        private const string DisabledValue = "Disabled";

        /// <summary> Enabled. </summary>
        public static AppConfigurationPublicNetworkAccess Enabled { get; } = new AppConfigurationPublicNetworkAccess(EnabledValue);
        /// <summary> Disabled. </summary>
        public static AppConfigurationPublicNetworkAccess Disabled { get; } = new AppConfigurationPublicNetworkAccess(DisabledValue);
        /// <summary> Determines if two <see cref="AppConfigurationPublicNetworkAccess"/> values are the same. </summary>
        public static bool operator ==(AppConfigurationPublicNetworkAccess left, AppConfigurationPublicNetworkAccess right) => left.Equals(right);
        /// <summary> Determines if two <see cref="AppConfigurationPublicNetworkAccess"/> values are not the same. </summary>
        public static bool operator !=(AppConfigurationPublicNetworkAccess left, AppConfigurationPublicNetworkAccess right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="AppConfigurationPublicNetworkAccess"/>. </summary>
        public static implicit operator AppConfigurationPublicNetworkAccess(string value) => new AppConfigurationPublicNetworkAccess(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is AppConfigurationPublicNetworkAccess other && Equals(other);
        /// <inheritdoc />
        public bool Equals(AppConfigurationPublicNetworkAccess other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
