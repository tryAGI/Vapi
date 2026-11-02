
#nullable enable

namespace Vapi
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CallHealthDashboardIssueDailyDTO
    {
        /// <summary>
        /// UTC calendar date, with boundary buckets clipped to the requested window.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("date")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime Date { get; set; }

        /// <summary>
        /// Distinct visible calls matching this issue in the bucket.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("affectedCallCount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long AffectedCallCount { get; set; }

        /// <summary>
        /// All accepted current-goal outcomes for the issue's assistant in the bucket.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("analyzedCallCount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long AnalyzedCallCount { get; set; }

        /// <summary>
        /// affectedCallCount / analyzedCallCount; omitted for a zero denominator.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("affectedCallRate")]
        public double? AffectedCallRate { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CallHealthDashboardIssueDailyDTO" /> class.
        /// </summary>
        /// <param name="date">
        /// UTC calendar date, with boundary buckets clipped to the requested window.
        /// </param>
        /// <param name="affectedCallCount">
        /// Distinct visible calls matching this issue in the bucket.
        /// </param>
        /// <param name="analyzedCallCount">
        /// All accepted current-goal outcomes for the issue's assistant in the bucket.
        /// </param>
        /// <param name="affectedCallRate">
        /// affectedCallCount / analyzedCallCount; omitted for a zero denominator.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CallHealthDashboardIssueDailyDTO(
            global::System.DateTime date,
            long affectedCallCount,
            long analyzedCallCount,
            double? affectedCallRate)
        {
            this.Date = date;
            this.AffectedCallCount = affectedCallCount;
            this.AnalyzedCallCount = analyzedCallCount;
            this.AffectedCallRate = affectedCallRate;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CallHealthDashboardIssueDailyDTO" /> class.
        /// </summary>
        public CallHealthDashboardIssueDailyDTO()
        {
        }

    }
}