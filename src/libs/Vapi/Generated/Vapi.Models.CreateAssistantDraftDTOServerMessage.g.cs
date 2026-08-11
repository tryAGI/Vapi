
#nullable enable

namespace Vapi
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateAssistantDraftDTOServerMessage
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
    public static class CreateAssistantDraftDTOServerMessageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateAssistantDraftDTOServerMessage value)
        {
            return value switch
            {
                CreateAssistantDraftDTOServerMessage.AssistantSpeechStarted => "assistant.speechStarted",
                CreateAssistantDraftDTOServerMessage.AssistantStarted => "assistant.started",
                CreateAssistantDraftDTOServerMessage.CallArtifactUpload => "call.artifact.upload",
                CreateAssistantDraftDTOServerMessage.CallDeleteFailed => "call.delete.failed",
                CreateAssistantDraftDTOServerMessage.CallDeleted => "call.deleted",
                CreateAssistantDraftDTOServerMessage.ChatCreated => "chat.created",
                CreateAssistantDraftDTOServerMessage.ChatDeleted => "chat.deleted",
                CreateAssistantDraftDTOServerMessage.ConversationUpdate => "conversation-update",
                CreateAssistantDraftDTOServerMessage.EndOfCallReport => "end-of-call-report",
                CreateAssistantDraftDTOServerMessage.FunctionCall => "function-call",
                CreateAssistantDraftDTOServerMessage.HandoffDestinationRequest => "handoff-destination-request",
                CreateAssistantDraftDTOServerMessage.Hang => "hang",
                CreateAssistantDraftDTOServerMessage.LanguageChangeDetected => "language-change-detected",
                CreateAssistantDraftDTOServerMessage.LanguageChanged => "language-changed",
                CreateAssistantDraftDTOServerMessage.ModelOutput => "model-output",
                CreateAssistantDraftDTOServerMessage.PhoneCallControl => "phone-call-control",
                CreateAssistantDraftDTOServerMessage.SessionCreated => "session.created",
                CreateAssistantDraftDTOServerMessage.SessionDeleted => "session.deleted",
                CreateAssistantDraftDTOServerMessage.SessionUpdated => "session.updated",
                CreateAssistantDraftDTOServerMessage.SpeechUpdate => "speech-update",
                CreateAssistantDraftDTOServerMessage.StatusUpdate => "status-update",
                CreateAssistantDraftDTOServerMessage.ToolCalls => "tool-calls",
                CreateAssistantDraftDTOServerMessage.Transcript => "transcript",
                CreateAssistantDraftDTOServerMessage.TranscripttranscriptType__final_ => "transcript[transcriptType=\"final\"]",
                CreateAssistantDraftDTOServerMessage.TransferDestinationRequest => "transfer-destination-request",
                CreateAssistantDraftDTOServerMessage.TransferUpdate => "transfer-update",
                CreateAssistantDraftDTOServerMessage.UserInterrupted => "user-interrupted",
                CreateAssistantDraftDTOServerMessage.VoiceInput => "voice-input",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateAssistantDraftDTOServerMessage? ToEnum(string value)
        {
            return value switch
            {
                "assistant.speechStarted" => CreateAssistantDraftDTOServerMessage.AssistantSpeechStarted,
                "assistant.started" => CreateAssistantDraftDTOServerMessage.AssistantStarted,
                "call.artifact.upload" => CreateAssistantDraftDTOServerMessage.CallArtifactUpload,
                "call.delete.failed" => CreateAssistantDraftDTOServerMessage.CallDeleteFailed,
                "call.deleted" => CreateAssistantDraftDTOServerMessage.CallDeleted,
                "chat.created" => CreateAssistantDraftDTOServerMessage.ChatCreated,
                "chat.deleted" => CreateAssistantDraftDTOServerMessage.ChatDeleted,
                "conversation-update" => CreateAssistantDraftDTOServerMessage.ConversationUpdate,
                "end-of-call-report" => CreateAssistantDraftDTOServerMessage.EndOfCallReport,
                "function-call" => CreateAssistantDraftDTOServerMessage.FunctionCall,
                "handoff-destination-request" => CreateAssistantDraftDTOServerMessage.HandoffDestinationRequest,
                "hang" => CreateAssistantDraftDTOServerMessage.Hang,
                "language-change-detected" => CreateAssistantDraftDTOServerMessage.LanguageChangeDetected,
                "language-changed" => CreateAssistantDraftDTOServerMessage.LanguageChanged,
                "model-output" => CreateAssistantDraftDTOServerMessage.ModelOutput,
                "phone-call-control" => CreateAssistantDraftDTOServerMessage.PhoneCallControl,
                "session.created" => CreateAssistantDraftDTOServerMessage.SessionCreated,
                "session.deleted" => CreateAssistantDraftDTOServerMessage.SessionDeleted,
                "session.updated" => CreateAssistantDraftDTOServerMessage.SessionUpdated,
                "speech-update" => CreateAssistantDraftDTOServerMessage.SpeechUpdate,
                "status-update" => CreateAssistantDraftDTOServerMessage.StatusUpdate,
                "tool-calls" => CreateAssistantDraftDTOServerMessage.ToolCalls,
                "transcript" => CreateAssistantDraftDTOServerMessage.Transcript,
                "transcript[transcriptType=\"final\"]" => CreateAssistantDraftDTOServerMessage.TranscripttranscriptType__final_,
                "transfer-destination-request" => CreateAssistantDraftDTOServerMessage.TransferDestinationRequest,
                "transfer-update" => CreateAssistantDraftDTOServerMessage.TransferUpdate,
                "user-interrupted" => CreateAssistantDraftDTOServerMessage.UserInterrupted,
                "voice-input" => CreateAssistantDraftDTOServerMessage.VoiceInput,
                _ => null,
            };
        }
    }
}