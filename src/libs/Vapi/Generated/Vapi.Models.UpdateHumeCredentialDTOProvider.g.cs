
#nullable enable

namespace Vapi
{
    /// <summary>
    ///
    /// </summary>
    public enum UpdateHumeCredentialDTOProvider
    {
        /// <summary>
        ///
        /// </summary>
        Hume,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateHumeCredentialDTOProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateHumeCredentialDTOProvider value)
        {
            return value switch
            {
                UpdateHumeCredentialDTOProvider.Hume => "hume",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateHumeCredentialDTOProvider? ToEnum(string value)
        {
            return value switch
            {
                "hume" => UpdateHumeCredentialDTOProvider.Hume,
                _ => null,
            };
        }
    }
}