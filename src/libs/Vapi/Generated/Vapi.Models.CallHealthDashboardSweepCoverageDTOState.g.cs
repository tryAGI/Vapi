
#nullable enable

namespace Vapi
{
    /// <summary>
    ///
    /// </summary>
    public enum CallHealthDashboardSweepCoverageDTOState
    {
        /// <summary>
        ///
        /// </summary>
        Blocked,
        /// <summary>
        ///
        /// </summary>
        Deduplicating,
        /// <summary>
        ///
        /// </summary>
        Enumerating,
        /// <summary>
        ///
        /// </summary>
        Idle,
        /// <summary>
        ///
        /// </summary>
        Processing,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CallHealthDashboardSweepCoverageDTOStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CallHealthDashboardSweepCoverageDTOState value)
        {
            return value switch
            {
                CallHealthDashboardSweepCoverageDTOState.Blocked => "blocked",
                CallHealthDashboardSweepCoverageDTOState.Deduplicating => "deduplicating",
                CallHealthDashboardSweepCoverageDTOState.Enumerating => "enumerating",
                CallHealthDashboardSweepCoverageDTOState.Idle => "idle",
                CallHealthDashboardSweepCoverageDTOState.Processing => "processing",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CallHealthDashboardSweepCoverageDTOState? ToEnum(string value)
        {
            return value switch
            {
                "blocked" => CallHealthDashboardSweepCoverageDTOState.Blocked,
                "deduplicating" => CallHealthDashboardSweepCoverageDTOState.Deduplicating,
                "enumerating" => CallHealthDashboardSweepCoverageDTOState.Enumerating,
                "idle" => CallHealthDashboardSweepCoverageDTOState.Idle,
                "processing" => CallHealthDashboardSweepCoverageDTOState.Processing,
                _ => null,
            };
        }
    }
}