
#nullable enable

namespace Vapi
{
    /// <summary>
    /// MAI-Voice-1 voice ID. Built-in voices listed in enum.<br/>
    /// Example: en-us-Jasper:MAI-Voice-1
    /// </summary>
    public enum FallbackMicrosoftVoiceVoiceId
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
    public static class FallbackMicrosoftVoiceVoiceIdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FallbackMicrosoftVoiceVoiceId value)
        {
            return value switch
            {
                FallbackMicrosoftVoiceVoiceId.EnUsGrant_MAIVoice1 => "en-us-Grant:MAI-Voice-1",
                FallbackMicrosoftVoiceVoiceId.EnUsIris_MAIVoice1 => "en-us-Iris:MAI-Voice-1",
                FallbackMicrosoftVoiceVoiceId.EnUsJasper_MAIVoice1 => "en-us-Jasper:MAI-Voice-1",
                FallbackMicrosoftVoiceVoiceId.EnUsJoy_MAIVoice1 => "en-us-Joy:MAI-Voice-1",
                FallbackMicrosoftVoiceVoiceId.EnUsJune_MAIVoice1 => "en-us-June:MAI-Voice-1",
                FallbackMicrosoftVoiceVoiceId.EnUsReed_MAIVoice1 => "en-us-Reed:MAI-Voice-1",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FallbackMicrosoftVoiceVoiceId? ToEnum(string value)
        {
            return value switch
            {
                "en-us-Grant:MAI-Voice-1" => FallbackMicrosoftVoiceVoiceId.EnUsGrant_MAIVoice1,
                "en-us-Iris:MAI-Voice-1" => FallbackMicrosoftVoiceVoiceId.EnUsIris_MAIVoice1,
                "en-us-Jasper:MAI-Voice-1" => FallbackMicrosoftVoiceVoiceId.EnUsJasper_MAIVoice1,
                "en-us-Joy:MAI-Voice-1" => FallbackMicrosoftVoiceVoiceId.EnUsJoy_MAIVoice1,
                "en-us-June:MAI-Voice-1" => FallbackMicrosoftVoiceVoiceId.EnUsJune_MAIVoice1,
                "en-us-Reed:MAI-Voice-1" => FallbackMicrosoftVoiceVoiceId.EnUsReed_MAIVoice1,
                _ => null,
            };
        }
    }
}