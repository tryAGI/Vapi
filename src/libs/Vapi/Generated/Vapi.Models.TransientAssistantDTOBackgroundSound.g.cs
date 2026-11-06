
#nullable enable

namespace Vapi
{
    /// <summary>
    /// Example: office
    /// </summary>
    public enum TransientAssistantDTOBackgroundSound
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
    public static class TransientAssistantDTOBackgroundSoundExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TransientAssistantDTOBackgroundSound value)
        {
            return value switch
            {
                TransientAssistantDTOBackgroundSound.City => "city",
                TransientAssistantDTOBackgroundSound.Crowd => "crowd",
                TransientAssistantDTOBackgroundSound.Farm => "farm",
                TransientAssistantDTOBackgroundSound.Off => "off",
                TransientAssistantDTOBackgroundSound.Office => "office",
                TransientAssistantDTOBackgroundSound.WhiteNoise => "white-noise",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TransientAssistantDTOBackgroundSound? ToEnum(string value)
        {
            return value switch
            {
                "city" => TransientAssistantDTOBackgroundSound.City,
                "crowd" => TransientAssistantDTOBackgroundSound.Crowd,
                "farm" => TransientAssistantDTOBackgroundSound.Farm,
                "off" => TransientAssistantDTOBackgroundSound.Off,
                "office" => TransientAssistantDTOBackgroundSound.Office,
                "white-noise" => TransientAssistantDTOBackgroundSound.WhiteNoise,
                _ => null,
            };
        }
    }
}