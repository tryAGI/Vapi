
#nullable enable

namespace Vapi
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ClientInboundMessageAppendContext
    {
        /// <summary>
        /// HTTP-only: append context to a GPT-Live call via `call.monitor.controlUrl`.<br/>
        /// Not supported on WebSocket text frames or SDK data channels.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.ClientInboundMessageAppendContextTypeJsonConverter))]
        public global::Vapi.ClientInboundMessageAppendContextType Type { get; set; }

        /// <summary>
        /// Commentary is spoken in the model's own words; thinking is silent context;<br/>
        /// instructions steer the speaker, including requests to try saying something.<br/>
        /// Acceptance does not guarantee exact wording or speech completion.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kind")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.ClientInboundMessageAppendContextKindJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vapi.ClientInboundMessageAppendContextKind Kind { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Content { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ClientInboundMessageAppendContext" /> class.
        /// </summary>
        /// <param name="kind">
        /// Commentary is spoken in the model's own words; thinking is silent context;<br/>
        /// instructions steer the speaker, including requests to try saying something.<br/>
        /// Acceptance does not guarantee exact wording or speech completion.
        /// </param>
        /// <param name="content"></param>
        /// <param name="type">
        /// HTTP-only: append context to a GPT-Live call via `call.monitor.controlUrl`.<br/>
        /// Not supported on WebSocket text frames or SDK data channels.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ClientInboundMessageAppendContext(
            global::Vapi.ClientInboundMessageAppendContextKind kind,
            string content,
            global::Vapi.ClientInboundMessageAppendContextType type)
        {
            this.Type = type;
            this.Kind = kind;
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClientInboundMessageAppendContext" /> class.
        /// </summary>
        public ClientInboundMessageAppendContext()
        {
        }

    }
}