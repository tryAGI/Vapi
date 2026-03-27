
#nullable enable

namespace Vapi
{
    /// <summary>
    /// 
    /// </summary>
    public enum LangfuseObservabilityPlanProvider
    {
        /// <summary>
        /// 
        /// </summary>
        Langfuse,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LangfuseObservabilityPlanProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LangfuseObservabilityPlanProvider value)
        {
            return value switch
            {
                LangfuseObservabilityPlanProvider.Langfuse => "langfuse",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LangfuseObservabilityPlanProvider? ToEnum(string value)
        {
            return value switch
            {
                "langfuse" => LangfuseObservabilityPlanProvider.Langfuse,
                _ => null,
            };
        }
    }
}