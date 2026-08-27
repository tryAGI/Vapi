
#nullable enable

namespace Vapi
{
    /// <summary>
    ///
    /// </summary>
    public enum ToolPinnedConflictResponseDTOError
    {
        /// <summary>
        ///
        /// </summary>
        ToolPinned,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ToolPinnedConflictResponseDTOErrorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolPinnedConflictResponseDTOError value)
        {
            return value switch
            {
                ToolPinnedConflictResponseDTOError.ToolPinned => "tool_pinned",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolPinnedConflictResponseDTOError? ToEnum(string value)
        {
            return value switch
            {
                "tool_pinned" => ToolPinnedConflictResponseDTOError.ToolPinned,
                _ => null,
            };
        }
    }
}