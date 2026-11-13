
#nullable enable

namespace Vapi
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SipTrunkOutboundAuthenticationPlan
    {
        /// <summary>
        /// This is not returned in the API.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("authPassword")]
        public string? AuthPassword { get; set; }

        /// <summary>
        /// This can be used to configure if SIP register is required by the SIP trunk. On creation, omission disables registration. On update, omission preserves it; null disables it.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sipRegisterPlan")]
        public global::Vapi.SipTrunkOutboundSipRegisterPlan? SipRegisterPlan { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("authUsername")]
        public string? AuthUsername { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SipTrunkOutboundAuthenticationPlan" /> class.
        /// </summary>
        /// <param name="authPassword">
        /// This is not returned in the API.
        /// </param>
        /// <param name="sipRegisterPlan">
        /// This can be used to configure if SIP register is required by the SIP trunk. On creation, omission disables registration. On update, omission preserves it; null disables it.
        /// </param>
        /// <param name="authUsername"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SipTrunkOutboundAuthenticationPlan(
            string? authPassword,
            global::Vapi.SipTrunkOutboundSipRegisterPlan? sipRegisterPlan,
            string? authUsername)
        {
            this.AuthPassword = authPassword;
            this.SipRegisterPlan = sipRegisterPlan;
            this.AuthUsername = authUsername;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SipTrunkOutboundAuthenticationPlan" /> class.
        /// </summary>
        public SipTrunkOutboundAuthenticationPlan()
        {
        }

    }
}