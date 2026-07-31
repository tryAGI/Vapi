
#nullable enable

namespace Vapi
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SkippedStructuredOutput
    {
        /// <summary>
        /// This is the name of the structured output that was skipped.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// This is the first condition that was not met. Conditions use AND semantics, so<br/>
        /// evaluation stops as soon as one condition does not pass.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("unmetCondition")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.MinMessagesCondition, global::Vapi.MinCallDurationCondition, global::Vapi.EndedReasonCondition>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vapi.OneOf<global::Vapi.MinMessagesCondition, global::Vapi.MinCallDurationCondition, global::Vapi.EndedReasonCondition> UnmetCondition { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SkippedStructuredOutput" /> class.
        /// </summary>
        /// <param name="name">
        /// This is the name of the structured output that was skipped.
        /// </param>
        /// <param name="unmetCondition">
        /// This is the first condition that was not met. Conditions use AND semantics, so<br/>
        /// evaluation stops as soon as one condition does not pass.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SkippedStructuredOutput(
            string name,
            global::Vapi.OneOf<global::Vapi.MinMessagesCondition, global::Vapi.MinCallDurationCondition, global::Vapi.EndedReasonCondition> unmetCondition)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.UnmetCondition = unmetCondition;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SkippedStructuredOutput" /> class.
        /// </summary>
        public SkippedStructuredOutput()
        {
        }

    }
}