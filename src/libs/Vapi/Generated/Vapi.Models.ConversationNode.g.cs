
#nullable enable

namespace Vapi
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ConversationNode
    {
        /// <summary>
        /// This is the Conversation node. This can be used to start a conversation with the customer.<br/>
        /// The flow is:<br/>
        /// - Workflow starts the conversation node<br/>
        /// - Model is active with the `prompt` and global context.<br/>
        /// - Model will call a tool to exit this node.<br/>
        /// - Workflow will extract variables from the conversation.<br/>
        /// - Workflow continues.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.ConversationNodeTypeJsonConverter))]
        public global::Vapi.ConversationNodeType Type { get; set; }

        /// <summary>
        /// This is the model for the node.<br/>
        /// This overrides `workflow.model`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.WorkflowOpenAIModel, global::Vapi.WorkflowAnthropicModel, global::Vapi.WorkflowAnthropicBedrockModel, global::Vapi.WorkflowGoogleModel, global::Vapi.WorkflowCustomModel>))]
        public global::Vapi.OneOf<global::Vapi.WorkflowOpenAIModel, global::Vapi.WorkflowAnthropicModel, global::Vapi.WorkflowAnthropicBedrockModel, global::Vapi.WorkflowGoogleModel, global::Vapi.WorkflowCustomModel>? Model { get; set; }

        /// <summary>
        /// This is the transcriber for the node.<br/>
        /// This overrides `workflow.transcriber`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transcriber")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.AssemblyAITranscriber, global::Vapi.AzureSpeechTranscriber, global::Vapi.CustomTranscriber, global::Vapi.DeepgramTranscriber, global::Vapi.ElevenLabsTranscriber, global::Vapi.GladiaTranscriber, global::Vapi.GoogleTranscriber, global::Vapi.SpeechmaticsTranscriber, global::Vapi.TalkscriberTranscriber, global::Vapi.OpenAITranscriber, global::Vapi.CartesiaTranscriber, global::Vapi.SonioxTranscriber>))]
        public global::Vapi.OneOf<global::Vapi.AssemblyAITranscriber, global::Vapi.AzureSpeechTranscriber, global::Vapi.CustomTranscriber, global::Vapi.DeepgramTranscriber, global::Vapi.ElevenLabsTranscriber, global::Vapi.GladiaTranscriber, global::Vapi.GoogleTranscriber, global::Vapi.SpeechmaticsTranscriber, global::Vapi.TalkscriberTranscriber, global::Vapi.OpenAITranscriber, global::Vapi.CartesiaTranscriber, global::Vapi.SonioxTranscriber>? Transcriber { get; set; }

        /// <summary>
        /// This is the voice for the node.<br/>
        /// This overrides `workflow.voice`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.AzureVoice, global::Vapi.CartesiaVoice, global::Vapi.CustomVoice, global::Vapi.DeepgramVoice, global::Vapi.ElevenLabsVoice, global::Vapi.HumeVoice, global::Vapi.LMNTVoice, global::Vapi.NeuphonicVoice, global::Vapi.OpenAIVoice, global::Vapi.PlayHTVoice, global::Vapi.WellSaidVoice, global::Vapi.RimeAIVoice, global::Vapi.SmallestAIVoice, global::Vapi.TavusVoice, global::Vapi.VapiVoice, global::Vapi.SesameVoice, global::Vapi.InworldVoice, global::Vapi.MinimaxVoice>))]
        public global::Vapi.OneOf<global::Vapi.AzureVoice, global::Vapi.CartesiaVoice, global::Vapi.CustomVoice, global::Vapi.DeepgramVoice, global::Vapi.ElevenLabsVoice, global::Vapi.HumeVoice, global::Vapi.LMNTVoice, global::Vapi.NeuphonicVoice, global::Vapi.OpenAIVoice, global::Vapi.PlayHTVoice, global::Vapi.WellSaidVoice, global::Vapi.RimeAIVoice, global::Vapi.SmallestAIVoice, global::Vapi.TavusVoice, global::Vapi.VapiVoice, global::Vapi.SesameVoice, global::Vapi.InworldVoice, global::Vapi.MinimaxVoice>? Voice { get; set; }

        /// <summary>
        /// These are the tools that the conversation node can use during the call. To use existing tools, use `toolIds`.<br/>
        /// Both `tools` and `toolIds` can be used together.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tools")]
        public global::System.Collections.Generic.IList<global::Vapi.OneOf<global::Vapi.CreateApiRequestToolDTO, global::Vapi.CreateBashToolDTO, global::Vapi.CreateCodeToolDTO, global::Vapi.CreateComputerToolDTO, global::Vapi.CreateDtmfToolDTO, global::Vapi.CreateEndCallToolDTO, global::Vapi.CreateFunctionToolDTO, global::Vapi.CreateGoHighLevelCalendarAvailabilityToolDTO, global::Vapi.CreateGoHighLevelCalendarEventCreateToolDTO, global::Vapi.CreateGoHighLevelContactCreateToolDTO, global::Vapi.CreateGoHighLevelContactGetToolDTO, global::Vapi.CreateGoogleCalendarCheckAvailabilityToolDTO, global::Vapi.CreateGoogleCalendarCreateEventToolDTO, global::Vapi.CreateGoogleSheetsRowAppendToolDTO, global::Vapi.CreateHandoffToolDTO, global::Vapi.CreateMcpToolDTO, global::Vapi.CreateQueryToolDTO, global::Vapi.CreateSlackSendMessageToolDTO, global::Vapi.CreateSmsToolDTO, global::Vapi.CreateTextEditorToolDTO, global::Vapi.CreateTransferCallToolDTO, global::Vapi.CreateSipRequestToolDTO, global::Vapi.CreateVoicemailToolDTO>>? Tools { get; set; }

        /// <summary>
        /// These are the tools that the conversation node can use during the call. To use transient tools, use `tools`.<br/>
        /// Both `tools` and `toolIds` can be used together.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("toolIds")]
        public global::System.Collections.Generic.IList<string>? ToolIds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        public string? Prompt { get; set; }

        /// <summary>
        /// This is the plan for the global node.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("globalNodePlan")]
        public global::Vapi.GlobalNodePlan? GlobalNodePlan { get; set; }

        /// <summary>
        /// This is the plan that controls the variable extraction from the user's responses.<br/>
        /// Usage:<br/>
        /// Use `schema` to specify what you want to extract from the user's responses.<br/>
        /// ```json<br/>
        /// {<br/>
        ///   "schema": {<br/>
        ///     "type": "object",<br/>
        ///     "properties": {<br/>
        ///       "user": {<br/>
        ///         "type": "object",<br/>
        ///         "properties": {<br/>
        ///           "name": {<br/>
        ///             "type": "string"<br/>
        ///           },<br/>
        ///           "age": {<br/>
        ///             "type": "number"<br/>
        ///           }<br/>
        ///         }<br/>
        ///       }<br/>
        ///     }<br/>
        ///   }<br/>
        /// }<br/>
        /// ```<br/>
        /// This will be extracted as `{{ user.name }}` and `{{ user.age }}` respectively.<br/>
        /// (Optional) Use `aliases` to create new variables.<br/>
        /// ```json<br/>
        /// {<br/>
        ///   "aliases": [<br/>
        ///     {<br/>
        ///       "key": "userAge",<br/>
        ///       "value": "{{user.age}}"<br/>
        ///     },<br/>
        ///     {<br/>
        ///       "key": "userName",<br/>
        ///       "value": "{{user.name}}"<br/>
        ///     }<br/>
        ///   ]<br/>
        /// }<br/>
        /// ```<br/>
        /// This will be extracted as `{{ userAge }}` and `{{ userName }}` respectively.<br/>
        /// Note: The `schema` field is required for Conversation nodes if you want to extract variables from the user's responses. `aliases` is just a convenience.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("variableExtractionPlan")]
        public global::Vapi.VariableExtractionPlan? VariableExtractionPlan { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// This is whether or not the node is the start of the workflow.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isStart")]
        public bool? IsStart { get; set; }

        /// <summary>
        /// This is for metadata you want to store on the task.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationNode" /> class.
        /// </summary>
        /// <param name="type">
        /// This is the Conversation node. This can be used to start a conversation with the customer.<br/>
        /// The flow is:<br/>
        /// - Workflow starts the conversation node<br/>
        /// - Model is active with the `prompt` and global context.<br/>
        /// - Model will call a tool to exit this node.<br/>
        /// - Workflow will extract variables from the conversation.<br/>
        /// - Workflow continues.
        /// </param>
        /// <param name="model">
        /// This is the model for the node.<br/>
        /// This overrides `workflow.model`.
        /// </param>
        /// <param name="transcriber">
        /// This is the transcriber for the node.<br/>
        /// This overrides `workflow.transcriber`.
        /// </param>
        /// <param name="voice">
        /// This is the voice for the node.<br/>
        /// This overrides `workflow.voice`.
        /// </param>
        /// <param name="tools">
        /// These are the tools that the conversation node can use during the call. To use existing tools, use `toolIds`.<br/>
        /// Both `tools` and `toolIds` can be used together.
        /// </param>
        /// <param name="toolIds">
        /// These are the tools that the conversation node can use during the call. To use transient tools, use `tools`.<br/>
        /// Both `tools` and `toolIds` can be used together.
        /// </param>
        /// <param name="prompt"></param>
        /// <param name="globalNodePlan">
        /// This is the plan for the global node.
        /// </param>
        /// <param name="variableExtractionPlan">
        /// This is the plan that controls the variable extraction from the user's responses.<br/>
        /// Usage:<br/>
        /// Use `schema` to specify what you want to extract from the user's responses.<br/>
        /// ```json<br/>
        /// {<br/>
        ///   "schema": {<br/>
        ///     "type": "object",<br/>
        ///     "properties": {<br/>
        ///       "user": {<br/>
        ///         "type": "object",<br/>
        ///         "properties": {<br/>
        ///           "name": {<br/>
        ///             "type": "string"<br/>
        ///           },<br/>
        ///           "age": {<br/>
        ///             "type": "number"<br/>
        ///           }<br/>
        ///         }<br/>
        ///       }<br/>
        ///     }<br/>
        ///   }<br/>
        /// }<br/>
        /// ```<br/>
        /// This will be extracted as `{{ user.name }}` and `{{ user.age }}` respectively.<br/>
        /// (Optional) Use `aliases` to create new variables.<br/>
        /// ```json<br/>
        /// {<br/>
        ///   "aliases": [<br/>
        ///     {<br/>
        ///       "key": "userAge",<br/>
        ///       "value": "{{user.age}}"<br/>
        ///     },<br/>
        ///     {<br/>
        ///       "key": "userName",<br/>
        ///       "value": "{{user.name}}"<br/>
        ///     }<br/>
        ///   ]<br/>
        /// }<br/>
        /// ```<br/>
        /// This will be extracted as `{{ userAge }}` and `{{ userName }}` respectively.<br/>
        /// Note: The `schema` field is required for Conversation nodes if you want to extract variables from the user's responses. `aliases` is just a convenience.
        /// </param>
        /// <param name="name"></param>
        /// <param name="isStart">
        /// This is whether or not the node is the start of the workflow.
        /// </param>
        /// <param name="metadata">
        /// This is for metadata you want to store on the task.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConversationNode(
            string name,
            global::Vapi.ConversationNodeType type,
            global::Vapi.OneOf<global::Vapi.WorkflowOpenAIModel, global::Vapi.WorkflowAnthropicModel, global::Vapi.WorkflowAnthropicBedrockModel, global::Vapi.WorkflowGoogleModel, global::Vapi.WorkflowCustomModel>? model,
            global::Vapi.OneOf<global::Vapi.AssemblyAITranscriber, global::Vapi.AzureSpeechTranscriber, global::Vapi.CustomTranscriber, global::Vapi.DeepgramTranscriber, global::Vapi.ElevenLabsTranscriber, global::Vapi.GladiaTranscriber, global::Vapi.GoogleTranscriber, global::Vapi.SpeechmaticsTranscriber, global::Vapi.TalkscriberTranscriber, global::Vapi.OpenAITranscriber, global::Vapi.CartesiaTranscriber, global::Vapi.SonioxTranscriber>? transcriber,
            global::Vapi.OneOf<global::Vapi.AzureVoice, global::Vapi.CartesiaVoice, global::Vapi.CustomVoice, global::Vapi.DeepgramVoice, global::Vapi.ElevenLabsVoice, global::Vapi.HumeVoice, global::Vapi.LMNTVoice, global::Vapi.NeuphonicVoice, global::Vapi.OpenAIVoice, global::Vapi.PlayHTVoice, global::Vapi.WellSaidVoice, global::Vapi.RimeAIVoice, global::Vapi.SmallestAIVoice, global::Vapi.TavusVoice, global::Vapi.VapiVoice, global::Vapi.SesameVoice, global::Vapi.InworldVoice, global::Vapi.MinimaxVoice>? voice,
            global::System.Collections.Generic.IList<global::Vapi.OneOf<global::Vapi.CreateApiRequestToolDTO, global::Vapi.CreateBashToolDTO, global::Vapi.CreateCodeToolDTO, global::Vapi.CreateComputerToolDTO, global::Vapi.CreateDtmfToolDTO, global::Vapi.CreateEndCallToolDTO, global::Vapi.CreateFunctionToolDTO, global::Vapi.CreateGoHighLevelCalendarAvailabilityToolDTO, global::Vapi.CreateGoHighLevelCalendarEventCreateToolDTO, global::Vapi.CreateGoHighLevelContactCreateToolDTO, global::Vapi.CreateGoHighLevelContactGetToolDTO, global::Vapi.CreateGoogleCalendarCheckAvailabilityToolDTO, global::Vapi.CreateGoogleCalendarCreateEventToolDTO, global::Vapi.CreateGoogleSheetsRowAppendToolDTO, global::Vapi.CreateHandoffToolDTO, global::Vapi.CreateMcpToolDTO, global::Vapi.CreateQueryToolDTO, global::Vapi.CreateSlackSendMessageToolDTO, global::Vapi.CreateSmsToolDTO, global::Vapi.CreateTextEditorToolDTO, global::Vapi.CreateTransferCallToolDTO, global::Vapi.CreateSipRequestToolDTO, global::Vapi.CreateVoicemailToolDTO>>? tools,
            global::System.Collections.Generic.IList<string>? toolIds,
            string? prompt,
            global::Vapi.GlobalNodePlan? globalNodePlan,
            global::Vapi.VariableExtractionPlan? variableExtractionPlan,
            bool? isStart,
            object? metadata)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Type = type;
            this.Model = model;
            this.Transcriber = transcriber;
            this.Voice = voice;
            this.Tools = tools;
            this.ToolIds = toolIds;
            this.Prompt = prompt;
            this.GlobalNodePlan = globalNodePlan;
            this.VariableExtractionPlan = variableExtractionPlan;
            this.IsStart = isStart;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationNode" /> class.
        /// </summary>
        public ConversationNode()
        {
        }
    }
}