
#nullable enable

namespace Vapi
{
    /// <summary>
    /// The type of tool. "make" for Make tool.
    /// </summary>
    public enum UpdateMakeToolDTOType
    {
        /// <summary>
        /// 
        /// </summary>
        Make,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateMakeToolDTOTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateMakeToolDTOType value)
        {
            return value switch
            {
                UpdateMakeToolDTOType.Make => "make",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateMakeToolDTOType? ToEnum(string value)
        {
            return value switch
            {
                "make" => UpdateMakeToolDTOType.Make,
                _ => null,
            };
        }
    }
}