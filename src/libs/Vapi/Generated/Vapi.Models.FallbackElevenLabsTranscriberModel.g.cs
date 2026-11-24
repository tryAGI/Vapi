
#nullable enable

namespace Vapi
{
    /// <summary>
    ///
    /// </summary>
    public enum FallbackElevenLabsTranscriberModel
    {
        /// <summary>
        ///
        /// </summary>
        ScribeV1,
        /// <summary>
        ///
        /// </summary>
        ScribeV2,
        /// <summary>
        ///
        /// </summary>
        ScribeV2Realtime,
        /// <summary>
        ///
        /// </summary>
        ScribeV3Live,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FallbackElevenLabsTranscriberModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FallbackElevenLabsTranscriberModel value)
        {
            return value switch
            {
                FallbackElevenLabsTranscriberModel.ScribeV1 => "scribe_v1",
                FallbackElevenLabsTranscriberModel.ScribeV2 => "scribe_v2",
                FallbackElevenLabsTranscriberModel.ScribeV2Realtime => "scribe_v2_realtime",
                FallbackElevenLabsTranscriberModel.ScribeV3Live => "scribe_v3_live",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FallbackElevenLabsTranscriberModel? ToEnum(string value)
        {
            return value switch
            {
                "scribe_v1" => FallbackElevenLabsTranscriberModel.ScribeV1,
                "scribe_v2" => FallbackElevenLabsTranscriberModel.ScribeV2,
                "scribe_v2_realtime" => FallbackElevenLabsTranscriberModel.ScribeV2Realtime,
                "scribe_v3_live" => FallbackElevenLabsTranscriberModel.ScribeV3Live,
                _ => null,
            };
        }
    }
}