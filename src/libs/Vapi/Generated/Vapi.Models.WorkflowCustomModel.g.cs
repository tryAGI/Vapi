
#nullable enable

namespace Vapi
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WorkflowCustomModel
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
        /// This is the provider of the model (`custom-llm`).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.WorkflowCustomModelProviderJsonConverter))]
        public global::Vapi.WorkflowCustomModelProvider Provider { get; set; }

        /// <summary>
        /// This determines whether metadata is sent in requests to the custom provider.<br/>
        /// - `off` will not send any metadata. payload will look like `{ messages }`<br/>
        /// - `variable` will send `assistant.metadata` as a variable on the payload. payload will look like `{ messages, metadata }`<br/>
        /// - `destructured` will send `assistant.metadata` fields directly on the payload. payload will look like `{ messages, ...metadata }`<br/>
        /// Further, `variable` and `destructured` will send `call`, `phoneNumber`, and `customer` objects in the payload.<br/>
        /// Default is `variable`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadataSendMode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.WorkflowCustomModelMetadataSendModeJsonConverter))]
        public global::Vapi.WorkflowCustomModelMetadataSendMode? MetadataSendMode { get; set; }

        /// <summary>
        /// These is the URL we'll use for the OpenAI client's `baseURL`. Ex. https://openrouter.ai/api/v1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// These are the headers we'll use for the OpenAI client's `headers`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("headers")]
        public object? Headers { get; set; }

        /// <summary>
        /// This sets the timeout for the connection to the custom provider without needing to stream any tokens back. Default is 20 seconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timeoutSeconds")]
        public double? TimeoutSeconds { get; set; }

        /// <summary>
        /// This is the name of the model. Ex. cognitivecomputations/dolphin-mixtral-8x7b
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

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
        /// Initializes a new instance of the <see cref="WorkflowCustomModel" /> class.
        /// </summary>
        /// <param name="url">
        /// These is the URL we'll use for the OpenAI client's `baseURL`. Ex. https://openrouter.ai/api/v1
        /// </param>
        /// <param name="model">
        /// This is the name of the model. Ex. cognitivecomputations/dolphin-mixtral-8x7b
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
        /// This is the provider of the model (`custom-llm`).
        /// </param>
        /// <param name="metadataSendMode">
        /// This determines whether metadata is sent in requests to the custom provider.<br/>
        /// - `off` will not send any metadata. payload will look like `{ messages }`<br/>
        /// - `variable` will send `assistant.metadata` as a variable on the payload. payload will look like `{ messages, metadata }`<br/>
        /// - `destructured` will send `assistant.metadata` fields directly on the payload. payload will look like `{ messages, ...metadata }`<br/>
        /// Further, `variable` and `destructured` will send `call`, `phoneNumber`, and `customer` objects in the payload.<br/>
        /// Default is `variable`.
        /// </param>
        /// <param name="headers">
        /// These are the headers we'll use for the OpenAI client's `headers`.
        /// </param>
        /// <param name="timeoutSeconds">
        /// This sets the timeout for the connection to the custom provider without needing to stream any tokens back. Default is 20 seconds.
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
        public WorkflowCustomModel(
            string url,
            string model,
            global::System.Collections.Generic.IList<global::Vapi.OpenAIMessage>? messages,
            global::Vapi.WorkflowCustomModelProvider provider,
            global::Vapi.WorkflowCustomModelMetadataSendMode? metadataSendMode,
            object? headers,
            double? timeoutSeconds,
            double? temperature,
            double? maxTokens)
        {
            this.Messages = messages;
            this.Provider = provider;
            this.MetadataSendMode = metadataSendMode;
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.Headers = headers;
            this.TimeoutSeconds = timeoutSeconds;
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Temperature = temperature;
            this.MaxTokens = maxTokens;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowCustomModel" /> class.
        /// </summary>
        public WorkflowCustomModel()
        {
        }

    }
}