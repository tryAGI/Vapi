
#nullable enable

namespace Vapi
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateAssistantDraftDTOServerMessage
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
    public static class UpdateAssistantDraftDTOServerMessageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateAssistantDraftDTOServerMessage value)
        {
            return value switch
            {
                UpdateAssistantDraftDTOServerMessage.AssistantSpeechStarted => "assistant.speechStarted",
                UpdateAssistantDraftDTOServerMessage.AssistantStarted => "assistant.started",
                UpdateAssistantDraftDTOServerMessage.CallDeleteFailed => "call.delete.failed",
                UpdateAssistantDraftDTOServerMessage.CallDeleted => "call.deleted",
                UpdateAssistantDraftDTOServerMessage.ChatCreated => "chat.created",
                UpdateAssistantDraftDTOServerMessage.ChatDeleted => "chat.deleted",
                UpdateAssistantDraftDTOServerMessage.ConversationUpdate => "conversation-update",
                UpdateAssistantDraftDTOServerMessage.EndOfCallReport => "end-of-call-report",
                UpdateAssistantDraftDTOServerMessage.FunctionCall => "function-call",
                UpdateAssistantDraftDTOServerMessage.HandoffDestinationRequest => "handoff-destination-request",
                UpdateAssistantDraftDTOServerMessage.Hang => "hang",
                UpdateAssistantDraftDTOServerMessage.LanguageChangeDetected => "language-change-detected",
                UpdateAssistantDraftDTOServerMessage.LanguageChanged => "language-changed",
                UpdateAssistantDraftDTOServerMessage.ModelOutput => "model-output",
                UpdateAssistantDraftDTOServerMessage.PhoneCallControl => "phone-call-control",
                UpdateAssistantDraftDTOServerMessage.SessionCreated => "session.created",
                UpdateAssistantDraftDTOServerMessage.SessionDeleted => "session.deleted",
                UpdateAssistantDraftDTOServerMessage.SessionUpdated => "session.updated",
                UpdateAssistantDraftDTOServerMessage.SpeechUpdate => "speech-update",
                UpdateAssistantDraftDTOServerMessage.StatusUpdate => "status-update",
                UpdateAssistantDraftDTOServerMessage.ToolCalls => "tool-calls",
                UpdateAssistantDraftDTOServerMessage.Transcript => "transcript",
                UpdateAssistantDraftDTOServerMessage.TranscripttranscriptType__final_ => "transcript[transcriptType=\"final\"]",
                UpdateAssistantDraftDTOServerMessage.TransferDestinationRequest => "transfer-destination-request",
                UpdateAssistantDraftDTOServerMessage.TransferUpdate => "transfer-update",
                UpdateAssistantDraftDTOServerMessage.UserInterrupted => "user-interrupted",
                UpdateAssistantDraftDTOServerMessage.VoiceInput => "voice-input",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateAssistantDraftDTOServerMessage? ToEnum(string value)
        {
            return value switch
            {
                "assistant.speechStarted" => UpdateAssistantDraftDTOServerMessage.AssistantSpeechStarted,
                "assistant.started" => UpdateAssistantDraftDTOServerMessage.AssistantStarted,
                "call.delete.failed" => UpdateAssistantDraftDTOServerMessage.CallDeleteFailed,
                "call.deleted" => UpdateAssistantDraftDTOServerMessage.CallDeleted,
                "chat.created" => UpdateAssistantDraftDTOServerMessage.ChatCreated,
                "chat.deleted" => UpdateAssistantDraftDTOServerMessage.ChatDeleted,
                "conversation-update" => UpdateAssistantDraftDTOServerMessage.ConversationUpdate,
                "end-of-call-report" => UpdateAssistantDraftDTOServerMessage.EndOfCallReport,
                "function-call" => UpdateAssistantDraftDTOServerMessage.FunctionCall,
                "handoff-destination-request" => UpdateAssistantDraftDTOServerMessage.HandoffDestinationRequest,
                "hang" => UpdateAssistantDraftDTOServerMessage.Hang,
                "language-change-detected" => UpdateAssistantDraftDTOServerMessage.LanguageChangeDetected,
                "language-changed" => UpdateAssistantDraftDTOServerMessage.LanguageChanged,
                "model-output" => UpdateAssistantDraftDTOServerMessage.ModelOutput,
                "phone-call-control" => UpdateAssistantDraftDTOServerMessage.PhoneCallControl,
                "session.created" => UpdateAssistantDraftDTOServerMessage.SessionCreated,
                "session.deleted" => UpdateAssistantDraftDTOServerMessage.SessionDeleted,
                "session.updated" => UpdateAssistantDraftDTOServerMessage.SessionUpdated,
                "speech-update" => UpdateAssistantDraftDTOServerMessage.SpeechUpdate,
                "status-update" => UpdateAssistantDraftDTOServerMessage.StatusUpdate,
                "tool-calls" => UpdateAssistantDraftDTOServerMessage.ToolCalls,
                "transcript" => UpdateAssistantDraftDTOServerMessage.Transcript,
                "transcript[transcriptType=\"final\"]" => UpdateAssistantDraftDTOServerMessage.TranscripttranscriptType__final_,
                "transfer-destination-request" => UpdateAssistantDraftDTOServerMessage.TransferDestinationRequest,
                "transfer-update" => UpdateAssistantDraftDTOServerMessage.TransferUpdate,
                "user-interrupted" => UpdateAssistantDraftDTOServerMessage.UserInterrupted,
                "voice-input" => UpdateAssistantDraftDTOServerMessage.VoiceInput,
                _ => null,
            };
        }
    }
}