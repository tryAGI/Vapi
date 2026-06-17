
#nullable enable

namespace Vapi
{
    /// <summary>
    /// Speaking style applied via mstts:express-as on every request. Unknown styles are ignored by Azure and fall back to neutral.<br/>
    /// Example: chat
    /// </summary>
    public enum FallbackMicrosoftVoiceStyle
    {
        /// <summary>
        /// 
        /// </summary>
        AdvertisementUpbeat,
        /// <summary>
        /// 
        /// </summary>
        Affectionate,
        /// <summary>
        /// 
        /// </summary>
        Angry,
        /// <summary>
        /// 
        /// </summary>
        Assistant,
        /// <summary>
        /// 
        /// </summary>
        Calm,
        /// <summary>
        /// 
        /// </summary>
        Chat,
        /// <summary>
        /// 
        /// </summary>
        Cheerful,
        /// <summary>
        /// 
        /// </summary>
        Customerservice,
        /// <summary>
        /// 
        /// </summary>
        Depressed,
        /// <summary>
        /// 
        /// </summary>
        Disgruntled,
        /// <summary>
        /// 
        /// </summary>
        DocumentaryNarration,
        /// <summary>
        /// 
        /// </summary>
        Embarrassed,
        /// <summary>
        /// 
        /// </summary>
        Empathetic,
        /// <summary>
        /// 
        /// </summary>
        Envious,
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
        Gentle,
        /// <summary>
        /// 
        /// </summary>
        Hopeful,
        /// <summary>
        /// 
        /// </summary>
        Lyrical,
        /// <summary>
        /// 
        /// </summary>
        NarrationProfessional,
        /// <summary>
        /// 
        /// </summary>
        NarrationRelaxed,
        /// <summary>
        /// 
        /// </summary>
        Newscast,
        /// <summary>
        /// 
        /// </summary>
        NewscastCasual,
        /// <summary>
        /// 
        /// </summary>
        NewscastFormal,
        /// <summary>
        /// 
        /// </summary>
        PoetryReading,
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
        SportsCommentary,
        /// <summary>
        /// 
        /// </summary>
        SportsCommentaryExcited,
        /// <summary>
        /// 
        /// </summary>
        Terrified,
        /// <summary>
        /// 
        /// </summary>
        Unfriendly,
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
                FallbackMicrosoftVoiceStyle.AdvertisementUpbeat => "advertisement_upbeat",
                FallbackMicrosoftVoiceStyle.Affectionate => "affectionate",
                FallbackMicrosoftVoiceStyle.Angry => "angry",
                FallbackMicrosoftVoiceStyle.Assistant => "assistant",
                FallbackMicrosoftVoiceStyle.Calm => "calm",
                FallbackMicrosoftVoiceStyle.Chat => "chat",
                FallbackMicrosoftVoiceStyle.Cheerful => "cheerful",
                FallbackMicrosoftVoiceStyle.Customerservice => "customerservice",
                FallbackMicrosoftVoiceStyle.Depressed => "depressed",
                FallbackMicrosoftVoiceStyle.Disgruntled => "disgruntled",
                FallbackMicrosoftVoiceStyle.DocumentaryNarration => "documentary-narration",
                FallbackMicrosoftVoiceStyle.Embarrassed => "embarrassed",
                FallbackMicrosoftVoiceStyle.Empathetic => "empathetic",
                FallbackMicrosoftVoiceStyle.Envious => "envious",
                FallbackMicrosoftVoiceStyle.Excited => "excited",
                FallbackMicrosoftVoiceStyle.Fearful => "fearful",
                FallbackMicrosoftVoiceStyle.Friendly => "friendly",
                FallbackMicrosoftVoiceStyle.Gentle => "gentle",
                FallbackMicrosoftVoiceStyle.Hopeful => "hopeful",
                FallbackMicrosoftVoiceStyle.Lyrical => "lyrical",
                FallbackMicrosoftVoiceStyle.NarrationProfessional => "narration-professional",
                FallbackMicrosoftVoiceStyle.NarrationRelaxed => "narration-relaxed",
                FallbackMicrosoftVoiceStyle.Newscast => "newscast",
                FallbackMicrosoftVoiceStyle.NewscastCasual => "newscast-casual",
                FallbackMicrosoftVoiceStyle.NewscastFormal => "newscast-formal",
                FallbackMicrosoftVoiceStyle.PoetryReading => "poetry-reading",
                FallbackMicrosoftVoiceStyle.Sad => "sad",
                FallbackMicrosoftVoiceStyle.Serious => "serious",
                FallbackMicrosoftVoiceStyle.Shouting => "shouting",
                FallbackMicrosoftVoiceStyle.SportsCommentary => "sports_commentary",
                FallbackMicrosoftVoiceStyle.SportsCommentaryExcited => "sports_commentary_excited",
                FallbackMicrosoftVoiceStyle.Terrified => "terrified",
                FallbackMicrosoftVoiceStyle.Unfriendly => "unfriendly",
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
                "advertisement_upbeat" => FallbackMicrosoftVoiceStyle.AdvertisementUpbeat,
                "affectionate" => FallbackMicrosoftVoiceStyle.Affectionate,
                "angry" => FallbackMicrosoftVoiceStyle.Angry,
                "assistant" => FallbackMicrosoftVoiceStyle.Assistant,
                "calm" => FallbackMicrosoftVoiceStyle.Calm,
                "chat" => FallbackMicrosoftVoiceStyle.Chat,
                "cheerful" => FallbackMicrosoftVoiceStyle.Cheerful,
                "customerservice" => FallbackMicrosoftVoiceStyle.Customerservice,
                "depressed" => FallbackMicrosoftVoiceStyle.Depressed,
                "disgruntled" => FallbackMicrosoftVoiceStyle.Disgruntled,
                "documentary-narration" => FallbackMicrosoftVoiceStyle.DocumentaryNarration,
                "embarrassed" => FallbackMicrosoftVoiceStyle.Embarrassed,
                "empathetic" => FallbackMicrosoftVoiceStyle.Empathetic,
                "envious" => FallbackMicrosoftVoiceStyle.Envious,
                "excited" => FallbackMicrosoftVoiceStyle.Excited,
                "fearful" => FallbackMicrosoftVoiceStyle.Fearful,
                "friendly" => FallbackMicrosoftVoiceStyle.Friendly,
                "gentle" => FallbackMicrosoftVoiceStyle.Gentle,
                "hopeful" => FallbackMicrosoftVoiceStyle.Hopeful,
                "lyrical" => FallbackMicrosoftVoiceStyle.Lyrical,
                "narration-professional" => FallbackMicrosoftVoiceStyle.NarrationProfessional,
                "narration-relaxed" => FallbackMicrosoftVoiceStyle.NarrationRelaxed,
                "newscast" => FallbackMicrosoftVoiceStyle.Newscast,
                "newscast-casual" => FallbackMicrosoftVoiceStyle.NewscastCasual,
                "newscast-formal" => FallbackMicrosoftVoiceStyle.NewscastFormal,
                "poetry-reading" => FallbackMicrosoftVoiceStyle.PoetryReading,
                "sad" => FallbackMicrosoftVoiceStyle.Sad,
                "serious" => FallbackMicrosoftVoiceStyle.Serious,
                "shouting" => FallbackMicrosoftVoiceStyle.Shouting,
                "sports_commentary" => FallbackMicrosoftVoiceStyle.SportsCommentary,
                "sports_commentary_excited" => FallbackMicrosoftVoiceStyle.SportsCommentaryExcited,
                "terrified" => FallbackMicrosoftVoiceStyle.Terrified,
                "unfriendly" => FallbackMicrosoftVoiceStyle.Unfriendly,
                "whispering" => FallbackMicrosoftVoiceStyle.Whispering,
                _ => null,
            };
        }
    }
}