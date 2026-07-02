
#nullable enable

namespace Vapi
{
    /// <summary>
    /// The type of tool. "mcp" for MCP tool.
    /// </summary>
    public enum UpdateMcpToolDTOType
    {
        /// <summary>
        /// 
        /// </summary>
        Mcp,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateMcpToolDTOTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateMcpToolDTOType value)
        {
            return value switch
            {
                UpdateMcpToolDTOType.Mcp => "mcp",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateMcpToolDTOType? ToEnum(string value)
        {
            return value switch
            {
                "mcp" => UpdateMcpToolDTOType.Mcp,
                _ => null,
            };
        }
    }
}