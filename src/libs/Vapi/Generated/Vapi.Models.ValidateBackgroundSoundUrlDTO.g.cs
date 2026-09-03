
#nullable enable

namespace Vapi
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ValidateBackgroundSoundUrlDTO
    {
        /// <summary>
        /// This is the background sound URL to validate. The server performs a ranged request and checks that the URL serves a live media file.<br/>
        /// Example: https://example.com/my-sound.mp3
        /// </summary>
        /// <example>https://example.com/my-sound.mp3</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ValidateBackgroundSoundUrlDTO" /> class.
        /// </summary>
        /// <param name="url">
        /// This is the background sound URL to validate. The server performs a ranged request and checks that the URL serves a live media file.<br/>
        /// Example: https://example.com/my-sound.mp3
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ValidateBackgroundSoundUrlDTO(
            string url)
        {
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ValidateBackgroundSoundUrlDTO" /> class.
        /// </summary>
        public ValidateBackgroundSoundUrlDTO()
        {
        }

    }
}