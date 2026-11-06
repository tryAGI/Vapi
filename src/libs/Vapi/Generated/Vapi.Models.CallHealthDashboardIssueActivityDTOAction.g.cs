
#nullable enable

namespace Vapi
{
    /// <summary>
    /// User resolve, dismiss or restore, or the system reopen written when a new match reopens a resolved issue.
    /// </summary>
    public enum CallHealthDashboardIssueActivityDTOAction
    {
        /// <summary>
        ///
        /// </summary>
        Dismiss,
        /// <summary>
        ///
        /// </summary>
        Reopen,
        /// <summary>
        ///
        /// </summary>
        Resolve,
        /// <summary>
        ///
        /// </summary>
        Restore,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CallHealthDashboardIssueActivityDTOActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CallHealthDashboardIssueActivityDTOAction value)
        {
            return value switch
            {
                CallHealthDashboardIssueActivityDTOAction.Dismiss => "dismiss",
                CallHealthDashboardIssueActivityDTOAction.Reopen => "reopen",
                CallHealthDashboardIssueActivityDTOAction.Resolve => "resolve",
                CallHealthDashboardIssueActivityDTOAction.Restore => "restore",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CallHealthDashboardIssueActivityDTOAction? ToEnum(string value)
        {
            return value switch
            {
                "dismiss" => CallHealthDashboardIssueActivityDTOAction.Dismiss,
                "reopen" => CallHealthDashboardIssueActivityDTOAction.Reopen,
                "resolve" => CallHealthDashboardIssueActivityDTOAction.Resolve,
                "restore" => CallHealthDashboardIssueActivityDTOAction.Restore,
                _ => null,
            };
        }
    }
}