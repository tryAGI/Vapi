
#nullable enable

namespace Vapi
{
    /// <summary>
    /// Number comparison operator<br/>
    /// Example: &gt;=
    /// </summary>
    public enum EventsTableNumberConditionOperator
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
    public static class EventsTableNumberConditionOperatorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EventsTableNumberConditionOperator value)
        {
            return value switch
            {
                EventsTableNumberConditionOperator.x__ => "!=",
                EventsTableNumberConditionOperator.x_3 => "<",
                EventsTableNumberConditionOperator.x__3 => "<=",
                EventsTableNumberConditionOperator.x_ => "=",
                EventsTableNumberConditionOperator.x_2 => ">",
                EventsTableNumberConditionOperator.x__2 => ">=",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EventsTableNumberConditionOperator? ToEnum(string value)
        {
            return value switch
            {
                "!=" => EventsTableNumberConditionOperator.x__,
                "<" => EventsTableNumberConditionOperator.x_3,
                "<=" => EventsTableNumberConditionOperator.x__3,
                "=" => EventsTableNumberConditionOperator.x_,
                ">" => EventsTableNumberConditionOperator.x_2,
                ">=" => EventsTableNumberConditionOperator.x__2,
                _ => null,
            };
        }
    }
}