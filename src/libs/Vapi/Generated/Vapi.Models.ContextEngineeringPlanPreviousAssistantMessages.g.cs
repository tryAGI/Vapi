
#nullable enable

namespace Vapi
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ContextEngineeringPlanPreviousAssistantMessages
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.ContextEngineeringPlanPreviousAssistantMessagesTypeJsonConverter))]
        public global::Vapi.ContextEngineeringPlanPreviousAssistantMessagesType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ContextEngineeringPlanPreviousAssistantMessages" /> class.
        /// </summary>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ContextEngineeringPlanPreviousAssistantMessages(
            global::Vapi.ContextEngineeringPlanPreviousAssistantMessagesType type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ContextEngineeringPlanPreviousAssistantMessages" /> class.
        /// </summary>
        public ContextEngineeringPlanPreviousAssistantMessages()
        {
        }
    }
}