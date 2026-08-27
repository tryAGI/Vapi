
#nullable enable

namespace Vapi
{
    /// <summary>
    ///
    /// </summary>
    public enum SimulationRunControllerFindAllStatus
    {
        /// <summary>
        ///
        /// </summary>
        Ended,
        /// <summary>
        ///
        /// </summary>
        Queued,
        /// <summary>
        ///
        /// </summary>
        Running,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SimulationRunControllerFindAllStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SimulationRunControllerFindAllStatus value)
        {
            return value switch
            {
                SimulationRunControllerFindAllStatus.Ended => "ended",
                SimulationRunControllerFindAllStatus.Queued => "queued",
                SimulationRunControllerFindAllStatus.Running => "running",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SimulationRunControllerFindAllStatus? ToEnum(string value)
        {
            return value switch
            {
                "ended" => SimulationRunControllerFindAllStatus.Ended,
                "queued" => SimulationRunControllerFindAllStatus.Queued,
                "running" => SimulationRunControllerFindAllStatus.Running,
                _ => null,
            };
        }
    }
}