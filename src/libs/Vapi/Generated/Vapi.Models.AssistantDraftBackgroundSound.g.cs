
#nullable enable

namespace Vapi
{
    /// <summary>
    /// Example: office
    /// </summary>
    public enum AssistantDraftBackgroundSound
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
    public static class AssistantDraftBackgroundSoundExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AssistantDraftBackgroundSound value)
        {
            return value switch
            {
                AssistantDraftBackgroundSound.City => "city",
                AssistantDraftBackgroundSound.Crowd => "crowd",
                AssistantDraftBackgroundSound.Farm => "farm",
                AssistantDraftBackgroundSound.Off => "off",
                AssistantDraftBackgroundSound.Office => "office",
                AssistantDraftBackgroundSound.WhiteNoise => "white-noise",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AssistantDraftBackgroundSound? ToEnum(string value)
        {
            return value switch
            {
                "city" => AssistantDraftBackgroundSound.City,
                "crowd" => AssistantDraftBackgroundSound.Crowd,
                "farm" => AssistantDraftBackgroundSound.Farm,
                "off" => AssistantDraftBackgroundSound.Off,
                "office" => AssistantDraftBackgroundSound.Office,
                "white-noise" => AssistantDraftBackgroundSound.WhiteNoise,
                _ => null,
            };
        }
    }
}