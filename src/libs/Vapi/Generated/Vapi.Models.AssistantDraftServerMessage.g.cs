
#nullable enable

namespace Vapi
{
    /// <summary>
    /// 
    /// </summary>
    public enum AssistantDraftServerMessage
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
        CallArtifactUpload,
        /// <summary>
        /// 
        /// </summary>
        CallDeleteFailed,
        /// <summary>
        /// 
        /// </summary>
        CallDeleted,
        /// <summary>
        /// 
        /// </summary>
        ChatCreated,
        /// <summary>
        /// 
        /// </summary>
        ChatDeleted,
        /// <summary>
        /// 
        /// </summary>
        ConversationUpdate,
        /// <summary>
        /// 
        /// </summary>
        EndOfCallReport,
        /// <summary>
        /// 
        /// </summary>
        FunctionCall,
        /// <summary>
        /// 
        /// </summary>
        HandoffDestinationRequest,
        /// <summary>
        /// 
        /// </summary>
        Hang,
        /// <summary>
        /// 
        /// </summary>
        LanguageChangeDetected,
        /// <summary>
        /// 
        /// </summary>
        LanguageChanged,
        /// <summary>
        /// 
        /// </summary>
        ModelOutput,
        /// <summary>
        /// 
        /// </summary>
        PhoneCallControl,
        /// <summary>
        /// 
        /// </summary>
        SessionCreated,
        /// <summary>
        /// 
        /// </summary>
        SessionDeleted,
        /// <summary>
        /// 
        /// </summary>
        SessionUpdated,
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
        Transcript,
        /// <summary>
        /// 
        /// </summary>
        TranscripttranscriptType__final_,
        /// <summary>
        /// 
        /// </summary>
        TransferDestinationRequest,
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
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AssistantDraftServerMessageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AssistantDraftServerMessage value)
        {
            return value switch
            {
                AssistantDraftServerMessage.AssistantSpeechStarted => "assistant.speechStarted",
                AssistantDraftServerMessage.AssistantStarted => "assistant.started",
                AssistantDraftServerMessage.CallArtifactUpload => "call.artifact.upload",
                AssistantDraftServerMessage.CallDeleteFailed => "call.delete.failed",
                AssistantDraftServerMessage.CallDeleted => "call.deleted",
                AssistantDraftServerMessage.ChatCreated => "chat.created",
                AssistantDraftServerMessage.ChatDeleted => "chat.deleted",
                AssistantDraftServerMessage.ConversationUpdate => "conversation-update",
                AssistantDraftServerMessage.EndOfCallReport => "end-of-call-report",
                AssistantDraftServerMessage.FunctionCall => "function-call",
                AssistantDraftServerMessage.HandoffDestinationRequest => "handoff-destination-request",
                AssistantDraftServerMessage.Hang => "hang",
                AssistantDraftServerMessage.LanguageChangeDetected => "language-change-detected",
                AssistantDraftServerMessage.LanguageChanged => "language-changed",
                AssistantDraftServerMessage.ModelOutput => "model-output",
                AssistantDraftServerMessage.PhoneCallControl => "phone-call-control",
                AssistantDraftServerMessage.SessionCreated => "session.created",
                AssistantDraftServerMessage.SessionDeleted => "session.deleted",
                AssistantDraftServerMessage.SessionUpdated => "session.updated",
                AssistantDraftServerMessage.SpeechUpdate => "speech-update",
                AssistantDraftServerMessage.StatusUpdate => "status-update",
                AssistantDraftServerMessage.ToolCalls => "tool-calls",
                AssistantDraftServerMessage.Transcript => "transcript",
                AssistantDraftServerMessage.TranscripttranscriptType__final_ => "transcript[transcriptType=\"final\"]",
                AssistantDraftServerMessage.TransferDestinationRequest => "transfer-destination-request",
                AssistantDraftServerMessage.TransferUpdate => "transfer-update",
                AssistantDraftServerMessage.UserInterrupted => "user-interrupted",
                AssistantDraftServerMessage.VoiceInput => "voice-input",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AssistantDraftServerMessage? ToEnum(string value)
        {
            return value switch
            {
                "assistant.speechStarted" => AssistantDraftServerMessage.AssistantSpeechStarted,
                "assistant.started" => AssistantDraftServerMessage.AssistantStarted,
                "call.artifact.upload" => AssistantDraftServerMessage.CallArtifactUpload,
                "call.delete.failed" => AssistantDraftServerMessage.CallDeleteFailed,
                "call.deleted" => AssistantDraftServerMessage.CallDeleted,
                "chat.created" => AssistantDraftServerMessage.ChatCreated,
                "chat.deleted" => AssistantDraftServerMessage.ChatDeleted,
                "conversation-update" => AssistantDraftServerMessage.ConversationUpdate,
                "end-of-call-report" => AssistantDraftServerMessage.EndOfCallReport,
                "function-call" => AssistantDraftServerMessage.FunctionCall,
                "handoff-destination-request" => AssistantDraftServerMessage.HandoffDestinationRequest,
                "hang" => AssistantDraftServerMessage.Hang,
                "language-change-detected" => AssistantDraftServerMessage.LanguageChangeDetected,
                "language-changed" => AssistantDraftServerMessage.LanguageChanged,
                "model-output" => AssistantDraftServerMessage.ModelOutput,
                "phone-call-control" => AssistantDraftServerMessage.PhoneCallControl,
                "session.created" => AssistantDraftServerMessage.SessionCreated,
                "session.deleted" => AssistantDraftServerMessage.SessionDeleted,
                "session.updated" => AssistantDraftServerMessage.SessionUpdated,
                "speech-update" => AssistantDraftServerMessage.SpeechUpdate,
                "status-update" => AssistantDraftServerMessage.StatusUpdate,
                "tool-calls" => AssistantDraftServerMessage.ToolCalls,
                "transcript" => AssistantDraftServerMessage.Transcript,
                "transcript[transcriptType=\"final\"]" => AssistantDraftServerMessage.TranscripttranscriptType__final_,
                "transfer-destination-request" => AssistantDraftServerMessage.TransferDestinationRequest,
                "transfer-update" => AssistantDraftServerMessage.TransferUpdate,
                "user-interrupted" => AssistantDraftServerMessage.UserInterrupted,
                "voice-input" => AssistantDraftServerMessage.VoiceInput,
                _ => null,
            };
        }
    }
}