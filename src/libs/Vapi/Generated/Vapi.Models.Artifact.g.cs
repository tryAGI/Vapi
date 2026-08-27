
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vapi
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class Artifact
    {
        /// <summary>
        /// These are the messages that were spoken during the call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("messages")]
        public global::System.Collections.Generic.IList<global::Vapi.OneOf<global::Vapi.UserMessage, global::Vapi.SystemMessage, global::Vapi.BotMessage, global::Vapi.ToolCallMessage, global::Vapi.ToolCallResultMessage>>? Messages { get; set; }

        /// <summary>
        /// These are the messages that were spoken during the call, formatted for OpenAI.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("messagesOpenAIFormatted")]
        public global::System.Collections.Generic.IList<global::Vapi.OpenAIMessage>? MessagesOpenAIFormatted { get; set; }

        /// <summary>
        /// Structured outputs skipped because their conditions were not met, keyed by saved or runtime output ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("skippedStructuredOutputs")]
        public global::System.Collections.Generic.Dictionary<string, global::Vapi.SkippedStructuredOutput>? SkippedStructuredOutputs { get; set; }

        /// <summary>
        /// These are the transfer records for the call's transfer attempts (warm and blind), including<br/>
        /// destination, mode, and status. Warm transfer records also include transcripts and messages.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transfers")]
        public global::System.Collections.Generic.IList<global::Vapi.TransferArtifact>? Transfers { get; set; }

        /// <summary>
        /// This is the recording url for the call. To enable, set `assistant.artifactPlan.recordingEnabled`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("recordingUrl")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? RecordingUrl { get; set; }

        /// <summary>
        /// This is the stereo recording url for the call. To enable, set `assistant.artifactPlan.recordingEnabled`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stereoRecordingUrl")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? StereoRecordingUrl { get; set; }

        /// <summary>
        /// This is video recording url for the call. To enable, set `assistant.artifactPlan.videoRecordingEnabled`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("videoRecordingUrl")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? VideoRecordingUrl { get; set; }

        /// <summary>
        /// This is video recording start delay in ms. To enable, set `assistant.artifactPlan.videoRecordingEnabled`. This can be used to align the playback of the recording with artifact.messages timestamps.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("videoRecordingStartDelaySeconds")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public double? VideoRecordingStartDelaySeconds { get; set; }

        /// <summary>
        /// This is the recording url for the call. To enable, set `assistant.artifactPlan.recordingEnabled`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("recording")]
        public global::Vapi.Recording? Recording { get; set; }

        /// <summary>
        /// This is the transcript of the call. This is derived from `artifact.messages` but provided for convenience.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transcript")]
        public string? Transcript { get; set; }

        /// <summary>
        /// This is the packet capture url for the call. This is only available for `phone` type calls where phone number's provider is `vapi` or `byo-phone-number`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pcapUrl")]
        public string? PcapUrl { get; set; }

        /// <summary>
        /// This is the url for the call logs. This includes all logging output during the call for debugging purposes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("logUrl")]
        public string? LogUrl { get; set; }

        /// <summary>
        /// This is the history of workflow nodes that were executed during the call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nodes")]
        public global::System.Collections.Generic.IList<global::Vapi.NodeArtifact>? Nodes { get; set; }

        /// <summary>
        /// Ordered list of assistants that were active during the call, including after transfers and handoffs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assistantActivations")]
        public global::System.Collections.Generic.IList<global::Vapi.AssistantActivation>? AssistantActivations { get; set; }

        /// <summary>
        /// These are the variable values at the end of the workflow execution.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("variableValues")]
        public object? VariableValues { get; set; }

        /// <summary>
        /// This is the performance metrics for the call. It contains the turn latency, broken down by component.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("performanceMetrics")]
        public global::Vapi.PerformanceMetrics? PerformanceMetrics { get; set; }

        /// <summary>
        /// These are the structured outputs that will be extracted from the call.<br/>
        /// To enable, set `assistant.artifactPlan.structuredOutputIds` with the IDs of the structured outputs you want to extract.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("structuredOutputs")]
        public object? StructuredOutputs { get; set; }

        /// <summary>
        /// These are the scorecards that have been evaluated based on the structured outputs extracted during the call.<br/>
        /// To enable, set `assistant.artifactPlan.scorecardIds` or `assistant.artifactPlan.scorecards` with the IDs or objects of the scorecards you want to evaluate.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scorecards")]
        public object? Scorecards { get; set; }

        /// <summary>
        /// This is when the structured outputs were last updated
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("structuredOutputsLastUpdatedAt")]
        public global::System.DateTime? StructuredOutputsLastUpdatedAt { get; set; }

        /// <summary>
        /// This is a presigned URL to download the mono recording without<br/>
        /// authentication. Populated on API responses and server messages; never<br/>
        /// stored. Expires at `presignedUrlsExpiresAt` — after that, use<br/>
        /// `GET /call/{id}/mono-recording`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("presignedMonoUrl")]
        public string? PresignedMonoUrl { get; set; }

        /// <summary>
        /// This is a presigned URL to download the stereo recording without<br/>
        /// authentication. Expires at `presignedUrlsExpiresAt` — after that, use<br/>
        /// `GET /call/{id}/stereo-recording`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("presignedStereoUrl")]
        public string? PresignedStereoUrl { get; set; }

        /// <summary>
        /// This is a presigned URL to download the video recording without<br/>
        /// authentication. Expires at `presignedUrlsExpiresAt` — after that, use<br/>
        /// `GET /call/{id}/video-recording`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("presignedVideoUrl")]
        public string? PresignedVideoUrl { get; set; }

        /// <summary>
        /// This is a presigned URL to download the assistant-channel mono recording<br/>
        /// without authentication. Expires at `presignedUrlsExpiresAt`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("presignedAssistantUrl")]
        public string? PresignedAssistantUrl { get; set; }

        /// <summary>
        /// This is a presigned URL to download the customer-channel mono recording<br/>
        /// without authentication. Expires at `presignedUrlsExpiresAt`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("presignedCustomerUrl")]
        public string? PresignedCustomerUrl { get; set; }

        /// <summary>
        /// This is a presigned URL to download the packet capture without<br/>
        /// authentication. Expires at `presignedUrlsExpiresAt`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("presignedPcapUrl")]
        public string? PresignedPcapUrl { get; set; }

        /// <summary>
        /// This is a presigned URL to download the call logs without<br/>
        /// authentication. Expires at `presignedUrlsExpiresAt`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("presignedLogUrl")]
        public string? PresignedLogUrl { get; set; }

        /// <summary>
        /// This is when the presigned URLs above expire, as an ISO 8601 timestamp.<br/>
        /// The raw `*Url` fields remain the stable identifiers and do not expire.<br/>
        /// Presigned URLs are regenerated per response and per webhook delivery, so<br/>
        /// values differ across retries.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("presignedUrlsExpiresAt")]
        public string? PresignedUrlsExpiresAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Artifact" /> class.
        /// </summary>
        /// <param name="messages">
        /// These are the messages that were spoken during the call.
        /// </param>
        /// <param name="messagesOpenAIFormatted">
        /// These are the messages that were spoken during the call, formatted for OpenAI.
        /// </param>
        /// <param name="skippedStructuredOutputs">
        /// Structured outputs skipped because their conditions were not met, keyed by saved or runtime output ID.
        /// </param>
        /// <param name="transfers">
        /// These are the transfer records for the call's transfer attempts (warm and blind), including<br/>
        /// destination, mode, and status. Warm transfer records also include transcripts and messages.
        /// </param>
        /// <param name="recording">
        /// This is the recording url for the call. To enable, set `assistant.artifactPlan.recordingEnabled`.
        /// </param>
        /// <param name="transcript">
        /// This is the transcript of the call. This is derived from `artifact.messages` but provided for convenience.
        /// </param>
        /// <param name="pcapUrl">
        /// This is the packet capture url for the call. This is only available for `phone` type calls where phone number's provider is `vapi` or `byo-phone-number`.
        /// </param>
        /// <param name="logUrl">
        /// This is the url for the call logs. This includes all logging output during the call for debugging purposes.
        /// </param>
        /// <param name="nodes">
        /// This is the history of workflow nodes that were executed during the call.
        /// </param>
        /// <param name="assistantActivations">
        /// Ordered list of assistants that were active during the call, including after transfers and handoffs.
        /// </param>
        /// <param name="variableValues">
        /// These are the variable values at the end of the workflow execution.
        /// </param>
        /// <param name="performanceMetrics">
        /// This is the performance metrics for the call. It contains the turn latency, broken down by component.
        /// </param>
        /// <param name="structuredOutputs">
        /// These are the structured outputs that will be extracted from the call.<br/>
        /// To enable, set `assistant.artifactPlan.structuredOutputIds` with the IDs of the structured outputs you want to extract.
        /// </param>
        /// <param name="scorecards">
        /// These are the scorecards that have been evaluated based on the structured outputs extracted during the call.<br/>
        /// To enable, set `assistant.artifactPlan.scorecardIds` or `assistant.artifactPlan.scorecards` with the IDs or objects of the scorecards you want to evaluate.
        /// </param>
        /// <param name="structuredOutputsLastUpdatedAt">
        /// This is when the structured outputs were last updated
        /// </param>
        /// <param name="presignedMonoUrl">
        /// This is a presigned URL to download the mono recording without<br/>
        /// authentication. Populated on API responses and server messages; never<br/>
        /// stored. Expires at `presignedUrlsExpiresAt` — after that, use<br/>
        /// `GET /call/{id}/mono-recording`.
        /// </param>
        /// <param name="presignedStereoUrl">
        /// This is a presigned URL to download the stereo recording without<br/>
        /// authentication. Expires at `presignedUrlsExpiresAt` — after that, use<br/>
        /// `GET /call/{id}/stereo-recording`.
        /// </param>
        /// <param name="presignedVideoUrl">
        /// This is a presigned URL to download the video recording without<br/>
        /// authentication. Expires at `presignedUrlsExpiresAt` — after that, use<br/>
        /// `GET /call/{id}/video-recording`.
        /// </param>
        /// <param name="presignedAssistantUrl">
        /// This is a presigned URL to download the assistant-channel mono recording<br/>
        /// without authentication. Expires at `presignedUrlsExpiresAt`.
        /// </param>
        /// <param name="presignedCustomerUrl">
        /// This is a presigned URL to download the customer-channel mono recording<br/>
        /// without authentication. Expires at `presignedUrlsExpiresAt`.
        /// </param>
        /// <param name="presignedPcapUrl">
        /// This is a presigned URL to download the packet capture without<br/>
        /// authentication. Expires at `presignedUrlsExpiresAt`.
        /// </param>
        /// <param name="presignedLogUrl">
        /// This is a presigned URL to download the call logs without<br/>
        /// authentication. Expires at `presignedUrlsExpiresAt`.
        /// </param>
        /// <param name="presignedUrlsExpiresAt">
        /// This is when the presigned URLs above expire, as an ISO 8601 timestamp.<br/>
        /// The raw `*Url` fields remain the stable identifiers and do not expire.<br/>
        /// Presigned URLs are regenerated per response and per webhook delivery, so<br/>
        /// values differ across retries.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Artifact(
            global::System.Collections.Generic.IList<global::Vapi.OneOf<global::Vapi.UserMessage, global::Vapi.SystemMessage, global::Vapi.BotMessage, global::Vapi.ToolCallMessage, global::Vapi.ToolCallResultMessage>>? messages,
            global::System.Collections.Generic.IList<global::Vapi.OpenAIMessage>? messagesOpenAIFormatted,
            global::System.Collections.Generic.Dictionary<string, global::Vapi.SkippedStructuredOutput>? skippedStructuredOutputs,
            global::System.Collections.Generic.IList<global::Vapi.TransferArtifact>? transfers,
            global::Vapi.Recording? recording,
            string? transcript,
            string? pcapUrl,
            string? logUrl,
            global::System.Collections.Generic.IList<global::Vapi.NodeArtifact>? nodes,
            global::System.Collections.Generic.IList<global::Vapi.AssistantActivation>? assistantActivations,
            object? variableValues,
            global::Vapi.PerformanceMetrics? performanceMetrics,
            object? structuredOutputs,
            object? scorecards,
            global::System.DateTime? structuredOutputsLastUpdatedAt,
            string? presignedMonoUrl,
            string? presignedStereoUrl,
            string? presignedVideoUrl,
            string? presignedAssistantUrl,
            string? presignedCustomerUrl,
            string? presignedPcapUrl,
            string? presignedLogUrl,
            string? presignedUrlsExpiresAt)
        {
            this.Messages = messages;
            this.MessagesOpenAIFormatted = messagesOpenAIFormatted;
            this.SkippedStructuredOutputs = skippedStructuredOutputs;
            this.Transfers = transfers;
            this.Recording = recording;
            this.Transcript = transcript;
            this.PcapUrl = pcapUrl;
            this.LogUrl = logUrl;
            this.Nodes = nodes;
            this.AssistantActivations = assistantActivations;
            this.VariableValues = variableValues;
            this.PerformanceMetrics = performanceMetrics;
            this.StructuredOutputs = structuredOutputs;
            this.Scorecards = scorecards;
            this.StructuredOutputsLastUpdatedAt = structuredOutputsLastUpdatedAt;
            this.PresignedMonoUrl = presignedMonoUrl;
            this.PresignedStereoUrl = presignedStereoUrl;
            this.PresignedVideoUrl = presignedVideoUrl;
            this.PresignedAssistantUrl = presignedAssistantUrl;
            this.PresignedCustomerUrl = presignedCustomerUrl;
            this.PresignedPcapUrl = presignedPcapUrl;
            this.PresignedLogUrl = presignedLogUrl;
            this.PresignedUrlsExpiresAt = presignedUrlsExpiresAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Artifact" /> class.
        /// </summary>
        public Artifact()
        {
        }

    }
}