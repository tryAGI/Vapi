
#nullable enable

namespace Vapi
{
    /// <summary>
    /// 
    /// </summary>
    public enum StructuredOutputControllerFindAllSortBy
    {
        /// <summary>
        /// 
        /// </summary>
        Cost,
        /// <summary>
        /// 
        /// </summary>
        CreatedAt,
        /// <summary>
        /// 
        /// </summary>
        Duration,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StructuredOutputControllerFindAllSortByExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StructuredOutputControllerFindAllSortBy value)
        {
            return value switch
            {
                StructuredOutputControllerFindAllSortBy.Cost => "cost",
                StructuredOutputControllerFindAllSortBy.CreatedAt => "createdAt",
                StructuredOutputControllerFindAllSortBy.Duration => "duration",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StructuredOutputControllerFindAllSortBy? ToEnum(string value)
        {
            return value switch
            {
                "cost" => StructuredOutputControllerFindAllSortBy.Cost,
                "createdAt" => StructuredOutputControllerFindAllSortBy.CreatedAt,
                "duration" => StructuredOutputControllerFindAllSortBy.Duration,
                _ => null,
            };
        }
    }
}