
#nullable enable

namespace Vapi
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class TrafficTabMetricsWindowDTO
    {
        /// <summary>
        /// Start of the window (inclusive), ISO 8601.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("from")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string From { get; set; }

        /// <summary>
        /// End of the window (exclusive), ISO 8601.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("to")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string To { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bucket")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.TrafficTabMetricsWindowDTOBucketJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vapi.TrafficTabMetricsWindowDTOBucket Bucket { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TrafficTabMetricsWindowDTO" /> class.
        /// </summary>
        /// <param name="from">
        /// Start of the window (inclusive), ISO 8601.
        /// </param>
        /// <param name="to">
        /// End of the window (exclusive), ISO 8601.
        /// </param>
        /// <param name="bucket"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TrafficTabMetricsWindowDTO(
            string from,
            string to,
            global::Vapi.TrafficTabMetricsWindowDTOBucket bucket)
        {
            this.From = from ?? throw new global::System.ArgumentNullException(nameof(from));
            this.To = to ?? throw new global::System.ArgumentNullException(nameof(to));
            this.Bucket = bucket;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TrafficTabMetricsWindowDTO" /> class.
        /// </summary>
        public TrafficTabMetricsWindowDTO()
        {
        }

    }
}