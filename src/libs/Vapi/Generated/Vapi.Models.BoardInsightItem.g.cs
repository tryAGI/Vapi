
#nullable enable

namespace Vapi
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BoardInsightItem
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.BoardInsightItemTypeJsonConverter))]
        public global::Vapi.BoardInsightItemType Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("insightId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string InsightId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("systemKey")]
        public string? SystemKey { get; set; }

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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BoardInsightItem" /> class.
        /// </summary>
        /// <param name="insightId"></param>
        /// <param name="position"></param>
        /// <param name="size"></param>
        /// <param name="type"></param>
        /// <param name="systemKey"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BoardInsightItem(
            string insightId,
            global::Vapi.BoardItemPosition position,
            global::Vapi.BoardItemSize size,
            global::Vapi.BoardInsightItemType type,
            string? systemKey)
        {
            this.Type = type;
            this.InsightId = insightId ?? throw new global::System.ArgumentNullException(nameof(insightId));
            this.SystemKey = systemKey;
            this.Position = position ?? throw new global::System.ArgumentNullException(nameof(position));
            this.Size = size ?? throw new global::System.ArgumentNullException(nameof(size));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BoardInsightItem" /> class.
        /// </summary>
        public BoardInsightItem()
        {
        }

    }
}