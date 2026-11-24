
#nullable enable

namespace Vapi
{
    /// <summary>
    /// This is the language the voice speaks. When omitted, Vapi uses the voice's native language if it has one on record for that voice; otherwise no language is sent to Cartesia. Regional codes such as `es-MX` require the `sonic-3.6` model.<br/>
    /// Example: en
    /// </summary>
    public enum FallbackCartesiaVoiceLanguage
    {
        /// <summary>
        ///
        /// </summary>
        Ar,
        /// <summary>
        ///
        /// </summary>
        Bg,
        /// <summary>
        ///
        /// </summary>
        BgBg,
        /// <summary>
        ///
        /// </summary>
        Bn,
        /// <summary>
        ///
        /// </summary>
        BnIn,
        /// <summary>
        ///
        /// </summary>
        Cs,
        /// <summary>
        ///
        /// </summary>
        CsCz,
        /// <summary>
        ///
        /// </summary>
        Da,
        /// <summary>
        ///
        /// </summary>
        DaDk,
        /// <summary>
        ///
        /// </summary>
        De,
        /// <summary>
        ///
        /// </summary>
        DeDe,
        /// <summary>
        ///
        /// </summary>
        El,
        /// <summary>
        ///
        /// </summary>
        ElGr,
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
        EnIe,
        /// <summary>
        ///
        /// </summary>
        EnIn,
        /// <summary>
        ///
        /// </summary>
        EnNz,
        /// <summary>
        ///
        /// </summary>
        EnSg,
        /// <summary>
        ///
        /// </summary>
        EnUs,
        /// <summary>
        ///
        /// </summary>
        EnZa,
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
        EsUs,
        /// <summary>
        ///
        /// </summary>
        Fi,
        /// <summary>
        ///
        /// </summary>
        FiFi,
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
        GuIn,
        /// <summary>
        ///
        /// </summary>
        He,
        /// <summary>
        ///
        /// </summary>
        HeIl,
        /// <summary>
        ///
        /// </summary>
        Hi,
        /// <summary>
        ///
        /// </summary>
        HiIn,
        /// <summary>
        ///
        /// </summary>
        Hr,
        /// <summary>
        ///
        /// </summary>
        HrHr,
        /// <summary>
        ///
        /// </summary>
        Hu,
        /// <summary>
        ///
        /// </summary>
        HuHu,
        /// <summary>
        ///
        /// </summary>
        Id,
        /// <summary>
        ///
        /// </summary>
        IdId,
        /// <summary>
        ///
        /// </summary>
        It,
        /// <summary>
        ///
        /// </summary>
        ItIt,
        /// <summary>
        ///
        /// </summary>
        Ja,
        /// <summary>
        ///
        /// </summary>
        JaJp,
        /// <summary>
        ///
        /// </summary>
        Ka,
        /// <summary>
        ///
        /// </summary>
        KaGe,
        /// <summary>
        ///
        /// </summary>
        Kn,
        /// <summary>
        ///
        /// </summary>
        KnIn,
        /// <summary>
        ///
        /// </summary>
        Ko,
        /// <summary>
        ///
        /// </summary>
        KoKr,
        /// <summary>
        ///
        /// </summary>
        Ml,
        /// <summary>
        ///
        /// </summary>
        MlIn,
        /// <summary>
        ///
        /// </summary>
        Mr,
        /// <summary>
        ///
        /// </summary>
        MrIn,
        /// <summary>
        ///
        /// </summary>
        Ms,
        /// <summary>
        ///
        /// </summary>
        MsMy,
        /// <summary>
        ///
        /// </summary>
        Nl,
        /// <summary>
        ///
        /// </summary>
        NlBe,
        /// <summary>
        ///
        /// </summary>
        NlNl,
        /// <summary>
        ///
        /// </summary>
        No,
        /// <summary>
        ///
        /// </summary>
        NoNo,
        /// <summary>
        ///
        /// </summary>
        Or,
        /// <summary>
        ///
        /// </summary>
        OrIn,
        /// <summary>
        ///
        /// </summary>
        Pa,
        /// <summary>
        ///
        /// </summary>
        PaIn,
        /// <summary>
        ///
        /// </summary>
        Pl,
        /// <summary>
        ///
        /// </summary>
        PlPl,
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
        RoRo,
        /// <summary>
        ///
        /// </summary>
        Ru,
        /// <summary>
        ///
        /// </summary>
        RuRu,
        /// <summary>
        ///
        /// </summary>
        Sk,
        /// <summary>
        ///
        /// </summary>
        SkSk,
        /// <summary>
        ///
        /// </summary>
        Sv,
        /// <summary>
        ///
        /// </summary>
        SvSe,
        /// <summary>
        ///
        /// </summary>
        Ta,
        /// <summary>
        ///
        /// </summary>
        TaIn,
        /// <summary>
        ///
        /// </summary>
        Te,
        /// <summary>
        ///
        /// </summary>
        TeIn,
        /// <summary>
        ///
        /// </summary>
        Th,
        /// <summary>
        ///
        /// </summary>
        ThTh,
        /// <summary>
        ///
        /// </summary>
        Tl,
        /// <summary>
        ///
        /// </summary>
        TlPh,
        /// <summary>
        ///
        /// </summary>
        Tr,
        /// <summary>
        ///
        /// </summary>
        TrTr,
        /// <summary>
        ///
        /// </summary>
        Uk,
        /// <summary>
        ///
        /// </summary>
        UkUa,
        /// <summary>
        ///
        /// </summary>
        Ur,
        /// <summary>
        ///
        /// </summary>
        UrIn,
        /// <summary>
        ///
        /// </summary>
        Vi,
        /// <summary>
        ///
        /// </summary>
        ViVn,
        /// <summary>
        ///
        /// </summary>
        Zh,
        /// <summary>
        ///
        /// </summary>
        ZhCn,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FallbackCartesiaVoiceLanguageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FallbackCartesiaVoiceLanguage value)
        {
            return value switch
            {
                FallbackCartesiaVoiceLanguage.Ar => "ar",
                FallbackCartesiaVoiceLanguage.Bg => "bg",
                FallbackCartesiaVoiceLanguage.BgBg => "bg-BG",
                FallbackCartesiaVoiceLanguage.Bn => "bn",
                FallbackCartesiaVoiceLanguage.BnIn => "bn-IN",
                FallbackCartesiaVoiceLanguage.Cs => "cs",
                FallbackCartesiaVoiceLanguage.CsCz => "cs-CZ",
                FallbackCartesiaVoiceLanguage.Da => "da",
                FallbackCartesiaVoiceLanguage.DaDk => "da-DK",
                FallbackCartesiaVoiceLanguage.De => "de",
                FallbackCartesiaVoiceLanguage.DeDe => "de-DE",
                FallbackCartesiaVoiceLanguage.El => "el",
                FallbackCartesiaVoiceLanguage.ElGr => "el-GR",
                FallbackCartesiaVoiceLanguage.En => "en",
                FallbackCartesiaVoiceLanguage.EnAu => "en-AU",
                FallbackCartesiaVoiceLanguage.EnCa => "en-CA",
                FallbackCartesiaVoiceLanguage.EnGb => "en-GB",
                FallbackCartesiaVoiceLanguage.EnIe => "en-IE",
                FallbackCartesiaVoiceLanguage.EnIn => "en-IN",
                FallbackCartesiaVoiceLanguage.EnNz => "en-NZ",
                FallbackCartesiaVoiceLanguage.EnSg => "en-SG",
                FallbackCartesiaVoiceLanguage.EnUs => "en-US",
                FallbackCartesiaVoiceLanguage.EnZa => "en-ZA",
                FallbackCartesiaVoiceLanguage.Es => "es",
                FallbackCartesiaVoiceLanguage.EsEs => "es-ES",
                FallbackCartesiaVoiceLanguage.EsMx => "es-MX",
                FallbackCartesiaVoiceLanguage.EsUs => "es-US",
                FallbackCartesiaVoiceLanguage.Fi => "fi",
                FallbackCartesiaVoiceLanguage.FiFi => "fi-FI",
                FallbackCartesiaVoiceLanguage.Fr => "fr",
                FallbackCartesiaVoiceLanguage.FrCa => "fr-CA",
                FallbackCartesiaVoiceLanguage.FrFr => "fr-FR",
                FallbackCartesiaVoiceLanguage.Gu => "gu",
                FallbackCartesiaVoiceLanguage.GuIn => "gu-IN",
                FallbackCartesiaVoiceLanguage.He => "he",
                FallbackCartesiaVoiceLanguage.HeIl => "he-IL",
                FallbackCartesiaVoiceLanguage.Hi => "hi",
                FallbackCartesiaVoiceLanguage.HiIn => "hi-IN",
                FallbackCartesiaVoiceLanguage.Hr => "hr",
                FallbackCartesiaVoiceLanguage.HrHr => "hr-HR",
                FallbackCartesiaVoiceLanguage.Hu => "hu",
                FallbackCartesiaVoiceLanguage.HuHu => "hu-HU",
                FallbackCartesiaVoiceLanguage.Id => "id",
                FallbackCartesiaVoiceLanguage.IdId => "id-ID",
                FallbackCartesiaVoiceLanguage.It => "it",
                FallbackCartesiaVoiceLanguage.ItIt => "it-IT",
                FallbackCartesiaVoiceLanguage.Ja => "ja",
                FallbackCartesiaVoiceLanguage.JaJp => "ja-JP",
                FallbackCartesiaVoiceLanguage.Ka => "ka",
                FallbackCartesiaVoiceLanguage.KaGe => "ka-GE",
                FallbackCartesiaVoiceLanguage.Kn => "kn",
                FallbackCartesiaVoiceLanguage.KnIn => "kn-IN",
                FallbackCartesiaVoiceLanguage.Ko => "ko",
                FallbackCartesiaVoiceLanguage.KoKr => "ko-KR",
                FallbackCartesiaVoiceLanguage.Ml => "ml",
                FallbackCartesiaVoiceLanguage.MlIn => "ml-IN",
                FallbackCartesiaVoiceLanguage.Mr => "mr",
                FallbackCartesiaVoiceLanguage.MrIn => "mr-IN",
                FallbackCartesiaVoiceLanguage.Ms => "ms",
                FallbackCartesiaVoiceLanguage.MsMy => "ms-MY",
                FallbackCartesiaVoiceLanguage.Nl => "nl",
                FallbackCartesiaVoiceLanguage.NlBe => "nl-BE",
                FallbackCartesiaVoiceLanguage.NlNl => "nl-NL",
                FallbackCartesiaVoiceLanguage.No => "no",
                FallbackCartesiaVoiceLanguage.NoNo => "no-NO",
                FallbackCartesiaVoiceLanguage.Or => "or",
                FallbackCartesiaVoiceLanguage.OrIn => "or-IN",
                FallbackCartesiaVoiceLanguage.Pa => "pa",
                FallbackCartesiaVoiceLanguage.PaIn => "pa-IN",
                FallbackCartesiaVoiceLanguage.Pl => "pl",
                FallbackCartesiaVoiceLanguage.PlPl => "pl-PL",
                FallbackCartesiaVoiceLanguage.Pt => "pt",
                FallbackCartesiaVoiceLanguage.PtBr => "pt-BR",
                FallbackCartesiaVoiceLanguage.PtPt => "pt-PT",
                FallbackCartesiaVoiceLanguage.Ro => "ro",
                FallbackCartesiaVoiceLanguage.RoRo => "ro-RO",
                FallbackCartesiaVoiceLanguage.Ru => "ru",
                FallbackCartesiaVoiceLanguage.RuRu => "ru-RU",
                FallbackCartesiaVoiceLanguage.Sk => "sk",
                FallbackCartesiaVoiceLanguage.SkSk => "sk-SK",
                FallbackCartesiaVoiceLanguage.Sv => "sv",
                FallbackCartesiaVoiceLanguage.SvSe => "sv-SE",
                FallbackCartesiaVoiceLanguage.Ta => "ta",
                FallbackCartesiaVoiceLanguage.TaIn => "ta-IN",
                FallbackCartesiaVoiceLanguage.Te => "te",
                FallbackCartesiaVoiceLanguage.TeIn => "te-IN",
                FallbackCartesiaVoiceLanguage.Th => "th",
                FallbackCartesiaVoiceLanguage.ThTh => "th-TH",
                FallbackCartesiaVoiceLanguage.Tl => "tl",
                FallbackCartesiaVoiceLanguage.TlPh => "tl-PH",
                FallbackCartesiaVoiceLanguage.Tr => "tr",
                FallbackCartesiaVoiceLanguage.TrTr => "tr-TR",
                FallbackCartesiaVoiceLanguage.Uk => "uk",
                FallbackCartesiaVoiceLanguage.UkUa => "uk-UA",
                FallbackCartesiaVoiceLanguage.Ur => "ur",
                FallbackCartesiaVoiceLanguage.UrIn => "ur-IN",
                FallbackCartesiaVoiceLanguage.Vi => "vi",
                FallbackCartesiaVoiceLanguage.ViVn => "vi-VN",
                FallbackCartesiaVoiceLanguage.Zh => "zh",
                FallbackCartesiaVoiceLanguage.ZhCn => "zh-CN",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FallbackCartesiaVoiceLanguage? ToEnum(string value)
        {
            return value switch
            {
                "ar" => FallbackCartesiaVoiceLanguage.Ar,
                "bg" => FallbackCartesiaVoiceLanguage.Bg,
                "bg-BG" => FallbackCartesiaVoiceLanguage.BgBg,
                "bn" => FallbackCartesiaVoiceLanguage.Bn,
                "bn-IN" => FallbackCartesiaVoiceLanguage.BnIn,
                "cs" => FallbackCartesiaVoiceLanguage.Cs,
                "cs-CZ" => FallbackCartesiaVoiceLanguage.CsCz,
                "da" => FallbackCartesiaVoiceLanguage.Da,
                "da-DK" => FallbackCartesiaVoiceLanguage.DaDk,
                "de" => FallbackCartesiaVoiceLanguage.De,
                "de-DE" => FallbackCartesiaVoiceLanguage.DeDe,
                "el" => FallbackCartesiaVoiceLanguage.El,
                "el-GR" => FallbackCartesiaVoiceLanguage.ElGr,
                "en" => FallbackCartesiaVoiceLanguage.En,
                "en-AU" => FallbackCartesiaVoiceLanguage.EnAu,
                "en-CA" => FallbackCartesiaVoiceLanguage.EnCa,
                "en-GB" => FallbackCartesiaVoiceLanguage.EnGb,
                "en-IE" => FallbackCartesiaVoiceLanguage.EnIe,
                "en-IN" => FallbackCartesiaVoiceLanguage.EnIn,
                "en-NZ" => FallbackCartesiaVoiceLanguage.EnNz,
                "en-SG" => FallbackCartesiaVoiceLanguage.EnSg,
                "en-US" => FallbackCartesiaVoiceLanguage.EnUs,
                "en-ZA" => FallbackCartesiaVoiceLanguage.EnZa,
                "es" => FallbackCartesiaVoiceLanguage.Es,
                "es-ES" => FallbackCartesiaVoiceLanguage.EsEs,
                "es-MX" => FallbackCartesiaVoiceLanguage.EsMx,
                "es-US" => FallbackCartesiaVoiceLanguage.EsUs,
                "fi" => FallbackCartesiaVoiceLanguage.Fi,
                "fi-FI" => FallbackCartesiaVoiceLanguage.FiFi,
                "fr" => FallbackCartesiaVoiceLanguage.Fr,
                "fr-CA" => FallbackCartesiaVoiceLanguage.FrCa,
                "fr-FR" => FallbackCartesiaVoiceLanguage.FrFr,
                "gu" => FallbackCartesiaVoiceLanguage.Gu,
                "gu-IN" => FallbackCartesiaVoiceLanguage.GuIn,
                "he" => FallbackCartesiaVoiceLanguage.He,
                "he-IL" => FallbackCartesiaVoiceLanguage.HeIl,
                "hi" => FallbackCartesiaVoiceLanguage.Hi,
                "hi-IN" => FallbackCartesiaVoiceLanguage.HiIn,
                "hr" => FallbackCartesiaVoiceLanguage.Hr,
                "hr-HR" => FallbackCartesiaVoiceLanguage.HrHr,
                "hu" => FallbackCartesiaVoiceLanguage.Hu,
                "hu-HU" => FallbackCartesiaVoiceLanguage.HuHu,
                "id" => FallbackCartesiaVoiceLanguage.Id,
                "id-ID" => FallbackCartesiaVoiceLanguage.IdId,
                "it" => FallbackCartesiaVoiceLanguage.It,
                "it-IT" => FallbackCartesiaVoiceLanguage.ItIt,
                "ja" => FallbackCartesiaVoiceLanguage.Ja,
                "ja-JP" => FallbackCartesiaVoiceLanguage.JaJp,
                "ka" => FallbackCartesiaVoiceLanguage.Ka,
                "ka-GE" => FallbackCartesiaVoiceLanguage.KaGe,
                "kn" => FallbackCartesiaVoiceLanguage.Kn,
                "kn-IN" => FallbackCartesiaVoiceLanguage.KnIn,
                "ko" => FallbackCartesiaVoiceLanguage.Ko,
                "ko-KR" => FallbackCartesiaVoiceLanguage.KoKr,
                "ml" => FallbackCartesiaVoiceLanguage.Ml,
                "ml-IN" => FallbackCartesiaVoiceLanguage.MlIn,
                "mr" => FallbackCartesiaVoiceLanguage.Mr,
                "mr-IN" => FallbackCartesiaVoiceLanguage.MrIn,
                "ms" => FallbackCartesiaVoiceLanguage.Ms,
                "ms-MY" => FallbackCartesiaVoiceLanguage.MsMy,
                "nl" => FallbackCartesiaVoiceLanguage.Nl,
                "nl-BE" => FallbackCartesiaVoiceLanguage.NlBe,
                "nl-NL" => FallbackCartesiaVoiceLanguage.NlNl,
                "no" => FallbackCartesiaVoiceLanguage.No,
                "no-NO" => FallbackCartesiaVoiceLanguage.NoNo,
                "or" => FallbackCartesiaVoiceLanguage.Or,
                "or-IN" => FallbackCartesiaVoiceLanguage.OrIn,
                "pa" => FallbackCartesiaVoiceLanguage.Pa,
                "pa-IN" => FallbackCartesiaVoiceLanguage.PaIn,
                "pl" => FallbackCartesiaVoiceLanguage.Pl,
                "pl-PL" => FallbackCartesiaVoiceLanguage.PlPl,
                "pt" => FallbackCartesiaVoiceLanguage.Pt,
                "pt-BR" => FallbackCartesiaVoiceLanguage.PtBr,
                "pt-PT" => FallbackCartesiaVoiceLanguage.PtPt,
                "ro" => FallbackCartesiaVoiceLanguage.Ro,
                "ro-RO" => FallbackCartesiaVoiceLanguage.RoRo,
                "ru" => FallbackCartesiaVoiceLanguage.Ru,
                "ru-RU" => FallbackCartesiaVoiceLanguage.RuRu,
                "sk" => FallbackCartesiaVoiceLanguage.Sk,
                "sk-SK" => FallbackCartesiaVoiceLanguage.SkSk,
                "sv" => FallbackCartesiaVoiceLanguage.Sv,
                "sv-SE" => FallbackCartesiaVoiceLanguage.SvSe,
                "ta" => FallbackCartesiaVoiceLanguage.Ta,
                "ta-IN" => FallbackCartesiaVoiceLanguage.TaIn,
                "te" => FallbackCartesiaVoiceLanguage.Te,
                "te-IN" => FallbackCartesiaVoiceLanguage.TeIn,
                "th" => FallbackCartesiaVoiceLanguage.Th,
                "th-TH" => FallbackCartesiaVoiceLanguage.ThTh,
                "tl" => FallbackCartesiaVoiceLanguage.Tl,
                "tl-PH" => FallbackCartesiaVoiceLanguage.TlPh,
                "tr" => FallbackCartesiaVoiceLanguage.Tr,
                "tr-TR" => FallbackCartesiaVoiceLanguage.TrTr,
                "uk" => FallbackCartesiaVoiceLanguage.Uk,
                "uk-UA" => FallbackCartesiaVoiceLanguage.UkUa,
                "ur" => FallbackCartesiaVoiceLanguage.Ur,
                "ur-IN" => FallbackCartesiaVoiceLanguage.UrIn,
                "vi" => FallbackCartesiaVoiceLanguage.Vi,
                "vi-VN" => FallbackCartesiaVoiceLanguage.ViVn,
                "zh" => FallbackCartesiaVoiceLanguage.Zh,
                "zh-CN" => FallbackCartesiaVoiceLanguage.ZhCn,
                _ => null,
            };
        }
    }
}