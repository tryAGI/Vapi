
#nullable enable

namespace Vapi
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CallHealthDashboardIssueDefinitionDTO
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("applicability")]
        public string? Applicability { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("problem")]
        public string? Problem { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdTaxonomyVersion")]
        public long? CreatedTaxonomyVersion { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CallHealthDashboardIssueDefinitionDTO" /> class.
        /// </summary>
        /// <param name="applicability"></param>
        /// <param name="problem"></param>
        /// <param name="createdTaxonomyVersion"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CallHealthDashboardIssueDefinitionDTO(
            string? applicability,
            string? problem,
            long? createdTaxonomyVersion)
        {
            this.Applicability = applicability;
            this.Problem = problem;
            this.CreatedTaxonomyVersion = createdTaxonomyVersion;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CallHealthDashboardIssueDefinitionDTO" /> class.
        /// </summary>
        public CallHealthDashboardIssueDefinitionDTO()
        {
        }

    }
}