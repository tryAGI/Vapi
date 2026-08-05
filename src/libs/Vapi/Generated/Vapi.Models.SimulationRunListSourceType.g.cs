
#nullable enable

namespace Vapi
{
    /// <summary>
    /// 
    /// </summary>
    public enum SimulationRunListSourceType
    {
        /// <summary>
        /// 
        /// </summary>
        AdHoc,
        /// <summary>
        /// 
        /// </summary>
        Api,
        /// <summary>
        /// 
        /// </summary>
        Simulation,
        /// <summary>
        /// 
        /// </summary>
        Suite,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SimulationRunListSourceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SimulationRunListSourceType value)
        {
            return value switch
            {
                SimulationRunListSourceType.AdHoc => "adHoc",
                SimulationRunListSourceType.Api => "api",
                SimulationRunListSourceType.Simulation => "simulation",
                SimulationRunListSourceType.Suite => "suite",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SimulationRunListSourceType? ToEnum(string value)
        {
            return value switch
            {
                "adHoc" => SimulationRunListSourceType.AdHoc,
                "api" => SimulationRunListSourceType.Api,
                "simulation" => SimulationRunListSourceType.Simulation,
                "suite" => SimulationRunListSourceType.Suite,
                _ => null,
            };
        }
    }
}