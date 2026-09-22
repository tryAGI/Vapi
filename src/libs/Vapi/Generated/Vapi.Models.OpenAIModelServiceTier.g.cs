
#nullable enable

namespace Vapi
{
    /// <summary>
    /// This is the OpenAI service tier used for chat completions requests.<br/>
    /// - `fast`: OpenAI's fast processing tier (renamed from `priority` on 2026-07-30; both values are accepted and billed identically) — up to ~2.5x faster inference at 2x the standard token rates. OpenAI may silently downgrade a fast request to standard processing under ramp limits; when that happens the response reports the served tier and the request is billed at standard rates.<br/>
    /// - `auto`: uses the service tier configured for the OpenAI project.<br/>
    /// - `default`: standard processing and billing.<br/>
    /// Only applies to models that support fast processing: gpt-5.6-sol, gpt-5.6-terra, gpt-5.6-luna, gpt-5.5. Ignored for other models.<br/>
    /// @default undefined (uses the service tier configured for the OpenAI project)
    /// </summary>
    public enum OpenAIModelServiceTier
    {
        /// <summary>
        /// uses the service tier configured for the OpenAI project.
        /// </summary>
        Auto,
        /// <summary>
        /// standard processing and billing.
        /// </summary>
        Default,
        /// <summary>
        /// OpenAI's fast processing tier (renamed from `priority` on 2026-07-30; both values are accepted and billed identically) — up to ~2.5x faster inference at 2x the standard token rates. OpenAI may silently downgrade a fast request to standard processing under ramp limits; when that happens the response reports the served tier and the request is billed at standard rates.
        /// </summary>
        Fast,
        /// <summary>
        /// OpenAI's fast processing tier (renamed from `priority` on 2026-07-30; both values are accepted and billed identically) — up to ~2.5x faster inference at 2x the standard token rates. OpenAI may silently downgrade a fast request to standard processing under ramp limits; when that happens the response reports the served tier and the request is billed at standard rates.
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