
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vapi
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateToolTemplateDTO
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("details")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.CreateApiRequestToolDTO, global::Vapi.CreateBashToolDTO, global::Vapi.CreateCodeToolDTO, global::Vapi.CreateComputerToolDTO, global::Vapi.CreateDtmfToolDTO, global::Vapi.CreateEndCallToolDTO, global::Vapi.CreateFunctionToolDTO, global::Vapi.CreateGoHighLevelCalendarAvailabilityToolDTO, global::Vapi.CreateGoHighLevelCalendarEventCreateToolDTO, global::Vapi.CreateGoHighLevelContactCreateToolDTO, global::Vapi.CreateGoHighLevelContactGetToolDTO, global::Vapi.CreateGoogleCalendarCheckAvailabilityToolDTO, global::Vapi.CreateGoogleCalendarCreateEventToolDTO, global::Vapi.CreateGoogleSheetsRowAppendToolDTO, global::Vapi.CreateHandoffToolDTO, global::Vapi.CreateMcpToolDTO, global::Vapi.CreateQueryToolDTO, global::Vapi.CreateSlackSendMessageToolDTO, global::Vapi.CreateSmsToolDTO, global::Vapi.CreateTextEditorToolDTO, global::Vapi.CreateTransferCallToolDTO, global::Vapi.CreateSipRequestToolDTO, global::Vapi.CreateVoicemailToolDTO>))]
        public global::Vapi.OneOf<global::Vapi.CreateApiRequestToolDTO, global::Vapi.CreateBashToolDTO, global::Vapi.CreateCodeToolDTO, global::Vapi.CreateComputerToolDTO, global::Vapi.CreateDtmfToolDTO, global::Vapi.CreateEndCallToolDTO, global::Vapi.CreateFunctionToolDTO, global::Vapi.CreateGoHighLevelCalendarAvailabilityToolDTO, global::Vapi.CreateGoHighLevelCalendarEventCreateToolDTO, global::Vapi.CreateGoHighLevelContactCreateToolDTO, global::Vapi.CreateGoHighLevelContactGetToolDTO, global::Vapi.CreateGoogleCalendarCheckAvailabilityToolDTO, global::Vapi.CreateGoogleCalendarCreateEventToolDTO, global::Vapi.CreateGoogleSheetsRowAppendToolDTO, global::Vapi.CreateHandoffToolDTO, global::Vapi.CreateMcpToolDTO, global::Vapi.CreateQueryToolDTO, global::Vapi.CreateSlackSendMessageToolDTO, global::Vapi.CreateSmsToolDTO, global::Vapi.CreateTextEditorToolDTO, global::Vapi.CreateTransferCallToolDTO, global::Vapi.CreateSipRequestToolDTO, global::Vapi.CreateVoicemailToolDTO>? Details { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("providerDetails")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.MakeToolProviderDetails, global::Vapi.GhlToolProviderDetails, global::Vapi.FunctionToolProviderDetails, global::Vapi.GoogleCalendarCreateEventToolProviderDetails, global::Vapi.GoogleSheetsRowAppendToolProviderDetails, global::Vapi.GoHighLevelCalendarAvailabilityToolProviderDetails, global::Vapi.GoHighLevelCalendarEventCreateToolProviderDetails, global::Vapi.GoHighLevelContactCreateToolProviderDetails, global::Vapi.GoHighLevelContactGetToolProviderDetails>))]
        public global::Vapi.OneOf<global::Vapi.MakeToolProviderDetails, global::Vapi.GhlToolProviderDetails, global::Vapi.FunctionToolProviderDetails, global::Vapi.GoogleCalendarCreateEventToolProviderDetails, global::Vapi.GoogleSheetsRowAppendToolProviderDetails, global::Vapi.GoHighLevelCalendarAvailabilityToolProviderDetails, global::Vapi.GoHighLevelCalendarEventCreateToolProviderDetails, global::Vapi.GoHighLevelContactCreateToolProviderDetails, global::Vapi.GoHighLevelContactGetToolProviderDetails>? ProviderDetails { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::Vapi.ToolTemplateMetadata? Metadata { get; set; }

        /// <summary>
        /// Default Value: private
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("visibility")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.CreateToolTemplateDTOVisibilityJsonConverter))]
        public global::Vapi.CreateToolTemplateDTOVisibility? Visibility { get; set; }

        /// <summary>
        /// Default Value: tool
        /// </summary>
        /// <default>global::Vapi.CreateToolTemplateDTOType.Tool</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.CreateToolTemplateDTOTypeJsonConverter))]
        public global::Vapi.CreateToolTemplateDTOType Type { get; set; } = global::Vapi.CreateToolTemplateDTOType.Tool;

        /// <summary>
        /// The name of the template. This is just for your own reference.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.CreateToolTemplateDTOProviderJsonConverter))]
        public global::Vapi.CreateToolTemplateDTOProvider? Provider { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateToolTemplateDTO" /> class.
        /// </summary>
        /// <param name="details"></param>
        /// <param name="providerDetails"></param>
        /// <param name="metadata"></param>
        /// <param name="visibility">
        /// Default Value: private
        /// </param>
        /// <param name="type">
        /// Default Value: tool
        /// </param>
        /// <param name="name">
        /// The name of the template. This is just for your own reference.
        /// </param>
        /// <param name="provider"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateToolTemplateDTO(
            global::Vapi.OneOf<global::Vapi.CreateApiRequestToolDTO, global::Vapi.CreateBashToolDTO, global::Vapi.CreateCodeToolDTO, global::Vapi.CreateComputerToolDTO, global::Vapi.CreateDtmfToolDTO, global::Vapi.CreateEndCallToolDTO, global::Vapi.CreateFunctionToolDTO, global::Vapi.CreateGoHighLevelCalendarAvailabilityToolDTO, global::Vapi.CreateGoHighLevelCalendarEventCreateToolDTO, global::Vapi.CreateGoHighLevelContactCreateToolDTO, global::Vapi.CreateGoHighLevelContactGetToolDTO, global::Vapi.CreateGoogleCalendarCheckAvailabilityToolDTO, global::Vapi.CreateGoogleCalendarCreateEventToolDTO, global::Vapi.CreateGoogleSheetsRowAppendToolDTO, global::Vapi.CreateHandoffToolDTO, global::Vapi.CreateMcpToolDTO, global::Vapi.CreateQueryToolDTO, global::Vapi.CreateSlackSendMessageToolDTO, global::Vapi.CreateSmsToolDTO, global::Vapi.CreateTextEditorToolDTO, global::Vapi.CreateTransferCallToolDTO, global::Vapi.CreateSipRequestToolDTO, global::Vapi.CreateVoicemailToolDTO>? details,
            global::Vapi.OneOf<global::Vapi.MakeToolProviderDetails, global::Vapi.GhlToolProviderDetails, global::Vapi.FunctionToolProviderDetails, global::Vapi.GoogleCalendarCreateEventToolProviderDetails, global::Vapi.GoogleSheetsRowAppendToolProviderDetails, global::Vapi.GoHighLevelCalendarAvailabilityToolProviderDetails, global::Vapi.GoHighLevelCalendarEventCreateToolProviderDetails, global::Vapi.GoHighLevelContactCreateToolProviderDetails, global::Vapi.GoHighLevelContactGetToolProviderDetails>? providerDetails,
            global::Vapi.ToolTemplateMetadata? metadata,
            global::Vapi.CreateToolTemplateDTOVisibility? visibility,
            string? name,
            global::Vapi.CreateToolTemplateDTOProvider? provider,
            global::Vapi.CreateToolTemplateDTOType type = global::Vapi.CreateToolTemplateDTOType.Tool)
        {
            this.Details = details;
            this.ProviderDetails = providerDetails;
            this.Metadata = metadata;
            this.Visibility = visibility;
            this.Type = type;
            this.Name = name;
            this.Provider = provider;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateToolTemplateDTO" /> class.
        /// </summary>
        public CreateToolTemplateDTO()
        {
        }
    }
}