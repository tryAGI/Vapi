
#nullable enable

namespace Vapi
{
    /// <summary>
    ///
    /// </summary>
    public enum SimulationRunControllerFindItemsSortOrder
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
    public static class SimulationRunControllerFindItemsSortOrderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SimulationRunControllerFindItemsSortOrder value)
        {
            return value switch
            {
                SimulationRunControllerFindItemsSortOrder.Asc => "ASC",
                SimulationRunControllerFindItemsSortOrder.Desc => "DESC",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SimulationRunControllerFindItemsSortOrder? ToEnum(string value)
        {
            return value switch
            {
                "ASC" => SimulationRunControllerFindItemsSortOrder.Asc,
                "DESC" => SimulationRunControllerFindItemsSortOrder.Desc,
                _ => null,
            };
        }
    }
}