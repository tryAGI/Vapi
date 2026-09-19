
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
        Af,
        /// <summary>
        ///
        /// </summary>
        Ar,
        /// <summary>
        ///
        /// </summary>
        Ca,
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
        Et,
        /// <summary>
        ///
        /// </summary>
        Fa,
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
        Gl,
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
        Ko,
        /// <summary>
        ///
        /// </summary>
        Mr,
        /// <summary>
        ///
        /// </summary>
        Nl,
        /// <summary>
        ///
        /// </summary>
        Nn,
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
        Ro,
        /// <summary>
        ///
        /// </summary>
        Ru,
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
        Ur,
        /// <summary>
        ///
        /// </summary>
        Vi,
        /// <summary>
        ///
        /// </summary>
        Xh,
        /// <summary>
        ///
        /// </summary>
        Yue,
        /// <summary>
        ///
        /// </summary>
        Zh,
        /// <summary>
        ///
        /// </summary>
        Zu,
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
                FallbackAssemblyAITranscriberLanguageCode.Af => "af",
                FallbackAssemblyAITranscriberLanguageCode.Ar => "ar",
                FallbackAssemblyAITranscriberLanguageCode.Ca => "ca",
                FallbackAssemblyAITranscriberLanguageCode.Da => "da",
                FallbackAssemblyAITranscriberLanguageCode.De => "de",
                FallbackAssemblyAITranscriberLanguageCode.En => "en",
                FallbackAssemblyAITranscriberLanguageCode.Es => "es",
                FallbackAssemblyAITranscriberLanguageCode.Et => "et",
                FallbackAssemblyAITranscriberLanguageCode.Fa => "fa",
                FallbackAssemblyAITranscriberLanguageCode.Fi => "fi",
                FallbackAssemblyAITranscriberLanguageCode.Fr => "fr",
                FallbackAssemblyAITranscriberLanguageCode.Gl => "gl",
                FallbackAssemblyAITranscriberLanguageCode.He => "he",
                FallbackAssemblyAITranscriberLanguageCode.Hi => "hi",
                FallbackAssemblyAITranscriberLanguageCode.It => "it",
                FallbackAssemblyAITranscriberLanguageCode.Ja => "ja",
                FallbackAssemblyAITranscriberLanguageCode.Ko => "ko",
                FallbackAssemblyAITranscriberLanguageCode.Mr => "mr",
                FallbackAssemblyAITranscriberLanguageCode.Nl => "nl",
                FallbackAssemblyAITranscriberLanguageCode.Nn => "nn",
                FallbackAssemblyAITranscriberLanguageCode.No => "no",
                FallbackAssemblyAITranscriberLanguageCode.Pt => "pt",
                FallbackAssemblyAITranscriberLanguageCode.Ro => "ro",
                FallbackAssemblyAITranscriberLanguageCode.Ru => "ru",
                FallbackAssemblyAITranscriberLanguageCode.Sv => "sv",
                FallbackAssemblyAITranscriberLanguageCode.Tr => "tr",
                FallbackAssemblyAITranscriberLanguageCode.Ur => "ur",
                FallbackAssemblyAITranscriberLanguageCode.Vi => "vi",
                FallbackAssemblyAITranscriberLanguageCode.Xh => "xh",
                FallbackAssemblyAITranscriberLanguageCode.Yue => "yue",
                FallbackAssemblyAITranscriberLanguageCode.Zh => "zh",
                FallbackAssemblyAITranscriberLanguageCode.Zu => "zu",
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
                "af" => FallbackAssemblyAITranscriberLanguageCode.Af,
                "ar" => FallbackAssemblyAITranscriberLanguageCode.Ar,
                "ca" => FallbackAssemblyAITranscriberLanguageCode.Ca,
                "da" => FallbackAssemblyAITranscriberLanguageCode.Da,
                "de" => FallbackAssemblyAITranscriberLanguageCode.De,
                "en" => FallbackAssemblyAITranscriberLanguageCode.En,
                "es" => FallbackAssemblyAITranscriberLanguageCode.Es,
                "et" => FallbackAssemblyAITranscriberLanguageCode.Et,
                "fa" => FallbackAssemblyAITranscriberLanguageCode.Fa,
                "fi" => FallbackAssemblyAITranscriberLanguageCode.Fi,
                "fr" => FallbackAssemblyAITranscriberLanguageCode.Fr,
                "gl" => FallbackAssemblyAITranscriberLanguageCode.Gl,
                "he" => FallbackAssemblyAITranscriberLanguageCode.He,
                "hi" => FallbackAssemblyAITranscriberLanguageCode.Hi,
                "it" => FallbackAssemblyAITranscriberLanguageCode.It,
                "ja" => FallbackAssemblyAITranscriberLanguageCode.Ja,
                "ko" => FallbackAssemblyAITranscriberLanguageCode.Ko,
                "mr" => FallbackAssemblyAITranscriberLanguageCode.Mr,
                "nl" => FallbackAssemblyAITranscriberLanguageCode.Nl,
                "nn" => FallbackAssemblyAITranscriberLanguageCode.Nn,
                "no" => FallbackAssemblyAITranscriberLanguageCode.No,
                "pt" => FallbackAssemblyAITranscriberLanguageCode.Pt,
                "ro" => FallbackAssemblyAITranscriberLanguageCode.Ro,
                "ru" => FallbackAssemblyAITranscriberLanguageCode.Ru,
                "sv" => FallbackAssemblyAITranscriberLanguageCode.Sv,
                "tr" => FallbackAssemblyAITranscriberLanguageCode.Tr,
                "ur" => FallbackAssemblyAITranscriberLanguageCode.Ur,
                "vi" => FallbackAssemblyAITranscriberLanguageCode.Vi,
                "xh" => FallbackAssemblyAITranscriberLanguageCode.Xh,
                "yue" => FallbackAssemblyAITranscriberLanguageCode.Yue,
                "zh" => FallbackAssemblyAITranscriberLanguageCode.Zh,
                "zu" => FallbackAssemblyAITranscriberLanguageCode.Zu,
                _ => null,
            };
        }
    }
}