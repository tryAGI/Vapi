
#nullable enable

namespace Vapi
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FallbackVapiVoice
    {
        /// <summary>
        /// This is the flag to toggle voice caching for the assistant.<br/>
        /// Default Value: true<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("cachingEnabled")]
        public bool? CachingEnabled { get; set; }

        /// <summary>
        /// This is the voice provider that will be used.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.FallbackVapiVoiceProviderJsonConverter))]
        public global::Vapi.FallbackVapiVoiceProvider Provider { get; set; }

        /// <summary>
        /// The voices provided by Vapi
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voiceId")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.FallbackVapiVoiceVoiceIdJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vapi.FallbackVapiVoiceVoiceId VoiceId { get; set; }

        /// <summary>
        /// The Vapi voice routing generation. Version 1 uses legacy mappings; version 2 can use xAI-backed voices when available. When omitted, Version 1 is used.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        public double? Version { get; set; }

        /// <summary>
        /// This is the speed multiplier that will be used.<br/>
        /// @default 1<br/>
        /// Default Value: 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speed")]
        public double? Speed { get; set; }

        /// <summary>
        /// Language for Vapi voice synthesis. For Version 2, omit this field or set `auto` for automatic language detection. Version 1 supports legacy Vapi language values.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.FallbackVapiVoiceLanguageJsonConverter))]
        public global::Vapi.FallbackVapiVoiceLanguage? Language { get; set; }

        /// <summary>
        /// List of pronunciation dictionary locators for custom word pronunciations.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pronunciationDictionary")]
        public global::System.Collections.Generic.IList<global::Vapi.VapiPronunciationDictionaryLocator>? PronunciationDictionary { get; set; }

        /// <summary>
        /// This is the plan for chunking the model output before it is sent to the voice provider.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chunkPlan")]
        public global::Vapi.ChunkPlan? ChunkPlan { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FallbackVapiVoice" /> class.
        /// </summary>
        /// <param name="voiceId">
        /// The voices provided by Vapi
        /// </param>
        /// <param name="cachingEnabled">
        /// This is the flag to toggle voice caching for the assistant.<br/>
        /// Default Value: true<br/>
        /// Example: true
        /// </param>
        /// <param name="provider">
        /// This is the voice provider that will be used.
        /// </param>
        /// <param name="version">
        /// The Vapi voice routing generation. Version 1 uses legacy mappings; version 2 can use xAI-backed voices when available. When omitted, Version 1 is used.
        /// </param>
        /// <param name="speed">
        /// This is the speed multiplier that will be used.<br/>
        /// @default 1<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="language">
        /// Language for Vapi voice synthesis. For Version 2, omit this field or set `auto` for automatic language detection. Version 1 supports legacy Vapi language values.
        /// </param>
        /// <param name="pronunciationDictionary">
        /// List of pronunciation dictionary locators for custom word pronunciations.
        /// </param>
        /// <param name="chunkPlan">
        /// This is the plan for chunking the model output before it is sent to the voice provider.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FallbackVapiVoice(
            global::Vapi.FallbackVapiVoiceVoiceId voiceId,
            bool? cachingEnabled,
            global::Vapi.FallbackVapiVoiceProvider provider,
            double? version,
            double? speed,
            global::Vapi.FallbackVapiVoiceLanguage? language,
            global::System.Collections.Generic.IList<global::Vapi.VapiPronunciationDictionaryLocator>? pronunciationDictionary,
            global::Vapi.ChunkPlan? chunkPlan)
        {
            this.CachingEnabled = cachingEnabled;
            this.Provider = provider;
            this.VoiceId = voiceId;
            this.Version = version;
            this.Speed = speed;
            this.Language = language;
            this.PronunciationDictionary = pronunciationDictionary;
            this.ChunkPlan = chunkPlan;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FallbackVapiVoice" /> class.
        /// </summary>
        public FallbackVapiVoice()
        {
        }

    }
}