
#nullable enable

namespace Vapi
{
    /// <summary>
    /// The type of tool. "query" for Query tool.
    /// </summary>
    public enum UpdateQueryToolDTOType
    {
        /// <summary>
        /// 
        /// </summary>
        Query,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateQueryToolDTOTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateQueryToolDTOType value)
        {
            return value switch
            {
                UpdateQueryToolDTOType.Query => "query",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateQueryToolDTOType? ToEnum(string value)
        {
            return value switch
            {
                "query" => UpdateQueryToolDTOType.Query,
                _ => null,
            };
        }
    }
}