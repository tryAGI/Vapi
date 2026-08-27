
#nullable enable

namespace Vapi
{
    /// <summary>
    /// The type of tool. "bash" for Bash tool.
    /// </summary>
    public enum UpdateBashToolDTOType
    {
        /// <summary>
        ///
        /// </summary>
        Bash,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateBashToolDTOTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateBashToolDTOType value)
        {
            return value switch
            {
                UpdateBashToolDTOType.Bash => "bash",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateBashToolDTOType? ToEnum(string value)
        {
            return value switch
            {
                "bash" => UpdateBashToolDTOType.Bash,
                _ => null,
            };
        }
    }
}