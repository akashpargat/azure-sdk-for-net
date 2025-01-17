// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.FrontDoor.Models
{
    /// <summary> Configures which HTTP method to use to probe the backends defined under backendPools. </summary>
    public readonly partial struct FrontDoorHealthProbeMethod : IEquatable<FrontDoorHealthProbeMethod>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="FrontDoorHealthProbeMethod"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public FrontDoorHealthProbeMethod(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string GETValue = "GET";
        private const string HeadValue = "HEAD";

        /// <summary> GET. </summary>
        public static FrontDoorHealthProbeMethod GET { get; } = new FrontDoorHealthProbeMethod(GETValue);
        /// <summary> HEAD. </summary>
        public static FrontDoorHealthProbeMethod Head { get; } = new FrontDoorHealthProbeMethod(HeadValue);
        /// <summary> Determines if two <see cref="FrontDoorHealthProbeMethod"/> values are the same. </summary>
        public static bool operator ==(FrontDoorHealthProbeMethod left, FrontDoorHealthProbeMethod right) => left.Equals(right);
        /// <summary> Determines if two <see cref="FrontDoorHealthProbeMethod"/> values are not the same. </summary>
        public static bool operator !=(FrontDoorHealthProbeMethod left, FrontDoorHealthProbeMethod right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="FrontDoorHealthProbeMethod"/>. </summary>
        public static implicit operator FrontDoorHealthProbeMethod(string value) => new FrontDoorHealthProbeMethod(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is FrontDoorHealthProbeMethod other && Equals(other);
        /// <inheritdoc />
        public bool Equals(FrontDoorHealthProbeMethod other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
