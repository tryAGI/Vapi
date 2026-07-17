
#nullable enable

namespace Vapi
{
    /// <summary>
    /// 
    /// </summary>
    public enum VersionPinConflictResponseDTOError
    {
        /// <summary>
        /// 
        /// </summary>
        VersionPinned,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VersionPinConflictResponseDTOErrorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VersionPinConflictResponseDTOError value)
        {
            return value switch
            {
                VersionPinConflictResponseDTOError.VersionPinned => "version_pinned",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VersionPinConflictResponseDTOError? ToEnum(string value)
        {
            return value switch
            {
                "version_pinned" => VersionPinConflictResponseDTOError.VersionPinned,
                _ => null,
            };
        }
    }
}