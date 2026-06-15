
#nullable enable

namespace Vapi
{
    /// <summary>
    /// 
    /// </summary>
    public enum MicrosoftCredentialProvider
    {
        /// <summary>
        /// 
        /// </summary>
        Microsoft,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MicrosoftCredentialProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MicrosoftCredentialProvider value)
        {
            return value switch
            {
                MicrosoftCredentialProvider.Microsoft => "microsoft",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MicrosoftCredentialProvider? ToEnum(string value)
        {
            return value switch
            {
                "microsoft" => MicrosoftCredentialProvider.Microsoft,
                _ => null,
            };
        }
    }
}