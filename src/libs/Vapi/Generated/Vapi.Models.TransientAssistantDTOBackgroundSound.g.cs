
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
        Off,
        /// <summary>
        ///
        /// </summary>
        Office,
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
                TransientAssistantDTOBackgroundSound.Off => "off",
                TransientAssistantDTOBackgroundSound.Office => "office",
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
                "off" => TransientAssistantDTOBackgroundSound.Off,
                "office" => TransientAssistantDTOBackgroundSound.Office,
                _ => null,
            };
        }
    }
}