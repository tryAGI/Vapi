
#nullable enable

namespace Vapi
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class TrafficTabDurationSecondsDTO
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mean")]
        public double? Mean { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stddev")]
        public double? Stddev { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("p50")]
        public double? P50 { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("p95")]
        public double? P95 { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TrafficTabDurationSecondsDTO" /> class.
        /// </summary>
        /// <param name="mean"></param>
        /// <param name="stddev"></param>
        /// <param name="p50"></param>
        /// <param name="p95"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TrafficTabDurationSecondsDTO(
            double? mean,
            double? stddev,
            double? p50,
            double? p95)
        {
            this.Mean = mean;
            this.Stddev = stddev;
            this.P50 = p50;
            this.P95 = p95;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TrafficTabDurationSecondsDTO" /> class.
        /// </summary>
        public TrafficTabDurationSecondsDTO()
        {
        }

    }
}