
#nullable enable

namespace Vapi
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VonageTransport
    {
        /// <summary>
        /// This is the conversation type of the call (ie, voice or chat).<br/>
        /// Default Value: voice
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conversationType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.VonageTransportConversationTypeJsonConverter))]
        public global::Vapi.VonageTransportConversationType? ConversationType { get; set; }

        /// <summary>
        /// Vonage transport provider
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.VonageTransportProviderJsonConverter))]
        public global::Vapi.VonageTransportProvider Provider { get; set; }

        /// <summary>
        /// This is the conversation UUID of the Vonage call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conversationUUID")]
        public string? ConversationUUID { get; set; }

        /// <summary>
        /// This is the call ID of the Vonage call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("callUUID")]
        public string? CallUUID { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VonageTransport" /> class.
        /// </summary>
        /// <param name="conversationType">
        /// This is the conversation type of the call (ie, voice or chat).<br/>
        /// Default Value: voice
        /// </param>
        /// <param name="provider">
        /// Vonage transport provider
        /// </param>
        /// <param name="conversationUUID">
        /// This is the conversation UUID of the Vonage call.
        /// </param>
        /// <param name="callUUID">
        /// This is the call ID of the Vonage call.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VonageTransport(
            global::Vapi.VonageTransportConversationType? conversationType,
            global::Vapi.VonageTransportProvider provider,
            string? conversationUUID,
            string? callUUID)
        {
            this.ConversationType = conversationType;
            this.Provider = provider;
            this.ConversationUUID = conversationUUID;
            this.CallUUID = callUUID;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VonageTransport" /> class.
        /// </summary>
        public VonageTransport()
        {
        }

    }
}