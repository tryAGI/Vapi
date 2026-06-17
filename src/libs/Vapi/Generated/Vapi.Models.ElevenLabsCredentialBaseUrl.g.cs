
#nullable enable

namespace Vapi
{
    /// <summary>
    /// This is the ElevenLabs API environment the key belongs to — the global endpoint or the EU data residency endpoint. It is detected automatically while validating the key and is not honored from the request, so a rotated key is always re-homed to the environment that actually accepts it.<br/>
    /// Included only in responses
    /// </summary>
    public enum ElevenLabsCredentialBaseUrl
    {
        /// <summary>
        /// 
        /// </summary>
        Https_ApiElevenlabsIo,
        /// <summary>
        /// 
        /// </summary>
        Https_ApiEuResidencyElevenlabsIo,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ElevenLabsCredentialBaseUrlExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ElevenLabsCredentialBaseUrl value)
        {
            return value switch
            {
                ElevenLabsCredentialBaseUrl.Https_ApiElevenlabsIo => "https://api.elevenlabs.io",
                ElevenLabsCredentialBaseUrl.Https_ApiEuResidencyElevenlabsIo => "https://api.eu.residency.elevenlabs.io",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ElevenLabsCredentialBaseUrl? ToEnum(string value)
        {
            return value switch
            {
                "https://api.elevenlabs.io" => ElevenLabsCredentialBaseUrl.Https_ApiElevenlabsIo,
                "https://api.eu.residency.elevenlabs.io" => ElevenLabsCredentialBaseUrl.Https_ApiEuResidencyElevenlabsIo,
                _ => null,
            };
        }
    }
}