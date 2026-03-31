
#nullable enable

namespace Vapi
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ClientMessage
    {
        /// <summary>
        /// These are all the messages that can be sent to the client-side SDKs during the call. Configure the messages you'd like to receive in `assistant.clientMessages`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.ClientMessageWorkflowNodeStarted, global::Vapi.ClientMessageAssistantStarted, global::Vapi.ClientMessageConversationUpdate, global::Vapi.ClientMessageHang, global::Vapi.ClientMessageMetadata, global::Vapi.ClientMessageModelOutput, global::Vapi.ClientMessageSpeechUpdate, global::Vapi.ClientMessageTranscript, global::Vapi.ClientMessageToolCalls, global::Vapi.ClientMessageToolCallsResult, global::Vapi.ClientMessageTransferUpdate, global::Vapi.ClientMessageUserInterrupted, global::Vapi.ClientMessageLanguageChangeDetected, global::Vapi.ClientMessageVoiceInput, global::Vapi.ClientMessageAssistantSpeech, global::Vapi.ClientMessageChatCreated, global::Vapi.ClientMessageChatDeleted, global::Vapi.ClientMessageSessionCreated, global::Vapi.ClientMessageSessionUpdated, global::Vapi.ClientMessageSessionDeleted, global::Vapi.ClientMessageCallDeleted, global::Vapi.ClientMessageCallDeleteFailed>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vapi.OneOf<global::Vapi.ClientMessageWorkflowNodeStarted, global::Vapi.ClientMessageAssistantStarted, global::Vapi.ClientMessageConversationUpdate, global::Vapi.ClientMessageHang, global::Vapi.ClientMessageMetadata, global::Vapi.ClientMessageModelOutput, global::Vapi.ClientMessageSpeechUpdate, global::Vapi.ClientMessageTranscript, global::Vapi.ClientMessageToolCalls, global::Vapi.ClientMessageToolCallsResult, global::Vapi.ClientMessageTransferUpdate, global::Vapi.ClientMessageUserInterrupted, global::Vapi.ClientMessageLanguageChangeDetected, global::Vapi.ClientMessageVoiceInput, global::Vapi.ClientMessageAssistantSpeech, global::Vapi.ClientMessageChatCreated, global::Vapi.ClientMessageChatDeleted, global::Vapi.ClientMessageSessionCreated, global::Vapi.ClientMessageSessionUpdated, global::Vapi.ClientMessageSessionDeleted, global::Vapi.ClientMessageCallDeleted, global::Vapi.ClientMessageCallDeleteFailed> Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ClientMessage" /> class.
        /// </summary>
        /// <param name="message">
        /// These are all the messages that can be sent to the client-side SDKs during the call. Configure the messages you'd like to receive in `assistant.clientMessages`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ClientMessage(
            global::Vapi.OneOf<global::Vapi.ClientMessageWorkflowNodeStarted, global::Vapi.ClientMessageAssistantStarted, global::Vapi.ClientMessageConversationUpdate, global::Vapi.ClientMessageHang, global::Vapi.ClientMessageMetadata, global::Vapi.ClientMessageModelOutput, global::Vapi.ClientMessageSpeechUpdate, global::Vapi.ClientMessageTranscript, global::Vapi.ClientMessageToolCalls, global::Vapi.ClientMessageToolCallsResult, global::Vapi.ClientMessageTransferUpdate, global::Vapi.ClientMessageUserInterrupted, global::Vapi.ClientMessageLanguageChangeDetected, global::Vapi.ClientMessageVoiceInput, global::Vapi.ClientMessageAssistantSpeech, global::Vapi.ClientMessageChatCreated, global::Vapi.ClientMessageChatDeleted, global::Vapi.ClientMessageSessionCreated, global::Vapi.ClientMessageSessionUpdated, global::Vapi.ClientMessageSessionDeleted, global::Vapi.ClientMessageCallDeleted, global::Vapi.ClientMessageCallDeleteFailed> message)
        {
            this.Message = message;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClientMessage" /> class.
        /// </summary>
        public ClientMessage()
        {
        }
    }
}