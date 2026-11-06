
#nullable enable

namespace Vapi
{
    /// <summary>
    /// Example: office
    /// </summary>
    public enum AssistantBackgroundSound
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
    public static class AssistantBackgroundSoundExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AssistantBackgroundSound value)
        {
            return value switch
            {
                AssistantBackgroundSound.City => "city",
                AssistantBackgroundSound.Crowd => "crowd",
                AssistantBackgroundSound.Farm => "farm",
                AssistantBackgroundSound.Off => "off",
                AssistantBackgroundSound.Office => "office",
                AssistantBackgroundSound.WhiteNoise => "white-noise",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AssistantBackgroundSound? ToEnum(string value)
        {
            return value switch
            {
                "city" => AssistantBackgroundSound.City,
                "crowd" => AssistantBackgroundSound.Crowd,
                "farm" => AssistantBackgroundSound.Farm,
                "off" => AssistantBackgroundSound.Off,
                "office" => AssistantBackgroundSound.Office,
                "white-noise" => AssistantBackgroundSound.WhiteNoise,
                _ => null,
            };
        }
    }
}