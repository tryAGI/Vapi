
#nullable enable

namespace Vapi
{
    /// <summary>
    /// 
    /// </summary>
    public enum PaginationMetaSortOrder
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
    public static class PaginationMetaSortOrderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PaginationMetaSortOrder value)
        {
            return value switch
            {
                PaginationMetaSortOrder.Asc => "ASC",
                PaginationMetaSortOrder.Desc => "DESC",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PaginationMetaSortOrder? ToEnum(string value)
        {
            return value switch
            {
                "ASC" => PaginationMetaSortOrder.Asc,
                "DESC" => PaginationMetaSortOrder.Desc,
                _ => null,
            };
        }
    }
}