
#nullable enable

namespace Vapi
{
    /// <summary>
    ///
    /// </summary>
    public enum TransientAssistantDTOClientMessage
    {
        /// <summary>
        ///
        /// </summary>
        AssistantSpeechStarted,
        /// <summary>
        ///
        /// </summary>
        AssistantStarted,
        /// <summary>
        ///
        /// </summary>
        ConversationUpdate,
        /// <summary>
        ///
        /// </summary>
        FunctionCall,
        /// <summary>
        ///
        /// </summary>
        FunctionCallResult,
        /// <summary>
        ///
        /// </summary>
        Hang,
        /// <summary>
        ///
        /// </summary>
        LanguageChanged,
        /// <summary>
        ///
        /// </summary>
        Metadata,
        /// <summary>
        ///
        /// </summary>
        ModelOutput,
        /// <summary>
        ///
        /// </summary>
        SpeechUpdate,
        /// <summary>
        ///
        /// </summary>
        StatusUpdate,
        /// <summary>
        ///
        /// </summary>
        ToolCalls,
        /// <summary>
        ///
        /// </summary>
        ToolCallsResult,
        /// <summary>
        ///
        /// </summary>
        ToolCompleted,
        /// <summary>
        ///
        /// </summary>
        Transcript,
        /// <summary>
        ///
        /// </summary>
        TransferUpdate,
        /// <summary>
        ///
        /// </summary>
        UserInterrupted,
        /// <summary>
        ///
        /// </summary>
        VoiceInput,
        /// <summary>
        ///
        /// </summary>
        WorkflowNodeStarted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TransientAssistantDTOClientMessageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TransientAssistantDTOClientMessage value)
        {
            return value switch
            {
                TransientAssistantDTOClientMessage.AssistantSpeechStarted => "assistant.speechStarted",
                TransientAssistantDTOClientMessage.AssistantStarted => "assistant.started",
                TransientAssistantDTOClientMessage.ConversationUpdate => "conversation-update",
                TransientAssistantDTOClientMessage.FunctionCall => "function-call",
                TransientAssistantDTOClientMessage.FunctionCallResult => "function-call-result",
                TransientAssistantDTOClientMessage.Hang => "hang",
                TransientAssistantDTOClientMessage.LanguageChanged => "language-changed",
                TransientAssistantDTOClientMessage.Metadata => "metadata",
                TransientAssistantDTOClientMessage.ModelOutput => "model-output",
                TransientAssistantDTOClientMessage.SpeechUpdate => "speech-update",
                TransientAssistantDTOClientMessage.StatusUpdate => "status-update",
                TransientAssistantDTOClientMessage.ToolCalls => "tool-calls",
                TransientAssistantDTOClientMessage.ToolCallsResult => "tool-calls-result",
                TransientAssistantDTOClientMessage.ToolCompleted => "tool.completed",
                TransientAssistantDTOClientMessage.Transcript => "transcript",
                TransientAssistantDTOClientMessage.TransferUpdate => "transfer-update",
                TransientAssistantDTOClientMessage.UserInterrupted => "user-interrupted",
                TransientAssistantDTOClientMessage.VoiceInput => "voice-input",
                TransientAssistantDTOClientMessage.WorkflowNodeStarted => "workflow.node.started",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TransientAssistantDTOClientMessage? ToEnum(string value)
        {
            return value switch
            {
                "assistant.speechStarted" => TransientAssistantDTOClientMessage.AssistantSpeechStarted,
                "assistant.started" => TransientAssistantDTOClientMessage.AssistantStarted,
                "conversation-update" => TransientAssistantDTOClientMessage.ConversationUpdate,
                "function-call" => TransientAssistantDTOClientMessage.FunctionCall,
                "function-call-result" => TransientAssistantDTOClientMessage.FunctionCallResult,
                "hang" => TransientAssistantDTOClientMessage.Hang,
                "language-changed" => TransientAssistantDTOClientMessage.LanguageChanged,
                "metadata" => TransientAssistantDTOClientMessage.Metadata,
                "model-output" => TransientAssistantDTOClientMessage.ModelOutput,
                "speech-update" => TransientAssistantDTOClientMessage.SpeechUpdate,
                "status-update" => TransientAssistantDTOClientMessage.StatusUpdate,
                "tool-calls" => TransientAssistantDTOClientMessage.ToolCalls,
                "tool-calls-result" => TransientAssistantDTOClientMessage.ToolCallsResult,
                "tool.completed" => TransientAssistantDTOClientMessage.ToolCompleted,
                "transcript" => TransientAssistantDTOClientMessage.Transcript,
                "transfer-update" => TransientAssistantDTOClientMessage.TransferUpdate,
                "user-interrupted" => TransientAssistantDTOClientMessage.UserInterrupted,
                "voice-input" => TransientAssistantDTOClientMessage.VoiceInput,
                "workflow.node.started" => TransientAssistantDTOClientMessage.WorkflowNodeStarted,
                _ => null,
            };
        }
    }
}