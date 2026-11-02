
#nullable enable

namespace Vapi
{
    /// <summary>
    ///
    /// </summary>
    public enum CallHealthDashboardIssueSummaryDTOStatus
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
    public static class CallHealthDashboardIssueSummaryDTOStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CallHealthDashboardIssueSummaryDTOStatus value)
        {
            return value switch
            {
                CallHealthDashboardIssueSummaryDTOStatus.Active => "active",
                CallHealthDashboardIssueSummaryDTOStatus.Dismissed => "dismissed",
                CallHealthDashboardIssueSummaryDTOStatus.Resolved => "resolved",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CallHealthDashboardIssueSummaryDTOStatus? ToEnum(string value)
        {
            return value switch
            {
                "active" => CallHealthDashboardIssueSummaryDTOStatus.Active,
                "dismissed" => CallHealthDashboardIssueSummaryDTOStatus.Dismissed,
                "resolved" => CallHealthDashboardIssueSummaryDTOStatus.Resolved,
                _ => null,
            };
        }
    }
}