
#nullable enable

namespace Vapi
{
    /// <summary>
    /// The delegated reasoning model. Omit to use GPT-5.6 Terra.<br/>
    /// Default Value: gpt-5.6-terra
    /// </summary>
    public enum OpenAIReasonerModel
    {
        /// <summary>
        ///
        /// </summary>
        Gpt56Luna,
        /// <summary>
        ///
        /// </summary>
        Gpt56Sol,
        /// <summary>
        ///
        /// </summary>
        Gpt56Terra,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OpenAIReasonerModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OpenAIReasonerModel value)
        {
            return value switch
            {
                OpenAIReasonerModel.Gpt56Luna => "gpt-5.6-luna",
                OpenAIReasonerModel.Gpt56Sol => "gpt-5.6-sol",
                OpenAIReasonerModel.Gpt56Terra => "gpt-5.6-terra",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OpenAIReasonerModel? ToEnum(string value)
        {
            return value switch
            {
                "gpt-5.6-luna" => OpenAIReasonerModel.Gpt56Luna,
                "gpt-5.6-sol" => OpenAIReasonerModel.Gpt56Sol,
                "gpt-5.6-terra" => OpenAIReasonerModel.Gpt56Terra,
                _ => null,
            };
        }
    }
}