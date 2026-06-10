
#nullable enable

namespace Vapi
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SayHookAction
    {
        /// <summary>
        /// This is the type of action - must be "say"
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.SayHookActionTypeJsonConverter))]
        public global::Vapi.SayHookActionType Type { get; set; }

        /// <summary>
        /// This is the exact message to say. When a string array is provided, one is randomly selected.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("exact")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>))]
        public global::Vapi.OneOf<string, global::System.Collections.Generic.IList<string>>? Exact { get; set; }

        /// <summary>
        /// This is the prompt for the assistant to generate a response based on existing conversation.<br/>
        /// Can be a string or an array of chat messages.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<global::Vapi.OneOf<global::Vapi.SystemMessage, global::Vapi.UserMessage, global::Vapi.AssistantMessage, global::Vapi.ToolMessage, global::Vapi.DeveloperMessage>>>))]
        public global::Vapi.OneOf<string, global::System.Collections.Generic.IList<global::Vapi.OneOf<global::Vapi.SystemMessage, global::Vapi.UserMessage, global::Vapi.AssistantMessage, global::Vapi.ToolMessage, global::Vapi.DeveloperMessage>>>? Prompt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SayHookAction" /> class.
        /// </summary>
        /// <param name="type">
        /// This is the type of action - must be "say"
        /// </param>
        /// <param name="exact">
        /// This is the exact message to say. When a string array is provided, one is randomly selected.
        /// </param>
        /// <param name="prompt">
        /// This is the prompt for the assistant to generate a response based on existing conversation.<br/>
        /// Can be a string or an array of chat messages.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SayHookAction(
            global::Vapi.SayHookActionType type,
            global::Vapi.OneOf<string, global::System.Collections.Generic.IList<string>>? exact,
            global::Vapi.OneOf<string, global::System.Collections.Generic.IList<global::Vapi.OneOf<global::Vapi.SystemMessage, global::Vapi.UserMessage, global::Vapi.AssistantMessage, global::Vapi.ToolMessage, global::Vapi.DeveloperMessage>>>? prompt)
        {
            this.Type = type;
            this.Exact = exact;
            this.Prompt = prompt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SayHookAction" /> class.
        /// </summary>
        public SayHookAction()
        {
        }

    }
}