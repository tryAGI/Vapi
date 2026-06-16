
#nullable enable

namespace Vapi
{
    /// <summary>
    /// The comparator can only be '=' for boolean conditions.
    /// </summary>
    public enum BooleanComparatorScorecardMetricConditionComparator
    {
        /// <summary>
        /// 
        /// </summary>
        Eq,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BooleanComparatorScorecardMetricConditionComparatorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BooleanComparatorScorecardMetricConditionComparator value)
        {
            return value switch
            {
                BooleanComparatorScorecardMetricConditionComparator.Eq => "=",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BooleanComparatorScorecardMetricConditionComparator? ToEnum(string value)
        {
            return value switch
            {
                "=" => BooleanComparatorScorecardMetricConditionComparator.Eq,
                _ => null,
            };
        }
    }
}