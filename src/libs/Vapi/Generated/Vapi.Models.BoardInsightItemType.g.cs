
#nullable enable

namespace Vapi
{
    /// <summary>
    ///
    /// </summary>
    public enum BoardInsightItemType
    {
        /// <summary>
        ///
        /// </summary>
        Insight,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BoardInsightItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BoardInsightItemType value)
        {
            return value switch
            {
                BoardInsightItemType.Insight => "insight",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BoardInsightItemType? ToEnum(string value)
        {
            return value switch
            {
                "insight" => BoardInsightItemType.Insight,
                _ => null,
            };
        }
    }
}