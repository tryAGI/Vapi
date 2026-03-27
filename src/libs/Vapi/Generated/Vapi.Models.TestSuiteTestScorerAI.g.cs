
#nullable enable

namespace Vapi
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TestSuiteTestScorerAI
    {
        /// <summary>
        /// This is the type of the scorer, which must be AI.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.TestSuiteTestScorerAITypeJsonConverter))]
        public global::Vapi.TestSuiteTestScorerAIType Type { get; set; }

        /// <summary>
        /// This is the rubric used by the AI scorer.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rubric")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Rubric { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TestSuiteTestScorerAI" /> class.
        /// </summary>
        /// <param name="type">
        /// This is the type of the scorer, which must be AI.
        /// </param>
        /// <param name="rubric">
        /// This is the rubric used by the AI scorer.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TestSuiteTestScorerAI(
            string rubric,
            global::Vapi.TestSuiteTestScorerAIType type)
        {
            this.Rubric = rubric ?? throw new global::System.ArgumentNullException(nameof(rubric));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TestSuiteTestScorerAI" /> class.
        /// </summary>
        public TestSuiteTestScorerAI()
        {
        }
    }
}