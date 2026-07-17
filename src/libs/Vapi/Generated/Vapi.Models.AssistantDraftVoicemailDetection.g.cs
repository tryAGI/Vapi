
#nullable enable

namespace Vapi
{
    /// <summary>
    /// 
    /// </summary>
    public enum AssistantDraftVoicemailDetection
    {
        /// <summary>
        /// 
        /// </summary>
        Off,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AssistantDraftVoicemailDetectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AssistantDraftVoicemailDetection value)
        {
            return value switch
            {
                AssistantDraftVoicemailDetection.Off => "off",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AssistantDraftVoicemailDetection? ToEnum(string value)
        {
            return value switch
            {
                "off" => AssistantDraftVoicemailDetection.Off,
                _ => null,
            };
        }
    }
}