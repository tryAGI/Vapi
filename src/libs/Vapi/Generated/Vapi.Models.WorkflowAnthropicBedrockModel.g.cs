
#nullable enable

namespace Vapi
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class WorkflowAnthropicBedrockModel
    {
        /// <summary>
        /// These are the messages used to customize the prompt used for structured output extraction.<br/>
        /// When provided, these messages replace the default prompts. Message contents support LiquidJS templating with the following variables:<br/>
        /// - `{{transcript}}` or `{{messages}}` to reference the conversation (one is required)<br/>
        /// - `{{structuredOutput.name}}`, `{{structuredOutput.description}}`, or `{{structuredOutput.schema}}` to reference the structured output definition (one is required)<br/>
        /// - `{{systemPrompt}}`, `{{callEndedReason}}`, `{{duration}}`, `{{startedAt}}`, `{{endedAt}}`, and any `assistantOverrides.variableValues`<br/>
        /// `{{messages}}` is the full message history including tool calls; `{{transcript}}` is the spoken text only, which uses significantly fewer tokens.<br/>
        /// If not provided, default system and user prompts are used.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("messages")]
        public global::System.Collections.Generic.IList<global::Vapi.OpenAIMessage>? Messages { get; set; }

        /// <summary>
        /// This is the provider of the model (`anthropic-bedrock`).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.WorkflowAnthropicBedrockModelProviderJsonConverter))]
        public global::Vapi.WorkflowAnthropicBedrockModelProvider Provider { get; set; }

        /// <summary>
        /// This is the specific model that will be used.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.WorkflowAnthropicBedrockModelModelJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vapi.WorkflowAnthropicBedrockModelModel Model { get; set; }

        /// <summary>
        /// This is the optional configuration for Anthropic's thinking feature.<br/>
        /// - If provided, `maxTokens` must be greater than `thinking.budgetTokens`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("thinking")]
        public global::Vapi.AnthropicThinkingConfig? Thinking { get; set; }

        /// <summary>
        /// This is the temperature of the model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("temperature")]
        public double? Temperature { get; set; }

        /// <summary>
        /// This is the max tokens of the model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maxTokens")]
        public double? MaxTokens { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowAnthropicBedrockModel" /> class.
        /// </summary>
        /// <param name="model">
        /// This is the specific model that will be used.
        /// </param>
        /// <param name="messages">
        /// These are the messages used to customize the prompt used for structured output extraction.<br/>
        /// When provided, these messages replace the default prompts. Message contents support LiquidJS templating with the following variables:<br/>
        /// - `{{transcript}}` or `{{messages}}` to reference the conversation (one is required)<br/>
        /// - `{{structuredOutput.name}}`, `{{structuredOutput.description}}`, or `{{structuredOutput.schema}}` to reference the structured output definition (one is required)<br/>
        /// - `{{systemPrompt}}`, `{{callEndedReason}}`, `{{duration}}`, `{{startedAt}}`, `{{endedAt}}`, and any `assistantOverrides.variableValues`<br/>
        /// `{{messages}}` is the full message history including tool calls; `{{transcript}}` is the spoken text only, which uses significantly fewer tokens.<br/>
        /// If not provided, default system and user prompts are used.
        /// </param>
        /// <param name="provider">
        /// This is the provider of the model (`anthropic-bedrock`).
        /// </param>
        /// <param name="thinking">
        /// This is the optional configuration for Anthropic's thinking feature.<br/>
        /// - If provided, `maxTokens` must be greater than `thinking.budgetTokens`.
        /// </param>
        /// <param name="temperature">
        /// This is the temperature of the model.
        /// </param>
        /// <param name="maxTokens">
        /// This is the max tokens of the model.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WorkflowAnthropicBedrockModel(
            global::Vapi.WorkflowAnthropicBedrockModelModel model,
            global::System.Collections.Generic.IList<global::Vapi.OpenAIMessage>? messages,
            global::Vapi.WorkflowAnthropicBedrockModelProvider provider,
            global::Vapi.AnthropicThinkingConfig? thinking,
            double? temperature,
            double? maxTokens)
        {
            this.Messages = messages;
            this.Provider = provider;
            this.Model = model;
            this.Thinking = thinking;
            this.Temperature = temperature;
            this.MaxTokens = maxTokens;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowAnthropicBedrockModel" /> class.
        /// </summary>
        public WorkflowAnthropicBedrockModel()
        {
        }

    }
}