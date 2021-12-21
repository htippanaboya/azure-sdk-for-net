// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.EdgeOrder.Models
{
    /// <summary> Charging type. </summary>
    public readonly partial struct ChargingType : IEquatable<ChargingType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ChargingType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ChargingType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string PerOrderValue = "PerOrder";
        private const string PerDeviceValue = "PerDevice";

        /// <summary> Per order charging type. </summary>
        public static ChargingType PerOrder { get; } = new ChargingType(PerOrderValue);
        /// <summary> Per device charging type. </summary>
        public static ChargingType PerDevice { get; } = new ChargingType(PerDeviceValue);
        /// <summary> Determines if two <see cref="ChargingType"/> values are the same. </summary>
        public static bool operator ==(ChargingType left, ChargingType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ChargingType"/> values are not the same. </summary>
        public static bool operator !=(ChargingType left, ChargingType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ChargingType"/>. </summary>
        public static implicit operator ChargingType(string value) => new ChargingType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ChargingType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ChargingType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
