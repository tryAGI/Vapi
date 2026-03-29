
#nullable enable

namespace Vapi
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResponseOutputMessage
    {
        /// <summary>
        /// The unique ID of the output message
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Content of the output message
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vapi.ResponseOutputText> Content { get; set; }

        /// <summary>
        /// The role of the output message<br/>
        /// Default Value: assistant
        /// </summary>
        /// <default>global::Vapi.ResponseOutputMessageRole.Assistant</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.ResponseOutputMessageRoleJsonConverter))]
        public global::Vapi.ResponseOutputMessageRole Role { get; set; } = global::Vapi.ResponseOutputMessageRole.Assistant;

        /// <summary>
        /// The status of the message
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.ResponseOutputMessageStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vapi.ResponseOutputMessageStatus Status { get; set; }

        /// <summary>
        /// The type of the output message<br/>
        /// Default Value: message
        /// </summary>
        /// <default>global::Vapi.ResponseOutputMessageType.Message</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.ResponseOutputMessageTypeJsonConverter))]
        public global::Vapi.ResponseOutputMessageType Type { get; set; } = global::Vapi.ResponseOutputMessageType.Message;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseOutputMessage" /> class.
        /// </summary>
        /// <param name="id">
        /// The unique ID of the output message
        /// </param>
        /// <param name="content">
        /// Content of the output message
        /// </param>
        /// <param name="status">
        /// The status of the message
        /// </param>
        /// <param name="role">
        /// The role of the output message<br/>
        /// Default Value: assistant
        /// </param>
        /// <param name="type">
        /// The type of the output message<br/>
        /// Default Value: message
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponseOutputMessage(
            string id,
            global::System.Collections.Generic.IList<global::Vapi.ResponseOutputText> content,
            global::Vapi.ResponseOutputMessageStatus status,
            global::Vapi.ResponseOutputMessageRole role = global::Vapi.ResponseOutputMessageRole.Assistant,
            global::Vapi.ResponseOutputMessageType type = global::Vapi.ResponseOutputMessageType.Message)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
            this.Role = role;
            this.Status = status;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseOutputMessage" /> class.
        /// </summary>
        public ResponseOutputMessage()
        {
        }
    }
}