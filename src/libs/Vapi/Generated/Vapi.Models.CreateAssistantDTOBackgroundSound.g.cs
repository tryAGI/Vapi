
#nullable enable

namespace Vapi
{
    /// <summary>
    /// Example: office
    /// </summary>
    public enum CreateAssistantDTOBackgroundSound
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
    public static class CreateAssistantDTOBackgroundSoundExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateAssistantDTOBackgroundSound value)
        {
            return value switch
            {
                CreateAssistantDTOBackgroundSound.City => "city",
                CreateAssistantDTOBackgroundSound.Crowd => "crowd",
                CreateAssistantDTOBackgroundSound.Farm => "farm",
                CreateAssistantDTOBackgroundSound.Off => "off",
                CreateAssistantDTOBackgroundSound.Office => "office",
                CreateAssistantDTOBackgroundSound.WhiteNoise => "white-noise",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateAssistantDTOBackgroundSound? ToEnum(string value)
        {
            return value switch
            {
                "city" => CreateAssistantDTOBackgroundSound.City,
                "crowd" => CreateAssistantDTOBackgroundSound.Crowd,
                "farm" => CreateAssistantDTOBackgroundSound.Farm,
                "off" => CreateAssistantDTOBackgroundSound.Off,
                "office" => CreateAssistantDTOBackgroundSound.Office,
                "white-noise" => CreateAssistantDTOBackgroundSound.WhiteNoise,
                _ => null,
            };
        }
    }
}