
#nullable enable

namespace Vapi
{
    /// <summary>
    /// This is the name of the model. Ex. cognitivecomputations/dolphin-mixtral-8x7b
    /// </summary>
    public enum MinimaxLLMModelModel
    {
        /// <summary>
        /// 
        /// </summary>
        MiniMaxM27,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MinimaxLLMModelModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MinimaxLLMModelModel value)
        {
            return value switch
            {
                MinimaxLLMModelModel.MiniMaxM27 => "MiniMax-M2.7",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MinimaxLLMModelModel? ToEnum(string value)
        {
            return value switch
            {
                "MiniMax-M2.7" => MinimaxLLMModelModel.MiniMaxM27,
                _ => null,
            };
        }
    }
}