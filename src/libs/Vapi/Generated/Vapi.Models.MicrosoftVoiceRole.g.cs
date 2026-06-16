
#nullable enable

namespace Vapi
{
    /// <summary>
    /// Role-play (age/gender imitation). Requires `style` to be set; ignored otherwise.<br/>
    /// Example: YoungAdultFemale
    /// </summary>
    public enum MicrosoftVoiceRole
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
    public static class MicrosoftVoiceRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MicrosoftVoiceRole value)
        {
            return value switch
            {
                MicrosoftVoiceRole.Boy => "Boy",
                MicrosoftVoiceRole.Girl => "Girl",
                MicrosoftVoiceRole.OlderAdultFemale => "OlderAdultFemale",
                MicrosoftVoiceRole.OlderAdultMale => "OlderAdultMale",
                MicrosoftVoiceRole.SeniorFemale => "SeniorFemale",
                MicrosoftVoiceRole.SeniorMale => "SeniorMale",
                MicrosoftVoiceRole.YoungAdultFemale => "YoungAdultFemale",
                MicrosoftVoiceRole.YoungAdultMale => "YoungAdultMale",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MicrosoftVoiceRole? ToEnum(string value)
        {
            return value switch
            {
                "Boy" => MicrosoftVoiceRole.Boy,
                "Girl" => MicrosoftVoiceRole.Girl,
                "OlderAdultFemale" => MicrosoftVoiceRole.OlderAdultFemale,
                "OlderAdultMale" => MicrosoftVoiceRole.OlderAdultMale,
                "SeniorFemale" => MicrosoftVoiceRole.SeniorFemale,
                "SeniorMale" => MicrosoftVoiceRole.SeniorMale,
                "YoungAdultFemale" => MicrosoftVoiceRole.YoungAdultFemale,
                "YoungAdultMale" => MicrosoftVoiceRole.YoungAdultMale,
                _ => null,
            };
        }
    }
}