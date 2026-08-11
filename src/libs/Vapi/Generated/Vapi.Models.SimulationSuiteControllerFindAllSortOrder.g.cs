
#nullable enable

namespace Vapi
{
    /// <summary>
    /// 
    /// </summary>
    public enum SimulationSuiteControllerFindAllSortOrder
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
    public static class SimulationSuiteControllerFindAllSortOrderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SimulationSuiteControllerFindAllSortOrder value)
        {
            return value switch
            {
                SimulationSuiteControllerFindAllSortOrder.Asc => "ASC",
                SimulationSuiteControllerFindAllSortOrder.Desc => "DESC",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SimulationSuiteControllerFindAllSortOrder? ToEnum(string value)
        {
            return value switch
            {
                "ASC" => SimulationSuiteControllerFindAllSortOrder.Asc,
                "DESC" => SimulationSuiteControllerFindAllSortOrder.Desc,
                _ => null,
            };
        }
    }
}