
#nullable enable

namespace Vapi
{
    /// <summary>
    /// Machine-readable reason for the warning.<br/>
    /// Example: fallback-voice-same-provider
    /// </summary>
    public enum AssistantFallbackWarningCode
    {
        /// <summary>
        ///
        /// </summary>
        FallbackTranscriberLanguageUnsupported,
        /// <summary>
        ///
        /// </summary>
        FallbackTranscriberSameProvider,
        /// <summary>
        ///
        /// </summary>
        FallbackTranscribersEmpty,
        /// <summary>
        ///
        /// </summary>
        FallbackVoiceInvalid,
        /// <summary>
        ///
        /// </summary>
        FallbackVoiceLanguageUnsupported,
        /// <summary>
        ///
        /// </summary>
        FallbackVoiceSameProvider,
        /// <summary>
        ///
        /// </summary>
        FallbackVoicesEmpty,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AssistantFallbackWarningCodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AssistantFallbackWarningCode value)
        {
            return value switch
            {
                AssistantFallbackWarningCode.FallbackTranscriberLanguageUnsupported => "fallback-transcriber-language-unsupported",
                AssistantFallbackWarningCode.FallbackTranscriberSameProvider => "fallback-transcriber-same-provider",
                AssistantFallbackWarningCode.FallbackTranscribersEmpty => "fallback-transcribers-empty",
                AssistantFallbackWarningCode.FallbackVoiceInvalid => "fallback-voice-invalid",
                AssistantFallbackWarningCode.FallbackVoiceLanguageUnsupported => "fallback-voice-language-unsupported",
                AssistantFallbackWarningCode.FallbackVoiceSameProvider => "fallback-voice-same-provider",
                AssistantFallbackWarningCode.FallbackVoicesEmpty => "fallback-voices-empty",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AssistantFallbackWarningCode? ToEnum(string value)
        {
            return value switch
            {
                "fallback-transcriber-language-unsupported" => AssistantFallbackWarningCode.FallbackTranscriberLanguageUnsupported,
                "fallback-transcriber-same-provider" => AssistantFallbackWarningCode.FallbackTranscriberSameProvider,
                "fallback-transcribers-empty" => AssistantFallbackWarningCode.FallbackTranscribersEmpty,
                "fallback-voice-invalid" => AssistantFallbackWarningCode.FallbackVoiceInvalid,
                "fallback-voice-language-unsupported" => AssistantFallbackWarningCode.FallbackVoiceLanguageUnsupported,
                "fallback-voice-same-provider" => AssistantFallbackWarningCode.FallbackVoiceSameProvider,
                "fallback-voices-empty" => AssistantFallbackWarningCode.FallbackVoicesEmpty,
                _ => null,
            };
        }
    }
}