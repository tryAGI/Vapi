
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
        /// This is the model that will be used for the transcription.<br/>
        /// Digit formatting can differ by model: `gpt-transcribe` may write spoken digit strings as words (for example, "four seven two"), where `gpt-4o-transcribe` and `gpt-4o-mini-transcribe` may write them as digits ("472"). Do not rely on either format.
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
        /// These are words and phrases the model should recognize, such as names, brands, and product terms.<br/>
        /// Supported only by `gpt-transcribe`. Each keyword is one line and must not contain `&lt;` or `&gt;`. Maximum 16,384 keywords.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("keywords")]
        public global::System.Collections.Generic.IList<string>? Keywords { get; set; }

        /// <summary>
        /// This is free-text context for the transcription, such as the topic of the call or the expected vocabulary.<br/>
        /// Maximum length: 8,192 characters for `gpt-transcribe`, and 1,024 characters for `gpt-4o-transcribe` and `gpt-4o-mini-transcribe`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        public string? Prompt { get; set; }

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
        /// <param name="model">
        /// This is the model that will be used for the transcription.<br/>
        /// Digit formatting can differ by model: `gpt-transcribe` may write spoken digit strings as words (for example, "four seven two"), where `gpt-4o-transcribe` and `gpt-4o-mini-transcribe` may write them as digits ("472"). Do not rely on either format.
        /// </param>
        /// <param name="provider">
        /// This is the transcription provider that will be used.
        /// </param>
        /// <param name="language">
        /// This is the language that will be set for the transcription.
        /// </param>
        /// <param name="keywords">
        /// These are words and phrases the model should recognize, such as names, brands, and product terms.<br/>
        /// Supported only by `gpt-transcribe`. Each keyword is one line and must not contain `&lt;` or `&gt;`. Maximum 16,384 keywords.
        /// </param>
        /// <param name="prompt">
        /// This is free-text context for the transcription, such as the topic of the call or the expected vocabulary.<br/>
        /// Maximum length: 8,192 characters for `gpt-transcribe`, and 1,024 characters for `gpt-4o-transcribe` and `gpt-4o-mini-transcribe`.
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
            global::System.Collections.Generic.IList<string>? keywords,
            string? prompt,
            global::Vapi.FallbackTranscriberPlan? fallbackPlan)
        {
            this.Provider = provider;
            this.Model = model;
            this.Language = language;
            this.Keywords = keywords;
            this.Prompt = prompt;
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