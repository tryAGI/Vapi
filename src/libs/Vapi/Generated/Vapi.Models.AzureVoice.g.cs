
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vapi
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AzureVoice
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.AzureVoiceProviderJsonConverter))]
        public global::Vapi.AzureVoiceProvider Provider { get; set; }

        /// <summary>
        /// This is the provider-specific ID that will be used.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voiceId")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.AzureVoiceVoiceId?, string>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vapi.OneOf<global::Vapi.AzureVoiceVoiceId?, string> VoiceId { get; set; }

        /// <summary>
        /// This is the plan for chunking the model output before it is sent to the voice provider.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chunkPlan")]
        public global::Vapi.ChunkPlan? ChunkPlan { get; set; }

        /// <summary>
        /// This is the speed multiplier that will be used.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speed")]
        public double? Speed { get; set; }

        /// <summary>
        /// This is the plan for voice provider fallbacks in the event that the primary voice provider fails.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fallbackPlan")]
        public global::Vapi.FallbackPlan? FallbackPlan { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AzureVoice" /> class.
        /// </summary>
        /// <param name="cachingEnabled">
        /// This is the flag to toggle voice caching for the assistant.<br/>
        /// Default Value: true<br/>
        /// Example: true
        /// </param>
        /// <param name="provider">
        /// This is the voice provider that will be used.
        /// </param>
        /// <param name="voiceId">
        /// This is the provider-specific ID that will be used.
        /// </param>
        /// <param name="chunkPlan">
        /// This is the plan for chunking the model output before it is sent to the voice provider.
        /// </param>
        /// <param name="speed">
        /// This is the speed multiplier that will be used.
        /// </param>
        /// <param name="fallbackPlan">
        /// This is the plan for voice provider fallbacks in the event that the primary voice provider fails.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AzureVoice(
            global::Vapi.OneOf<global::Vapi.AzureVoiceVoiceId?, string> voiceId,
            bool? cachingEnabled,
            global::Vapi.AzureVoiceProvider provider,
            global::Vapi.ChunkPlan? chunkPlan,
            double? speed,
            global::Vapi.FallbackPlan? fallbackPlan)
        {
            this.VoiceId = voiceId;
            this.CachingEnabled = cachingEnabled;
            this.Provider = provider;
            this.ChunkPlan = chunkPlan;
            this.Speed = speed;
            this.FallbackPlan = fallbackPlan;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AzureVoice" /> class.
        /// </summary>
        public AzureVoice()
        {
        }
    }
}