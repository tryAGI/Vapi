
#nullable enable

namespace Vapi
{
    /// <summary>
    /// Language hints sent to Soniox as `language_hints`. Provide `[lang1, lang2, ...]` (ISO 639-1 codes) to bias recognition toward specific languages, or provide an explicit empty array `[]` to enable Soniox auto-detect across all 60+ supported languages. When set (including the empty array), this field takes precedence over the singular `language` field. When omitted, falls back to the singular `language` (which defaults to `en` if also unset). Best accuracy is achieved with a single language.
    /// </summary>
    public enum FallbackSonioxTranscriberLanguages
    {
        /// <summary>
        /// 
        /// </summary>
        Aa,
        /// <summary>
        /// 
        /// </summary>
        Ab,
        /// <summary>
        /// 
        /// </summary>
        Ae,
        /// <summary>
        /// 
        /// </summary>
        Af,
        /// <summary>
        /// 
        /// </summary>
        Ak,
        /// <summary>
        /// 
        /// </summary>
        Am,
        /// <summary>
        /// 
        /// </summary>
        An,
        /// <summary>
        /// 
        /// </summary>
        Ar,
        /// <summary>
        /// 
        /// </summary>
        As,
        /// <summary>
        /// 
        /// </summary>
        Av,
        /// <summary>
        /// 
        /// </summary>
        Ay,
        /// <summary>
        /// 
        /// </summary>
        Az,
        /// <summary>
        /// 
        /// </summary>
        Ba,
        /// <summary>
        /// 
        /// </summary>
        Be,
        /// <summary>
        /// 
        /// </summary>
        Bg,
        /// <summary>
        /// 
        /// </summary>
        Bh,
        /// <summary>
        /// 
        /// </summary>
        Bi,
        /// <summary>
        /// 
        /// </summary>
        Bm,
        /// <summary>
        /// 
        /// </summary>
        Bn,
        /// <summary>
        /// 
        /// </summary>
        Bo,
        /// <summary>
        /// 
        /// </summary>
        Br,
        /// <summary>
        /// 
        /// </summary>
        Bs,
        /// <summary>
        /// 
        /// </summary>
        Ca,
        /// <summary>
        /// 
        /// </summary>
        Ce,
        /// <summary>
        /// 
        /// </summary>
        Ch,
        /// <summary>
        /// 
        /// </summary>
        Co,
        /// <summary>
        /// 
        /// </summary>
        Cr,
        /// <summary>
        /// 
        /// </summary>
        Cs,
        /// <summary>
        /// 
        /// </summary>
        Cu,
        /// <summary>
        /// 
        /// </summary>
        Cv,
        /// <summary>
        /// 
        /// </summary>
        Cy,
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
        Dv,
        /// <summary>
        /// 
        /// </summary>
        Dz,
        /// <summary>
        /// 
        /// </summary>
        Ee,
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
        Eo,
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
        Eu,
        /// <summary>
        /// 
        /// </summary>
        Fa,
        /// <summary>
        /// 
        /// </summary>
        Ff,
        /// <summary>
        /// 
        /// </summary>
        Fi,
        /// <summary>
        /// 
        /// </summary>
        Fj,
        /// <summary>
        /// 
        /// </summary>
        Fo,
        /// <summary>
        /// 
        /// </summary>
        Fr,
        /// <summary>
        /// 
        /// </summary>
        Fy,
        /// <summary>
        /// 
        /// </summary>
        Ga,
        /// <summary>
        /// 
        /// </summary>
        Gd,
        /// <summary>
        /// 
        /// </summary>
        Gl,
        /// <summary>
        /// 
        /// </summary>
        Gn,
        /// <summary>
        /// 
        /// </summary>
        Gu,
        /// <summary>
        /// 
        /// </summary>
        Gv,
        /// <summary>
        /// 
        /// </summary>
        Ha,
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
        Ho,
        /// <summary>
        /// 
        /// </summary>
        Hr,
        /// <summary>
        /// 
        /// </summary>
        Ht,
        /// <summary>
        /// 
        /// </summary>
        Hu,
        /// <summary>
        /// 
        /// </summary>
        Hy,
        /// <summary>
        /// 
        /// </summary>
        Hz,
        /// <summary>
        /// 
        /// </summary>
        Ia,
        /// <summary>
        /// 
        /// </summary>
        Id,
        /// <summary>
        /// 
        /// </summary>
        Ie,
        /// <summary>
        /// 
        /// </summary>
        Ig,
        /// <summary>
        /// 
        /// </summary>
        Ii,
        /// <summary>
        /// 
        /// </summary>
        Ik,
        /// <summary>
        /// 
        /// </summary>
        Io,
        /// <summary>
        /// 
        /// </summary>
        Is,
        /// <summary>
        /// 
        /// </summary>
        It,
        /// <summary>
        /// 
        /// </summary>
        Iu,
        /// <summary>
        /// 
        /// </summary>
        Ja,
        /// <summary>
        /// 
        /// </summary>
        Jv,
        /// <summary>
        /// 
        /// </summary>
        Ka,
        /// <summary>
        /// 
        /// </summary>
        Kg,
        /// <summary>
        /// 
        /// </summary>
        Ki,
        /// <summary>
        /// 
        /// </summary>
        Kj,
        /// <summary>
        /// 
        /// </summary>
        Kk,
        /// <summary>
        /// 
        /// </summary>
        Kl,
        /// <summary>
        /// 
        /// </summary>
        Km,
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
        Kr,
        /// <summary>
        /// 
        /// </summary>
        Ks,
        /// <summary>
        /// 
        /// </summary>
        Ku,
        /// <summary>
        /// 
        /// </summary>
        Kv,
        /// <summary>
        /// 
        /// </summary>
        Kw,
        /// <summary>
        /// 
        /// </summary>
        Ky,
        /// <summary>
        /// 
        /// </summary>
        La,
        /// <summary>
        /// 
        /// </summary>
        Lb,
        /// <summary>
        /// 
        /// </summary>
        Lg,
        /// <summary>
        /// 
        /// </summary>
        Li,
        /// <summary>
        /// 
        /// </summary>
        Ln,
        /// <summary>
        /// 
        /// </summary>
        Lo,
        /// <summary>
        /// 
        /// </summary>
        Lt,
        /// <summary>
        /// 
        /// </summary>
        Lu,
        /// <summary>
        /// 
        /// </summary>
        Lv,
        /// <summary>
        /// 
        /// </summary>
        Mg,
        /// <summary>
        /// 
        /// </summary>
        Mh,
        /// <summary>
        /// 
        /// </summary>
        Mi,
        /// <summary>
        /// 
        /// </summary>
        Mk,
        /// <summary>
        /// 
        /// </summary>
        Ml,
        /// <summary>
        /// 
        /// </summary>
        Mn,
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
        Mt,
        /// <summary>
        /// 
        /// </summary>
        My,
        /// <summary>
        /// 
        /// </summary>
        Na,
        /// <summary>
        /// 
        /// </summary>
        Nb,
        /// <summary>
        /// 
        /// </summary>
        Nd,
        /// <summary>
        /// 
        /// </summary>
        Ne,
        /// <summary>
        /// 
        /// </summary>
        Ng,
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
        Nr,
        /// <summary>
        /// 
        /// </summary>
        Nv,
        /// <summary>
        /// 
        /// </summary>
        Ny,
        /// <summary>
        /// 
        /// </summary>
        Oc,
        /// <summary>
        /// 
        /// </summary>
        Oj,
        /// <summary>
        /// 
        /// </summary>
        Om,
        /// <summary>
        /// 
        /// </summary>
        Or,
        /// <summary>
        /// 
        /// </summary>
        Os,
        /// <summary>
        /// 
        /// </summary>
        Pa,
        /// <summary>
        /// 
        /// </summary>
        Pi,
        /// <summary>
        /// 
        /// </summary>
        Pl,
        /// <summary>
        /// 
        /// </summary>
        Ps,
        /// <summary>
        /// 
        /// </summary>
        Pt,
        /// <summary>
        /// 
        /// </summary>
        Qu,
        /// <summary>
        /// 
        /// </summary>
        Rm,
        /// <summary>
        /// 
        /// </summary>
        Rn,
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
        Rw,
        /// <summary>
        /// 
        /// </summary>
        Sa,
        /// <summary>
        /// 
        /// </summary>
        Sc,
        /// <summary>
        /// 
        /// </summary>
        Sd,
        /// <summary>
        /// 
        /// </summary>
        Se,
        /// <summary>
        /// 
        /// </summary>
        Sg,
        /// <summary>
        /// 
        /// </summary>
        Si,
        /// <summary>
        /// 
        /// </summary>
        Sk,
        /// <summary>
        /// 
        /// </summary>
        Sl,
        /// <summary>
        /// 
        /// </summary>
        Sm,
        /// <summary>
        /// 
        /// </summary>
        Sn,
        /// <summary>
        /// 
        /// </summary>
        So,
        /// <summary>
        /// 
        /// </summary>
        Sq,
        /// <summary>
        /// 
        /// </summary>
        Sr,
        /// <summary>
        /// 
        /// </summary>
        Ss,
        /// <summary>
        /// 
        /// </summary>
        St,
        /// <summary>
        /// 
        /// </summary>
        Su,
        /// <summary>
        /// 
        /// </summary>
        Sv,
        /// <summary>
        /// 
        /// </summary>
        Sw,
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
        Tg,
        /// <summary>
        /// 
        /// </summary>
        Th,
        /// <summary>
        /// 
        /// </summary>
        Ti,
        /// <summary>
        /// 
        /// </summary>
        Tk,
        /// <summary>
        /// 
        /// </summary>
        Tl,
        /// <summary>
        /// 
        /// </summary>
        Tn,
        /// <summary>
        /// 
        /// </summary>
        To,
        /// <summary>
        /// 
        /// </summary>
        Tr,
        /// <summary>
        /// 
        /// </summary>
        Ts,
        /// <summary>
        /// 
        /// </summary>
        Tt,
        /// <summary>
        /// 
        /// </summary>
        Tw,
        /// <summary>
        /// 
        /// </summary>
        Ty,
        /// <summary>
        /// 
        /// </summary>
        Ug,
        /// <summary>
        /// 
        /// </summary>
        Uk,
        /// <summary>
        /// 
        /// </summary>
        Ur,
        /// <summary>
        /// 
        /// </summary>
        Uz,
        /// <summary>
        /// 
        /// </summary>
        Ve,
        /// <summary>
        /// 
        /// </summary>
        Vi,
        /// <summary>
        /// 
        /// </summary>
        Vo,
        /// <summary>
        /// 
        /// </summary>
        Wa,
        /// <summary>
        /// 
        /// </summary>
        Wo,
        /// <summary>
        /// 
        /// </summary>
        Xh,
        /// <summary>
        /// 
        /// </summary>
        Yi,
        /// <summary>
        /// 
        /// </summary>
        Yo,
        /// <summary>
        /// 
        /// </summary>
        Yue,
        /// <summary>
        /// 
        /// </summary>
        Za,
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
    public static class FallbackSonioxTranscriberLanguagesExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FallbackSonioxTranscriberLanguages value)
        {
            return value switch
            {
                FallbackSonioxTranscriberLanguages.Aa => "aa",
                FallbackSonioxTranscriberLanguages.Ab => "ab",
                FallbackSonioxTranscriberLanguages.Ae => "ae",
                FallbackSonioxTranscriberLanguages.Af => "af",
                FallbackSonioxTranscriberLanguages.Ak => "ak",
                FallbackSonioxTranscriberLanguages.Am => "am",
                FallbackSonioxTranscriberLanguages.An => "an",
                FallbackSonioxTranscriberLanguages.Ar => "ar",
                FallbackSonioxTranscriberLanguages.As => "as",
                FallbackSonioxTranscriberLanguages.Av => "av",
                FallbackSonioxTranscriberLanguages.Ay => "ay",
                FallbackSonioxTranscriberLanguages.Az => "az",
                FallbackSonioxTranscriberLanguages.Ba => "ba",
                FallbackSonioxTranscriberLanguages.Be => "be",
                FallbackSonioxTranscriberLanguages.Bg => "bg",
                FallbackSonioxTranscriberLanguages.Bh => "bh",
                FallbackSonioxTranscriberLanguages.Bi => "bi",
                FallbackSonioxTranscriberLanguages.Bm => "bm",
                FallbackSonioxTranscriberLanguages.Bn => "bn",
                FallbackSonioxTranscriberLanguages.Bo => "bo",
                FallbackSonioxTranscriberLanguages.Br => "br",
                FallbackSonioxTranscriberLanguages.Bs => "bs",
                FallbackSonioxTranscriberLanguages.Ca => "ca",
                FallbackSonioxTranscriberLanguages.Ce => "ce",
                FallbackSonioxTranscriberLanguages.Ch => "ch",
                FallbackSonioxTranscriberLanguages.Co => "co",
                FallbackSonioxTranscriberLanguages.Cr => "cr",
                FallbackSonioxTranscriberLanguages.Cs => "cs",
                FallbackSonioxTranscriberLanguages.Cu => "cu",
                FallbackSonioxTranscriberLanguages.Cv => "cv",
                FallbackSonioxTranscriberLanguages.Cy => "cy",
                FallbackSonioxTranscriberLanguages.Da => "da",
                FallbackSonioxTranscriberLanguages.De => "de",
                FallbackSonioxTranscriberLanguages.Dv => "dv",
                FallbackSonioxTranscriberLanguages.Dz => "dz",
                FallbackSonioxTranscriberLanguages.Ee => "ee",
                FallbackSonioxTranscriberLanguages.El => "el",
                FallbackSonioxTranscriberLanguages.En => "en",
                FallbackSonioxTranscriberLanguages.Eo => "eo",
                FallbackSonioxTranscriberLanguages.Es => "es",
                FallbackSonioxTranscriberLanguages.Et => "et",
                FallbackSonioxTranscriberLanguages.Eu => "eu",
                FallbackSonioxTranscriberLanguages.Fa => "fa",
                FallbackSonioxTranscriberLanguages.Ff => "ff",
                FallbackSonioxTranscriberLanguages.Fi => "fi",
                FallbackSonioxTranscriberLanguages.Fj => "fj",
                FallbackSonioxTranscriberLanguages.Fo => "fo",
                FallbackSonioxTranscriberLanguages.Fr => "fr",
                FallbackSonioxTranscriberLanguages.Fy => "fy",
                FallbackSonioxTranscriberLanguages.Ga => "ga",
                FallbackSonioxTranscriberLanguages.Gd => "gd",
                FallbackSonioxTranscriberLanguages.Gl => "gl",
                FallbackSonioxTranscriberLanguages.Gn => "gn",
                FallbackSonioxTranscriberLanguages.Gu => "gu",
                FallbackSonioxTranscriberLanguages.Gv => "gv",
                FallbackSonioxTranscriberLanguages.Ha => "ha",
                FallbackSonioxTranscriberLanguages.He => "he",
                FallbackSonioxTranscriberLanguages.Hi => "hi",
                FallbackSonioxTranscriberLanguages.Ho => "ho",
                FallbackSonioxTranscriberLanguages.Hr => "hr",
                FallbackSonioxTranscriberLanguages.Ht => "ht",
                FallbackSonioxTranscriberLanguages.Hu => "hu",
                FallbackSonioxTranscriberLanguages.Hy => "hy",
                FallbackSonioxTranscriberLanguages.Hz => "hz",
                FallbackSonioxTranscriberLanguages.Ia => "ia",
                FallbackSonioxTranscriberLanguages.Id => "id",
                FallbackSonioxTranscriberLanguages.Ie => "ie",
                FallbackSonioxTranscriberLanguages.Ig => "ig",
                FallbackSonioxTranscriberLanguages.Ii => "ii",
                FallbackSonioxTranscriberLanguages.Ik => "ik",
                FallbackSonioxTranscriberLanguages.Io => "io",
                FallbackSonioxTranscriberLanguages.Is => "is",
                FallbackSonioxTranscriberLanguages.It => "it",
                FallbackSonioxTranscriberLanguages.Iu => "iu",
                FallbackSonioxTranscriberLanguages.Ja => "ja",
                FallbackSonioxTranscriberLanguages.Jv => "jv",
                FallbackSonioxTranscriberLanguages.Ka => "ka",
                FallbackSonioxTranscriberLanguages.Kg => "kg",
                FallbackSonioxTranscriberLanguages.Ki => "ki",
                FallbackSonioxTranscriberLanguages.Kj => "kj",
                FallbackSonioxTranscriberLanguages.Kk => "kk",
                FallbackSonioxTranscriberLanguages.Kl => "kl",
                FallbackSonioxTranscriberLanguages.Km => "km",
                FallbackSonioxTranscriberLanguages.Kn => "kn",
                FallbackSonioxTranscriberLanguages.Ko => "ko",
                FallbackSonioxTranscriberLanguages.Kr => "kr",
                FallbackSonioxTranscriberLanguages.Ks => "ks",
                FallbackSonioxTranscriberLanguages.Ku => "ku",
                FallbackSonioxTranscriberLanguages.Kv => "kv",
                FallbackSonioxTranscriberLanguages.Kw => "kw",
                FallbackSonioxTranscriberLanguages.Ky => "ky",
                FallbackSonioxTranscriberLanguages.La => "la",
                FallbackSonioxTranscriberLanguages.Lb => "lb",
                FallbackSonioxTranscriberLanguages.Lg => "lg",
                FallbackSonioxTranscriberLanguages.Li => "li",
                FallbackSonioxTranscriberLanguages.Ln => "ln",
                FallbackSonioxTranscriberLanguages.Lo => "lo",
                FallbackSonioxTranscriberLanguages.Lt => "lt",
                FallbackSonioxTranscriberLanguages.Lu => "lu",
                FallbackSonioxTranscriberLanguages.Lv => "lv",
                FallbackSonioxTranscriberLanguages.Mg => "mg",
                FallbackSonioxTranscriberLanguages.Mh => "mh",
                FallbackSonioxTranscriberLanguages.Mi => "mi",
                FallbackSonioxTranscriberLanguages.Mk => "mk",
                FallbackSonioxTranscriberLanguages.Ml => "ml",
                FallbackSonioxTranscriberLanguages.Mn => "mn",
                FallbackSonioxTranscriberLanguages.Mr => "mr",
                FallbackSonioxTranscriberLanguages.Ms => "ms",
                FallbackSonioxTranscriberLanguages.Mt => "mt",
                FallbackSonioxTranscriberLanguages.My => "my",
                FallbackSonioxTranscriberLanguages.Na => "na",
                FallbackSonioxTranscriberLanguages.Nb => "nb",
                FallbackSonioxTranscriberLanguages.Nd => "nd",
                FallbackSonioxTranscriberLanguages.Ne => "ne",
                FallbackSonioxTranscriberLanguages.Ng => "ng",
                FallbackSonioxTranscriberLanguages.Nl => "nl",
                FallbackSonioxTranscriberLanguages.Nn => "nn",
                FallbackSonioxTranscriberLanguages.No => "no",
                FallbackSonioxTranscriberLanguages.Nr => "nr",
                FallbackSonioxTranscriberLanguages.Nv => "nv",
                FallbackSonioxTranscriberLanguages.Ny => "ny",
                FallbackSonioxTranscriberLanguages.Oc => "oc",
                FallbackSonioxTranscriberLanguages.Oj => "oj",
                FallbackSonioxTranscriberLanguages.Om => "om",
                FallbackSonioxTranscriberLanguages.Or => "or",
                FallbackSonioxTranscriberLanguages.Os => "os",
                FallbackSonioxTranscriberLanguages.Pa => "pa",
                FallbackSonioxTranscriberLanguages.Pi => "pi",
                FallbackSonioxTranscriberLanguages.Pl => "pl",
                FallbackSonioxTranscriberLanguages.Ps => "ps",
                FallbackSonioxTranscriberLanguages.Pt => "pt",
                FallbackSonioxTranscriberLanguages.Qu => "qu",
                FallbackSonioxTranscriberLanguages.Rm => "rm",
                FallbackSonioxTranscriberLanguages.Rn => "rn",
                FallbackSonioxTranscriberLanguages.Ro => "ro",
                FallbackSonioxTranscriberLanguages.Ru => "ru",
                FallbackSonioxTranscriberLanguages.Rw => "rw",
                FallbackSonioxTranscriberLanguages.Sa => "sa",
                FallbackSonioxTranscriberLanguages.Sc => "sc",
                FallbackSonioxTranscriberLanguages.Sd => "sd",
                FallbackSonioxTranscriberLanguages.Se => "se",
                FallbackSonioxTranscriberLanguages.Sg => "sg",
                FallbackSonioxTranscriberLanguages.Si => "si",
                FallbackSonioxTranscriberLanguages.Sk => "sk",
                FallbackSonioxTranscriberLanguages.Sl => "sl",
                FallbackSonioxTranscriberLanguages.Sm => "sm",
                FallbackSonioxTranscriberLanguages.Sn => "sn",
                FallbackSonioxTranscriberLanguages.So => "so",
                FallbackSonioxTranscriberLanguages.Sq => "sq",
                FallbackSonioxTranscriberLanguages.Sr => "sr",
                FallbackSonioxTranscriberLanguages.Ss => "ss",
                FallbackSonioxTranscriberLanguages.St => "st",
                FallbackSonioxTranscriberLanguages.Su => "su",
                FallbackSonioxTranscriberLanguages.Sv => "sv",
                FallbackSonioxTranscriberLanguages.Sw => "sw",
                FallbackSonioxTranscriberLanguages.Ta => "ta",
                FallbackSonioxTranscriberLanguages.Te => "te",
                FallbackSonioxTranscriberLanguages.Tg => "tg",
                FallbackSonioxTranscriberLanguages.Th => "th",
                FallbackSonioxTranscriberLanguages.Ti => "ti",
                FallbackSonioxTranscriberLanguages.Tk => "tk",
                FallbackSonioxTranscriberLanguages.Tl => "tl",
                FallbackSonioxTranscriberLanguages.Tn => "tn",
                FallbackSonioxTranscriberLanguages.To => "to",
                FallbackSonioxTranscriberLanguages.Tr => "tr",
                FallbackSonioxTranscriberLanguages.Ts => "ts",
                FallbackSonioxTranscriberLanguages.Tt => "tt",
                FallbackSonioxTranscriberLanguages.Tw => "tw",
                FallbackSonioxTranscriberLanguages.Ty => "ty",
                FallbackSonioxTranscriberLanguages.Ug => "ug",
                FallbackSonioxTranscriberLanguages.Uk => "uk",
                FallbackSonioxTranscriberLanguages.Ur => "ur",
                FallbackSonioxTranscriberLanguages.Uz => "uz",
                FallbackSonioxTranscriberLanguages.Ve => "ve",
                FallbackSonioxTranscriberLanguages.Vi => "vi",
                FallbackSonioxTranscriberLanguages.Vo => "vo",
                FallbackSonioxTranscriberLanguages.Wa => "wa",
                FallbackSonioxTranscriberLanguages.Wo => "wo",
                FallbackSonioxTranscriberLanguages.Xh => "xh",
                FallbackSonioxTranscriberLanguages.Yi => "yi",
                FallbackSonioxTranscriberLanguages.Yo => "yo",
                FallbackSonioxTranscriberLanguages.Yue => "yue",
                FallbackSonioxTranscriberLanguages.Za => "za",
                FallbackSonioxTranscriberLanguages.Zh => "zh",
                FallbackSonioxTranscriberLanguages.Zu => "zu",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FallbackSonioxTranscriberLanguages? ToEnum(string value)
        {
            return value switch
            {
                "aa" => FallbackSonioxTranscriberLanguages.Aa,
                "ab" => FallbackSonioxTranscriberLanguages.Ab,
                "ae" => FallbackSonioxTranscriberLanguages.Ae,
                "af" => FallbackSonioxTranscriberLanguages.Af,
                "ak" => FallbackSonioxTranscriberLanguages.Ak,
                "am" => FallbackSonioxTranscriberLanguages.Am,
                "an" => FallbackSonioxTranscriberLanguages.An,
                "ar" => FallbackSonioxTranscriberLanguages.Ar,
                "as" => FallbackSonioxTranscriberLanguages.As,
                "av" => FallbackSonioxTranscriberLanguages.Av,
                "ay" => FallbackSonioxTranscriberLanguages.Ay,
                "az" => FallbackSonioxTranscriberLanguages.Az,
                "ba" => FallbackSonioxTranscriberLanguages.Ba,
                "be" => FallbackSonioxTranscriberLanguages.Be,
                "bg" => FallbackSonioxTranscriberLanguages.Bg,
                "bh" => FallbackSonioxTranscriberLanguages.Bh,
                "bi" => FallbackSonioxTranscriberLanguages.Bi,
                "bm" => FallbackSonioxTranscriberLanguages.Bm,
                "bn" => FallbackSonioxTranscriberLanguages.Bn,
                "bo" => FallbackSonioxTranscriberLanguages.Bo,
                "br" => FallbackSonioxTranscriberLanguages.Br,
                "bs" => FallbackSonioxTranscriberLanguages.Bs,
                "ca" => FallbackSonioxTranscriberLanguages.Ca,
                "ce" => FallbackSonioxTranscriberLanguages.Ce,
                "ch" => FallbackSonioxTranscriberLanguages.Ch,
                "co" => FallbackSonioxTranscriberLanguages.Co,
                "cr" => FallbackSonioxTranscriberLanguages.Cr,
                "cs" => FallbackSonioxTranscriberLanguages.Cs,
                "cu" => FallbackSonioxTranscriberLanguages.Cu,
                "cv" => FallbackSonioxTranscriberLanguages.Cv,
                "cy" => FallbackSonioxTranscriberLanguages.Cy,
                "da" => FallbackSonioxTranscriberLanguages.Da,
                "de" => FallbackSonioxTranscriberLanguages.De,
                "dv" => FallbackSonioxTranscriberLanguages.Dv,
                "dz" => FallbackSonioxTranscriberLanguages.Dz,
                "ee" => FallbackSonioxTranscriberLanguages.Ee,
                "el" => FallbackSonioxTranscriberLanguages.El,
                "en" => FallbackSonioxTranscriberLanguages.En,
                "eo" => FallbackSonioxTranscriberLanguages.Eo,
                "es" => FallbackSonioxTranscriberLanguages.Es,
                "et" => FallbackSonioxTranscriberLanguages.Et,
                "eu" => FallbackSonioxTranscriberLanguages.Eu,
                "fa" => FallbackSonioxTranscriberLanguages.Fa,
                "ff" => FallbackSonioxTranscriberLanguages.Ff,
                "fi" => FallbackSonioxTranscriberLanguages.Fi,
                "fj" => FallbackSonioxTranscriberLanguages.Fj,
                "fo" => FallbackSonioxTranscriberLanguages.Fo,
                "fr" => FallbackSonioxTranscriberLanguages.Fr,
                "fy" => FallbackSonioxTranscriberLanguages.Fy,
                "ga" => FallbackSonioxTranscriberLanguages.Ga,
                "gd" => FallbackSonioxTranscriberLanguages.Gd,
                "gl" => FallbackSonioxTranscriberLanguages.Gl,
                "gn" => FallbackSonioxTranscriberLanguages.Gn,
                "gu" => FallbackSonioxTranscriberLanguages.Gu,
                "gv" => FallbackSonioxTranscriberLanguages.Gv,
                "ha" => FallbackSonioxTranscriberLanguages.Ha,
                "he" => FallbackSonioxTranscriberLanguages.He,
                "hi" => FallbackSonioxTranscriberLanguages.Hi,
                "ho" => FallbackSonioxTranscriberLanguages.Ho,
                "hr" => FallbackSonioxTranscriberLanguages.Hr,
                "ht" => FallbackSonioxTranscriberLanguages.Ht,
                "hu" => FallbackSonioxTranscriberLanguages.Hu,
                "hy" => FallbackSonioxTranscriberLanguages.Hy,
                "hz" => FallbackSonioxTranscriberLanguages.Hz,
                "ia" => FallbackSonioxTranscriberLanguages.Ia,
                "id" => FallbackSonioxTranscriberLanguages.Id,
                "ie" => FallbackSonioxTranscriberLanguages.Ie,
                "ig" => FallbackSonioxTranscriberLanguages.Ig,
                "ii" => FallbackSonioxTranscriberLanguages.Ii,
                "ik" => FallbackSonioxTranscriberLanguages.Ik,
                "io" => FallbackSonioxTranscriberLanguages.Io,
                "is" => FallbackSonioxTranscriberLanguages.Is,
                "it" => FallbackSonioxTranscriberLanguages.It,
                "iu" => FallbackSonioxTranscriberLanguages.Iu,
                "ja" => FallbackSonioxTranscriberLanguages.Ja,
                "jv" => FallbackSonioxTranscriberLanguages.Jv,
                "ka" => FallbackSonioxTranscriberLanguages.Ka,
                "kg" => FallbackSonioxTranscriberLanguages.Kg,
                "ki" => FallbackSonioxTranscriberLanguages.Ki,
                "kj" => FallbackSonioxTranscriberLanguages.Kj,
                "kk" => FallbackSonioxTranscriberLanguages.Kk,
                "kl" => FallbackSonioxTranscriberLanguages.Kl,
                "km" => FallbackSonioxTranscriberLanguages.Km,
                "kn" => FallbackSonioxTranscriberLanguages.Kn,
                "ko" => FallbackSonioxTranscriberLanguages.Ko,
                "kr" => FallbackSonioxTranscriberLanguages.Kr,
                "ks" => FallbackSonioxTranscriberLanguages.Ks,
                "ku" => FallbackSonioxTranscriberLanguages.Ku,
                "kv" => FallbackSonioxTranscriberLanguages.Kv,
                "kw" => FallbackSonioxTranscriberLanguages.Kw,
                "ky" => FallbackSonioxTranscriberLanguages.Ky,
                "la" => FallbackSonioxTranscriberLanguages.La,
                "lb" => FallbackSonioxTranscriberLanguages.Lb,
                "lg" => FallbackSonioxTranscriberLanguages.Lg,
                "li" => FallbackSonioxTranscriberLanguages.Li,
                "ln" => FallbackSonioxTranscriberLanguages.Ln,
                "lo" => FallbackSonioxTranscriberLanguages.Lo,
                "lt" => FallbackSonioxTranscriberLanguages.Lt,
                "lu" => FallbackSonioxTranscriberLanguages.Lu,
                "lv" => FallbackSonioxTranscriberLanguages.Lv,
                "mg" => FallbackSonioxTranscriberLanguages.Mg,
                "mh" => FallbackSonioxTranscriberLanguages.Mh,
                "mi" => FallbackSonioxTranscriberLanguages.Mi,
                "mk" => FallbackSonioxTranscriberLanguages.Mk,
                "ml" => FallbackSonioxTranscriberLanguages.Ml,
                "mn" => FallbackSonioxTranscriberLanguages.Mn,
                "mr" => FallbackSonioxTranscriberLanguages.Mr,
                "ms" => FallbackSonioxTranscriberLanguages.Ms,
                "mt" => FallbackSonioxTranscriberLanguages.Mt,
                "my" => FallbackSonioxTranscriberLanguages.My,
                "na" => FallbackSonioxTranscriberLanguages.Na,
                "nb" => FallbackSonioxTranscriberLanguages.Nb,
                "nd" => FallbackSonioxTranscriberLanguages.Nd,
                "ne" => FallbackSonioxTranscriberLanguages.Ne,
                "ng" => FallbackSonioxTranscriberLanguages.Ng,
                "nl" => FallbackSonioxTranscriberLanguages.Nl,
                "nn" => FallbackSonioxTranscriberLanguages.Nn,
                "no" => FallbackSonioxTranscriberLanguages.No,
                "nr" => FallbackSonioxTranscriberLanguages.Nr,
                "nv" => FallbackSonioxTranscriberLanguages.Nv,
                "ny" => FallbackSonioxTranscriberLanguages.Ny,
                "oc" => FallbackSonioxTranscriberLanguages.Oc,
                "oj" => FallbackSonioxTranscriberLanguages.Oj,
                "om" => FallbackSonioxTranscriberLanguages.Om,
                "or" => FallbackSonioxTranscriberLanguages.Or,
                "os" => FallbackSonioxTranscriberLanguages.Os,
                "pa" => FallbackSonioxTranscriberLanguages.Pa,
                "pi" => FallbackSonioxTranscriberLanguages.Pi,
                "pl" => FallbackSonioxTranscriberLanguages.Pl,
                "ps" => FallbackSonioxTranscriberLanguages.Ps,
                "pt" => FallbackSonioxTranscriberLanguages.Pt,
                "qu" => FallbackSonioxTranscriberLanguages.Qu,
                "rm" => FallbackSonioxTranscriberLanguages.Rm,
                "rn" => FallbackSonioxTranscriberLanguages.Rn,
                "ro" => FallbackSonioxTranscriberLanguages.Ro,
                "ru" => FallbackSonioxTranscriberLanguages.Ru,
                "rw" => FallbackSonioxTranscriberLanguages.Rw,
                "sa" => FallbackSonioxTranscriberLanguages.Sa,
                "sc" => FallbackSonioxTranscriberLanguages.Sc,
                "sd" => FallbackSonioxTranscriberLanguages.Sd,
                "se" => FallbackSonioxTranscriberLanguages.Se,
                "sg" => FallbackSonioxTranscriberLanguages.Sg,
                "si" => FallbackSonioxTranscriberLanguages.Si,
                "sk" => FallbackSonioxTranscriberLanguages.Sk,
                "sl" => FallbackSonioxTranscriberLanguages.Sl,
                "sm" => FallbackSonioxTranscriberLanguages.Sm,
                "sn" => FallbackSonioxTranscriberLanguages.Sn,
                "so" => FallbackSonioxTranscriberLanguages.So,
                "sq" => FallbackSonioxTranscriberLanguages.Sq,
                "sr" => FallbackSonioxTranscriberLanguages.Sr,
                "ss" => FallbackSonioxTranscriberLanguages.Ss,
                "st" => FallbackSonioxTranscriberLanguages.St,
                "su" => FallbackSonioxTranscriberLanguages.Su,
                "sv" => FallbackSonioxTranscriberLanguages.Sv,
                "sw" => FallbackSonioxTranscriberLanguages.Sw,
                "ta" => FallbackSonioxTranscriberLanguages.Ta,
                "te" => FallbackSonioxTranscriberLanguages.Te,
                "tg" => FallbackSonioxTranscriberLanguages.Tg,
                "th" => FallbackSonioxTranscriberLanguages.Th,
                "ti" => FallbackSonioxTranscriberLanguages.Ti,
                "tk" => FallbackSonioxTranscriberLanguages.Tk,
                "tl" => FallbackSonioxTranscriberLanguages.Tl,
                "tn" => FallbackSonioxTranscriberLanguages.Tn,
                "to" => FallbackSonioxTranscriberLanguages.To,
                "tr" => FallbackSonioxTranscriberLanguages.Tr,
                "ts" => FallbackSonioxTranscriberLanguages.Ts,
                "tt" => FallbackSonioxTranscriberLanguages.Tt,
                "tw" => FallbackSonioxTranscriberLanguages.Tw,
                "ty" => FallbackSonioxTranscriberLanguages.Ty,
                "ug" => FallbackSonioxTranscriberLanguages.Ug,
                "uk" => FallbackSonioxTranscriberLanguages.Uk,
                "ur" => FallbackSonioxTranscriberLanguages.Ur,
                "uz" => FallbackSonioxTranscriberLanguages.Uz,
                "ve" => FallbackSonioxTranscriberLanguages.Ve,
                "vi" => FallbackSonioxTranscriberLanguages.Vi,
                "vo" => FallbackSonioxTranscriberLanguages.Vo,
                "wa" => FallbackSonioxTranscriberLanguages.Wa,
                "wo" => FallbackSonioxTranscriberLanguages.Wo,
                "xh" => FallbackSonioxTranscriberLanguages.Xh,
                "yi" => FallbackSonioxTranscriberLanguages.Yi,
                "yo" => FallbackSonioxTranscriberLanguages.Yo,
                "yue" => FallbackSonioxTranscriberLanguages.Yue,
                "za" => FallbackSonioxTranscriberLanguages.Za,
                "zh" => FallbackSonioxTranscriberLanguages.Zh,
                "zu" => FallbackSonioxTranscriberLanguages.Zu,
                _ => null,
            };
        }
    }
}