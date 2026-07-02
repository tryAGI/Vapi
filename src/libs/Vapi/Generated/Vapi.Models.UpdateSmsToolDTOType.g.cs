
#nullable enable

namespace Vapi
{
    /// <summary>
    /// The type of tool. "sms" for Twilio SMS sending tool.
    /// </summary>
    public enum UpdateSmsToolDTOType
    {
        /// <summary>
        /// 
        /// </summary>
        Sms,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateSmsToolDTOTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateSmsToolDTOType value)
        {
            return value switch
            {
                UpdateSmsToolDTOType.Sms => "sms",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateSmsToolDTOType? ToEnum(string value)
        {
            return value switch
            {
                "sms" => UpdateSmsToolDTOType.Sms,
                _ => null,
            };
        }
    }
}