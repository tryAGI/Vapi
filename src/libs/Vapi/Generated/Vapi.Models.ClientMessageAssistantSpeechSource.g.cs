
#nullable enable

namespace Vapi
{
    /// <summary>
    /// Indicates how the text was sourced.
    /// </summary>
    public enum ClientMessageAssistantSpeechSource
    {
        /// <summary>
        /// 
        /// </summary>
        CustomVoice,
        /// <summary>
        /// 
        /// </summary>
        ForceSay,
        /// <summary>
        /// 
        /// </summary>
        Model,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ClientMessageAssistantSpeechSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ClientMessageAssistantSpeechSource value)
        {
            return value switch
            {
                ClientMessageAssistantSpeechSource.CustomVoice => "custom-voice",
                ClientMessageAssistantSpeechSource.ForceSay => "force-say",
                ClientMessageAssistantSpeechSource.Model => "model",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ClientMessageAssistantSpeechSource? ToEnum(string value)
        {
            return value switch
            {
                "custom-voice" => ClientMessageAssistantSpeechSource.CustomVoice,
                "force-say" => ClientMessageAssistantSpeechSource.ForceSay,
                "model" => ClientMessageAssistantSpeechSource.Model,
                _ => null,
            };
        }
    }
}