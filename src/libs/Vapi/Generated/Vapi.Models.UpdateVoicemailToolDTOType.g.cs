
#nullable enable

namespace Vapi
{
    /// <summary>
    /// The type of tool. "voicemail" for Voicemail tool.
    /// </summary>
    public enum UpdateVoicemailToolDTOType
    {
        /// <summary>
        ///
        /// </summary>
        Voicemail,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateVoicemailToolDTOTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateVoicemailToolDTOType value)
        {
            return value switch
            {
                UpdateVoicemailToolDTOType.Voicemail => "voicemail",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateVoicemailToolDTOType? ToEnum(string value)
        {
            return value switch
            {
                "voicemail" => UpdateVoicemailToolDTOType.Voicemail,
                _ => null,
            };
        }
    }
}