
#nullable enable

namespace Vapi
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class TrafficAllocationControllerCreateResponseDiscriminator
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.TrafficAllocationControllerCreateResponseDiscriminatorErrorJsonConverter))]
        public global::Vapi.TrafficAllocationControllerCreateResponseDiscriminatorError? Error { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TrafficAllocationControllerCreateResponseDiscriminator" /> class.
        /// </summary>
        /// <param name="error"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TrafficAllocationControllerCreateResponseDiscriminator(
            global::Vapi.TrafficAllocationControllerCreateResponseDiscriminatorError? error)
        {
            this.Error = error;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TrafficAllocationControllerCreateResponseDiscriminator" /> class.
        /// </summary>
        public TrafficAllocationControllerCreateResponseDiscriminator()
        {
        }

    }
}