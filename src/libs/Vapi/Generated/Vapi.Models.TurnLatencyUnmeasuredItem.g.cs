
#nullable enable

namespace Vapi
{
    /// <summary>
    ///
    /// </summary>
    public enum TurnLatencyUnmeasuredItem
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
        Voice,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TurnLatencyUnmeasuredItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TurnLatencyUnmeasuredItem value)
        {
            return value switch
            {
                TurnLatencyUnmeasuredItem.Endpointing => "endpointing",
                TurnLatencyUnmeasuredItem.Model => "model",
                TurnLatencyUnmeasuredItem.Transcriber => "transcriber",
                TurnLatencyUnmeasuredItem.Voice => "voice",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TurnLatencyUnmeasuredItem? ToEnum(string value)
        {
            return value switch
            {
                "endpointing" => TurnLatencyUnmeasuredItem.Endpointing,
                "model" => TurnLatencyUnmeasuredItem.Model,
                "transcriber" => TurnLatencyUnmeasuredItem.Transcriber,
                "voice" => TurnLatencyUnmeasuredItem.Voice,
                _ => null,
            };
        }
    }
}