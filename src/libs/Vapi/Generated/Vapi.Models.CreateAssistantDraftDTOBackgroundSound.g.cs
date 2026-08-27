
#nullable enable

namespace Vapi
{
    /// <summary>
    /// Example: office
    /// </summary>
    public enum CreateAssistantDraftDTOBackgroundSound
    {
        /// <summary>
        ///
        /// </summary>
        Off,
        /// <summary>
        ///
        /// </summary>
        Office,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateAssistantDraftDTOBackgroundSoundExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateAssistantDraftDTOBackgroundSound value)
        {
            return value switch
            {
                CreateAssistantDraftDTOBackgroundSound.Off => "off",
                CreateAssistantDraftDTOBackgroundSound.Office => "office",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateAssistantDraftDTOBackgroundSound? ToEnum(string value)
        {
            return value switch
            {
                "off" => CreateAssistantDraftDTOBackgroundSound.Off,
                "office" => CreateAssistantDraftDTOBackgroundSound.Office,
                _ => null,
            };
        }
    }
}