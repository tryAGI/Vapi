
#nullable enable

namespace Vapi
{
    /// <summary>
    /// 
    /// </summary>
    public enum FallbackXaiTranscriberProvider
    {
        /// <summary>
        /// 
        /// </summary>
        Xai,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FallbackXaiTranscriberProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FallbackXaiTranscriberProvider value)
        {
            return value switch
            {
                FallbackXaiTranscriberProvider.Xai => "xai",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FallbackXaiTranscriberProvider? ToEnum(string value)
        {
            return value switch
            {
                "xai" => FallbackXaiTranscriberProvider.Xai,
                _ => null,
            };
        }
    }
}