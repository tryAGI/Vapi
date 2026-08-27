
#nullable enable

namespace Vapi
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CampaignCallMetrics
    {
        /// <summary>
        /// This is the number of contacts a call was actually placed for. Contacts<br/>
        /// that were skipped, rejected before dialing, or failed to dispatch are not<br/>
        /// counted — no call existed, so there was nothing to answer.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dialed")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Dialed { get; set; }

        /// <summary>
        /// This is the number of those calls a human picked up. Voicemail does not<br/>
        /// count. Divide by `dialed` for the pick-up rate.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("connected")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Connected { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CampaignCallMetrics" /> class.
        /// </summary>
        /// <param name="dialed">
        /// This is the number of contacts a call was actually placed for. Contacts<br/>
        /// that were skipped, rejected before dialing, or failed to dispatch are not<br/>
        /// counted — no call existed, so there was nothing to answer.
        /// </param>
        /// <param name="connected">
        /// This is the number of those calls a human picked up. Voicemail does not<br/>
        /// count. Divide by `dialed` for the pick-up rate.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CampaignCallMetrics(
            double dialed,
            double connected)
        {
            this.Dialed = dialed;
            this.Connected = connected;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CampaignCallMetrics" /> class.
        /// </summary>
        public CampaignCallMetrics()
        {
        }

    }
}