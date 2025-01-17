// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Peering.Models
{
    /// <summary> The validation state of the ASN associated with the peer. </summary>
    public readonly partial struct ValidationState : IEquatable<ValidationState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ValidationState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ValidationState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NoneValue = "None";
        private const string PendingValue = "Pending";
        private const string ApprovedValue = "Approved";
        private const string FailedValue = "Failed";

        /// <summary> None. </summary>
        public static ValidationState None { get; } = new ValidationState(NoneValue);
        /// <summary> Pending. </summary>
        public static ValidationState Pending { get; } = new ValidationState(PendingValue);
        /// <summary> Approved. </summary>
        public static ValidationState Approved { get; } = new ValidationState(ApprovedValue);
        /// <summary> Failed. </summary>
        public static ValidationState Failed { get; } = new ValidationState(FailedValue);
        /// <summary> Determines if two <see cref="ValidationState"/> values are the same. </summary>
        public static bool operator ==(ValidationState left, ValidationState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ValidationState"/> values are not the same. </summary>
        public static bool operator !=(ValidationState left, ValidationState right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ValidationState"/>. </summary>
        public static implicit operator ValidationState(string value) => new ValidationState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ValidationState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ValidationState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
