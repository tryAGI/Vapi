
#nullable enable

namespace Vapi
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VapiWebCallTransport
    {
        /// <summary>
        /// This is the conversation type of the call (ie, voice or chat).<br/>
        /// Default Value: voice
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conversationType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.VapiWebCallTransportConversationTypeJsonConverter))]
        public global::Vapi.VapiWebCallTransportConversationType? ConversationType { get; set; }

        /// <summary>
        /// Vapi web call transport provider
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.VapiWebCallTransportProviderJsonConverter))]
        public global::Vapi.VapiWebCallTransportProvider Provider { get; set; }

        /// <summary>
        /// This determines whether the daily room will be deleted and all participants will be kicked once the user leaves the room.<br/>
        /// If set to `false`, the room will be kept alive even after the user leaves, allowing clients to reconnect to the same room.<br/>
        /// If set to `true`, the room will be deleted and reconnection will not be allowed.<br/>
        /// Defaults to `true`.<br/>
        /// Default Value: true<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("roomDeleteOnUserLeaveEnabled")]
        public bool? RoomDeleteOnUserLeaveEnabled { get; set; }

        /// <summary>
        /// This is the URL of the web call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("callUrl")]
        public string? CallUrl { get; set; }

        /// <summary>
        /// This is the SIP URI of the web call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("callSipUri")]
        public string? CallSipUri { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VapiWebCallTransport" /> class.
        /// </summary>
        /// <param name="conversationType">
        /// This is the conversation type of the call (ie, voice or chat).<br/>
        /// Default Value: voice
        /// </param>
        /// <param name="provider">
        /// Vapi web call transport provider
        /// </param>
        /// <param name="roomDeleteOnUserLeaveEnabled">
        /// This determines whether the daily room will be deleted and all participants will be kicked once the user leaves the room.<br/>
        /// If set to `false`, the room will be kept alive even after the user leaves, allowing clients to reconnect to the same room.<br/>
        /// If set to `true`, the room will be deleted and reconnection will not be allowed.<br/>
        /// Defaults to `true`.<br/>
        /// Default Value: true<br/>
        /// Example: true
        /// </param>
        /// <param name="callUrl">
        /// This is the URL of the web call.
        /// </param>
        /// <param name="callSipUri">
        /// This is the SIP URI of the web call.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VapiWebCallTransport(
            global::Vapi.VapiWebCallTransportConversationType? conversationType,
            global::Vapi.VapiWebCallTransportProvider provider,
            bool? roomDeleteOnUserLeaveEnabled,
            string? callUrl,
            string? callSipUri)
        {
            this.ConversationType = conversationType;
            this.Provider = provider;
            this.RoomDeleteOnUserLeaveEnabled = roomDeleteOnUserLeaveEnabled;
            this.CallUrl = callUrl;
            this.CallSipUri = callSipUri;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VapiWebCallTransport" /> class.
        /// </summary>
        public VapiWebCallTransport()
        {
        }

    }
}