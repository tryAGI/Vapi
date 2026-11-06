
#nullable enable

namespace Vapi
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CallHealthDashboardIssueActivityListResponseDTO
    {
        /// <summary>
        /// Newest issue versions first; this is shared team activity, not per-user feedback.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("results")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vapi.CallHealthDashboardIssueActivityDTO> Results { get; set; }

        /// <summary>
        /// Signed continuation bound to the authenticated organization, issue and activity contract.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nextCursor")]
        public string? NextCursor { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CallHealthDashboardIssueActivityListResponseDTO" /> class.
        /// </summary>
        /// <param name="results">
        /// Newest issue versions first; this is shared team activity, not per-user feedback.
        /// </param>
        /// <param name="nextCursor">
        /// Signed continuation bound to the authenticated organization, issue and activity contract.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CallHealthDashboardIssueActivityListResponseDTO(
            global::System.Collections.Generic.IList<global::Vapi.CallHealthDashboardIssueActivityDTO> results,
            string? nextCursor)
        {
            this.Results = results ?? throw new global::System.ArgumentNullException(nameof(results));
            this.NextCursor = nextCursor;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CallHealthDashboardIssueActivityListResponseDTO" /> class.
        /// </summary>
        public CallHealthDashboardIssueActivityListResponseDTO()
        {
        }

    }
}