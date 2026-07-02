
#nullable enable

namespace Vapi
{
    /// <summary>
    /// The type of tool. "function" for Function tool.
    /// </summary>
    public enum UpdateFunctionToolDTOType
    {
        /// <summary>
        /// 
        /// </summary>
        Function,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateFunctionToolDTOTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateFunctionToolDTOType value)
        {
            return value switch
            {
                UpdateFunctionToolDTOType.Function => "function",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateFunctionToolDTOType? ToEnum(string value)
        {
            return value switch
            {
                "function" => UpdateFunctionToolDTOType.Function,
                _ => null,
            };
        }
    }
}