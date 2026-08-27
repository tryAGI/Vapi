
#nullable enable

namespace Vapi
{
    /// <summary>
    ///
    /// </summary>
    public enum BoardControllerFindAllSortOrder
    {
        /// <summary>
        ///
        /// </summary>
        Asc,
        /// <summary>
        ///
        /// </summary>
        Desc,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BoardControllerFindAllSortOrderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BoardControllerFindAllSortOrder value)
        {
            return value switch
            {
                BoardControllerFindAllSortOrder.Asc => "ASC",
                BoardControllerFindAllSortOrder.Desc => "DESC",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BoardControllerFindAllSortOrder? ToEnum(string value)
        {
            return value switch
            {
                "ASC" => BoardControllerFindAllSortOrder.Asc,
                "DESC" => BoardControllerFindAllSortOrder.Desc,
                _ => null,
            };
        }
    }
}