
#nullable enable

namespace Vapi
{
    /// <summary>
    ///
    /// </summary>
    public enum CallHealthDashboardTriageRequestDTOAction
    {
        /// <summary>
        ///
        /// </summary>
        Dismiss,
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
    public static class CallHealthDashboardTriageRequestDTOActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CallHealthDashboardTriageRequestDTOAction value)
        {
            return value switch
            {
                CallHealthDashboardTriageRequestDTOAction.Dismiss => "dismiss",
                CallHealthDashboardTriageRequestDTOAction.Resolve => "resolve",
                CallHealthDashboardTriageRequestDTOAction.Restore => "restore",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CallHealthDashboardTriageRequestDTOAction? ToEnum(string value)
        {
            return value switch
            {
                "dismiss" => CallHealthDashboardTriageRequestDTOAction.Dismiss,
                "resolve" => CallHealthDashboardTriageRequestDTOAction.Resolve,
                "restore" => CallHealthDashboardTriageRequestDTOAction.Restore,
                _ => null,
            };
        }
    }
}