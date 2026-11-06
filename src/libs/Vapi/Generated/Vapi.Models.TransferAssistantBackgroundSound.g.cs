
#nullable enable

namespace Vapi
{
    /// <summary>
    /// Example: office
    /// </summary>
    public enum TransferAssistantBackgroundSound
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
    public static class TransferAssistantBackgroundSoundExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TransferAssistantBackgroundSound value)
        {
            return value switch
            {
                TransferAssistantBackgroundSound.City => "city",
                TransferAssistantBackgroundSound.Crowd => "crowd",
                TransferAssistantBackgroundSound.Farm => "farm",
                TransferAssistantBackgroundSound.Off => "off",
                TransferAssistantBackgroundSound.Office => "office",
                TransferAssistantBackgroundSound.WhiteNoise => "white-noise",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TransferAssistantBackgroundSound? ToEnum(string value)
        {
            return value switch
            {
                "city" => TransferAssistantBackgroundSound.City,
                "crowd" => TransferAssistantBackgroundSound.Crowd,
                "farm" => TransferAssistantBackgroundSound.Farm,
                "off" => TransferAssistantBackgroundSound.Off,
                "office" => TransferAssistantBackgroundSound.Office,
                "white-noise" => TransferAssistantBackgroundSound.WhiteNoise,
                _ => null,
            };
        }
    }
}