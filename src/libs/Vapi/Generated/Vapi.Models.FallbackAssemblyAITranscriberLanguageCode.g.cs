
#nullable enable

namespace Vapi
{
    /// <summary>
    /// 
    /// </summary>
    public enum FallbackAssemblyAITranscriberLanguageCode
    {
        /// <summary>
        /// 
        /// </summary>
        Ar,
        /// <summary>
        /// 
        /// </summary>
        Da,
        /// <summary>
        /// 
        /// </summary>
        De,
        /// <summary>
        /// 
        /// </summary>
        En,
        /// <summary>
        /// 
        /// </summary>
        Es,
        /// <summary>
        /// 
        /// </summary>
        Fi,
        /// <summary>
        /// 
        /// </summary>
        Fr,
        /// <summary>
        /// 
        /// </summary>
        He,
        /// <summary>
        /// 
        /// </summary>
        Hi,
        /// <summary>
        /// 
        /// </summary>
        It,
        /// <summary>
        /// 
        /// </summary>
        Ja,
        /// <summary>
        /// 
        /// </summary>
        Nl,
        /// <summary>
        /// 
        /// </summary>
        No,
        /// <summary>
        /// 
        /// </summary>
        Pt,
        /// <summary>
        /// 
        /// </summary>
        Sv,
        /// <summary>
        /// 
        /// </summary>
        Tr,
        /// <summary>
        /// 
        /// </summary>
        Vi,
        /// <summary>
        /// 
        /// </summary>
        Zh,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FallbackAssemblyAITranscriberLanguageCodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FallbackAssemblyAITranscriberLanguageCode value)
        {
            return value switch
            {
                FallbackAssemblyAITranscriberLanguageCode.Ar => "ar",
                FallbackAssemblyAITranscriberLanguageCode.Da => "da",
                FallbackAssemblyAITranscriberLanguageCode.De => "de",
                FallbackAssemblyAITranscriberLanguageCode.En => "en",
                FallbackAssemblyAITranscriberLanguageCode.Es => "es",
                FallbackAssemblyAITranscriberLanguageCode.Fi => "fi",
                FallbackAssemblyAITranscriberLanguageCode.Fr => "fr",
                FallbackAssemblyAITranscriberLanguageCode.He => "he",
                FallbackAssemblyAITranscriberLanguageCode.Hi => "hi",
                FallbackAssemblyAITranscriberLanguageCode.It => "it",
                FallbackAssemblyAITranscriberLanguageCode.Ja => "ja",
                FallbackAssemblyAITranscriberLanguageCode.Nl => "nl",
                FallbackAssemblyAITranscriberLanguageCode.No => "no",
                FallbackAssemblyAITranscriberLanguageCode.Pt => "pt",
                FallbackAssemblyAITranscriberLanguageCode.Sv => "sv",
                FallbackAssemblyAITranscriberLanguageCode.Tr => "tr",
                FallbackAssemblyAITranscriberLanguageCode.Vi => "vi",
                FallbackAssemblyAITranscriberLanguageCode.Zh => "zh",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FallbackAssemblyAITranscriberLanguageCode? ToEnum(string value)
        {
            return value switch
            {
                "ar" => FallbackAssemblyAITranscriberLanguageCode.Ar,
                "da" => FallbackAssemblyAITranscriberLanguageCode.Da,
                "de" => FallbackAssemblyAITranscriberLanguageCode.De,
                "en" => FallbackAssemblyAITranscriberLanguageCode.En,
                "es" => FallbackAssemblyAITranscriberLanguageCode.Es,
                "fi" => FallbackAssemblyAITranscriberLanguageCode.Fi,
                "fr" => FallbackAssemblyAITranscriberLanguageCode.Fr,
                "he" => FallbackAssemblyAITranscriberLanguageCode.He,
                "hi" => FallbackAssemblyAITranscriberLanguageCode.Hi,
                "it" => FallbackAssemblyAITranscriberLanguageCode.It,
                "ja" => FallbackAssemblyAITranscriberLanguageCode.Ja,
                "nl" => FallbackAssemblyAITranscriberLanguageCode.Nl,
                "no" => FallbackAssemblyAITranscriberLanguageCode.No,
                "pt" => FallbackAssemblyAITranscriberLanguageCode.Pt,
                "sv" => FallbackAssemblyAITranscriberLanguageCode.Sv,
                "tr" => FallbackAssemblyAITranscriberLanguageCode.Tr,
                "vi" => FallbackAssemblyAITranscriberLanguageCode.Vi,
                "zh" => FallbackAssemblyAITranscriberLanguageCode.Zh,
                _ => null,
            };
        }
    }
}