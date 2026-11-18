
#nullable enable

namespace Vapi
{
    /// <summary>
    /// Classification state, named as in the coverage `classification` counters.
    /// </summary>
    public enum CallHealthDashboardCallResponseDTOAssessmentState
    {
        /// <summary>
        ///
        /// </summary>
        Complete,
        /// <summary>
        ///
        /// </summary>
        Error,
        /// <summary>
        ///
        /// </summary>
        Excluded,
        /// <summary>
        ///
        /// </summary>
        Partial,
        /// <summary>
        ///
        /// </summary>
        Pending,
        /// <summary>
        ///
        /// </summary>
        Skipped,
        /// <summary>
        ///
        /// </summary>
        Unavailable,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CallHealthDashboardCallResponseDTOAssessmentStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CallHealthDashboardCallResponseDTOAssessmentState value)
        {
            return value switch
            {
                CallHealthDashboardCallResponseDTOAssessmentState.Complete => "complete",
                CallHealthDashboardCallResponseDTOAssessmentState.Error => "error",
                CallHealthDashboardCallResponseDTOAssessmentState.Excluded => "excluded",
                CallHealthDashboardCallResponseDTOAssessmentState.Partial => "partial",
                CallHealthDashboardCallResponseDTOAssessmentState.Pending => "pending",
                CallHealthDashboardCallResponseDTOAssessmentState.Skipped => "skipped",
                CallHealthDashboardCallResponseDTOAssessmentState.Unavailable => "unavailable",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CallHealthDashboardCallResponseDTOAssessmentState? ToEnum(string value)
        {
            return value switch
            {
                "complete" => CallHealthDashboardCallResponseDTOAssessmentState.Complete,
                "error" => CallHealthDashboardCallResponseDTOAssessmentState.Error,
                "excluded" => CallHealthDashboardCallResponseDTOAssessmentState.Excluded,
                "partial" => CallHealthDashboardCallResponseDTOAssessmentState.Partial,
                "pending" => CallHealthDashboardCallResponseDTOAssessmentState.Pending,
                "skipped" => CallHealthDashboardCallResponseDTOAssessmentState.Skipped,
                "unavailable" => CallHealthDashboardCallResponseDTOAssessmentState.Unavailable,
                _ => null,
            };
        }
    }
}