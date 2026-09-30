
#nullable enable

namespace Vapi
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class TrafficAllocationLatestResponseDTO
    {
        /// <summary>
        /// The source's current configuration: the newest allocation row with its targets. Absent when the source has never been configured.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allocation")]
        public global::Vapi.TrafficAllocation? Allocation { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TrafficAllocationLatestResponseDTO" /> class.
        /// </summary>
        /// <param name="allocation">
        /// The source's current configuration: the newest allocation row with its targets. Absent when the source has never been configured.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TrafficAllocationLatestResponseDTO(
            global::Vapi.TrafficAllocation? allocation)
        {
            this.Allocation = allocation;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TrafficAllocationLatestResponseDTO" /> class.
        /// </summary>
        public TrafficAllocationLatestResponseDTO()
        {
        }

    }
}