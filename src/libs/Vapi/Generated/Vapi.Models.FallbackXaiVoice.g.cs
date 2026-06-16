
#nullable enable

namespace Vapi
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FallbackXaiVoice
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.FallbackXaiVoiceProviderJsonConverter))]
        public global::Vapi.FallbackXaiVoiceProvider Provider { get; set; }

        /// <summary>
        /// Built-in voices: eve, ara, rex, sal, leo. Cloned voice IDs are also accepted.<br/>
        /// Example: eve
        /// </summary>
        /// <example>eve</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("voiceId")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.FallbackXaiVoiceVoiceIdJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vapi.FallbackXaiVoiceVoiceId VoiceId { get; set; }

        /// <summary>
        /// BCP-47 language code for xAI TTS synthesis.<br/>
        /// Default Value: en
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.FallbackXaiVoiceLanguageJsonConverter))]
        public global::Vapi.FallbackXaiVoiceLanguage? Language { get; set; }

        /// <summary>
        /// Speed multiplier for xAI TTS synthesis.<br/>
        /// Default Value: 1.1F
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speed")]
        public double? Speed { get; set; }

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
        /// Initializes a new instance of the <see cref="FallbackXaiVoice" /> class.
        /// </summary>
        /// <param name="voiceId">
        /// Built-in voices: eve, ara, rex, sal, leo. Cloned voice IDs are also accepted.<br/>
        /// Example: eve
        /// </param>
        /// <param name="cachingEnabled">
        /// This is the flag to toggle voice caching for the assistant.<br/>
        /// Default Value: true<br/>
        /// Example: true
        /// </param>
        /// <param name="provider">
        /// This is the voice provider that will be used.
        /// </param>
        /// <param name="language">
        /// BCP-47 language code for xAI TTS synthesis.<br/>
        /// Default Value: en
        /// </param>
        /// <param name="speed">
        /// Speed multiplier for xAI TTS synthesis.<br/>
        /// Default Value: 1.1F
        /// </param>
        /// <param name="chunkPlan">
        /// This is the plan for chunking the model output before it is sent to the voice provider.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FallbackXaiVoice(
            global::Vapi.FallbackXaiVoiceVoiceId voiceId,
            bool? cachingEnabled,
            global::Vapi.FallbackXaiVoiceProvider provider,
            global::Vapi.FallbackXaiVoiceLanguage? language,
            double? speed,
            global::Vapi.ChunkPlan? chunkPlan)
        {
            this.CachingEnabled = cachingEnabled;
            this.Provider = provider;
            this.VoiceId = voiceId;
            this.Language = language;
            this.Speed = speed;
            this.ChunkPlan = chunkPlan;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FallbackXaiVoice" /> class.
        /// </summary>
        public FallbackXaiVoice()
        {
        }

    }
}