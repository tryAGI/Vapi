
#nullable enable

namespace Vapi
{
    /// <summary>
    /// Credential provider. Only allowed value is s3
    /// </summary>
    public enum UpdateS3CredentialDTOProvider
    {
        /// <summary>
        ///
        /// </summary>
        S3,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateS3CredentialDTOProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateS3CredentialDTOProvider value)
        {
            return value switch
            {
                UpdateS3CredentialDTOProvider.S3 => "s3",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateS3CredentialDTOProvider? ToEnum(string value)
        {
            return value switch
            {
                "s3" => UpdateS3CredentialDTOProvider.S3,
                _ => null,
            };
        }
    }
}