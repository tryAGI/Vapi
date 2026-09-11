
#nullable enable

namespace Vapi
{
    /// <summary>
    /// The reasoner uses OpenAI. Omit to use OpenAI.<br/>
    /// Default Value: openai
    /// </summary>
    public enum OpenAIReasonerProvider
    {
        /// <summary>
        ///
        /// </summary>
        Openai,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OpenAIReasonerProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OpenAIReasonerProvider value)
        {
            return value switch
            {
                OpenAIReasonerProvider.Openai => "openai",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OpenAIReasonerProvider? ToEnum(string value)
        {
            return value switch
            {
                "openai" => OpenAIReasonerProvider.Openai,
                _ => null,
            };
        }
    }
}