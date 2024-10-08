// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.ElasticSan.Models
{
    /// <summary> The sku tier. </summary>
    public readonly partial struct ElasticSanSkuTier : IEquatable<ElasticSanSkuTier>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ElasticSanSkuTier"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ElasticSanSkuTier(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string PremiumValue = "Premium";

        /// <summary> Premium Tier. </summary>
        public static ElasticSanSkuTier Premium { get; } = new ElasticSanSkuTier(PremiumValue);
        /// <summary> Determines if two <see cref="ElasticSanSkuTier"/> values are the same. </summary>
        public static bool operator ==(ElasticSanSkuTier left, ElasticSanSkuTier right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ElasticSanSkuTier"/> values are not the same. </summary>
        public static bool operator !=(ElasticSanSkuTier left, ElasticSanSkuTier right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="ElasticSanSkuTier"/>. </summary>
        public static implicit operator ElasticSanSkuTier(string value) => new ElasticSanSkuTier(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ElasticSanSkuTier other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ElasticSanSkuTier other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
