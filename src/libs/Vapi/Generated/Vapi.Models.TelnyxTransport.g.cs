
#nullable enable

namespace Vapi
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TelnyxTransport
    {
        /// <summary>
        /// This is the conversation type of the call (ie, voice or chat).<br/>
        /// Default Value: voice
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conversationType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.TelnyxTransportConversationTypeJsonConverter))]
        public global::Vapi.TelnyxTransportConversationType? ConversationType { get; set; }

        /// <summary>
        /// Telnyx transport provider
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.TelnyxTransportProviderJsonConverter))]
        public global::Vapi.TelnyxTransportProvider Provider { get; set; }

        /// <summary>
        /// This is the call control ID of the Telnyx call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("callControlId")]
        public string? CallControlId { get; set; }

        /// <summary>
        /// This is the call leg ID of the Telnyx call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("callLegId")]
        public string? CallLegId { get; set; }

        /// <summary>
        /// This is the call session ID of the Telnyx call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("callSessionId")]
        public string? CallSessionId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TelnyxTransport" /> class.
        /// </summary>
        /// <param name="conversationType">
        /// This is the conversation type of the call (ie, voice or chat).<br/>
        /// Default Value: voice
        /// </param>
        /// <param name="provider">
        /// Telnyx transport provider
        /// </param>
        /// <param name="callControlId">
        /// This is the call control ID of the Telnyx call.
        /// </param>
        /// <param name="callLegId">
        /// This is the call leg ID of the Telnyx call.
        /// </param>
        /// <param name="callSessionId">
        /// This is the call session ID of the Telnyx call.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TelnyxTransport(
            global::Vapi.TelnyxTransportConversationType? conversationType,
            global::Vapi.TelnyxTransportProvider provider,
            string? callControlId,
            string? callLegId,
            string? callSessionId)
        {
            this.ConversationType = conversationType;
            this.Provider = provider;
            this.CallControlId = callControlId;
            this.CallLegId = callLegId;
            this.CallSessionId = callSessionId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TelnyxTransport" /> class.
        /// </summary>
        public TelnyxTransport()
        {
        }

    }
}