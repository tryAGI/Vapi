
#nullable enable

namespace Vapi
{
    /// <summary>
    /// Speaking style applied via mstts:express-as on every request. Unknown styles are ignored by Azure and fall back to neutral.<br/>
    /// Example: chat
    /// </summary>
    public enum MicrosoftVoiceStyle
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
    public static class MicrosoftVoiceStyleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MicrosoftVoiceStyle value)
        {
            return value switch
            {
                MicrosoftVoiceStyle.AdvertisementUpbeat => "advertisement_upbeat",
                MicrosoftVoiceStyle.Affectionate => "affectionate",
                MicrosoftVoiceStyle.Angry => "angry",
                MicrosoftVoiceStyle.Assistant => "assistant",
                MicrosoftVoiceStyle.Calm => "calm",
                MicrosoftVoiceStyle.Chat => "chat",
                MicrosoftVoiceStyle.Cheerful => "cheerful",
                MicrosoftVoiceStyle.Customerservice => "customerservice",
                MicrosoftVoiceStyle.Depressed => "depressed",
                MicrosoftVoiceStyle.Disgruntled => "disgruntled",
                MicrosoftVoiceStyle.DocumentaryNarration => "documentary-narration",
                MicrosoftVoiceStyle.Embarrassed => "embarrassed",
                MicrosoftVoiceStyle.Empathetic => "empathetic",
                MicrosoftVoiceStyle.Envious => "envious",
                MicrosoftVoiceStyle.Excited => "excited",
                MicrosoftVoiceStyle.Fearful => "fearful",
                MicrosoftVoiceStyle.Friendly => "friendly",
                MicrosoftVoiceStyle.Gentle => "gentle",
                MicrosoftVoiceStyle.Hopeful => "hopeful",
                MicrosoftVoiceStyle.Lyrical => "lyrical",
                MicrosoftVoiceStyle.NarrationProfessional => "narration-professional",
                MicrosoftVoiceStyle.NarrationRelaxed => "narration-relaxed",
                MicrosoftVoiceStyle.Newscast => "newscast",
                MicrosoftVoiceStyle.NewscastCasual => "newscast-casual",
                MicrosoftVoiceStyle.NewscastFormal => "newscast-formal",
                MicrosoftVoiceStyle.PoetryReading => "poetry-reading",
                MicrosoftVoiceStyle.Sad => "sad",
                MicrosoftVoiceStyle.Serious => "serious",
                MicrosoftVoiceStyle.Shouting => "shouting",
                MicrosoftVoiceStyle.SportsCommentary => "sports_commentary",
                MicrosoftVoiceStyle.SportsCommentaryExcited => "sports_commentary_excited",
                MicrosoftVoiceStyle.Terrified => "terrified",
                MicrosoftVoiceStyle.Unfriendly => "unfriendly",
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
                "advertisement_upbeat" => MicrosoftVoiceStyle.AdvertisementUpbeat,
                "affectionate" => MicrosoftVoiceStyle.Affectionate,
                "angry" => MicrosoftVoiceStyle.Angry,
                "assistant" => MicrosoftVoiceStyle.Assistant,
                "calm" => MicrosoftVoiceStyle.Calm,
                "chat" => MicrosoftVoiceStyle.Chat,
                "cheerful" => MicrosoftVoiceStyle.Cheerful,
                "customerservice" => MicrosoftVoiceStyle.Customerservice,
                "depressed" => MicrosoftVoiceStyle.Depressed,
                "disgruntled" => MicrosoftVoiceStyle.Disgruntled,
                "documentary-narration" => MicrosoftVoiceStyle.DocumentaryNarration,
                "embarrassed" => MicrosoftVoiceStyle.Embarrassed,
                "empathetic" => MicrosoftVoiceStyle.Empathetic,
                "envious" => MicrosoftVoiceStyle.Envious,
                "excited" => MicrosoftVoiceStyle.Excited,
                "fearful" => MicrosoftVoiceStyle.Fearful,
                "friendly" => MicrosoftVoiceStyle.Friendly,
                "gentle" => MicrosoftVoiceStyle.Gentle,
                "hopeful" => MicrosoftVoiceStyle.Hopeful,
                "lyrical" => MicrosoftVoiceStyle.Lyrical,
                "narration-professional" => MicrosoftVoiceStyle.NarrationProfessional,
                "narration-relaxed" => MicrosoftVoiceStyle.NarrationRelaxed,
                "newscast" => MicrosoftVoiceStyle.Newscast,
                "newscast-casual" => MicrosoftVoiceStyle.NewscastCasual,
                "newscast-formal" => MicrosoftVoiceStyle.NewscastFormal,
                "poetry-reading" => MicrosoftVoiceStyle.PoetryReading,
                "sad" => MicrosoftVoiceStyle.Sad,
                "serious" => MicrosoftVoiceStyle.Serious,
                "shouting" => MicrosoftVoiceStyle.Shouting,
                "sports_commentary" => MicrosoftVoiceStyle.SportsCommentary,
                "sports_commentary_excited" => MicrosoftVoiceStyle.SportsCommentaryExcited,
                "terrified" => MicrosoftVoiceStyle.Terrified,
                "unfriendly" => MicrosoftVoiceStyle.Unfriendly,
                "whispering" => MicrosoftVoiceStyle.Whispering,
                _ => null,
            };
        }
    }
}