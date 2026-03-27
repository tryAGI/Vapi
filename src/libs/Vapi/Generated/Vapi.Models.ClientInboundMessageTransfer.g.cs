
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vapi
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ClientInboundMessageTransfer
    {
        /// <summary>
        /// This is the type of the message. Send "transfer" message to transfer the call to a destination.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.ClientInboundMessageTransferTypeJsonConverter))]
        public global::Vapi.ClientInboundMessageTransferType Type { get; set; }

        /// <summary>
        /// This is the destination to transfer the call to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("destination")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.TransferDestinationNumber, global::Vapi.TransferDestinationSip>))]
        public global::Vapi.OneOf<global::Vapi.TransferDestinationNumber, global::Vapi.TransferDestinationSip>? Destination { get; set; }

        /// <summary>
        /// This is the content to say.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        public string? Content { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ClientInboundMessageTransfer" /> class.
        /// </summary>
        /// <param name="type">
        /// This is the type of the message. Send "transfer" message to transfer the call to a destination.
        /// </param>
        /// <param name="destination">
        /// This is the destination to transfer the call to.
        /// </param>
        /// <param name="content">
        /// This is the content to say.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ClientInboundMessageTransfer(
            global::Vapi.ClientInboundMessageTransferType type,
            global::Vapi.OneOf<global::Vapi.TransferDestinationNumber, global::Vapi.TransferDestinationSip>? destination,
            string? content)
        {
            this.Type = type;
            this.Destination = destination;
            this.Content = content;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClientInboundMessageTransfer" /> class.
        /// </summary>
        public ClientInboundMessageTransfer()
        {
        }
    }
}