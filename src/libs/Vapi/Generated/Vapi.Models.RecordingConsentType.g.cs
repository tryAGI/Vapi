
#nullable enable

namespace Vapi
{
    /// <summary>
    /// This is the type of recording consent.
    /// </summary>
    public enum RecordingConsentType
    {
        /// <summary>
        /// 
        /// </summary>
        StayOnLine,
        /// <summary>
        /// 
        /// </summary>
        Verbal,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RecordingConsentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RecordingConsentType value)
        {
            return value switch
            {
                RecordingConsentType.StayOnLine => "stay-on-line",
                RecordingConsentType.Verbal => "verbal",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RecordingConsentType? ToEnum(string value)
        {
            return value switch
            {
                "stay-on-line" => RecordingConsentType.StayOnLine,
                "verbal" => RecordingConsentType.Verbal,
                _ => null,
            };
        }
    }
}