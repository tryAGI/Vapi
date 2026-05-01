
#nullable enable

namespace Vapi
{
    /// <summary>
    /// The kind of warning. Currently:<br/>
    /// - `oversized-tool-response`: the tool's serialized response exceeded the<br/>
    ///   recommended size and is likely to bloat the model context, increasing<br/>
    ///   latency and risking truncation of earlier instructions.
    /// </summary>
    public enum ToolCallResultMessageWarningType
    {
        /// <summary>
        /// the tool's serialized response exceeded the
        /// </summary>
        OversizedToolResponse,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ToolCallResultMessageWarningTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolCallResultMessageWarningType value)
        {
            return value switch
            {
                ToolCallResultMessageWarningType.OversizedToolResponse => "oversized-tool-response",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolCallResultMessageWarningType? ToEnum(string value)
        {
            return value switch
            {
                "oversized-tool-response" => ToolCallResultMessageWarningType.OversizedToolResponse,
                _ => null,
            };
        }
    }
}