
#nullable enable

namespace Vapi
{
    /// <summary>
    ///
    /// </summary>
    public enum UpdateWellSaidCredentialDTOProvider
    {
        /// <summary>
        ///
        /// </summary>
        Wellsaid,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateWellSaidCredentialDTOProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateWellSaidCredentialDTOProvider value)
        {
            return value switch
            {
                UpdateWellSaidCredentialDTOProvider.Wellsaid => "wellsaid",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateWellSaidCredentialDTOProvider? ToEnum(string value)
        {
            return value switch
            {
                "wellsaid" => UpdateWellSaidCredentialDTOProvider.Wellsaid,
                _ => null,
            };
        }
    }
}