
#nullable enable

namespace Vapi
{
    /// <summary>
    /// 
    /// </summary>
    public enum AssistantVersionServerMessage
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
    public static class AssistantVersionServerMessageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AssistantVersionServerMessage value)
        {
            return value switch
            {
                AssistantVersionServerMessage.AssistantSpeechStarted => "assistant.speechStarted",
                AssistantVersionServerMessage.AssistantStarted => "assistant.started",
                AssistantVersionServerMessage.CallArtifactUpload => "call.artifact.upload",
                AssistantVersionServerMessage.CallDeleteFailed => "call.delete.failed",
                AssistantVersionServerMessage.CallDeleted => "call.deleted",
                AssistantVersionServerMessage.ChatCreated => "chat.created",
                AssistantVersionServerMessage.ChatDeleted => "chat.deleted",
                AssistantVersionServerMessage.ConversationUpdate => "conversation-update",
                AssistantVersionServerMessage.EndOfCallReport => "end-of-call-report",
                AssistantVersionServerMessage.FunctionCall => "function-call",
                AssistantVersionServerMessage.HandoffDestinationRequest => "handoff-destination-request",
                AssistantVersionServerMessage.Hang => "hang",
                AssistantVersionServerMessage.LanguageChangeDetected => "language-change-detected",
                AssistantVersionServerMessage.LanguageChanged => "language-changed",
                AssistantVersionServerMessage.ModelOutput => "model-output",
                AssistantVersionServerMessage.PhoneCallControl => "phone-call-control",
                AssistantVersionServerMessage.SessionCreated => "session.created",
                AssistantVersionServerMessage.SessionDeleted => "session.deleted",
                AssistantVersionServerMessage.SessionUpdated => "session.updated",
                AssistantVersionServerMessage.SpeechUpdate => "speech-update",
                AssistantVersionServerMessage.StatusUpdate => "status-update",
                AssistantVersionServerMessage.ToolCalls => "tool-calls",
                AssistantVersionServerMessage.Transcript => "transcript",
                AssistantVersionServerMessage.TranscripttranscriptType__final_ => "transcript[transcriptType=\"final\"]",
                AssistantVersionServerMessage.TransferDestinationRequest => "transfer-destination-request",
                AssistantVersionServerMessage.TransferUpdate => "transfer-update",
                AssistantVersionServerMessage.UserInterrupted => "user-interrupted",
                AssistantVersionServerMessage.VoiceInput => "voice-input",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AssistantVersionServerMessage? ToEnum(string value)
        {
            return value switch
            {
                "assistant.speechStarted" => AssistantVersionServerMessage.AssistantSpeechStarted,
                "assistant.started" => AssistantVersionServerMessage.AssistantStarted,
                "call.artifact.upload" => AssistantVersionServerMessage.CallArtifactUpload,
                "call.delete.failed" => AssistantVersionServerMessage.CallDeleteFailed,
                "call.deleted" => AssistantVersionServerMessage.CallDeleted,
                "chat.created" => AssistantVersionServerMessage.ChatCreated,
                "chat.deleted" => AssistantVersionServerMessage.ChatDeleted,
                "conversation-update" => AssistantVersionServerMessage.ConversationUpdate,
                "end-of-call-report" => AssistantVersionServerMessage.EndOfCallReport,
                "function-call" => AssistantVersionServerMessage.FunctionCall,
                "handoff-destination-request" => AssistantVersionServerMessage.HandoffDestinationRequest,
                "hang" => AssistantVersionServerMessage.Hang,
                "language-change-detected" => AssistantVersionServerMessage.LanguageChangeDetected,
                "language-changed" => AssistantVersionServerMessage.LanguageChanged,
                "model-output" => AssistantVersionServerMessage.ModelOutput,
                "phone-call-control" => AssistantVersionServerMessage.PhoneCallControl,
                "session.created" => AssistantVersionServerMessage.SessionCreated,
                "session.deleted" => AssistantVersionServerMessage.SessionDeleted,
                "session.updated" => AssistantVersionServerMessage.SessionUpdated,
                "speech-update" => AssistantVersionServerMessage.SpeechUpdate,
                "status-update" => AssistantVersionServerMessage.StatusUpdate,
                "tool-calls" => AssistantVersionServerMessage.ToolCalls,
                "transcript" => AssistantVersionServerMessage.Transcript,
                "transcript[transcriptType=\"final\"]" => AssistantVersionServerMessage.TranscripttranscriptType__final_,
                "transfer-destination-request" => AssistantVersionServerMessage.TransferDestinationRequest,
                "transfer-update" => AssistantVersionServerMessage.TransferUpdate,
                "user-interrupted" => AssistantVersionServerMessage.UserInterrupted,
                "voice-input" => AssistantVersionServerMessage.VoiceInput,
                _ => null,
            };
        }
    }
}