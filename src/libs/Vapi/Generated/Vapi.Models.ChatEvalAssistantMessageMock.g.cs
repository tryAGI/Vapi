
#nullable enable

namespace Vapi
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatEvalAssistantMessageMock
    {
        /// <summary>
        /// This is the role of the message author.<br/>
        /// For a mock assistant message, the role is always 'assistant'<br/>
        /// @default 'assistant'<br/>
        /// Default Value: assistant
        /// </summary>
        /// <default>global::Vapi.ChatEvalAssistantMessageMockRole.Assistant</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.ChatEvalAssistantMessageMockRoleJsonConverter))]
        public global::Vapi.ChatEvalAssistantMessageMockRole Role { get; set; } = global::Vapi.ChatEvalAssistantMessageMockRole.Assistant;

        /// <summary>
        /// This is the content of the assistant message.<br/>
        /// This is the message that the assistant would have sent.<br/>
        /// Example: The weather in San Francisco is sunny.
        /// </summary>
        /// <example>The weather in San Francisco is sunny.</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        public string? Content { get; set; }

        /// <summary>
        /// This is the tool calls that will be made by the assistant.<br/>
        /// Example: [{ name: "get_weather", arguments: { city: "San Francisco" } }]
        /// </summary>
        /// <example>[{ name: "get_weather", arguments: { city: "San Francisco" } }]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("toolCalls")]
        public global::System.Collections.Generic.IList<global::Vapi.ChatEvalAssistantMessageMockToolCall>? ToolCalls { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatEvalAssistantMessageMock" /> class.
        /// </summary>
        /// <param name="role">
        /// This is the role of the message author.<br/>
        /// For a mock assistant message, the role is always 'assistant'<br/>
        /// @default 'assistant'<br/>
        /// Default Value: assistant
        /// </param>
        /// <param name="content">
        /// This is the content of the assistant message.<br/>
        /// This is the message that the assistant would have sent.<br/>
        /// Example: The weather in San Francisco is sunny.
        /// </param>
        /// <param name="toolCalls">
        /// This is the tool calls that will be made by the assistant.<br/>
        /// Example: [{ name: "get_weather", arguments: { city: "San Francisco" } }]
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatEvalAssistantMessageMock(
            string? content,
            global::System.Collections.Generic.IList<global::Vapi.ChatEvalAssistantMessageMockToolCall>? toolCalls,
            global::Vapi.ChatEvalAssistantMessageMockRole role = global::Vapi.ChatEvalAssistantMessageMockRole.Assistant)
        {
            this.Role = role;
            this.Content = content;
            this.ToolCalls = toolCalls;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatEvalAssistantMessageMock" /> class.
        /// </summary>
        public ChatEvalAssistantMessageMock()
        {
        }
    }
}