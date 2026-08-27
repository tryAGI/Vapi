
#nullable enable

namespace Vapi
{
    /// <summary>
    ///
    /// </summary>
    public enum BoardMetricWidgetItemType
    {
        /// <summary>
        ///
        /// </summary>
        AverageCostBreakdownChart,
        /// <summary>
        ///
        /// </summary>
        ConcurrencyChart,
        /// <summary>
        ///
        /// </summary>
        FailedCallsList,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BoardMetricWidgetItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BoardMetricWidgetItemType value)
        {
            return value switch
            {
                BoardMetricWidgetItemType.AverageCostBreakdownChart => "average_cost_breakdown_chart",
                BoardMetricWidgetItemType.ConcurrencyChart => "concurrency_chart",
                BoardMetricWidgetItemType.FailedCallsList => "failed_calls_list",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BoardMetricWidgetItemType? ToEnum(string value)
        {
            return value switch
            {
                "average_cost_breakdown_chart" => BoardMetricWidgetItemType.AverageCostBreakdownChart,
                "concurrency_chart" => BoardMetricWidgetItemType.ConcurrencyChart,
                "failed_calls_list" => BoardMetricWidgetItemType.FailedCallsList,
                _ => null,
            };
        }
    }
}