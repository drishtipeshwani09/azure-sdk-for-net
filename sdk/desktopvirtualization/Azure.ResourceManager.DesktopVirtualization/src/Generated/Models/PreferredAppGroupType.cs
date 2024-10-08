// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.DesktopVirtualization.Models
{
    /// <summary> The type of preferred application group type, default to Desktop Application Group. </summary>
    public readonly partial struct PreferredAppGroupType : IEquatable<PreferredAppGroupType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="PreferredAppGroupType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public PreferredAppGroupType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NoneValue = "None";
        private const string DesktopValue = "Desktop";
        private const string RailApplicationsValue = "RailApplications";

        /// <summary> None. </summary>
        public static PreferredAppGroupType None { get; } = new PreferredAppGroupType(NoneValue);
        /// <summary> Desktop. </summary>
        public static PreferredAppGroupType Desktop { get; } = new PreferredAppGroupType(DesktopValue);
        /// <summary> RailApplications. </summary>
        public static PreferredAppGroupType RailApplications { get; } = new PreferredAppGroupType(RailApplicationsValue);
        /// <summary> Determines if two <see cref="PreferredAppGroupType"/> values are the same. </summary>
        public static bool operator ==(PreferredAppGroupType left, PreferredAppGroupType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="PreferredAppGroupType"/> values are not the same. </summary>
        public static bool operator !=(PreferredAppGroupType left, PreferredAppGroupType right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="PreferredAppGroupType"/>. </summary>
        public static implicit operator PreferredAppGroupType(string value) => new PreferredAppGroupType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is PreferredAppGroupType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(PreferredAppGroupType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
