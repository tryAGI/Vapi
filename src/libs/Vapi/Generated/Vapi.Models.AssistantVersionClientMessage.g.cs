
#nullable enable

namespace Vapi
{
    /// <summary>
    /// 
    /// </summary>
    public enum AssistantVersionClientMessage
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
    public static class AssistantVersionClientMessageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AssistantVersionClientMessage value)
        {
            return value switch
            {
                AssistantVersionClientMessage.AssistantSpeechStarted => "assistant.speechStarted",
                AssistantVersionClientMessage.AssistantStarted => "assistant.started",
                AssistantVersionClientMessage.ConversationUpdate => "conversation-update",
                AssistantVersionClientMessage.FunctionCall => "function-call",
                AssistantVersionClientMessage.FunctionCallResult => "function-call-result",
                AssistantVersionClientMessage.Hang => "hang",
                AssistantVersionClientMessage.LanguageChanged => "language-changed",
                AssistantVersionClientMessage.Metadata => "metadata",
                AssistantVersionClientMessage.ModelOutput => "model-output",
                AssistantVersionClientMessage.SpeechUpdate => "speech-update",
                AssistantVersionClientMessage.StatusUpdate => "status-update",
                AssistantVersionClientMessage.ToolCalls => "tool-calls",
                AssistantVersionClientMessage.ToolCallsResult => "tool-calls-result",
                AssistantVersionClientMessage.ToolCompleted => "tool.completed",
                AssistantVersionClientMessage.Transcript => "transcript",
                AssistantVersionClientMessage.TransferUpdate => "transfer-update",
                AssistantVersionClientMessage.UserInterrupted => "user-interrupted",
                AssistantVersionClientMessage.VoiceInput => "voice-input",
                AssistantVersionClientMessage.WorkflowNodeStarted => "workflow.node.started",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AssistantVersionClientMessage? ToEnum(string value)
        {
            return value switch
            {
                "assistant.speechStarted" => AssistantVersionClientMessage.AssistantSpeechStarted,
                "assistant.started" => AssistantVersionClientMessage.AssistantStarted,
                "conversation-update" => AssistantVersionClientMessage.ConversationUpdate,
                "function-call" => AssistantVersionClientMessage.FunctionCall,
                "function-call-result" => AssistantVersionClientMessage.FunctionCallResult,
                "hang" => AssistantVersionClientMessage.Hang,
                "language-changed" => AssistantVersionClientMessage.LanguageChanged,
                "metadata" => AssistantVersionClientMessage.Metadata,
                "model-output" => AssistantVersionClientMessage.ModelOutput,
                "speech-update" => AssistantVersionClientMessage.SpeechUpdate,
                "status-update" => AssistantVersionClientMessage.StatusUpdate,
                "tool-calls" => AssistantVersionClientMessage.ToolCalls,
                "tool-calls-result" => AssistantVersionClientMessage.ToolCallsResult,
                "tool.completed" => AssistantVersionClientMessage.ToolCompleted,
                "transcript" => AssistantVersionClientMessage.Transcript,
                "transfer-update" => AssistantVersionClientMessage.TransferUpdate,
                "user-interrupted" => AssistantVersionClientMessage.UserInterrupted,
                "voice-input" => AssistantVersionClientMessage.VoiceInput,
                "workflow.node.started" => AssistantVersionClientMessage.WorkflowNodeStarted,
                _ => null,
            };
        }
    }
}