
#nullable enable

namespace Vapi
{
    /// <summary>
    /// 
    /// </summary>
    public enum SimulationRunControllerFindAllSortOrder
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
    public static class SimulationRunControllerFindAllSortOrderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SimulationRunControllerFindAllSortOrder value)
        {
            return value switch
            {
                SimulationRunControllerFindAllSortOrder.Asc => "ASC",
                SimulationRunControllerFindAllSortOrder.Desc => "DESC",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SimulationRunControllerFindAllSortOrder? ToEnum(string value)
        {
            return value switch
            {
                "ASC" => SimulationRunControllerFindAllSortOrder.Asc,
                "DESC" => SimulationRunControllerFindAllSortOrder.Desc,
                _ => null,
            };
        }
    }
}