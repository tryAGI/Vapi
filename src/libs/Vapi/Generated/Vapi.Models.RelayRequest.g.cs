
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vapi
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RelayRequest
    {
        /// <summary>
        /// The source identifier of the relay request
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Source { get; set; }

        /// <summary>
        /// The target assistant or squad to relay the commands to
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.RelayTargetAssistant, global::Vapi.RelayTargetSquad>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vapi.OneOf<global::Vapi.RelayTargetAssistant, global::Vapi.RelayTargetSquad> Target { get; set; }

        /// <summary>
        /// The unique identifier of the customer
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("customerId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CustomerId { get; set; }

        /// <summary>
        /// The list of commands to relay to the target
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("commands")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vapi.OneOf<global::Vapi.RelayCommandSay, global::Vapi.RelayCommandNote>> Commands { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RelayRequest" /> class.
        /// </summary>
        /// <param name="source">
        /// The source identifier of the relay request
        /// </param>
        /// <param name="target">
        /// The target assistant or squad to relay the commands to
        /// </param>
        /// <param name="customerId">
        /// The unique identifier of the customer
        /// </param>
        /// <param name="commands">
        /// The list of commands to relay to the target
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RelayRequest(
            string source,
            global::Vapi.OneOf<global::Vapi.RelayTargetAssistant, global::Vapi.RelayTargetSquad> target,
            string customerId,
            global::System.Collections.Generic.IList<global::Vapi.OneOf<global::Vapi.RelayCommandSay, global::Vapi.RelayCommandNote>> commands)
        {
            this.Source = source ?? throw new global::System.ArgumentNullException(nameof(source));
            this.Target = target;
            this.CustomerId = customerId ?? throw new global::System.ArgumentNullException(nameof(customerId));
            this.Commands = commands ?? throw new global::System.ArgumentNullException(nameof(commands));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RelayRequest" /> class.
        /// </summary>
        public RelayRequest()
        {
        }
    }
}