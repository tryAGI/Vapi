
#nullable enable

namespace Vapi
{
    /// <summary>
    /// Built-in voices: eve, ara, rex, sal, leo. Cloned voice IDs are also accepted.<br/>
    /// Example: eve
    /// </summary>
    public enum XaiVoiceVoiceId
    {
        /// <summary>
        /// eve, ara, rex, sal, leo. Cloned voice IDs are also accepted.
        /// </summary>
        Ara,
        /// <summary>
        /// eve, ara, rex, sal, leo. Cloned voice IDs are also accepted.
        /// </summary>
        Eve,
        /// <summary>
        /// eve, ara, rex, sal, leo. Cloned voice IDs are also accepted.
        /// </summary>
        Leo,
        /// <summary>
        /// eve, ara, rex, sal, leo. Cloned voice IDs are also accepted.
        /// </summary>
        Rex,
        /// <summary>
        /// eve, ara, rex, sal, leo. Cloned voice IDs are also accepted.
        /// </summary>
        Sal,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class XaiVoiceVoiceIdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this XaiVoiceVoiceId value)
        {
            return value switch
            {
                XaiVoiceVoiceId.Ara => "ara",
                XaiVoiceVoiceId.Eve => "eve",
                XaiVoiceVoiceId.Leo => "leo",
                XaiVoiceVoiceId.Rex => "rex",
                XaiVoiceVoiceId.Sal => "sal",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static XaiVoiceVoiceId? ToEnum(string value)
        {
            return value switch
            {
                "ara" => XaiVoiceVoiceId.Ara,
                "eve" => XaiVoiceVoiceId.Eve,
                "leo" => XaiVoiceVoiceId.Leo,
                "rex" => XaiVoiceVoiceId.Rex,
                "sal" => XaiVoiceVoiceId.Sal,
                _ => null,
            };
        }
    }
}