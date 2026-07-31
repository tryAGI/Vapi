
#nullable enable

namespace Vapi
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EndedReasonCondition
    {
        /// <summary>
        /// This is the type discriminator for the endedReason condition.<br/>
        /// Example: endedReason
        /// </summary>
        /// <example>endedReason</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.EndedReasonConditionTypeJsonConverter))]
        public global::Vapi.EndedReasonConditionType Type { get; set; }

        /// <summary>
        /// This is the membership operator applied against `values`.<br/>
        /// - 'oneOf': the structured output runs only if the call's ended reason is in `values`.<br/>
        /// - 'notOneOf': the structured output runs only if the call's ended reason is NOT in `values`.<br/>
        /// Example: oneOf
        /// </summary>
        /// <example>oneOf</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("operator")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.EndedReasonConditionOperatorJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vapi.EndedReasonConditionOperator Operator { get; set; }

        /// <summary>
        /// These are the ended reasons compared against the call's ended reason.<br/>
        /// Any string is accepted so configurations never break when new ended<br/>
        /// reasons are introduced. Must contain at least one value.<br/>
        /// Example: [customer-ended-call]
        /// </summary>
        /// <example>[customer-ended-call]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("values")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Values { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EndedReasonCondition" /> class.
        /// </summary>
        /// <param name="operator">
        /// This is the membership operator applied against `values`.<br/>
        /// - 'oneOf': the structured output runs only if the call's ended reason is in `values`.<br/>
        /// - 'notOneOf': the structured output runs only if the call's ended reason is NOT in `values`.<br/>
        /// Example: oneOf
        /// </param>
        /// <param name="values">
        /// These are the ended reasons compared against the call's ended reason.<br/>
        /// Any string is accepted so configurations never break when new ended<br/>
        /// reasons are introduced. Must contain at least one value.<br/>
        /// Example: [customer-ended-call]
        /// </param>
        /// <param name="type">
        /// This is the type discriminator for the endedReason condition.<br/>
        /// Example: endedReason
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EndedReasonCondition(
            global::Vapi.EndedReasonConditionOperator @operator,
            global::System.Collections.Generic.IList<string> values,
            global::Vapi.EndedReasonConditionType type)
        {
            this.Type = type;
            this.Operator = @operator;
            this.Values = values ?? throw new global::System.ArgumentNullException(nameof(values));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EndedReasonCondition" /> class.
        /// </summary>
        public EndedReasonCondition()
        {
        }

    }
}