
#nullable enable

namespace Vapi
{
    /// <summary>
    ///
    /// </summary>
    public enum AssistantSaveResponseServerMessage
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
    public static class AssistantSaveResponseServerMessageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AssistantSaveResponseServerMessage value)
        {
            return value switch
            {
                AssistantSaveResponseServerMessage.AssistantSpeechStarted => "assistant.speechStarted",
                AssistantSaveResponseServerMessage.AssistantStarted => "assistant.started",
                AssistantSaveResponseServerMessage.CallArtifactUpload => "call.artifact.upload",
                AssistantSaveResponseServerMessage.CallDeleteFailed => "call.delete.failed",
                AssistantSaveResponseServerMessage.CallDeleted => "call.deleted",
                AssistantSaveResponseServerMessage.ChatCreated => "chat.created",
                AssistantSaveResponseServerMessage.ChatDeleted => "chat.deleted",
                AssistantSaveResponseServerMessage.ConversationUpdate => "conversation-update",
                AssistantSaveResponseServerMessage.EndOfCallReport => "end-of-call-report",
                AssistantSaveResponseServerMessage.FunctionCall => "function-call",
                AssistantSaveResponseServerMessage.HandoffDestinationRequest => "handoff-destination-request",
                AssistantSaveResponseServerMessage.Hang => "hang",
                AssistantSaveResponseServerMessage.LanguageChangeDetected => "language-change-detected",
                AssistantSaveResponseServerMessage.LanguageChanged => "language-changed",
                AssistantSaveResponseServerMessage.ModelOutput => "model-output",
                AssistantSaveResponseServerMessage.PhoneCallControl => "phone-call-control",
                AssistantSaveResponseServerMessage.SessionCreated => "session.created",
                AssistantSaveResponseServerMessage.SessionDeleted => "session.deleted",
                AssistantSaveResponseServerMessage.SessionUpdated => "session.updated",
                AssistantSaveResponseServerMessage.SpeechUpdate => "speech-update",
                AssistantSaveResponseServerMessage.StatusUpdate => "status-update",
                AssistantSaveResponseServerMessage.ToolCalls => "tool-calls",
                AssistantSaveResponseServerMessage.Transcript => "transcript",
                AssistantSaveResponseServerMessage.TranscripttranscriptType__final_ => "transcript[transcriptType=\"final\"]",
                AssistantSaveResponseServerMessage.TransferDestinationRequest => "transfer-destination-request",
                AssistantSaveResponseServerMessage.TransferUpdate => "transfer-update",
                AssistantSaveResponseServerMessage.UserInterrupted => "user-interrupted",
                AssistantSaveResponseServerMessage.VoiceInput => "voice-input",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AssistantSaveResponseServerMessage? ToEnum(string value)
        {
            return value switch
            {
                "assistant.speechStarted" => AssistantSaveResponseServerMessage.AssistantSpeechStarted,
                "assistant.started" => AssistantSaveResponseServerMessage.AssistantStarted,
                "call.artifact.upload" => AssistantSaveResponseServerMessage.CallArtifactUpload,
                "call.delete.failed" => AssistantSaveResponseServerMessage.CallDeleteFailed,
                "call.deleted" => AssistantSaveResponseServerMessage.CallDeleted,
                "chat.created" => AssistantSaveResponseServerMessage.ChatCreated,
                "chat.deleted" => AssistantSaveResponseServerMessage.ChatDeleted,
                "conversation-update" => AssistantSaveResponseServerMessage.ConversationUpdate,
                "end-of-call-report" => AssistantSaveResponseServerMessage.EndOfCallReport,
                "function-call" => AssistantSaveResponseServerMessage.FunctionCall,
                "handoff-destination-request" => AssistantSaveResponseServerMessage.HandoffDestinationRequest,
                "hang" => AssistantSaveResponseServerMessage.Hang,
                "language-change-detected" => AssistantSaveResponseServerMessage.LanguageChangeDetected,
                "language-changed" => AssistantSaveResponseServerMessage.LanguageChanged,
                "model-output" => AssistantSaveResponseServerMessage.ModelOutput,
                "phone-call-control" => AssistantSaveResponseServerMessage.PhoneCallControl,
                "session.created" => AssistantSaveResponseServerMessage.SessionCreated,
                "session.deleted" => AssistantSaveResponseServerMessage.SessionDeleted,
                "session.updated" => AssistantSaveResponseServerMessage.SessionUpdated,
                "speech-update" => AssistantSaveResponseServerMessage.SpeechUpdate,
                "status-update" => AssistantSaveResponseServerMessage.StatusUpdate,
                "tool-calls" => AssistantSaveResponseServerMessage.ToolCalls,
                "transcript" => AssistantSaveResponseServerMessage.Transcript,
                "transcript[transcriptType=\"final\"]" => AssistantSaveResponseServerMessage.TranscripttranscriptType__final_,
                "transfer-destination-request" => AssistantSaveResponseServerMessage.TransferDestinationRequest,
                "transfer-update" => AssistantSaveResponseServerMessage.TransferUpdate,
                "user-interrupted" => AssistantSaveResponseServerMessage.UserInterrupted,
                "voice-input" => AssistantSaveResponseServerMessage.VoiceInput,
                _ => null,
            };
        }
    }
}