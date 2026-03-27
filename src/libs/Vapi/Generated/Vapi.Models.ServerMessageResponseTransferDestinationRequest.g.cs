
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vapi
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ServerMessageResponseTransferDestinationRequest
    {
        /// <summary>
        /// This is the destination you'd like the call to be transferred to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("destination")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.TransferDestinationAssistant, global::Vapi.TransferDestinationNumber, global::Vapi.TransferDestinationSip>))]
        public global::Vapi.OneOf<global::Vapi.TransferDestinationAssistant, global::Vapi.TransferDestinationNumber, global::Vapi.TransferDestinationSip>? Destination { get; set; }

        /// <summary>
        /// This is the message that will be spoken to the user as the tool is running.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.ToolMessageStart, global::Vapi.ToolMessageComplete, global::Vapi.ToolMessageFailed, global::Vapi.ToolMessageDelayed>))]
        public global::Vapi.OneOf<global::Vapi.ToolMessageStart, global::Vapi.ToolMessageComplete, global::Vapi.ToolMessageFailed, global::Vapi.ToolMessageDelayed>? Message { get; set; }

        /// <summary>
        /// This is the error message if the transfer should not be made.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public string? Error { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ServerMessageResponseTransferDestinationRequest" /> class.
        /// </summary>
        /// <param name="destination">
        /// This is the destination you'd like the call to be transferred to.
        /// </param>
        /// <param name="message">
        /// This is the message that will be spoken to the user as the tool is running.
        /// </param>
        /// <param name="error">
        /// This is the error message if the transfer should not be made.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ServerMessageResponseTransferDestinationRequest(
            global::Vapi.OneOf<global::Vapi.TransferDestinationAssistant, global::Vapi.TransferDestinationNumber, global::Vapi.TransferDestinationSip>? destination,
            global::Vapi.OneOf<global::Vapi.ToolMessageStart, global::Vapi.ToolMessageComplete, global::Vapi.ToolMessageFailed, global::Vapi.ToolMessageDelayed>? message,
            string? error)
        {
            this.Destination = destination;
            this.Message = message;
            this.Error = error;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ServerMessageResponseTransferDestinationRequest" /> class.
        /// </summary>
        public ServerMessageResponseTransferDestinationRequest()
        {
        }
    }
}