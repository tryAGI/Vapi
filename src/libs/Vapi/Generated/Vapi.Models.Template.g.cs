
#nullable enable

namespace Vapi
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Template
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.TemplateVisibilityJsonConverter))]
        public global::Vapi.TemplateVisibility? Visibility { get; set; }

        /// <summary>
        /// Default Value: tool
        /// </summary>
        /// <default>global::Vapi.TemplateType.Tool</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.TemplateTypeJsonConverter))]
        public global::Vapi.TemplateType Type { get; set; } = global::Vapi.TemplateType.Tool;

        /// <summary>
        /// The name of the template. This is just for your own reference.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.TemplateProviderJsonConverter))]
        public global::Vapi.TemplateProvider? Provider { get; set; }

        /// <summary>
        /// The unique identifier for the template.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The unique identifier for the organization that this template belongs to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("orgId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OrgId { get; set; }

        /// <summary>
        /// The ISO 8601 date-time string of when the template was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// The ISO 8601 date-time string of when the template was last updated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Template" /> class.
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
        /// <param name="id">
        /// The unique identifier for the template.
        /// </param>
        /// <param name="orgId">
        /// The unique identifier for the organization that this template belongs to.
        /// </param>
        /// <param name="createdAt">
        /// The ISO 8601 date-time string of when the template was created.
        /// </param>
        /// <param name="updatedAt">
        /// The ISO 8601 date-time string of when the template was last updated.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Template(
            string id,
            string orgId,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            global::Vapi.OneOf<global::Vapi.CreateApiRequestToolDTO, global::Vapi.CreateBashToolDTO, global::Vapi.CreateCodeToolDTO, global::Vapi.CreateComputerToolDTO, global::Vapi.CreateDtmfToolDTO, global::Vapi.CreateEndCallToolDTO, global::Vapi.CreateFunctionToolDTO, global::Vapi.CreateGoHighLevelCalendarAvailabilityToolDTO, global::Vapi.CreateGoHighLevelCalendarEventCreateToolDTO, global::Vapi.CreateGoHighLevelContactCreateToolDTO, global::Vapi.CreateGoHighLevelContactGetToolDTO, global::Vapi.CreateGoogleCalendarCheckAvailabilityToolDTO, global::Vapi.CreateGoogleCalendarCreateEventToolDTO, global::Vapi.CreateGoogleSheetsRowAppendToolDTO, global::Vapi.CreateHandoffToolDTO, global::Vapi.CreateMcpToolDTO, global::Vapi.CreateQueryToolDTO, global::Vapi.CreateSlackSendMessageToolDTO, global::Vapi.CreateSmsToolDTO, global::Vapi.CreateTextEditorToolDTO, global::Vapi.CreateTransferCallToolDTO, global::Vapi.CreateSipRequestToolDTO, global::Vapi.CreateVoicemailToolDTO>? details,
            global::Vapi.OneOf<global::Vapi.MakeToolProviderDetails, global::Vapi.GhlToolProviderDetails, global::Vapi.FunctionToolProviderDetails, global::Vapi.GoogleCalendarCreateEventToolProviderDetails, global::Vapi.GoogleSheetsRowAppendToolProviderDetails, global::Vapi.GoHighLevelCalendarAvailabilityToolProviderDetails, global::Vapi.GoHighLevelCalendarEventCreateToolProviderDetails, global::Vapi.GoHighLevelContactCreateToolProviderDetails, global::Vapi.GoHighLevelContactGetToolProviderDetails>? providerDetails,
            global::Vapi.ToolTemplateMetadata? metadata,
            global::Vapi.TemplateVisibility? visibility,
            string? name,
            global::Vapi.TemplateProvider? provider,
            global::Vapi.TemplateType type = global::Vapi.TemplateType.Tool)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.OrgId = orgId ?? throw new global::System.ArgumentNullException(nameof(orgId));
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.Details = details;
            this.ProviderDetails = providerDetails;
            this.Metadata = metadata;
            this.Visibility = visibility;
            this.Type = type;
            this.Name = name;
            this.Provider = provider;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Template" /> class.
        /// </summary>
        public Template()
        {
        }
    }
}