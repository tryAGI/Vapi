
#nullable enable

namespace Vapi
{
    /// <summary>
    /// This is for S3-compatible storage such as MinIO, Garage, Ceph, or Backblaze B2.
    /// </summary>
    public enum UpdateS3CompatibleCredentialDTOProvider
    {
        /// <summary>
        ///
        /// </summary>
        S3Compatible,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateS3CompatibleCredentialDTOProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateS3CompatibleCredentialDTOProvider value)
        {
            return value switch
            {
                UpdateS3CompatibleCredentialDTOProvider.S3Compatible => "s3-compatible",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateS3CompatibleCredentialDTOProvider? ToEnum(string value)
        {
            return value switch
            {
                "s3-compatible" => UpdateS3CompatibleCredentialDTOProvider.S3Compatible,
                _ => null,
            };
        }
    }
}