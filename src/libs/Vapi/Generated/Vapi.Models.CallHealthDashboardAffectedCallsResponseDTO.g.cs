
#nullable enable

namespace Vapi
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CallHealthDashboardAffectedCallsResponseDTO
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("results")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vapi.CallHealthDashboardAffectedCallDTO> Results { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nextCursor")]
        public string? NextCursor { get; set; }

        /// <summary>
        ///
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
        /// Initializes a new instance of the <see cref="CallHealthDashboardAffectedCallsResponseDTO" /> class.
        /// </summary>
        /// <param name="results"></param>
        /// <param name="coverage"></param>
        /// <param name="nextCursor"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CallHealthDashboardAffectedCallsResponseDTO(
            global::System.Collections.Generic.IList<global::Vapi.CallHealthDashboardAffectedCallDTO> results,
            global::Vapi.CallHealthDashboardCoverageDTO coverage,
            string? nextCursor)
        {
            this.Results = results ?? throw new global::System.ArgumentNullException(nameof(results));
            this.NextCursor = nextCursor;
            this.Coverage = coverage ?? throw new global::System.ArgumentNullException(nameof(coverage));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CallHealthDashboardAffectedCallsResponseDTO" /> class.
        /// </summary>
        public CallHealthDashboardAffectedCallsResponseDTO()
        {
        }

    }
}