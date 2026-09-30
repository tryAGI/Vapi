
#nullable enable

namespace Vapi
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UserMessage
    {
        /// <summary>
        /// The role of the user in the conversation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Role { get; set; }

        /// <summary>
        /// The message content from the user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// The timestamp when the message was sent.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("time")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Time { get; set; }

        /// <summary>
        /// The timestamp when the message ended.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("endTime")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double EndTime { get; set; }

        /// <summary>
        /// The number of seconds from the start of the conversation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secondsFromStart")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double SecondsFromStart { get; set; }

        /// <summary>
        /// The duration of the message in seconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration")]
        public double? Duration { get; set; }

        /// <summary>
        /// Indicates if the message was filtered for security reasons.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isFiltered")]
        public bool? IsFiltered { get; set; }

        /// <summary>
        /// List of detected security threats if the message was filtered.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("detectedThreats")]
        public global::System.Collections.Generic.IList<string>? DetectedThreats { get; set; }

        /// <summary>
        /// The original message before filtering (only included if content was filtered).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("originalMessage")]
        public string? OriginalMessage { get; set; }

        /// <summary>
        /// The transcriber's confidence score for this message, in [0, 1]. Only<br/>
        /// ever set alongside `confidenceSource` — see there for why an unmarked<br/>
        /// or out-of-range score is never stored.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("confidence")]
        public double? Confidence { get; set; }

        /// <summary>
        /// Whether `confidence` came directly from the transcriber ('provider') or<br/>
        /// was computed by Vapi ('derived').<br/>
        /// 'derived' means Vapi computed the score from the transcriber's per-word<br/>
        /// scores; the exact aggregation is provider-specific (an average, a median<br/>
        /// or a minimum, depending on the transcriber). It is also 'derived' when<br/>
        /// consecutive transcript fragments were merged into one message, where the<br/>
        /// score is the minimum across the fragments.<br/>
        /// Absent means no trustworthy score was available for this message: either<br/>
        /// the transcriber does not report one, or the value it reported was invalid<br/>
        /// and was dropped. A merged message is unmarked whenever any fragment it<br/>
        /// contains was unmarked.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("confidenceSource")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.UserMessageConfidenceSourceJsonConverter))]
        public global::Vapi.UserMessageConfidenceSource? ConfidenceSource { get; set; }

        /// <summary>
        /// The metadata associated with the message. Currently used to store the transcriber's word level confidence.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::Vapi.UserMessageMetadata? Metadata { get; set; }

        /// <summary>
        /// Stable speaker label for diarized user speakers (e.g., "Speaker 1").
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speakerLabel")]
        public string? SpeakerLabel { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserMessage" /> class.
        /// </summary>
        /// <param name="role">
        /// The role of the user in the conversation.
        /// </param>
        /// <param name="message">
        /// The message content from the user.
        /// </param>
        /// <param name="time">
        /// The timestamp when the message was sent.
        /// </param>
        /// <param name="endTime">
        /// The timestamp when the message ended.
        /// </param>
        /// <param name="secondsFromStart">
        /// The number of seconds from the start of the conversation.
        /// </param>
        /// <param name="duration">
        /// The duration of the message in seconds.
        /// </param>
        /// <param name="isFiltered">
        /// Indicates if the message was filtered for security reasons.
        /// </param>
        /// <param name="detectedThreats">
        /// List of detected security threats if the message was filtered.
        /// </param>
        /// <param name="originalMessage">
        /// The original message before filtering (only included if content was filtered).
        /// </param>
        /// <param name="confidence">
        /// The transcriber's confidence score for this message, in [0, 1]. Only<br/>
        /// ever set alongside `confidenceSource` — see there for why an unmarked<br/>
        /// or out-of-range score is never stored.
        /// </param>
        /// <param name="confidenceSource">
        /// Whether `confidence` came directly from the transcriber ('provider') or<br/>
        /// was computed by Vapi ('derived').<br/>
        /// 'derived' means Vapi computed the score from the transcriber's per-word<br/>
        /// scores; the exact aggregation is provider-specific (an average, a median<br/>
        /// or a minimum, depending on the transcriber). It is also 'derived' when<br/>
        /// consecutive transcript fragments were merged into one message, where the<br/>
        /// score is the minimum across the fragments.<br/>
        /// Absent means no trustworthy score was available for this message: either<br/>
        /// the transcriber does not report one, or the value it reported was invalid<br/>
        /// and was dropped. A merged message is unmarked whenever any fragment it<br/>
        /// contains was unmarked.
        /// </param>
        /// <param name="metadata">
        /// The metadata associated with the message. Currently used to store the transcriber's word level confidence.
        /// </param>
        /// <param name="speakerLabel">
        /// Stable speaker label for diarized user speakers (e.g., "Speaker 1").
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserMessage(
            string role,
            string message,
            double time,
            double endTime,
            double secondsFromStart,
            double? duration,
            bool? isFiltered,
            global::System.Collections.Generic.IList<string>? detectedThreats,
            string? originalMessage,
            double? confidence,
            global::Vapi.UserMessageConfidenceSource? confidenceSource,
            global::Vapi.UserMessageMetadata? metadata,
            string? speakerLabel)
        {
            this.Role = role ?? throw new global::System.ArgumentNullException(nameof(role));
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.Time = time;
            this.EndTime = endTime;
            this.SecondsFromStart = secondsFromStart;
            this.Duration = duration;
            this.IsFiltered = isFiltered;
            this.DetectedThreats = detectedThreats;
            this.OriginalMessage = originalMessage;
            this.Confidence = confidence;
            this.ConfidenceSource = confidenceSource;
            this.Metadata = metadata;
            this.SpeakerLabel = speakerLabel;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserMessage" /> class.
        /// </summary>
        public UserMessage()
        {
        }

    }
}