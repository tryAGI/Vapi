
#nullable enable

namespace Vapi
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Board
    {
        /// <summary>
        /// This is the contents of the Board, which is an array of objects defining the type, contents, and position of the widgets on the Board.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("items")]
        public global::System.Collections.Generic.IList<global::Vapi.OneOf<global::Vapi.BoardInsightItem, global::Vapi.BoardMetricWidgetItem>>? Items { get; set; }

        /// <summary>
        /// This is the unique identifier for the Board.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// This is the unique identifier for the org that this Board belongs to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("orgId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OrgId { get; set; }

        /// <summary>
        /// This is the ISO 8601 date-time string of when the Board was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// This is the ISO 8601 date-time string of when the Board was last updated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Server-owned key for system-provisioned boards. User create/update DTOs do<br/>
        /// not accept this field.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("systemKey")]
        public string? SystemKey { get; set; }

        /// <summary>
        /// This is the name of the Board.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// This is the layout of the Board.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("layout")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vapi.BoardLayout Layout { get; set; }

        /// <summary>
        /// This is the timerange override for the board.<br/>
        /// By default, individual insights have their own timerange.<br/>
        /// This is a global override for the board which will be passed to all insights on the board.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timeRangeOverride")]
        public global::Vapi.InsightTimeRangeWithStep? TimeRangeOverride { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Board" /> class.
        /// </summary>
        /// <param name="id">
        /// This is the unique identifier for the Board.
        /// </param>
        /// <param name="orgId">
        /// This is the unique identifier for the org that this Board belongs to.
        /// </param>
        /// <param name="createdAt">
        /// This is the ISO 8601 date-time string of when the Board was created.
        /// </param>
        /// <param name="updatedAt">
        /// This is the ISO 8601 date-time string of when the Board was last updated.
        /// </param>
        /// <param name="name">
        /// This is the name of the Board.
        /// </param>
        /// <param name="layout">
        /// This is the layout of the Board.
        /// </param>
        /// <param name="items">
        /// This is the contents of the Board, which is an array of objects defining the type, contents, and position of the widgets on the Board.
        /// </param>
        /// <param name="systemKey">
        /// Server-owned key for system-provisioned boards. User create/update DTOs do<br/>
        /// not accept this field.
        /// </param>
        /// <param name="timeRangeOverride">
        /// This is the timerange override for the board.<br/>
        /// By default, individual insights have their own timerange.<br/>
        /// This is a global override for the board which will be passed to all insights on the board.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Board(
            string id,
            string orgId,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            string name,
            global::Vapi.BoardLayout layout,
            global::System.Collections.Generic.IList<global::Vapi.OneOf<global::Vapi.BoardInsightItem, global::Vapi.BoardMetricWidgetItem>>? items,
            string? systemKey,
            global::Vapi.InsightTimeRangeWithStep? timeRangeOverride)
        {
            this.Items = items;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.OrgId = orgId ?? throw new global::System.ArgumentNullException(nameof(orgId));
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.SystemKey = systemKey;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Layout = layout ?? throw new global::System.ArgumentNullException(nameof(layout));
            this.TimeRangeOverride = timeRangeOverride;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Board" /> class.
        /// </summary>
        public Board()
        {
        }

    }
}