// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.KeyVault.Models
{
    /// <summary> A message indicating if changes on the service provider require any updates on the consumer. </summary>
    public readonly partial struct KeyVaultActionsRequiredMessage : IEquatable<KeyVaultActionsRequiredMessage>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="KeyVaultActionsRequiredMessage"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public KeyVaultActionsRequiredMessage(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NoneValue = "None";

        /// <summary> None. </summary>
        public static KeyVaultActionsRequiredMessage None { get; } = new KeyVaultActionsRequiredMessage(NoneValue);
        /// <summary> Determines if two <see cref="KeyVaultActionsRequiredMessage"/> values are the same. </summary>
        public static bool operator ==(KeyVaultActionsRequiredMessage left, KeyVaultActionsRequiredMessage right) => left.Equals(right);
        /// <summary> Determines if two <see cref="KeyVaultActionsRequiredMessage"/> values are not the same. </summary>
        public static bool operator !=(KeyVaultActionsRequiredMessage left, KeyVaultActionsRequiredMessage right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="KeyVaultActionsRequiredMessage"/>. </summary>
        public static implicit operator KeyVaultActionsRequiredMessage(string value) => new KeyVaultActionsRequiredMessage(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is KeyVaultActionsRequiredMessage other && Equals(other);
        /// <inheritdoc />
        public bool Equals(KeyVaultActionsRequiredMessage other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
