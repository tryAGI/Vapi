
#nullable enable

namespace Vapi
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CallHealthDashboardIntakeCoverageDTO
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deliveryMode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.CallHealthDashboardIntakeCoverageDTODeliveryModeJsonConverter))]
        public global::Vapi.CallHealthDashboardIntakeCoverageDTODeliveryMode DeliveryMode { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("endToEndCoverage")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.CallHealthDashboardIntakeCoverageDTOEndToEndCoverageJsonConverter))]
        public global::Vapi.CallHealthDashboardIntakeCoverageDTOEndToEndCoverage EndToEndCoverage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CallHealthDashboardIntakeCoverageDTO" /> class.
        /// </summary>
        /// <param name="deliveryMode"></param>
        /// <param name="endToEndCoverage"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CallHealthDashboardIntakeCoverageDTO(
            global::Vapi.CallHealthDashboardIntakeCoverageDTODeliveryMode deliveryMode,
            global::Vapi.CallHealthDashboardIntakeCoverageDTOEndToEndCoverage endToEndCoverage)
        {
            this.DeliveryMode = deliveryMode;
            this.EndToEndCoverage = endToEndCoverage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CallHealthDashboardIntakeCoverageDTO" /> class.
        /// </summary>
        public CallHealthDashboardIntakeCoverageDTO()
        {
        }

    }
}