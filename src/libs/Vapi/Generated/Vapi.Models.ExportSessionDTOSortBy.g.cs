
#nullable enable

namespace Vapi
{
    /// <summary>
    /// This is the column to sort by. Defaults to 'createdAt'.
    /// </summary>
    public enum ExportSessionDTOSortBy
    {
        /// <summary>
        /// 
        /// </summary>
        Cost,
        /// <summary>
        /// 
        /// </summary>
        CreatedAt,
        /// <summary>
        /// 
        /// </summary>
        Duration,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ExportSessionDTOSortByExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ExportSessionDTOSortBy value)
        {
            return value switch
            {
                ExportSessionDTOSortBy.Cost => "cost",
                ExportSessionDTOSortBy.CreatedAt => "createdAt",
                ExportSessionDTOSortBy.Duration => "duration",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ExportSessionDTOSortBy? ToEnum(string value)
        {
            return value switch
            {
                "cost" => ExportSessionDTOSortBy.Cost,
                "createdAt" => ExportSessionDTOSortBy.CreatedAt,
                "duration" => ExportSessionDTOSortBy.Duration,
                _ => null,
            };
        }
    }
}