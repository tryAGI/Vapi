
#nullable enable

namespace Vapi
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateAzureCredentialDTOProvider
    {
        /// <summary>
        /// 
        /// </summary>
        Azure,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateAzureCredentialDTOProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateAzureCredentialDTOProvider value)
        {
            return value switch
            {
                CreateAzureCredentialDTOProvider.Azure => "azure",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateAzureCredentialDTOProvider? ToEnum(string value)
        {
            return value switch
            {
                "azure" => CreateAzureCredentialDTOProvider.Azure,
                _ => null,
            };
        }
    }
}