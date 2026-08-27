
#nullable enable

namespace Vapi
{
    /// <summary>
    ///
    /// </summary>
    public enum KnowledgeBaseV2FileStatus
    {
        /// <summary>
        ///
        /// </summary>
        Failed,
        /// <summary>
        ///
        /// </summary>
        Indexing,
        /// <summary>
        ///
        /// </summary>
        Ready,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class KnowledgeBaseV2FileStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this KnowledgeBaseV2FileStatus value)
        {
            return value switch
            {
                KnowledgeBaseV2FileStatus.Failed => "failed",
                KnowledgeBaseV2FileStatus.Indexing => "indexing",
                KnowledgeBaseV2FileStatus.Ready => "ready",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static KnowledgeBaseV2FileStatus? ToEnum(string value)
        {
            return value switch
            {
                "failed" => KnowledgeBaseV2FileStatus.Failed,
                "indexing" => KnowledgeBaseV2FileStatus.Indexing,
                "ready" => KnowledgeBaseV2FileStatus.Ready,
                _ => null,
            };
        }
    }
}