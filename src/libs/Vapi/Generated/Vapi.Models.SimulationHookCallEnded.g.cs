
#nullable enable

namespace Vapi
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SimulationHookCallEnded
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("on")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.SimulationHookCallEndedOnJsonConverter))]
        public global::Vapi.SimulationHookCallEndedOn On { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("do")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vapi.SimulationHookWebhookAction> Do { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SimulationHookCallEnded" /> class.
        /// </summary>
        /// <param name="on"></param>
        /// <param name="do"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SimulationHookCallEnded(
            global::System.Collections.Generic.IList<global::Vapi.SimulationHookWebhookAction> @do,
            global::Vapi.SimulationHookCallEndedOn on)
        {
            this.Do = @do ?? throw new global::System.ArgumentNullException(nameof(@do));
            this.On = on;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SimulationHookCallEnded" /> class.
        /// </summary>
        public SimulationHookCallEnded()
        {
        }
    }
}