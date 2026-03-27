
#nullable enable

namespace Vapi
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FallbackCartesiaTranscriber
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.FallbackCartesiaTranscriberProviderJsonConverter))]
        public global::Vapi.FallbackCartesiaTranscriberProvider Provider { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.FallbackCartesiaTranscriberModelJsonConverter))]
        public global::Vapi.FallbackCartesiaTranscriberModel? Model { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.FallbackCartesiaTranscriberLanguageJsonConverter))]
        public global::Vapi.FallbackCartesiaTranscriberLanguage? Language { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FallbackCartesiaTranscriber" /> class.
        /// </summary>
        /// <param name="provider"></param>
        /// <param name="model"></param>
        /// <param name="language"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FallbackCartesiaTranscriber(
            global::Vapi.FallbackCartesiaTranscriberProvider provider,
            global::Vapi.FallbackCartesiaTranscriberModel? model,
            global::Vapi.FallbackCartesiaTranscriberLanguage? language)
        {
            this.Provider = provider;
            this.Model = model;
            this.Language = language;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FallbackCartesiaTranscriber" /> class.
        /// </summary>
        public FallbackCartesiaTranscriber()
        {
        }
    }
}