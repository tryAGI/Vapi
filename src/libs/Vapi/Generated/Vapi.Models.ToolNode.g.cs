
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vapi
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ToolNode
    {
        /// <summary>
        /// This is the Tool node. This can be used to call a tool in your workflow.<br/>
        /// The flow is:<br/>
        /// - Workflow starts the tool node<br/>
        /// - Model is called to extract parameters needed by the tool from the conversation history<br/>
        /// - Tool is called with the parameters<br/>
        /// - Server returns a response<br/>
        /// - Workflow continues with the response
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.ToolNodeTypeJsonConverter))]
        public global::Vapi.ToolNodeType Type { get; set; }

        /// <summary>
        /// This is the tool to call. To use an existing tool, send `toolId` instead.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.CreateApiRequestToolDTO, global::Vapi.CreateBashToolDTO, global::Vapi.CreateCodeToolDTO, global::Vapi.CreateComputerToolDTO, global::Vapi.CreateDtmfToolDTO, global::Vapi.CreateEndCallToolDTO, global::Vapi.CreateFunctionToolDTO, global::Vapi.CreateGoHighLevelCalendarAvailabilityToolDTO, global::Vapi.CreateGoHighLevelCalendarEventCreateToolDTO, global::Vapi.CreateGoHighLevelContactCreateToolDTO, global::Vapi.CreateGoHighLevelContactGetToolDTO, global::Vapi.CreateGoogleCalendarCheckAvailabilityToolDTO, global::Vapi.CreateGoogleCalendarCreateEventToolDTO, global::Vapi.CreateGoogleSheetsRowAppendToolDTO, global::Vapi.CreateHandoffToolDTO, global::Vapi.CreateMcpToolDTO, global::Vapi.CreateQueryToolDTO, global::Vapi.CreateSlackSendMessageToolDTO, global::Vapi.CreateSmsToolDTO, global::Vapi.CreateTextEditorToolDTO, global::Vapi.CreateTransferCallToolDTO, global::Vapi.CreateSipRequestToolDTO, global::Vapi.CreateVoicemailToolDTO>))]
        public global::Vapi.OneOf<global::Vapi.CreateApiRequestToolDTO, global::Vapi.CreateBashToolDTO, global::Vapi.CreateCodeToolDTO, global::Vapi.CreateComputerToolDTO, global::Vapi.CreateDtmfToolDTO, global::Vapi.CreateEndCallToolDTO, global::Vapi.CreateFunctionToolDTO, global::Vapi.CreateGoHighLevelCalendarAvailabilityToolDTO, global::Vapi.CreateGoHighLevelCalendarEventCreateToolDTO, global::Vapi.CreateGoHighLevelContactCreateToolDTO, global::Vapi.CreateGoHighLevelContactGetToolDTO, global::Vapi.CreateGoogleCalendarCheckAvailabilityToolDTO, global::Vapi.CreateGoogleCalendarCreateEventToolDTO, global::Vapi.CreateGoogleSheetsRowAppendToolDTO, global::Vapi.CreateHandoffToolDTO, global::Vapi.CreateMcpToolDTO, global::Vapi.CreateQueryToolDTO, global::Vapi.CreateSlackSendMessageToolDTO, global::Vapi.CreateSmsToolDTO, global::Vapi.CreateTextEditorToolDTO, global::Vapi.CreateTransferCallToolDTO, global::Vapi.CreateSipRequestToolDTO, global::Vapi.CreateVoicemailToolDTO>? Tool { get; set; }

        /// <summary>
        /// This is the tool to call. To use a transient tool, send `tool` instead.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("toolId")]
        public string? ToolId { get; set; }

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
        /// Initializes a new instance of the <see cref="ToolNode" /> class.
        /// </summary>
        /// <param name="type">
        /// This is the Tool node. This can be used to call a tool in your workflow.<br/>
        /// The flow is:<br/>
        /// - Workflow starts the tool node<br/>
        /// - Model is called to extract parameters needed by the tool from the conversation history<br/>
        /// - Tool is called with the parameters<br/>
        /// - Server returns a response<br/>
        /// - Workflow continues with the response
        /// </param>
        /// <param name="tool">
        /// This is the tool to call. To use an existing tool, send `toolId` instead.
        /// </param>
        /// <param name="toolId">
        /// This is the tool to call. To use a transient tool, send `tool` instead.
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
        public ToolNode(
            string name,
            global::Vapi.ToolNodeType type,
            global::Vapi.OneOf<global::Vapi.CreateApiRequestToolDTO, global::Vapi.CreateBashToolDTO, global::Vapi.CreateCodeToolDTO, global::Vapi.CreateComputerToolDTO, global::Vapi.CreateDtmfToolDTO, global::Vapi.CreateEndCallToolDTO, global::Vapi.CreateFunctionToolDTO, global::Vapi.CreateGoHighLevelCalendarAvailabilityToolDTO, global::Vapi.CreateGoHighLevelCalendarEventCreateToolDTO, global::Vapi.CreateGoHighLevelContactCreateToolDTO, global::Vapi.CreateGoHighLevelContactGetToolDTO, global::Vapi.CreateGoogleCalendarCheckAvailabilityToolDTO, global::Vapi.CreateGoogleCalendarCreateEventToolDTO, global::Vapi.CreateGoogleSheetsRowAppendToolDTO, global::Vapi.CreateHandoffToolDTO, global::Vapi.CreateMcpToolDTO, global::Vapi.CreateQueryToolDTO, global::Vapi.CreateSlackSendMessageToolDTO, global::Vapi.CreateSmsToolDTO, global::Vapi.CreateTextEditorToolDTO, global::Vapi.CreateTransferCallToolDTO, global::Vapi.CreateSipRequestToolDTO, global::Vapi.CreateVoicemailToolDTO>? tool,
            string? toolId,
            bool? isStart,
            object? metadata)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Type = type;
            this.Tool = tool;
            this.ToolId = toolId;
            this.IsStart = isStart;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolNode" /> class.
        /// </summary>
        public ToolNode()
        {
        }
    }
}