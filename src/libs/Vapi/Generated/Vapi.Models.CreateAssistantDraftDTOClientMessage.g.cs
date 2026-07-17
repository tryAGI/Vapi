
#nullable enable

namespace Vapi
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateAssistantDraftDTOClientMessage
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
    public static class CreateAssistantDraftDTOClientMessageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateAssistantDraftDTOClientMessage value)
        {
            return value switch
            {
                CreateAssistantDraftDTOClientMessage.AssistantSpeechStarted => "assistant.speechStarted",
                CreateAssistantDraftDTOClientMessage.AssistantStarted => "assistant.started",
                CreateAssistantDraftDTOClientMessage.ConversationUpdate => "conversation-update",
                CreateAssistantDraftDTOClientMessage.FunctionCall => "function-call",
                CreateAssistantDraftDTOClientMessage.FunctionCallResult => "function-call-result",
                CreateAssistantDraftDTOClientMessage.Hang => "hang",
                CreateAssistantDraftDTOClientMessage.LanguageChanged => "language-changed",
                CreateAssistantDraftDTOClientMessage.Metadata => "metadata",
                CreateAssistantDraftDTOClientMessage.ModelOutput => "model-output",
                CreateAssistantDraftDTOClientMessage.SpeechUpdate => "speech-update",
                CreateAssistantDraftDTOClientMessage.StatusUpdate => "status-update",
                CreateAssistantDraftDTOClientMessage.ToolCalls => "tool-calls",
                CreateAssistantDraftDTOClientMessage.ToolCallsResult => "tool-calls-result",
                CreateAssistantDraftDTOClientMessage.ToolCompleted => "tool.completed",
                CreateAssistantDraftDTOClientMessage.Transcript => "transcript",
                CreateAssistantDraftDTOClientMessage.TransferUpdate => "transfer-update",
                CreateAssistantDraftDTOClientMessage.UserInterrupted => "user-interrupted",
                CreateAssistantDraftDTOClientMessage.VoiceInput => "voice-input",
                CreateAssistantDraftDTOClientMessage.WorkflowNodeStarted => "workflow.node.started",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateAssistantDraftDTOClientMessage? ToEnum(string value)
        {
            return value switch
            {
                "assistant.speechStarted" => CreateAssistantDraftDTOClientMessage.AssistantSpeechStarted,
                "assistant.started" => CreateAssistantDraftDTOClientMessage.AssistantStarted,
                "conversation-update" => CreateAssistantDraftDTOClientMessage.ConversationUpdate,
                "function-call" => CreateAssistantDraftDTOClientMessage.FunctionCall,
                "function-call-result" => CreateAssistantDraftDTOClientMessage.FunctionCallResult,
                "hang" => CreateAssistantDraftDTOClientMessage.Hang,
                "language-changed" => CreateAssistantDraftDTOClientMessage.LanguageChanged,
                "metadata" => CreateAssistantDraftDTOClientMessage.Metadata,
                "model-output" => CreateAssistantDraftDTOClientMessage.ModelOutput,
                "speech-update" => CreateAssistantDraftDTOClientMessage.SpeechUpdate,
                "status-update" => CreateAssistantDraftDTOClientMessage.StatusUpdate,
                "tool-calls" => CreateAssistantDraftDTOClientMessage.ToolCalls,
                "tool-calls-result" => CreateAssistantDraftDTOClientMessage.ToolCallsResult,
                "tool.completed" => CreateAssistantDraftDTOClientMessage.ToolCompleted,
                "transcript" => CreateAssistantDraftDTOClientMessage.Transcript,
                "transfer-update" => CreateAssistantDraftDTOClientMessage.TransferUpdate,
                "user-interrupted" => CreateAssistantDraftDTOClientMessage.UserInterrupted,
                "voice-input" => CreateAssistantDraftDTOClientMessage.VoiceInput,
                "workflow.node.started" => CreateAssistantDraftDTOClientMessage.WorkflowNodeStarted,
                _ => null,
            };
        }
    }
}