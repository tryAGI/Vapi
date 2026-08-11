
#nullable enable

namespace Vapi
{
    /// <summary>
    /// 
    /// </summary>
    public enum SimulationSuiteControllerFindAllSortBy
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
    public static class SimulationSuiteControllerFindAllSortByExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SimulationSuiteControllerFindAllSortBy value)
        {
            return value switch
            {
                SimulationSuiteControllerFindAllSortBy.Cost => "cost",
                SimulationSuiteControllerFindAllSortBy.CreatedAt => "createdAt",
                SimulationSuiteControllerFindAllSortBy.Duration => "duration",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SimulationSuiteControllerFindAllSortBy? ToEnum(string value)
        {
            return value switch
            {
                "cost" => SimulationSuiteControllerFindAllSortBy.Cost,
                "createdAt" => SimulationSuiteControllerFindAllSortBy.CreatedAt,
                "duration" => SimulationSuiteControllerFindAllSortBy.Duration,
                _ => null,
            };
        }
    }
}