
#nullable enable

namespace Vapi
{
    /// <summary>
    /// 
    /// </summary>
    public enum MinimaxLLMModelProvider
    {
        /// <summary>
        /// 
        /// </summary>
        Minimax,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MinimaxLLMModelProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MinimaxLLMModelProvider value)
        {
            return value switch
            {
                MinimaxLLMModelProvider.Minimax => "minimax",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MinimaxLLMModelProvider? ToEnum(string value)
        {
            return value switch
            {
                "minimax" => MinimaxLLMModelProvider.Minimax,
                _ => null,
            };
        }
    }
}