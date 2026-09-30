
#nullable enable

namespace Vapi
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class TrafficAllocationTarget
    {
        /// <summary>
        /// The assistant version this target sends calls to, such as "v7".
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assistantVersion")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AssistantVersion { get; set; }

        /// <summary>
        /// The target's place in the split, starting at 0. Set from the order of the targets array.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("position")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Position { get; set; }

        /// <summary>
        /// Share of calls sent to this version, from 0 to 100 with up to three decimal places. Targets add up to exactly 100. A 0% target keeps the version in the split without sending it calls.
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
        /// Initializes a new instance of the <see cref="TrafficAllocationTarget" /> class.
        /// </summary>
        /// <param name="assistantVersion">
        /// The assistant version this target sends calls to, such as "v7".
        /// </param>
        /// <param name="position">
        /// The target's place in the split, starting at 0. Set from the order of the targets array.
        /// </param>
        /// <param name="percentage">
        /// Share of calls sent to this version, from 0 to 100 with up to three decimal places. Targets add up to exactly 100. A 0% target keeps the version in the split without sending it calls.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TrafficAllocationTarget(
            string assistantVersion,
            double position,
            double percentage)
        {
            this.AssistantVersion = assistantVersion ?? throw new global::System.ArgumentNullException(nameof(assistantVersion));
            this.Position = position;
            this.Percentage = percentage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TrafficAllocationTarget" /> class.
        /// </summary>
        public TrafficAllocationTarget()
        {
        }

    }
}