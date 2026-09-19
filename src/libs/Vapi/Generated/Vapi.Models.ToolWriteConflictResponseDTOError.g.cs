
#nullable enable

namespace Vapi
{
    /// <summary>
    ///
    /// </summary>
    public enum ToolWriteConflictResponseDTOError
    {
        /// <summary>
        ///
        /// </summary>
        ToolWriteConflict,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ToolWriteConflictResponseDTOErrorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolWriteConflictResponseDTOError value)
        {
            return value switch
            {
                ToolWriteConflictResponseDTOError.ToolWriteConflict => "tool_write_conflict",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolWriteConflictResponseDTOError? ToEnum(string value)
        {
            return value switch
            {
                "tool_write_conflict" => ToolWriteConflictResponseDTOError.ToolWriteConflict,
                _ => null,
            };
        }
    }
}