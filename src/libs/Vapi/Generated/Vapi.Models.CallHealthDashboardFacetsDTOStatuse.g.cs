
#nullable enable

namespace Vapi
{
    /// <summary>
    ///
    /// </summary>
    public enum CallHealthDashboardFacetsDTOStatuse
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
    public static class CallHealthDashboardFacetsDTOStatuseExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CallHealthDashboardFacetsDTOStatuse value)
        {
            return value switch
            {
                CallHealthDashboardFacetsDTOStatuse.Active => "active",
                CallHealthDashboardFacetsDTOStatuse.Dismissed => "dismissed",
                CallHealthDashboardFacetsDTOStatuse.Resolved => "resolved",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CallHealthDashboardFacetsDTOStatuse? ToEnum(string value)
        {
            return value switch
            {
                "active" => CallHealthDashboardFacetsDTOStatuse.Active,
                "dismissed" => CallHealthDashboardFacetsDTOStatuse.Dismissed,
                "resolved" => CallHealthDashboardFacetsDTOStatuse.Resolved,
                _ => null,
            };
        }
    }
}