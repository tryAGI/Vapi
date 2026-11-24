
#nullable enable

namespace Vapi
{
    /// <summary>
    /// This is the language the voice speaks. When omitted, Vapi uses the voice's native language if it has one on record for that voice; otherwise no language is sent to Cartesia. Regional codes such as `es-MX` require the `sonic-3.6` model.<br/>
    /// Example: en
    /// </summary>
    public enum CartesiaVoiceLanguage
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
    public static class CartesiaVoiceLanguageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CartesiaVoiceLanguage value)
        {
            return value switch
            {
                CartesiaVoiceLanguage.Ar => "ar",
                CartesiaVoiceLanguage.Bg => "bg",
                CartesiaVoiceLanguage.BgBg => "bg-BG",
                CartesiaVoiceLanguage.Bn => "bn",
                CartesiaVoiceLanguage.BnIn => "bn-IN",
                CartesiaVoiceLanguage.Cs => "cs",
                CartesiaVoiceLanguage.CsCz => "cs-CZ",
                CartesiaVoiceLanguage.Da => "da",
                CartesiaVoiceLanguage.DaDk => "da-DK",
                CartesiaVoiceLanguage.De => "de",
                CartesiaVoiceLanguage.DeDe => "de-DE",
                CartesiaVoiceLanguage.El => "el",
                CartesiaVoiceLanguage.ElGr => "el-GR",
                CartesiaVoiceLanguage.En => "en",
                CartesiaVoiceLanguage.EnAu => "en-AU",
                CartesiaVoiceLanguage.EnCa => "en-CA",
                CartesiaVoiceLanguage.EnGb => "en-GB",
                CartesiaVoiceLanguage.EnIe => "en-IE",
                CartesiaVoiceLanguage.EnIn => "en-IN",
                CartesiaVoiceLanguage.EnNz => "en-NZ",
                CartesiaVoiceLanguage.EnSg => "en-SG",
                CartesiaVoiceLanguage.EnUs => "en-US",
                CartesiaVoiceLanguage.EnZa => "en-ZA",
                CartesiaVoiceLanguage.Es => "es",
                CartesiaVoiceLanguage.EsEs => "es-ES",
                CartesiaVoiceLanguage.EsMx => "es-MX",
                CartesiaVoiceLanguage.EsUs => "es-US",
                CartesiaVoiceLanguage.Fi => "fi",
                CartesiaVoiceLanguage.FiFi => "fi-FI",
                CartesiaVoiceLanguage.Fr => "fr",
                CartesiaVoiceLanguage.FrCa => "fr-CA",
                CartesiaVoiceLanguage.FrFr => "fr-FR",
                CartesiaVoiceLanguage.Gu => "gu",
                CartesiaVoiceLanguage.GuIn => "gu-IN",
                CartesiaVoiceLanguage.He => "he",
                CartesiaVoiceLanguage.HeIl => "he-IL",
                CartesiaVoiceLanguage.Hi => "hi",
                CartesiaVoiceLanguage.HiIn => "hi-IN",
                CartesiaVoiceLanguage.Hr => "hr",
                CartesiaVoiceLanguage.HrHr => "hr-HR",
                CartesiaVoiceLanguage.Hu => "hu",
                CartesiaVoiceLanguage.HuHu => "hu-HU",
                CartesiaVoiceLanguage.Id => "id",
                CartesiaVoiceLanguage.IdId => "id-ID",
                CartesiaVoiceLanguage.It => "it",
                CartesiaVoiceLanguage.ItIt => "it-IT",
                CartesiaVoiceLanguage.Ja => "ja",
                CartesiaVoiceLanguage.JaJp => "ja-JP",
                CartesiaVoiceLanguage.Ka => "ka",
                CartesiaVoiceLanguage.KaGe => "ka-GE",
                CartesiaVoiceLanguage.Kn => "kn",
                CartesiaVoiceLanguage.KnIn => "kn-IN",
                CartesiaVoiceLanguage.Ko => "ko",
                CartesiaVoiceLanguage.KoKr => "ko-KR",
                CartesiaVoiceLanguage.Ml => "ml",
                CartesiaVoiceLanguage.MlIn => "ml-IN",
                CartesiaVoiceLanguage.Mr => "mr",
                CartesiaVoiceLanguage.MrIn => "mr-IN",
                CartesiaVoiceLanguage.Ms => "ms",
                CartesiaVoiceLanguage.MsMy => "ms-MY",
                CartesiaVoiceLanguage.Nl => "nl",
                CartesiaVoiceLanguage.NlBe => "nl-BE",
                CartesiaVoiceLanguage.NlNl => "nl-NL",
                CartesiaVoiceLanguage.No => "no",
                CartesiaVoiceLanguage.NoNo => "no-NO",
                CartesiaVoiceLanguage.Or => "or",
                CartesiaVoiceLanguage.OrIn => "or-IN",
                CartesiaVoiceLanguage.Pa => "pa",
                CartesiaVoiceLanguage.PaIn => "pa-IN",
                CartesiaVoiceLanguage.Pl => "pl",
                CartesiaVoiceLanguage.PlPl => "pl-PL",
                CartesiaVoiceLanguage.Pt => "pt",
                CartesiaVoiceLanguage.PtBr => "pt-BR",
                CartesiaVoiceLanguage.PtPt => "pt-PT",
                CartesiaVoiceLanguage.Ro => "ro",
                CartesiaVoiceLanguage.RoRo => "ro-RO",
                CartesiaVoiceLanguage.Ru => "ru",
                CartesiaVoiceLanguage.RuRu => "ru-RU",
                CartesiaVoiceLanguage.Sk => "sk",
                CartesiaVoiceLanguage.SkSk => "sk-SK",
                CartesiaVoiceLanguage.Sv => "sv",
                CartesiaVoiceLanguage.SvSe => "sv-SE",
                CartesiaVoiceLanguage.Ta => "ta",
                CartesiaVoiceLanguage.TaIn => "ta-IN",
                CartesiaVoiceLanguage.Te => "te",
                CartesiaVoiceLanguage.TeIn => "te-IN",
                CartesiaVoiceLanguage.Th => "th",
                CartesiaVoiceLanguage.ThTh => "th-TH",
                CartesiaVoiceLanguage.Tl => "tl",
                CartesiaVoiceLanguage.TlPh => "tl-PH",
                CartesiaVoiceLanguage.Tr => "tr",
                CartesiaVoiceLanguage.TrTr => "tr-TR",
                CartesiaVoiceLanguage.Uk => "uk",
                CartesiaVoiceLanguage.UkUa => "uk-UA",
                CartesiaVoiceLanguage.Ur => "ur",
                CartesiaVoiceLanguage.UrIn => "ur-IN",
                CartesiaVoiceLanguage.Vi => "vi",
                CartesiaVoiceLanguage.ViVn => "vi-VN",
                CartesiaVoiceLanguage.Zh => "zh",
                CartesiaVoiceLanguage.ZhCn => "zh-CN",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CartesiaVoiceLanguage? ToEnum(string value)
        {
            return value switch
            {
                "ar" => CartesiaVoiceLanguage.Ar,
                "bg" => CartesiaVoiceLanguage.Bg,
                "bg-BG" => CartesiaVoiceLanguage.BgBg,
                "bn" => CartesiaVoiceLanguage.Bn,
                "bn-IN" => CartesiaVoiceLanguage.BnIn,
                "cs" => CartesiaVoiceLanguage.Cs,
                "cs-CZ" => CartesiaVoiceLanguage.CsCz,
                "da" => CartesiaVoiceLanguage.Da,
                "da-DK" => CartesiaVoiceLanguage.DaDk,
                "de" => CartesiaVoiceLanguage.De,
                "de-DE" => CartesiaVoiceLanguage.DeDe,
                "el" => CartesiaVoiceLanguage.El,
                "el-GR" => CartesiaVoiceLanguage.ElGr,
                "en" => CartesiaVoiceLanguage.En,
                "en-AU" => CartesiaVoiceLanguage.EnAu,
                "en-CA" => CartesiaVoiceLanguage.EnCa,
                "en-GB" => CartesiaVoiceLanguage.EnGb,
                "en-IE" => CartesiaVoiceLanguage.EnIe,
                "en-IN" => CartesiaVoiceLanguage.EnIn,
                "en-NZ" => CartesiaVoiceLanguage.EnNz,
                "en-SG" => CartesiaVoiceLanguage.EnSg,
                "en-US" => CartesiaVoiceLanguage.EnUs,
                "en-ZA" => CartesiaVoiceLanguage.EnZa,
                "es" => CartesiaVoiceLanguage.Es,
                "es-ES" => CartesiaVoiceLanguage.EsEs,
                "es-MX" => CartesiaVoiceLanguage.EsMx,
                "es-US" => CartesiaVoiceLanguage.EsUs,
                "fi" => CartesiaVoiceLanguage.Fi,
                "fi-FI" => CartesiaVoiceLanguage.FiFi,
                "fr" => CartesiaVoiceLanguage.Fr,
                "fr-CA" => CartesiaVoiceLanguage.FrCa,
                "fr-FR" => CartesiaVoiceLanguage.FrFr,
                "gu" => CartesiaVoiceLanguage.Gu,
                "gu-IN" => CartesiaVoiceLanguage.GuIn,
                "he" => CartesiaVoiceLanguage.He,
                "he-IL" => CartesiaVoiceLanguage.HeIl,
                "hi" => CartesiaVoiceLanguage.Hi,
                "hi-IN" => CartesiaVoiceLanguage.HiIn,
                "hr" => CartesiaVoiceLanguage.Hr,
                "hr-HR" => CartesiaVoiceLanguage.HrHr,
                "hu" => CartesiaVoiceLanguage.Hu,
                "hu-HU" => CartesiaVoiceLanguage.HuHu,
                "id" => CartesiaVoiceLanguage.Id,
                "id-ID" => CartesiaVoiceLanguage.IdId,
                "it" => CartesiaVoiceLanguage.It,
                "it-IT" => CartesiaVoiceLanguage.ItIt,
                "ja" => CartesiaVoiceLanguage.Ja,
                "ja-JP" => CartesiaVoiceLanguage.JaJp,
                "ka" => CartesiaVoiceLanguage.Ka,
                "ka-GE" => CartesiaVoiceLanguage.KaGe,
                "kn" => CartesiaVoiceLanguage.Kn,
                "kn-IN" => CartesiaVoiceLanguage.KnIn,
                "ko" => CartesiaVoiceLanguage.Ko,
                "ko-KR" => CartesiaVoiceLanguage.KoKr,
                "ml" => CartesiaVoiceLanguage.Ml,
                "ml-IN" => CartesiaVoiceLanguage.MlIn,
                "mr" => CartesiaVoiceLanguage.Mr,
                "mr-IN" => CartesiaVoiceLanguage.MrIn,
                "ms" => CartesiaVoiceLanguage.Ms,
                "ms-MY" => CartesiaVoiceLanguage.MsMy,
                "nl" => CartesiaVoiceLanguage.Nl,
                "nl-BE" => CartesiaVoiceLanguage.NlBe,
                "nl-NL" => CartesiaVoiceLanguage.NlNl,
                "no" => CartesiaVoiceLanguage.No,
                "no-NO" => CartesiaVoiceLanguage.NoNo,
                "or" => CartesiaVoiceLanguage.Or,
                "or-IN" => CartesiaVoiceLanguage.OrIn,
                "pa" => CartesiaVoiceLanguage.Pa,
                "pa-IN" => CartesiaVoiceLanguage.PaIn,
                "pl" => CartesiaVoiceLanguage.Pl,
                "pl-PL" => CartesiaVoiceLanguage.PlPl,
                "pt" => CartesiaVoiceLanguage.Pt,
                "pt-BR" => CartesiaVoiceLanguage.PtBr,
                "pt-PT" => CartesiaVoiceLanguage.PtPt,
                "ro" => CartesiaVoiceLanguage.Ro,
                "ro-RO" => CartesiaVoiceLanguage.RoRo,
                "ru" => CartesiaVoiceLanguage.Ru,
                "ru-RU" => CartesiaVoiceLanguage.RuRu,
                "sk" => CartesiaVoiceLanguage.Sk,
                "sk-SK" => CartesiaVoiceLanguage.SkSk,
                "sv" => CartesiaVoiceLanguage.Sv,
                "sv-SE" => CartesiaVoiceLanguage.SvSe,
                "ta" => CartesiaVoiceLanguage.Ta,
                "ta-IN" => CartesiaVoiceLanguage.TaIn,
                "te" => CartesiaVoiceLanguage.Te,
                "te-IN" => CartesiaVoiceLanguage.TeIn,
                "th" => CartesiaVoiceLanguage.Th,
                "th-TH" => CartesiaVoiceLanguage.ThTh,
                "tl" => CartesiaVoiceLanguage.Tl,
                "tl-PH" => CartesiaVoiceLanguage.TlPh,
                "tr" => CartesiaVoiceLanguage.Tr,
                "tr-TR" => CartesiaVoiceLanguage.TrTr,
                "uk" => CartesiaVoiceLanguage.Uk,
                "uk-UA" => CartesiaVoiceLanguage.UkUa,
                "ur" => CartesiaVoiceLanguage.Ur,
                "ur-IN" => CartesiaVoiceLanguage.UrIn,
                "vi" => CartesiaVoiceLanguage.Vi,
                "vi-VN" => CartesiaVoiceLanguage.ViVn,
                "zh" => CartesiaVoiceLanguage.Zh,
                "zh-CN" => CartesiaVoiceLanguage.ZhCn,
                _ => null,
            };
        }
    }
}