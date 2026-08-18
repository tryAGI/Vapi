
#nullable enable

namespace Vapi
{
    /// <summary>
    /// A Vapi-hosted knowledge base retrieval tool.
    /// </summary>
    public enum UpdateKnowledgeBaseToolDTOType
    {
        /// <summary>
        /// 
        /// </summary>
        KnowledgeBase,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateKnowledgeBaseToolDTOTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateKnowledgeBaseToolDTOType value)
        {
            return value switch
            {
                UpdateKnowledgeBaseToolDTOType.KnowledgeBase => "knowledgeBase",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateKnowledgeBaseToolDTOType? ToEnum(string value)
        {
            return value switch
            {
                "knowledgeBase" => UpdateKnowledgeBaseToolDTOType.KnowledgeBase,
                _ => null,
            };
        }
    }
}