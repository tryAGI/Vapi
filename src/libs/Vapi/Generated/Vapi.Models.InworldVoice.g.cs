
#nullable enable

namespace Vapi
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class InworldVoice
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.InworldVoiceProviderJsonConverter))]
        public global::Vapi.InworldVoiceProvider Provider { get; set; }

        /// <summary>
        /// Available voices by language:<br/>
        /// • en: Alex, Ashley, Craig, Deborah, Dennis, Edward, Elizabeth, Hades, Julia, Pixie, Mark, Olivia, Priya, Ronald, Sarah, Shaun, Theodore, Timothy, Wendy, Dominus, Hana, Clive, Carter, Blake, Luna<br/>
        /// • zh: Yichen, Xiaoyin, Xinyi, Jing<br/>
        /// • nl: Erik, Katrien, Lennart, Lore<br/>
        /// • fr: Alain, Hélène, Mathieu, Étienne<br/>
        /// • de: Johanna, Josef<br/>
        /// • it: Gianni, Orietta<br/>
        /// • ja: Asuka, Satoshi<br/>
        /// • ko: Hyunwoo, Minji, Seojun, Yoona<br/>
        /// • pl: Szymon, Wojciech<br/>
        /// • pt: Heitor, Maitê<br/>
        /// • es: Diego, Lupita, Miguel, Rafael<br/>
        /// • ru: Svetlana, Elena, Dmitry, Nikolai<br/>
        /// • hi: Riya, Manoj<br/>
        /// • he: Yael, Oren<br/>
        /// • ar: Nour, Omar<br/>
        /// Example: Alex
        /// </summary>
        /// <example>Alex</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("voiceId")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.InworldVoiceVoiceIdJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vapi.InworldVoiceVoiceId VoiceId { get; set; }

        /// <summary>
        /// This is the model that will be used.<br/>
        /// Default Value: inworld-tts-1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.InworldVoiceModelJsonConverter))]
        public global::Vapi.InworldVoiceModel? Model { get; set; }

        /// <summary>
        /// Language code for Inworld TTS synthesis<br/>
        /// Default Value: en
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("languageCode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.InworldVoiceLanguageCodeJsonConverter))]
        public global::Vapi.InworldVoiceLanguageCode? LanguageCode { get; set; }

        /// <summary>
        /// A floating point number between 0, exclusive, and 2, inclusive. If equal to null or not provided, the model's default temperature of 1.1 will be used. The temperature parameter controls variance.<br/>
        /// Higher values will make the output more random and can lead to more expressive results. Lower values will make it more deterministic.<br/>
        /// See https://docs.inworld.ai/docs/tts/capabilities/generating-audio#additional-configurations for more details.<br/>
        /// Default Value: 1.1F<br/>
        /// Example: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        /// <example>openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("temperature")]
        public double? Temperature { get; set; }

        /// <summary>
        /// A floating point number between 0.5, inclusive, and 1.5, inclusive. If equal to null or not provided, the model's default speaking speed of 1.0 will be used.<br/>
        /// Values above 0.8 are recommended for higher quality.<br/>
        /// See https://docs.inworld.ai/docs/tts/capabilities/generating-audio#additional-configurations for more details.<br/>
        /// Default Value: 1<br/>
        /// Example: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        /// <example>openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("speakingRate")]
        public double? SpeakingRate { get; set; }

        /// <summary>
        /// This is the plan for chunking the model output before it is sent to the voice provider.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chunkPlan")]
        public global::Vapi.ChunkPlan? ChunkPlan { get; set; }

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
        /// Initializes a new instance of the <see cref="InworldVoice" /> class.
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
        /// Available voices by language:<br/>
        /// • en: Alex, Ashley, Craig, Deborah, Dennis, Edward, Elizabeth, Hades, Julia, Pixie, Mark, Olivia, Priya, Ronald, Sarah, Shaun, Theodore, Timothy, Wendy, Dominus, Hana, Clive, Carter, Blake, Luna<br/>
        /// • zh: Yichen, Xiaoyin, Xinyi, Jing<br/>
        /// • nl: Erik, Katrien, Lennart, Lore<br/>
        /// • fr: Alain, Hélène, Mathieu, Étienne<br/>
        /// • de: Johanna, Josef<br/>
        /// • it: Gianni, Orietta<br/>
        /// • ja: Asuka, Satoshi<br/>
        /// • ko: Hyunwoo, Minji, Seojun, Yoona<br/>
        /// • pl: Szymon, Wojciech<br/>
        /// • pt: Heitor, Maitê<br/>
        /// • es: Diego, Lupita, Miguel, Rafael<br/>
        /// • ru: Svetlana, Elena, Dmitry, Nikolai<br/>
        /// • hi: Riya, Manoj<br/>
        /// • he: Yael, Oren<br/>
        /// • ar: Nour, Omar<br/>
        /// Example: Alex
        /// </param>
        /// <param name="model">
        /// This is the model that will be used.<br/>
        /// Default Value: inworld-tts-1
        /// </param>
        /// <param name="languageCode">
        /// Language code for Inworld TTS synthesis<br/>
        /// Default Value: en
        /// </param>
        /// <param name="temperature">
        /// A floating point number between 0, exclusive, and 2, inclusive. If equal to null or not provided, the model's default temperature of 1.1 will be used. The temperature parameter controls variance.<br/>
        /// Higher values will make the output more random and can lead to more expressive results. Lower values will make it more deterministic.<br/>
        /// See https://docs.inworld.ai/docs/tts/capabilities/generating-audio#additional-configurations for more details.<br/>
        /// Default Value: 1.1F<br/>
        /// Example: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="speakingRate">
        /// A floating point number between 0.5, inclusive, and 1.5, inclusive. If equal to null or not provided, the model's default speaking speed of 1.0 will be used.<br/>
        /// Values above 0.8 are recommended for higher quality.<br/>
        /// See https://docs.inworld.ai/docs/tts/capabilities/generating-audio#additional-configurations for more details.<br/>
        /// Default Value: 1<br/>
        /// Example: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="chunkPlan">
        /// This is the plan for chunking the model output before it is sent to the voice provider.
        /// </param>
        /// <param name="fallbackPlan">
        /// This is the plan for voice provider fallbacks in the event that the primary voice provider fails.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InworldVoice(
            global::Vapi.InworldVoiceVoiceId voiceId,
            bool? cachingEnabled,
            global::Vapi.InworldVoiceProvider provider,
            global::Vapi.InworldVoiceModel? model,
            global::Vapi.InworldVoiceLanguageCode? languageCode,
            double? temperature,
            double? speakingRate,
            global::Vapi.ChunkPlan? chunkPlan,
            global::Vapi.FallbackPlan? fallbackPlan)
        {
            this.VoiceId = voiceId;
            this.CachingEnabled = cachingEnabled;
            this.Provider = provider;
            this.Model = model;
            this.LanguageCode = languageCode;
            this.Temperature = temperature;
            this.SpeakingRate = speakingRate;
            this.ChunkPlan = chunkPlan;
            this.FallbackPlan = fallbackPlan;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InworldVoice" /> class.
        /// </summary>
        public InworldVoice()
        {
        }
    }
}