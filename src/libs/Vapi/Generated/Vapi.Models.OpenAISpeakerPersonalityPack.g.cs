
#nullable enable

namespace Vapi
{
    /// <summary>
    ///
    /// </summary>
    public enum OpenAISpeakerPersonalityPack
    {
        /// <summary>
        ///
        /// </summary>
        Bouncy,
        /// <summary>
        ///
        /// </summary>
        EagerListener,
        /// <summary>
        ///
        /// </summary>
        IdleHummer,
        /// <summary>
        ///
        /// </summary>
        Unhurried,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OpenAISpeakerPersonalityPackExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OpenAISpeakerPersonalityPack value)
        {
            return value switch
            {
                OpenAISpeakerPersonalityPack.Bouncy => "bouncy",
                OpenAISpeakerPersonalityPack.EagerListener => "eager-listener",
                OpenAISpeakerPersonalityPack.IdleHummer => "idle-hummer",
                OpenAISpeakerPersonalityPack.Unhurried => "unhurried",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OpenAISpeakerPersonalityPack? ToEnum(string value)
        {
            return value switch
            {
                "bouncy" => OpenAISpeakerPersonalityPack.Bouncy,
                "eager-listener" => OpenAISpeakerPersonalityPack.EagerListener,
                "idle-hummer" => OpenAISpeakerPersonalityPack.IdleHummer,
                "unhurried" => OpenAISpeakerPersonalityPack.Unhurried,
                _ => null,
            };
        }
    }
}