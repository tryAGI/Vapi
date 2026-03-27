
#nullable enable

namespace Vapi
{
    /// <summary>
    /// This is the delimiter(s) that will be used to process the input.<br/>
    /// Can be '#', '*', or an empty array.
    /// </summary>
    public enum KeypadInputPlanDelimiters
    {
        /// <summary>
        /// 
        /// </summary>
        x_,
        /// <summary>
        /// 
        /// </summary>
        Any,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class KeypadInputPlanDelimitersExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this KeypadInputPlanDelimiters value)
        {
            return value switch
            {
                KeypadInputPlanDelimiters.x_ => "#",
                KeypadInputPlanDelimiters.Any => "*",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static KeypadInputPlanDelimiters? ToEnum(string value)
        {
            return value switch
            {
                "#" => KeypadInputPlanDelimiters.x_,
                "*" => KeypadInputPlanDelimiters.Any,
                _ => null,
            };
        }
    }
}