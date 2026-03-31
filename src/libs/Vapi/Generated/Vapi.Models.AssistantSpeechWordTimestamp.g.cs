
#nullable enable

namespace Vapi
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AssistantSpeechWordTimestamp
    {
        /// <summary>
        /// The full word text (syllables aggregated into complete words).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("word")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Word { get; set; }

        /// <summary>
        /// Start time in milliseconds relative to the segment start.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("startMs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double StartMs { get; set; }

        /// <summary>
        /// End time in milliseconds relative to the segment start.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("endMs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double EndMs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AssistantSpeechWordTimestamp" /> class.
        /// </summary>
        /// <param name="word">
        /// The full word text (syllables aggregated into complete words).
        /// </param>
        /// <param name="startMs">
        /// Start time in milliseconds relative to the segment start.
        /// </param>
        /// <param name="endMs">
        /// End time in milliseconds relative to the segment start.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AssistantSpeechWordTimestamp(
            string word,
            double startMs,
            double endMs)
        {
            this.Word = word ?? throw new global::System.ArgumentNullException(nameof(word));
            this.StartMs = startMs;
            this.EndMs = endMs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AssistantSpeechWordTimestamp" /> class.
        /// </summary>
        public AssistantSpeechWordTimestamp()
        {
        }
    }
}