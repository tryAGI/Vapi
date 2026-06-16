
#nullable enable

namespace Vapi
{
    /// <summary>
    /// This is the comparator that will be used to compare the result of the structured output with the value specified.<br/>
    /// Only '=', '!=', '&gt;', '&lt;', '&gt;=', and '&lt;=' are supported for number conditions<br/>
    /// Only '=' is supported for boolean conditions.
    /// </summary>
    public enum NumberComparatorScorecardMetricConditionComparator
    {
        /// <summary>
        /// 
        /// </summary>
        Eq,
        /// <summary>
        /// 
        /// </summary>
        Gt,
        /// <summary>
        /// 
        /// </summary>
        Gte,
        /// <summary>
        /// 
        /// </summary>
        Lt,
        /// <summary>
        /// 
        /// </summary>
        Lte,
        /// <summary>
        /// 
        /// </summary>
        Neq,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class NumberComparatorScorecardMetricConditionComparatorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this NumberComparatorScorecardMetricConditionComparator value)
        {
            return value switch
            {
                NumberComparatorScorecardMetricConditionComparator.Eq => "eq",
                NumberComparatorScorecardMetricConditionComparator.Gt => "gt",
                NumberComparatorScorecardMetricConditionComparator.Gte => "gte",
                NumberComparatorScorecardMetricConditionComparator.Lt => "lt",
                NumberComparatorScorecardMetricConditionComparator.Lte => "lte",
                NumberComparatorScorecardMetricConditionComparator.Neq => "neq",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static NumberComparatorScorecardMetricConditionComparator? ToEnum(string value)
        {
            return value switch
            {
                "eq" => NumberComparatorScorecardMetricConditionComparator.Eq,
                "gt" => NumberComparatorScorecardMetricConditionComparator.Gt,
                "gte" => NumberComparatorScorecardMetricConditionComparator.Gte,
                "lt" => NumberComparatorScorecardMetricConditionComparator.Lt,
                "lte" => NumberComparatorScorecardMetricConditionComparator.Lte,
                "neq" => NumberComparatorScorecardMetricConditionComparator.Neq,
                _ => null,
            };
        }
    }
}