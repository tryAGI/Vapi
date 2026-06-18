
#nullable enable

namespace Vapi
{
    /// <summary>
    /// Speaking style applied via mstts:express-as on every request. Unknown styles are ignored by Azure and fall back to neutral.<br/>
    /// Example: happy
    /// </summary>
    public enum FallbackMicrosoftVoiceStyle
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
    public static class FallbackMicrosoftVoiceStyleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FallbackMicrosoftVoiceStyle value)
        {
            return value switch
            {
                FallbackMicrosoftVoiceStyle.Adventurous => "adventurous",
                FallbackMicrosoftVoiceStyle.Angry => "angry",
                FallbackMicrosoftVoiceStyle.Caring => "caring",
                FallbackMicrosoftVoiceStyle.Cheerful => "cheerful",
                FallbackMicrosoftVoiceStyle.Confused => "confused",
                FallbackMicrosoftVoiceStyle.Curious => "curious",
                FallbackMicrosoftVoiceStyle.Determined => "determined",
                FallbackMicrosoftVoiceStyle.Disappointed => "disappointed",
                FallbackMicrosoftVoiceStyle.Disgusted => "disgusted",
                FallbackMicrosoftVoiceStyle.Embarrassed => "embarrassed",
                FallbackMicrosoftVoiceStyle.Empathy => "empathy",
                FallbackMicrosoftVoiceStyle.Encouraging => "encouraging",
                FallbackMicrosoftVoiceStyle.Excited => "excited",
                FallbackMicrosoftVoiceStyle.Fearful => "fearful",
                FallbackMicrosoftVoiceStyle.Friendly => "friendly",
                FallbackMicrosoftVoiceStyle.Happy => "happy",
                FallbackMicrosoftVoiceStyle.Hopeful => "hopeful",
                FallbackMicrosoftVoiceStyle.Jealous => "jealous",
                FallbackMicrosoftVoiceStyle.Joyful => "joyful",
                FallbackMicrosoftVoiceStyle.Nostalgic => "nostalgic",
                FallbackMicrosoftVoiceStyle.Reflective => "reflective",
                FallbackMicrosoftVoiceStyle.Regretful => "regretful",
                FallbackMicrosoftVoiceStyle.Relieved => "relieved",
                FallbackMicrosoftVoiceStyle.Sad => "sad",
                FallbackMicrosoftVoiceStyle.Serious => "serious",
                FallbackMicrosoftVoiceStyle.Shouting => "shouting",
                FallbackMicrosoftVoiceStyle.Softvoice => "softvoice",
                FallbackMicrosoftVoiceStyle.Surprised => "surprised",
                FallbackMicrosoftVoiceStyle.Whispering => "whispering",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FallbackMicrosoftVoiceStyle? ToEnum(string value)
        {
            return value switch
            {
                "adventurous" => FallbackMicrosoftVoiceStyle.Adventurous,
                "angry" => FallbackMicrosoftVoiceStyle.Angry,
                "caring" => FallbackMicrosoftVoiceStyle.Caring,
                "cheerful" => FallbackMicrosoftVoiceStyle.Cheerful,
                "confused" => FallbackMicrosoftVoiceStyle.Confused,
                "curious" => FallbackMicrosoftVoiceStyle.Curious,
                "determined" => FallbackMicrosoftVoiceStyle.Determined,
                "disappointed" => FallbackMicrosoftVoiceStyle.Disappointed,
                "disgusted" => FallbackMicrosoftVoiceStyle.Disgusted,
                "embarrassed" => FallbackMicrosoftVoiceStyle.Embarrassed,
                "empathy" => FallbackMicrosoftVoiceStyle.Empathy,
                "encouraging" => FallbackMicrosoftVoiceStyle.Encouraging,
                "excited" => FallbackMicrosoftVoiceStyle.Excited,
                "fearful" => FallbackMicrosoftVoiceStyle.Fearful,
                "friendly" => FallbackMicrosoftVoiceStyle.Friendly,
                "happy" => FallbackMicrosoftVoiceStyle.Happy,
                "hopeful" => FallbackMicrosoftVoiceStyle.Hopeful,
                "jealous" => FallbackMicrosoftVoiceStyle.Jealous,
                "joyful" => FallbackMicrosoftVoiceStyle.Joyful,
                "nostalgic" => FallbackMicrosoftVoiceStyle.Nostalgic,
                "reflective" => FallbackMicrosoftVoiceStyle.Reflective,
                "regretful" => FallbackMicrosoftVoiceStyle.Regretful,
                "relieved" => FallbackMicrosoftVoiceStyle.Relieved,
                "sad" => FallbackMicrosoftVoiceStyle.Sad,
                "serious" => FallbackMicrosoftVoiceStyle.Serious,
                "shouting" => FallbackMicrosoftVoiceStyle.Shouting,
                "softvoice" => FallbackMicrosoftVoiceStyle.Softvoice,
                "surprised" => FallbackMicrosoftVoiceStyle.Surprised,
                "whispering" => FallbackMicrosoftVoiceStyle.Whispering,
                _ => null,
            };
        }
    }
}