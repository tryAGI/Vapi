
#nullable enable

namespace Vapi
{
    /// <summary>
    /// Where this call's evaluation under goalVersion stands.
    /// </summary>
    public enum CallHealthDashboardGoalCallDTOProcessingState
    {
        /// <summary>
        ///
        /// </summary>
        Completed,
        /// <summary>
        ///
        /// </summary>
        Excluded,
        /// <summary>
        ///
        /// </summary>
        Parked,
        /// <summary>
        ///
        /// </summary>
        Pending,
        /// <summary>
        ///
        /// </summary>
        Running,
        /// <summary>
        ///
        /// </summary>
        Unavailable,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CallHealthDashboardGoalCallDTOProcessingStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CallHealthDashboardGoalCallDTOProcessingState value)
        {
            return value switch
            {
                CallHealthDashboardGoalCallDTOProcessingState.Completed => "completed",
                CallHealthDashboardGoalCallDTOProcessingState.Excluded => "excluded",
                CallHealthDashboardGoalCallDTOProcessingState.Parked => "parked",
                CallHealthDashboardGoalCallDTOProcessingState.Pending => "pending",
                CallHealthDashboardGoalCallDTOProcessingState.Running => "running",
                CallHealthDashboardGoalCallDTOProcessingState.Unavailable => "unavailable",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CallHealthDashboardGoalCallDTOProcessingState? ToEnum(string value)
        {
            return value switch
            {
                "completed" => CallHealthDashboardGoalCallDTOProcessingState.Completed,
                "excluded" => CallHealthDashboardGoalCallDTOProcessingState.Excluded,
                "parked" => CallHealthDashboardGoalCallDTOProcessingState.Parked,
                "pending" => CallHealthDashboardGoalCallDTOProcessingState.Pending,
                "running" => CallHealthDashboardGoalCallDTOProcessingState.Running,
                "unavailable" => CallHealthDashboardGoalCallDTOProcessingState.Unavailable,
                _ => null,
            };
        }
    }
}