
#nullable enable

namespace Vapi
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateGladiaCredentialDTOProvider
    {
        /// <summary>
        /// 
        /// </summary>
        Gladia,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateGladiaCredentialDTOProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateGladiaCredentialDTOProvider value)
        {
            return value switch
            {
                UpdateGladiaCredentialDTOProvider.Gladia => "gladia",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateGladiaCredentialDTOProvider? ToEnum(string value)
        {
            return value switch
            {
                "gladia" => UpdateGladiaCredentialDTOProvider.Gladia,
                _ => null,
            };
        }
    }
}