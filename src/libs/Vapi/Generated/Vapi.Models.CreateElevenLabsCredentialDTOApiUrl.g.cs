
#nullable enable

namespace Vapi
{
    /// <summary>
    /// ElevenLabs-only API environment for this key: the global endpoint or the EU data residency endpoint. If omitted on create, Vapi detects it automatically. If set to null on update, Vapi clears the saved endpoint and re-detects it with the saved API key.
    /// </summary>
    public enum CreateElevenLabsCredentialDTOApiUrl
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
    public static class CreateElevenLabsCredentialDTOApiUrlExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateElevenLabsCredentialDTOApiUrl value)
        {
            return value switch
            {
                CreateElevenLabsCredentialDTOApiUrl.Https_ApiElevenlabsIo => "https://api.elevenlabs.io",
                CreateElevenLabsCredentialDTOApiUrl.Https_ApiEuResidencyElevenlabsIo => "https://api.eu.residency.elevenlabs.io",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateElevenLabsCredentialDTOApiUrl? ToEnum(string value)
        {
            return value switch
            {
                "https://api.elevenlabs.io" => CreateElevenLabsCredentialDTOApiUrl.Https_ApiElevenlabsIo,
                "https://api.eu.residency.elevenlabs.io" => CreateElevenLabsCredentialDTOApiUrl.Https_ApiEuResidencyElevenlabsIo,
                _ => null,
            };
        }
    }
}