
#nullable enable

namespace Vapi
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SimulationOnboardingOpenQuestionDTO
    {
        /// <summary>
        /// Question id within its draft, e.g. `Q1`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// A question about expected assistant behavior that needs clarification.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// Which requirement the answer changes, and how.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("why")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Why { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SimulationOnboardingOpenQuestionDTO" /> class.
        /// </summary>
        /// <param name="id">
        /// Question id within its draft, e.g. `Q1`.
        /// </param>
        /// <param name="text">
        /// A question about expected assistant behavior that needs clarification.
        /// </param>
        /// <param name="why">
        /// Which requirement the answer changes, and how.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SimulationOnboardingOpenQuestionDTO(
            string id,
            string text,
            string why)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.Why = why ?? throw new global::System.ArgumentNullException(nameof(why));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SimulationOnboardingOpenQuestionDTO" /> class.
        /// </summary>
        public SimulationOnboardingOpenQuestionDTO()
        {
        }

    }
}