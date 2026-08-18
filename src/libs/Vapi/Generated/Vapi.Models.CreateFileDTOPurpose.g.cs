
#nullable enable

namespace Vapi
{
    /// <summary>
    /// Optional product flow that owns the uploaded file.
    /// </summary>
    public enum CreateFileDTOPurpose
    {
        /// <summary>
        /// 
        /// </summary>
        Assistant,
        /// <summary>
        /// 
        /// </summary>
        ComposerAttachment,
        /// <summary>
        /// 
        /// </summary>
        KnowledgeBaseV2,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateFileDTOPurposeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateFileDTOPurpose value)
        {
            return value switch
            {
                CreateFileDTOPurpose.Assistant => "assistant",
                CreateFileDTOPurpose.ComposerAttachment => "composer-attachment",
                CreateFileDTOPurpose.KnowledgeBaseV2 => "knowledge-base-v2",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateFileDTOPurpose? ToEnum(string value)
        {
            return value switch
            {
                "assistant" => CreateFileDTOPurpose.Assistant,
                "composer-attachment" => CreateFileDTOPurpose.ComposerAttachment,
                "knowledge-base-v2" => CreateFileDTOPurpose.KnowledgeBaseV2,
                _ => null,
            };
        }
    }
}