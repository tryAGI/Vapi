
#nullable enable

namespace Vapi
{
    /// <summary>
    /// This is the voice provider that will be used.
    /// </summary>
    public enum MicrosoftVoiceProvider
    {
        /// <summary>
        ///
        /// </summary>
        Microsoft,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MicrosoftVoiceProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MicrosoftVoiceProvider value)
        {
            return value switch
            {
                MicrosoftVoiceProvider.Microsoft => "microsoft",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MicrosoftVoiceProvider? ToEnum(string value)
        {
            return value switch
            {
                "microsoft" => MicrosoftVoiceProvider.Microsoft,
                _ => null,
            };
        }
    }
}