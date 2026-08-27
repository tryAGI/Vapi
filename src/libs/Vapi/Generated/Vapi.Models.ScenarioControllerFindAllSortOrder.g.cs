
#nullable enable

namespace Vapi
{
    /// <summary>
    ///
    /// </summary>
    public enum ScenarioControllerFindAllSortOrder
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
    public static class ScenarioControllerFindAllSortOrderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ScenarioControllerFindAllSortOrder value)
        {
            return value switch
            {
                ScenarioControllerFindAllSortOrder.Asc => "ASC",
                ScenarioControllerFindAllSortOrder.Desc => "DESC",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ScenarioControllerFindAllSortOrder? ToEnum(string value)
        {
            return value switch
            {
                "ASC" => ScenarioControllerFindAllSortOrder.Asc,
                "DESC" => ScenarioControllerFindAllSortOrder.Desc,
                _ => null,
            };
        }
    }
}