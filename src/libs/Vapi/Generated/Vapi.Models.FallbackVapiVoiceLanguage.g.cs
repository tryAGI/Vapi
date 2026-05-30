
#nullable enable

namespace Vapi
{
    /// <summary>
    /// Language for Vapi voice synthesis. For Version 2, omit this field or set `auto` for automatic language detection. Version 1 supports legacy Vapi language values.
    /// </summary>
    public enum FallbackVapiVoiceLanguage
    {
        /// <summary>
        /// 
        /// </summary>
        Ar,
        /// <summary>
        /// 
        /// </summary>
        ArAe,
        /// <summary>
        /// 
        /// </summary>
        ArEg,
        /// <summary>
        /// 
        /// </summary>
        ArSa,
        /// <summary>
        /// 
        /// </summary>
        Auto,
        /// <summary>
        /// 
        /// </summary>
        Bg,
        /// <summary>
        /// 
        /// </summary>
        Bn,
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
        El,
        /// <summary>
        /// 
        /// </summary>
        En,
        /// <summary>
        /// 
        /// </summary>
        EnAu,
        /// <summary>
        /// 
        /// </summary>
        EnCa,
        /// <summary>
        /// 
        /// </summary>
        EnGb,
        /// <summary>
        /// 
        /// </summary>
        EnUs,
        /// <summary>
        /// 
        /// </summary>
        Es,
        /// <summary>
        /// 
        /// </summary>
        EsEs,
        /// <summary>
        /// 
        /// </summary>
        EsMx,
        /// <summary>
        /// 
        /// </summary>
        Fi,
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
        FrCa,
        /// <summary>
        /// 
        /// </summary>
        FrFr,
        /// <summary>
        /// 
        /// </summary>
        Gu,
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
        Hr,
        /// <summary>
        /// 
        /// </summary>
        Hu,
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
        Ka,
        /// <summary>
        /// 
        /// </summary>
        Kn,
        /// <summary>
        /// 
        /// </summary>
        Ko,
        /// <summary>
        /// 
        /// </summary>
        Ml,
        /// <summary>
        /// 
        /// </summary>
        Mr,
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
        No,
        /// <summary>
        /// 
        /// </summary>
        Pa,
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
        PtBr,
        /// <summary>
        /// 
        /// </summary>
        PtPt,
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
        Sk,
        /// <summary>
        /// 
        /// </summary>
        Sv,
        /// <summary>
        /// 
        /// </summary>
        Ta,
        /// <summary>
        /// 
        /// </summary>
        Te,
        /// <summary>
        /// 
        /// </summary>
        Th,
        /// <summary>
        /// 
        /// </summary>
        Tl,
        /// <summary>
        /// 
        /// </summary>
        Tr,
        /// <summary>
        /// 
        /// </summary>
        Uk,
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
    public static class FallbackVapiVoiceLanguageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FallbackVapiVoiceLanguage value)
        {
            return value switch
            {
                FallbackVapiVoiceLanguage.Ar => "ar",
                FallbackVapiVoiceLanguage.ArAe => "ar-AE",
                FallbackVapiVoiceLanguage.ArEg => "ar-EG",
                FallbackVapiVoiceLanguage.ArSa => "ar-SA",
                FallbackVapiVoiceLanguage.Auto => "auto",
                FallbackVapiVoiceLanguage.Bg => "bg",
                FallbackVapiVoiceLanguage.Bn => "bn",
                FallbackVapiVoiceLanguage.Cs => "cs",
                FallbackVapiVoiceLanguage.Da => "da",
                FallbackVapiVoiceLanguage.De => "de",
                FallbackVapiVoiceLanguage.El => "el",
                FallbackVapiVoiceLanguage.En => "en",
                FallbackVapiVoiceLanguage.EnAu => "en-AU",
                FallbackVapiVoiceLanguage.EnCa => "en-CA",
                FallbackVapiVoiceLanguage.EnGb => "en-GB",
                FallbackVapiVoiceLanguage.EnUs => "en-US",
                FallbackVapiVoiceLanguage.Es => "es",
                FallbackVapiVoiceLanguage.EsEs => "es-ES",
                FallbackVapiVoiceLanguage.EsMx => "es-MX",
                FallbackVapiVoiceLanguage.Fi => "fi",
                FallbackVapiVoiceLanguage.Fil => "fil",
                FallbackVapiVoiceLanguage.Fr => "fr",
                FallbackVapiVoiceLanguage.FrCa => "fr-CA",
                FallbackVapiVoiceLanguage.FrFr => "fr-FR",
                FallbackVapiVoiceLanguage.Gu => "gu",
                FallbackVapiVoiceLanguage.He => "he",
                FallbackVapiVoiceLanguage.Hi => "hi",
                FallbackVapiVoiceLanguage.Hr => "hr",
                FallbackVapiVoiceLanguage.Hu => "hu",
                FallbackVapiVoiceLanguage.Id => "id",
                FallbackVapiVoiceLanguage.It => "it",
                FallbackVapiVoiceLanguage.Ja => "ja",
                FallbackVapiVoiceLanguage.Ka => "ka",
                FallbackVapiVoiceLanguage.Kn => "kn",
                FallbackVapiVoiceLanguage.Ko => "ko",
                FallbackVapiVoiceLanguage.Ml => "ml",
                FallbackVapiVoiceLanguage.Mr => "mr",
                FallbackVapiVoiceLanguage.Ms => "ms",
                FallbackVapiVoiceLanguage.Nl => "nl",
                FallbackVapiVoiceLanguage.No => "no",
                FallbackVapiVoiceLanguage.Pa => "pa",
                FallbackVapiVoiceLanguage.Pl => "pl",
                FallbackVapiVoiceLanguage.Pt => "pt",
                FallbackVapiVoiceLanguage.PtBr => "pt-BR",
                FallbackVapiVoiceLanguage.PtPt => "pt-PT",
                FallbackVapiVoiceLanguage.Ro => "ro",
                FallbackVapiVoiceLanguage.Ru => "ru",
                FallbackVapiVoiceLanguage.Sk => "sk",
                FallbackVapiVoiceLanguage.Sv => "sv",
                FallbackVapiVoiceLanguage.Ta => "ta",
                FallbackVapiVoiceLanguage.Te => "te",
                FallbackVapiVoiceLanguage.Th => "th",
                FallbackVapiVoiceLanguage.Tl => "tl",
                FallbackVapiVoiceLanguage.Tr => "tr",
                FallbackVapiVoiceLanguage.Uk => "uk",
                FallbackVapiVoiceLanguage.Vi => "vi",
                FallbackVapiVoiceLanguage.Zh => "zh",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FallbackVapiVoiceLanguage? ToEnum(string value)
        {
            return value switch
            {
                "ar" => FallbackVapiVoiceLanguage.Ar,
                "ar-AE" => FallbackVapiVoiceLanguage.ArAe,
                "ar-EG" => FallbackVapiVoiceLanguage.ArEg,
                "ar-SA" => FallbackVapiVoiceLanguage.ArSa,
                "auto" => FallbackVapiVoiceLanguage.Auto,
                "bg" => FallbackVapiVoiceLanguage.Bg,
                "bn" => FallbackVapiVoiceLanguage.Bn,
                "cs" => FallbackVapiVoiceLanguage.Cs,
                "da" => FallbackVapiVoiceLanguage.Da,
                "de" => FallbackVapiVoiceLanguage.De,
                "el" => FallbackVapiVoiceLanguage.El,
                "en" => FallbackVapiVoiceLanguage.En,
                "en-AU" => FallbackVapiVoiceLanguage.EnAu,
                "en-CA" => FallbackVapiVoiceLanguage.EnCa,
                "en-GB" => FallbackVapiVoiceLanguage.EnGb,
                "en-US" => FallbackVapiVoiceLanguage.EnUs,
                "es" => FallbackVapiVoiceLanguage.Es,
                "es-ES" => FallbackVapiVoiceLanguage.EsEs,
                "es-MX" => FallbackVapiVoiceLanguage.EsMx,
                "fi" => FallbackVapiVoiceLanguage.Fi,
                "fil" => FallbackVapiVoiceLanguage.Fil,
                "fr" => FallbackVapiVoiceLanguage.Fr,
                "fr-CA" => FallbackVapiVoiceLanguage.FrCa,
                "fr-FR" => FallbackVapiVoiceLanguage.FrFr,
                "gu" => FallbackVapiVoiceLanguage.Gu,
                "he" => FallbackVapiVoiceLanguage.He,
                "hi" => FallbackVapiVoiceLanguage.Hi,
                "hr" => FallbackVapiVoiceLanguage.Hr,
                "hu" => FallbackVapiVoiceLanguage.Hu,
                "id" => FallbackVapiVoiceLanguage.Id,
                "it" => FallbackVapiVoiceLanguage.It,
                "ja" => FallbackVapiVoiceLanguage.Ja,
                "ka" => FallbackVapiVoiceLanguage.Ka,
                "kn" => FallbackVapiVoiceLanguage.Kn,
                "ko" => FallbackVapiVoiceLanguage.Ko,
                "ml" => FallbackVapiVoiceLanguage.Ml,
                "mr" => FallbackVapiVoiceLanguage.Mr,
                "ms" => FallbackVapiVoiceLanguage.Ms,
                "nl" => FallbackVapiVoiceLanguage.Nl,
                "no" => FallbackVapiVoiceLanguage.No,
                "pa" => FallbackVapiVoiceLanguage.Pa,
                "pl" => FallbackVapiVoiceLanguage.Pl,
                "pt" => FallbackVapiVoiceLanguage.Pt,
                "pt-BR" => FallbackVapiVoiceLanguage.PtBr,
                "pt-PT" => FallbackVapiVoiceLanguage.PtPt,
                "ro" => FallbackVapiVoiceLanguage.Ro,
                "ru" => FallbackVapiVoiceLanguage.Ru,
                "sk" => FallbackVapiVoiceLanguage.Sk,
                "sv" => FallbackVapiVoiceLanguage.Sv,
                "ta" => FallbackVapiVoiceLanguage.Ta,
                "te" => FallbackVapiVoiceLanguage.Te,
                "th" => FallbackVapiVoiceLanguage.Th,
                "tl" => FallbackVapiVoiceLanguage.Tl,
                "tr" => FallbackVapiVoiceLanguage.Tr,
                "uk" => FallbackVapiVoiceLanguage.Uk,
                "vi" => FallbackVapiVoiceLanguage.Vi,
                "zh" => FallbackVapiVoiceLanguage.Zh,
                _ => null,
            };
        }
    }
}