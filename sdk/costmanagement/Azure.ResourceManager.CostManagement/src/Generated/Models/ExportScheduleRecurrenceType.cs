// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.CostManagement.Models
{
    /// <summary> The schedule recurrence. </summary>
    public readonly partial struct ExportScheduleRecurrenceType : IEquatable<ExportScheduleRecurrenceType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ExportScheduleRecurrenceType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ExportScheduleRecurrenceType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string DailyValue = "Daily";
        private const string WeeklyValue = "Weekly";
        private const string MonthlyValue = "Monthly";
        private const string AnnuallyValue = "Annually";

        /// <summary> Daily. </summary>
        public static ExportScheduleRecurrenceType Daily { get; } = new ExportScheduleRecurrenceType(DailyValue);
        /// <summary> Weekly. </summary>
        public static ExportScheduleRecurrenceType Weekly { get; } = new ExportScheduleRecurrenceType(WeeklyValue);
        /// <summary> Monthly. </summary>
        public static ExportScheduleRecurrenceType Monthly { get; } = new ExportScheduleRecurrenceType(MonthlyValue);
        /// <summary> Annually. </summary>
        public static ExportScheduleRecurrenceType Annually { get; } = new ExportScheduleRecurrenceType(AnnuallyValue);
        /// <summary> Determines if two <see cref="ExportScheduleRecurrenceType"/> values are the same. </summary>
        public static bool operator ==(ExportScheduleRecurrenceType left, ExportScheduleRecurrenceType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ExportScheduleRecurrenceType"/> values are not the same. </summary>
        public static bool operator !=(ExportScheduleRecurrenceType left, ExportScheduleRecurrenceType right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="ExportScheduleRecurrenceType"/>. </summary>
        public static implicit operator ExportScheduleRecurrenceType(string value) => new ExportScheduleRecurrenceType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ExportScheduleRecurrenceType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ExportScheduleRecurrenceType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
