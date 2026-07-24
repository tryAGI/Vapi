
#nullable enable

namespace Vapi
{
    /// <summary>
    /// Current status of the run
    /// </summary>
    public enum CreateSimulationRunResponseStatus
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
    public static class CreateSimulationRunResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateSimulationRunResponseStatus value)
        {
            return value switch
            {
                CreateSimulationRunResponseStatus.Ended => "ended",
                CreateSimulationRunResponseStatus.Queued => "queued",
                CreateSimulationRunResponseStatus.Running => "running",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateSimulationRunResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "ended" => CreateSimulationRunResponseStatus.Ended,
                "queued" => CreateSimulationRunResponseStatus.Queued,
                "running" => CreateSimulationRunResponseStatus.Running,
                _ => null,
            };
        }
    }
}