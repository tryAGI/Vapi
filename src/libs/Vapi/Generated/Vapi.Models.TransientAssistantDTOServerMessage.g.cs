
#nullable enable

namespace Vapi
{
    /// <summary>
    ///
    /// </summary>
    public enum TransientAssistantDTOServerMessage
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
    public static class TransientAssistantDTOServerMessageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TransientAssistantDTOServerMessage value)
        {
            return value switch
            {
                TransientAssistantDTOServerMessage.AssistantSpeechStarted => "assistant.speechStarted",
                TransientAssistantDTOServerMessage.AssistantStarted => "assistant.started",
                TransientAssistantDTOServerMessage.CallArtifactUpload => "call.artifact.upload",
                TransientAssistantDTOServerMessage.CallDeleteFailed => "call.delete.failed",
                TransientAssistantDTOServerMessage.CallDeleted => "call.deleted",
                TransientAssistantDTOServerMessage.ChatCreated => "chat.created",
                TransientAssistantDTOServerMessage.ChatDeleted => "chat.deleted",
                TransientAssistantDTOServerMessage.ConversationUpdate => "conversation-update",
                TransientAssistantDTOServerMessage.EndOfCallReport => "end-of-call-report",
                TransientAssistantDTOServerMessage.FunctionCall => "function-call",
                TransientAssistantDTOServerMessage.HandoffDestinationRequest => "handoff-destination-request",
                TransientAssistantDTOServerMessage.Hang => "hang",
                TransientAssistantDTOServerMessage.LanguageChangeDetected => "language-change-detected",
                TransientAssistantDTOServerMessage.LanguageChanged => "language-changed",
                TransientAssistantDTOServerMessage.ModelOutput => "model-output",
                TransientAssistantDTOServerMessage.PhoneCallControl => "phone-call-control",
                TransientAssistantDTOServerMessage.SessionCreated => "session.created",
                TransientAssistantDTOServerMessage.SessionDeleted => "session.deleted",
                TransientAssistantDTOServerMessage.SessionUpdated => "session.updated",
                TransientAssistantDTOServerMessage.SpeechUpdate => "speech-update",
                TransientAssistantDTOServerMessage.StatusUpdate => "status-update",
                TransientAssistantDTOServerMessage.ToolCalls => "tool-calls",
                TransientAssistantDTOServerMessage.Transcript => "transcript",
                TransientAssistantDTOServerMessage.TranscripttranscriptType__final_ => "transcript[transcriptType=\"final\"]",
                TransientAssistantDTOServerMessage.TransferDestinationRequest => "transfer-destination-request",
                TransientAssistantDTOServerMessage.TransferUpdate => "transfer-update",
                TransientAssistantDTOServerMessage.UserInterrupted => "user-interrupted",
                TransientAssistantDTOServerMessage.VoiceInput => "voice-input",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TransientAssistantDTOServerMessage? ToEnum(string value)
        {
            return value switch
            {
                "assistant.speechStarted" => TransientAssistantDTOServerMessage.AssistantSpeechStarted,
                "assistant.started" => TransientAssistantDTOServerMessage.AssistantStarted,
                "call.artifact.upload" => TransientAssistantDTOServerMessage.CallArtifactUpload,
                "call.delete.failed" => TransientAssistantDTOServerMessage.CallDeleteFailed,
                "call.deleted" => TransientAssistantDTOServerMessage.CallDeleted,
                "chat.created" => TransientAssistantDTOServerMessage.ChatCreated,
                "chat.deleted" => TransientAssistantDTOServerMessage.ChatDeleted,
                "conversation-update" => TransientAssistantDTOServerMessage.ConversationUpdate,
                "end-of-call-report" => TransientAssistantDTOServerMessage.EndOfCallReport,
                "function-call" => TransientAssistantDTOServerMessage.FunctionCall,
                "handoff-destination-request" => TransientAssistantDTOServerMessage.HandoffDestinationRequest,
                "hang" => TransientAssistantDTOServerMessage.Hang,
                "language-change-detected" => TransientAssistantDTOServerMessage.LanguageChangeDetected,
                "language-changed" => TransientAssistantDTOServerMessage.LanguageChanged,
                "model-output" => TransientAssistantDTOServerMessage.ModelOutput,
                "phone-call-control" => TransientAssistantDTOServerMessage.PhoneCallControl,
                "session.created" => TransientAssistantDTOServerMessage.SessionCreated,
                "session.deleted" => TransientAssistantDTOServerMessage.SessionDeleted,
                "session.updated" => TransientAssistantDTOServerMessage.SessionUpdated,
                "speech-update" => TransientAssistantDTOServerMessage.SpeechUpdate,
                "status-update" => TransientAssistantDTOServerMessage.StatusUpdate,
                "tool-calls" => TransientAssistantDTOServerMessage.ToolCalls,
                "transcript" => TransientAssistantDTOServerMessage.Transcript,
                "transcript[transcriptType=\"final\"]" => TransientAssistantDTOServerMessage.TranscripttranscriptType__final_,
                "transfer-destination-request" => TransientAssistantDTOServerMessage.TransferDestinationRequest,
                "transfer-update" => TransientAssistantDTOServerMessage.TransferUpdate,
                "user-interrupted" => TransientAssistantDTOServerMessage.UserInterrupted,
                "voice-input" => TransientAssistantDTOServerMessage.VoiceInput,
                _ => null,
            };
        }
    }
}