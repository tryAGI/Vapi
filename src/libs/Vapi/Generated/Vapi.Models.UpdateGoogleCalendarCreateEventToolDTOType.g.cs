
#nullable enable

namespace Vapi
{
    /// <summary>
    /// The type of tool. "google.calendar.event.create" for Google Calendar Create Event tool.
    /// </summary>
    public enum UpdateGoogleCalendarCreateEventToolDTOType
    {
        /// <summary>
        ///
        /// </summary>
        GoogleCalendarEventCreate,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateGoogleCalendarCreateEventToolDTOTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateGoogleCalendarCreateEventToolDTOType value)
        {
            return value switch
            {
                UpdateGoogleCalendarCreateEventToolDTOType.GoogleCalendarEventCreate => "google.calendar.event.create",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateGoogleCalendarCreateEventToolDTOType? ToEnum(string value)
        {
            return value switch
            {
                "google.calendar.event.create" => UpdateGoogleCalendarCreateEventToolDTOType.GoogleCalendarEventCreate,
                _ => null,
            };
        }
    }
}