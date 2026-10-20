
#nullable enable

namespace Vapi
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class TrafficTabCostPerMinuteDTO
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mean")]
        public double? Mean { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("breakdown")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vapi.TrafficTabCostBreakdownPerMinuteDTO Breakdown { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TrafficTabCostPerMinuteDTO" /> class.
        /// </summary>
        /// <param name="breakdown"></param>
        /// <param name="mean"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TrafficTabCostPerMinuteDTO(
            global::Vapi.TrafficTabCostBreakdownPerMinuteDTO breakdown,
            double? mean)
        {
            this.Mean = mean;
            this.Breakdown = breakdown ?? throw new global::System.ArgumentNullException(nameof(breakdown));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TrafficTabCostPerMinuteDTO" /> class.
        /// </summary>
        public TrafficTabCostPerMinuteDTO()
        {
        }

    }
}