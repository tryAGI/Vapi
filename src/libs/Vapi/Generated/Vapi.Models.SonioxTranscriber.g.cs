
#nullable enable

namespace Vapi
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SonioxTranscriber
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.SonioxTranscriberProviderJsonConverter))]
        public global::Vapi.SonioxTranscriberProvider Provider { get; set; }

        /// <summary>
        /// The Soniox model to use for transcription.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.SonioxTranscriberModelJsonConverter))]
        public global::Vapi.SonioxTranscriberModel? Model { get; set; }

        /// <summary>
        /// Single language for transcription as an ISO 639-1 code (e.g., `en`, `es`). For multi-language hints or to enable Soniox auto-detect, use `languages` instead — when `languages` is set (including to an empty array), this field is ignored when building the Soniox request. Defaults to `en` if neither this nor `languages` is set.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.SonioxTranscriberLanguageJsonConverter))]
        public global::Vapi.SonioxTranscriberLanguage? Language { get; set; }

        /// <summary>
        /// Language hints sent to Soniox as `language_hints`. Provide `[lang1, lang2, ...]` (ISO 639-1 codes) to bias recognition toward specific languages, or provide an explicit empty array `[]` to enable Soniox auto-detect across all 60+ supported languages. When set (including the empty array), this field takes precedence over the singular `language` field. When omitted, falls back to the singular `language` (which defaults to `en` if also unset). Best accuracy is achieved with a single language.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("languages")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.SonioxTranscriberLanguagesJsonConverter))]
        public global::Vapi.SonioxTranscriberLanguages? Languages { get; set; }

        /// <summary>
        /// When `true`, Soniox strictly restricts transcription to the languages in `languages` (or the singular `language` if `languages` is unset). When `false`, Soniox biases toward those languages but still allows transcription in other languages. Has no effect when no language hints are sent (e.g., `languages: []` for auto-detect). Defaults to `true` (strict mode).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("languageHintsStrict")]
        public bool? LanguageHintsStrict { get; set; }

        /// <summary>
        /// Maximum delay in milliseconds between when the speaker stops and when the endpoint is detected. Lower values mean faster turn-taking but more false endpoints. Range: 500-3000. Default: 500.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maxEndpointDelayMs")]
        public double? MaxEndpointDelayMs { get; set; }

        /// <summary>
        /// Custom vocabulary terms to boost recognition accuracy. Useful for brand names, product names, and domain-specific terminology. Maps to Soniox context.terms.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("customVocabulary")]
        public global::System.Collections.Generic.IList<string>? CustomVocabulary { get; set; }

        /// <summary>
        /// General context key-value pairs that guide the AI model during transcription. Helps adapt vocabulary to the correct domain, improving accuracy. Recommended: 10 or fewer pairs. Maps to Soniox context.general.<br/>
        /// Example: [{"key":"domain","value":"Healthcare"}, {"key":"topic","value":"Diabetes management consultation"}]
        /// </summary>
        /// <example>[{"key":"domain","value":"Healthcare"}, {"key":"topic","value":"Diabetes management consultation"}]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("contextGeneral")]
        public global::System.Collections.Generic.IList<global::Vapi.SonioxContextGeneralItem>? ContextGeneral { get; set; }

        /// <summary>
        /// This is the plan for transcriber provider fallbacks in the event that the primary transcriber provider fails.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fallbackPlan")]
        public global::Vapi.FallbackTranscriberPlan? FallbackPlan { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SonioxTranscriber" /> class.
        /// </summary>
        /// <param name="provider"></param>
        /// <param name="model">
        /// The Soniox model to use for transcription.
        /// </param>
        /// <param name="language">
        /// Single language for transcription as an ISO 639-1 code (e.g., `en`, `es`). For multi-language hints or to enable Soniox auto-detect, use `languages` instead — when `languages` is set (including to an empty array), this field is ignored when building the Soniox request. Defaults to `en` if neither this nor `languages` is set.
        /// </param>
        /// <param name="languages">
        /// Language hints sent to Soniox as `language_hints`. Provide `[lang1, lang2, ...]` (ISO 639-1 codes) to bias recognition toward specific languages, or provide an explicit empty array `[]` to enable Soniox auto-detect across all 60+ supported languages. When set (including the empty array), this field takes precedence over the singular `language` field. When omitted, falls back to the singular `language` (which defaults to `en` if also unset). Best accuracy is achieved with a single language.
        /// </param>
        /// <param name="languageHintsStrict">
        /// When `true`, Soniox strictly restricts transcription to the languages in `languages` (or the singular `language` if `languages` is unset). When `false`, Soniox biases toward those languages but still allows transcription in other languages. Has no effect when no language hints are sent (e.g., `languages: []` for auto-detect). Defaults to `true` (strict mode).
        /// </param>
        /// <param name="maxEndpointDelayMs">
        /// Maximum delay in milliseconds between when the speaker stops and when the endpoint is detected. Lower values mean faster turn-taking but more false endpoints. Range: 500-3000. Default: 500.
        /// </param>
        /// <param name="customVocabulary">
        /// Custom vocabulary terms to boost recognition accuracy. Useful for brand names, product names, and domain-specific terminology. Maps to Soniox context.terms.
        /// </param>
        /// <param name="contextGeneral">
        /// General context key-value pairs that guide the AI model during transcription. Helps adapt vocabulary to the correct domain, improving accuracy. Recommended: 10 or fewer pairs. Maps to Soniox context.general.<br/>
        /// Example: [{"key":"domain","value":"Healthcare"}, {"key":"topic","value":"Diabetes management consultation"}]
        /// </param>
        /// <param name="fallbackPlan">
        /// This is the plan for transcriber provider fallbacks in the event that the primary transcriber provider fails.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SonioxTranscriber(
            global::Vapi.SonioxTranscriberProvider provider,
            global::Vapi.SonioxTranscriberModel? model,
            global::Vapi.SonioxTranscriberLanguage? language,
            global::Vapi.SonioxTranscriberLanguages? languages,
            bool? languageHintsStrict,
            double? maxEndpointDelayMs,
            global::System.Collections.Generic.IList<string>? customVocabulary,
            global::System.Collections.Generic.IList<global::Vapi.SonioxContextGeneralItem>? contextGeneral,
            global::Vapi.FallbackTranscriberPlan? fallbackPlan)
        {
            this.Provider = provider;
            this.Model = model;
            this.Language = language;
            this.Languages = languages;
            this.LanguageHintsStrict = languageHintsStrict;
            this.MaxEndpointDelayMs = maxEndpointDelayMs;
            this.CustomVocabulary = customVocabulary;
            this.ContextGeneral = contextGeneral;
            this.FallbackPlan = fallbackPlan;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SonioxTranscriber" /> class.
        /// </summary>
        public SonioxTranscriber()
        {
        }
    }
}