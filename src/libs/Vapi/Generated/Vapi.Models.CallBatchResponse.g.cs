
#nullable enable

namespace Vapi
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CallBatchResponse
    {
        /// <summary>
        /// Subscription limits at the end of this batch
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subscriptionLimits")]
        public global::Vapi.SubscriptionLimits? SubscriptionLimits { get; set; }

        /// <summary>
        /// This is the list of calls that were created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("results")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vapi.Call> Results { get; set; }

        /// <summary>
        /// This is the list of calls that failed to be created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("errors")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vapi.CallBatchError> Errors { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CallBatchResponse" /> class.
        /// </summary>
        /// <param name="subscriptionLimits">
        /// Subscription limits at the end of this batch
        /// </param>
        /// <param name="results">
        /// This is the list of calls that were created.
        /// </param>
        /// <param name="errors">
        /// This is the list of calls that failed to be created.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CallBatchResponse(
            global::System.Collections.Generic.IList<global::Vapi.Call> results,
            global::System.Collections.Generic.IList<global::Vapi.CallBatchError> errors,
            global::Vapi.SubscriptionLimits? subscriptionLimits)
        {
            this.Results = results ?? throw new global::System.ArgumentNullException(nameof(results));
            this.Errors = errors ?? throw new global::System.ArgumentNullException(nameof(errors));
            this.SubscriptionLimits = subscriptionLimits;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CallBatchResponse" /> class.
        /// </summary>
        public CallBatchResponse()
        {
        }
    }
}