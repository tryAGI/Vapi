
#nullable enable

namespace Vapi
{
    /// <summary>
    ///
    /// </summary>
    public enum SimulationRunControllerFindItemsSortBy
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
    public static class SimulationRunControllerFindItemsSortByExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SimulationRunControllerFindItemsSortBy value)
        {
            return value switch
            {
                SimulationRunControllerFindItemsSortBy.Cost => "cost",
                SimulationRunControllerFindItemsSortBy.CreatedAt => "createdAt",
                SimulationRunControllerFindItemsSortBy.Duration => "duration",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SimulationRunControllerFindItemsSortBy? ToEnum(string value)
        {
            return value switch
            {
                "cost" => SimulationRunControllerFindItemsSortBy.Cost,
                "createdAt" => SimulationRunControllerFindItemsSortBy.CreatedAt,
                "duration" => SimulationRunControllerFindItemsSortBy.Duration,
                _ => null,
            };
        }
    }
}