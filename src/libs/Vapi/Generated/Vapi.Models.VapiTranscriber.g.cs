
#nullable enable

namespace Vapi
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VapiTranscriber
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.VapiTranscriberProviderJsonConverter))]
        public global::Vapi.VapiTranscriberProvider Provider { get; set; }

        /// <summary>
        /// This is the version of the Vapi transcriber. Vapi manages the underlying<br/>
        /// model and routing. When omitted, the latest version is used.<br/>
        /// Managed version params are additive-only and `'latest'` is an auto-update<br/>
        /// channel — see the param-evolution INVARIANT in `vapiManaged/types.ts`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.VapiTranscriberVersionJsonConverter))]
        public global::Vapi.VapiTranscriberVersion? Version { get; set; }

        /// <summary>
        /// This is the language for transcription as an ISO 639-1 code (e.g. `en`).<br/>
        /// Selecting a language locks transcription to it. For multiple languages,<br/>
        /// use `languages` instead. When neither `language` nor `languages` is set,<br/>
        /// the transcriber auto-detects the spoken language.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.VapiTranscriberLanguageJsonConverter))]
        public global::Vapi.VapiTranscriberLanguage? Language { get; set; }

        /// <summary>
        /// These are the languages for transcription as ISO 639-1 codes. Set one or<br/>
        /// more codes to restrict and bias recognition to those languages. An empty<br/>
        /// array `[]` (or omitting both this and `language`) enables auto-detection<br/>
        /// of the spoken language.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("languages")]
        public global::System.Collections.Generic.IList<global::Vapi.VapiTranscriberLanguage2>? Languages { get; set; }

        /// <summary>
        /// These are custom keywords/vocabulary to boost recognition of use-case<br/>
        /// specific words (company names, product names, jargon).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("keywords")]
        public global::System.Collections.Generic.IList<string>? Keywords { get; set; }

        /// <summary>
        /// This is the turn-taking mode. `intelligent` uses the underlying model's<br/>
        /// native end-of-turn detection; `manual` ignores it and waits a fixed<br/>
        /// end-of-turn delay. Defaults to `intelligent`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("turnTaking")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.VapiTranscriberTurnTakingJsonConverter))]
        public global::Vapi.VapiTranscriberTurnTaking? TurnTaking { get; set; }

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
        /// Initializes a new instance of the <see cref="VapiTranscriber" /> class.
        /// </summary>
        /// <param name="provider"></param>
        /// <param name="version">
        /// This is the version of the Vapi transcriber. Vapi manages the underlying<br/>
        /// model and routing. When omitted, the latest version is used.<br/>
        /// Managed version params are additive-only and `'latest'` is an auto-update<br/>
        /// channel — see the param-evolution INVARIANT in `vapiManaged/types.ts`.
        /// </param>
        /// <param name="language">
        /// This is the language for transcription as an ISO 639-1 code (e.g. `en`).<br/>
        /// Selecting a language locks transcription to it. For multiple languages,<br/>
        /// use `languages` instead. When neither `language` nor `languages` is set,<br/>
        /// the transcriber auto-detects the spoken language.
        /// </param>
        /// <param name="languages">
        /// These are the languages for transcription as ISO 639-1 codes. Set one or<br/>
        /// more codes to restrict and bias recognition to those languages. An empty<br/>
        /// array `[]` (or omitting both this and `language`) enables auto-detection<br/>
        /// of the spoken language.
        /// </param>
        /// <param name="keywords">
        /// These are custom keywords/vocabulary to boost recognition of use-case<br/>
        /// specific words (company names, product names, jargon).
        /// </param>
        /// <param name="turnTaking">
        /// This is the turn-taking mode. `intelligent` uses the underlying model's<br/>
        /// native end-of-turn detection; `manual` ignores it and waits a fixed<br/>
        /// end-of-turn delay. Defaults to `intelligent`.
        /// </param>
        /// <param name="fallbackPlan">
        /// This is the plan for transcriber provider fallbacks in the event that the primary transcriber provider fails.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VapiTranscriber(
            global::Vapi.VapiTranscriberProvider provider,
            global::Vapi.VapiTranscriberVersion? version,
            global::Vapi.VapiTranscriberLanguage? language,
            global::System.Collections.Generic.IList<global::Vapi.VapiTranscriberLanguage2>? languages,
            global::System.Collections.Generic.IList<string>? keywords,
            global::Vapi.VapiTranscriberTurnTaking? turnTaking,
            global::Vapi.FallbackTranscriberPlan? fallbackPlan)
        {
            this.Provider = provider;
            this.Version = version;
            this.Language = language;
            this.Languages = languages;
            this.Keywords = keywords;
            this.TurnTaking = turnTaking;
            this.FallbackPlan = fallbackPlan;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VapiTranscriber" /> class.
        /// </summary>
        public VapiTranscriber()
        {
        }

    }
}