
#nullable enable

namespace Vapi
{
    /// <summary>
    /// Omitted legacy modes normalize to fixed when transformed.<br/>
    /// Default Value: fixed
    /// </summary>
    public enum GuardrailFixedResponseActionMode
    {
        /// <summary>
        ///
        /// </summary>
        Fixed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GuardrailFixedResponseActionModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GuardrailFixedResponseActionMode value)
        {
            return value switch
            {
                GuardrailFixedResponseActionMode.Fixed => "fixed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GuardrailFixedResponseActionMode? ToEnum(string value)
        {
            return value switch
            {
                "fixed" => GuardrailFixedResponseActionMode.Fixed,
                _ => null,
            };
        }
    }
}