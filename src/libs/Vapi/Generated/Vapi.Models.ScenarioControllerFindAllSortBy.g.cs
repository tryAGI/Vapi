
#nullable enable

namespace Vapi
{
    /// <summary>
    ///
    /// </summary>
    public enum ScenarioControllerFindAllSortBy
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
    public static class ScenarioControllerFindAllSortByExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ScenarioControllerFindAllSortBy value)
        {
            return value switch
            {
                ScenarioControllerFindAllSortBy.Cost => "cost",
                ScenarioControllerFindAllSortBy.CreatedAt => "createdAt",
                ScenarioControllerFindAllSortBy.Duration => "duration",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ScenarioControllerFindAllSortBy? ToEnum(string value)
        {
            return value switch
            {
                "cost" => ScenarioControllerFindAllSortBy.Cost,
                "createdAt" => ScenarioControllerFindAllSortBy.CreatedAt,
                "duration" => ScenarioControllerFindAllSortBy.Duration,
                _ => null,
            };
        }
    }
}