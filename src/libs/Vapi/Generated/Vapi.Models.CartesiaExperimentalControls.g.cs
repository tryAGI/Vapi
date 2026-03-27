
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vapi
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CartesiaExperimentalControls
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speed")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.CartesiaExperimentalControlsSpeed?, double?>))]
        public global::Vapi.OneOf<global::Vapi.CartesiaExperimentalControlsSpeed?, double?>? Speed { get; set; }

        /// <summary>
        /// Example: [happiness:high]
        /// </summary>
        /// <example>[happiness:high]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("emotion")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.CartesiaExperimentalControlsEmotionJsonConverter))]
        public global::Vapi.CartesiaExperimentalControlsEmotion? Emotion { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CartesiaExperimentalControls" /> class.
        /// </summary>
        /// <param name="speed"></param>
        /// <param name="emotion">
        /// Example: [happiness:high]
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CartesiaExperimentalControls(
            global::Vapi.OneOf<global::Vapi.CartesiaExperimentalControlsSpeed?, double?>? speed,
            global::Vapi.CartesiaExperimentalControlsEmotion? emotion)
        {
            this.Speed = speed;
            this.Emotion = emotion;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CartesiaExperimentalControls" /> class.
        /// </summary>
        public CartesiaExperimentalControls()
        {
        }
    }
}