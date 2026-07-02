
#nullable enable

namespace Vapi
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ServerMessageResponseCampaignPredial
    {
        /// <summary>
        /// This is whether the contact is eligible to be dialed. When `false` — or when the server is unreachable, errors, or times out — the contact is skipped and not called.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("eligible")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Eligible { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ServerMessageResponseCampaignPredial" /> class.
        /// </summary>
        /// <param name="eligible">
        /// This is whether the contact is eligible to be dialed. When `false` — or when the server is unreachable, errors, or times out — the contact is skipped and not called.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ServerMessageResponseCampaignPredial(
            bool eligible)
        {
            this.Eligible = eligible;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ServerMessageResponseCampaignPredial" /> class.
        /// </summary>
        public ServerMessageResponseCampaignPredial()
        {
        }

    }
}