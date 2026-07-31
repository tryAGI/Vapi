
#nullable enable

namespace Vapi
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BoardMetricWidgetItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.BoardMetricWidgetItemTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vapi.BoardMetricWidgetItemType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("position")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vapi.BoardItemPosition Position { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("size")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vapi.BoardItemSize Size { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("insightId")]
        public string? InsightId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("systemKey")]
        public string? SystemKey { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BoardMetricWidgetItem" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="position"></param>
        /// <param name="size"></param>
        /// <param name="insightId"></param>
        /// <param name="systemKey"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BoardMetricWidgetItem(
            global::Vapi.BoardMetricWidgetItemType type,
            global::Vapi.BoardItemPosition position,
            global::Vapi.BoardItemSize size,
            string? insightId,
            string? systemKey)
        {
            this.Type = type;
            this.Position = position ?? throw new global::System.ArgumentNullException(nameof(position));
            this.Size = size ?? throw new global::System.ArgumentNullException(nameof(size));
            this.InsightId = insightId;
            this.SystemKey = systemKey;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BoardMetricWidgetItem" /> class.
        /// </summary>
        public BoardMetricWidgetItem()
        {
        }

    }
}