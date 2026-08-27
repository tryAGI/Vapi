
#nullable enable

namespace Vapi
{
    /// <summary>
    /// The type of tool. "dtmf" for DTMF tool.
    /// </summary>
    public enum UpdateDtmfToolDTOType
    {
        /// <summary>
        ///
        /// </summary>
        Dtmf,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateDtmfToolDTOTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateDtmfToolDTOType value)
        {
            return value switch
            {
                UpdateDtmfToolDTOType.Dtmf => "dtmf",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateDtmfToolDTOType? ToEnum(string value)
        {
            return value switch
            {
                "dtmf" => UpdateDtmfToolDTOType.Dtmf,
                _ => null,
            };
        }
    }
}