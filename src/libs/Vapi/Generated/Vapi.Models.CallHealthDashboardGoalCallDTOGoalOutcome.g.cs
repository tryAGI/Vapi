
#nullable enable

namespace Vapi
{
    /// <summary>
    /// Absent until a result is accepted; a processing failure is never goal_not_met.
    /// </summary>
    public enum CallHealthDashboardGoalCallDTOGoalOutcome
    {
        /// <summary>
        ///
        /// </summary>
        GoalMet,
        /// <summary>
        ///
        /// </summary>
        GoalNotMet,
        /// <summary>
        ///
        /// </summary>
        NotApplicable,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CallHealthDashboardGoalCallDTOGoalOutcomeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CallHealthDashboardGoalCallDTOGoalOutcome value)
        {
            return value switch
            {
                CallHealthDashboardGoalCallDTOGoalOutcome.GoalMet => "goal_met",
                CallHealthDashboardGoalCallDTOGoalOutcome.GoalNotMet => "goal_not_met",
                CallHealthDashboardGoalCallDTOGoalOutcome.NotApplicable => "not_applicable",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CallHealthDashboardGoalCallDTOGoalOutcome? ToEnum(string value)
        {
            return value switch
            {
                "goal_met" => CallHealthDashboardGoalCallDTOGoalOutcome.GoalMet,
                "goal_not_met" => CallHealthDashboardGoalCallDTOGoalOutcome.GoalNotMet,
                "not_applicable" => CallHealthDashboardGoalCallDTOGoalOutcome.NotApplicable,
                _ => null,
            };
        }
    }
}