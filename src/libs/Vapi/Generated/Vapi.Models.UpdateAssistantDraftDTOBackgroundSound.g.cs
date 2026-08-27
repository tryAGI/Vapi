
#nullable enable

namespace Vapi
{
    /// <summary>
    /// Example: office
    /// </summary>
    public enum UpdateAssistantDraftDTOBackgroundSound
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
    public static class UpdateAssistantDraftDTOBackgroundSoundExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateAssistantDraftDTOBackgroundSound value)
        {
            return value switch
            {
                UpdateAssistantDraftDTOBackgroundSound.Off => "off",
                UpdateAssistantDraftDTOBackgroundSound.Office => "office",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateAssistantDraftDTOBackgroundSound? ToEnum(string value)
        {
            return value switch
            {
                "off" => UpdateAssistantDraftDTOBackgroundSound.Off,
                "office" => UpdateAssistantDraftDTOBackgroundSound.Office,
                _ => null,
            };
        }
    }
}