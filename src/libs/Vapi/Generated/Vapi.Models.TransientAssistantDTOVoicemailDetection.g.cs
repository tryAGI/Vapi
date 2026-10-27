
#nullable enable

namespace Vapi
{
    /// <summary>
    ///
    /// </summary>
    public enum TransientAssistantDTOVoicemailDetection
    {
        /// <summary>
        ///
        /// </summary>
        Off,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TransientAssistantDTOVoicemailDetectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TransientAssistantDTOVoicemailDetection value)
        {
            return value switch
            {
                TransientAssistantDTOVoicemailDetection.Off => "off",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TransientAssistantDTOVoicemailDetection? ToEnum(string value)
        {
            return value switch
            {
                "off" => TransientAssistantDTOVoicemailDetection.Off,
                _ => null,
            };
        }
    }
}