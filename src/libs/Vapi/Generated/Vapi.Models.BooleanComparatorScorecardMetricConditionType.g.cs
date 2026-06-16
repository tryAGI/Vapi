
#nullable enable

namespace Vapi
{
    /// <summary>
    /// This is the type of the condition. Currently only 'comparator' is supported.
    /// </summary>
    public enum BooleanComparatorScorecardMetricConditionType
    {
        /// <summary>
        /// 
        /// </summary>
        Comparator,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BooleanComparatorScorecardMetricConditionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BooleanComparatorScorecardMetricConditionType value)
        {
            return value switch
            {
                BooleanComparatorScorecardMetricConditionType.Comparator => "comparator",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BooleanComparatorScorecardMetricConditionType? ToEnum(string value)
        {
            return value switch
            {
                "comparator" => BooleanComparatorScorecardMetricConditionType.Comparator,
                _ => null,
            };
        }
    }
}