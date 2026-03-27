
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vapi
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class InflectionAIModel
    {
        /// <summary>
        /// This is the starting state for the conversation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("messages")]
        public global::System.Collections.Generic.IList<global::Vapi.OpenAIMessage>? Messages { get; set; }

        /// <summary>
        /// These are the tools that the assistant can use during the call. To use existing tools, use `toolIds`.<br/>
        /// Both `tools` and `toolIds` can be used together.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tools")]
        public global::System.Collections.Generic.IList<global::Vapi.OneOf<global::Vapi.CreateApiRequestToolDTO, global::Vapi.CreateBashToolDTO, global::Vapi.CreateCodeToolDTO, global::Vapi.CreateComputerToolDTO, global::Vapi.CreateDtmfToolDTO, global::Vapi.CreateEndCallToolDTO, global::Vapi.CreateFunctionToolDTO, global::Vapi.CreateGoHighLevelCalendarAvailabilityToolDTO, global::Vapi.CreateGoHighLevelCalendarEventCreateToolDTO, global::Vapi.CreateGoHighLevelContactCreateToolDTO, global::Vapi.CreateGoHighLevelContactGetToolDTO, global::Vapi.CreateGoogleCalendarCheckAvailabilityToolDTO, global::Vapi.CreateGoogleCalendarCreateEventToolDTO, global::Vapi.CreateGoogleSheetsRowAppendToolDTO, global::Vapi.CreateHandoffToolDTO, global::Vapi.CreateMcpToolDTO, global::Vapi.CreateQueryToolDTO, global::Vapi.CreateSlackSendMessageToolDTO, global::Vapi.CreateSmsToolDTO, global::Vapi.CreateTextEditorToolDTO, global::Vapi.CreateTransferCallToolDTO, global::Vapi.CreateSipRequestToolDTO, global::Vapi.CreateVoicemailToolDTO>>? Tools { get; set; }

        /// <summary>
        /// These are the tools that the assistant can use during the call. To use transient tools, use `tools`.<br/>
        /// Both `tools` and `toolIds` can be used together.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("toolIds")]
        public global::System.Collections.Generic.IList<string>? ToolIds { get; set; }

        /// <summary>
        /// These are the options for the knowledge base.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("knowledgeBase")]
        public global::Vapi.CreateCustomKnowledgeBaseDTO? KnowledgeBase { get; set; }

        /// <summary>
        /// This is the name of the model. Ex. cognitivecomputations/dolphin-mixtral-8x7b
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.InflectionAIModelModelJsonConverter))]
        public global::Vapi.InflectionAIModelModel Model { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.InflectionAIModelProviderJsonConverter))]
        public global::Vapi.InflectionAIModelProvider Provider { get; set; }

        /// <summary>
        /// This is the temperature that will be used for calls. Default is 0 to leverage caching for lower latency.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("temperature")]
        public double? Temperature { get; set; }

        /// <summary>
        /// This is the max number of tokens that the assistant will be allowed to generate in each turn of the conversation. Default is 250.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maxTokens")]
        public double? MaxTokens { get; set; }

        /// <summary>
        /// This determines whether we detect user's emotion while they speak and send it as an additional info to model.<br/>
        /// Default `false` because the model is usually are good at understanding the user's emotion from text.<br/>
        /// @default false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("emotionRecognitionEnabled")]
        public bool? EmotionRecognitionEnabled { get; set; }

        /// <summary>
        /// This sets how many turns at the start of the conversation to use a smaller, faster model from the same provider before switching to the primary model. Example, gpt-3.5-turbo if provider is openai.<br/>
        /// Default is 0.<br/>
        /// @default 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("numFastTurns")]
        public double? NumFastTurns { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InflectionAIModel" /> class.
        /// </summary>
        /// <param name="messages">
        /// This is the starting state for the conversation.
        /// </param>
        /// <param name="tools">
        /// These are the tools that the assistant can use during the call. To use existing tools, use `toolIds`.<br/>
        /// Both `tools` and `toolIds` can be used together.
        /// </param>
        /// <param name="toolIds">
        /// These are the tools that the assistant can use during the call. To use transient tools, use `tools`.<br/>
        /// Both `tools` and `toolIds` can be used together.
        /// </param>
        /// <param name="knowledgeBase">
        /// These are the options for the knowledge base.
        /// </param>
        /// <param name="model">
        /// This is the name of the model. Ex. cognitivecomputations/dolphin-mixtral-8x7b
        /// </param>
        /// <param name="provider"></param>
        /// <param name="temperature">
        /// This is the temperature that will be used for calls. Default is 0 to leverage caching for lower latency.
        /// </param>
        /// <param name="maxTokens">
        /// This is the max number of tokens that the assistant will be allowed to generate in each turn of the conversation. Default is 250.
        /// </param>
        /// <param name="emotionRecognitionEnabled">
        /// This determines whether we detect user's emotion while they speak and send it as an additional info to model.<br/>
        /// Default `false` because the model is usually are good at understanding the user's emotion from text.<br/>
        /// @default false
        /// </param>
        /// <param name="numFastTurns">
        /// This sets how many turns at the start of the conversation to use a smaller, faster model from the same provider before switching to the primary model. Example, gpt-3.5-turbo if provider is openai.<br/>
        /// Default is 0.<br/>
        /// @default 0
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InflectionAIModel(
            global::System.Collections.Generic.IList<global::Vapi.OpenAIMessage>? messages,
            global::System.Collections.Generic.IList<global::Vapi.OneOf<global::Vapi.CreateApiRequestToolDTO, global::Vapi.CreateBashToolDTO, global::Vapi.CreateCodeToolDTO, global::Vapi.CreateComputerToolDTO, global::Vapi.CreateDtmfToolDTO, global::Vapi.CreateEndCallToolDTO, global::Vapi.CreateFunctionToolDTO, global::Vapi.CreateGoHighLevelCalendarAvailabilityToolDTO, global::Vapi.CreateGoHighLevelCalendarEventCreateToolDTO, global::Vapi.CreateGoHighLevelContactCreateToolDTO, global::Vapi.CreateGoHighLevelContactGetToolDTO, global::Vapi.CreateGoogleCalendarCheckAvailabilityToolDTO, global::Vapi.CreateGoogleCalendarCreateEventToolDTO, global::Vapi.CreateGoogleSheetsRowAppendToolDTO, global::Vapi.CreateHandoffToolDTO, global::Vapi.CreateMcpToolDTO, global::Vapi.CreateQueryToolDTO, global::Vapi.CreateSlackSendMessageToolDTO, global::Vapi.CreateSmsToolDTO, global::Vapi.CreateTextEditorToolDTO, global::Vapi.CreateTransferCallToolDTO, global::Vapi.CreateSipRequestToolDTO, global::Vapi.CreateVoicemailToolDTO>>? tools,
            global::System.Collections.Generic.IList<string>? toolIds,
            global::Vapi.CreateCustomKnowledgeBaseDTO? knowledgeBase,
            global::Vapi.InflectionAIModelModel model,
            global::Vapi.InflectionAIModelProvider provider,
            double? temperature,
            double? maxTokens,
            bool? emotionRecognitionEnabled,
            double? numFastTurns)
        {
            this.Messages = messages;
            this.Tools = tools;
            this.ToolIds = toolIds;
            this.KnowledgeBase = knowledgeBase;
            this.Model = model;
            this.Provider = provider;
            this.Temperature = temperature;
            this.MaxTokens = maxTokens;
            this.EmotionRecognitionEnabled = emotionRecognitionEnabled;
            this.NumFastTurns = numFastTurns;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InflectionAIModel" /> class.
        /// </summary>
        public InflectionAIModel()
        {
        }
    }
}