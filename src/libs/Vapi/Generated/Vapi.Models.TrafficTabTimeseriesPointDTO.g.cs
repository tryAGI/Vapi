
#nullable enable

namespace Vapi
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class TrafficTabTimeseriesPointDTO
    {
        /// <summary>
        /// Start of the bucket, ISO 8601 (UTC).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bucketStart")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BucketStart { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("calls")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Calls { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("durationSecondsMean")]
        public double? DurationSecondsMean { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("costPerMinuteMean")]
        public double? CostPerMinuteMean { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("turnLatencyMsMean")]
        public double? TurnLatencyMsMean { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TrafficTabTimeseriesPointDTO" /> class.
        /// </summary>
        /// <param name="bucketStart">
        /// Start of the bucket, ISO 8601 (UTC).
        /// </param>
        /// <param name="calls"></param>
        /// <param name="durationSecondsMean"></param>
        /// <param name="costPerMinuteMean"></param>
        /// <param name="turnLatencyMsMean"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TrafficTabTimeseriesPointDTO(
            string bucketStart,
            double calls,
            double? durationSecondsMean,
            double? costPerMinuteMean,
            double? turnLatencyMsMean)
        {
            this.BucketStart = bucketStart ?? throw new global::System.ArgumentNullException(nameof(bucketStart));
            this.Calls = calls;
            this.DurationSecondsMean = durationSecondsMean;
            this.CostPerMinuteMean = costPerMinuteMean;
            this.TurnLatencyMsMean = turnLatencyMsMean;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TrafficTabTimeseriesPointDTO" /> class.
        /// </summary>
        public TrafficTabTimeseriesPointDTO()
        {
        }

    }
}