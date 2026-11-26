
#nullable enable

namespace Vapi
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AssistantFallbackWarning
    {
        /// <summary>
        /// Machine-readable reason for the warning.<br/>
        /// Example: fallback-voice-same-provider
        /// </summary>
        /// <example>fallback-voice-same-provider</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.AssistantFallbackWarningCodeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vapi.AssistantFallbackWarningCode Code { get; set; }

        /// <summary>
        /// Path of the setting the warning is about, relative to the assistant:<br/>
        /// `voice.fallbackPlan.voices[1]` for one fallback, or<br/>
        /// `voice.fallbackPlan.voices` for the whole list.<br/>
        /// Example: voice.fallbackPlan.voices[0]
        /// </summary>
        /// <example>voice.fallbackPlan.voices[0]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("slot")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Slot { get; set; }

        /// <summary>
        /// Human-readable explanation, in sentence case.<br/>
        /// Example: Fallback voice 1 uses the same provider as the primary (11labs), so an outage there takes down both.
        /// </summary>
        /// <example>Fallback voice 1 uses the same provider as the primary (11labs), so an outage there takes down both.</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AssistantFallbackWarning" /> class.
        /// </summary>
        /// <param name="code">
        /// Machine-readable reason for the warning.<br/>
        /// Example: fallback-voice-same-provider
        /// </param>
        /// <param name="slot">
        /// Path of the setting the warning is about, relative to the assistant:<br/>
        /// `voice.fallbackPlan.voices[1]` for one fallback, or<br/>
        /// `voice.fallbackPlan.voices` for the whole list.<br/>
        /// Example: voice.fallbackPlan.voices[0]
        /// </param>
        /// <param name="message">
        /// Human-readable explanation, in sentence case.<br/>
        /// Example: Fallback voice 1 uses the same provider as the primary (11labs), so an outage there takes down both.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AssistantFallbackWarning(
            global::Vapi.AssistantFallbackWarningCode code,
            string slot,
            string message)
        {
            this.Code = code;
            this.Slot = slot ?? throw new global::System.ArgumentNullException(nameof(slot));
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AssistantFallbackWarning" /> class.
        /// </summary>
        public AssistantFallbackWarning()
        {
        }

    }
}