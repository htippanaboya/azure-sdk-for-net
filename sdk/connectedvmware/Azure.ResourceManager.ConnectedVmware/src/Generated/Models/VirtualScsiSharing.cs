// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.ConnectedVmware.Models
{
    /// <summary> Defines the sharing mode for sharing the SCSI bus. </summary>
    public readonly partial struct VirtualScsiSharing : IEquatable<VirtualScsiSharing>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="VirtualScsiSharing"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public VirtualScsiSharing(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NoSharingValue = "noSharing";
        private const string PhysicalSharingValue = "physicalSharing";
        private const string VirtualSharingValue = "virtualSharing";

        /// <summary> noSharing. </summary>
        public static VirtualScsiSharing NoSharing { get; } = new VirtualScsiSharing(NoSharingValue);
        /// <summary> physicalSharing. </summary>
        public static VirtualScsiSharing PhysicalSharing { get; } = new VirtualScsiSharing(PhysicalSharingValue);
        /// <summary> virtualSharing. </summary>
        public static VirtualScsiSharing VirtualSharing { get; } = new VirtualScsiSharing(VirtualSharingValue);
        /// <summary> Determines if two <see cref="VirtualScsiSharing"/> values are the same. </summary>
        public static bool operator ==(VirtualScsiSharing left, VirtualScsiSharing right) => left.Equals(right);
        /// <summary> Determines if two <see cref="VirtualScsiSharing"/> values are not the same. </summary>
        public static bool operator !=(VirtualScsiSharing left, VirtualScsiSharing right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="VirtualScsiSharing"/>. </summary>
        public static implicit operator VirtualScsiSharing(string value) => new VirtualScsiSharing(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is VirtualScsiSharing other && Equals(other);
        /// <inheritdoc />
        public bool Equals(VirtualScsiSharing other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
