
#nullable enable

namespace Vapi
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class OpenAIReasoner
    {
        /// <summary>
        /// The reasoner uses OpenAI. Omit to use OpenAI.<br/>
        /// Default Value: openai
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.OpenAIReasonerProviderJsonConverter))]
        public global::Vapi.OpenAIReasonerProvider? Provider { get; set; }

        /// <summary>
        /// The delegated reasoning model. Omit to use GPT-5.6 Terra.<br/>
        /// Default Value: gpt-5.6-terra
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.OpenAIReasonerModelJsonConverter))]
        public global::Vapi.OpenAIReasonerModel? Model { get; set; }

        /// <summary>
        /// Higher effort can increase response time. Omit to use low.<br/>
        /// Default Value: low
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reasoningEffort")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.OpenAIReasonerReasoningEffortJsonConverter))]
        public global::Vapi.OpenAIReasonerReasoningEffort? ReasoningEffort { get; set; }

        /// <summary>
        /// Complete reasoner instructions. An explicit empty string is preserved.<br/>
        /// Omit to use Vapi's default reasoner instructions. No behavioral instructions<br/>
        /// are appended to a custom prompt.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instructions")]
        public string? Instructions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAIReasoner" /> class.
        /// </summary>
        /// <param name="provider">
        /// The reasoner uses OpenAI. Omit to use OpenAI.<br/>
        /// Default Value: openai
        /// </param>
        /// <param name="model">
        /// The delegated reasoning model. Omit to use GPT-5.6 Terra.<br/>
        /// Default Value: gpt-5.6-terra
        /// </param>
        /// <param name="reasoningEffort">
        /// Higher effort can increase response time. Omit to use low.<br/>
        /// Default Value: low
        /// </param>
        /// <param name="instructions">
        /// Complete reasoner instructions. An explicit empty string is preserved.<br/>
        /// Omit to use Vapi's default reasoner instructions. No behavioral instructions<br/>
        /// are appended to a custom prompt.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OpenAIReasoner(
            global::Vapi.OpenAIReasonerProvider? provider,
            global::Vapi.OpenAIReasonerModel? model,
            global::Vapi.OpenAIReasonerReasoningEffort? reasoningEffort,
            string? instructions)
        {
            this.Provider = provider;
            this.Model = model;
            this.ReasoningEffort = reasoningEffort;
            this.Instructions = instructions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAIReasoner" /> class.
        /// </summary>
        public OpenAIReasoner()
        {
        }

    }
}