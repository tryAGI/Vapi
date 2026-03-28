
#nullable enable

namespace Vapi
{
    /// <summary>
    /// 
    /// </summary>
    public enum LMNTVoiceLanguageAutoDetect
    {
        /// <summary>
        /// 
        /// </summary>
        Auto,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LMNTVoiceLanguageAutoDetectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LMNTVoiceLanguageAutoDetect value)
        {
            return value switch
            {
                LMNTVoiceLanguageAutoDetect.Auto => "auto",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LMNTVoiceLanguageAutoDetect? ToEnum(string value)
        {
            return value switch
            {
                "auto" => LMNTVoiceLanguageAutoDetect.Auto,
                _ => null,
            };
        }
    }
}