
#nullable enable

namespace Vapi
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BackgroundSoundUrlValidationResult
    {
        /// <summary>
        /// Whether the URL currently serves a live media file. When false, calls configured with this URL silently play no background sound.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("valid")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Valid { get; set; }

        /// <summary>
        /// Why validation failed. Only present when valid is false.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reason")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.BackgroundSoundUrlValidationResultReasonJsonConverter))]
        public global::Vapi.BackgroundSoundUrlValidationResultReason? Reason { get; set; }

        /// <summary>
        /// The HTTP status the URL returned, when a response was received.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public double? Status { get; set; }

        /// <summary>
        /// The content-type the URL returned, when a response was received.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("contentType")]
        public string? ContentType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BackgroundSoundUrlValidationResult" /> class.
        /// </summary>
        /// <param name="valid">
        /// Whether the URL currently serves a live media file. When false, calls configured with this URL silently play no background sound.
        /// </param>
        /// <param name="reason">
        /// Why validation failed. Only present when valid is false.
        /// </param>
        /// <param name="status">
        /// The HTTP status the URL returned, when a response was received.
        /// </param>
        /// <param name="contentType">
        /// The content-type the URL returned, when a response was received.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BackgroundSoundUrlValidationResult(
            bool valid,
            global::Vapi.BackgroundSoundUrlValidationResultReason? reason,
            double? status,
            string? contentType)
        {
            this.Valid = valid;
            this.Reason = reason;
            this.Status = status;
            this.ContentType = contentType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BackgroundSoundUrlValidationResult" /> class.
        /// </summary>
        public BackgroundSoundUrlValidationResult()
        {
        }

    }
}