
#nullable enable

namespace Vapi
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class TrafficAllocation
    {
        /// <summary>
        /// Unique identifier. The most recently created allocation for an assistant is the one in effect.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("orgId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OrgId { get; set; }

        /// <summary>
        /// The assistant this allocation splits calls for.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assistantId")]
        public string? AssistantId { get; set; }

        /// <summary>
        /// 'explicit' splits calls across this allocation's targets. 'follow-latest' sends every call to the newest published version.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allocationIntent")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.TrafficAllocationAllocationIntentJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vapi.TrafficAllocationAllocationIntent AllocationIntent { get; set; }

        /// <summary>
        /// When this allocation was created, which is also when it took effect.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// Who created this allocation. 'system' means Vapi created it automatically, for example when a publish advances a follow-latest allocation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("actorType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.TrafficAllocationActorTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vapi.TrafficAllocationActorType ActorType { get; set; }

        /// <summary>
        /// The user id or API key id that created this allocation. Absent for system rows.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("actorId")]
        public string? ActorId { get; set; }

        /// <summary>
        /// Email of the user who created this allocation, as of that time.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("actorEmail")]
        public string? ActorEmail { get; set; }

        /// <summary>
        /// The note given when this allocation was created, if any.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// The versions this allocation splits calls across, in position order. Empty for follow-latest allocations.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("targets")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vapi.TrafficAllocationTarget> Targets { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TrafficAllocation" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier. The most recently created allocation for an assistant is the one in effect.
        /// </param>
        /// <param name="orgId"></param>
        /// <param name="allocationIntent">
        /// 'explicit' splits calls across this allocation's targets. 'follow-latest' sends every call to the newest published version.
        /// </param>
        /// <param name="createdAt">
        /// When this allocation was created, which is also when it took effect.
        /// </param>
        /// <param name="actorType">
        /// Who created this allocation. 'system' means Vapi created it automatically, for example when a publish advances a follow-latest allocation.
        /// </param>
        /// <param name="targets">
        /// The versions this allocation splits calls across, in position order. Empty for follow-latest allocations.
        /// </param>
        /// <param name="assistantId">
        /// The assistant this allocation splits calls for.
        /// </param>
        /// <param name="actorId">
        /// The user id or API key id that created this allocation. Absent for system rows.
        /// </param>
        /// <param name="actorEmail">
        /// Email of the user who created this allocation, as of that time.
        /// </param>
        /// <param name="description">
        /// The note given when this allocation was created, if any.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TrafficAllocation(
            string id,
            string orgId,
            global::Vapi.TrafficAllocationAllocationIntent allocationIntent,
            global::System.DateTime createdAt,
            global::Vapi.TrafficAllocationActorType actorType,
            global::System.Collections.Generic.IList<global::Vapi.TrafficAllocationTarget> targets,
            string? assistantId,
            string? actorId,
            string? actorEmail,
            string? description)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.OrgId = orgId ?? throw new global::System.ArgumentNullException(nameof(orgId));
            this.AssistantId = assistantId;
            this.AllocationIntent = allocationIntent;
            this.CreatedAt = createdAt;
            this.ActorType = actorType;
            this.ActorId = actorId;
            this.ActorEmail = actorEmail;
            this.Description = description;
            this.Targets = targets ?? throw new global::System.ArgumentNullException(nameof(targets));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TrafficAllocation" /> class.
        /// </summary>
        public TrafficAllocation()
        {
        }

    }
}