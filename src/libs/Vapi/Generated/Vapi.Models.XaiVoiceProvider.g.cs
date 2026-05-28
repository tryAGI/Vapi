
#nullable enable

namespace Vapi
{
    /// <summary>
    /// This is the voice provider that will be used.
    /// </summary>
    public enum XaiVoiceProvider
    {
        /// <summary>
        /// 
        /// </summary>
        Xai,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class XaiVoiceProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this XaiVoiceProvider value)
        {
            return value switch
            {
                XaiVoiceProvider.Xai => "xai",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static XaiVoiceProvider? ToEnum(string value)
        {
            return value switch
            {
                "xai" => XaiVoiceProvider.Xai,
                _ => null,
            };
        }
    }
}