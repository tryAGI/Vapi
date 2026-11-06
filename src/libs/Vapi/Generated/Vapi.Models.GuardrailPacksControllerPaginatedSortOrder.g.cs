
#nullable enable

namespace Vapi
{
    /// <summary>
    ///
    /// </summary>
    public enum GuardrailPacksControllerPaginatedSortOrder
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
    public static class GuardrailPacksControllerPaginatedSortOrderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GuardrailPacksControllerPaginatedSortOrder value)
        {
            return value switch
            {
                GuardrailPacksControllerPaginatedSortOrder.Asc => "ASC",
                GuardrailPacksControllerPaginatedSortOrder.Desc => "DESC",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GuardrailPacksControllerPaginatedSortOrder? ToEnum(string value)
        {
            return value switch
            {
                "ASC" => GuardrailPacksControllerPaginatedSortOrder.Asc,
                "DESC" => GuardrailPacksControllerPaginatedSortOrder.Desc,
                _ => null,
            };
        }
    }
}