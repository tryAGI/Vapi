
#nullable enable

namespace Vapi
{
    /// <summary>
    ///
    /// </summary>
    public enum ToolControllerRemoveResponseDiscriminatorError
    {
        /// <summary>
        ///
        /// </summary>
        ToolPinned,
        /// <summary>
        ///
        /// </summary>
        ToolWriteConflict,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ToolControllerRemoveResponseDiscriminatorErrorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolControllerRemoveResponseDiscriminatorError value)
        {
            return value switch
            {
                ToolControllerRemoveResponseDiscriminatorError.ToolPinned => "tool_pinned",
                ToolControllerRemoveResponseDiscriminatorError.ToolWriteConflict => "tool_write_conflict",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolControllerRemoveResponseDiscriminatorError? ToEnum(string value)
        {
            return value switch
            {
                "tool_pinned" => ToolControllerRemoveResponseDiscriminatorError.ToolPinned,
                "tool_write_conflict" => ToolControllerRemoveResponseDiscriminatorError.ToolWriteConflict,
                _ => null,
            };
        }
    }
}