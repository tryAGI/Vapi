
#nullable enable

namespace Vapi
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class TranscriptReplay
    {
        /// <summary>
        /// This is the HTTPS URL of the recording, fetched when each run starts and<br/>
        /// never stored. Use a presigned URL that stays valid until the run executes.<br/>
        /// WAV, MP3, FLAC and OGG are supported; MP4 and M4A only when the file was<br/>
        /// written for streaming.<br/>
        /// Example: https://example.com/recordings/call-123.wav
        /// </summary>
        /// <example>https://example.com/recordings/call-123.wav</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("recordingUrl")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RecordingUrl { get; set; }

        /// <summary>
        /// This is the answer key, inline. Supply this or `answerKeyUrl`, not both.<br/>
        /// Organizations with HIPAA, PCI or zero data retention enabled must use<br/>
        /// `answerKeyUrl`, so no answer key is stored.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("answerKey")]
        public global::Vapi.TranscriptAnswerKey? AnswerKey { get; set; }

        /// <summary>
        /// This is the HTTPS URL of a JSON answer key with the same shape as<br/>
        /// `answerKey`, fetched when each run starts and never stored.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("answerKeyUrl")]
        public string? AnswerKeyUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TranscriptReplay" /> class.
        /// </summary>
        /// <param name="recordingUrl">
        /// This is the HTTPS URL of the recording, fetched when each run starts and<br/>
        /// never stored. Use a presigned URL that stays valid until the run executes.<br/>
        /// WAV, MP3, FLAC and OGG are supported; MP4 and M4A only when the file was<br/>
        /// written for streaming.<br/>
        /// Example: https://example.com/recordings/call-123.wav
        /// </param>
        /// <param name="answerKey">
        /// This is the answer key, inline. Supply this or `answerKeyUrl`, not both.<br/>
        /// Organizations with HIPAA, PCI or zero data retention enabled must use<br/>
        /// `answerKeyUrl`, so no answer key is stored.
        /// </param>
        /// <param name="answerKeyUrl">
        /// This is the HTTPS URL of a JSON answer key with the same shape as<br/>
        /// `answerKey`, fetched when each run starts and never stored.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TranscriptReplay(
            string recordingUrl,
            global::Vapi.TranscriptAnswerKey? answerKey,
            string? answerKeyUrl)
        {
            this.RecordingUrl = recordingUrl ?? throw new global::System.ArgumentNullException(nameof(recordingUrl));
            this.AnswerKey = answerKey;
            this.AnswerKeyUrl = answerKeyUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TranscriptReplay" /> class.
        /// </summary>
        public TranscriptReplay()
        {
        }

    }
}