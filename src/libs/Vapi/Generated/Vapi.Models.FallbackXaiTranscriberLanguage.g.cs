
#nullable enable

namespace Vapi
{
    /// <summary>
    /// Single language for transcription as an ISO 639-1 code (e.g., `en`, `es`). Defaults to `en` if not set. xAI auto-detects when omitted via the API but Vapi defaults to English for deterministic behavior.
    /// </summary>
    public enum FallbackXaiTranscriberLanguage
    {
        /// <summary>
        /// 
        /// </summary>
        Ar,
        /// <summary>
        /// 
        /// </summary>
        Cs,
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
        Fa,
        /// <summary>
        /// 
        /// </summary>
        Fil,
        /// <summary>
        /// 
        /// </summary>
        Fr,
        /// <summary>
        /// 
        /// </summary>
        Hi,
        /// <summary>
        /// 
        /// </summary>
        Id,
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
        Mk,
        /// <summary>
        /// 
        /// </summary>
        Ms,
        /// <summary>
        /// 
        /// </summary>
        Nl,
        /// <summary>
        /// 
        /// </summary>
        Pl,
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
        Th,
        /// <summary>
        /// 
        /// </summary>
        Tr,
        /// <summary>
        /// 
        /// </summary>
        Vi,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FallbackXaiTranscriberLanguageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FallbackXaiTranscriberLanguage value)
        {
            return value switch
            {
                FallbackXaiTranscriberLanguage.Ar => "ar",
                FallbackXaiTranscriberLanguage.Cs => "cs",
                FallbackXaiTranscriberLanguage.Da => "da",
                FallbackXaiTranscriberLanguage.De => "de",
                FallbackXaiTranscriberLanguage.En => "en",
                FallbackXaiTranscriberLanguage.Es => "es",
                FallbackXaiTranscriberLanguage.Fa => "fa",
                FallbackXaiTranscriberLanguage.Fil => "fil",
                FallbackXaiTranscriberLanguage.Fr => "fr",
                FallbackXaiTranscriberLanguage.Hi => "hi",
                FallbackXaiTranscriberLanguage.Id => "id",
                FallbackXaiTranscriberLanguage.It => "it",
                FallbackXaiTranscriberLanguage.Ja => "ja",
                FallbackXaiTranscriberLanguage.Ko => "ko",
                FallbackXaiTranscriberLanguage.Mk => "mk",
                FallbackXaiTranscriberLanguage.Ms => "ms",
                FallbackXaiTranscriberLanguage.Nl => "nl",
                FallbackXaiTranscriberLanguage.Pl => "pl",
                FallbackXaiTranscriberLanguage.Pt => "pt",
                FallbackXaiTranscriberLanguage.Ro => "ro",
                FallbackXaiTranscriberLanguage.Ru => "ru",
                FallbackXaiTranscriberLanguage.Sv => "sv",
                FallbackXaiTranscriberLanguage.Th => "th",
                FallbackXaiTranscriberLanguage.Tr => "tr",
                FallbackXaiTranscriberLanguage.Vi => "vi",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FallbackXaiTranscriberLanguage? ToEnum(string value)
        {
            return value switch
            {
                "ar" => FallbackXaiTranscriberLanguage.Ar,
                "cs" => FallbackXaiTranscriberLanguage.Cs,
                "da" => FallbackXaiTranscriberLanguage.Da,
                "de" => FallbackXaiTranscriberLanguage.De,
                "en" => FallbackXaiTranscriberLanguage.En,
                "es" => FallbackXaiTranscriberLanguage.Es,
                "fa" => FallbackXaiTranscriberLanguage.Fa,
                "fil" => FallbackXaiTranscriberLanguage.Fil,
                "fr" => FallbackXaiTranscriberLanguage.Fr,
                "hi" => FallbackXaiTranscriberLanguage.Hi,
                "id" => FallbackXaiTranscriberLanguage.Id,
                "it" => FallbackXaiTranscriberLanguage.It,
                "ja" => FallbackXaiTranscriberLanguage.Ja,
                "ko" => FallbackXaiTranscriberLanguage.Ko,
                "mk" => FallbackXaiTranscriberLanguage.Mk,
                "ms" => FallbackXaiTranscriberLanguage.Ms,
                "nl" => FallbackXaiTranscriberLanguage.Nl,
                "pl" => FallbackXaiTranscriberLanguage.Pl,
                "pt" => FallbackXaiTranscriberLanguage.Pt,
                "ro" => FallbackXaiTranscriberLanguage.Ro,
                "ru" => FallbackXaiTranscriberLanguage.Ru,
                "sv" => FallbackXaiTranscriberLanguage.Sv,
                "th" => FallbackXaiTranscriberLanguage.Th,
                "tr" => FallbackXaiTranscriberLanguage.Tr,
                "vi" => FallbackXaiTranscriberLanguage.Vi,
                _ => null,
            };
        }
    }
}