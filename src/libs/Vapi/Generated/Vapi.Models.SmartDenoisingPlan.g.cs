
#nullable enable

namespace Vapi
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SmartDenoisingPlan
    {
        /// <summary>
        /// Whether smart denoising using Krisp is enabled.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Intensity of the applied noise suppression, in the range [0, 100].<br/>
        /// - 0 indicates no noise suppression (audio passes through Krisp unchanged).<br/>
        /// - 100 indicates full noise suppression and is the historical default.<br/>
        /// Lower values are gentler; useful for narrowband telephony audio where<br/>
        /// aggressive suppression can over-attenuate brief or quiet user utterances.<br/>
        /// Per-call intensity is in beta, rolling out to select organizations and<br/>
        /// regions. Where it is not available, or the intensity-aware denoiser cannot<br/>
        /// be reached for a call, the standard denoiser runs at full suppression<br/>
        /// (100) whatever this is set to, so 0 does not turn suppression off there;<br/>
        /// set `enabled` to false for that. If the standard denoiser cannot be<br/>
        /// reached either, the call's audio passes through without smart denoising.<br/>
        /// @default 100<br/>
        /// Default Value: 100<br/>
        /// Example: 100
        /// </summary>
        /// <example>100</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("intensity")]
        public double? Intensity { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SmartDenoisingPlan" /> class.
        /// </summary>
        /// <param name="enabled">
        /// Whether smart denoising using Krisp is enabled.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="intensity">
        /// Intensity of the applied noise suppression, in the range [0, 100].<br/>
        /// - 0 indicates no noise suppression (audio passes through Krisp unchanged).<br/>
        /// - 100 indicates full noise suppression and is the historical default.<br/>
        /// Lower values are gentler; useful for narrowband telephony audio where<br/>
        /// aggressive suppression can over-attenuate brief or quiet user utterances.<br/>
        /// Per-call intensity is in beta, rolling out to select organizations and<br/>
        /// regions. Where it is not available, or the intensity-aware denoiser cannot<br/>
        /// be reached for a call, the standard denoiser runs at full suppression<br/>
        /// (100) whatever this is set to, so 0 does not turn suppression off there;<br/>
        /// set `enabled` to false for that. If the standard denoiser cannot be<br/>
        /// reached either, the call's audio passes through without smart denoising.<br/>
        /// @default 100<br/>
        /// Default Value: 100<br/>
        /// Example: 100
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SmartDenoisingPlan(
            bool? enabled,
            double? intensity)
        {
            this.Enabled = enabled;
            this.Intensity = intensity;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SmartDenoisingPlan" /> class.
        /// </summary>
        public SmartDenoisingPlan()
        {
        }

    }
}