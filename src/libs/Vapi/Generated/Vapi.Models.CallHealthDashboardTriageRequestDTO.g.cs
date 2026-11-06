
#nullable enable

namespace Vapi
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CallHealthDashboardTriageRequestDTO
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.CallHealthDashboardTriageRequestDTOActionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vapi.CallHealthDashboardTriageRequestDTOAction Action { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expectedRowVersion")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long ExpectedRowVersion { get; set; }

        /// <summary>
        /// Trimmed; at most 2,048 UTF-16 code units. Empty comments are omitted from activity.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("comment")]
        public string? Comment { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CallHealthDashboardTriageRequestDTO" /> class.
        /// </summary>
        /// <param name="action"></param>
        /// <param name="expectedRowVersion"></param>
        /// <param name="comment">
        /// Trimmed; at most 2,048 UTF-16 code units. Empty comments are omitted from activity.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CallHealthDashboardTriageRequestDTO(
            global::Vapi.CallHealthDashboardTriageRequestDTOAction action,
            long expectedRowVersion,
            string? comment)
        {
            this.Action = action;
            this.ExpectedRowVersion = expectedRowVersion;
            this.Comment = comment;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CallHealthDashboardTriageRequestDTO" /> class.
        /// </summary>
        public CallHealthDashboardTriageRequestDTO()
        {
        }

    }
}