
#nullable enable

namespace Vapi
{
    /// <summary>
    /// 
    /// </summary>
    public enum SimulationRunControllerFindAllFilterStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Failed,
        /// <summary>
        /// 
        /// </summary>
        Passed,
        /// <summary>
        /// 
        /// </summary>
        Running,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SimulationRunControllerFindAllFilterStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SimulationRunControllerFindAllFilterStatus value)
        {
            return value switch
            {
                SimulationRunControllerFindAllFilterStatus.Failed => "failed",
                SimulationRunControllerFindAllFilterStatus.Passed => "passed",
                SimulationRunControllerFindAllFilterStatus.Running => "running",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SimulationRunControllerFindAllFilterStatus? ToEnum(string value)
        {
            return value switch
            {
                "failed" => SimulationRunControllerFindAllFilterStatus.Failed,
                "passed" => SimulationRunControllerFindAllFilterStatus.Passed,
                "running" => SimulationRunControllerFindAllFilterStatus.Running,
                _ => null,
            };
        }
    }
}