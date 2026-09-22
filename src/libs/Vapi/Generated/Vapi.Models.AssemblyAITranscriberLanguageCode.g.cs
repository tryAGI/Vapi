
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
    public static class AssemblyAITranscriberLanguageCodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AssemblyAITranscriberLanguageCode value)
        {
            return value switch
            {
                AssemblyAITranscriberLanguageCode.Af => "af",
                AssemblyAITranscriberLanguageCode.Ar => "ar",
                AssemblyAITranscriberLanguageCode.Ca => "ca",
                AssemblyAITranscriberLanguageCode.Da => "da",
                AssemblyAITranscriberLanguageCode.De => "de",
                AssemblyAITranscriberLanguageCode.En => "en",
                AssemblyAITranscriberLanguageCode.Es => "es",
                AssemblyAITranscriberLanguageCode.Et => "et",
                AssemblyAITranscriberLanguageCode.Fa => "fa",
                AssemblyAITranscriberLanguageCode.Fi => "fi",
                AssemblyAITranscriberLanguageCode.Fr => "fr",
                AssemblyAITranscriberLanguageCode.Gl => "gl",
                AssemblyAITranscriberLanguageCode.He => "he",
                AssemblyAITranscriberLanguageCode.Hi => "hi",
                AssemblyAITranscriberLanguageCode.It => "it",
                AssemblyAITranscriberLanguageCode.Ja => "ja",
                AssemblyAITranscriberLanguageCode.Ko => "ko",
                AssemblyAITranscriberLanguageCode.Mr => "mr",
                AssemblyAITranscriberLanguageCode.Nl => "nl",
                AssemblyAITranscriberLanguageCode.Nn => "nn",
                AssemblyAITranscriberLanguageCode.No => "no",
                AssemblyAITranscriberLanguageCode.Pt => "pt",
                AssemblyAITranscriberLanguageCode.Ro => "ro",
                AssemblyAITranscriberLanguageCode.Ru => "ru",
                AssemblyAITranscriberLanguageCode.Sv => "sv",
                AssemblyAITranscriberLanguageCode.Tr => "tr",
                AssemblyAITranscriberLanguageCode.Ur => "ur",
                AssemblyAITranscriberLanguageCode.Vi => "vi",
                AssemblyAITranscriberLanguageCode.Xh => "xh",
                AssemblyAITranscriberLanguageCode.Yue => "yue",
                AssemblyAITranscriberLanguageCode.Zh => "zh",
                AssemblyAITranscriberLanguageCode.Zu => "zu",
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
                "af" => AssemblyAITranscriberLanguageCode.Af,
                "ar" => AssemblyAITranscriberLanguageCode.Ar,
                "ca" => AssemblyAITranscriberLanguageCode.Ca,
                "da" => AssemblyAITranscriberLanguageCode.Da,
                "de" => AssemblyAITranscriberLanguageCode.De,
                "en" => AssemblyAITranscriberLanguageCode.En,
                "es" => AssemblyAITranscriberLanguageCode.Es,
                "et" => AssemblyAITranscriberLanguageCode.Et,
                "fa" => AssemblyAITranscriberLanguageCode.Fa,
                "fi" => AssemblyAITranscriberLanguageCode.Fi,
                "fr" => AssemblyAITranscriberLanguageCode.Fr,
                "gl" => AssemblyAITranscriberLanguageCode.Gl,
                "he" => AssemblyAITranscriberLanguageCode.He,
                "hi" => AssemblyAITranscriberLanguageCode.Hi,
                "it" => AssemblyAITranscriberLanguageCode.It,
                "ja" => AssemblyAITranscriberLanguageCode.Ja,
                "ko" => AssemblyAITranscriberLanguageCode.Ko,
                "mr" => AssemblyAITranscriberLanguageCode.Mr,
                "nl" => AssemblyAITranscriberLanguageCode.Nl,
                "nn" => AssemblyAITranscriberLanguageCode.Nn,
                "no" => AssemblyAITranscriberLanguageCode.No,
                "pt" => AssemblyAITranscriberLanguageCode.Pt,
                "ro" => AssemblyAITranscriberLanguageCode.Ro,
                "ru" => AssemblyAITranscriberLanguageCode.Ru,
                "sv" => AssemblyAITranscriberLanguageCode.Sv,
                "tr" => AssemblyAITranscriberLanguageCode.Tr,
                "ur" => AssemblyAITranscriberLanguageCode.Ur,
                "vi" => AssemblyAITranscriberLanguageCode.Vi,
                "xh" => AssemblyAITranscriberLanguageCode.Xh,
                "yue" => AssemblyAITranscriberLanguageCode.Yue,
                "zh" => AssemblyAITranscriberLanguageCode.Zh,
                "zu" => AssemblyAITranscriberLanguageCode.Zu,
                _ => null,
            };
        }
    }
}