
#nullable enable

namespace Vapi
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VapiSipTransport
    {
        /// <summary>
        /// This is the conversation type of the call (ie, voice or chat).<br/>
        /// Default Value: voice
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conversationType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.VapiSipTransportConversationTypeJsonConverter))]
        public global::Vapi.VapiSipTransportConversationType? ConversationType { get; set; }

        /// <summary>
        /// Vapi SIP transport provider
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.VapiSipTransportProviderJsonConverter))]
        public global::Vapi.VapiSipTransportProvider Provider { get; set; }

        /// <summary>
        /// This sets the timeout for outbound dial operations in seconds. This is the duration the call will ring before timing out.<br/>
        /// @default 60<br/>
        /// Default Value: 60
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dialTimeout")]
        public double? DialTimeout { get; set; }

        /// <summary>
        /// This is the call SID of the Vapi SIP call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sbcCallSid")]
        public string? SbcCallSid { get; set; }

        /// <summary>
        /// This is the call ID of the Vapi SIP call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("callSid")]
        public string? CallSid { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VapiSipTransport" /> class.
        /// </summary>
        /// <param name="conversationType">
        /// This is the conversation type of the call (ie, voice or chat).<br/>
        /// Default Value: voice
        /// </param>
        /// <param name="provider">
        /// Vapi SIP transport provider
        /// </param>
        /// <param name="dialTimeout">
        /// This sets the timeout for outbound dial operations in seconds. This is the duration the call will ring before timing out.<br/>
        /// @default 60<br/>
        /// Default Value: 60
        /// </param>
        /// <param name="sbcCallSid">
        /// This is the call SID of the Vapi SIP call.
        /// </param>
        /// <param name="callSid">
        /// This is the call ID of the Vapi SIP call.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VapiSipTransport(
            global::Vapi.VapiSipTransportConversationType? conversationType,
            global::Vapi.VapiSipTransportProvider provider,
            double? dialTimeout,
            string? sbcCallSid,
            string? callSid)
        {
            this.ConversationType = conversationType;
            this.Provider = provider;
            this.DialTimeout = dialTimeout;
            this.SbcCallSid = sbcCallSid;
            this.CallSid = callSid;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VapiSipTransport" /> class.
        /// </summary>
        public VapiSipTransport()
        {
        }

    }
}