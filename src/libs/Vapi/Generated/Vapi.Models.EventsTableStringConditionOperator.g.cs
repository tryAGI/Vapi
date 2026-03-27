
#nullable enable

namespace Vapi
{
    /// <summary>
    /// String comparison operator<br/>
    /// Example: =
    /// </summary>
    public enum EventsTableStringConditionOperator
    {
        /// <summary>
        /// 
        /// </summary>
        x__,
        /// <summary>
        /// 
        /// </summary>
        x_,
        /// <summary>
        /// 
        /// </summary>
        Contains,
        /// <summary>
        /// 
        /// </summary>
        NotContains,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EventsTableStringConditionOperatorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EventsTableStringConditionOperator value)
        {
            return value switch
            {
                EventsTableStringConditionOperator.x__ => "!=",
                EventsTableStringConditionOperator.x_ => "=",
                EventsTableStringConditionOperator.Contains => "contains",
                EventsTableStringConditionOperator.NotContains => "notContains",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EventsTableStringConditionOperator? ToEnum(string value)
        {
            return value switch
            {
                "!=" => EventsTableStringConditionOperator.x__,
                "=" => EventsTableStringConditionOperator.x_,
                "contains" => EventsTableStringConditionOperator.Contains,
                "notContains" => EventsTableStringConditionOperator.NotContains,
                _ => null,
            };
        }
    }
}