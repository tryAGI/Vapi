
#nullable enable

namespace Vapi
{
    /// <summary>
    /// Example: office
    /// </summary>
    public enum UpdateAssistantDTOBackgroundSound
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
    public static class UpdateAssistantDTOBackgroundSoundExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateAssistantDTOBackgroundSound value)
        {
            return value switch
            {
                UpdateAssistantDTOBackgroundSound.City => "city",
                UpdateAssistantDTOBackgroundSound.Crowd => "crowd",
                UpdateAssistantDTOBackgroundSound.Farm => "farm",
                UpdateAssistantDTOBackgroundSound.Off => "off",
                UpdateAssistantDTOBackgroundSound.Office => "office",
                UpdateAssistantDTOBackgroundSound.WhiteNoise => "white-noise",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateAssistantDTOBackgroundSound? ToEnum(string value)
        {
            return value switch
            {
                "city" => UpdateAssistantDTOBackgroundSound.City,
                "crowd" => UpdateAssistantDTOBackgroundSound.Crowd,
                "farm" => UpdateAssistantDTOBackgroundSound.Farm,
                "off" => UpdateAssistantDTOBackgroundSound.Off,
                "office" => UpdateAssistantDTOBackgroundSound.Office,
                "white-noise" => UpdateAssistantDTOBackgroundSound.WhiteNoise,
                _ => null,
            };
        }
    }
}