
#nullable enable

namespace Vapi
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class StructuredOutputRunResult
    {
        /// <summary>
        /// This is the name of the structured output that produced this value.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// This is the extracted value, shaped by the structured output's schema.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("result")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.OneOfJsonConverter<string, double?, bool?, object, byte[]>))]
        public global::Vapi.OneOf<string, double?, bool?, object, byte[]>? Result { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("compliancePlan")]
        public global::Vapi.ComplianceOverride? CompliancePlan { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StructuredOutputRunResult" /> class.
        /// </summary>
        /// <param name="name">
        /// This is the name of the structured output that produced this value.
        /// </param>
        /// <param name="result">
        /// This is the extracted value, shaped by the structured output's schema.
        /// </param>
        /// <param name="compliancePlan"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StructuredOutputRunResult(
            string name,
            global::Vapi.OneOf<string, double?, bool?, object, byte[]>? result,
            global::Vapi.ComplianceOverride? compliancePlan)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Result = result;
            this.CompliancePlan = compliancePlan;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StructuredOutputRunResult" /> class.
        /// </summary>
        public StructuredOutputRunResult()
        {
        }

    }
}