
#nullable enable

namespace Vapi
{
    /// <summary>
    /// This is the transcription mode used by the `universal-3-5-pro` speech model. Only applies to the `universal-3-5-pro` speech model.<br/>
    /// @default 'balanced'
    /// </summary>
    public enum FallbackAssemblyAITranscriberMode
    {
        /// <summary>
        /// 
        /// </summary>
        Balanced,
        /// <summary>
        /// 
        /// </summary>
        MaxAccuracy,
        /// <summary>
        /// 
        /// </summary>
        MinLatency,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FallbackAssemblyAITranscriberModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FallbackAssemblyAITranscriberMode value)
        {
            return value switch
            {
                FallbackAssemblyAITranscriberMode.Balanced => "balanced",
                FallbackAssemblyAITranscriberMode.MaxAccuracy => "max_accuracy",
                FallbackAssemblyAITranscriberMode.MinLatency => "min_latency",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FallbackAssemblyAITranscriberMode? ToEnum(string value)
        {
            return value switch
            {
                "balanced" => FallbackAssemblyAITranscriberMode.Balanced,
                "max_accuracy" => FallbackAssemblyAITranscriberMode.MaxAccuracy,
                "min_latency" => FallbackAssemblyAITranscriberMode.MinLatency,
                _ => null,
            };
        }
    }
}