
#nullable enable

namespace Vapi
{
    /// <summary>
    /// This is the OpenAI service tier to request.<br/>
    /// - `fast`: requests Fast mode, which gives faster responses at a higher per-token rate. How much faster depends on the model.<br/>
    /// - `priority`: the old name for `fast`, accepted and billed the same.<br/>
    /// - `default`: standard processing.<br/>
    /// - `auto`: the default when unset. On Vapi's OpenAI keys this is standard processing; on your own OpenAI key, OpenAI applies your project's default tier.<br/>
    /// OpenAI sets Fast mode rates per model, and they are not a fixed multiple of the standard rates. Vapi bills them only when OpenAI reports that it served the request in Fast mode. Otherwise the request is billed at standard rates, for example when Fast mode isn't available for the model on Vapi, OpenAI downgrades the request, or the request runs on Azure OpenAI.<br/>
    /// Supported models and their Fast mode rates: https://docs.vapi.ai/providers/model/openai
    /// </summary>
    public enum OpenAIModelServiceTier
    {
        /// <summary>
        /// the default when unset. On Vapi's OpenAI keys this is standard processing; on your own OpenAI key, OpenAI applies your project's default tier.
        /// </summary>
        Auto,
        /// <summary>
        /// standard processing.
        /// </summary>
        Default,
        /// <summary>
        /// requests Fast mode, which gives faster responses at a higher per-token rate. How much faster depends on the model.
        /// </summary>
        Fast,
        /// <summary>
        /// the old name for `fast`, accepted and billed the same.
        /// </summary>
        Priority,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OpenAIModelServiceTierExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OpenAIModelServiceTier value)
        {
            return value switch
            {
                OpenAIModelServiceTier.Auto => "auto",
                OpenAIModelServiceTier.Default => "default",
                OpenAIModelServiceTier.Fast => "fast",
                OpenAIModelServiceTier.Priority => "priority",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OpenAIModelServiceTier? ToEnum(string value)
        {
            return value switch
            {
                "auto" => OpenAIModelServiceTier.Auto,
                "default" => OpenAIModelServiceTier.Default,
                "fast" => OpenAIModelServiceTier.Fast,
                "priority" => OpenAIModelServiceTier.Priority,
                _ => null,
            };
        }
    }
}