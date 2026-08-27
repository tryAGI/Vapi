
#nullable enable

namespace Vapi
{
    /// <summary>
    /// The type of tool. "computer" for Computer tool.
    /// </summary>
    public enum UpdateComputerToolDTOType
    {
        /// <summary>
        ///
        /// </summary>
        Computer,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateComputerToolDTOTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateComputerToolDTOType value)
        {
            return value switch
            {
                UpdateComputerToolDTOType.Computer => "computer",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateComputerToolDTOType? ToEnum(string value)
        {
            return value switch
            {
                "computer" => UpdateComputerToolDTOType.Computer,
                _ => null,
            };
        }
    }
}