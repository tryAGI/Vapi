
#nullable enable

namespace Vapi
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateReson8CredentialDTOProvider
    {
        /// <summary>
        ///
        /// </summary>
        Reson8,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateReson8CredentialDTOProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateReson8CredentialDTOProvider value)
        {
            return value switch
            {
                CreateReson8CredentialDTOProvider.Reson8 => "reson8",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateReson8CredentialDTOProvider? ToEnum(string value)
        {
            return value switch
            {
                "reson8" => CreateReson8CredentialDTOProvider.Reson8,
                _ => null,
            };
        }
    }
}