
#nullable enable

namespace Vapi
{
    /// <summary>
    /// 
    /// </summary>
    public enum XaiTranscriberProvider
    {
        /// <summary>
        /// 
        /// </summary>
        Xai,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class XaiTranscriberProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this XaiTranscriberProvider value)
        {
            return value switch
            {
                XaiTranscriberProvider.Xai => "xai",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static XaiTranscriberProvider? ToEnum(string value)
        {
            return value switch
            {
                "xai" => XaiTranscriberProvider.Xai,
                _ => null,
            };
        }
    }
}