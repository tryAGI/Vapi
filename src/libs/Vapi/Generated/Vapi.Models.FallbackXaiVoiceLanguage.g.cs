
#nullable enable

namespace Vapi
{
    /// <summary>
    /// BCP-47 language code for xAI TTS synthesis.<br/>
    /// Default Value: en
    /// </summary>
    public enum FallbackXaiVoiceLanguage
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
    public static class FallbackXaiVoiceLanguageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FallbackXaiVoiceLanguage value)
        {
            return value switch
            {
                FallbackXaiVoiceLanguage.ArAe => "ar-AE",
                FallbackXaiVoiceLanguage.ArEg => "ar-EG",
                FallbackXaiVoiceLanguage.ArSa => "ar-SA",
                FallbackXaiVoiceLanguage.Auto => "auto",
                FallbackXaiVoiceLanguage.Bn => "bn",
                FallbackXaiVoiceLanguage.De => "de",
                FallbackXaiVoiceLanguage.En => "en",
                FallbackXaiVoiceLanguage.EsEs => "es-ES",
                FallbackXaiVoiceLanguage.EsMx => "es-MX",
                FallbackXaiVoiceLanguage.Fr => "fr",
                FallbackXaiVoiceLanguage.Hi => "hi",
                FallbackXaiVoiceLanguage.Id => "id",
                FallbackXaiVoiceLanguage.It => "it",
                FallbackXaiVoiceLanguage.Ja => "ja",
                FallbackXaiVoiceLanguage.Ko => "ko",
                FallbackXaiVoiceLanguage.PtBr => "pt-BR",
                FallbackXaiVoiceLanguage.PtPt => "pt-PT",
                FallbackXaiVoiceLanguage.Ru => "ru",
                FallbackXaiVoiceLanguage.Tr => "tr",
                FallbackXaiVoiceLanguage.Vi => "vi",
                FallbackXaiVoiceLanguage.Zh => "zh",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FallbackXaiVoiceLanguage? ToEnum(string value)
        {
            return value switch
            {
                "ar-AE" => FallbackXaiVoiceLanguage.ArAe,
                "ar-EG" => FallbackXaiVoiceLanguage.ArEg,
                "ar-SA" => FallbackXaiVoiceLanguage.ArSa,
                "auto" => FallbackXaiVoiceLanguage.Auto,
                "bn" => FallbackXaiVoiceLanguage.Bn,
                "de" => FallbackXaiVoiceLanguage.De,
                "en" => FallbackXaiVoiceLanguage.En,
                "es-ES" => FallbackXaiVoiceLanguage.EsEs,
                "es-MX" => FallbackXaiVoiceLanguage.EsMx,
                "fr" => FallbackXaiVoiceLanguage.Fr,
                "hi" => FallbackXaiVoiceLanguage.Hi,
                "id" => FallbackXaiVoiceLanguage.Id,
                "it" => FallbackXaiVoiceLanguage.It,
                "ja" => FallbackXaiVoiceLanguage.Ja,
                "ko" => FallbackXaiVoiceLanguage.Ko,
                "pt-BR" => FallbackXaiVoiceLanguage.PtBr,
                "pt-PT" => FallbackXaiVoiceLanguage.PtPt,
                "ru" => FallbackXaiVoiceLanguage.Ru,
                "tr" => FallbackXaiVoiceLanguage.Tr,
                "vi" => FallbackXaiVoiceLanguage.Vi,
                "zh" => FallbackXaiVoiceLanguage.Zh,
                _ => null,
            };
        }
    }
}