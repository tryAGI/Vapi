
#nullable enable

namespace Vapi
{
    /// <summary>
    /// Example: office
    /// </summary>
    public enum AssistantVersionBackgroundSound
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
    public static class AssistantVersionBackgroundSoundExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AssistantVersionBackgroundSound value)
        {
            return value switch
            {
                AssistantVersionBackgroundSound.City => "city",
                AssistantVersionBackgroundSound.Crowd => "crowd",
                AssistantVersionBackgroundSound.Farm => "farm",
                AssistantVersionBackgroundSound.Off => "off",
                AssistantVersionBackgroundSound.Office => "office",
                AssistantVersionBackgroundSound.WhiteNoise => "white-noise",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AssistantVersionBackgroundSound? ToEnum(string value)
        {
            return value switch
            {
                "city" => AssistantVersionBackgroundSound.City,
                "crowd" => AssistantVersionBackgroundSound.Crowd,
                "farm" => AssistantVersionBackgroundSound.Farm,
                "off" => AssistantVersionBackgroundSound.Off,
                "office" => AssistantVersionBackgroundSound.Office,
                "white-noise" => AssistantVersionBackgroundSound.WhiteNoise,
                _ => null,
            };
        }
    }
}