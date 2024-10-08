// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    /// <summary> The InfrastructureEncryptionState. </summary>
    public readonly partial struct InfrastructureEncryptionState : IEquatable<InfrastructureEncryptionState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="InfrastructureEncryptionState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public InfrastructureEncryptionState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string InvalidValue = "Invalid";
        private const string DisabledValue = "Disabled";
        private const string EnabledValue = "Enabled";

        /// <summary> Invalid. </summary>
        public static InfrastructureEncryptionState Invalid { get; } = new InfrastructureEncryptionState(InvalidValue);
        /// <summary> Disabled. </summary>
        public static InfrastructureEncryptionState Disabled { get; } = new InfrastructureEncryptionState(DisabledValue);
        /// <summary> Enabled. </summary>
        public static InfrastructureEncryptionState Enabled { get; } = new InfrastructureEncryptionState(EnabledValue);
        /// <summary> Determines if two <see cref="InfrastructureEncryptionState"/> values are the same. </summary>
        public static bool operator ==(InfrastructureEncryptionState left, InfrastructureEncryptionState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="InfrastructureEncryptionState"/> values are not the same. </summary>
        public static bool operator !=(InfrastructureEncryptionState left, InfrastructureEncryptionState right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="InfrastructureEncryptionState"/>. </summary>
        public static implicit operator InfrastructureEncryptionState(string value) => new InfrastructureEncryptionState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is InfrastructureEncryptionState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(InfrastructureEncryptionState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
