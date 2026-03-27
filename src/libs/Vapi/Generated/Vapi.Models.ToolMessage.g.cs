
#nullable enable

namespace Vapi
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ToolMessage
    {
        /// <summary>
        /// This is the role of the message author<br/>
        /// Default Value: tool
        /// </summary>
        /// <default>global::Vapi.ToolMessageRole.Tool</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.ToolMessageRoleJsonConverter))]
        public global::Vapi.ToolMessageRole Role { get; set; } = global::Vapi.ToolMessageRole.Tool;

        /// <summary>
        /// This is the content of the tool message
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Content { get; set; }

        /// <summary>
        /// This is the ID of the tool call this message is responding to
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_call_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ToolCallId { get; set; }

        /// <summary>
        /// This is an optional name for the participant
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// This is an optional metadata for the message
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolMessage" /> class.
        /// </summary>
        /// <param name="role">
        /// This is the role of the message author<br/>
        /// Default Value: tool
        /// </param>
        /// <param name="content">
        /// This is the content of the tool message
        /// </param>
        /// <param name="toolCallId">
        /// This is the ID of the tool call this message is responding to
        /// </param>
        /// <param name="name">
        /// This is an optional name for the participant
        /// </param>
        /// <param name="metadata">
        /// This is an optional metadata for the message
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolMessage(
            string content,
            string toolCallId,
            string? name,
            object? metadata,
            global::Vapi.ToolMessageRole role = global::Vapi.ToolMessageRole.Tool)
        {
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
            this.ToolCallId = toolCallId ?? throw new global::System.ArgumentNullException(nameof(toolCallId));
            this.Role = role;
            this.Name = name;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolMessage" /> class.
        /// </summary>
        public ToolMessage()
        {
        }
    }
}