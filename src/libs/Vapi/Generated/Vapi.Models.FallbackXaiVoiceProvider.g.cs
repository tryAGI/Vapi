
#nullable enable

namespace Vapi
{
    /// <summary>
    /// This is the voice provider that will be used.
    /// </summary>
    public enum FallbackXaiVoiceProvider
    {
        /// <summary>
        /// 
        /// </summary>
        Xai,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FallbackXaiVoiceProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FallbackXaiVoiceProvider value)
        {
            return value switch
            {
                FallbackXaiVoiceProvider.Xai => "xai",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FallbackXaiVoiceProvider? ToEnum(string value)
        {
            return value switch
            {
                "xai" => FallbackXaiVoiceProvider.Xai,
                _ => null,
            };
        }
    }
}