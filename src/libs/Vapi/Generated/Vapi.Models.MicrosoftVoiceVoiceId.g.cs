
#nullable enable

namespace Vapi
{
    /// <summary>
    /// MAI-Voice-1 voice ID. Built-in voices listed in enum.<br/>
    /// Example: en-us-Jasper:MAI-Voice-1
    /// </summary>
    public enum MicrosoftVoiceVoiceId
    {
        /// <summary>
        /// 
        /// </summary>
        EnUsGrant_MAIVoice1,
        /// <summary>
        /// 
        /// </summary>
        EnUsIris_MAIVoice1,
        /// <summary>
        /// 
        /// </summary>
        EnUsJasper_MAIVoice1,
        /// <summary>
        /// 
        /// </summary>
        EnUsJoy_MAIVoice1,
        /// <summary>
        /// 
        /// </summary>
        EnUsJune_MAIVoice1,
        /// <summary>
        /// 
        /// </summary>
        EnUsReed_MAIVoice1,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MicrosoftVoiceVoiceIdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MicrosoftVoiceVoiceId value)
        {
            return value switch
            {
                MicrosoftVoiceVoiceId.EnUsGrant_MAIVoice1 => "en-us-Grant:MAI-Voice-1",
                MicrosoftVoiceVoiceId.EnUsIris_MAIVoice1 => "en-us-Iris:MAI-Voice-1",
                MicrosoftVoiceVoiceId.EnUsJasper_MAIVoice1 => "en-us-Jasper:MAI-Voice-1",
                MicrosoftVoiceVoiceId.EnUsJoy_MAIVoice1 => "en-us-Joy:MAI-Voice-1",
                MicrosoftVoiceVoiceId.EnUsJune_MAIVoice1 => "en-us-June:MAI-Voice-1",
                MicrosoftVoiceVoiceId.EnUsReed_MAIVoice1 => "en-us-Reed:MAI-Voice-1",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MicrosoftVoiceVoiceId? ToEnum(string value)
        {
            return value switch
            {
                "en-us-Grant:MAI-Voice-1" => MicrosoftVoiceVoiceId.EnUsGrant_MAIVoice1,
                "en-us-Iris:MAI-Voice-1" => MicrosoftVoiceVoiceId.EnUsIris_MAIVoice1,
                "en-us-Jasper:MAI-Voice-1" => MicrosoftVoiceVoiceId.EnUsJasper_MAIVoice1,
                "en-us-Joy:MAI-Voice-1" => MicrosoftVoiceVoiceId.EnUsJoy_MAIVoice1,
                "en-us-June:MAI-Voice-1" => MicrosoftVoiceVoiceId.EnUsJune_MAIVoice1,
                "en-us-Reed:MAI-Voice-1" => MicrosoftVoiceVoiceId.EnUsReed_MAIVoice1,
                _ => null,
            };
        }
    }
}