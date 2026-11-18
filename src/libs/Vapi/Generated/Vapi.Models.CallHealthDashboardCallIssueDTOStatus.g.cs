
#nullable enable

namespace Vapi
{
    /// <summary>
    ///
    /// </summary>
    public enum CallHealthDashboardCallIssueDTOStatus
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
    public static class CallHealthDashboardCallIssueDTOStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CallHealthDashboardCallIssueDTOStatus value)
        {
            return value switch
            {
                CallHealthDashboardCallIssueDTOStatus.Active => "active",
                CallHealthDashboardCallIssueDTOStatus.Dismissed => "dismissed",
                CallHealthDashboardCallIssueDTOStatus.Resolved => "resolved",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CallHealthDashboardCallIssueDTOStatus? ToEnum(string value)
        {
            return value switch
            {
                "active" => CallHealthDashboardCallIssueDTOStatus.Active,
                "dismissed" => CallHealthDashboardCallIssueDTOStatus.Dismissed,
                "resolved" => CallHealthDashboardCallIssueDTOStatus.Resolved,
                _ => null,
            };
        }
    }
}