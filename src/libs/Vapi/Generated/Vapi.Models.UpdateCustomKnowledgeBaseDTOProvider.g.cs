
#nullable enable

namespace Vapi
{
    /// <summary>
    /// This knowledge base is bring your own knowledge base implementation.
    /// </summary>
    public enum UpdateCustomKnowledgeBaseDTOProvider
    {
        /// <summary>
        ///
        /// </summary>
        CustomKnowledgeBase,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateCustomKnowledgeBaseDTOProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateCustomKnowledgeBaseDTOProvider value)
        {
            return value switch
            {
                UpdateCustomKnowledgeBaseDTOProvider.CustomKnowledgeBase => "custom-knowledge-base",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateCustomKnowledgeBaseDTOProvider? ToEnum(string value)
        {
            return value switch
            {
                "custom-knowledge-base" => UpdateCustomKnowledgeBaseDTOProvider.CustomKnowledgeBase,
                _ => null,
            };
        }
    }
}