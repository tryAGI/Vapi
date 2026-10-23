
#nullable enable

namespace Vapi
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SimulationOnboardingSuiteUpdateDTO
    {
        /// <summary>
        /// A new key for each edit. Replaying an applied key changes nothing and returns the current suite. A suite remembers its last 50 keys, so never reuse one.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("patchKey")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PatchKey { get; set; }

        /// <summary>
        /// Simulations to take out of the suite. They are unlinked, not deleted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("removeSimulationIds")]
        public global::System.Collections.Generic.IList<global::System.Guid>? RemoveSimulationIds { get; set; }

        /// <summary>
        /// Simulations to rewrite in place, at most one edit per simulation: put every change for a simulation in one instruction.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("edits")]
        public global::System.Collections.Generic.IList<global::Vapi.SimulationOnboardingSuiteEditDTO>? Edits { get; set; }

        /// <summary>
        /// Regenerate the scenarios that failed or did not fit when the suite was generated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("retryFailed")]
        public bool? RetryFailed { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SimulationOnboardingSuiteUpdateDTO" /> class.
        /// </summary>
        /// <param name="patchKey">
        /// A new key for each edit. Replaying an applied key changes nothing and returns the current suite. A suite remembers its last 50 keys, so never reuse one.
        /// </param>
        /// <param name="removeSimulationIds">
        /// Simulations to take out of the suite. They are unlinked, not deleted.
        /// </param>
        /// <param name="edits">
        /// Simulations to rewrite in place, at most one edit per simulation: put every change for a simulation in one instruction.
        /// </param>
        /// <param name="retryFailed">
        /// Regenerate the scenarios that failed or did not fit when the suite was generated.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SimulationOnboardingSuiteUpdateDTO(
            string patchKey,
            global::System.Collections.Generic.IList<global::System.Guid>? removeSimulationIds,
            global::System.Collections.Generic.IList<global::Vapi.SimulationOnboardingSuiteEditDTO>? edits,
            bool? retryFailed)
        {
            this.PatchKey = patchKey ?? throw new global::System.ArgumentNullException(nameof(patchKey));
            this.RemoveSimulationIds = removeSimulationIds;
            this.Edits = edits;
            this.RetryFailed = retryFailed;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SimulationOnboardingSuiteUpdateDTO" /> class.
        /// </summary>
        public SimulationOnboardingSuiteUpdateDTO()
        {
        }

    }
}