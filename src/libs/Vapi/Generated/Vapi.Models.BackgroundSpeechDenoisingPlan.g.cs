
#nullable enable

namespace Vapi
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BackgroundSpeechDenoisingPlan
    {
        /// <summary>
        /// Whether smart denoising using Krisp is enabled.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("smartDenoisingPlan")]
        public global::Vapi.SmartDenoisingPlan? SmartDenoisingPlan { get; set; }

        /// <summary>
        /// Whether Fourier denoising is enabled. Note that this is experimental and may not work as expected.<br/>
        /// This can be combined with smart denoising, and will be run afterwards.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fourierDenoisingPlan")]
        public global::Vapi.FourierDenoisingPlan? FourierDenoisingPlan { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BackgroundSpeechDenoisingPlan" /> class.
        /// </summary>
        /// <param name="smartDenoisingPlan">
        /// Whether smart denoising using Krisp is enabled.
        /// </param>
        /// <param name="fourierDenoisingPlan">
        /// Whether Fourier denoising is enabled. Note that this is experimental and may not work as expected.<br/>
        /// This can be combined with smart denoising, and will be run afterwards.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BackgroundSpeechDenoisingPlan(
            global::Vapi.SmartDenoisingPlan? smartDenoisingPlan,
            global::Vapi.FourierDenoisingPlan? fourierDenoisingPlan)
        {
            this.SmartDenoisingPlan = smartDenoisingPlan;
            this.FourierDenoisingPlan = fourierDenoisingPlan;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BackgroundSpeechDenoisingPlan" /> class.
        /// </summary>
        public BackgroundSpeechDenoisingPlan()
        {
        }
    }
}