
#nullable enable

namespace Vapi
{
    /// <summary>
    ///
    /// </summary>
    public enum GuardrailRulesControllerPaginatedSortBy
    {
        /// <summary>
        ///
        /// </summary>
        CreatedAt,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GuardrailRulesControllerPaginatedSortByExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GuardrailRulesControllerPaginatedSortBy value)
        {
            return value switch
            {
                GuardrailRulesControllerPaginatedSortBy.CreatedAt => "createdAt",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GuardrailRulesControllerPaginatedSortBy? ToEnum(string value)
        {
            return value switch
            {
                "createdAt" => GuardrailRulesControllerPaginatedSortBy.CreatedAt,
                _ => null,
            };
        }
    }
}