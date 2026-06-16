
#nullable enable

namespace Vapi
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AudioFormat
    {
        /// <summary>
        /// This is the sample rate of the call.<br/>
        /// @default 16000
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sampleRate")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double SampleRate { get; set; }

        /// <summary>
        /// This is the audio format of the call.<br/>
        /// @default 'pcm_s16le'
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("format")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Format { get; set; }

        /// <summary>
        /// This is the container format of the call.<br/>
        /// @default 'raw'
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("container")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.AudioFormatContainerJsonConverter))]
        public global::Vapi.AudioFormatContainer? Container { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioFormat" /> class.
        /// </summary>
        /// <param name="sampleRate">
        /// This is the sample rate of the call.<br/>
        /// @default 16000
        /// </param>
        /// <param name="format">
        /// This is the audio format of the call.<br/>
        /// @default 'pcm_s16le'
        /// </param>
        /// <param name="container">
        /// This is the container format of the call.<br/>
        /// @default 'raw'
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AudioFormat(
            double sampleRate,
            object format,
            global::Vapi.AudioFormatContainer? container)
        {
            this.SampleRate = sampleRate;
            this.Format = format ?? throw new global::System.ArgumentNullException(nameof(format));
            this.Container = container;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioFormat" /> class.
        /// </summary>
        public AudioFormat()
        {
        }

    }
}