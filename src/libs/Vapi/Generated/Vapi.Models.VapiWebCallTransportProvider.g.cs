
#nullable enable

namespace Vapi
{
    /// <summary>
    /// Vapi web call transport provider
    /// </summary>
    public enum VapiWebCallTransportProvider
    {
        /// <summary>
        /// 
        /// </summary>
        Daily,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VapiWebCallTransportProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VapiWebCallTransportProvider value)
        {
            return value switch
            {
                VapiWebCallTransportProvider.Daily => "daily",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VapiWebCallTransportProvider? ToEnum(string value)
        {
            return value switch
            {
                "daily" => VapiWebCallTransportProvider.Daily,
                _ => null,
            };
        }
    }
}