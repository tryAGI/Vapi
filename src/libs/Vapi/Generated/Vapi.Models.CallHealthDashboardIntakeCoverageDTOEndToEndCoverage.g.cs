
#nullable enable

namespace Vapi
{
    /// <summary>
    ///
    /// </summary>
    public enum CallHealthDashboardIntakeCoverageDTOEndToEndCoverage
    {
        /// <summary>
        ///
        /// </summary>
        Unknown,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CallHealthDashboardIntakeCoverageDTOEndToEndCoverageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CallHealthDashboardIntakeCoverageDTOEndToEndCoverage value)
        {
            return value switch
            {
                CallHealthDashboardIntakeCoverageDTOEndToEndCoverage.Unknown => "unknown",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CallHealthDashboardIntakeCoverageDTOEndToEndCoverage? ToEnum(string value)
        {
            return value switch
            {
                "unknown" => CallHealthDashboardIntakeCoverageDTOEndToEndCoverage.Unknown,
                _ => null,
            };
        }
    }
}