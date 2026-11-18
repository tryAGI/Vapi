
#nullable enable

namespace Vapi
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CallHealthDashboardSeriesPageDTO
    {
        /// <summary>
        /// Full resolved completion window used by every total, rate and coverage count.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("window")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vapi.CallHealthDashboardWindowDTO Window { get; set; }

        /// <summary>
        /// Clipped completion window represented by this page's daily buckets.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pageWindow")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vapi.CallHealthDashboardWindowDTO PageWindow { get; set; }

        /// <summary>
        /// Continue chart dates only; independent of the issue-row nextCursor.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nextCursor")]
        public string? NextCursor { get; set; }

        /// <summary>
        /// The requested time zone whose midnights bound this page and label its dates; absent for UTC.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timeZone")]
        public string? TimeZone { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CallHealthDashboardSeriesPageDTO" /> class.
        /// </summary>
        /// <param name="window">
        /// Full resolved completion window used by every total, rate and coverage count.
        /// </param>
        /// <param name="pageWindow">
        /// Clipped completion window represented by this page's daily buckets.
        /// </param>
        /// <param name="nextCursor">
        /// Continue chart dates only; independent of the issue-row nextCursor.
        /// </param>
        /// <param name="timeZone">
        /// The requested time zone whose midnights bound this page and label its dates; absent for UTC.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CallHealthDashboardSeriesPageDTO(
            global::Vapi.CallHealthDashboardWindowDTO window,
            global::Vapi.CallHealthDashboardWindowDTO pageWindow,
            string? nextCursor,
            string? timeZone)
        {
            this.Window = window ?? throw new global::System.ArgumentNullException(nameof(window));
            this.PageWindow = pageWindow ?? throw new global::System.ArgumentNullException(nameof(pageWindow));
            this.NextCursor = nextCursor;
            this.TimeZone = timeZone;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CallHealthDashboardSeriesPageDTO" /> class.
        /// </summary>
        public CallHealthDashboardSeriesPageDTO()
        {
        }

    }
}