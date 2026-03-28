
#nullable enable

namespace Vapi
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ServerMessageResponse
    {
        /// <summary>
        /// This is the response that is expected from the server to the message.<br/>
        /// Note: Most messages don't expect a response. Only "assistant-request", "tool-calls" and "transfer-destination-request" do.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("messageResponse")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.ServerMessageResponseAssistantRequest, global::Vapi.ServerMessageResponseHandoffDestinationRequest, global::Vapi.ServerMessageResponseKnowledgeBaseRequest, global::Vapi.ServerMessageResponseToolCalls, global::Vapi.ServerMessageResponseTransferDestinationRequest, global::Vapi.ServerMessageResponseVoiceRequest, global::Vapi.ServerMessageResponseCallEndpointingRequest>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vapi.OneOf<global::Vapi.ServerMessageResponseAssistantRequest, global::Vapi.ServerMessageResponseHandoffDestinationRequest, global::Vapi.ServerMessageResponseKnowledgeBaseRequest, global::Vapi.ServerMessageResponseToolCalls, global::Vapi.ServerMessageResponseTransferDestinationRequest, global::Vapi.ServerMessageResponseVoiceRequest, global::Vapi.ServerMessageResponseCallEndpointingRequest> MessageResponse { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ServerMessageResponse" /> class.
        /// </summary>
        /// <param name="messageResponse">
        /// This is the response that is expected from the server to the message.<br/>
        /// Note: Most messages don't expect a response. Only "assistant-request", "tool-calls" and "transfer-destination-request" do.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ServerMessageResponse(
            global::Vapi.OneOf<global::Vapi.ServerMessageResponseAssistantRequest, global::Vapi.ServerMessageResponseHandoffDestinationRequest, global::Vapi.ServerMessageResponseKnowledgeBaseRequest, global::Vapi.ServerMessageResponseToolCalls, global::Vapi.ServerMessageResponseTransferDestinationRequest, global::Vapi.ServerMessageResponseVoiceRequest, global::Vapi.ServerMessageResponseCallEndpointingRequest> messageResponse)
        {
            this.MessageResponse = messageResponse;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ServerMessageResponse" /> class.
        /// </summary>
        public ServerMessageResponse()
        {
        }
    }
}