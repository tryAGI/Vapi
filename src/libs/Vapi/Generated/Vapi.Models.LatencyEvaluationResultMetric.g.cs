
#nullable enable

namespace Vapi
{
    /// <summary>
    /// This is the latency component that was measured.
    /// </summary>
    public enum LatencyEvaluationResultMetric
    {
        /// <summary>
        ///
        /// </summary>
        Endpointing,
        /// <summary>
        ///
        /// </summary>
        Model,
        /// <summary>
        ///
        /// </summary>
        Transcriber,
        /// <summary>
        ///
        /// </summary>
        Turn,
        /// <summary>
        ///
        /// </summary>
        Voice,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LatencyEvaluationResultMetricExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LatencyEvaluationResultMetric value)
        {
            return value switch
            {
                LatencyEvaluationResultMetric.Endpointing => "endpointing",
                LatencyEvaluationResultMetric.Model => "model",
                LatencyEvaluationResultMetric.Transcriber => "transcriber",
                LatencyEvaluationResultMetric.Turn => "turn",
                LatencyEvaluationResultMetric.Voice => "voice",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LatencyEvaluationResultMetric? ToEnum(string value)
        {
            return value switch
            {
                "endpointing" => LatencyEvaluationResultMetric.Endpointing,
                "model" => LatencyEvaluationResultMetric.Model,
                "transcriber" => LatencyEvaluationResultMetric.Transcriber,
                "turn" => LatencyEvaluationResultMetric.Turn,
                "voice" => LatencyEvaluationResultMetric.Voice,
                _ => null,
            };
        }
    }
}