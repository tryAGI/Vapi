
#nullable enable

namespace Vapi
{
    /// <summary>
    ///
    /// </summary>
    public enum BoardControllerFindAllSortBy
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
    public static class BoardControllerFindAllSortByExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BoardControllerFindAllSortBy value)
        {
            return value switch
            {
                BoardControllerFindAllSortBy.Cost => "cost",
                BoardControllerFindAllSortBy.CreatedAt => "createdAt",
                BoardControllerFindAllSortBy.Duration => "duration",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BoardControllerFindAllSortBy? ToEnum(string value)
        {
            return value switch
            {
                "cost" => BoardControllerFindAllSortBy.Cost,
                "createdAt" => BoardControllerFindAllSortBy.CreatedAt,
                "duration" => BoardControllerFindAllSortBy.Duration,
                _ => null,
            };
        }
    }
}