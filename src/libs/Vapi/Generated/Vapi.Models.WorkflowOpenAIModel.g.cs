
#nullable enable

namespace Vapi
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class WorkflowOpenAIModel
    {
        /// <summary>
        /// These are the messages used to customize the prompt used for structured output extraction.<br/>
        /// When provided, these messages replace the default prompts. For text extraction, message contents support LiquidJS templating with the following variables:<br/>
        /// - `{{transcript}}`, `{{messages}}`, or `{{messagesWithConfidence}}` to reference the conversation (one is required)<br/>
        /// - `{{structuredOutput.name}}`, `{{structuredOutput.description}}`, or `{{structuredOutput.schema}}` to reference the structured output definition (one is required)<br/>
        /// - `{{systemPrompt}}`, `{{callEndedReason}}`, `{{duration}}`, `{{startedAt}}`, `{{endedAt}}`, and any `assistantOverrides.variableValues`<br/>
        /// In structured outputs, `{{messages}}` includes conversation text and tool calls/results, but omits caller transcription-confidence fields. For text extraction, `{{messagesWithConfidence}}` includes the original message history with transcription confidence for outputs that explicitly need it. These variables also apply in structured-output schema descriptions. Audio-targeted (`messages-with-audio`) extraction ignores custom messages. Stored call artifacts and API messages retain their confidence data. `{{transcript}}` is the spoken text only, which uses significantly fewer tokens.<br/>
        /// If not provided, default system and user prompts are used.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("messages")]
        public global::System.Collections.Generic.IList<global::Vapi.OpenAIMessage>? Messages { get; set; }

        /// <summary>
        /// This is the provider of the model (`openai`).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.WorkflowOpenAIModelProviderJsonConverter))]
        public global::Vapi.WorkflowOpenAIModelProvider Provider { get; set; }

        /// <summary>
        /// This is the OpenAI model that will be used.<br/>
        /// When using Vapi OpenAI or your own Azure Credentials, you have the option to specify the region for the selected model. This shouldn't be specified unless you have a specific reason to do so. Vapi will automatically find the fastest region that make sense.<br/>
        /// This is helpful when you are required to comply with Data Residency rules. Learn more about Azure regions here https://azure.microsoft.com/en-us/explore/global-infrastructure/data-residency/.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.WorkflowOpenAIModelModelJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vapi.WorkflowOpenAIModelModel Model { get; set; }

        /// <summary>
        /// This is the reasoning effort for structured output extraction. It applies to the primary extraction attempt only; the GPT-4.1 and Gemini fallbacks run without it. Other features that use this model type ignore it.<br/>
        /// Only reasoning models accept it, and each accepts only the efforts OpenAI supports for it (for example `none` and `xhigh` on gpt-5.6, `minimal` on gpt-5). When unset, OpenAI's default effort for the model applies, except on GPT-6 models, which Vapi sends with `none`.<br/>
        /// Reasoning tokens are billed as output tokens.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reasoningEffort")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.WorkflowOpenAIModelReasoningEffortJsonConverter))]
        public global::Vapi.WorkflowOpenAIModelReasoningEffort? ReasoningEffort { get; set; }

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
        /// Initializes a new instance of the <see cref="WorkflowOpenAIModel" /> class.
        /// </summary>
        /// <param name="model">
        /// This is the OpenAI model that will be used.<br/>
        /// When using Vapi OpenAI or your own Azure Credentials, you have the option to specify the region for the selected model. This shouldn't be specified unless you have a specific reason to do so. Vapi will automatically find the fastest region that make sense.<br/>
        /// This is helpful when you are required to comply with Data Residency rules. Learn more about Azure regions here https://azure.microsoft.com/en-us/explore/global-infrastructure/data-residency/.
        /// </param>
        /// <param name="messages">
        /// These are the messages used to customize the prompt used for structured output extraction.<br/>
        /// When provided, these messages replace the default prompts. For text extraction, message contents support LiquidJS templating with the following variables:<br/>
        /// - `{{transcript}}`, `{{messages}}`, or `{{messagesWithConfidence}}` to reference the conversation (one is required)<br/>
        /// - `{{structuredOutput.name}}`, `{{structuredOutput.description}}`, or `{{structuredOutput.schema}}` to reference the structured output definition (one is required)<br/>
        /// - `{{systemPrompt}}`, `{{callEndedReason}}`, `{{duration}}`, `{{startedAt}}`, `{{endedAt}}`, and any `assistantOverrides.variableValues`<br/>
        /// In structured outputs, `{{messages}}` includes conversation text and tool calls/results, but omits caller transcription-confidence fields. For text extraction, `{{messagesWithConfidence}}` includes the original message history with transcription confidence for outputs that explicitly need it. These variables also apply in structured-output schema descriptions. Audio-targeted (`messages-with-audio`) extraction ignores custom messages. Stored call artifacts and API messages retain their confidence data. `{{transcript}}` is the spoken text only, which uses significantly fewer tokens.<br/>
        /// If not provided, default system and user prompts are used.
        /// </param>
        /// <param name="provider">
        /// This is the provider of the model (`openai`).
        /// </param>
        /// <param name="reasoningEffort">
        /// This is the reasoning effort for structured output extraction. It applies to the primary extraction attempt only; the GPT-4.1 and Gemini fallbacks run without it. Other features that use this model type ignore it.<br/>
        /// Only reasoning models accept it, and each accepts only the efforts OpenAI supports for it (for example `none` and `xhigh` on gpt-5.6, `minimal` on gpt-5). When unset, OpenAI's default effort for the model applies, except on GPT-6 models, which Vapi sends with `none`.<br/>
        /// Reasoning tokens are billed as output tokens.
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
        public WorkflowOpenAIModel(
            global::Vapi.WorkflowOpenAIModelModel model,
            global::System.Collections.Generic.IList<global::Vapi.OpenAIMessage>? messages,
            global::Vapi.WorkflowOpenAIModelProvider provider,
            global::Vapi.WorkflowOpenAIModelReasoningEffort? reasoningEffort,
            double? temperature,
            double? maxTokens)
        {
            this.Messages = messages;
            this.Provider = provider;
            this.Model = model;
            this.ReasoningEffort = reasoningEffort;
            this.Temperature = temperature;
            this.MaxTokens = maxTokens;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowOpenAIModel" /> class.
        /// </summary>
        public WorkflowOpenAIModel()
        {
        }

    }
}