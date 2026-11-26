
#nullable enable

namespace Vapi
{
    /// <summary>
    ///
    /// </summary>
    public enum AssistantSaveResponseClientMessage
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
    public static class AssistantSaveResponseClientMessageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AssistantSaveResponseClientMessage value)
        {
            return value switch
            {
                AssistantSaveResponseClientMessage.AssistantSpeechStarted => "assistant.speechStarted",
                AssistantSaveResponseClientMessage.AssistantStarted => "assistant.started",
                AssistantSaveResponseClientMessage.ConversationUpdate => "conversation-update",
                AssistantSaveResponseClientMessage.FunctionCall => "function-call",
                AssistantSaveResponseClientMessage.FunctionCallResult => "function-call-result",
                AssistantSaveResponseClientMessage.Hang => "hang",
                AssistantSaveResponseClientMessage.LanguageChanged => "language-changed",
                AssistantSaveResponseClientMessage.Metadata => "metadata",
                AssistantSaveResponseClientMessage.ModelOutput => "model-output",
                AssistantSaveResponseClientMessage.SpeechUpdate => "speech-update",
                AssistantSaveResponseClientMessage.StatusUpdate => "status-update",
                AssistantSaveResponseClientMessage.ToolCalls => "tool-calls",
                AssistantSaveResponseClientMessage.ToolCallsResult => "tool-calls-result",
                AssistantSaveResponseClientMessage.ToolCompleted => "tool.completed",
                AssistantSaveResponseClientMessage.Transcript => "transcript",
                AssistantSaveResponseClientMessage.TransferUpdate => "transfer-update",
                AssistantSaveResponseClientMessage.UserInterrupted => "user-interrupted",
                AssistantSaveResponseClientMessage.VoiceInput => "voice-input",
                AssistantSaveResponseClientMessage.WorkflowNodeStarted => "workflow.node.started",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AssistantSaveResponseClientMessage? ToEnum(string value)
        {
            return value switch
            {
                "assistant.speechStarted" => AssistantSaveResponseClientMessage.AssistantSpeechStarted,
                "assistant.started" => AssistantSaveResponseClientMessage.AssistantStarted,
                "conversation-update" => AssistantSaveResponseClientMessage.ConversationUpdate,
                "function-call" => AssistantSaveResponseClientMessage.FunctionCall,
                "function-call-result" => AssistantSaveResponseClientMessage.FunctionCallResult,
                "hang" => AssistantSaveResponseClientMessage.Hang,
                "language-changed" => AssistantSaveResponseClientMessage.LanguageChanged,
                "metadata" => AssistantSaveResponseClientMessage.Metadata,
                "model-output" => AssistantSaveResponseClientMessage.ModelOutput,
                "speech-update" => AssistantSaveResponseClientMessage.SpeechUpdate,
                "status-update" => AssistantSaveResponseClientMessage.StatusUpdate,
                "tool-calls" => AssistantSaveResponseClientMessage.ToolCalls,
                "tool-calls-result" => AssistantSaveResponseClientMessage.ToolCallsResult,
                "tool.completed" => AssistantSaveResponseClientMessage.ToolCompleted,
                "transcript" => AssistantSaveResponseClientMessage.Transcript,
                "transfer-update" => AssistantSaveResponseClientMessage.TransferUpdate,
                "user-interrupted" => AssistantSaveResponseClientMessage.UserInterrupted,
                "voice-input" => AssistantSaveResponseClientMessage.VoiceInput,
                "workflow.node.started" => AssistantSaveResponseClientMessage.WorkflowNodeStarted,
                _ => null,
            };
        }
    }
}