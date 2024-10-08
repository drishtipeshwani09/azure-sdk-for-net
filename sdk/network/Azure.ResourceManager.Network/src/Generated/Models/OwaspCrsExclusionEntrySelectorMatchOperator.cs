// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> When matchVariable is a collection, operate on the selector to specify which elements in the collection this exclusion applies to. </summary>
    public readonly partial struct OwaspCrsExclusionEntrySelectorMatchOperator : IEquatable<OwaspCrsExclusionEntrySelectorMatchOperator>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="OwaspCrsExclusionEntrySelectorMatchOperator"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public OwaspCrsExclusionEntrySelectorMatchOperator(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string EqualsValueValue = "Equals";
        private const string ContainsValue = "Contains";
        private const string StartsWithValue = "StartsWith";
        private const string EndsWithValue = "EndsWith";
        private const string EqualsAnyValue = "EqualsAny";

        /// <summary> Equals. </summary>
        public static OwaspCrsExclusionEntrySelectorMatchOperator EqualsValue { get; } = new OwaspCrsExclusionEntrySelectorMatchOperator(EqualsValueValue);
        /// <summary> Contains. </summary>
        public static OwaspCrsExclusionEntrySelectorMatchOperator Contains { get; } = new OwaspCrsExclusionEntrySelectorMatchOperator(ContainsValue);
        /// <summary> StartsWith. </summary>
        public static OwaspCrsExclusionEntrySelectorMatchOperator StartsWith { get; } = new OwaspCrsExclusionEntrySelectorMatchOperator(StartsWithValue);
        /// <summary> EndsWith. </summary>
        public static OwaspCrsExclusionEntrySelectorMatchOperator EndsWith { get; } = new OwaspCrsExclusionEntrySelectorMatchOperator(EndsWithValue);
        /// <summary> EqualsAny. </summary>
        public static OwaspCrsExclusionEntrySelectorMatchOperator EqualsAny { get; } = new OwaspCrsExclusionEntrySelectorMatchOperator(EqualsAnyValue);
        /// <summary> Determines if two <see cref="OwaspCrsExclusionEntrySelectorMatchOperator"/> values are the same. </summary>
        public static bool operator ==(OwaspCrsExclusionEntrySelectorMatchOperator left, OwaspCrsExclusionEntrySelectorMatchOperator right) => left.Equals(right);
        /// <summary> Determines if two <see cref="OwaspCrsExclusionEntrySelectorMatchOperator"/> values are not the same. </summary>
        public static bool operator !=(OwaspCrsExclusionEntrySelectorMatchOperator left, OwaspCrsExclusionEntrySelectorMatchOperator right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="OwaspCrsExclusionEntrySelectorMatchOperator"/>. </summary>
        public static implicit operator OwaspCrsExclusionEntrySelectorMatchOperator(string value) => new OwaspCrsExclusionEntrySelectorMatchOperator(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is OwaspCrsExclusionEntrySelectorMatchOperator other && Equals(other);
        /// <inheritdoc />
        public bool Equals(OwaspCrsExclusionEntrySelectorMatchOperator other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
