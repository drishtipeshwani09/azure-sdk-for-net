// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> The initial replication progress health. </summary>
    public readonly partial struct VmReplicationProgressHealth : IEquatable<VmReplicationProgressHealth>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="VmReplicationProgressHealth"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public VmReplicationProgressHealth(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NoneValue = "None";
        private const string InProgressValue = "InProgress";
        private const string SlowProgressValue = "SlowProgress";
        private const string NoProgressValue = "NoProgress";

        /// <summary> None. </summary>
        public static VmReplicationProgressHealth None { get; } = new VmReplicationProgressHealth(NoneValue);
        /// <summary> InProgress. </summary>
        public static VmReplicationProgressHealth InProgress { get; } = new VmReplicationProgressHealth(InProgressValue);
        /// <summary> SlowProgress. </summary>
        public static VmReplicationProgressHealth SlowProgress { get; } = new VmReplicationProgressHealth(SlowProgressValue);
        /// <summary> NoProgress. </summary>
        public static VmReplicationProgressHealth NoProgress { get; } = new VmReplicationProgressHealth(NoProgressValue);
        /// <summary> Determines if two <see cref="VmReplicationProgressHealth"/> values are the same. </summary>
        public static bool operator ==(VmReplicationProgressHealth left, VmReplicationProgressHealth right) => left.Equals(right);
        /// <summary> Determines if two <see cref="VmReplicationProgressHealth"/> values are not the same. </summary>
        public static bool operator !=(VmReplicationProgressHealth left, VmReplicationProgressHealth right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="VmReplicationProgressHealth"/>. </summary>
        public static implicit operator VmReplicationProgressHealth(string value) => new VmReplicationProgressHealth(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is VmReplicationProgressHealth other && Equals(other);
        /// <inheritdoc />
        public bool Equals(VmReplicationProgressHealth other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
