
#nullable enable

namespace Vapi
{
    /// <summary>
    ///
    /// </summary>
    public enum GoalEvaluationCurrentDTOProcessingState
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
    public static class GoalEvaluationCurrentDTOProcessingStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GoalEvaluationCurrentDTOProcessingState value)
        {
            return value switch
            {
                GoalEvaluationCurrentDTOProcessingState.Completed => "completed",
                GoalEvaluationCurrentDTOProcessingState.Excluded => "excluded",
                GoalEvaluationCurrentDTOProcessingState.Parked => "parked",
                GoalEvaluationCurrentDTOProcessingState.Pending => "pending",
                GoalEvaluationCurrentDTOProcessingState.Running => "running",
                GoalEvaluationCurrentDTOProcessingState.Unavailable => "unavailable",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GoalEvaluationCurrentDTOProcessingState? ToEnum(string value)
        {
            return value switch
            {
                "completed" => GoalEvaluationCurrentDTOProcessingState.Completed,
                "excluded" => GoalEvaluationCurrentDTOProcessingState.Excluded,
                "parked" => GoalEvaluationCurrentDTOProcessingState.Parked,
                "pending" => GoalEvaluationCurrentDTOProcessingState.Pending,
                "running" => GoalEvaluationCurrentDTOProcessingState.Running,
                "unavailable" => GoalEvaluationCurrentDTOProcessingState.Unavailable,
                _ => null,
            };
        }
    }
}