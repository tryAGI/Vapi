
#nullable enable

namespace Vapi
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class MinMessagesCondition
    {
        /// <summary>
        /// This is the type discriminator for the minMessages condition.<br/>
        /// Example: minMessages
        /// </summary>
        /// <example>minMessages</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.MinMessagesConditionTypeJsonConverter))]
        public global::Vapi.MinMessagesConditionType Type { get; set; }

        /// <summary>
        /// This is the minimum number of conversation messages required for the<br/>
        /// structured output to run.<br/>
        /// A count of 0 removes the runtime default minimum, so the structured output<br/>
        /// runs regardless of how few messages the conversation has.<br/>
        /// Example: 4
        /// </summary>
        /// <example>4</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Count { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MinMessagesCondition" /> class.
        /// </summary>
        /// <param name="count">
        /// This is the minimum number of conversation messages required for the<br/>
        /// structured output to run.<br/>
        /// A count of 0 removes the runtime default minimum, so the structured output<br/>
        /// runs regardless of how few messages the conversation has.<br/>
        /// Example: 4
        /// </param>
        /// <param name="type">
        /// This is the type discriminator for the minMessages condition.<br/>
        /// Example: minMessages
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MinMessagesCondition(
            double count,
            global::Vapi.MinMessagesConditionType type)
        {
            this.Type = type;
            this.Count = count;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MinMessagesCondition" /> class.
        /// </summary>
        public MinMessagesCondition()
        {
        }

    }
}