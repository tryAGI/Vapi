
#nullable enable

namespace Vapi
{
    /// <summary>
    /// 
    /// </summary>
    public enum SimulationControllerFindAllSortBy
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
    public static class SimulationControllerFindAllSortByExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SimulationControllerFindAllSortBy value)
        {
            return value switch
            {
                SimulationControllerFindAllSortBy.Cost => "cost",
                SimulationControllerFindAllSortBy.CreatedAt => "createdAt",
                SimulationControllerFindAllSortBy.Duration => "duration",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SimulationControllerFindAllSortBy? ToEnum(string value)
        {
            return value switch
            {
                "cost" => SimulationControllerFindAllSortBy.Cost,
                "createdAt" => SimulationControllerFindAllSortBy.CreatedAt,
                "duration" => SimulationControllerFindAllSortBy.Duration,
                _ => null,
            };
        }
    }
}