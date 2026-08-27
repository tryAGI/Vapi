
#nullable enable

namespace Vapi
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CampaignContactCounters
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pending")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Pending { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dispatched")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Dispatched { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completed")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Completed { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("failed")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Failed { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("skipped")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Skipped { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("predialFailed")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double PredialFailed { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CampaignContactCounters" /> class.
        /// </summary>
        /// <param name="pending"></param>
        /// <param name="dispatched"></param>
        /// <param name="completed"></param>
        /// <param name="failed"></param>
        /// <param name="skipped"></param>
        /// <param name="predialFailed"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CampaignContactCounters(
            double pending,
            double dispatched,
            double completed,
            double failed,
            double skipped,
            double predialFailed)
        {
            this.Pending = pending;
            this.Dispatched = dispatched;
            this.Completed = completed;
            this.Failed = failed;
            this.Skipped = skipped;
            this.PredialFailed = predialFailed;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CampaignContactCounters" /> class.
        /// </summary>
        public CampaignContactCounters()
        {
        }

    }
}