
#nullable enable

namespace Vapi
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class LangfuseServerProbeDTO
    {
        /// <summary>
        /// The Langfuse host URL to probe, e.g. https://cloud.langfuse.com. Only the unauthenticated health endpoint is read; no keys are involved.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("apiUrl")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ApiUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LangfuseServerProbeDTO" /> class.
        /// </summary>
        /// <param name="apiUrl">
        /// The Langfuse host URL to probe, e.g. https://cloud.langfuse.com. Only the unauthenticated health endpoint is read; no keys are involved.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LangfuseServerProbeDTO(
            string apiUrl)
        {
            this.ApiUrl = apiUrl ?? throw new global::System.ArgumentNullException(nameof(apiUrl));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LangfuseServerProbeDTO" /> class.
        /// </summary>
        public LangfuseServerProbeDTO()
        {
        }

    }
}