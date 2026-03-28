
#nullable enable

namespace Vapi
{
    /// <summary>
    /// This is the comparison operator to use when evaluating the extracted value against the expected value.<br/>
    /// Available operators depend on the structured output's schema type:<br/>
    /// - boolean: '=', '!='<br/>
    /// - string: '=', '!='<br/>
    /// - number/integer: '=', '!=', '&gt;', '&lt;', '&gt;=', '&lt;='<br/>
    /// Example: =
    /// </summary>
    public enum EvaluationPlanItemComparator
    {
        /// <summary>
        /// '=', '!='
        /// </summary>
        x__,
        /// <summary>
        /// '=', '!=', '&gt;', '&lt;', '&gt;=', '&lt;='
        /// </summary>
        x_3,
        /// <summary>
        /// '=', '!=', '&gt;', '&lt;', '&gt;=', '&lt;='
        /// </summary>
        x__3,
        /// <summary>
        /// '=', '!='
        /// </summary>
        x_,
        /// <summary>
        /// '=', '!=', '&gt;', '&lt;', '&gt;=', '&lt;='
        /// </summary>
        x_2,
        /// <summary>
        /// '=', '!=', '&gt;', '&lt;', '&gt;=', '&lt;='
        /// </summary>
        x__2,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EvaluationPlanItemComparatorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EvaluationPlanItemComparator value)
        {
            return value switch
            {
                EvaluationPlanItemComparator.x__ => "!=",
                EvaluationPlanItemComparator.x_3 => "<",
                EvaluationPlanItemComparator.x__3 => "<=",
                EvaluationPlanItemComparator.x_ => "=",
                EvaluationPlanItemComparator.x_2 => ">",
                EvaluationPlanItemComparator.x__2 => ">=",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EvaluationPlanItemComparator? ToEnum(string value)
        {
            return value switch
            {
                "!=" => EvaluationPlanItemComparator.x__,
                "<" => EvaluationPlanItemComparator.x_3,
                "<=" => EvaluationPlanItemComparator.x__3,
                "=" => EvaluationPlanItemComparator.x_,
                ">" => EvaluationPlanItemComparator.x_2,
                ">=" => EvaluationPlanItemComparator.x__2,
                _ => null,
            };
        }
    }
}