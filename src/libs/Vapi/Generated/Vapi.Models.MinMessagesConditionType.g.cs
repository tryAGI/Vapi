
#nullable enable

namespace Vapi
{
    /// <summary>
    /// This is the type discriminator for the minMessages condition.<br/>
    /// Example: minMessages
    /// </summary>
    public enum MinMessagesConditionType
    {
        /// <summary>
        /// 
        /// </summary>
        MinMessages,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MinMessagesConditionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MinMessagesConditionType value)
        {
            return value switch
            {
                MinMessagesConditionType.MinMessages => "minMessages",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MinMessagesConditionType? ToEnum(string value)
        {
            return value switch
            {
                "minMessages" => MinMessagesConditionType.MinMessages,
                _ => null,
            };
        }
    }
}