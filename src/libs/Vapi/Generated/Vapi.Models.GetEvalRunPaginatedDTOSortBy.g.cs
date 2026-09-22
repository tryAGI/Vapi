
#nullable enable

namespace Vapi
{
    /// <summary>
    ///
    /// </summary>
    public enum GetEvalRunPaginatedDTOSortBy
    {
        /// <summary>
        ///
        /// </summary>
        CreatedAt,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetEvalRunPaginatedDTOSortByExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetEvalRunPaginatedDTOSortBy value)
        {
            return value switch
            {
                GetEvalRunPaginatedDTOSortBy.CreatedAt => "createdAt",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetEvalRunPaginatedDTOSortBy? ToEnum(string value)
        {
            return value switch
            {
                "createdAt" => GetEvalRunPaginatedDTOSortBy.CreatedAt,
                _ => null,
            };
        }
    }
}