
#nullable enable

namespace Vapi
{
    /// <summary>
    /// Language hints sent to Soniox as `language_hints`. Provide `[lang1, lang2, ...]` (ISO 639-1 codes) to bias recognition toward specific languages, or provide an explicit empty array `[]` to enable Soniox auto-detect across all 60+ supported languages. When set (including the empty array), this field takes precedence over the singular `language` field. When omitted, falls back to the singular `language` (which defaults to `en` if also unset). Best accuracy is achieved with a single language.
    /// </summary>
    public enum SonioxTranscriberLanguages
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
    public static class SonioxTranscriberLanguagesExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SonioxTranscriberLanguages value)
        {
            return value switch
            {
                SonioxTranscriberLanguages.Aa => "aa",
                SonioxTranscriberLanguages.Ab => "ab",
                SonioxTranscriberLanguages.Ae => "ae",
                SonioxTranscriberLanguages.Af => "af",
                SonioxTranscriberLanguages.Ak => "ak",
                SonioxTranscriberLanguages.Am => "am",
                SonioxTranscriberLanguages.An => "an",
                SonioxTranscriberLanguages.Ar => "ar",
                SonioxTranscriberLanguages.As => "as",
                SonioxTranscriberLanguages.Av => "av",
                SonioxTranscriberLanguages.Ay => "ay",
                SonioxTranscriberLanguages.Az => "az",
                SonioxTranscriberLanguages.Ba => "ba",
                SonioxTranscriberLanguages.Be => "be",
                SonioxTranscriberLanguages.Bg => "bg",
                SonioxTranscriberLanguages.Bh => "bh",
                SonioxTranscriberLanguages.Bi => "bi",
                SonioxTranscriberLanguages.Bm => "bm",
                SonioxTranscriberLanguages.Bn => "bn",
                SonioxTranscriberLanguages.Bo => "bo",
                SonioxTranscriberLanguages.Br => "br",
                SonioxTranscriberLanguages.Bs => "bs",
                SonioxTranscriberLanguages.Ca => "ca",
                SonioxTranscriberLanguages.Ce => "ce",
                SonioxTranscriberLanguages.Ch => "ch",
                SonioxTranscriberLanguages.Co => "co",
                SonioxTranscriberLanguages.Cr => "cr",
                SonioxTranscriberLanguages.Cs => "cs",
                SonioxTranscriberLanguages.Cu => "cu",
                SonioxTranscriberLanguages.Cv => "cv",
                SonioxTranscriberLanguages.Cy => "cy",
                SonioxTranscriberLanguages.Da => "da",
                SonioxTranscriberLanguages.De => "de",
                SonioxTranscriberLanguages.Dv => "dv",
                SonioxTranscriberLanguages.Dz => "dz",
                SonioxTranscriberLanguages.Ee => "ee",
                SonioxTranscriberLanguages.El => "el",
                SonioxTranscriberLanguages.En => "en",
                SonioxTranscriberLanguages.Eo => "eo",
                SonioxTranscriberLanguages.Es => "es",
                SonioxTranscriberLanguages.Et => "et",
                SonioxTranscriberLanguages.Eu => "eu",
                SonioxTranscriberLanguages.Fa => "fa",
                SonioxTranscriberLanguages.Ff => "ff",
                SonioxTranscriberLanguages.Fi => "fi",
                SonioxTranscriberLanguages.Fj => "fj",
                SonioxTranscriberLanguages.Fo => "fo",
                SonioxTranscriberLanguages.Fr => "fr",
                SonioxTranscriberLanguages.Fy => "fy",
                SonioxTranscriberLanguages.Ga => "ga",
                SonioxTranscriberLanguages.Gd => "gd",
                SonioxTranscriberLanguages.Gl => "gl",
                SonioxTranscriberLanguages.Gn => "gn",
                SonioxTranscriberLanguages.Gu => "gu",
                SonioxTranscriberLanguages.Gv => "gv",
                SonioxTranscriberLanguages.Ha => "ha",
                SonioxTranscriberLanguages.He => "he",
                SonioxTranscriberLanguages.Hi => "hi",
                SonioxTranscriberLanguages.Ho => "ho",
                SonioxTranscriberLanguages.Hr => "hr",
                SonioxTranscriberLanguages.Ht => "ht",
                SonioxTranscriberLanguages.Hu => "hu",
                SonioxTranscriberLanguages.Hy => "hy",
                SonioxTranscriberLanguages.Hz => "hz",
                SonioxTranscriberLanguages.Ia => "ia",
                SonioxTranscriberLanguages.Id => "id",
                SonioxTranscriberLanguages.Ie => "ie",
                SonioxTranscriberLanguages.Ig => "ig",
                SonioxTranscriberLanguages.Ii => "ii",
                SonioxTranscriberLanguages.Ik => "ik",
                SonioxTranscriberLanguages.Io => "io",
                SonioxTranscriberLanguages.Is => "is",
                SonioxTranscriberLanguages.It => "it",
                SonioxTranscriberLanguages.Iu => "iu",
                SonioxTranscriberLanguages.Ja => "ja",
                SonioxTranscriberLanguages.Jv => "jv",
                SonioxTranscriberLanguages.Ka => "ka",
                SonioxTranscriberLanguages.Kg => "kg",
                SonioxTranscriberLanguages.Ki => "ki",
                SonioxTranscriberLanguages.Kj => "kj",
                SonioxTranscriberLanguages.Kk => "kk",
                SonioxTranscriberLanguages.Kl => "kl",
                SonioxTranscriberLanguages.Km => "km",
                SonioxTranscriberLanguages.Kn => "kn",
                SonioxTranscriberLanguages.Ko => "ko",
                SonioxTranscriberLanguages.Kr => "kr",
                SonioxTranscriberLanguages.Ks => "ks",
                SonioxTranscriberLanguages.Ku => "ku",
                SonioxTranscriberLanguages.Kv => "kv",
                SonioxTranscriberLanguages.Kw => "kw",
                SonioxTranscriberLanguages.Ky => "ky",
                SonioxTranscriberLanguages.La => "la",
                SonioxTranscriberLanguages.Lb => "lb",
                SonioxTranscriberLanguages.Lg => "lg",
                SonioxTranscriberLanguages.Li => "li",
                SonioxTranscriberLanguages.Ln => "ln",
                SonioxTranscriberLanguages.Lo => "lo",
                SonioxTranscriberLanguages.Lt => "lt",
                SonioxTranscriberLanguages.Lu => "lu",
                SonioxTranscriberLanguages.Lv => "lv",
                SonioxTranscriberLanguages.Mg => "mg",
                SonioxTranscriberLanguages.Mh => "mh",
                SonioxTranscriberLanguages.Mi => "mi",
                SonioxTranscriberLanguages.Mk => "mk",
                SonioxTranscriberLanguages.Ml => "ml",
                SonioxTranscriberLanguages.Mn => "mn",
                SonioxTranscriberLanguages.Mr => "mr",
                SonioxTranscriberLanguages.Ms => "ms",
                SonioxTranscriberLanguages.Mt => "mt",
                SonioxTranscriberLanguages.My => "my",
                SonioxTranscriberLanguages.Na => "na",
                SonioxTranscriberLanguages.Nb => "nb",
                SonioxTranscriberLanguages.Nd => "nd",
                SonioxTranscriberLanguages.Ne => "ne",
                SonioxTranscriberLanguages.Ng => "ng",
                SonioxTranscriberLanguages.Nl => "nl",
                SonioxTranscriberLanguages.Nn => "nn",
                SonioxTranscriberLanguages.No => "no",
                SonioxTranscriberLanguages.Nr => "nr",
                SonioxTranscriberLanguages.Nv => "nv",
                SonioxTranscriberLanguages.Ny => "ny",
                SonioxTranscriberLanguages.Oc => "oc",
                SonioxTranscriberLanguages.Oj => "oj",
                SonioxTranscriberLanguages.Om => "om",
                SonioxTranscriberLanguages.Or => "or",
                SonioxTranscriberLanguages.Os => "os",
                SonioxTranscriberLanguages.Pa => "pa",
                SonioxTranscriberLanguages.Pi => "pi",
                SonioxTranscriberLanguages.Pl => "pl",
                SonioxTranscriberLanguages.Ps => "ps",
                SonioxTranscriberLanguages.Pt => "pt",
                SonioxTranscriberLanguages.Qu => "qu",
                SonioxTranscriberLanguages.Rm => "rm",
                SonioxTranscriberLanguages.Rn => "rn",
                SonioxTranscriberLanguages.Ro => "ro",
                SonioxTranscriberLanguages.Ru => "ru",
                SonioxTranscriberLanguages.Rw => "rw",
                SonioxTranscriberLanguages.Sa => "sa",
                SonioxTranscriberLanguages.Sc => "sc",
                SonioxTranscriberLanguages.Sd => "sd",
                SonioxTranscriberLanguages.Se => "se",
                SonioxTranscriberLanguages.Sg => "sg",
                SonioxTranscriberLanguages.Si => "si",
                SonioxTranscriberLanguages.Sk => "sk",
                SonioxTranscriberLanguages.Sl => "sl",
                SonioxTranscriberLanguages.Sm => "sm",
                SonioxTranscriberLanguages.Sn => "sn",
                SonioxTranscriberLanguages.So => "so",
                SonioxTranscriberLanguages.Sq => "sq",
                SonioxTranscriberLanguages.Sr => "sr",
                SonioxTranscriberLanguages.Ss => "ss",
                SonioxTranscriberLanguages.St => "st",
                SonioxTranscriberLanguages.Su => "su",
                SonioxTranscriberLanguages.Sv => "sv",
                SonioxTranscriberLanguages.Sw => "sw",
                SonioxTranscriberLanguages.Ta => "ta",
                SonioxTranscriberLanguages.Te => "te",
                SonioxTranscriberLanguages.Tg => "tg",
                SonioxTranscriberLanguages.Th => "th",
                SonioxTranscriberLanguages.Ti => "ti",
                SonioxTranscriberLanguages.Tk => "tk",
                SonioxTranscriberLanguages.Tl => "tl",
                SonioxTranscriberLanguages.Tn => "tn",
                SonioxTranscriberLanguages.To => "to",
                SonioxTranscriberLanguages.Tr => "tr",
                SonioxTranscriberLanguages.Ts => "ts",
                SonioxTranscriberLanguages.Tt => "tt",
                SonioxTranscriberLanguages.Tw => "tw",
                SonioxTranscriberLanguages.Ty => "ty",
                SonioxTranscriberLanguages.Ug => "ug",
                SonioxTranscriberLanguages.Uk => "uk",
                SonioxTranscriberLanguages.Ur => "ur",
                SonioxTranscriberLanguages.Uz => "uz",
                SonioxTranscriberLanguages.Ve => "ve",
                SonioxTranscriberLanguages.Vi => "vi",
                SonioxTranscriberLanguages.Vo => "vo",
                SonioxTranscriberLanguages.Wa => "wa",
                SonioxTranscriberLanguages.Wo => "wo",
                SonioxTranscriberLanguages.Xh => "xh",
                SonioxTranscriberLanguages.Yi => "yi",
                SonioxTranscriberLanguages.Yo => "yo",
                SonioxTranscriberLanguages.Yue => "yue",
                SonioxTranscriberLanguages.Za => "za",
                SonioxTranscriberLanguages.Zh => "zh",
                SonioxTranscriberLanguages.Zu => "zu",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SonioxTranscriberLanguages? ToEnum(string value)
        {
            return value switch
            {
                "aa" => SonioxTranscriberLanguages.Aa,
                "ab" => SonioxTranscriberLanguages.Ab,
                "ae" => SonioxTranscriberLanguages.Ae,
                "af" => SonioxTranscriberLanguages.Af,
                "ak" => SonioxTranscriberLanguages.Ak,
                "am" => SonioxTranscriberLanguages.Am,
                "an" => SonioxTranscriberLanguages.An,
                "ar" => SonioxTranscriberLanguages.Ar,
                "as" => SonioxTranscriberLanguages.As,
                "av" => SonioxTranscriberLanguages.Av,
                "ay" => SonioxTranscriberLanguages.Ay,
                "az" => SonioxTranscriberLanguages.Az,
                "ba" => SonioxTranscriberLanguages.Ba,
                "be" => SonioxTranscriberLanguages.Be,
                "bg" => SonioxTranscriberLanguages.Bg,
                "bh" => SonioxTranscriberLanguages.Bh,
                "bi" => SonioxTranscriberLanguages.Bi,
                "bm" => SonioxTranscriberLanguages.Bm,
                "bn" => SonioxTranscriberLanguages.Bn,
                "bo" => SonioxTranscriberLanguages.Bo,
                "br" => SonioxTranscriberLanguages.Br,
                "bs" => SonioxTranscriberLanguages.Bs,
                "ca" => SonioxTranscriberLanguages.Ca,
                "ce" => SonioxTranscriberLanguages.Ce,
                "ch" => SonioxTranscriberLanguages.Ch,
                "co" => SonioxTranscriberLanguages.Co,
                "cr" => SonioxTranscriberLanguages.Cr,
                "cs" => SonioxTranscriberLanguages.Cs,
                "cu" => SonioxTranscriberLanguages.Cu,
                "cv" => SonioxTranscriberLanguages.Cv,
                "cy" => SonioxTranscriberLanguages.Cy,
                "da" => SonioxTranscriberLanguages.Da,
                "de" => SonioxTranscriberLanguages.De,
                "dv" => SonioxTranscriberLanguages.Dv,
                "dz" => SonioxTranscriberLanguages.Dz,
                "ee" => SonioxTranscriberLanguages.Ee,
                "el" => SonioxTranscriberLanguages.El,
                "en" => SonioxTranscriberLanguages.En,
                "eo" => SonioxTranscriberLanguages.Eo,
                "es" => SonioxTranscriberLanguages.Es,
                "et" => SonioxTranscriberLanguages.Et,
                "eu" => SonioxTranscriberLanguages.Eu,
                "fa" => SonioxTranscriberLanguages.Fa,
                "ff" => SonioxTranscriberLanguages.Ff,
                "fi" => SonioxTranscriberLanguages.Fi,
                "fj" => SonioxTranscriberLanguages.Fj,
                "fo" => SonioxTranscriberLanguages.Fo,
                "fr" => SonioxTranscriberLanguages.Fr,
                "fy" => SonioxTranscriberLanguages.Fy,
                "ga" => SonioxTranscriberLanguages.Ga,
                "gd" => SonioxTranscriberLanguages.Gd,
                "gl" => SonioxTranscriberLanguages.Gl,
                "gn" => SonioxTranscriberLanguages.Gn,
                "gu" => SonioxTranscriberLanguages.Gu,
                "gv" => SonioxTranscriberLanguages.Gv,
                "ha" => SonioxTranscriberLanguages.Ha,
                "he" => SonioxTranscriberLanguages.He,
                "hi" => SonioxTranscriberLanguages.Hi,
                "ho" => SonioxTranscriberLanguages.Ho,
                "hr" => SonioxTranscriberLanguages.Hr,
                "ht" => SonioxTranscriberLanguages.Ht,
                "hu" => SonioxTranscriberLanguages.Hu,
                "hy" => SonioxTranscriberLanguages.Hy,
                "hz" => SonioxTranscriberLanguages.Hz,
                "ia" => SonioxTranscriberLanguages.Ia,
                "id" => SonioxTranscriberLanguages.Id,
                "ie" => SonioxTranscriberLanguages.Ie,
                "ig" => SonioxTranscriberLanguages.Ig,
                "ii" => SonioxTranscriberLanguages.Ii,
                "ik" => SonioxTranscriberLanguages.Ik,
                "io" => SonioxTranscriberLanguages.Io,
                "is" => SonioxTranscriberLanguages.Is,
                "it" => SonioxTranscriberLanguages.It,
                "iu" => SonioxTranscriberLanguages.Iu,
                "ja" => SonioxTranscriberLanguages.Ja,
                "jv" => SonioxTranscriberLanguages.Jv,
                "ka" => SonioxTranscriberLanguages.Ka,
                "kg" => SonioxTranscriberLanguages.Kg,
                "ki" => SonioxTranscriberLanguages.Ki,
                "kj" => SonioxTranscriberLanguages.Kj,
                "kk" => SonioxTranscriberLanguages.Kk,
                "kl" => SonioxTranscriberLanguages.Kl,
                "km" => SonioxTranscriberLanguages.Km,
                "kn" => SonioxTranscriberLanguages.Kn,
                "ko" => SonioxTranscriberLanguages.Ko,
                "kr" => SonioxTranscriberLanguages.Kr,
                "ks" => SonioxTranscriberLanguages.Ks,
                "ku" => SonioxTranscriberLanguages.Ku,
                "kv" => SonioxTranscriberLanguages.Kv,
                "kw" => SonioxTranscriberLanguages.Kw,
                "ky" => SonioxTranscriberLanguages.Ky,
                "la" => SonioxTranscriberLanguages.La,
                "lb" => SonioxTranscriberLanguages.Lb,
                "lg" => SonioxTranscriberLanguages.Lg,
                "li" => SonioxTranscriberLanguages.Li,
                "ln" => SonioxTranscriberLanguages.Ln,
                "lo" => SonioxTranscriberLanguages.Lo,
                "lt" => SonioxTranscriberLanguages.Lt,
                "lu" => SonioxTranscriberLanguages.Lu,
                "lv" => SonioxTranscriberLanguages.Lv,
                "mg" => SonioxTranscriberLanguages.Mg,
                "mh" => SonioxTranscriberLanguages.Mh,
                "mi" => SonioxTranscriberLanguages.Mi,
                "mk" => SonioxTranscriberLanguages.Mk,
                "ml" => SonioxTranscriberLanguages.Ml,
                "mn" => SonioxTranscriberLanguages.Mn,
                "mr" => SonioxTranscriberLanguages.Mr,
                "ms" => SonioxTranscriberLanguages.Ms,
                "mt" => SonioxTranscriberLanguages.Mt,
                "my" => SonioxTranscriberLanguages.My,
                "na" => SonioxTranscriberLanguages.Na,
                "nb" => SonioxTranscriberLanguages.Nb,
                "nd" => SonioxTranscriberLanguages.Nd,
                "ne" => SonioxTranscriberLanguages.Ne,
                "ng" => SonioxTranscriberLanguages.Ng,
                "nl" => SonioxTranscriberLanguages.Nl,
                "nn" => SonioxTranscriberLanguages.Nn,
                "no" => SonioxTranscriberLanguages.No,
                "nr" => SonioxTranscriberLanguages.Nr,
                "nv" => SonioxTranscriberLanguages.Nv,
                "ny" => SonioxTranscriberLanguages.Ny,
                "oc" => SonioxTranscriberLanguages.Oc,
                "oj" => SonioxTranscriberLanguages.Oj,
                "om" => SonioxTranscriberLanguages.Om,
                "or" => SonioxTranscriberLanguages.Or,
                "os" => SonioxTranscriberLanguages.Os,
                "pa" => SonioxTranscriberLanguages.Pa,
                "pi" => SonioxTranscriberLanguages.Pi,
                "pl" => SonioxTranscriberLanguages.Pl,
                "ps" => SonioxTranscriberLanguages.Ps,
                "pt" => SonioxTranscriberLanguages.Pt,
                "qu" => SonioxTranscriberLanguages.Qu,
                "rm" => SonioxTranscriberLanguages.Rm,
                "rn" => SonioxTranscriberLanguages.Rn,
                "ro" => SonioxTranscriberLanguages.Ro,
                "ru" => SonioxTranscriberLanguages.Ru,
                "rw" => SonioxTranscriberLanguages.Rw,
                "sa" => SonioxTranscriberLanguages.Sa,
                "sc" => SonioxTranscriberLanguages.Sc,
                "sd" => SonioxTranscriberLanguages.Sd,
                "se" => SonioxTranscriberLanguages.Se,
                "sg" => SonioxTranscriberLanguages.Sg,
                "si" => SonioxTranscriberLanguages.Si,
                "sk" => SonioxTranscriberLanguages.Sk,
                "sl" => SonioxTranscriberLanguages.Sl,
                "sm" => SonioxTranscriberLanguages.Sm,
                "sn" => SonioxTranscriberLanguages.Sn,
                "so" => SonioxTranscriberLanguages.So,
                "sq" => SonioxTranscriberLanguages.Sq,
                "sr" => SonioxTranscriberLanguages.Sr,
                "ss" => SonioxTranscriberLanguages.Ss,
                "st" => SonioxTranscriberLanguages.St,
                "su" => SonioxTranscriberLanguages.Su,
                "sv" => SonioxTranscriberLanguages.Sv,
                "sw" => SonioxTranscriberLanguages.Sw,
                "ta" => SonioxTranscriberLanguages.Ta,
                "te" => SonioxTranscriberLanguages.Te,
                "tg" => SonioxTranscriberLanguages.Tg,
                "th" => SonioxTranscriberLanguages.Th,
                "ti" => SonioxTranscriberLanguages.Ti,
                "tk" => SonioxTranscriberLanguages.Tk,
                "tl" => SonioxTranscriberLanguages.Tl,
                "tn" => SonioxTranscriberLanguages.Tn,
                "to" => SonioxTranscriberLanguages.To,
                "tr" => SonioxTranscriberLanguages.Tr,
                "ts" => SonioxTranscriberLanguages.Ts,
                "tt" => SonioxTranscriberLanguages.Tt,
                "tw" => SonioxTranscriberLanguages.Tw,
                "ty" => SonioxTranscriberLanguages.Ty,
                "ug" => SonioxTranscriberLanguages.Ug,
                "uk" => SonioxTranscriberLanguages.Uk,
                "ur" => SonioxTranscriberLanguages.Ur,
                "uz" => SonioxTranscriberLanguages.Uz,
                "ve" => SonioxTranscriberLanguages.Ve,
                "vi" => SonioxTranscriberLanguages.Vi,
                "vo" => SonioxTranscriberLanguages.Vo,
                "wa" => SonioxTranscriberLanguages.Wa,
                "wo" => SonioxTranscriberLanguages.Wo,
                "xh" => SonioxTranscriberLanguages.Xh,
                "yi" => SonioxTranscriberLanguages.Yi,
                "yo" => SonioxTranscriberLanguages.Yo,
                "yue" => SonioxTranscriberLanguages.Yue,
                "za" => SonioxTranscriberLanguages.Za,
                "zh" => SonioxTranscriberLanguages.Zh,
                "zu" => SonioxTranscriberLanguages.Zu,
                _ => null,
            };
        }
    }
}