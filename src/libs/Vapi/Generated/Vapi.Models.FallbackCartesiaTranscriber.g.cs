
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
        /// Ink 2 speech likelihood above which a turn starts. Higher values require stronger speech evidence. Must exceed turnEagerEndThreshold, which is 0.4 when unset. When unset, the Cartesia server default (currently 0.8) applies. With startSpeakingPlan.smartEndpointingPlan unset, this affects when the assistant replies. A smart endpointing plan decides reply timing itself from Ink 2's partial and final transcripts, so with one set this only shapes the plan's input.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("turnStartThreshold")]
        public double? TurnStartThreshold { get; set; }

        /// <summary>
        /// Ink 2 speech likelihood below which an eager end fires. Higher values fire sooner. Must be below turnStartThreshold (0.8 when unset) and above turnEndThreshold (0.2 when unset). Eager ends are emitted as partial transcripts. With startSpeakingPlan.smartEndpointingPlan unset they do not start a model request, so tuning this changes when the event is observed rather than when the assistant replies. A smart endpointing plan receives them with Ink 2's other transcripts and decides reply timing itself. When unset, the Cartesia server default (currently 0.4) applies.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("turnEagerEndThreshold")]
        public double? TurnEagerEndThreshold { get; set; }

        /// <summary>
        /// Ink 2 speech likelihood below which a turn ends. Higher values end the turn sooner. Must be below turnEagerEndThreshold, which is 0.4 when unset; values at or above that therefore require raising turnEagerEndThreshold as well. When unset, the Cartesia server default (currently 0.2) applies. With startSpeakingPlan.smartEndpointingPlan unset, this affects when the assistant replies. A smart endpointing plan decides reply timing itself from Ink 2's partial and final transcripts, so with one set this only shapes the plan's input.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("turnEndThreshold")]
        public double? TurnEndThreshold { get; set; }

        /// <summary>
        /// Maximum Ink 2 wait after speech stops, in milliseconds. Lower values force an earlier end. When unset, the Cartesia server default (currently 5600) applies. With startSpeakingPlan.smartEndpointingPlan unset, this affects when the assistant replies. A smart endpointing plan decides reply timing itself from Ink 2's partial and final transcripts, so with one set this only shapes the plan's input.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("turnEndTimeoutMs")]
        public int? TurnEndTimeoutMs { get; set; }

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
        /// <param name="turnStartThreshold">
        /// Ink 2 speech likelihood above which a turn starts. Higher values require stronger speech evidence. Must exceed turnEagerEndThreshold, which is 0.4 when unset. When unset, the Cartesia server default (currently 0.8) applies. With startSpeakingPlan.smartEndpointingPlan unset, this affects when the assistant replies. A smart endpointing plan decides reply timing itself from Ink 2's partial and final transcripts, so with one set this only shapes the plan's input.
        /// </param>
        /// <param name="turnEagerEndThreshold">
        /// Ink 2 speech likelihood below which an eager end fires. Higher values fire sooner. Must be below turnStartThreshold (0.8 when unset) and above turnEndThreshold (0.2 when unset). Eager ends are emitted as partial transcripts. With startSpeakingPlan.smartEndpointingPlan unset they do not start a model request, so tuning this changes when the event is observed rather than when the assistant replies. A smart endpointing plan receives them with Ink 2's other transcripts and decides reply timing itself. When unset, the Cartesia server default (currently 0.4) applies.
        /// </param>
        /// <param name="turnEndThreshold">
        /// Ink 2 speech likelihood below which a turn ends. Higher values end the turn sooner. Must be below turnEagerEndThreshold, which is 0.4 when unset; values at or above that therefore require raising turnEagerEndThreshold as well. When unset, the Cartesia server default (currently 0.2) applies. With startSpeakingPlan.smartEndpointingPlan unset, this affects when the assistant replies. A smart endpointing plan decides reply timing itself from Ink 2's partial and final transcripts, so with one set this only shapes the plan's input.
        /// </param>
        /// <param name="turnEndTimeoutMs">
        /// Maximum Ink 2 wait after speech stops, in milliseconds. Lower values force an earlier end. When unset, the Cartesia server default (currently 5600) applies. With startSpeakingPlan.smartEndpointingPlan unset, this affects when the assistant replies. A smart endpointing plan decides reply timing itself from Ink 2's partial and final transcripts, so with one set this only shapes the plan's input.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FallbackCartesiaTranscriber(
            global::Vapi.FallbackCartesiaTranscriberProvider provider,
            global::Vapi.FallbackCartesiaTranscriberModel? model,
            global::Vapi.FallbackCartesiaTranscriberLanguage? language,
            double? turnStartThreshold,
            double? turnEagerEndThreshold,
            double? turnEndThreshold,
            int? turnEndTimeoutMs)
        {
            this.Provider = provider;
            this.Model = model;
            this.Language = language;
            this.TurnStartThreshold = turnStartThreshold;
            this.TurnEagerEndThreshold = turnEagerEndThreshold;
            this.TurnEndThreshold = turnEndThreshold;
            this.TurnEndTimeoutMs = turnEndTimeoutMs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FallbackCartesiaTranscriber" /> class.
        /// </summary>
        public FallbackCartesiaTranscriber()
        {
        }

    }
}