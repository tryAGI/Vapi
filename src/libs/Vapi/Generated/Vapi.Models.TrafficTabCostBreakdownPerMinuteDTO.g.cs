
#nullable enable

namespace Vapi
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class TrafficTabCostBreakdownPerMinuteDTO
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("llm")]
        public double? Llm { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stt")]
        public double? Stt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tts")]
        public double? Tts { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vapi")]
        public double? Vapi { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transport")]
        public double? Transport { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TrafficTabCostBreakdownPerMinuteDTO" /> class.
        /// </summary>
        /// <param name="llm"></param>
        /// <param name="stt"></param>
        /// <param name="tts"></param>
        /// <param name="vapi"></param>
        /// <param name="transport"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TrafficTabCostBreakdownPerMinuteDTO(
            double? llm,
            double? stt,
            double? tts,
            double? vapi,
            double? transport)
        {
            this.Llm = llm;
            this.Stt = stt;
            this.Tts = tts;
            this.Vapi = vapi;
            this.Transport = transport;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TrafficTabCostBreakdownPerMinuteDTO" /> class.
        /// </summary>
        public TrafficTabCostBreakdownPerMinuteDTO()
        {
        }

    }
}