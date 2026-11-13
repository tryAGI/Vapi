
#nullable enable

namespace Vapi
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class LangfuseServerProbeResponse
    {
        /// <summary>
        /// Whether {apiUrl}/api/public/health answered at all.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reachable")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Reachable { get; set; }

        /// <summary>
        /// The exact version the server reported, e.g. 3.63.0. Absent when the destination answered without one (proxies, adapters) or not at all.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("serverVersion")]
        public string? ServerVersion { get; set; }

        /// <summary>
        /// Why the URL was refused without being contacted (a private address, plaintext http). Absent for a destination that was merely unreachable: supplying the version yourself applies there, but not here, because saving would refuse the URL with this same reason.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("blockedMessage")]
        public string? BlockedMessage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LangfuseServerProbeResponse" /> class.
        /// </summary>
        /// <param name="reachable">
        /// Whether {apiUrl}/api/public/health answered at all.
        /// </param>
        /// <param name="serverVersion">
        /// The exact version the server reported, e.g. 3.63.0. Absent when the destination answered without one (proxies, adapters) or not at all.
        /// </param>
        /// <param name="blockedMessage">
        /// Why the URL was refused without being contacted (a private address, plaintext http). Absent for a destination that was merely unreachable: supplying the version yourself applies there, but not here, because saving would refuse the URL with this same reason.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LangfuseServerProbeResponse(
            bool reachable,
            string? serverVersion,
            string? blockedMessage)
        {
            this.Reachable = reachable;
            this.ServerVersion = serverVersion;
            this.BlockedMessage = blockedMessage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LangfuseServerProbeResponse" /> class.
        /// </summary>
        public LangfuseServerProbeResponse()
        {
        }

    }
}