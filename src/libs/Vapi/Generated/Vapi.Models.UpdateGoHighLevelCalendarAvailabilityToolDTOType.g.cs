
#nullable enable

namespace Vapi
{
    /// <summary>
    /// The type of tool. "gohighlevel.calendar.availability.check" for GoHighLevel Calendar Availability Check tool.
    /// </summary>
    public enum UpdateGoHighLevelCalendarAvailabilityToolDTOType
    {
        /// <summary>
        ///
        /// </summary>
        GohighlevelCalendarAvailabilityCheck,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateGoHighLevelCalendarAvailabilityToolDTOTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateGoHighLevelCalendarAvailabilityToolDTOType value)
        {
            return value switch
            {
                UpdateGoHighLevelCalendarAvailabilityToolDTOType.GohighlevelCalendarAvailabilityCheck => "gohighlevel.calendar.availability.check",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateGoHighLevelCalendarAvailabilityToolDTOType? ToEnum(string value)
        {
            return value switch
            {
                "gohighlevel.calendar.availability.check" => UpdateGoHighLevelCalendarAvailabilityToolDTOType.GohighlevelCalendarAvailabilityCheck,
                _ => null,
            };
        }
    }
}