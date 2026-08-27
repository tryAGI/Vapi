
#nullable enable

namespace Vapi
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateAssistantDraftDTOVoicemailDetection
    {
        /// <summary>
        ///
        /// </summary>
        Off,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateAssistantDraftDTOVoicemailDetectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateAssistantDraftDTOVoicemailDetection value)
        {
            return value switch
            {
                CreateAssistantDraftDTOVoicemailDetection.Off => "off",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateAssistantDraftDTOVoicemailDetection? ToEnum(string value)
        {
            return value switch
            {
                "off" => CreateAssistantDraftDTOVoicemailDetection.Off,
                _ => null,
            };
        }
    }
}