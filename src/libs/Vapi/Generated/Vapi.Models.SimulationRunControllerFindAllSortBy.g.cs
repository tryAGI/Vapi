
#nullable enable

namespace Vapi
{
    /// <summary>
    /// 
    /// </summary>
    public enum SimulationRunControllerFindAllSortBy
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
    public static class SimulationRunControllerFindAllSortByExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SimulationRunControllerFindAllSortBy value)
        {
            return value switch
            {
                SimulationRunControllerFindAllSortBy.Cost => "cost",
                SimulationRunControllerFindAllSortBy.CreatedAt => "createdAt",
                SimulationRunControllerFindAllSortBy.Duration => "duration",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SimulationRunControllerFindAllSortBy? ToEnum(string value)
        {
            return value switch
            {
                "cost" => SimulationRunControllerFindAllSortBy.Cost,
                "createdAt" => SimulationRunControllerFindAllSortBy.CreatedAt,
                "duration" => SimulationRunControllerFindAllSortBy.Duration,
                _ => null,
            };
        }
    }
}