
#nullable enable

namespace Vapi
{
    /// <summary>
    /// This is the speech model used for the streaming session.<br/>
    /// Keyterms prompting is supported on universal-streaming-english, universal-3-5-pro and universal-3-6-pro.<br/>
    /// universal-3-6-pro is AssemblyAI's newest and most accurate voice-agent model.<br/>
    /// @default 'universal-streaming-english'
    /// </summary>
    public enum AssemblyAITranscriberSpeechModel
    {
        /// <summary>
        ///
        /// </summary>
        Universal35Pro,
        /// <summary>
        ///
        /// </summary>
        Universal36Pro,
        /// <summary>
        ///
        /// </summary>
        UniversalStreamingEnglish,
        /// <summary>
        ///
        /// </summary>
        UniversalStreamingMultilingual,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AssemblyAITranscriberSpeechModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AssemblyAITranscriberSpeechModel value)
        {
            return value switch
            {
                AssemblyAITranscriberSpeechModel.Universal35Pro => "universal-3-5-pro",
                AssemblyAITranscriberSpeechModel.Universal36Pro => "universal-3-6-pro",
                AssemblyAITranscriberSpeechModel.UniversalStreamingEnglish => "universal-streaming-english",
                AssemblyAITranscriberSpeechModel.UniversalStreamingMultilingual => "universal-streaming-multilingual",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AssemblyAITranscriberSpeechModel? ToEnum(string value)
        {
            return value switch
            {
                "universal-3-5-pro" => AssemblyAITranscriberSpeechModel.Universal35Pro,
                "universal-3-6-pro" => AssemblyAITranscriberSpeechModel.Universal36Pro,
                "universal-streaming-english" => AssemblyAITranscriberSpeechModel.UniversalStreamingEnglish,
                "universal-streaming-multilingual" => AssemblyAITranscriberSpeechModel.UniversalStreamingMultilingual,
                _ => null,
            };
        }
    }
}