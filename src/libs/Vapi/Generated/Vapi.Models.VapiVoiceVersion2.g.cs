
#nullable enable

namespace Vapi
{
    /// <summary>
    ///
    /// </summary>
    public enum VapiVoiceVersion2
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
    public static class VapiVoiceVersion2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VapiVoiceVersion2 value)
        {
            return value switch
            {
                VapiVoiceVersion2.x1 => "1",
                VapiVoiceVersion2.x2 => "2",
                VapiVoiceVersion2.Latest => "latest",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VapiVoiceVersion2? ToEnum(string value)
        {
            return value switch
            {
                "1" => VapiVoiceVersion2.x1,
                "2" => VapiVoiceVersion2.x2,
                "latest" => VapiVoiceVersion2.Latest,
                _ => null,
            };
        }
    }
}