
#nullable enable

namespace Vapi
{
    /// <summary>
    ///
    /// </summary>
    public enum VapiTranscriberProvider
    {
        /// <summary>
        ///
        /// </summary>
        Vapi,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VapiTranscriberProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VapiTranscriberProvider value)
        {
            return value switch
            {
                VapiTranscriberProvider.Vapi => "vapi",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VapiTranscriberProvider? ToEnum(string value)
        {
            return value switch
            {
                "vapi" => VapiTranscriberProvider.Vapi,
                _ => null,
            };
        }
    }
}