
#nullable enable

namespace Vapi
{
    /// <summary>
    /// BCP-47 language code for xAI TTS synthesis.<br/>
    /// Default Value: en
    /// </summary>
    public enum XaiVoiceLanguage
    {
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
        Bn,
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
        EsEs,
        /// <summary>
        /// 
        /// </summary>
        EsMx,
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
        PtBr,
        /// <summary>
        /// 
        /// </summary>
        PtPt,
        /// <summary>
        /// 
        /// </summary>
        Ru,
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
    public static class XaiVoiceLanguageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this XaiVoiceLanguage value)
        {
            return value switch
            {
                XaiVoiceLanguage.ArAe => "ar-AE",
                XaiVoiceLanguage.ArEg => "ar-EG",
                XaiVoiceLanguage.ArSa => "ar-SA",
                XaiVoiceLanguage.Auto => "auto",
                XaiVoiceLanguage.Bn => "bn",
                XaiVoiceLanguage.De => "de",
                XaiVoiceLanguage.En => "en",
                XaiVoiceLanguage.EsEs => "es-ES",
                XaiVoiceLanguage.EsMx => "es-MX",
                XaiVoiceLanguage.Fr => "fr",
                XaiVoiceLanguage.Hi => "hi",
                XaiVoiceLanguage.Id => "id",
                XaiVoiceLanguage.It => "it",
                XaiVoiceLanguage.Ja => "ja",
                XaiVoiceLanguage.Ko => "ko",
                XaiVoiceLanguage.PtBr => "pt-BR",
                XaiVoiceLanguage.PtPt => "pt-PT",
                XaiVoiceLanguage.Ru => "ru",
                XaiVoiceLanguage.Tr => "tr",
                XaiVoiceLanguage.Vi => "vi",
                XaiVoiceLanguage.Zh => "zh",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static XaiVoiceLanguage? ToEnum(string value)
        {
            return value switch
            {
                "ar-AE" => XaiVoiceLanguage.ArAe,
                "ar-EG" => XaiVoiceLanguage.ArEg,
                "ar-SA" => XaiVoiceLanguage.ArSa,
                "auto" => XaiVoiceLanguage.Auto,
                "bn" => XaiVoiceLanguage.Bn,
                "de" => XaiVoiceLanguage.De,
                "en" => XaiVoiceLanguage.En,
                "es-ES" => XaiVoiceLanguage.EsEs,
                "es-MX" => XaiVoiceLanguage.EsMx,
                "fr" => XaiVoiceLanguage.Fr,
                "hi" => XaiVoiceLanguage.Hi,
                "id" => XaiVoiceLanguage.Id,
                "it" => XaiVoiceLanguage.It,
                "ja" => XaiVoiceLanguage.Ja,
                "ko" => XaiVoiceLanguage.Ko,
                "pt-BR" => XaiVoiceLanguage.PtBr,
                "pt-PT" => XaiVoiceLanguage.PtPt,
                "ru" => XaiVoiceLanguage.Ru,
                "tr" => XaiVoiceLanguage.Tr,
                "vi" => XaiVoiceLanguage.Vi,
                "zh" => XaiVoiceLanguage.Zh,
                _ => null,
            };
        }
    }
}