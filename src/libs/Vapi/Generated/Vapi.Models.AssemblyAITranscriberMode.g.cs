
#nullable enable

namespace Vapi
{
    /// <summary>
    /// This is the transcription mode used by the `universal-3-5-pro` speech model. Only applies to the `universal-3-5-pro` speech model.<br/>
    /// @default 'balanced'
    /// </summary>
    public enum AssemblyAITranscriberMode
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
    public static class AssemblyAITranscriberModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AssemblyAITranscriberMode value)
        {
            return value switch
            {
                AssemblyAITranscriberMode.Balanced => "balanced",
                AssemblyAITranscriberMode.MaxAccuracy => "max_accuracy",
                AssemblyAITranscriberMode.MinLatency => "min_latency",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AssemblyAITranscriberMode? ToEnum(string value)
        {
            return value switch
            {
                "balanced" => AssemblyAITranscriberMode.Balanced,
                "max_accuracy" => AssemblyAITranscriberMode.MaxAccuracy,
                "min_latency" => AssemblyAITranscriberMode.MinLatency,
                _ => null,
            };
        }
    }
}