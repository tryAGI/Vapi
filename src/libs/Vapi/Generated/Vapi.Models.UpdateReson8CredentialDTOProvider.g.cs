
#nullable enable

namespace Vapi
{
    /// <summary>
    ///
    /// </summary>
    public enum UpdateReson8CredentialDTOProvider
    {
        /// <summary>
        ///
        /// </summary>
        Reson8,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateReson8CredentialDTOProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateReson8CredentialDTOProvider value)
        {
            return value switch
            {
                UpdateReson8CredentialDTOProvider.Reson8 => "reson8",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateReson8CredentialDTOProvider? ToEnum(string value)
        {
            return value switch
            {
                "reson8" => UpdateReson8CredentialDTOProvider.Reson8,
                _ => null,
            };
        }
    }
}