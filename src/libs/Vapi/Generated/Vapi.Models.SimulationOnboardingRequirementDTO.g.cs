
#nullable enable

namespace Vapi
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SimulationOnboardingRequirementDTO
    {
        /// <summary>
        /// Stable requirement id, e.g. `R3`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// One observable behaviour the assistant must get right.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// Why this requirement needs the user's attention, when it does.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tag")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.SimulationOnboardingRequirementDTOTagJsonConverter))]
        public global::Vapi.SimulationOnboardingRequirementDTOTag? Tag { get; set; }

        /// <summary>
        /// What was assumed, why only a voice run can check it, or why it cannot be tested.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("note")]
        public string? Note { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SimulationOnboardingRequirementDTO" /> class.
        /// </summary>
        /// <param name="id">
        /// Stable requirement id, e.g. `R3`.
        /// </param>
        /// <param name="text">
        /// One observable behaviour the assistant must get right.
        /// </param>
        /// <param name="tag">
        /// Why this requirement needs the user's attention, when it does.
        /// </param>
        /// <param name="note">
        /// What was assumed, why only a voice run can check it, or why it cannot be tested.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SimulationOnboardingRequirementDTO(
            string id,
            string text,
            global::Vapi.SimulationOnboardingRequirementDTOTag? tag,
            string? note)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.Tag = tag;
            this.Note = note;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SimulationOnboardingRequirementDTO" /> class.
        /// </summary>
        public SimulationOnboardingRequirementDTO()
        {
        }

    }
}