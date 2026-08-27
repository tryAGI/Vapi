
#nullable enable

namespace Vapi
{
    /// <summary>
    ///
    /// </summary>
    public enum SimulationRunControllerFindItemsStatus
    {
        /// <summary>
        ///
        /// </summary>
        Canceled,
        /// <summary>
        ///
        /// </summary>
        Evaluating,
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
        Queued,
        /// <summary>
        ///
        /// </summary>
        Running,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SimulationRunControllerFindItemsStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SimulationRunControllerFindItemsStatus value)
        {
            return value switch
            {
                SimulationRunControllerFindItemsStatus.Canceled => "canceled",
                SimulationRunControllerFindItemsStatus.Evaluating => "evaluating",
                SimulationRunControllerFindItemsStatus.Failed => "failed",
                SimulationRunControllerFindItemsStatus.Passed => "passed",
                SimulationRunControllerFindItemsStatus.Queued => "queued",
                SimulationRunControllerFindItemsStatus.Running => "running",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SimulationRunControllerFindItemsStatus? ToEnum(string value)
        {
            return value switch
            {
                "canceled" => SimulationRunControllerFindItemsStatus.Canceled,
                "evaluating" => SimulationRunControllerFindItemsStatus.Evaluating,
                "failed" => SimulationRunControllerFindItemsStatus.Failed,
                "passed" => SimulationRunControllerFindItemsStatus.Passed,
                "queued" => SimulationRunControllerFindItemsStatus.Queued,
                "running" => SimulationRunControllerFindItemsStatus.Running,
                _ => null,
            };
        }
    }
}