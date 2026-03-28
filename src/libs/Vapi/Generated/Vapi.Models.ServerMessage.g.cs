
#nullable enable

namespace Vapi
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ServerMessage
    {
        /// <summary>
        /// These are all the messages that can be sent to your server before, after and during the call. Configure the messages you'd like to receive in `assistant.serverMessages`.<br/>
        /// The server where the message is sent is determined by the following precedence order:<br/>
        /// 1. `tool.server.url` (if configured, and only for "tool-calls" message)<br/>
        /// 2. `assistant.serverUrl` (if configure)<br/>
        /// 3. `phoneNumber.serverUrl` (if configured)<br/>
        /// 4. `org.serverUrl` (if configured)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.ServerMessageAssistantRequest, global::Vapi.ServerMessageConversationUpdate, global::Vapi.ServerMessageEndOfCallReport, global::Vapi.ServerMessageHandoffDestinationRequest, global::Vapi.ServerMessageHang, global::Vapi.ServerMessageKnowledgeBaseRequest, global::Vapi.ServerMessageModelOutput, global::Vapi.ServerMessagePhoneCallControl, global::Vapi.ServerMessageSpeechUpdate, global::Vapi.ServerMessageStatusUpdate, global::Vapi.ServerMessageToolCalls, global::Vapi.ServerMessageTransferDestinationRequest, global::Vapi.ServerMessageTransferUpdate, global::Vapi.ServerMessageTranscript, global::Vapi.ServerMessageUserInterrupted, global::Vapi.ServerMessageLanguageChangeDetected, global::Vapi.ServerMessageVoiceInput, global::Vapi.ServerMessageVoiceRequest, global::Vapi.ServerMessageCallEndpointingRequest, global::Vapi.ServerMessageChatCreated, global::Vapi.ServerMessageChatDeleted, global::Vapi.ServerMessageSessionCreated, global::Vapi.ServerMessageSessionUpdated, global::Vapi.ServerMessageSessionDeleted, global::Vapi.ServerMessageCallDeleted, global::Vapi.ServerMessageCallDeleteFailed>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vapi.OneOf<global::Vapi.ServerMessageAssistantRequest, global::Vapi.ServerMessageConversationUpdate, global::Vapi.ServerMessageEndOfCallReport, global::Vapi.ServerMessageHandoffDestinationRequest, global::Vapi.ServerMessageHang, global::Vapi.ServerMessageKnowledgeBaseRequest, global::Vapi.ServerMessageModelOutput, global::Vapi.ServerMessagePhoneCallControl, global::Vapi.ServerMessageSpeechUpdate, global::Vapi.ServerMessageStatusUpdate, global::Vapi.ServerMessageToolCalls, global::Vapi.ServerMessageTransferDestinationRequest, global::Vapi.ServerMessageTransferUpdate, global::Vapi.ServerMessageTranscript, global::Vapi.ServerMessageUserInterrupted, global::Vapi.ServerMessageLanguageChangeDetected, global::Vapi.ServerMessageVoiceInput, global::Vapi.ServerMessageVoiceRequest, global::Vapi.ServerMessageCallEndpointingRequest, global::Vapi.ServerMessageChatCreated, global::Vapi.ServerMessageChatDeleted, global::Vapi.ServerMessageSessionCreated, global::Vapi.ServerMessageSessionUpdated, global::Vapi.ServerMessageSessionDeleted, global::Vapi.ServerMessageCallDeleted, global::Vapi.ServerMessageCallDeleteFailed> Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ServerMessage" /> class.
        /// </summary>
        /// <param name="message">
        /// These are all the messages that can be sent to your server before, after and during the call. Configure the messages you'd like to receive in `assistant.serverMessages`.<br/>
        /// The server where the message is sent is determined by the following precedence order:<br/>
        /// 1. `tool.server.url` (if configured, and only for "tool-calls" message)<br/>
        /// 2. `assistant.serverUrl` (if configure)<br/>
        /// 3. `phoneNumber.serverUrl` (if configured)<br/>
        /// 4. `org.serverUrl` (if configured)
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ServerMessage(
            global::Vapi.OneOf<global::Vapi.ServerMessageAssistantRequest, global::Vapi.ServerMessageConversationUpdate, global::Vapi.ServerMessageEndOfCallReport, global::Vapi.ServerMessageHandoffDestinationRequest, global::Vapi.ServerMessageHang, global::Vapi.ServerMessageKnowledgeBaseRequest, global::Vapi.ServerMessageModelOutput, global::Vapi.ServerMessagePhoneCallControl, global::Vapi.ServerMessageSpeechUpdate, global::Vapi.ServerMessageStatusUpdate, global::Vapi.ServerMessageToolCalls, global::Vapi.ServerMessageTransferDestinationRequest, global::Vapi.ServerMessageTransferUpdate, global::Vapi.ServerMessageTranscript, global::Vapi.ServerMessageUserInterrupted, global::Vapi.ServerMessageLanguageChangeDetected, global::Vapi.ServerMessageVoiceInput, global::Vapi.ServerMessageVoiceRequest, global::Vapi.ServerMessageCallEndpointingRequest, global::Vapi.ServerMessageChatCreated, global::Vapi.ServerMessageChatDeleted, global::Vapi.ServerMessageSessionCreated, global::Vapi.ServerMessageSessionUpdated, global::Vapi.ServerMessageSessionDeleted, global::Vapi.ServerMessageCallDeleted, global::Vapi.ServerMessageCallDeleteFailed> message)
        {
            this.Message = message;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ServerMessage" /> class.
        /// </summary>
        public ServerMessage()
        {
        }
    }
}