
#nullable enable

namespace Vapi
{
    /// <summary>
    ///
    /// </summary>
    public enum GuardrailAuthoringMode
    {
        /// <summary>
        ///
        /// </summary>
        Always,
        /// <summary>
        ///
        /// </summary>
        Never,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GuardrailAuthoringModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GuardrailAuthoringMode value)
        {
            return value switch
            {
                GuardrailAuthoringMode.Always => "always",
                GuardrailAuthoringMode.Never => "never",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GuardrailAuthoringMode? ToEnum(string value)
        {
            return value switch
            {
                "always" => GuardrailAuthoringMode.Always,
                "never" => GuardrailAuthoringMode.Never,
                _ => null,
            };
        }
    }
}