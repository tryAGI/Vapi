
#nullable enable

namespace Vapi
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ClientInboundMessageSendTransportMessage
    {
        /// <summary>
        /// This is the type of the message. Send "send-transport-message" to send a transport-specific message during the call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.ClientInboundMessageSendTransportMessageTypeJsonConverter))]
        public global::Vapi.ClientInboundMessageSendTransportMessageType Type { get; set; }

        /// <summary>
        /// This is the transport-specific message to send.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.VapiSipTransportMessage, global::Vapi.TwilioTransportMessage>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vapi.OneOf<global::Vapi.VapiSipTransportMessage, global::Vapi.TwilioTransportMessage> Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ClientInboundMessageSendTransportMessage" /> class.
        /// </summary>
        /// <param name="message">
        /// This is the transport-specific message to send.
        /// </param>
        /// <param name="type">
        /// This is the type of the message. Send "send-transport-message" to send a transport-specific message during the call.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ClientInboundMessageSendTransportMessage(
            global::Vapi.OneOf<global::Vapi.VapiSipTransportMessage, global::Vapi.TwilioTransportMessage> message,
            global::Vapi.ClientInboundMessageSendTransportMessageType type)
        {
            this.Type = type;
            this.Message = message;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClientInboundMessageSendTransportMessage" /> class.
        /// </summary>
        public ClientInboundMessageSendTransportMessage()
        {
        }
    }
}