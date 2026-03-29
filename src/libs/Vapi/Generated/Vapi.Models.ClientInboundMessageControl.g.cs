
#nullable enable

namespace Vapi
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ClientInboundMessageControl
    {
        /// <summary>
        /// This is the type of the message. Send "control" message to control the assistant. `control` options are:<br/>
        /// - "mute-assistant" - mute the assistant<br/>
        /// - "unmute-assistant" - unmute the assistant<br/>
        /// - "mute-customer" - mute the user<br/>
        /// - "unmute-customer" - unmute the user<br/>
        /// - "say-first-message" - say the first message (this is used when video recording is enabled and the conversation is only started once the client side kicks off the recording)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.ClientInboundMessageControlTypeJsonConverter))]
        public global::Vapi.ClientInboundMessageControlType Type { get; set; }

        /// <summary>
        /// This is the control action
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("control")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.ClientInboundMessageControlControlJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vapi.ClientInboundMessageControlControl Control { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ClientInboundMessageControl" /> class.
        /// </summary>
        /// <param name="control">
        /// This is the control action
        /// </param>
        /// <param name="type">
        /// This is the type of the message. Send "control" message to control the assistant. `control` options are:<br/>
        /// - "mute-assistant" - mute the assistant<br/>
        /// - "unmute-assistant" - unmute the assistant<br/>
        /// - "mute-customer" - mute the user<br/>
        /// - "unmute-customer" - unmute the user<br/>
        /// - "say-first-message" - say the first message (this is used when video recording is enabled and the conversation is only started once the client side kicks off the recording)
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ClientInboundMessageControl(
            global::Vapi.ClientInboundMessageControlControl control,
            global::Vapi.ClientInboundMessageControlType type)
        {
            this.Type = type;
            this.Control = control;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClientInboundMessageControl" /> class.
        /// </summary>
        public ClientInboundMessageControl()
        {
        }
    }
}