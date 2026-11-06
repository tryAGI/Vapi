
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
        City,
        /// <summary>
        ///
        /// </summary>
        Crowd,
        /// <summary>
        ///
        /// </summary>
        Farm,
        /// <summary>
        ///
        /// </summary>
        Off,
        /// <summary>
        ///
        /// </summary>
        Office,
        /// <summary>
        ///
        /// </summary>
        WhiteNoise,
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
                CreateAssistantDraftDTOBackgroundSound.City => "city",
                CreateAssistantDraftDTOBackgroundSound.Crowd => "crowd",
                CreateAssistantDraftDTOBackgroundSound.Farm => "farm",
                CreateAssistantDraftDTOBackgroundSound.Off => "off",
                CreateAssistantDraftDTOBackgroundSound.Office => "office",
                CreateAssistantDraftDTOBackgroundSound.WhiteNoise => "white-noise",
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
                "city" => CreateAssistantDraftDTOBackgroundSound.City,
                "crowd" => CreateAssistantDraftDTOBackgroundSound.Crowd,
                "farm" => CreateAssistantDraftDTOBackgroundSound.Farm,
                "off" => CreateAssistantDraftDTOBackgroundSound.Off,
                "office" => CreateAssistantDraftDTOBackgroundSound.Office,
                "white-noise" => CreateAssistantDraftDTOBackgroundSound.WhiteNoise,
                _ => null,
            };
        }
    }
}