
#nullable enable

namespace Vapi
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SimulationOnboardingSuiteCoverageDTO
    {
        /// <summary>
        /// Requirements at least one simulation covers.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("covered")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Covered { get; set; }

        /// <summary>
        /// Requirements in the agreed draft.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Total { get; set; }

        /// <summary>
        /// Requirements no simulation covers, and why.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gaps")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vapi.SimulationOnboardingCoverageGapDTO> Gaps { get; set; }

        /// <summary>
        /// Planned scenarios an edit with `retryFailed` would regenerate.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("retryable")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Retryable { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SimulationOnboardingSuiteCoverageDTO" /> class.
        /// </summary>
        /// <param name="covered">
        /// Requirements at least one simulation covers.
        /// </param>
        /// <param name="total">
        /// Requirements in the agreed draft.
        /// </param>
        /// <param name="gaps">
        /// Requirements no simulation covers, and why.
        /// </param>
        /// <param name="retryable">
        /// Planned scenarios an edit with `retryFailed` would regenerate.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SimulationOnboardingSuiteCoverageDTO(
            double covered,
            double total,
            global::System.Collections.Generic.IList<global::Vapi.SimulationOnboardingCoverageGapDTO> gaps,
            double retryable)
        {
            this.Covered = covered;
            this.Total = total;
            this.Gaps = gaps ?? throw new global::System.ArgumentNullException(nameof(gaps));
            this.Retryable = retryable;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SimulationOnboardingSuiteCoverageDTO" /> class.
        /// </summary>
        public SimulationOnboardingSuiteCoverageDTO()
        {
        }

    }
}