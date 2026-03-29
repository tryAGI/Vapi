
#nullable enable

namespace Vapi
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatEvalToolResponseMessageMock
    {
        /// <summary>
        /// This is the role of the message author.<br/>
        /// For a mock tool response message, the role is always 'tool'<br/>
        /// @default 'tool'<br/>
        /// Default Value: tool
        /// </summary>
        /// <default>global::Vapi.ChatEvalToolResponseMessageMockRole.Tool</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.ChatEvalToolResponseMessageMockRoleJsonConverter))]
        public global::Vapi.ChatEvalToolResponseMessageMockRole Role { get; set; } = global::Vapi.ChatEvalToolResponseMessageMockRole.Tool;

        /// <summary>
        /// This is the content of the tool response message. JSON Objects should be stringified.
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
        /// Initializes a new instance of the <see cref="ChatEvalToolResponseMessageMock" /> class.
        /// </summary>
        /// <param name="content">
        /// This is the content of the tool response message. JSON Objects should be stringified.
        /// </param>
        /// <param name="role">
        /// This is the role of the message author.<br/>
        /// For a mock tool response message, the role is always 'tool'<br/>
        /// @default 'tool'<br/>
        /// Default Value: tool
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatEvalToolResponseMessageMock(
            string content,
            global::Vapi.ChatEvalToolResponseMessageMockRole role = global::Vapi.ChatEvalToolResponseMessageMockRole.Tool)
        {
            this.Role = role;
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatEvalToolResponseMessageMock" /> class.
        /// </summary>
        public ChatEvalToolResponseMessageMock()
        {
        }
    }
}