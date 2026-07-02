
#nullable enable

namespace Vapi
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateElevenLabsCredentialDTOProvider
    {
        /// <summary>
        /// 
        /// </summary>
        x11labs,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateElevenLabsCredentialDTOProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateElevenLabsCredentialDTOProvider value)
        {
            return value switch
            {
                UpdateElevenLabsCredentialDTOProvider.x11labs => "11labs",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateElevenLabsCredentialDTOProvider? ToEnum(string value)
        {
            return value switch
            {
                "11labs" => UpdateElevenLabsCredentialDTOProvider.x11labs,
                _ => null,
            };
        }
    }
}