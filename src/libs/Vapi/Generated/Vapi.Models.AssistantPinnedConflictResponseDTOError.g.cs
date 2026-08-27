
#nullable enable

namespace Vapi
{
    /// <summary>
    ///
    /// </summary>
    public enum AssistantPinnedConflictResponseDTOError
    {
        /// <summary>
        ///
        /// </summary>
        AssistantPinned,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AssistantPinnedConflictResponseDTOErrorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AssistantPinnedConflictResponseDTOError value)
        {
            return value switch
            {
                AssistantPinnedConflictResponseDTOError.AssistantPinned => "assistant_pinned",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AssistantPinnedConflictResponseDTOError? ToEnum(string value)
        {
            return value switch
            {
                "assistant_pinned" => AssistantPinnedConflictResponseDTOError.AssistantPinned,
                _ => null,
            };
        }
    }
}