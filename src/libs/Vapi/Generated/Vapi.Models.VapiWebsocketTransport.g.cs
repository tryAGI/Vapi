
#nullable enable

namespace Vapi
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VapiWebsocketTransport
    {
        /// <summary>
        /// This is the conversation type of the call (ie, voice or chat).<br/>
        /// Default Value: voice
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conversationType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.VapiWebsocketTransportConversationTypeJsonConverter))]
        public global::Vapi.VapiWebsocketTransportConversationType? ConversationType { get; set; }

        /// <summary>
        /// Vapi websocket transport provider
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.VapiWebsocketTransportProviderJsonConverter))]
        public global::Vapi.VapiWebsocketTransportProvider Provider { get; set; }

        /// <summary>
        /// This is the audio format of the call. Defaults to 16KHz raw pcm_s16le
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audioFormat")]
        public global::Vapi.AudioFormat? AudioFormat { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VapiWebsocketTransport" /> class.
        /// </summary>
        /// <param name="conversationType">
        /// This is the conversation type of the call (ie, voice or chat).<br/>
        /// Default Value: voice
        /// </param>
        /// <param name="provider">
        /// Vapi websocket transport provider
        /// </param>
        /// <param name="audioFormat">
        /// This is the audio format of the call. Defaults to 16KHz raw pcm_s16le
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VapiWebsocketTransport(
            global::Vapi.VapiWebsocketTransportConversationType? conversationType,
            global::Vapi.VapiWebsocketTransportProvider provider,
            global::Vapi.AudioFormat? audioFormat)
        {
            this.ConversationType = conversationType;
            this.Provider = provider;
            this.AudioFormat = audioFormat;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VapiWebsocketTransport" /> class.
        /// </summary>
        public VapiWebsocketTransport()
        {
        }

    }
}