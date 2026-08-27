
#nullable enable

namespace Vapi
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class TransferArtifact
    {
        /// <summary>
        /// The transfer destination (phone number or SIP URI).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("destination")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.TransferDestinationNumber, global::Vapi.TransferDestinationSip>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vapi.OneOf<global::Vapi.TransferDestinationNumber, global::Vapi.TransferDestinationSip> Destination { get; set; }

        /// <summary>
        /// The transfer mode (e.g. warm-transfer-experimental, blind-transfer).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.TransferArtifactModeJsonConverter))]
        public global::Vapi.TransferArtifactMode? Mode { get; set; }

        /// <summary>
        /// Flat-text transcript / announcement preview of the transfer.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transcript")]
        public string? Transcript { get; set; }

        /// <summary>
        /// The terminal status of the transfer, rendered as the status line.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.TransferArtifactStatusJsonConverter))]
        public global::Vapi.TransferArtifactStatus? Status { get; set; }

        /// <summary>
        /// The agent↔operator conversation captured during a<br/>
        /// warm-transfer-experimental, rendered as bubbles.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("messages")]
        public global::System.Collections.Generic.IList<global::Vapi.OneOf<global::Vapi.UserMessage, global::Vapi.SystemMessage, global::Vapi.BotMessage, global::Vapi.ToolCallMessage, global::Vapi.ToolCallResultMessage>>? Messages { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TransferArtifact" /> class.
        /// </summary>
        /// <param name="destination">
        /// The transfer destination (phone number or SIP URI).
        /// </param>
        /// <param name="mode">
        /// The transfer mode (e.g. warm-transfer-experimental, blind-transfer).
        /// </param>
        /// <param name="transcript">
        /// Flat-text transcript / announcement preview of the transfer.
        /// </param>
        /// <param name="status">
        /// The terminal status of the transfer, rendered as the status line.
        /// </param>
        /// <param name="messages">
        /// The agent↔operator conversation captured during a<br/>
        /// warm-transfer-experimental, rendered as bubbles.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TransferArtifact(
            global::Vapi.OneOf<global::Vapi.TransferDestinationNumber, global::Vapi.TransferDestinationSip> destination,
            global::Vapi.TransferArtifactMode? mode,
            string? transcript,
            global::Vapi.TransferArtifactStatus? status,
            global::System.Collections.Generic.IList<global::Vapi.OneOf<global::Vapi.UserMessage, global::Vapi.SystemMessage, global::Vapi.BotMessage, global::Vapi.ToolCallMessage, global::Vapi.ToolCallResultMessage>>? messages)
        {
            this.Destination = destination;
            this.Mode = mode;
            this.Transcript = transcript;
            this.Status = status;
            this.Messages = messages;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TransferArtifact" /> class.
        /// </summary>
        public TransferArtifact()
        {
        }

    }
}