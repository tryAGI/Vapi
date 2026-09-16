
#nullable enable

namespace Vapi
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class OrgConcurrencyLimitsDTO
    {
        /// <summary>
        /// True when the org is at or over its concurrency limit at the time of the read. This is a status read, not an admission decision: no call was evaluated and no slot is reserved.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("concurrencyBlocked")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool ConcurrencyBlocked { get; set; }

        /// <summary>
        /// Maximum number of concurrent calls the subscription allows, at the time of the read. Computed as the subscription's included plus purchased concurrency, defaulting to the initial allowance when either is unset; call create derives its own figure and can differ for subscriptions with an unset allowance.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("concurrencyLimit")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double ConcurrencyLimit { get; set; }

        /// <summary>
        /// Plain concurrent-call headroom at the time of the read, floored at zero. Unlike the call create response, this does not include or reserve a slot for a new call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("remainingConcurrentCalls")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double RemainingConcurrentCalls { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OrgConcurrencyLimitsDTO" /> class.
        /// </summary>
        /// <param name="concurrencyBlocked">
        /// True when the org is at or over its concurrency limit at the time of the read. This is a status read, not an admission decision: no call was evaluated and no slot is reserved.
        /// </param>
        /// <param name="concurrencyLimit">
        /// Maximum number of concurrent calls the subscription allows, at the time of the read. Computed as the subscription's included plus purchased concurrency, defaulting to the initial allowance when either is unset; call create derives its own figure and can differ for subscriptions with an unset allowance.
        /// </param>
        /// <param name="remainingConcurrentCalls">
        /// Plain concurrent-call headroom at the time of the read, floored at zero. Unlike the call create response, this does not include or reserve a slot for a new call.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OrgConcurrencyLimitsDTO(
            bool concurrencyBlocked,
            double concurrencyLimit,
            double remainingConcurrentCalls)
        {
            this.ConcurrencyBlocked = concurrencyBlocked;
            this.ConcurrencyLimit = concurrencyLimit;
            this.RemainingConcurrentCalls = remainingConcurrentCalls;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrgConcurrencyLimitsDTO" /> class.
        /// </summary>
        public OrgConcurrencyLimitsDTO()
        {
        }

    }
}