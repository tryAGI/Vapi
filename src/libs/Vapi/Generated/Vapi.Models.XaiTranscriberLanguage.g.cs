
#nullable enable

namespace Vapi
{
    /// <summary>
    /// Single language for transcription as an ISO 639-1 code (e.g., `en`, `es`). Defaults to `en` if not set. xAI auto-detects when omitted via the API but Vapi defaults to English for deterministic behavior.
    /// </summary>
    public enum XaiTranscriberLanguage
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
    public static class XaiTranscriberLanguageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this XaiTranscriberLanguage value)
        {
            return value switch
            {
                XaiTranscriberLanguage.Ar => "ar",
                XaiTranscriberLanguage.Cs => "cs",
                XaiTranscriberLanguage.Da => "da",
                XaiTranscriberLanguage.De => "de",
                XaiTranscriberLanguage.En => "en",
                XaiTranscriberLanguage.Es => "es",
                XaiTranscriberLanguage.Fa => "fa",
                XaiTranscriberLanguage.Fil => "fil",
                XaiTranscriberLanguage.Fr => "fr",
                XaiTranscriberLanguage.Hi => "hi",
                XaiTranscriberLanguage.Id => "id",
                XaiTranscriberLanguage.It => "it",
                XaiTranscriberLanguage.Ja => "ja",
                XaiTranscriberLanguage.Ko => "ko",
                XaiTranscriberLanguage.Mk => "mk",
                XaiTranscriberLanguage.Ms => "ms",
                XaiTranscriberLanguage.Nl => "nl",
                XaiTranscriberLanguage.Pl => "pl",
                XaiTranscriberLanguage.Pt => "pt",
                XaiTranscriberLanguage.Ro => "ro",
                XaiTranscriberLanguage.Ru => "ru",
                XaiTranscriberLanguage.Sv => "sv",
                XaiTranscriberLanguage.Th => "th",
                XaiTranscriberLanguage.Tr => "tr",
                XaiTranscriberLanguage.Vi => "vi",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static XaiTranscriberLanguage? ToEnum(string value)
        {
            return value switch
            {
                "ar" => XaiTranscriberLanguage.Ar,
                "cs" => XaiTranscriberLanguage.Cs,
                "da" => XaiTranscriberLanguage.Da,
                "de" => XaiTranscriberLanguage.De,
                "en" => XaiTranscriberLanguage.En,
                "es" => XaiTranscriberLanguage.Es,
                "fa" => XaiTranscriberLanguage.Fa,
                "fil" => XaiTranscriberLanguage.Fil,
                "fr" => XaiTranscriberLanguage.Fr,
                "hi" => XaiTranscriberLanguage.Hi,
                "id" => XaiTranscriberLanguage.Id,
                "it" => XaiTranscriberLanguage.It,
                "ja" => XaiTranscriberLanguage.Ja,
                "ko" => XaiTranscriberLanguage.Ko,
                "mk" => XaiTranscriberLanguage.Mk,
                "ms" => XaiTranscriberLanguage.Ms,
                "nl" => XaiTranscriberLanguage.Nl,
                "pl" => XaiTranscriberLanguage.Pl,
                "pt" => XaiTranscriberLanguage.Pt,
                "ro" => XaiTranscriberLanguage.Ro,
                "ru" => XaiTranscriberLanguage.Ru,
                "sv" => XaiTranscriberLanguage.Sv,
                "th" => XaiTranscriberLanguage.Th,
                "tr" => XaiTranscriberLanguage.Tr,
                "vi" => XaiTranscriberLanguage.Vi,
                _ => null,
            };
        }
    }
}