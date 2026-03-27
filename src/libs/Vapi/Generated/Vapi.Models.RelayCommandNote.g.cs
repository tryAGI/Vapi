
#nullable enable

namespace Vapi
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RelayCommandNote
    {
        /// <summary>
        /// The type of relay command
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.RelayCommandNoteTypeJsonConverter))]
        public global::Vapi.RelayCommandNoteType Type { get; set; }

        /// <summary>
        /// The note content to add to the conversation
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
        /// Initializes a new instance of the <see cref="RelayCommandNote" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of relay command
        /// </param>
        /// <param name="content">
        /// The note content to add to the conversation
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RelayCommandNote(
            string content,
            global::Vapi.RelayCommandNoteType type)
        {
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RelayCommandNote" /> class.
        /// </summary>
        public RelayCommandNote()
        {
        }
    }
}