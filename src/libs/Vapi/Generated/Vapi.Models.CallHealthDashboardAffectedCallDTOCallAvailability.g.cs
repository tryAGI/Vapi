
#nullable enable

namespace Vapi
{
    /// <summary>
    ///
    /// </summary>
    public enum CallHealthDashboardAffectedCallDTOCallAvailability
    {
        /// <summary>
        ///
        /// </summary>
        Available,
        /// <summary>
        ///
        /// </summary>
        Unavailable,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CallHealthDashboardAffectedCallDTOCallAvailabilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CallHealthDashboardAffectedCallDTOCallAvailability value)
        {
            return value switch
            {
                CallHealthDashboardAffectedCallDTOCallAvailability.Available => "available",
                CallHealthDashboardAffectedCallDTOCallAvailability.Unavailable => "unavailable",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CallHealthDashboardAffectedCallDTOCallAvailability? ToEnum(string value)
        {
            return value switch
            {
                "available" => CallHealthDashboardAffectedCallDTOCallAvailability.Available,
                "unavailable" => CallHealthDashboardAffectedCallDTOCallAvailability.Unavailable,
                _ => null,
            };
        }
    }
}