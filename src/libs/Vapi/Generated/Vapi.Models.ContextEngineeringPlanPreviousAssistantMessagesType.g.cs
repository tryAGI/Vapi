
#nullable enable

namespace Vapi
{
    /// <summary>
    /// 
    /// </summary>
    public enum ContextEngineeringPlanPreviousAssistantMessagesType
    {
        /// <summary>
        /// 
        /// </summary>
        PreviousAssistantMessages,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ContextEngineeringPlanPreviousAssistantMessagesTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ContextEngineeringPlanPreviousAssistantMessagesType value)
        {
            return value switch
            {
                ContextEngineeringPlanPreviousAssistantMessagesType.PreviousAssistantMessages => "previousAssistantMessages",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ContextEngineeringPlanPreviousAssistantMessagesType? ToEnum(string value)
        {
            return value switch
            {
                "previousAssistantMessages" => ContextEngineeringPlanPreviousAssistantMessagesType.PreviousAssistantMessages,
                _ => null,
            };
        }
    }
}