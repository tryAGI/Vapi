
#nullable enable

namespace Vapi
{
    /// <summary>
    /// 
    /// </summary>
    public enum SimulationControllerFindAllSortOrder
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
    public static class SimulationControllerFindAllSortOrderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SimulationControllerFindAllSortOrder value)
        {
            return value switch
            {
                SimulationControllerFindAllSortOrder.Asc => "ASC",
                SimulationControllerFindAllSortOrder.Desc => "DESC",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SimulationControllerFindAllSortOrder? ToEnum(string value)
        {
            return value switch
            {
                "ASC" => SimulationControllerFindAllSortOrder.Asc,
                "DESC" => SimulationControllerFindAllSortOrder.Desc,
                _ => null,
            };
        }
    }
}