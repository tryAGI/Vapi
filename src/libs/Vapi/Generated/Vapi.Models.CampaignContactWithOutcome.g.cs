
#nullable enable

namespace Vapi
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CampaignContactWithOutcome
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
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.CampaignContactWithOutcomeStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vapi.CampaignContactWithOutcomeStatus Status { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("callId")]
        public string? CallId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dispatchedAt")]
        public global::System.DateTime? DispatchedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("endedReason")]
        public string? EndedReason { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CampaignContactWithOutcome" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="number"></param>
        /// <param name="status"></param>
        /// <param name="name"></param>
        /// <param name="callId"></param>
        /// <param name="dispatchedAt"></param>
        /// <param name="endedReason"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CampaignContactWithOutcome(
            string id,
            string number,
            global::Vapi.CampaignContactWithOutcomeStatus status,
            string? name,
            string? callId,
            global::System.DateTime? dispatchedAt,
            string? endedReason)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Number = number ?? throw new global::System.ArgumentNullException(nameof(number));
            this.Name = name;
            this.Status = status;
            this.CallId = callId;
            this.DispatchedAt = dispatchedAt;
            this.EndedReason = endedReason;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CampaignContactWithOutcome" /> class.
        /// </summary>
        public CampaignContactWithOutcome()
        {
        }

    }
}