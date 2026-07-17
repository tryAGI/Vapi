
#nullable enable

namespace Vapi
{
    /// <summary>
    /// 
    /// </summary>
    public enum AssistantVersionVoicemailDetection
    {
        /// <summary>
        /// 
        /// </summary>
        Off,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AssistantVersionVoicemailDetectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AssistantVersionVoicemailDetection value)
        {
            return value switch
            {
                AssistantVersionVoicemailDetection.Off => "off",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AssistantVersionVoicemailDetection? ToEnum(string value)
        {
            return value switch
            {
                "off" => AssistantVersionVoicemailDetection.Off,
                _ => null,
            };
        }
    }
}