
#nullable enable

namespace Vapi
{
    /// <summary>
    /// Absent until a semantic result is accepted. Processing failures are never goal_not_met.
    /// </summary>
    public enum GoalEvaluationCurrentDTOGoalOutcome
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
        Ineligible,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GoalEvaluationCurrentDTOGoalOutcomeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GoalEvaluationCurrentDTOGoalOutcome value)
        {
            return value switch
            {
                GoalEvaluationCurrentDTOGoalOutcome.GoalMet => "goal_met",
                GoalEvaluationCurrentDTOGoalOutcome.GoalNotMet => "goal_not_met",
                GoalEvaluationCurrentDTOGoalOutcome.Ineligible => "ineligible",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GoalEvaluationCurrentDTOGoalOutcome? ToEnum(string value)
        {
            return value switch
            {
                "goal_met" => GoalEvaluationCurrentDTOGoalOutcome.GoalMet,
                "goal_not_met" => GoalEvaluationCurrentDTOGoalOutcome.GoalNotMet,
                "ineligible" => GoalEvaluationCurrentDTOGoalOutcome.Ineligible,
                _ => null,
            };
        }
    }
}