
#nullable enable

namespace Vapi
{
    /// <summary>
    /// This is the model that will be used for the transcription.<br/>
    /// Digit formatting can differ by model: `gpt-transcribe` may write spoken digit strings as words (for example, "four seven two"), where `gpt-4o-transcribe` and `gpt-4o-mini-transcribe` may write them as digits ("472"). Do not rely on either format.
    /// </summary>
    public enum FallbackOpenAITranscriberModel
    {
        /// <summary>
        /// `gpt-transcribe` may write spoken digit strings as words (for example, "four seven two"), where `gpt-4o-transcribe` and `gpt-4o-mini-transcribe` may write them as digits ("472"). Do not rely on either format.
        /// </summary>
        Gpt4oMiniTranscribe,
        /// <summary>
        /// `gpt-transcribe` may write spoken digit strings as words (for example, "four seven two"), where `gpt-4o-transcribe` and `gpt-4o-mini-transcribe` may write them as digits ("472"). Do not rely on either format.
        /// </summary>
        Gpt4oTranscribe,
        /// <summary>
        /// `gpt-transcribe` may write spoken digit strings as words (for example, "four seven two"), where `gpt-4o-transcribe` and `gpt-4o-mini-transcribe` may write them as digits ("472"). Do not rely on either format.
        /// </summary>
        GptTranscribe,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FallbackOpenAITranscriberModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FallbackOpenAITranscriberModel value)
        {
            return value switch
            {
                FallbackOpenAITranscriberModel.Gpt4oMiniTranscribe => "gpt-4o-mini-transcribe",
                FallbackOpenAITranscriberModel.Gpt4oTranscribe => "gpt-4o-transcribe",
                FallbackOpenAITranscriberModel.GptTranscribe => "gpt-transcribe",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FallbackOpenAITranscriberModel? ToEnum(string value)
        {
            return value switch
            {
                "gpt-4o-mini-transcribe" => FallbackOpenAITranscriberModel.Gpt4oMiniTranscribe,
                "gpt-4o-transcribe" => FallbackOpenAITranscriberModel.Gpt4oTranscribe,
                "gpt-transcribe" => FallbackOpenAITranscriberModel.GptTranscribe,
                _ => null,
            };
        }
    }
}