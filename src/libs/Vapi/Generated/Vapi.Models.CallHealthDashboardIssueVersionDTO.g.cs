
#nullable enable

namespace Vapi
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CallHealthDashboardIssueVersionDTO
    {
        /// <summary>
        /// The version the calls ran on; null groups the calls that ran on no version.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assistantVersionId")]
        public global::System.Guid? AssistantVersionId { get; set; }

        /// <summary>
        /// The version's label, such as v3; absent for calls on no version or whose label was unavailable at registration.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assistantVersion")]
        public string? AssistantVersion { get; set; }

        /// <summary>
        /// Distinct visible calls on this version matching the issue in the window.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("affectedCallCount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long AffectedCallCount { get; set; }

        /// <summary>
        /// Accepted current-goal outcomes on this version for the issue's assistant in the window.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("analyzedCallCount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long AnalyzedCallCount { get; set; }

        /// <summary>
        /// affectedCallCount / analyzedCallCount; omitted for a zero denominator.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("affectedCallRate")]
        public double? AffectedCallRate { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CallHealthDashboardIssueVersionDTO" /> class.
        /// </summary>
        /// <param name="affectedCallCount">
        /// Distinct visible calls on this version matching the issue in the window.
        /// </param>
        /// <param name="analyzedCallCount">
        /// Accepted current-goal outcomes on this version for the issue's assistant in the window.
        /// </param>
        /// <param name="assistantVersionId">
        /// The version the calls ran on; null groups the calls that ran on no version.
        /// </param>
        /// <param name="assistantVersion">
        /// The version's label, such as v3; absent for calls on no version or whose label was unavailable at registration.
        /// </param>
        /// <param name="affectedCallRate">
        /// affectedCallCount / analyzedCallCount; omitted for a zero denominator.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CallHealthDashboardIssueVersionDTO(
            long affectedCallCount,
            long analyzedCallCount,
            global::System.Guid? assistantVersionId,
            string? assistantVersion,
            double? affectedCallRate)
        {
            this.AssistantVersionId = assistantVersionId;
            this.AssistantVersion = assistantVersion;
            this.AffectedCallCount = affectedCallCount;
            this.AnalyzedCallCount = analyzedCallCount;
            this.AffectedCallRate = affectedCallRate;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CallHealthDashboardIssueVersionDTO" /> class.
        /// </summary>
        public CallHealthDashboardIssueVersionDTO()
        {
        }

    }
}