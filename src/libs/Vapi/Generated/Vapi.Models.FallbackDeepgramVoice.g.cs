
#nullable enable

namespace Vapi
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class FallbackDeepgramVoice
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.FallbackDeepgramVoiceProviderJsonConverter))]
        public global::Vapi.FallbackDeepgramVoiceProvider Provider { get; set; }

        /// <summary>
        /// This is the provider-specific ID that will be used.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voiceId")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.FallbackDeepgramVoiceVoiceIdJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vapi.FallbackDeepgramVoiceVoiceId VoiceId { get; set; }

        /// <summary>
        /// This is the model that will be used. Defaults to 'aura' when not specified.<br/>
        /// Example: aura-2
        /// </summary>
        /// <example>aura-2</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.FallbackDeepgramVoiceModelJsonConverter))]
        public global::Vapi.FallbackDeepgramVoiceModel? Model { get; set; }

        /// <summary>
        /// If set to true, this will add mip_opt_out=true as a query parameter of all API requests. See https://developers.deepgram.com/docs/the-deepgram-model-improvement-partnership-program#want-to-opt-out<br/>
        /// This only applies to your own Deepgram API key. Requests on Vapi's key always opt out, whatever this is set to.<br/>
        /// @default false<br/>
        /// Default Value: false<br/>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("mipOptOut")]
        public bool? MipOptOut { get; set; }

        /// <summary>
        /// This is the speed multiplier that will be used. Aura-2 accepts 0.7 to 1.5; Flux accepts 0.5 to 1.5 in steps of 0.05. Aura does not support speed.<br/>
        /// @default 1<br/>
        /// Default Value: 1<br/>
        /// Example: 1.1F
        /// </summary>
        /// <example>1.1F</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("speed")]
        public double? Speed { get; set; }

        /// <summary>
        /// This is the expressivity level for Flux voices, from -2 (flat) to 2 (lively). Deepgram marks this control as beta and may retune the scale. Aura and Aura-2 do not support it.<br/>
        /// @default 0<br/>
        /// Default Value: 0<br/>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("expressivity")]
        public double? Expressivity { get; set; }

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
        /// Initializes a new instance of the <see cref="FallbackDeepgramVoice" /> class.
        /// </summary>
        /// <param name="voiceId">
        /// This is the provider-specific ID that will be used.
        /// </param>
        /// <param name="cachingEnabled">
        /// This is the flag to toggle voice caching for the assistant.<br/>
        /// Default Value: true<br/>
        /// Example: true
        /// </param>
        /// <param name="provider">
        /// This is the voice provider that will be used.
        /// </param>
        /// <param name="model">
        /// This is the model that will be used. Defaults to 'aura' when not specified.<br/>
        /// Example: aura-2
        /// </param>
        /// <param name="mipOptOut">
        /// If set to true, this will add mip_opt_out=true as a query parameter of all API requests. See https://developers.deepgram.com/docs/the-deepgram-model-improvement-partnership-program#want-to-opt-out<br/>
        /// This only applies to your own Deepgram API key. Requests on Vapi's key always opt out, whatever this is set to.<br/>
        /// @default false<br/>
        /// Default Value: false<br/>
        /// Example: false
        /// </param>
        /// <param name="speed">
        /// This is the speed multiplier that will be used. Aura-2 accepts 0.7 to 1.5; Flux accepts 0.5 to 1.5 in steps of 0.05. Aura does not support speed.<br/>
        /// @default 1<br/>
        /// Default Value: 1<br/>
        /// Example: 1.1F
        /// </param>
        /// <param name="expressivity">
        /// This is the expressivity level for Flux voices, from -2 (flat) to 2 (lively). Deepgram marks this control as beta and may retune the scale. Aura and Aura-2 do not support it.<br/>
        /// @default 0<br/>
        /// Default Value: 0<br/>
        /// Example: 1
        /// </param>
        /// <param name="chunkPlan">
        /// This is the plan for chunking the model output before it is sent to the voice provider.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FallbackDeepgramVoice(
            global::Vapi.FallbackDeepgramVoiceVoiceId voiceId,
            bool? cachingEnabled,
            global::Vapi.FallbackDeepgramVoiceProvider provider,
            global::Vapi.FallbackDeepgramVoiceModel? model,
            bool? mipOptOut,
            double? speed,
            double? expressivity,
            global::Vapi.ChunkPlan? chunkPlan)
        {
            this.CachingEnabled = cachingEnabled;
            this.Provider = provider;
            this.VoiceId = voiceId;
            this.Model = model;
            this.MipOptOut = mipOptOut;
            this.Speed = speed;
            this.Expressivity = expressivity;
            this.ChunkPlan = chunkPlan;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FallbackDeepgramVoice" /> class.
        /// </summary>
        public FallbackDeepgramVoice()
        {
        }

    }
}