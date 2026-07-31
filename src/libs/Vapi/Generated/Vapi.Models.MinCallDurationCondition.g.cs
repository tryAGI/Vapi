
#nullable enable

namespace Vapi
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MinCallDurationCondition
    {
        /// <summary>
        /// This is the type discriminator for the minCallDuration condition.<br/>
        /// Example: minCallDuration
        /// </summary>
        /// <example>minCallDuration</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.MinCallDurationConditionTypeJsonConverter))]
        public global::Vapi.MinCallDurationConditionType Type { get; set; }

        /// <summary>
        /// This is the minimum call duration in seconds required for the structured<br/>
        /// output to run.<br/>
        /// When timestamps are unavailable (for example, chat sessions have no call<br/>
        /// timestamps), this check passes and does not block the structured output.<br/>
        /// Example: 10
        /// </summary>
        /// <example>10</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("seconds")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Seconds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MinCallDurationCondition" /> class.
        /// </summary>
        /// <param name="seconds">
        /// This is the minimum call duration in seconds required for the structured<br/>
        /// output to run.<br/>
        /// When timestamps are unavailable (for example, chat sessions have no call<br/>
        /// timestamps), this check passes and does not block the structured output.<br/>
        /// Example: 10
        /// </param>
        /// <param name="type">
        /// This is the type discriminator for the minCallDuration condition.<br/>
        /// Example: minCallDuration
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MinCallDurationCondition(
            double seconds,
            global::Vapi.MinCallDurationConditionType type)
        {
            this.Type = type;
            this.Seconds = seconds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MinCallDurationCondition" /> class.
        /// </summary>
        public MinCallDurationCondition()
        {
        }

    }
}