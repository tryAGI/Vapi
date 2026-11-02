
#nullable enable

namespace Vapi
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CallHealthDashboardAssignmentCoverageDTO
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pending")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long Pending { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("unmatched")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long Unmatched { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("skipped")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long Skipped { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("unavailable")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long Unavailable { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long Error { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("coverageGapCount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long CoverageGapCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CallHealthDashboardAssignmentCoverageDTO" /> class.
        /// </summary>
        /// <param name="pending"></param>
        /// <param name="unmatched"></param>
        /// <param name="skipped"></param>
        /// <param name="unavailable"></param>
        /// <param name="error"></param>
        /// <param name="coverageGapCount"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CallHealthDashboardAssignmentCoverageDTO(
            long pending,
            long unmatched,
            long skipped,
            long unavailable,
            long error,
            long coverageGapCount)
        {
            this.Pending = pending;
            this.Unmatched = unmatched;
            this.Skipped = skipped;
            this.Unavailable = unavailable;
            this.Error = error;
            this.CoverageGapCount = coverageGapCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CallHealthDashboardAssignmentCoverageDTO" /> class.
        /// </summary>
        public CallHealthDashboardAssignmentCoverageDTO()
        {
        }

    }
}