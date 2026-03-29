
#nullable enable

namespace Vapi
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TrieveKnowledgeBaseCreate
    {
        /// <summary>
        /// This is to create a new dataset on Trieve.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.TrieveKnowledgeBaseCreateTypeJsonConverter))]
        public global::Vapi.TrieveKnowledgeBaseCreateType Type { get; set; }

        /// <summary>
        /// These are the chunk plans used to create the dataset.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chunkPlans")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vapi.TrieveKnowledgeBaseChunkPlan> ChunkPlans { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TrieveKnowledgeBaseCreate" /> class.
        /// </summary>
        /// <param name="chunkPlans">
        /// These are the chunk plans used to create the dataset.
        /// </param>
        /// <param name="type">
        /// This is to create a new dataset on Trieve.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TrieveKnowledgeBaseCreate(
            global::System.Collections.Generic.IList<global::Vapi.TrieveKnowledgeBaseChunkPlan> chunkPlans,
            global::Vapi.TrieveKnowledgeBaseCreateType type)
        {
            this.Type = type;
            this.ChunkPlans = chunkPlans ?? throw new global::System.ArgumentNullException(nameof(chunkPlans));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TrieveKnowledgeBaseCreate" /> class.
        /// </summary>
        public TrieveKnowledgeBaseCreate()
        {
        }
    }
}