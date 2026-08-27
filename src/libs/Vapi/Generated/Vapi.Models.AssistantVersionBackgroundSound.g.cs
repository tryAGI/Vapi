
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
        Off,
        /// <summary>
        ///
        /// </summary>
        Office,
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
                AssistantVersionBackgroundSound.Off => "off",
                AssistantVersionBackgroundSound.Office => "office",
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
                "off" => AssistantVersionBackgroundSound.Off,
                "office" => AssistantVersionBackgroundSound.Office,
                _ => null,
            };
        }
    }
}