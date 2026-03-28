
#nullable enable

namespace Vapi
{
    /// <summary>
    /// This is the comparison operator used for evaluation.
    /// </summary>
    public enum StructuredOutputEvaluationResultComparator
    {
        /// <summary>
        /// 
        /// </summary>
        x__,
        /// <summary>
        /// 
        /// </summary>
        x_3,
        /// <summary>
        /// 
        /// </summary>
        x__3,
        /// <summary>
        /// 
        /// </summary>
        x_,
        /// <summary>
        /// 
        /// </summary>
        x_2,
        /// <summary>
        /// 
        /// </summary>
        x__2,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StructuredOutputEvaluationResultComparatorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StructuredOutputEvaluationResultComparator value)
        {
            return value switch
            {
                StructuredOutputEvaluationResultComparator.x__ => "!=",
                StructuredOutputEvaluationResultComparator.x_3 => "<",
                StructuredOutputEvaluationResultComparator.x__3 => "<=",
                StructuredOutputEvaluationResultComparator.x_ => "=",
                StructuredOutputEvaluationResultComparator.x_2 => ">",
                StructuredOutputEvaluationResultComparator.x__2 => ">=",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StructuredOutputEvaluationResultComparator? ToEnum(string value)
        {
            return value switch
            {
                "!=" => StructuredOutputEvaluationResultComparator.x__,
                "<" => StructuredOutputEvaluationResultComparator.x_3,
                "<=" => StructuredOutputEvaluationResultComparator.x__3,
                "=" => StructuredOutputEvaluationResultComparator.x_,
                ">" => StructuredOutputEvaluationResultComparator.x_2,
                ">=" => StructuredOutputEvaluationResultComparator.x__2,
                _ => null,
            };
        }
    }
}