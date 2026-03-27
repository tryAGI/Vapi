
#nullable enable

namespace Vapi
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AIEdgeCondition
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.AIEdgeConditionTypeJsonConverter))]
        public global::Vapi.AIEdgeConditionType Type { get; set; }

        /// <summary>
        /// This is the prompt for the AI edge condition. It should evaluate to a boolean.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Prompt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AIEdgeCondition" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="prompt">
        /// This is the prompt for the AI edge condition. It should evaluate to a boolean.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AIEdgeCondition(
            string prompt,
            global::Vapi.AIEdgeConditionType type)
        {
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AIEdgeCondition" /> class.
        /// </summary>
        public AIEdgeCondition()
        {
        }
    }
}