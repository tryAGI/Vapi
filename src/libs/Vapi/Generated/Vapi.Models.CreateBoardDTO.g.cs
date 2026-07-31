
#nullable enable

namespace Vapi
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateBoardDTO
    {
        /// <summary>
        /// This is the contents of the Board, which is an array of objects defining the type, contents, and position of the widgets on the Board.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("items")]
        public global::System.Collections.Generic.IList<global::Vapi.OneOf<global::Vapi.BoardInsightItem, global::Vapi.BoardMetricWidgetItem>>? Items { get; set; }

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
        /// Initializes a new instance of the <see cref="CreateBoardDTO" /> class.
        /// </summary>
        /// <param name="name">
        /// This is the name of the Board.
        /// </param>
        /// <param name="layout">
        /// This is the layout of the Board.
        /// </param>
        /// <param name="items">
        /// This is the contents of the Board, which is an array of objects defining the type, contents, and position of the widgets on the Board.
        /// </param>
        /// <param name="timeRangeOverride">
        /// This is the timerange override for the board.<br/>
        /// By default, individual insights have their own timerange.<br/>
        /// This is a global override for the board which will be passed to all insights on the board.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateBoardDTO(
            string name,
            global::Vapi.BoardLayout layout,
            global::System.Collections.Generic.IList<global::Vapi.OneOf<global::Vapi.BoardInsightItem, global::Vapi.BoardMetricWidgetItem>>? items,
            global::Vapi.InsightTimeRangeWithStep? timeRangeOverride)
        {
            this.Items = items;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Layout = layout ?? throw new global::System.ArgumentNullException(nameof(layout));
            this.TimeRangeOverride = timeRangeOverride;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateBoardDTO" /> class.
        /// </summary>
        public CreateBoardDTO()
        {
        }

    }
}