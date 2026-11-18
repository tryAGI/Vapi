
#nullable enable

namespace Vapi
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CallHealthDashboardGoalCallsResponseDTO
    {
        /// <summary>
        /// Newest completion first, then call UUID descending.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("results")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vapi.CallHealthDashboardGoalCallDTO> Results { get; set; }

        /// <summary>
        /// Continues the list after the last result; absent on the last page.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nextCursor")]
        public string? NextCursor { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CallHealthDashboardGoalCallsResponseDTO" /> class.
        /// </summary>
        /// <param name="results">
        /// Newest completion first, then call UUID descending.
        /// </param>
        /// <param name="nextCursor">
        /// Continues the list after the last result; absent on the last page.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CallHealthDashboardGoalCallsResponseDTO(
            global::System.Collections.Generic.IList<global::Vapi.CallHealthDashboardGoalCallDTO> results,
            string? nextCursor)
        {
            this.Results = results ?? throw new global::System.ArgumentNullException(nameof(results));
            this.NextCursor = nextCursor;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CallHealthDashboardGoalCallsResponseDTO" /> class.
        /// </summary>
        public CallHealthDashboardGoalCallsResponseDTO()
        {
        }

    }
}