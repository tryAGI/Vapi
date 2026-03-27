
#nullable enable

namespace Vapi
{
    /// <summary>
    /// 
    /// </summary>
    public enum SonioxCredentialProvider
    {
        /// <summary>
        /// 
        /// </summary>
        Soniox,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SonioxCredentialProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SonioxCredentialProvider value)
        {
            return value switch
            {
                SonioxCredentialProvider.Soniox => "soniox",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SonioxCredentialProvider? ToEnum(string value)
        {
            return value switch
            {
                "soniox" => SonioxCredentialProvider.Soniox,
                _ => null,
            };
        }
    }
}