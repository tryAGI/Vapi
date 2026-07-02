
#nullable enable

namespace Vapi
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateLmntCredentialDTOProvider
    {
        /// <summary>
        /// 
        /// </summary>
        Lmnt,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateLmntCredentialDTOProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateLmntCredentialDTOProvider value)
        {
            return value switch
            {
                UpdateLmntCredentialDTOProvider.Lmnt => "lmnt",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateLmntCredentialDTOProvider? ToEnum(string value)
        {
            return value switch
            {
                "lmnt" => UpdateLmntCredentialDTOProvider.Lmnt,
                _ => null,
            };
        }
    }
}