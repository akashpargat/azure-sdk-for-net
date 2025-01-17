// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Kusto.Models
{
    /// <summary> The data format of the message. Optionally the data format can be added to each message. </summary>
    public readonly partial struct EventHubDataFormat : IEquatable<EventHubDataFormat>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="EventHubDataFormat"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public EventHubDataFormat(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string MultijsonValue = "MULTIJSON";
        private const string JsonValue = "JSON";
        private const string CSVValue = "CSV";
        private const string TSVValue = "TSV";
        private const string ScsvValue = "SCSV";
        private const string SohsvValue = "SOHSV";
        private const string PSVValue = "PSV";
        private const string TXTValue = "TXT";
        private const string RAWValue = "RAW";
        private const string SinglejsonValue = "SINGLEJSON";
        private const string AvroValue = "AVRO";
        private const string TsveValue = "TSVE";
        private const string ParquetValue = "PARQUET";
        private const string ORCValue = "ORC";
        private const string ApacheAvroValue = "APACHEAVRO";
        private const string W3ClogfileValue = "W3CLOGFILE";

        /// <summary> MULTIJSON. </summary>
        public static EventHubDataFormat Multijson { get; } = new EventHubDataFormat(MultijsonValue);
        /// <summary> JSON. </summary>
        public static EventHubDataFormat Json { get; } = new EventHubDataFormat(JsonValue);
        /// <summary> CSV. </summary>
        public static EventHubDataFormat CSV { get; } = new EventHubDataFormat(CSVValue);
        /// <summary> TSV. </summary>
        public static EventHubDataFormat TSV { get; } = new EventHubDataFormat(TSVValue);
        /// <summary> SCSV. </summary>
        public static EventHubDataFormat Scsv { get; } = new EventHubDataFormat(ScsvValue);
        /// <summary> SOHSV. </summary>
        public static EventHubDataFormat Sohsv { get; } = new EventHubDataFormat(SohsvValue);
        /// <summary> PSV. </summary>
        public static EventHubDataFormat PSV { get; } = new EventHubDataFormat(PSVValue);
        /// <summary> TXT. </summary>
        public static EventHubDataFormat TXT { get; } = new EventHubDataFormat(TXTValue);
        /// <summary> RAW. </summary>
        public static EventHubDataFormat RAW { get; } = new EventHubDataFormat(RAWValue);
        /// <summary> SINGLEJSON. </summary>
        public static EventHubDataFormat Singlejson { get; } = new EventHubDataFormat(SinglejsonValue);
        /// <summary> AVRO. </summary>
        public static EventHubDataFormat Avro { get; } = new EventHubDataFormat(AvroValue);
        /// <summary> TSVE. </summary>
        public static EventHubDataFormat Tsve { get; } = new EventHubDataFormat(TsveValue);
        /// <summary> PARQUET. </summary>
        public static EventHubDataFormat Parquet { get; } = new EventHubDataFormat(ParquetValue);
        /// <summary> ORC. </summary>
        public static EventHubDataFormat ORC { get; } = new EventHubDataFormat(ORCValue);
        /// <summary> APACHEAVRO. </summary>
        public static EventHubDataFormat ApacheAvro { get; } = new EventHubDataFormat(ApacheAvroValue);
        /// <summary> W3CLOGFILE. </summary>
        public static EventHubDataFormat W3Clogfile { get; } = new EventHubDataFormat(W3ClogfileValue);
        /// <summary> Determines if two <see cref="EventHubDataFormat"/> values are the same. </summary>
        public static bool operator ==(EventHubDataFormat left, EventHubDataFormat right) => left.Equals(right);
        /// <summary> Determines if two <see cref="EventHubDataFormat"/> values are not the same. </summary>
        public static bool operator !=(EventHubDataFormat left, EventHubDataFormat right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="EventHubDataFormat"/>. </summary>
        public static implicit operator EventHubDataFormat(string value) => new EventHubDataFormat(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is EventHubDataFormat other && Equals(other);
        /// <inheritdoc />
        public bool Equals(EventHubDataFormat other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
