
#nullable enable

namespace Vapi
{
    /// <summary>
    /// Language for Vapi voice synthesis. For Version 2, omit this field or set `auto` for automatic language detection. Version 1 supports legacy Vapi language values.
    /// </summary>
    public enum VapiVoiceLanguage
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
    public static class VapiVoiceLanguageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VapiVoiceLanguage value)
        {
            return value switch
            {
                VapiVoiceLanguage.Ar => "ar",
                VapiVoiceLanguage.ArAe => "ar-AE",
                VapiVoiceLanguage.ArEg => "ar-EG",
                VapiVoiceLanguage.ArSa => "ar-SA",
                VapiVoiceLanguage.Auto => "auto",
                VapiVoiceLanguage.Bg => "bg",
                VapiVoiceLanguage.Bn => "bn",
                VapiVoiceLanguage.Cs => "cs",
                VapiVoiceLanguage.Da => "da",
                VapiVoiceLanguage.De => "de",
                VapiVoiceLanguage.El => "el",
                VapiVoiceLanguage.En => "en",
                VapiVoiceLanguage.EnAu => "en-AU",
                VapiVoiceLanguage.EnCa => "en-CA",
                VapiVoiceLanguage.EnGb => "en-GB",
                VapiVoiceLanguage.EnUs => "en-US",
                VapiVoiceLanguage.Es => "es",
                VapiVoiceLanguage.EsEs => "es-ES",
                VapiVoiceLanguage.EsMx => "es-MX",
                VapiVoiceLanguage.Fi => "fi",
                VapiVoiceLanguage.Fil => "fil",
                VapiVoiceLanguage.Fr => "fr",
                VapiVoiceLanguage.FrCa => "fr-CA",
                VapiVoiceLanguage.FrFr => "fr-FR",
                VapiVoiceLanguage.Gu => "gu",
                VapiVoiceLanguage.He => "he",
                VapiVoiceLanguage.Hi => "hi",
                VapiVoiceLanguage.Hr => "hr",
                VapiVoiceLanguage.Hu => "hu",
                VapiVoiceLanguage.Id => "id",
                VapiVoiceLanguage.It => "it",
                VapiVoiceLanguage.Ja => "ja",
                VapiVoiceLanguage.Ka => "ka",
                VapiVoiceLanguage.Kn => "kn",
                VapiVoiceLanguage.Ko => "ko",
                VapiVoiceLanguage.Ml => "ml",
                VapiVoiceLanguage.Mr => "mr",
                VapiVoiceLanguage.Ms => "ms",
                VapiVoiceLanguage.Nl => "nl",
                VapiVoiceLanguage.No => "no",
                VapiVoiceLanguage.Pa => "pa",
                VapiVoiceLanguage.Pl => "pl",
                VapiVoiceLanguage.Pt => "pt",
                VapiVoiceLanguage.PtBr => "pt-BR",
                VapiVoiceLanguage.PtPt => "pt-PT",
                VapiVoiceLanguage.Ro => "ro",
                VapiVoiceLanguage.Ru => "ru",
                VapiVoiceLanguage.Sk => "sk",
                VapiVoiceLanguage.Sv => "sv",
                VapiVoiceLanguage.Ta => "ta",
                VapiVoiceLanguage.Te => "te",
                VapiVoiceLanguage.Th => "th",
                VapiVoiceLanguage.Tl => "tl",
                VapiVoiceLanguage.Tr => "tr",
                VapiVoiceLanguage.Uk => "uk",
                VapiVoiceLanguage.Vi => "vi",
                VapiVoiceLanguage.Zh => "zh",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VapiVoiceLanguage? ToEnum(string value)
        {
            return value switch
            {
                "ar" => VapiVoiceLanguage.Ar,
                "ar-AE" => VapiVoiceLanguage.ArAe,
                "ar-EG" => VapiVoiceLanguage.ArEg,
                "ar-SA" => VapiVoiceLanguage.ArSa,
                "auto" => VapiVoiceLanguage.Auto,
                "bg" => VapiVoiceLanguage.Bg,
                "bn" => VapiVoiceLanguage.Bn,
                "cs" => VapiVoiceLanguage.Cs,
                "da" => VapiVoiceLanguage.Da,
                "de" => VapiVoiceLanguage.De,
                "el" => VapiVoiceLanguage.El,
                "en" => VapiVoiceLanguage.En,
                "en-AU" => VapiVoiceLanguage.EnAu,
                "en-CA" => VapiVoiceLanguage.EnCa,
                "en-GB" => VapiVoiceLanguage.EnGb,
                "en-US" => VapiVoiceLanguage.EnUs,
                "es" => VapiVoiceLanguage.Es,
                "es-ES" => VapiVoiceLanguage.EsEs,
                "es-MX" => VapiVoiceLanguage.EsMx,
                "fi" => VapiVoiceLanguage.Fi,
                "fil" => VapiVoiceLanguage.Fil,
                "fr" => VapiVoiceLanguage.Fr,
                "fr-CA" => VapiVoiceLanguage.FrCa,
                "fr-FR" => VapiVoiceLanguage.FrFr,
                "gu" => VapiVoiceLanguage.Gu,
                "he" => VapiVoiceLanguage.He,
                "hi" => VapiVoiceLanguage.Hi,
                "hr" => VapiVoiceLanguage.Hr,
                "hu" => VapiVoiceLanguage.Hu,
                "id" => VapiVoiceLanguage.Id,
                "it" => VapiVoiceLanguage.It,
                "ja" => VapiVoiceLanguage.Ja,
                "ka" => VapiVoiceLanguage.Ka,
                "kn" => VapiVoiceLanguage.Kn,
                "ko" => VapiVoiceLanguage.Ko,
                "ml" => VapiVoiceLanguage.Ml,
                "mr" => VapiVoiceLanguage.Mr,
                "ms" => VapiVoiceLanguage.Ms,
                "nl" => VapiVoiceLanguage.Nl,
                "no" => VapiVoiceLanguage.No,
                "pa" => VapiVoiceLanguage.Pa,
                "pl" => VapiVoiceLanguage.Pl,
                "pt" => VapiVoiceLanguage.Pt,
                "pt-BR" => VapiVoiceLanguage.PtBr,
                "pt-PT" => VapiVoiceLanguage.PtPt,
                "ro" => VapiVoiceLanguage.Ro,
                "ru" => VapiVoiceLanguage.Ru,
                "sk" => VapiVoiceLanguage.Sk,
                "sv" => VapiVoiceLanguage.Sv,
                "ta" => VapiVoiceLanguage.Ta,
                "te" => VapiVoiceLanguage.Te,
                "th" => VapiVoiceLanguage.Th,
                "tl" => VapiVoiceLanguage.Tl,
                "tr" => VapiVoiceLanguage.Tr,
                "uk" => VapiVoiceLanguage.Uk,
                "vi" => VapiVoiceLanguage.Vi,
                "zh" => VapiVoiceLanguage.Zh,
                _ => null,
            };
        }
    }
}