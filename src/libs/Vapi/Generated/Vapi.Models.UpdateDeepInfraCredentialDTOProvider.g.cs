
#nullable enable

namespace Vapi
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateDeepInfraCredentialDTOProvider
    {
        /// <summary>
        /// 
        /// </summary>
        Deepinfra,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateDeepInfraCredentialDTOProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateDeepInfraCredentialDTOProvider value)
        {
            return value switch
            {
                UpdateDeepInfraCredentialDTOProvider.Deepinfra => "deepinfra",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateDeepInfraCredentialDTOProvider? ToEnum(string value)
        {
            return value switch
            {
                "deepinfra" => UpdateDeepInfraCredentialDTOProvider.Deepinfra,
                _ => null,
            };
        }
    }
}