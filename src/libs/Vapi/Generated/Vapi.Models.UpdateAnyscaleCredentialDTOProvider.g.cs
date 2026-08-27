
#nullable enable

namespace Vapi
{
    /// <summary>
    ///
    /// </summary>
    public enum UpdateAnyscaleCredentialDTOProvider
    {
        /// <summary>
        ///
        /// </summary>
        Anyscale,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateAnyscaleCredentialDTOProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateAnyscaleCredentialDTOProvider value)
        {
            return value switch
            {
                UpdateAnyscaleCredentialDTOProvider.Anyscale => "anyscale",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateAnyscaleCredentialDTOProvider? ToEnum(string value)
        {
            return value switch
            {
                "anyscale" => UpdateAnyscaleCredentialDTOProvider.Anyscale,
                _ => null,
            };
        }
    }
}