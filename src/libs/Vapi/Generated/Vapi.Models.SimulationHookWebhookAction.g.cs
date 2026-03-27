
#nullable enable

namespace Vapi
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SimulationHookWebhookAction
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.SimulationHookWebhookActionTypeJsonConverter))]
        public global::Vapi.SimulationHookWebhookActionType Type { get; set; }

        /// <summary>
        /// Optional server override for this hook action.<br/>
        /// If omitted, runtime defaults may apply (e.g. org server).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("server")]
        public global::Vapi.Server? Server { get; set; }

        /// <summary>
        /// Optional payload include controls.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("include")]
        public global::Vapi.SimulationHookInclude? Include { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SimulationHookWebhookAction" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="server">
        /// Optional server override for this hook action.<br/>
        /// If omitted, runtime defaults may apply (e.g. org server).
        /// </param>
        /// <param name="include">
        /// Optional payload include controls.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SimulationHookWebhookAction(
            global::Vapi.SimulationHookWebhookActionType type,
            global::Vapi.Server? server,
            global::Vapi.SimulationHookInclude? include)
        {
            this.Type = type;
            this.Server = server;
            this.Include = include;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SimulationHookWebhookAction" /> class.
        /// </summary>
        public SimulationHookWebhookAction()
        {
        }
    }
}