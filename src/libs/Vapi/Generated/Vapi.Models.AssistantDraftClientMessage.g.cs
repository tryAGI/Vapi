
#nullable enable

namespace Vapi
{
    /// <summary>
    /// 
    /// </summary>
    public enum AssistantDraftClientMessage
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
    public static class AssistantDraftClientMessageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AssistantDraftClientMessage value)
        {
            return value switch
            {
                AssistantDraftClientMessage.AssistantSpeechStarted => "assistant.speechStarted",
                AssistantDraftClientMessage.AssistantStarted => "assistant.started",
                AssistantDraftClientMessage.ConversationUpdate => "conversation-update",
                AssistantDraftClientMessage.FunctionCall => "function-call",
                AssistantDraftClientMessage.FunctionCallResult => "function-call-result",
                AssistantDraftClientMessage.Hang => "hang",
                AssistantDraftClientMessage.LanguageChanged => "language-changed",
                AssistantDraftClientMessage.Metadata => "metadata",
                AssistantDraftClientMessage.ModelOutput => "model-output",
                AssistantDraftClientMessage.SpeechUpdate => "speech-update",
                AssistantDraftClientMessage.StatusUpdate => "status-update",
                AssistantDraftClientMessage.ToolCalls => "tool-calls",
                AssistantDraftClientMessage.ToolCallsResult => "tool-calls-result",
                AssistantDraftClientMessage.ToolCompleted => "tool.completed",
                AssistantDraftClientMessage.Transcript => "transcript",
                AssistantDraftClientMessage.TransferUpdate => "transfer-update",
                AssistantDraftClientMessage.UserInterrupted => "user-interrupted",
                AssistantDraftClientMessage.VoiceInput => "voice-input",
                AssistantDraftClientMessage.WorkflowNodeStarted => "workflow.node.started",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AssistantDraftClientMessage? ToEnum(string value)
        {
            return value switch
            {
                "assistant.speechStarted" => AssistantDraftClientMessage.AssistantSpeechStarted,
                "assistant.started" => AssistantDraftClientMessage.AssistantStarted,
                "conversation-update" => AssistantDraftClientMessage.ConversationUpdate,
                "function-call" => AssistantDraftClientMessage.FunctionCall,
                "function-call-result" => AssistantDraftClientMessage.FunctionCallResult,
                "hang" => AssistantDraftClientMessage.Hang,
                "language-changed" => AssistantDraftClientMessage.LanguageChanged,
                "metadata" => AssistantDraftClientMessage.Metadata,
                "model-output" => AssistantDraftClientMessage.ModelOutput,
                "speech-update" => AssistantDraftClientMessage.SpeechUpdate,
                "status-update" => AssistantDraftClientMessage.StatusUpdate,
                "tool-calls" => AssistantDraftClientMessage.ToolCalls,
                "tool-calls-result" => AssistantDraftClientMessage.ToolCallsResult,
                "tool.completed" => AssistantDraftClientMessage.ToolCompleted,
                "transcript" => AssistantDraftClientMessage.Transcript,
                "transfer-update" => AssistantDraftClientMessage.TransferUpdate,
                "user-interrupted" => AssistantDraftClientMessage.UserInterrupted,
                "voice-input" => AssistantDraftClientMessage.VoiceInput,
                "workflow.node.started" => AssistantDraftClientMessage.WorkflowNodeStarted,
                _ => null,
            };
        }
    }
}