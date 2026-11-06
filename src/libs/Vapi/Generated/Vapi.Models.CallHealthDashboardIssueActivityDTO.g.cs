
#nullable enable

namespace Vapi
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CallHealthDashboardIssueActivityDTO
    {
        /// <summary>
        /// Existing issue version after this transition; also the per-issue activity identity.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rowVersion")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long RowVersion { get; set; }

        /// <summary>
        /// User resolve, dismiss or restore, or the system reopen written when a new match reopens a resolved issue.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.CallHealthDashboardIssueActivityDTOActionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vapi.CallHealthDashboardIssueActivityDTOAction Action { get; set; }

        /// <summary>
        /// Omitted for private-key actors and system entries; names/emails are not copied.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("actorUserId")]
        public global::System.Guid? ActorUserId { get; set; }

        /// <summary>
        /// Optional team-visible comment; omitted after privacy scrubbing.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("comment")]
        public string? Comment { get; set; }

        /// <summary>
        /// Database action time; ordering uses rowVersion rather than rounded timestamps.
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
        /// Initializes a new instance of the <see cref="CallHealthDashboardIssueActivityDTO" /> class.
        /// </summary>
        /// <param name="rowVersion">
        /// Existing issue version after this transition; also the per-issue activity identity.
        /// </param>
        /// <param name="action">
        /// User resolve, dismiss or restore, or the system reopen written when a new match reopens a resolved issue.
        /// </param>
        /// <param name="createdAt">
        /// Database action time; ordering uses rowVersion rather than rounded timestamps.
        /// </param>
        /// <param name="actorUserId">
        /// Omitted for private-key actors and system entries; names/emails are not copied.
        /// </param>
        /// <param name="comment">
        /// Optional team-visible comment; omitted after privacy scrubbing.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CallHealthDashboardIssueActivityDTO(
            long rowVersion,
            global::Vapi.CallHealthDashboardIssueActivityDTOAction action,
            global::System.DateTime createdAt,
            global::System.Guid? actorUserId,
            string? comment)
        {
            this.RowVersion = rowVersion;
            this.Action = action;
            this.ActorUserId = actorUserId;
            this.Comment = comment;
            this.CreatedAt = createdAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CallHealthDashboardIssueActivityDTO" /> class.
        /// </summary>
        public CallHealthDashboardIssueActivityDTO()
        {
        }

    }
}