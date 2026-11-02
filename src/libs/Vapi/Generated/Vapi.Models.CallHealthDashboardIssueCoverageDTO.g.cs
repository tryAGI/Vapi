
#nullable enable

namespace Vapi
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CallHealthDashboardIssueCoverageDTO
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.CallHealthDashboardIssueCoverageDTOStateJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vapi.CallHealthDashboardIssueCoverageDTOState State { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("asOf")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime AsOf { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CallHealthDashboardIssueCoverageDTO" /> class.
        /// </summary>
        /// <param name="state"></param>
        /// <param name="asOf"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CallHealthDashboardIssueCoverageDTO(
            global::Vapi.CallHealthDashboardIssueCoverageDTOState state,
            global::System.DateTime asOf)
        {
            this.State = state;
            this.AsOf = asOf;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CallHealthDashboardIssueCoverageDTO" /> class.
        /// </summary>
        public CallHealthDashboardIssueCoverageDTO()
        {
        }

    }
}