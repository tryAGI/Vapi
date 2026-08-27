
#nullable enable

namespace Vapi
{
    /// <summary>
    /// This is the voice provider that will be used.
    /// </summary>
    public enum FallbackMicrosoftVoiceProvider
    {
        /// <summary>
        ///
        /// </summary>
        Microsoft,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FallbackMicrosoftVoiceProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FallbackMicrosoftVoiceProvider value)
        {
            return value switch
            {
                FallbackMicrosoftVoiceProvider.Microsoft => "microsoft",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FallbackMicrosoftVoiceProvider? ToEnum(string value)
        {
            return value switch
            {
                "microsoft" => FallbackMicrosoftVoiceProvider.Microsoft,
                _ => null,
            };
        }
    }
}