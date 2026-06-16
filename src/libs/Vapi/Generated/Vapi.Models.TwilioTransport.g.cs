
#nullable enable

namespace Vapi
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TwilioTransport
    {
        /// <summary>
        /// This is the conversation type of the call (ie, voice or chat).<br/>
        /// Default Value: voice
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conversationType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.TwilioTransportConversationTypeJsonConverter))]
        public global::Vapi.TwilioTransportConversationType? ConversationType { get; set; }

        /// <summary>
        /// Twilio transport provider
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.TwilioTransportProviderJsonConverter))]
        public global::Vapi.TwilioTransportProvider Provider { get; set; }

        /// <summary>
        /// This is the account SID of the Twilio account.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("accountSid")]
        public string? AccountSid { get; set; }

        /// <summary>
        /// This is the call SID of the Twilio call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("callSid")]
        public string? CallSid { get; set; }

        /// <summary>
        /// This is the call token of the Twilio call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("callToken")]
        public string? CallToken { get; set; }

        /// <summary>
        /// This is the phone number from which the call was forwarded.<br/>
        /// Undefined if the call was not forwarded.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("forwardedFrom")]
        public string? ForwardedFrom { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TwilioTransport" /> class.
        /// </summary>
        /// <param name="conversationType">
        /// This is the conversation type of the call (ie, voice or chat).<br/>
        /// Default Value: voice
        /// </param>
        /// <param name="provider">
        /// Twilio transport provider
        /// </param>
        /// <param name="accountSid">
        /// This is the account SID of the Twilio account.
        /// </param>
        /// <param name="callSid">
        /// This is the call SID of the Twilio call.
        /// </param>
        /// <param name="callToken">
        /// This is the call token of the Twilio call.
        /// </param>
        /// <param name="forwardedFrom">
        /// This is the phone number from which the call was forwarded.<br/>
        /// Undefined if the call was not forwarded.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TwilioTransport(
            global::Vapi.TwilioTransportConversationType? conversationType,
            global::Vapi.TwilioTransportProvider provider,
            string? accountSid,
            string? callSid,
            string? callToken,
            string? forwardedFrom)
        {
            this.ConversationType = conversationType;
            this.Provider = provider;
            this.AccountSid = accountSid;
            this.CallSid = callSid;
            this.CallToken = callToken;
            this.ForwardedFrom = forwardedFrom;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TwilioTransport" /> class.
        /// </summary>
        public TwilioTransport()
        {
        }

    }
}