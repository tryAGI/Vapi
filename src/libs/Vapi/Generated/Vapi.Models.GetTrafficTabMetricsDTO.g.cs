
#nullable enable

namespace Vapi
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GetTrafficTabMetricsDTO
    {
        /// <summary>
        /// The assistant whose per-version traffic metrics to return.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assistantId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AssistantId { get; set; }

        /// <summary>
        /// Start of the metrics window (inclusive), ISO 8601 datetime.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("from")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime From { get; set; }

        /// <summary>
        /// End of the metrics window (exclusive), ISO 8601 datetime. Must be later than from, and the window may hold at most 2000 buckets of the requested width.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("to")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime To { get; set; }

        /// <summary>
        /// Bucket size for the timeseries. Defaults to 'day'.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bucket")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.GetTrafficTabMetricsDTOBucketJsonConverter))]
        public global::Vapi.GetTrafficTabMetricsDTOBucket? Bucket { get; set; }

        /// <summary>
        /// Structured output ids to aggregate per version, as an array or a comma-separated string. At most 5.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("structuredOutputIds")]
        public global::System.Collections.Generic.IList<global::System.Guid>? StructuredOutputIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetTrafficTabMetricsDTO" /> class.
        /// </summary>
        /// <param name="assistantId">
        /// The assistant whose per-version traffic metrics to return.
        /// </param>
        /// <param name="from">
        /// Start of the metrics window (inclusive), ISO 8601 datetime.
        /// </param>
        /// <param name="to">
        /// End of the metrics window (exclusive), ISO 8601 datetime. Must be later than from, and the window may hold at most 2000 buckets of the requested width.
        /// </param>
        /// <param name="bucket">
        /// Bucket size for the timeseries. Defaults to 'day'.
        /// </param>
        /// <param name="structuredOutputIds">
        /// Structured output ids to aggregate per version, as an array or a comma-separated string. At most 5.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetTrafficTabMetricsDTO(
            string assistantId,
            global::System.DateTime from,
            global::System.DateTime to,
            global::Vapi.GetTrafficTabMetricsDTOBucket? bucket,
            global::System.Collections.Generic.IList<global::System.Guid>? structuredOutputIds)
        {
            this.AssistantId = assistantId ?? throw new global::System.ArgumentNullException(nameof(assistantId));
            this.From = from;
            this.To = to;
            this.Bucket = bucket;
            this.StructuredOutputIds = structuredOutputIds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetTrafficTabMetricsDTO" /> class.
        /// </summary>
        public GetTrafficTabMetricsDTO()
        {
        }

    }
}