
#nullable enable

namespace Vapi
{
    /// <summary>
    /// ElevenLabs-only API environment for this key: the global endpoint or the EU data residency endpoint. In EU deployments, new credentials must explicitly use the EU data residency endpoint; existing credentials may omit this field on update to retain their saved endpoint. Outside EU deployments, Vapi detects an omitted endpoint automatically and null on update clears and re-detects the endpoint.
    /// </summary>
    public enum UpdateElevenLabsCredentialDTOApiUrl
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
    public static class UpdateElevenLabsCredentialDTOApiUrlExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateElevenLabsCredentialDTOApiUrl value)
        {
            return value switch
            {
                UpdateElevenLabsCredentialDTOApiUrl.Https_ApiElevenlabsIo => "https://api.elevenlabs.io",
                UpdateElevenLabsCredentialDTOApiUrl.Https_ApiEuResidencyElevenlabsIo => "https://api.eu.residency.elevenlabs.io",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateElevenLabsCredentialDTOApiUrl? ToEnum(string value)
        {
            return value switch
            {
                "https://api.elevenlabs.io" => UpdateElevenLabsCredentialDTOApiUrl.Https_ApiElevenlabsIo,
                "https://api.eu.residency.elevenlabs.io" => UpdateElevenLabsCredentialDTOApiUrl.Https_ApiEuResidencyElevenlabsIo,
                _ => null,
            };
        }
    }
}