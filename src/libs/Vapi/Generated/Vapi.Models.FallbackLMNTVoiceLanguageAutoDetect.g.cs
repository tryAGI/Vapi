
#nullable enable

namespace Vapi
{
    /// <summary>
    /// 
    /// </summary>
    public enum FallbackLMNTVoiceLanguageAutoDetect
    {
        /// <summary>
        /// 
        /// </summary>
        Auto,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FallbackLMNTVoiceLanguageAutoDetectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FallbackLMNTVoiceLanguageAutoDetect value)
        {
            return value switch
            {
                FallbackLMNTVoiceLanguageAutoDetect.Auto => "auto",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FallbackLMNTVoiceLanguageAutoDetect? ToEnum(string value)
        {
            return value switch
            {
                "auto" => FallbackLMNTVoiceLanguageAutoDetect.Auto,
                _ => null,
            };
        }
    }
}