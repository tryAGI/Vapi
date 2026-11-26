
#nullable enable

namespace Vapi
{
    /// <summary>
    /// Example: office
    /// </summary>
    public enum AssistantSaveResponseBackgroundSound
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
    public static class AssistantSaveResponseBackgroundSoundExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AssistantSaveResponseBackgroundSound value)
        {
            return value switch
            {
                AssistantSaveResponseBackgroundSound.City => "city",
                AssistantSaveResponseBackgroundSound.Crowd => "crowd",
                AssistantSaveResponseBackgroundSound.Farm => "farm",
                AssistantSaveResponseBackgroundSound.Off => "off",
                AssistantSaveResponseBackgroundSound.Office => "office",
                AssistantSaveResponseBackgroundSound.WhiteNoise => "white-noise",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AssistantSaveResponseBackgroundSound? ToEnum(string value)
        {
            return value switch
            {
                "city" => AssistantSaveResponseBackgroundSound.City,
                "crowd" => AssistantSaveResponseBackgroundSound.Crowd,
                "farm" => AssistantSaveResponseBackgroundSound.Farm,
                "off" => AssistantSaveResponseBackgroundSound.Off,
                "office" => AssistantSaveResponseBackgroundSound.Office,
                "white-noise" => AssistantSaveResponseBackgroundSound.WhiteNoise,
                _ => null,
            };
        }
    }
}