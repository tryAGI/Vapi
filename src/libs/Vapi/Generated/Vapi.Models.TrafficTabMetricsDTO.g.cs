
#nullable enable

namespace Vapi
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class TrafficTabMetricsDTO
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("window")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vapi.TrafficTabMetricsWindowDTO Window { get; set; }

        /// <summary>
        /// All calls for the assistant in the window, every version.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("totalCalls")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double TotalCalls { get; set; }

        /// <summary>
        /// The allocation currently governing the assistant. Null when traffic splitting was never configured.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("currentAllocation")]
        public global::Vapi.TrafficAllocation? CurrentAllocation { get; set; }

        /// <summary>
        /// One row per version with calls in the window, plus the unversioned row when it has any. Ordered by calls descending, then by version label (numeric-aware), the unversioned row last among equals.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("versions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vapi.TrafficTabVersionMetricsDTO> Versions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TrafficTabMetricsDTO" /> class.
        /// </summary>
        /// <param name="window"></param>
        /// <param name="totalCalls">
        /// All calls for the assistant in the window, every version.
        /// </param>
        /// <param name="versions">
        /// One row per version with calls in the window, plus the unversioned row when it has any. Ordered by calls descending, then by version label (numeric-aware), the unversioned row last among equals.
        /// </param>
        /// <param name="currentAllocation">
        /// The allocation currently governing the assistant. Null when traffic splitting was never configured.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TrafficTabMetricsDTO(
            global::Vapi.TrafficTabMetricsWindowDTO window,
            double totalCalls,
            global::System.Collections.Generic.IList<global::Vapi.TrafficTabVersionMetricsDTO> versions,
            global::Vapi.TrafficAllocation? currentAllocation)
        {
            this.Window = window ?? throw new global::System.ArgumentNullException(nameof(window));
            this.TotalCalls = totalCalls;
            this.CurrentAllocation = currentAllocation;
            this.Versions = versions ?? throw new global::System.ArgumentNullException(nameof(versions));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TrafficTabMetricsDTO" /> class.
        /// </summary>
        public TrafficTabMetricsDTO()
        {
        }

    }
}