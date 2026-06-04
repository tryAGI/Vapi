
#nullable enable

namespace Vapi
{
    /// <summary>
    /// Vonage transport provider
    /// </summary>
    public enum VonageTransportProvider
    {
        /// <summary>
        /// 
        /// </summary>
        Vonage,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VonageTransportProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VonageTransportProvider value)
        {
            return value switch
            {
                VonageTransportProvider.Vonage => "vonage",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VonageTransportProvider? ToEnum(string value)
        {
            return value switch
            {
                "vonage" => VonageTransportProvider.Vonage,
                _ => null,
            };
        }
    }
}