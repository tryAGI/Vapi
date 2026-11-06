
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
    public static class UpdateAssistantDraftDTOBackgroundSoundExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateAssistantDraftDTOBackgroundSound value)
        {
            return value switch
            {
                UpdateAssistantDraftDTOBackgroundSound.City => "city",
                UpdateAssistantDraftDTOBackgroundSound.Crowd => "crowd",
                UpdateAssistantDraftDTOBackgroundSound.Farm => "farm",
                UpdateAssistantDraftDTOBackgroundSound.Off => "off",
                UpdateAssistantDraftDTOBackgroundSound.Office => "office",
                UpdateAssistantDraftDTOBackgroundSound.WhiteNoise => "white-noise",
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
                "city" => UpdateAssistantDraftDTOBackgroundSound.City,
                "crowd" => UpdateAssistantDraftDTOBackgroundSound.Crowd,
                "farm" => UpdateAssistantDraftDTOBackgroundSound.Farm,
                "off" => UpdateAssistantDraftDTOBackgroundSound.Off,
                "office" => UpdateAssistantDraftDTOBackgroundSound.Office,
                "white-noise" => UpdateAssistantDraftDTOBackgroundSound.WhiteNoise,
                _ => null,
            };
        }
    }
}