
#nullable enable

namespace Vapi
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateMicrosoftCredentialDTOProvider
    {
        /// <summary>
        ///
        /// </summary>
        Microsoft,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateMicrosoftCredentialDTOProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateMicrosoftCredentialDTOProvider value)
        {
            return value switch
            {
                CreateMicrosoftCredentialDTOProvider.Microsoft => "microsoft",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateMicrosoftCredentialDTOProvider? ToEnum(string value)
        {
            return value switch
            {
                "microsoft" => CreateMicrosoftCredentialDTOProvider.Microsoft,
                _ => null,
            };
        }
    }
}