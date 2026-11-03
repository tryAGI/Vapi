
#nullable enable

namespace Vapi
{
    /// <summary>
    /// How Reson8 renders filler words in transcripts. Provider default `natural`.
    /// </summary>
    public enum FallbackReson8TranscriberFillerMode
    {
        /// <summary>
        ///
        /// </summary>
        Clean,
        /// <summary>
        ///
        /// </summary>
        Natural,
        /// <summary>
        ///
        /// </summary>
        Verbatim,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FallbackReson8TranscriberFillerModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FallbackReson8TranscriberFillerMode value)
        {
            return value switch
            {
                FallbackReson8TranscriberFillerMode.Clean => "clean",
                FallbackReson8TranscriberFillerMode.Natural => "natural",
                FallbackReson8TranscriberFillerMode.Verbatim => "verbatim",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FallbackReson8TranscriberFillerMode? ToEnum(string value)
        {
            return value switch
            {
                "clean" => FallbackReson8TranscriberFillerMode.Clean,
                "natural" => FallbackReson8TranscriberFillerMode.Natural,
                "verbatim" => FallbackReson8TranscriberFillerMode.Verbatim,
                _ => null,
            };
        }
    }
}