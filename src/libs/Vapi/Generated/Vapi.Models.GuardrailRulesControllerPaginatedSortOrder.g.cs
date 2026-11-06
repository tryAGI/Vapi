
#nullable enable

namespace Vapi
{
    /// <summary>
    ///
    /// </summary>
    public enum GuardrailRulesControllerPaginatedSortOrder
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
    public static class GuardrailRulesControllerPaginatedSortOrderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GuardrailRulesControllerPaginatedSortOrder value)
        {
            return value switch
            {
                GuardrailRulesControllerPaginatedSortOrder.Asc => "ASC",
                GuardrailRulesControllerPaginatedSortOrder.Desc => "DESC",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GuardrailRulesControllerPaginatedSortOrder? ToEnum(string value)
        {
            return value switch
            {
                "ASC" => GuardrailRulesControllerPaginatedSortOrder.Asc,
                "DESC" => GuardrailRulesControllerPaginatedSortOrder.Desc,
                _ => null,
            };
        }
    }
}