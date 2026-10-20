
#nullable enable

namespace Vapi
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class TrafficTabStructuredOutputDTO
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("structuredOutputId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string StructuredOutputId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.TrafficTabStructuredOutputDTOTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vapi.TrafficTabStructuredOutputDTOType Type { get; set; }

        /// <summary>
        /// Calls in the window where this output produced a result.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("present")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Present { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("numeric")]
        public global::Vapi.TrafficTabStructuredOutputNumericDTO? Numeric { get; set; }

        /// <summary>
        /// Top 10 values by count, for string/boolean outputs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("valueCounts")]
        public global::System.Collections.Generic.IList<global::Vapi.TrafficTabStructuredOutputValueCountDTO>? ValueCounts { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TrafficTabStructuredOutputDTO" /> class.
        /// </summary>
        /// <param name="structuredOutputId"></param>
        /// <param name="type"></param>
        /// <param name="present">
        /// Calls in the window where this output produced a result.
        /// </param>
        /// <param name="numeric"></param>
        /// <param name="valueCounts">
        /// Top 10 values by count, for string/boolean outputs.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TrafficTabStructuredOutputDTO(
            string structuredOutputId,
            global::Vapi.TrafficTabStructuredOutputDTOType type,
            double present,
            global::Vapi.TrafficTabStructuredOutputNumericDTO? numeric,
            global::System.Collections.Generic.IList<global::Vapi.TrafficTabStructuredOutputValueCountDTO>? valueCounts)
        {
            this.StructuredOutputId = structuredOutputId ?? throw new global::System.ArgumentNullException(nameof(structuredOutputId));
            this.Type = type;
            this.Present = present;
            this.Numeric = numeric;
            this.ValueCounts = valueCounts;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TrafficTabStructuredOutputDTO" /> class.
        /// </summary>
        public TrafficTabStructuredOutputDTO()
        {
        }

    }
}