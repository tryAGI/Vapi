
#nullable enable

namespace Vapi
{
    /// <summary>
    /// Built-in voices: eve, ara, rex, sal, leo. Cloned voice IDs are also accepted.<br/>
    /// Example: eve
    /// </summary>
    public enum FallbackXaiVoiceVoiceId
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
    public static class FallbackXaiVoiceVoiceIdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FallbackXaiVoiceVoiceId value)
        {
            return value switch
            {
                FallbackXaiVoiceVoiceId.Ara => "ara",
                FallbackXaiVoiceVoiceId.Eve => "eve",
                FallbackXaiVoiceVoiceId.Leo => "leo",
                FallbackXaiVoiceVoiceId.Rex => "rex",
                FallbackXaiVoiceVoiceId.Sal => "sal",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FallbackXaiVoiceVoiceId? ToEnum(string value)
        {
            return value switch
            {
                "ara" => FallbackXaiVoiceVoiceId.Ara,
                "eve" => FallbackXaiVoiceVoiceId.Eve,
                "leo" => FallbackXaiVoiceVoiceId.Leo,
                "rex" => FallbackXaiVoiceVoiceId.Rex,
                "sal" => FallbackXaiVoiceVoiceId.Sal,
                _ => null,
            };
        }
    }
}