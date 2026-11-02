
#nullable enable

namespace Vapi
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CallHealthDashboardDiscoveryCoverageDTO
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pendingIssueCategoryCount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long PendingIssueCategoryCount { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("blockedIssueCategoryCount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long BlockedIssueCategoryCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CallHealthDashboardDiscoveryCoverageDTO" /> class.
        /// </summary>
        /// <param name="pendingIssueCategoryCount"></param>
        /// <param name="blockedIssueCategoryCount"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CallHealthDashboardDiscoveryCoverageDTO(
            long pendingIssueCategoryCount,
            long blockedIssueCategoryCount)
        {
            this.PendingIssueCategoryCount = pendingIssueCategoryCount;
            this.BlockedIssueCategoryCount = blockedIssueCategoryCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CallHealthDashboardDiscoveryCoverageDTO" /> class.
        /// </summary>
        public CallHealthDashboardDiscoveryCoverageDTO()
        {
        }

    }
}