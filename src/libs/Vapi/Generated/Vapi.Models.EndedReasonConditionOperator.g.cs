
#nullable enable

namespace Vapi
{
    /// <summary>
    /// This is the membership operator applied against `values`.<br/>
    /// - 'oneOf': the structured output runs only if the call's ended reason is in `values`.<br/>
    /// - 'notOneOf': the structured output runs only if the call's ended reason is NOT in `values`.<br/>
    /// Example: oneOf
    /// </summary>
    public enum EndedReasonConditionOperator
    {
        /// <summary>
        /// the structured output runs only if the call's ended reason is NOT in `values`.
        /// </summary>
        NotOneOf,
        /// <summary>
        /// the structured output runs only if the call's ended reason is in `values`.
        /// </summary>
        OneOf,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EndedReasonConditionOperatorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EndedReasonConditionOperator value)
        {
            return value switch
            {
                EndedReasonConditionOperator.NotOneOf => "notOneOf",
                EndedReasonConditionOperator.OneOf => "oneOf",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EndedReasonConditionOperator? ToEnum(string value)
        {
            return value switch
            {
                "notOneOf" => EndedReasonConditionOperator.NotOneOf,
                "oneOf" => EndedReasonConditionOperator.OneOf,
                _ => null,
            };
        }
    }
}