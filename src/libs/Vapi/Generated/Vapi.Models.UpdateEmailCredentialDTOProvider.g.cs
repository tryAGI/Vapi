
#nullable enable

namespace Vapi
{
    /// <summary>
    ///
    /// </summary>
    public enum UpdateEmailCredentialDTOProvider
    {
        /// <summary>
        ///
        /// </summary>
        Email,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateEmailCredentialDTOProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateEmailCredentialDTOProvider value)
        {
            return value switch
            {
                UpdateEmailCredentialDTOProvider.Email => "email",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateEmailCredentialDTOProvider? ToEnum(string value)
        {
            return value switch
            {
                "email" => UpdateEmailCredentialDTOProvider.Email,
                _ => null,
            };
        }
    }
}