
#nullable enable

namespace Vapi
{
    /// <summary>
    /// Current status of the run
    /// </summary>
    public enum SimulationRunListItemStatus
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
    public static class SimulationRunListItemStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SimulationRunListItemStatus value)
        {
            return value switch
            {
                SimulationRunListItemStatus.Ended => "ended",
                SimulationRunListItemStatus.Queued => "queued",
                SimulationRunListItemStatus.Running => "running",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SimulationRunListItemStatus? ToEnum(string value)
        {
            return value switch
            {
                "ended" => SimulationRunListItemStatus.Ended,
                "queued" => SimulationRunListItemStatus.Queued,
                "running" => SimulationRunListItemStatus.Running,
                _ => null,
            };
        }
    }
}