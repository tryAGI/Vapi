
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
        Off,
        /// <summary>
        /// 
        /// </summary>
        Office,
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
                AssistantDraftBackgroundSound.Off => "off",
                AssistantDraftBackgroundSound.Office => "office",
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
                "off" => AssistantDraftBackgroundSound.Off,
                "office" => AssistantDraftBackgroundSound.Office,
                _ => null,
            };
        }
    }
}