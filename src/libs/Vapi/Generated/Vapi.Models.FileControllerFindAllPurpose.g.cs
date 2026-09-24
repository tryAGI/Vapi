
#nullable enable

namespace Vapi
{
    /// <summary>
    ///
    /// </summary>
    public enum FileControllerFindAllPurpose
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
    public static class FileControllerFindAllPurposeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FileControllerFindAllPurpose value)
        {
            return value switch
            {
                FileControllerFindAllPurpose.Assistant => "assistant",
                FileControllerFindAllPurpose.ComposerAttachment => "composer-attachment",
                FileControllerFindAllPurpose.KnowledgeBaseV2 => "knowledge-base-v2",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FileControllerFindAllPurpose? ToEnum(string value)
        {
            return value switch
            {
                "assistant" => FileControllerFindAllPurpose.Assistant,
                "composer-attachment" => FileControllerFindAllPurpose.ComposerAttachment,
                "knowledge-base-v2" => FileControllerFindAllPurpose.KnowledgeBaseV2,
                _ => null,
            };
        }
    }
}