
#nullable enable

namespace Vapi
{
    /// <summary>
    /// Role-play (age/gender imitation). Requires `style` to be set; ignored otherwise.<br/>
    /// Example: YoungAdultFemale
    /// </summary>
    public enum FallbackMicrosoftVoiceRole
    {
        /// <summary>
        ///
        /// </summary>
        Boy,
        /// <summary>
        ///
        /// </summary>
        Girl,
        /// <summary>
        ///
        /// </summary>
        OlderAdultFemale,
        /// <summary>
        ///
        /// </summary>
        OlderAdultMale,
        /// <summary>
        ///
        /// </summary>
        SeniorFemale,
        /// <summary>
        ///
        /// </summary>
        SeniorMale,
        /// <summary>
        ///
        /// </summary>
        YoungAdultFemale,
        /// <summary>
        ///
        /// </summary>
        YoungAdultMale,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FallbackMicrosoftVoiceRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FallbackMicrosoftVoiceRole value)
        {
            return value switch
            {
                FallbackMicrosoftVoiceRole.Boy => "Boy",
                FallbackMicrosoftVoiceRole.Girl => "Girl",
                FallbackMicrosoftVoiceRole.OlderAdultFemale => "OlderAdultFemale",
                FallbackMicrosoftVoiceRole.OlderAdultMale => "OlderAdultMale",
                FallbackMicrosoftVoiceRole.SeniorFemale => "SeniorFemale",
                FallbackMicrosoftVoiceRole.SeniorMale => "SeniorMale",
                FallbackMicrosoftVoiceRole.YoungAdultFemale => "YoungAdultFemale",
                FallbackMicrosoftVoiceRole.YoungAdultMale => "YoungAdultMale",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FallbackMicrosoftVoiceRole? ToEnum(string value)
        {
            return value switch
            {
                "Boy" => FallbackMicrosoftVoiceRole.Boy,
                "Girl" => FallbackMicrosoftVoiceRole.Girl,
                "OlderAdultFemale" => FallbackMicrosoftVoiceRole.OlderAdultFemale,
                "OlderAdultMale" => FallbackMicrosoftVoiceRole.OlderAdultMale,
                "SeniorFemale" => FallbackMicrosoftVoiceRole.SeniorFemale,
                "SeniorMale" => FallbackMicrosoftVoiceRole.SeniorMale,
                "YoungAdultFemale" => FallbackMicrosoftVoiceRole.YoungAdultFemale,
                "YoungAdultMale" => FallbackMicrosoftVoiceRole.YoungAdultMale,
                _ => null,
            };
        }
    }
}