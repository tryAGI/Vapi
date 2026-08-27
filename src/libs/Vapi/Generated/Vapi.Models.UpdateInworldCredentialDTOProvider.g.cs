
#nullable enable

namespace Vapi
{
    /// <summary>
    ///
    /// </summary>
    public enum UpdateInworldCredentialDTOProvider
    {
        /// <summary>
        ///
        /// </summary>
        Inworld,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateInworldCredentialDTOProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateInworldCredentialDTOProvider value)
        {
            return value switch
            {
                UpdateInworldCredentialDTOProvider.Inworld => "inworld",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateInworldCredentialDTOProvider? ToEnum(string value)
        {
            return value switch
            {
                "inworld" => UpdateInworldCredentialDTOProvider.Inworld,
                _ => null,
            };
        }
    }
}