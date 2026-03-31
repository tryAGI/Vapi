
#nullable enable

namespace Vapi
{
    /// <summary>
    /// Indicates how the text was sourced.
    /// </summary>
    public enum ServerMessageAssistantSpeechSource
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
    public static class ServerMessageAssistantSpeechSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ServerMessageAssistantSpeechSource value)
        {
            return value switch
            {
                ServerMessageAssistantSpeechSource.CustomVoice => "custom-voice",
                ServerMessageAssistantSpeechSource.ForceSay => "force-say",
                ServerMessageAssistantSpeechSource.Model => "model",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ServerMessageAssistantSpeechSource? ToEnum(string value)
        {
            return value switch
            {
                "custom-voice" => ServerMessageAssistantSpeechSource.CustomVoice,
                "force-say" => ServerMessageAssistantSpeechSource.ForceSay,
                "model" => ServerMessageAssistantSpeechSource.Model,
                _ => null,
            };
        }
    }
}