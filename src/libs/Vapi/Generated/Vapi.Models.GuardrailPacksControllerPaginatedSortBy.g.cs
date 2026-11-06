
#nullable enable

namespace Vapi
{
    /// <summary>
    ///
    /// </summary>
    public enum GuardrailPacksControllerPaginatedSortBy
    {
        /// <summary>
        ///
        /// </summary>
        CreatedAt,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GuardrailPacksControllerPaginatedSortByExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GuardrailPacksControllerPaginatedSortBy value)
        {
            return value switch
            {
                GuardrailPacksControllerPaginatedSortBy.CreatedAt => "createdAt",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GuardrailPacksControllerPaginatedSortBy? ToEnum(string value)
        {
            return value switch
            {
                "createdAt" => GuardrailPacksControllerPaginatedSortBy.CreatedAt,
                _ => null,
            };
        }
    }
}