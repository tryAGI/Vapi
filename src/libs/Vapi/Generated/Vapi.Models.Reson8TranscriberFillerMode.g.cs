
#nullable enable

namespace Vapi
{
    /// <summary>
    /// How Reson8 renders filler words in transcripts. Provider default `natural`.
    /// </summary>
    public enum Reson8TranscriberFillerMode
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
    public static class Reson8TranscriberFillerModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this Reson8TranscriberFillerMode value)
        {
            return value switch
            {
                Reson8TranscriberFillerMode.Clean => "clean",
                Reson8TranscriberFillerMode.Natural => "natural",
                Reson8TranscriberFillerMode.Verbatim => "verbatim",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static Reson8TranscriberFillerMode? ToEnum(string value)
        {
            return value switch
            {
                "clean" => Reson8TranscriberFillerMode.Clean,
                "natural" => Reson8TranscriberFillerMode.Natural,
                "verbatim" => Reson8TranscriberFillerMode.Verbatim,
                _ => null,
            };
        }
    }
}