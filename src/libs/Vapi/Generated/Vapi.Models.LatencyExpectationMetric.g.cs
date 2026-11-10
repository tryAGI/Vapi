
#nullable enable

namespace Vapi
{
    /// <summary>
    /// This is the latency component to measure.<br/>
    /// - turn: total time from the end of user speech to the start of assistant speech<br/>
    /// - model: LLM time to first token<br/>
    /// - voice: TTS time to first audio<br/>
    /// - transcriber: time from the end of user speech to the transcript's words being known<br/>
    /// - endpointing: time from the transcript's words being known to deciding the user finished their turn<br/>
    /// Turns where a component was not measured are left out of that metric.<br/>
    /// Example: turn
    /// </summary>
    public enum LatencyExpectationMetric
    {
        /// <summary>
        /// time from the transcript's words being known to deciding the user finished their turn
        /// </summary>
        Endpointing,
        /// <summary>
        /// LLM time to first token
        /// </summary>
        Model,
        /// <summary>
        /// time from the end of user speech to the transcript's words being known
        /// </summary>
        Transcriber,
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
                LatencyExpectationMetric.Endpointing => "endpointing",
                LatencyExpectationMetric.Model => "model",
                LatencyExpectationMetric.Transcriber => "transcriber",
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
                "endpointing" => LatencyExpectationMetric.Endpointing,
                "model" => LatencyExpectationMetric.Model,
                "transcriber" => LatencyExpectationMetric.Transcriber,
                "turn" => LatencyExpectationMetric.Turn,
                "voice" => LatencyExpectationMetric.Voice,
                _ => null,
            };
        }
    }
}