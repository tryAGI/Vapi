
#nullable enable

namespace Vapi
{
    /// <summary>
    ///
    /// </summary>
    public enum UpdateDeepgramCredentialDTOProvider
    {
        /// <summary>
        ///
        /// </summary>
        Deepgram,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateDeepgramCredentialDTOProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateDeepgramCredentialDTOProvider value)
        {
            return value switch
            {
                UpdateDeepgramCredentialDTOProvider.Deepgram => "deepgram",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateDeepgramCredentialDTOProvider? ToEnum(string value)
        {
            return value switch
            {
                "deepgram" => UpdateDeepgramCredentialDTOProvider.Deepgram,
                _ => null,
            };
        }
    }
}