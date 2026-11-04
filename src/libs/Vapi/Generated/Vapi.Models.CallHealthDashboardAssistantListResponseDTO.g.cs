
#nullable enable

namespace Vapi
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CallHealthDashboardAssistantListResponseDTO
    {
        /// <summary>
        /// Visible nondeleted assistants in ascending ID transport order; sort the exhausted result in the frontend.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("results")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vapi.CallHealthDashboardAssistantOverviewDTO> Results { get; set; }

        /// <summary>
        /// Opaque ID continuation bound to tenant, completion window and filters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nextCursor")]
        public string? NextCursor { get; set; }

        /// <summary>
        /// Received-work processing coverage, separate from analyzed goal results.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("coverage")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vapi.CallHealthDashboardCoverageDTO Coverage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CallHealthDashboardAssistantListResponseDTO" /> class.
        /// </summary>
        /// <param name="results">
        /// Visible nondeleted assistants in ascending ID transport order; sort the exhausted result in the frontend.
        /// </param>
        /// <param name="coverage">
        /// Received-work processing coverage, separate from analyzed goal results.
        /// </param>
        /// <param name="nextCursor">
        /// Opaque ID continuation bound to tenant, completion window and filters.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CallHealthDashboardAssistantListResponseDTO(
            global::System.Collections.Generic.IList<global::Vapi.CallHealthDashboardAssistantOverviewDTO> results,
            global::Vapi.CallHealthDashboardCoverageDTO coverage,
            string? nextCursor)
        {
            this.Results = results ?? throw new global::System.ArgumentNullException(nameof(results));
            this.NextCursor = nextCursor;
            this.Coverage = coverage ?? throw new global::System.ArgumentNullException(nameof(coverage));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CallHealthDashboardAssistantListResponseDTO" /> class.
        /// </summary>
        public CallHealthDashboardAssistantListResponseDTO()
        {
        }

    }
}