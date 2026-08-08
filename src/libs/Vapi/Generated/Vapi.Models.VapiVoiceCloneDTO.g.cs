
#nullable enable

namespace Vapi
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VapiVoiceCloneDTO
    {
        /// <summary>
        /// Display name for the cloned voice.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Optional language (ISO-639 / BCP-47). When omitted, xAI infers it from the<br/>
        /// reference audio.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        public string? Language { get; set; }

        /// <summary>
        /// Reference audio to clone the voice from (up to 120 seconds). Supported formats: MP3, WAV, OGG/Opus, WebM, AAC, M4A, FLAC, WMA.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("files")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<byte[]> Files { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VapiVoiceCloneDTO" /> class.
        /// </summary>
        /// <param name="name">
        /// Display name for the cloned voice.
        /// </param>
        /// <param name="files">
        /// Reference audio to clone the voice from (up to 120 seconds). Supported formats: MP3, WAV, OGG/Opus, WebM, AAC, M4A, FLAC, WMA.
        /// </param>
        /// <param name="language">
        /// Optional language (ISO-639 / BCP-47). When omitted, xAI infers it from the<br/>
        /// reference audio.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VapiVoiceCloneDTO(
            string name,
            global::System.Collections.Generic.IList<byte[]> files,
            string? language)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Language = language;
            this.Files = files ?? throw new global::System.ArgumentNullException(nameof(files));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VapiVoiceCloneDTO" /> class.
        /// </summary>
        public VapiVoiceCloneDTO()
        {
        }

    }
}