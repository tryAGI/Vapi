
#nullable enable

namespace Vapi
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateCampaignDTO
    {
        /// <summary>
        /// This is the name of the campaign. This is just for your own reference.<br/>
        /// Example: Q2 Sales Campaign
        /// </summary>
        /// <example>Q2 Sales Campaign</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// This is the assistant ID that will be used for the campaign calls. Note: Only one of assistantId, workflowId, or squadId can be used.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assistantId")]
        public string? AssistantId { get; set; }

        /// <summary>
        /// This is the workflow ID that will be used for the campaign calls. Note: Only one of assistantId, workflowId, or squadId can be used.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workflowId")]
        public string? WorkflowId { get; set; }

        /// <summary>
        /// This is the squad ID that will be used for the campaign calls. Note: Only one of assistantId, workflowId, or squadId can be used.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("squadId")]
        public string? SquadId { get; set; }

        /// <summary>
        /// This is the phone number ID that will be used for the campaign calls. Required if dialPlan is not provided. Note: phoneNumberId and dialPlan are mutually exclusive.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("phoneNumberId")]
        public string? PhoneNumberId { get; set; }

        /// <summary>
        /// This is a list of dial entries, each specifying a phone number and the customers to call using that number. Use this when you want different phone numbers to call different sets of customers. Note: phoneNumberId and dialPlan are mutually exclusive.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dialPlan")]
        public global::System.Collections.Generic.IList<global::Vapi.DialPlanEntry>? DialPlan { get; set; }

        /// <summary>
        /// This is the schedule plan for the campaign. Calls will start at startedAt and continue until your organization’s concurrency limit is reached. Any remaining calls will be retried for up to one hour as capacity becomes available. After that hour or after latestAt, whichever comes first, any calls that couldn’t be placed won’t be retried.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("schedulePlan")]
        public global::Vapi.SchedulePlan? SchedulePlan { get; set; }

        /// <summary>
        /// These are the customers that will be called in the campaign. Required if dialPlan is not provided.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("customers")]
        public global::System.Collections.Generic.IList<global::Vapi.CreateCustomerDTO>? Customers { get; set; }

        /// <summary>
        /// This is the maximum number of concurrent calls that will be made for the campaign. Defaults to 10.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maxConcurrency")]
        public double? MaxConcurrency { get; set; }

        /// <summary>
        /// These are the overrides for the assistant's settings and template variables for the campaign. Use this when the campaign targets an `assistantId`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assistantOverrides")]
        public global::Vapi.AssistantOverrides? AssistantOverrides { get; set; }

        /// <summary>
        /// These are the overrides for the squad and template variables for the campaign. Use this when the campaign targets a `squadId`. Per-contact `squadOverrides` are deep-merged on top of this at dispatch time.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("squadOverrides")]
        public global::Vapi.AssistantOverrides? SquadOverrides { get; set; }

        /// <summary>
        /// This is the server (URL, auth headers, timeout, etc.) for the campaign webhooks.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("server")]
        public global::Vapi.Server? Server { get; set; }

        /// <summary>
        /// Optional campaign ID to duplicate config from. Provided fields in the request override the source. If `customers` is omitted, contacts are copied from the source.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duplicateFromCampaignId")]
        public string? DuplicateFromCampaignId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCampaignDTO" /> class.
        /// </summary>
        /// <param name="name">
        /// This is the name of the campaign. This is just for your own reference.<br/>
        /// Example: Q2 Sales Campaign
        /// </param>
        /// <param name="assistantId">
        /// This is the assistant ID that will be used for the campaign calls. Note: Only one of assistantId, workflowId, or squadId can be used.
        /// </param>
        /// <param name="workflowId">
        /// This is the workflow ID that will be used for the campaign calls. Note: Only one of assistantId, workflowId, or squadId can be used.
        /// </param>
        /// <param name="squadId">
        /// This is the squad ID that will be used for the campaign calls. Note: Only one of assistantId, workflowId, or squadId can be used.
        /// </param>
        /// <param name="phoneNumberId">
        /// This is the phone number ID that will be used for the campaign calls. Required if dialPlan is not provided. Note: phoneNumberId and dialPlan are mutually exclusive.
        /// </param>
        /// <param name="dialPlan">
        /// This is a list of dial entries, each specifying a phone number and the customers to call using that number. Use this when you want different phone numbers to call different sets of customers. Note: phoneNumberId and dialPlan are mutually exclusive.
        /// </param>
        /// <param name="schedulePlan">
        /// This is the schedule plan for the campaign. Calls will start at startedAt and continue until your organization’s concurrency limit is reached. Any remaining calls will be retried for up to one hour as capacity becomes available. After that hour or after latestAt, whichever comes first, any calls that couldn’t be placed won’t be retried.
        /// </param>
        /// <param name="customers">
        /// These are the customers that will be called in the campaign. Required if dialPlan is not provided.
        /// </param>
        /// <param name="maxConcurrency">
        /// This is the maximum number of concurrent calls that will be made for the campaign. Defaults to 10.
        /// </param>
        /// <param name="assistantOverrides">
        /// These are the overrides for the assistant's settings and template variables for the campaign. Use this when the campaign targets an `assistantId`.
        /// </param>
        /// <param name="squadOverrides">
        /// These are the overrides for the squad and template variables for the campaign. Use this when the campaign targets a `squadId`. Per-contact `squadOverrides` are deep-merged on top of this at dispatch time.
        /// </param>
        /// <param name="server">
        /// This is the server (URL, auth headers, timeout, etc.) for the campaign webhooks.
        /// </param>
        /// <param name="duplicateFromCampaignId">
        /// Optional campaign ID to duplicate config from. Provided fields in the request override the source. If `customers` is omitted, contacts are copied from the source.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateCampaignDTO(
            string name,
            string? assistantId,
            string? workflowId,
            string? squadId,
            string? phoneNumberId,
            global::System.Collections.Generic.IList<global::Vapi.DialPlanEntry>? dialPlan,
            global::Vapi.SchedulePlan? schedulePlan,
            global::System.Collections.Generic.IList<global::Vapi.CreateCustomerDTO>? customers,
            double? maxConcurrency,
            global::Vapi.AssistantOverrides? assistantOverrides,
            global::Vapi.AssistantOverrides? squadOverrides,
            global::Vapi.Server? server,
            string? duplicateFromCampaignId)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.AssistantId = assistantId;
            this.WorkflowId = workflowId;
            this.SquadId = squadId;
            this.PhoneNumberId = phoneNumberId;
            this.DialPlan = dialPlan;
            this.SchedulePlan = schedulePlan;
            this.Customers = customers;
            this.MaxConcurrency = maxConcurrency;
            this.AssistantOverrides = assistantOverrides;
            this.SquadOverrides = squadOverrides;
            this.Server = server;
            this.DuplicateFromCampaignId = duplicateFromCampaignId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCampaignDTO" /> class.
        /// </summary>
        public CreateCampaignDTO()
        {
        }

    }
}