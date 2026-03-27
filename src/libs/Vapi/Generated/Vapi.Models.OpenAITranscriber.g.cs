
#nullable enable

namespace Vapi
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OpenAITranscriber
    {
        /// <summary>
        /// This is the transcription provider that will be used.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.OpenAITranscriberProviderJsonConverter))]
        public global::Vapi.OpenAITranscriberProvider Provider { get; set; }

        /// <summary>
        /// This is the model that will be used for the transcription.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.OpenAITranscriberModelJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vapi.OpenAITranscriberModel Model { get; set; }

        /// <summary>
        /// This is the language that will be set for the transcription.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.OpenAITranscriberLanguageJsonConverter))]
        public global::Vapi.OpenAITranscriberLanguage? Language { get; set; }

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
        /// Initializes a new instance of the <see cref="OpenAITranscriber" /> class.
        /// </summary>
        /// <param name="provider">
        /// This is the transcription provider that will be used.
        /// </param>
        /// <param name="model">
        /// This is the model that will be used for the transcription.
        /// </param>
        /// <param name="language">
        /// This is the language that will be set for the transcription.
        /// </param>
        /// <param name="fallbackPlan">
        /// This is the plan for transcriber provider fallbacks in the event that the primary transcriber provider fails.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OpenAITranscriber(
            global::Vapi.OpenAITranscriberModel model,
            global::Vapi.OpenAITranscriberProvider provider,
            global::Vapi.OpenAITranscriberLanguage? language,
            global::Vapi.FallbackTranscriberPlan? fallbackPlan)
        {
            this.Model = model;
            this.Provider = provider;
            this.Language = language;
            this.FallbackPlan = fallbackPlan;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAITranscriber" /> class.
        /// </summary>
        public OpenAITranscriber()
        {
        }
    }
}