
#nullable enable

namespace Vapi
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SimulationRunItemResultsStructuredOutputs2
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("result")]
        public object? Result { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SimulationRunItemResultsStructuredOutputs2" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="result"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SimulationRunItemResultsStructuredOutputs2(
            string name,
            object? result)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Result = result;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SimulationRunItemResultsStructuredOutputs2" /> class.
        /// </summary>
        public SimulationRunItemResultsStructuredOutputs2()
        {
        }

    }
}