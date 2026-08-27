
#nullable enable

namespace Vapi
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CampaignPredialPlan
    {
        /// <summary>
        /// Whether the pre-dial eligibility webhook is active. Defaults to true when `predialPlan` is set. Set to false to keep the plan without running the webhook (useful when duplicating a campaign).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CampaignPredialPlan" /> class.
        /// </summary>
        /// <param name="enabled">
        /// Whether the pre-dial eligibility webhook is active. Defaults to true when `predialPlan` is set. Set to false to keep the plan without running the webhook (useful when duplicating a campaign).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CampaignPredialPlan(
            bool? enabled)
        {
            this.Enabled = enabled;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CampaignPredialPlan" /> class.
        /// </summary>
        public CampaignPredialPlan()
        {
        }

    }
}