
#nullable enable

namespace Vapi
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class TrafficTabLatencyMsDTO
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vapi.TrafficTabLatencyStatsDTO Model { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vapi.TrafficTabLatencyStatsDTO Voice { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transcriber")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vapi.TrafficTabLatencyStatsDTO Transcriber { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("turn")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vapi.TrafficTabLatencyStatsDTO Turn { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TrafficTabLatencyMsDTO" /> class.
        /// </summary>
        /// <param name="model"></param>
        /// <param name="voice"></param>
        /// <param name="transcriber"></param>
        /// <param name="turn"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TrafficTabLatencyMsDTO(
            global::Vapi.TrafficTabLatencyStatsDTO model,
            global::Vapi.TrafficTabLatencyStatsDTO voice,
            global::Vapi.TrafficTabLatencyStatsDTO transcriber,
            global::Vapi.TrafficTabLatencyStatsDTO turn)
        {
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Voice = voice ?? throw new global::System.ArgumentNullException(nameof(voice));
            this.Transcriber = transcriber ?? throw new global::System.ArgumentNullException(nameof(transcriber));
            this.Turn = turn ?? throw new global::System.ArgumentNullException(nameof(turn));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TrafficTabLatencyMsDTO" /> class.
        /// </summary>
        public TrafficTabLatencyMsDTO()
        {
        }

    }
}