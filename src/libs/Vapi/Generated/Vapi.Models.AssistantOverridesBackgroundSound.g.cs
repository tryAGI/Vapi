
#nullable enable

namespace Vapi
{
    /// <summary>
    /// Example: office
    /// </summary>
    public enum AssistantOverridesBackgroundSound
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
    public static class AssistantOverridesBackgroundSoundExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AssistantOverridesBackgroundSound value)
        {
            return value switch
            {
                AssistantOverridesBackgroundSound.City => "city",
                AssistantOverridesBackgroundSound.Crowd => "crowd",
                AssistantOverridesBackgroundSound.Farm => "farm",
                AssistantOverridesBackgroundSound.Off => "off",
                AssistantOverridesBackgroundSound.Office => "office",
                AssistantOverridesBackgroundSound.WhiteNoise => "white-noise",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AssistantOverridesBackgroundSound? ToEnum(string value)
        {
            return value switch
            {
                "city" => AssistantOverridesBackgroundSound.City,
                "crowd" => AssistantOverridesBackgroundSound.Crowd,
                "farm" => AssistantOverridesBackgroundSound.Farm,
                "off" => AssistantOverridesBackgroundSound.Off,
                "office" => AssistantOverridesBackgroundSound.Office,
                "white-noise" => AssistantOverridesBackgroundSound.WhiteNoise,
                _ => null,
            };
        }
    }
}