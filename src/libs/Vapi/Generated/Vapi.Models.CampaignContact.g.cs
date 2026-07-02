
#nullable enable

namespace Vapi
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CampaignContact
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("campaignId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CampaignId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("orgId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OrgId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("customerId")]
        public string? CustomerId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("number")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Number { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assistantOverrides")]
        public global::Vapi.AssistantOverrides? AssistantOverrides { get; set; }

        /// <summary>
        /// Use this when the campaign targets a `squadId`. Mirrors the call-level `squadOverrides` field. Merged with the campaign-level squadOverrides at dispatch time.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("squadOverrides")]
        public global::Vapi.AssistantOverrides? SquadOverrides { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CampaignContact" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="campaignId"></param>
        /// <param name="orgId"></param>
        /// <param name="number"></param>
        /// <param name="createdAt"></param>
        /// <param name="customerId"></param>
        /// <param name="name"></param>
        /// <param name="assistantOverrides"></param>
        /// <param name="squadOverrides">
        /// Use this when the campaign targets a `squadId`. Mirrors the call-level `squadOverrides` field. Merged with the campaign-level squadOverrides at dispatch time.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CampaignContact(
            string id,
            string campaignId,
            string orgId,
            string number,
            global::System.DateTime createdAt,
            string? customerId,
            string? name,
            global::Vapi.AssistantOverrides? assistantOverrides,
            global::Vapi.AssistantOverrides? squadOverrides)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.CampaignId = campaignId ?? throw new global::System.ArgumentNullException(nameof(campaignId));
            this.OrgId = orgId ?? throw new global::System.ArgumentNullException(nameof(orgId));
            this.CustomerId = customerId;
            this.Number = number ?? throw new global::System.ArgumentNullException(nameof(number));
            this.Name = name;
            this.AssistantOverrides = assistantOverrides;
            this.SquadOverrides = squadOverrides;
            this.CreatedAt = createdAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CampaignContact" /> class.
        /// </summary>
        public CampaignContact()
        {
        }

    }
}