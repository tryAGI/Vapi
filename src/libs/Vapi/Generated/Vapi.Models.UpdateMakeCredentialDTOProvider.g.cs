
#nullable enable

namespace Vapi
{
    /// <summary>
    ///
    /// </summary>
    public enum UpdateMakeCredentialDTOProvider
    {
        /// <summary>
        ///
        /// </summary>
        Make,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateMakeCredentialDTOProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateMakeCredentialDTOProvider value)
        {
            return value switch
            {
                UpdateMakeCredentialDTOProvider.Make => "make",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateMakeCredentialDTOProvider? ToEnum(string value)
        {
            return value switch
            {
                "make" => UpdateMakeCredentialDTOProvider.Make,
                _ => null,
            };
        }
    }
}