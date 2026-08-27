
#nullable enable

namespace Vapi
{
    /// <summary>
    ///
    /// </summary>
    public enum UpdateAzureCredentialDTOProvider
    {
        /// <summary>
        ///
        /// </summary>
        Azure,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateAzureCredentialDTOProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateAzureCredentialDTOProvider value)
        {
            return value switch
            {
                UpdateAzureCredentialDTOProvider.Azure => "azure",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateAzureCredentialDTOProvider? ToEnum(string value)
        {
            return value switch
            {
                "azure" => UpdateAzureCredentialDTOProvider.Azure,
                _ => null,
            };
        }
    }
}