
#nullable enable

namespace Vapi
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MicrosoftVoice
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.MicrosoftVoiceProviderJsonConverter))]
        public global::Vapi.MicrosoftVoiceProvider Provider { get; set; }

        /// <summary>
        /// MAI-Voice-2 voice ID. Built-in voices listed in enum.<br/>
        /// Example: en-US-Ethan:MAI-Voice-2
        /// </summary>
        /// <example>en-US-Ethan:MAI-Voice-2</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("voiceId")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.MicrosoftVoiceVoiceIdJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vapi.MicrosoftVoiceVoiceId VoiceId { get; set; }

        /// <summary>
        /// Speaking style applied via mstts:express-as on every request. Unknown styles are ignored by Azure and fall back to neutral.<br/>
        /// Example: happy
        /// </summary>
        /// <example>happy</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("style")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.MicrosoftVoiceStyleJsonConverter))]
        public global::Vapi.MicrosoftVoiceStyle? Style { get; set; }

        /// <summary>
        /// Style intensity (0.01–2). Default 1 = the predefined style strength. Only applies when `style` is set.<br/>
        /// Default Value: 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("styleDegree")]
        public double? StyleDegree { get; set; }

        /// <summary>
        /// Role-play (age/gender imitation). Requires `style` to be set; ignored otherwise.<br/>
        /// Example: YoungAdultFemale
        /// </summary>
        /// <example>YoungAdultFemale</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.MicrosoftVoiceRoleJsonConverter))]
        public global::Vapi.MicrosoftVoiceRole? Role { get; set; }

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
        /// Initializes a new instance of the <see cref="MicrosoftVoice" /> class.
        /// </summary>
        /// <param name="voiceId">
        /// MAI-Voice-2 voice ID. Built-in voices listed in enum.<br/>
        /// Example: en-US-Ethan:MAI-Voice-2
        /// </param>
        /// <param name="cachingEnabled">
        /// This is the flag to toggle voice caching for the assistant.<br/>
        /// Default Value: true<br/>
        /// Example: true
        /// </param>
        /// <param name="provider">
        /// This is the voice provider that will be used.
        /// </param>
        /// <param name="style">
        /// Speaking style applied via mstts:express-as on every request. Unknown styles are ignored by Azure and fall back to neutral.<br/>
        /// Example: happy
        /// </param>
        /// <param name="styleDegree">
        /// Style intensity (0.01–2). Default 1 = the predefined style strength. Only applies when `style` is set.<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="role">
        /// Role-play (age/gender imitation). Requires `style` to be set; ignored otherwise.<br/>
        /// Example: YoungAdultFemale
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
        public MicrosoftVoice(
            global::Vapi.MicrosoftVoiceVoiceId voiceId,
            bool? cachingEnabled,
            global::Vapi.MicrosoftVoiceProvider provider,
            global::Vapi.MicrosoftVoiceStyle? style,
            double? styleDegree,
            global::Vapi.MicrosoftVoiceRole? role,
            global::Vapi.ChunkPlan? chunkPlan,
            double? speed,
            global::Vapi.FallbackPlan? fallbackPlan)
        {
            this.CachingEnabled = cachingEnabled;
            this.Provider = provider;
            this.VoiceId = voiceId;
            this.Style = style;
            this.StyleDegree = styleDegree;
            this.Role = role;
            this.ChunkPlan = chunkPlan;
            this.Speed = speed;
            this.FallbackPlan = fallbackPlan;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MicrosoftVoice" /> class.
        /// </summary>
        public MicrosoftVoice()
        {
        }

    }
}