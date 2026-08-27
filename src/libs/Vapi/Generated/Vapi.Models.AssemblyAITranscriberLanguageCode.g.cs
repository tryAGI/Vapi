
#nullable enable

namespace Vapi
{
    /// <summary>
    ///
    /// </summary>
    public enum AssemblyAITranscriberLanguageCode
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
    public static class AssemblyAITranscriberLanguageCodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AssemblyAITranscriberLanguageCode value)
        {
            return value switch
            {
                AssemblyAITranscriberLanguageCode.Ar => "ar",
                AssemblyAITranscriberLanguageCode.Da => "da",
                AssemblyAITranscriberLanguageCode.De => "de",
                AssemblyAITranscriberLanguageCode.En => "en",
                AssemblyAITranscriberLanguageCode.Es => "es",
                AssemblyAITranscriberLanguageCode.Fi => "fi",
                AssemblyAITranscriberLanguageCode.Fr => "fr",
                AssemblyAITranscriberLanguageCode.He => "he",
                AssemblyAITranscriberLanguageCode.Hi => "hi",
                AssemblyAITranscriberLanguageCode.It => "it",
                AssemblyAITranscriberLanguageCode.Ja => "ja",
                AssemblyAITranscriberLanguageCode.Nl => "nl",
                AssemblyAITranscriberLanguageCode.No => "no",
                AssemblyAITranscriberLanguageCode.Pt => "pt",
                AssemblyAITranscriberLanguageCode.Sv => "sv",
                AssemblyAITranscriberLanguageCode.Tr => "tr",
                AssemblyAITranscriberLanguageCode.Vi => "vi",
                AssemblyAITranscriberLanguageCode.Zh => "zh",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AssemblyAITranscriberLanguageCode? ToEnum(string value)
        {
            return value switch
            {
                "ar" => AssemblyAITranscriberLanguageCode.Ar,
                "da" => AssemblyAITranscriberLanguageCode.Da,
                "de" => AssemblyAITranscriberLanguageCode.De,
                "en" => AssemblyAITranscriberLanguageCode.En,
                "es" => AssemblyAITranscriberLanguageCode.Es,
                "fi" => AssemblyAITranscriberLanguageCode.Fi,
                "fr" => AssemblyAITranscriberLanguageCode.Fr,
                "he" => AssemblyAITranscriberLanguageCode.He,
                "hi" => AssemblyAITranscriberLanguageCode.Hi,
                "it" => AssemblyAITranscriberLanguageCode.It,
                "ja" => AssemblyAITranscriberLanguageCode.Ja,
                "nl" => AssemblyAITranscriberLanguageCode.Nl,
                "no" => AssemblyAITranscriberLanguageCode.No,
                "pt" => AssemblyAITranscriberLanguageCode.Pt,
                "sv" => AssemblyAITranscriberLanguageCode.Sv,
                "tr" => AssemblyAITranscriberLanguageCode.Tr,
                "vi" => AssemblyAITranscriberLanguageCode.Vi,
                "zh" => AssemblyAITranscriberLanguageCode.Zh,
                _ => null,
            };
        }
    }
}