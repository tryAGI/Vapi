
#nullable enable

namespace Vapi
{
    /// <summary>
    /// This is for S3-compatible storage such as MinIO, Garage, Ceph, or Backblaze B2.
    /// </summary>
    public enum S3CompatibleStorageCredentialProvider
    {
        /// <summary>
        /// 
        /// </summary>
        S3Compatible,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class S3CompatibleStorageCredentialProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this S3CompatibleStorageCredentialProvider value)
        {
            return value switch
            {
                S3CompatibleStorageCredentialProvider.S3Compatible => "s3-compatible",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static S3CompatibleStorageCredentialProvider? ToEnum(string value)
        {
            return value switch
            {
                "s3-compatible" => S3CompatibleStorageCredentialProvider.S3Compatible,
                _ => null,
            };
        }
    }
}