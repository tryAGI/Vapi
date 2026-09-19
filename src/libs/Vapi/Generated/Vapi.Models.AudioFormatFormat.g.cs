
#nullable enable

namespace Vapi
{
    /// <summary>
    /// This is the audio format of the call.<br/>
    /// @default 'pcm_s16le'
    /// </summary>
    public enum AudioFormatFormat
    {
        /// <summary>
        ///
        /// </summary>
        Mulaw,
        /// <summary>
        ///
        /// </summary>
        PcmS16le,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AudioFormatFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AudioFormatFormat value)
        {
            return value switch
            {
                AudioFormatFormat.Mulaw => "mulaw",
                AudioFormatFormat.PcmS16le => "pcm_s16le",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AudioFormatFormat? ToEnum(string value)
        {
            return value switch
            {
                "mulaw" => AudioFormatFormat.Mulaw,
                "pcm_s16le" => AudioFormatFormat.PcmS16le,
                _ => null,
            };
        }
    }
}