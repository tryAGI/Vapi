
#nullable enable

namespace Vapi
{
    /// <summary>
    /// A Vapi-hosted knowledge base retrieval tool.
    /// </summary>
    public enum KnowledgeBaseToolType
    {
        /// <summary>
        ///
        /// </summary>
        KnowledgeBase,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class KnowledgeBaseToolTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this KnowledgeBaseToolType value)
        {
            return value switch
            {
                KnowledgeBaseToolType.KnowledgeBase => "knowledgeBase",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static KnowledgeBaseToolType? ToEnum(string value)
        {
            return value switch
            {
                "knowledgeBase" => KnowledgeBaseToolType.KnowledgeBase,
                _ => null,
            };
        }
    }
}