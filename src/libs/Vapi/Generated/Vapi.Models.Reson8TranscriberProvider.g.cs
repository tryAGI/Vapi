
#nullable enable

namespace Vapi
{
    /// <summary>
    ///
    /// </summary>
    public enum Reson8TranscriberProvider
    {
        /// <summary>
        ///
        /// </summary>
        Reson8,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class Reson8TranscriberProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this Reson8TranscriberProvider value)
        {
            return value switch
            {
                Reson8TranscriberProvider.Reson8 => "reson8",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static Reson8TranscriberProvider? ToEnum(string value)
        {
            return value switch
            {
                "reson8" => Reson8TranscriberProvider.Reson8,
                _ => null,
            };
        }
    }
}