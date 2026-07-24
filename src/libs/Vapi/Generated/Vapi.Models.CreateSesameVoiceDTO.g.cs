
#nullable enable

namespace Vapi
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateSesameVoiceDTO
    {
        /// <summary>
        /// This is the audio file of the utterance to clone the voice from.<br/>
        /// Consumed by multer via FileInterceptor('file'), so it never reaches<br/>
        /// class-validator; declared here (like CreateFileDTO.file) so the OpenAPI<br/>
        /// spec is truthful about the multipart request body.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required byte[] File { get; set; }

        /// <summary>
        /// This is the audio file of the utterance to clone the voice from.<br/>
        /// Consumed by multer via FileInterceptor('file'), so it never reaches<br/>
        /// class-validator; declared here (like CreateFileDTO.file) so the OpenAPI<br/>
        /// spec is truthful about the multipart request body.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filename")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Filename { get; set; }

        /// <summary>
        /// The name of the voice.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voiceName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string VoiceName { get; set; }

        /// <summary>
        /// The transcript of the utterance.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transcription")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Transcription { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSesameVoiceDTO" /> class.
        /// </summary>
        /// <param name="file">
        /// This is the audio file of the utterance to clone the voice from.<br/>
        /// Consumed by multer via FileInterceptor('file'), so it never reaches<br/>
        /// class-validator; declared here (like CreateFileDTO.file) so the OpenAPI<br/>
        /// spec is truthful about the multipart request body.
        /// </param>
        /// <param name="filename">
        /// This is the audio file of the utterance to clone the voice from.<br/>
        /// Consumed by multer via FileInterceptor('file'), so it never reaches<br/>
        /// class-validator; declared here (like CreateFileDTO.file) so the OpenAPI<br/>
        /// spec is truthful about the multipart request body.
        /// </param>
        /// <param name="voiceName">
        /// The name of the voice.
        /// </param>
        /// <param name="transcription">
        /// The transcript of the utterance.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateSesameVoiceDTO(
            byte[] file,
            string filename,
            string voiceName,
            string transcription)
        {
            this.File = file ?? throw new global::System.ArgumentNullException(nameof(file));
            this.Filename = filename ?? throw new global::System.ArgumentNullException(nameof(filename));
            this.VoiceName = voiceName ?? throw new global::System.ArgumentNullException(nameof(voiceName));
            this.Transcription = transcription ?? throw new global::System.ArgumentNullException(nameof(transcription));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSesameVoiceDTO" /> class.
        /// </summary>
        public CreateSesameVoiceDTO()
        {
        }

    }
}