
#nullable enable

namespace Vapi
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateAssistantDraftDTOVoicemailDetection
    {
        /// <summary>
        /// 
        /// </summary>
        Off,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateAssistantDraftDTOVoicemailDetectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateAssistantDraftDTOVoicemailDetection value)
        {
            return value switch
            {
                UpdateAssistantDraftDTOVoicemailDetection.Off => "off",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateAssistantDraftDTOVoicemailDetection? ToEnum(string value)
        {
            return value switch
            {
                "off" => UpdateAssistantDraftDTOVoicemailDetection.Off,
                _ => null,
            };
        }
    }
}