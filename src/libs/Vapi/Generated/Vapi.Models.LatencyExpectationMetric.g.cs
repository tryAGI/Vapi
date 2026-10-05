
#nullable enable

namespace Vapi
{
    /// <summary>
    /// This is the latency component to measure.<br/>
    /// - turn: total time from the end of user speech to the start of assistant speech<br/>
    /// - model: LLM time to first token<br/>
    /// - voice: TTS time to first audio<br/>
    /// Example: turn
    /// </summary>
    public enum LatencyExpectationMetric
    {
        /// <summary>
        /// LLM time to first token
        /// </summary>
        Model,
        /// <summary>
        /// total time from the end of user speech to the start of assistant speech
        /// </summary>
        Turn,
        /// <summary>
        /// TTS time to first audio
        /// </summary>
        Voice,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LatencyExpectationMetricExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LatencyExpectationMetric value)
        {
            return value switch
            {
                LatencyExpectationMetric.Model => "model",
                LatencyExpectationMetric.Turn => "turn",
                LatencyExpectationMetric.Voice => "voice",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LatencyExpectationMetric? ToEnum(string value)
        {
            return value switch
            {
                "model" => LatencyExpectationMetric.Model,
                "turn" => LatencyExpectationMetric.Turn,
                "voice" => LatencyExpectationMetric.Voice,
                _ => null,
            };
        }
    }
}