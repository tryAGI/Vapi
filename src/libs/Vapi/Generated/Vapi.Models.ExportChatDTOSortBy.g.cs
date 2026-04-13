
#nullable enable

namespace Vapi
{
    /// <summary>
    /// This is the column to sort by. Defaults to 'createdAt'.
    /// </summary>
    public enum ExportChatDTOSortBy
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
    public static class ExportChatDTOSortByExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ExportChatDTOSortBy value)
        {
            return value switch
            {
                ExportChatDTOSortBy.Cost => "cost",
                ExportChatDTOSortBy.CreatedAt => "createdAt",
                ExportChatDTOSortBy.Duration => "duration",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ExportChatDTOSortBy? ToEnum(string value)
        {
            return value switch
            {
                "cost" => ExportChatDTOSortBy.Cost,
                "createdAt" => ExportChatDTOSortBy.CreatedAt,
                "duration" => ExportChatDTOSortBy.Duration,
                _ => null,
            };
        }
    }
}