
#nullable enable

namespace Vapi
{
    /// <summary>
    ///
    /// </summary>
    public enum UpdateRunpodCredentialDTOProvider
    {
        /// <summary>
        ///
        /// </summary>
        Runpod,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateRunpodCredentialDTOProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateRunpodCredentialDTOProvider value)
        {
            return value switch
            {
                UpdateRunpodCredentialDTOProvider.Runpod => "runpod",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateRunpodCredentialDTOProvider? ToEnum(string value)
        {
            return value switch
            {
                "runpod" => UpdateRunpodCredentialDTOProvider.Runpod,
                _ => null,
            };
        }
    }
}