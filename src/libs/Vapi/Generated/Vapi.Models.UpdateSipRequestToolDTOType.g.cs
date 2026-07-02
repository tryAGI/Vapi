
#nullable enable

namespace Vapi
{
    /// <summary>
    /// The type of tool. "sipRequest" for SIP request tool.
    /// </summary>
    public enum UpdateSipRequestToolDTOType
    {
        /// <summary>
        /// 
        /// </summary>
        SipRequest,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateSipRequestToolDTOTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateSipRequestToolDTOType value)
        {
            return value switch
            {
                UpdateSipRequestToolDTOType.SipRequest => "sipRequest",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateSipRequestToolDTOType? ToEnum(string value)
        {
            return value switch
            {
                "sipRequest" => UpdateSipRequestToolDTOType.SipRequest,
                _ => null,
            };
        }
    }
}