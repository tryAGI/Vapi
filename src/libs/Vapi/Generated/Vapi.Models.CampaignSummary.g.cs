
#nullable enable

namespace Vapi
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CampaignSummary
    {
        /// <summary>
        /// This is the status of the campaign.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.CampaignSummaryStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vapi.CampaignSummaryStatus Status { get; set; }

        /// <summary>
        /// This is the explanation for how the campaign ended.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("endedReason")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.CampaignSummaryEndedReasonJsonConverter))]
        public global::Vapi.CampaignSummaryEndedReason? EndedReason { get; set; }

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
        /// This is the schedule plan for the campaign. Calls will start at startedAt and continue until your organization’s concurrency limit is reached. Any remaining calls will be retried for up to one hour as capacity becomes available. After that hour or after latestAt, whichever comes first, any calls that couldn’t be placed won’t be retried.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("schedulePlan")]
        public global::Vapi.SchedulePlan? SchedulePlan { get; set; }

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
        /// These are the messages that will be sent to your Server URL.<br/>
        /// Example: [campaign.started, contact.dispatched]
        /// </summary>
        /// <example>[campaign.started, contact.dispatched]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("serverMessages")]
        public global::System.Collections.Generic.IList<global::Vapi.CampaignSummaryServerMessage>? ServerMessages { get; set; }

        /// <summary>
        /// This opts the campaign into the blocking `campaign.predial` eligibility webhook. When set, every contact triggers a `campaign.predial` POST to the Server URL before dialing, and the response `{ eligible: boolean }` decides whether the call is placed. Requires `server`. When unset, no pre-dial webhook is sent.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("predialPlan")]
        public global::Vapi.CampaignPredialPlan? PredialPlan { get; set; }

        /// <summary>
        /// These are the per-status contact counts for this campaign. Sum them for the<br/>
        /// campaign's total audience; `pending` plus `dispatched` is what is left to<br/>
        /// complete.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("contactCounters")]
        public global::Vapi.CampaignContactCounters? ContactCounters { get; set; }

        /// <summary>
        /// These are the call-level outcomes for this campaign — how many contacts<br/>
        /// were actually dialed, and how many of those a human picked up.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("callMetrics")]
        public global::Vapi.CampaignCallMetrics? CallMetrics { get; set; }

        /// <summary>
        /// This is the unique identifier for the campaign.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// This is the unique identifier for the org that this campaign belongs to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("orgId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OrgId { get; set; }

        /// <summary>
        /// This is the ISO 8601 date-time string of when the campaign was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// This is the ISO 8601 date-time string of when the campaign was last updated.
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
        /// Initializes a new instance of the <see cref="CampaignSummary" /> class.
        /// </summary>
        /// <param name="status">
        /// This is the status of the campaign.
        /// </param>
        /// <param name="name">
        /// This is the name of the campaign. This is just for your own reference.<br/>
        /// Example: Q2 Sales Campaign
        /// </param>
        /// <param name="id">
        /// This is the unique identifier for the campaign.
        /// </param>
        /// <param name="orgId">
        /// This is the unique identifier for the org that this campaign belongs to.
        /// </param>
        /// <param name="createdAt">
        /// This is the ISO 8601 date-time string of when the campaign was created.
        /// </param>
        /// <param name="updatedAt">
        /// This is the ISO 8601 date-time string of when the campaign was last updated.
        /// </param>
        /// <param name="endedReason">
        /// This is the explanation for how the campaign ended.
        /// </param>
        /// <param name="assistantId">
        /// This is the assistant ID that will be used for the campaign calls. Note: Only one of assistantId, workflowId, or squadId can be used.
        /// </param>
        /// <param name="squadId">
        /// This is the squad ID that will be used for the campaign calls. Note: Only one of assistantId, workflowId, or squadId can be used.
        /// </param>
        /// <param name="phoneNumberId">
        /// This is the phone number ID that will be used for the campaign calls. Required if dialPlan is not provided. Note: phoneNumberId and dialPlan are mutually exclusive.
        /// </param>
        /// <param name="schedulePlan">
        /// This is the schedule plan for the campaign. Calls will start at startedAt and continue until your organization’s concurrency limit is reached. Any remaining calls will be retried for up to one hour as capacity becomes available. After that hour or after latestAt, whichever comes first, any calls that couldn’t be placed won’t be retried.
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
        /// <param name="serverMessages">
        /// These are the messages that will be sent to your Server URL.<br/>
        /// Example: [campaign.started, contact.dispatched]
        /// </param>
        /// <param name="predialPlan">
        /// This opts the campaign into the blocking `campaign.predial` eligibility webhook. When set, every contact triggers a `campaign.predial` POST to the Server URL before dialing, and the response `{ eligible: boolean }` decides whether the call is placed. Requires `server`. When unset, no pre-dial webhook is sent.
        /// </param>
        /// <param name="contactCounters">
        /// These are the per-status contact counts for this campaign. Sum them for the<br/>
        /// campaign's total audience; `pending` plus `dispatched` is what is left to<br/>
        /// complete.
        /// </param>
        /// <param name="callMetrics">
        /// These are the call-level outcomes for this campaign — how many contacts<br/>
        /// were actually dialed, and how many of those a human picked up.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CampaignSummary(
            global::Vapi.CampaignSummaryStatus status,
            string name,
            string id,
            string orgId,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            global::Vapi.CampaignSummaryEndedReason? endedReason,
            string? assistantId,
            string? squadId,
            string? phoneNumberId,
            global::Vapi.SchedulePlan? schedulePlan,
            double? maxConcurrency,
            global::Vapi.AssistantOverrides? assistantOverrides,
            global::Vapi.AssistantOverrides? squadOverrides,
            global::Vapi.Server? server,
            global::System.Collections.Generic.IList<global::Vapi.CampaignSummaryServerMessage>? serverMessages,
            global::Vapi.CampaignPredialPlan? predialPlan,
            global::Vapi.CampaignContactCounters? contactCounters,
            global::Vapi.CampaignCallMetrics? callMetrics)
        {
            this.Status = status;
            this.EndedReason = endedReason;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.AssistantId = assistantId;
            this.SquadId = squadId;
            this.PhoneNumberId = phoneNumberId;
            this.SchedulePlan = schedulePlan;
            this.MaxConcurrency = maxConcurrency;
            this.AssistantOverrides = assistantOverrides;
            this.SquadOverrides = squadOverrides;
            this.Server = server;
            this.ServerMessages = serverMessages;
            this.PredialPlan = predialPlan;
            this.ContactCounters = contactCounters;
            this.CallMetrics = callMetrics;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.OrgId = orgId ?? throw new global::System.ArgumentNullException(nameof(orgId));
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CampaignSummary" /> class.
        /// </summary>
        public CampaignSummary()
        {
        }

    }
}