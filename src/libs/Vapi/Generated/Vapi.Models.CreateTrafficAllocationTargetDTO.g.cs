
#nullable enable

namespace Vapi
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateTrafficAllocationTargetDTO
    {
        /// <summary>
        /// A published version of this assistant, such as "v7". To split onto a new version, publish it first, then create the allocation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assistantVersion")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AssistantVersion { get; set; }

        /// <summary>
        /// Share of calls sent to this version, from 0 to 100 with up to three decimal places. Finer values are rejected, not rounded. All targets together add up to exactly 100. Position is taken from array order.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("percentage")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Percentage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTrafficAllocationTargetDTO" /> class.
        /// </summary>
        /// <param name="assistantVersion">
        /// A published version of this assistant, such as "v7". To split onto a new version, publish it first, then create the allocation.
        /// </param>
        /// <param name="percentage">
        /// Share of calls sent to this version, from 0 to 100 with up to three decimal places. Finer values are rejected, not rounded. All targets together add up to exactly 100. Position is taken from array order.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateTrafficAllocationTargetDTO(
            string assistantVersion,
            double percentage)
        {
            this.AssistantVersion = assistantVersion ?? throw new global::System.ArgumentNullException(nameof(assistantVersion));
            this.Percentage = percentage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTrafficAllocationTargetDTO" /> class.
        /// </summary>
        public CreateTrafficAllocationTargetDTO()
        {
        }

    }
}