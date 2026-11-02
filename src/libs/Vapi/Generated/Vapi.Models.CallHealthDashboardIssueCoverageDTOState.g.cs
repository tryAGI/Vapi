
#nullable enable

namespace Vapi
{
    /// <summary>
    ///
    /// </summary>
    public enum CallHealthDashboardIssueCoverageDTOState
    {
        /// <summary>
        ///
        /// </summary>
        Blocked,
        /// <summary>
        ///
        /// </summary>
        Complete,
        /// <summary>
        ///
        /// </summary>
        Partial,
        /// <summary>
        ///
        /// </summary>
        Sweeping,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CallHealthDashboardIssueCoverageDTOStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CallHealthDashboardIssueCoverageDTOState value)
        {
            return value switch
            {
                CallHealthDashboardIssueCoverageDTOState.Blocked => "blocked",
                CallHealthDashboardIssueCoverageDTOState.Complete => "complete",
                CallHealthDashboardIssueCoverageDTOState.Partial => "partial",
                CallHealthDashboardIssueCoverageDTOState.Sweeping => "sweeping",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CallHealthDashboardIssueCoverageDTOState? ToEnum(string value)
        {
            return value switch
            {
                "blocked" => CallHealthDashboardIssueCoverageDTOState.Blocked,
                "complete" => CallHealthDashboardIssueCoverageDTOState.Complete,
                "partial" => CallHealthDashboardIssueCoverageDTOState.Partial,
                "sweeping" => CallHealthDashboardIssueCoverageDTOState.Sweeping,
                _ => null,
            };
        }
    }
}