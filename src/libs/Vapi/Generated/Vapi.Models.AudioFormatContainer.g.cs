
#nullable enable

namespace Vapi
{
    /// <summary>
    /// This is the container format of the call.<br/>
    /// @default 'raw'
    /// </summary>
    public enum AudioFormatContainer
    {
        /// <summary>
        /// 
        /// </summary>
        Raw,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AudioFormatContainerExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AudioFormatContainer value)
        {
            return value switch
            {
                AudioFormatContainer.Raw => "raw",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AudioFormatContainer? ToEnum(string value)
        {
            return value switch
            {
                "raw" => AudioFormatContainer.Raw,
                _ => null,
            };
        }
    }
}