
#nullable enable

namespace Vapi
{
    /// <summary>
    /// Speaking style applied via mstts:express-as on every request. Unknown styles are ignored by Azure and fall back to neutral.<br/>
    /// Example: happy
    /// </summary>
    public enum MicrosoftVoiceStyle
    {
        /// <summary>
        /// 
        /// </summary>
        Adventurous,
        /// <summary>
        /// 
        /// </summary>
        Angry,
        /// <summary>
        /// 
        /// </summary>
        Caring,
        /// <summary>
        /// 
        /// </summary>
        Cheerful,
        /// <summary>
        /// 
        /// </summary>
        Confused,
        /// <summary>
        /// 
        /// </summary>
        Curious,
        /// <summary>
        /// 
        /// </summary>
        Determined,
        /// <summary>
        /// 
        /// </summary>
        Disappointed,
        /// <summary>
        /// 
        /// </summary>
        Disgusted,
        /// <summary>
        /// 
        /// </summary>
        Embarrassed,
        /// <summary>
        /// 
        /// </summary>
        Empathy,
        /// <summary>
        /// 
        /// </summary>
        Encouraging,
        /// <summary>
        /// 
        /// </summary>
        Excited,
        /// <summary>
        /// 
        /// </summary>
        Fearful,
        /// <summary>
        /// 
        /// </summary>
        Friendly,
        /// <summary>
        /// 
        /// </summary>
        Happy,
        /// <summary>
        /// 
        /// </summary>
        Hopeful,
        /// <summary>
        /// 
        /// </summary>
        Jealous,
        /// <summary>
        /// 
        /// </summary>
        Joyful,
        /// <summary>
        /// 
        /// </summary>
        Nostalgic,
        /// <summary>
        /// 
        /// </summary>
        Reflective,
        /// <summary>
        /// 
        /// </summary>
        Regretful,
        /// <summary>
        /// 
        /// </summary>
        Relieved,
        /// <summary>
        /// 
        /// </summary>
        Sad,
        /// <summary>
        /// 
        /// </summary>
        Serious,
        /// <summary>
        /// 
        /// </summary>
        Shouting,
        /// <summary>
        /// 
        /// </summary>
        Softvoice,
        /// <summary>
        /// 
        /// </summary>
        Surprised,
        /// <summary>
        /// 
        /// </summary>
        Whispering,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MicrosoftVoiceStyleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MicrosoftVoiceStyle value)
        {
            return value switch
            {
                MicrosoftVoiceStyle.Adventurous => "adventurous",
                MicrosoftVoiceStyle.Angry => "angry",
                MicrosoftVoiceStyle.Caring => "caring",
                MicrosoftVoiceStyle.Cheerful => "cheerful",
                MicrosoftVoiceStyle.Confused => "confused",
                MicrosoftVoiceStyle.Curious => "curious",
                MicrosoftVoiceStyle.Determined => "determined",
                MicrosoftVoiceStyle.Disappointed => "disappointed",
                MicrosoftVoiceStyle.Disgusted => "disgusted",
                MicrosoftVoiceStyle.Embarrassed => "embarrassed",
                MicrosoftVoiceStyle.Empathy => "empathy",
                MicrosoftVoiceStyle.Encouraging => "encouraging",
                MicrosoftVoiceStyle.Excited => "excited",
                MicrosoftVoiceStyle.Fearful => "fearful",
                MicrosoftVoiceStyle.Friendly => "friendly",
                MicrosoftVoiceStyle.Happy => "happy",
                MicrosoftVoiceStyle.Hopeful => "hopeful",
                MicrosoftVoiceStyle.Jealous => "jealous",
                MicrosoftVoiceStyle.Joyful => "joyful",
                MicrosoftVoiceStyle.Nostalgic => "nostalgic",
                MicrosoftVoiceStyle.Reflective => "reflective",
                MicrosoftVoiceStyle.Regretful => "regretful",
                MicrosoftVoiceStyle.Relieved => "relieved",
                MicrosoftVoiceStyle.Sad => "sad",
                MicrosoftVoiceStyle.Serious => "serious",
                MicrosoftVoiceStyle.Shouting => "shouting",
                MicrosoftVoiceStyle.Softvoice => "softvoice",
                MicrosoftVoiceStyle.Surprised => "surprised",
                MicrosoftVoiceStyle.Whispering => "whispering",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MicrosoftVoiceStyle? ToEnum(string value)
        {
            return value switch
            {
                "adventurous" => MicrosoftVoiceStyle.Adventurous,
                "angry" => MicrosoftVoiceStyle.Angry,
                "caring" => MicrosoftVoiceStyle.Caring,
                "cheerful" => MicrosoftVoiceStyle.Cheerful,
                "confused" => MicrosoftVoiceStyle.Confused,
                "curious" => MicrosoftVoiceStyle.Curious,
                "determined" => MicrosoftVoiceStyle.Determined,
                "disappointed" => MicrosoftVoiceStyle.Disappointed,
                "disgusted" => MicrosoftVoiceStyle.Disgusted,
                "embarrassed" => MicrosoftVoiceStyle.Embarrassed,
                "empathy" => MicrosoftVoiceStyle.Empathy,
                "encouraging" => MicrosoftVoiceStyle.Encouraging,
                "excited" => MicrosoftVoiceStyle.Excited,
                "fearful" => MicrosoftVoiceStyle.Fearful,
                "friendly" => MicrosoftVoiceStyle.Friendly,
                "happy" => MicrosoftVoiceStyle.Happy,
                "hopeful" => MicrosoftVoiceStyle.Hopeful,
                "jealous" => MicrosoftVoiceStyle.Jealous,
                "joyful" => MicrosoftVoiceStyle.Joyful,
                "nostalgic" => MicrosoftVoiceStyle.Nostalgic,
                "reflective" => MicrosoftVoiceStyle.Reflective,
                "regretful" => MicrosoftVoiceStyle.Regretful,
                "relieved" => MicrosoftVoiceStyle.Relieved,
                "sad" => MicrosoftVoiceStyle.Sad,
                "serious" => MicrosoftVoiceStyle.Serious,
                "shouting" => MicrosoftVoiceStyle.Shouting,
                "softvoice" => MicrosoftVoiceStyle.Softvoice,
                "surprised" => MicrosoftVoiceStyle.Surprised,
                "whispering" => MicrosoftVoiceStyle.Whispering,
                _ => null,
            };
        }
    }
}