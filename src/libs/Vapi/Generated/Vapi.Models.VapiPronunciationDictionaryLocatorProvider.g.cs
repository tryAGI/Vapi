
#nullable enable

namespace Vapi
{
    /// <summary>
    /// Provider that hosts this pronunciation dictionary<br/>
    /// Example: 11labs
    /// </summary>
    public enum VapiPronunciationDictionaryLocatorProvider
    {
        /// <summary>
        /// 
        /// </summary>
        x11labs,
        /// <summary>
        /// 
        /// </summary>
        Cartesia,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VapiPronunciationDictionaryLocatorProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VapiPronunciationDictionaryLocatorProvider value)
        {
            return value switch
            {
                VapiPronunciationDictionaryLocatorProvider.x11labs => "11labs",
                VapiPronunciationDictionaryLocatorProvider.Cartesia => "cartesia",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VapiPronunciationDictionaryLocatorProvider? ToEnum(string value)
        {
            return value switch
            {
                "11labs" => VapiPronunciationDictionaryLocatorProvider.x11labs,
                "cartesia" => VapiPronunciationDictionaryLocatorProvider.Cartesia,
                _ => null,
            };
        }
    }
}