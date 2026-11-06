
#nullable enable

namespace Vapi
{
    /// <summary>
    ///
    /// </summary>
    public enum CallHealthDashboardIssueReferenceDTOStatus
    {
        /// <summary>
        ///
        /// </summary>
        Active,
        /// <summary>
        ///
        /// </summary>
        Dismissed,
        /// <summary>
        ///
        /// </summary>
        Resolved,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CallHealthDashboardIssueReferenceDTOStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CallHealthDashboardIssueReferenceDTOStatus value)
        {
            return value switch
            {
                CallHealthDashboardIssueReferenceDTOStatus.Active => "active",
                CallHealthDashboardIssueReferenceDTOStatus.Dismissed => "dismissed",
                CallHealthDashboardIssueReferenceDTOStatus.Resolved => "resolved",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CallHealthDashboardIssueReferenceDTOStatus? ToEnum(string value)
        {
            return value switch
            {
                "active" => CallHealthDashboardIssueReferenceDTOStatus.Active,
                "dismissed" => CallHealthDashboardIssueReferenceDTOStatus.Dismissed,
                "resolved" => CallHealthDashboardIssueReferenceDTOStatus.Resolved,
                _ => null,
            };
        }
    }
}