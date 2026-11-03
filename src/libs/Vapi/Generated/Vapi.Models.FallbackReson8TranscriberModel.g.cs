
#nullable enable

namespace Vapi
{
    /// <summary>
    /// The Reson8 speech-to-text endpoint to use. `turns` is Reson8's turn-detection endpoint.
    /// </summary>
    public enum FallbackReson8TranscriberModel
    {
        /// <summary>
        ///
        /// </summary>
        Turns,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FallbackReson8TranscriberModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FallbackReson8TranscriberModel value)
        {
            return value switch
            {
                FallbackReson8TranscriberModel.Turns => "turns",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FallbackReson8TranscriberModel? ToEnum(string value)
        {
            return value switch
            {
                "turns" => FallbackReson8TranscriberModel.Turns,
                _ => null,
            };
        }
    }
}