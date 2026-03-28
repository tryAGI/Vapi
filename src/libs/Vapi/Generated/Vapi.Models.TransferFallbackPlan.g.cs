
#nullable enable

namespace Vapi
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TransferFallbackPlan
    {
        /// <summary>
        /// This is the message the assistant will deliver to the customer if the transfer fails.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.OneOfJsonConverter<string, global::Vapi.CustomMessage>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vapi.OneOf<string, global::Vapi.CustomMessage> Message { get; set; }

        /// <summary>
        /// This controls what happens after delivering the failure message to the customer.<br/>
        /// - true: End the call after delivering the failure message (default)<br/>
        /// - false: Keep the assistant on the call to continue handling the customer's request<br/>
        /// @default true<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("endCallEnabled")]
        public bool? EndCallEnabled { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TransferFallbackPlan" /> class.
        /// </summary>
        /// <param name="message">
        /// This is the message the assistant will deliver to the customer if the transfer fails.
        /// </param>
        /// <param name="endCallEnabled">
        /// This controls what happens after delivering the failure message to the customer.<br/>
        /// - true: End the call after delivering the failure message (default)<br/>
        /// - false: Keep the assistant on the call to continue handling the customer's request<br/>
        /// @default true<br/>
        /// Default Value: true
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TransferFallbackPlan(
            global::Vapi.OneOf<string, global::Vapi.CustomMessage> message,
            bool? endCallEnabled)
        {
            this.Message = message;
            this.EndCallEnabled = endCallEnabled;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TransferFallbackPlan" /> class.
        /// </summary>
        public TransferFallbackPlan()
        {
        }
    }
}