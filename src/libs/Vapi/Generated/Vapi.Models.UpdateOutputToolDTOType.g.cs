
#nullable enable

namespace Vapi
{
    /// <summary>
    /// The type of tool. "output" for Output tool.
    /// </summary>
    public enum UpdateOutputToolDTOType
    {
        /// <summary>
        ///
        /// </summary>
        Output,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateOutputToolDTOTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateOutputToolDTOType value)
        {
            return value switch
            {
                UpdateOutputToolDTOType.Output => "output",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateOutputToolDTOType? ToEnum(string value)
        {
            return value switch
            {
                "output" => UpdateOutputToolDTOType.Output,
                _ => null,
            };
        }
    }
}