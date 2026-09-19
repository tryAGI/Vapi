
#nullable enable

namespace Vapi
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ToolControllerRemoveResponseDiscriminator2
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.ToolControllerRemoveResponseDiscriminatorErrorJsonConverter))]
        public global::Vapi.ToolControllerRemoveResponseDiscriminatorError? Error { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolControllerRemoveResponseDiscriminator2" /> class.
        /// </summary>
        /// <param name="error"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolControllerRemoveResponseDiscriminator2(
            global::Vapi.ToolControllerRemoveResponseDiscriminatorError? error)
        {
            this.Error = error;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolControllerRemoveResponseDiscriminator2" /> class.
        /// </summary>
        public ToolControllerRemoveResponseDiscriminator2()
        {
        }

    }
}