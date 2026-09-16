
#nullable enable

namespace Vapi
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class OrgLimitsResponseDTO
    {
        /// <summary>
        /// Call concurrency limits for the subscription. Unlike the call create response, remainingConcurrentCalls does not reserve a slot for a new call: it is the plain headroom at the time of the read. Covers the concurrency gate only — credits, frozen subscriptions, included minutes, and the billing limit are not reflected here, so call create can still refuse. Omitted when the limits could not be computed, and for an org with no subscription at all (legacy ungated orgs), which has no concurrency ceiling.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subscriptionLimits")]
        public global::Vapi.OrgConcurrencyLimitsDTO? SubscriptionLimits { get; set; }

        /// <summary>
        /// API rate limit usage for the org. Approximate, per region, and scoped to the current minute. Omitted when the limit information is unavailable.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("apiLimits")]
        public global::Vapi.OrgApiLimitsDTO? ApiLimits { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OrgLimitsResponseDTO" /> class.
        /// </summary>
        /// <param name="subscriptionLimits">
        /// Call concurrency limits for the subscription. Unlike the call create response, remainingConcurrentCalls does not reserve a slot for a new call: it is the plain headroom at the time of the read. Covers the concurrency gate only — credits, frozen subscriptions, included minutes, and the billing limit are not reflected here, so call create can still refuse. Omitted when the limits could not be computed, and for an org with no subscription at all (legacy ungated orgs), which has no concurrency ceiling.
        /// </param>
        /// <param name="apiLimits">
        /// API rate limit usage for the org. Approximate, per region, and scoped to the current minute. Omitted when the limit information is unavailable.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OrgLimitsResponseDTO(
            global::Vapi.OrgConcurrencyLimitsDTO? subscriptionLimits,
            global::Vapi.OrgApiLimitsDTO? apiLimits)
        {
            this.SubscriptionLimits = subscriptionLimits;
            this.ApiLimits = apiLimits;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrgLimitsResponseDTO" /> class.
        /// </summary>
        public OrgLimitsResponseDTO()
        {
        }

    }
}