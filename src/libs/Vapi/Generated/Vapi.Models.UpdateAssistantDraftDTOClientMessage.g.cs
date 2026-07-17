
#nullable enable

namespace Vapi
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateAssistantDraftDTOClientMessage
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
    public static class UpdateAssistantDraftDTOClientMessageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateAssistantDraftDTOClientMessage value)
        {
            return value switch
            {
                UpdateAssistantDraftDTOClientMessage.AssistantSpeechStarted => "assistant.speechStarted",
                UpdateAssistantDraftDTOClientMessage.AssistantStarted => "assistant.started",
                UpdateAssistantDraftDTOClientMessage.ConversationUpdate => "conversation-update",
                UpdateAssistantDraftDTOClientMessage.FunctionCall => "function-call",
                UpdateAssistantDraftDTOClientMessage.FunctionCallResult => "function-call-result",
                UpdateAssistantDraftDTOClientMessage.Hang => "hang",
                UpdateAssistantDraftDTOClientMessage.LanguageChanged => "language-changed",
                UpdateAssistantDraftDTOClientMessage.Metadata => "metadata",
                UpdateAssistantDraftDTOClientMessage.ModelOutput => "model-output",
                UpdateAssistantDraftDTOClientMessage.SpeechUpdate => "speech-update",
                UpdateAssistantDraftDTOClientMessage.StatusUpdate => "status-update",
                UpdateAssistantDraftDTOClientMessage.ToolCalls => "tool-calls",
                UpdateAssistantDraftDTOClientMessage.ToolCallsResult => "tool-calls-result",
                UpdateAssistantDraftDTOClientMessage.ToolCompleted => "tool.completed",
                UpdateAssistantDraftDTOClientMessage.Transcript => "transcript",
                UpdateAssistantDraftDTOClientMessage.TransferUpdate => "transfer-update",
                UpdateAssistantDraftDTOClientMessage.UserInterrupted => "user-interrupted",
                UpdateAssistantDraftDTOClientMessage.VoiceInput => "voice-input",
                UpdateAssistantDraftDTOClientMessage.WorkflowNodeStarted => "workflow.node.started",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateAssistantDraftDTOClientMessage? ToEnum(string value)
        {
            return value switch
            {
                "assistant.speechStarted" => UpdateAssistantDraftDTOClientMessage.AssistantSpeechStarted,
                "assistant.started" => UpdateAssistantDraftDTOClientMessage.AssistantStarted,
                "conversation-update" => UpdateAssistantDraftDTOClientMessage.ConversationUpdate,
                "function-call" => UpdateAssistantDraftDTOClientMessage.FunctionCall,
                "function-call-result" => UpdateAssistantDraftDTOClientMessage.FunctionCallResult,
                "hang" => UpdateAssistantDraftDTOClientMessage.Hang,
                "language-changed" => UpdateAssistantDraftDTOClientMessage.LanguageChanged,
                "metadata" => UpdateAssistantDraftDTOClientMessage.Metadata,
                "model-output" => UpdateAssistantDraftDTOClientMessage.ModelOutput,
                "speech-update" => UpdateAssistantDraftDTOClientMessage.SpeechUpdate,
                "status-update" => UpdateAssistantDraftDTOClientMessage.StatusUpdate,
                "tool-calls" => UpdateAssistantDraftDTOClientMessage.ToolCalls,
                "tool-calls-result" => UpdateAssistantDraftDTOClientMessage.ToolCallsResult,
                "tool.completed" => UpdateAssistantDraftDTOClientMessage.ToolCompleted,
                "transcript" => UpdateAssistantDraftDTOClientMessage.Transcript,
                "transfer-update" => UpdateAssistantDraftDTOClientMessage.TransferUpdate,
                "user-interrupted" => UpdateAssistantDraftDTOClientMessage.UserInterrupted,
                "voice-input" => UpdateAssistantDraftDTOClientMessage.VoiceInput,
                "workflow.node.started" => UpdateAssistantDraftDTOClientMessage.WorkflowNodeStarted,
                _ => null,
            };
        }
    }
}