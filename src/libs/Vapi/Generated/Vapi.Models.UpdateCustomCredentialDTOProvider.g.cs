
#nullable enable

namespace Vapi
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateCustomCredentialDTOProvider
    {
        /// <summary>
        /// 
        /// </summary>
        CustomCredential,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateCustomCredentialDTOProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateCustomCredentialDTOProvider value)
        {
            return value switch
            {
                UpdateCustomCredentialDTOProvider.CustomCredential => "custom-credential",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateCustomCredentialDTOProvider? ToEnum(string value)
        {
            return value switch
            {
                "custom-credential" => UpdateCustomCredentialDTOProvider.CustomCredential,
                _ => null,
            };
        }
    }
}