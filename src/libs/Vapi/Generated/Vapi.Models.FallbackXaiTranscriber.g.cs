
#nullable enable

namespace Vapi
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FallbackXaiTranscriber
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.FallbackXaiTranscriberProviderJsonConverter))]
        public global::Vapi.FallbackXaiTranscriberProvider Provider { get; set; }

        /// <summary>
        /// The xAI speech-to-text model to use. xAI currently exposes a single STT model — placeholder for future model selection.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.FallbackXaiTranscriberModelJsonConverter))]
        public global::Vapi.FallbackXaiTranscriberModel? Model { get; set; }

        /// <summary>
        /// Single language for transcription as an ISO 639-1 code (e.g., `en`, `es`). Defaults to `en` if not set. xAI auto-detects when omitted via the API but Vapi defaults to English for deterministic behavior.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.FallbackXaiTranscriberLanguageJsonConverter))]
        public global::Vapi.FallbackXaiTranscriberLanguage? Language { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FallbackXaiTranscriber" /> class.
        /// </summary>
        /// <param name="provider"></param>
        /// <param name="model">
        /// The xAI speech-to-text model to use. xAI currently exposes a single STT model — placeholder for future model selection.
        /// </param>
        /// <param name="language">
        /// Single language for transcription as an ISO 639-1 code (e.g., `en`, `es`). Defaults to `en` if not set. xAI auto-detects when omitted via the API but Vapi defaults to English for deterministic behavior.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FallbackXaiTranscriber(
            global::Vapi.FallbackXaiTranscriberProvider provider,
            global::Vapi.FallbackXaiTranscriberModel? model,
            global::Vapi.FallbackXaiTranscriberLanguage? language)
        {
            this.Provider = provider;
            this.Model = model;
            this.Language = language;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FallbackXaiTranscriber" /> class.
        /// </summary>
        public FallbackXaiTranscriber()
        {
        }

    }
}