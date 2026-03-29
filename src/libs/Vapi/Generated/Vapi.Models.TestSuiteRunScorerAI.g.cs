
#nullable enable

namespace Vapi
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TestSuiteRunScorerAI
    {
        /// <summary>
        /// This is the type of the scorer, which must be AI.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.TestSuiteRunScorerAITypeJsonConverter))]
        public global::Vapi.TestSuiteRunScorerAIType Type { get; set; }

        /// <summary>
        /// This is the result of the test suite.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("result")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.TestSuiteRunScorerAIResultJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vapi.TestSuiteRunScorerAIResult Result { get; set; }

        /// <summary>
        /// This is the reasoning provided by the AI scorer.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reasoning")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Reasoning { get; set; }

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
        /// Initializes a new instance of the <see cref="TestSuiteRunScorerAI" /> class.
        /// </summary>
        /// <param name="result">
        /// This is the result of the test suite.
        /// </param>
        /// <param name="reasoning">
        /// This is the reasoning provided by the AI scorer.
        /// </param>
        /// <param name="rubric">
        /// This is the rubric used by the AI scorer.
        /// </param>
        /// <param name="type">
        /// This is the type of the scorer, which must be AI.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TestSuiteRunScorerAI(
            global::Vapi.TestSuiteRunScorerAIResult result,
            string reasoning,
            string rubric,
            global::Vapi.TestSuiteRunScorerAIType type)
        {
            this.Type = type;
            this.Result = result;
            this.Reasoning = reasoning ?? throw new global::System.ArgumentNullException(nameof(reasoning));
            this.Rubric = rubric ?? throw new global::System.ArgumentNullException(nameof(rubric));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TestSuiteRunScorerAI" /> class.
        /// </summary>
        public TestSuiteRunScorerAI()
        {
        }
    }
}