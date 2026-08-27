
#nullable enable

namespace Vapi
{
    /// <summary>
    /// The type of tool. "code" for Code tool.
    /// </summary>
    public enum UpdateCodeToolDTOType
    {
        /// <summary>
        ///
        /// </summary>
        Code,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateCodeToolDTOTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateCodeToolDTOType value)
        {
            return value switch
            {
                UpdateCodeToolDTOType.Code => "code",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateCodeToolDTOType? ToEnum(string value)
        {
            return value switch
            {
                "code" => UpdateCodeToolDTOType.Code,
                _ => null,
            };
        }
    }
}