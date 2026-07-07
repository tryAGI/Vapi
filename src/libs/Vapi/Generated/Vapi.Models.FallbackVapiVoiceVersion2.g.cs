
#nullable enable

namespace Vapi
{
    /// <summary>
    /// 
    /// </summary>
    public enum FallbackVapiVoiceVersion2
    {
        /// <summary>
        /// 
        /// </summary>
        x1,
        /// <summary>
        /// 
        /// </summary>
        x2,
        /// <summary>
        /// 
        /// </summary>
        Latest,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FallbackVapiVoiceVersion2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FallbackVapiVoiceVersion2 value)
        {
            return value switch
            {
                FallbackVapiVoiceVersion2.x1 => "1",
                FallbackVapiVoiceVersion2.x2 => "2",
                FallbackVapiVoiceVersion2.Latest => "latest",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FallbackVapiVoiceVersion2? ToEnum(string value)
        {
            return value switch
            {
                "1" => FallbackVapiVoiceVersion2.x1,
                "2" => FallbackVapiVoiceVersion2.x2,
                "latest" => FallbackVapiVoiceVersion2.Latest,
                _ => null,
            };
        }
    }
}