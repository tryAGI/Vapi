
#nullable enable

namespace Vapi
{
    /// <summary>
    ///
    /// </summary>
    public enum OpenAIVoiceVoiceId
    {
        /// <summary>
        ///
        /// </summary>
        Alloy,
        /// <summary>
        ///
        /// </summary>
        Ash,
        /// <summary>
        ///
        /// </summary>
        Ballad,
        /// <summary>
        ///
        /// </summary>
        Beacon,
        /// <summary>
        ///
        /// </summary>
        Bossa,
        /// <summary>
        ///
        /// </summary>
        Brise,
        /// <summary>
        ///
        /// </summary>
        Cedar,
        /// <summary>
        ///
        /// </summary>
        Cinder,
        /// <summary>
        ///
        /// </summary>
        Coral,
        /// <summary>
        ///
        /// </summary>
        Delta,
        /// <summary>
        ///
        /// </summary>
        Echo,
        /// <summary>
        ///
        /// </summary>
        Fable,
        /// <summary>
        ///
        /// </summary>
        Flitz,
        /// <summary>
        ///
        /// </summary>
        Gleam,
        /// <summary>
        ///
        /// </summary>
        Harema,
        /// <summary>
        ///
        /// </summary>
        Juni,
        /// <summary>
        ///
        /// </summary>
        Marin,
        /// <summary>
        ///
        /// </summary>
        Meridian,
        /// <summary>
        ///
        /// </summary>
        Nira,
        /// <summary>
        ///
        /// </summary>
        Noeul,
        /// <summary>
        ///
        /// </summary>
        Nova,
        /// <summary>
        ///
        /// </summary>
        Nuri,
        /// <summary>
        ///
        /// </summary>
        Onyx,
        /// <summary>
        ///
        /// </summary>
        Quartz,
        /// <summary>
        ///
        /// </summary>
        Ripple,
        /// <summary>
        ///
        /// </summary>
        Sage,
        /// <summary>
        ///
        /// </summary>
        Shida,
        /// <summary>
        ///
        /// </summary>
        Shimmer,
        /// <summary>
        ///
        /// </summary>
        Sillage,
        /// <summary>
        ///
        /// </summary>
        Stone,
        /// <summary>
        ///
        /// </summary>
        Tempo,
        /// <summary>
        ///
        /// </summary>
        Verse,
        /// <summary>
        ///
        /// </summary>
        Vesper,
        /// <summary>
        ///
        /// </summary>
        Willow,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OpenAIVoiceVoiceIdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OpenAIVoiceVoiceId value)
        {
            return value switch
            {
                OpenAIVoiceVoiceId.Alloy => "alloy",
                OpenAIVoiceVoiceId.Ash => "ash",
                OpenAIVoiceVoiceId.Ballad => "ballad",
                OpenAIVoiceVoiceId.Beacon => "beacon",
                OpenAIVoiceVoiceId.Bossa => "bossa",
                OpenAIVoiceVoiceId.Brise => "brise",
                OpenAIVoiceVoiceId.Cedar => "cedar",
                OpenAIVoiceVoiceId.Cinder => "cinder",
                OpenAIVoiceVoiceId.Coral => "coral",
                OpenAIVoiceVoiceId.Delta => "delta",
                OpenAIVoiceVoiceId.Echo => "echo",
                OpenAIVoiceVoiceId.Fable => "fable",
                OpenAIVoiceVoiceId.Flitz => "flitz",
                OpenAIVoiceVoiceId.Gleam => "gleam",
                OpenAIVoiceVoiceId.Harema => "harema",
                OpenAIVoiceVoiceId.Juni => "juni",
                OpenAIVoiceVoiceId.Marin => "marin",
                OpenAIVoiceVoiceId.Meridian => "meridian",
                OpenAIVoiceVoiceId.Nira => "nira",
                OpenAIVoiceVoiceId.Noeul => "noeul",
                OpenAIVoiceVoiceId.Nova => "nova",
                OpenAIVoiceVoiceId.Nuri => "nuri",
                OpenAIVoiceVoiceId.Onyx => "onyx",
                OpenAIVoiceVoiceId.Quartz => "quartz",
                OpenAIVoiceVoiceId.Ripple => "ripple",
                OpenAIVoiceVoiceId.Sage => "sage",
                OpenAIVoiceVoiceId.Shida => "shida",
                OpenAIVoiceVoiceId.Shimmer => "shimmer",
                OpenAIVoiceVoiceId.Sillage => "sillage",
                OpenAIVoiceVoiceId.Stone => "stone",
                OpenAIVoiceVoiceId.Tempo => "tempo",
                OpenAIVoiceVoiceId.Verse => "verse",
                OpenAIVoiceVoiceId.Vesper => "vesper",
                OpenAIVoiceVoiceId.Willow => "willow",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OpenAIVoiceVoiceId? ToEnum(string value)
        {
            return value switch
            {
                "alloy" => OpenAIVoiceVoiceId.Alloy,
                "ash" => OpenAIVoiceVoiceId.Ash,
                "ballad" => OpenAIVoiceVoiceId.Ballad,
                "beacon" => OpenAIVoiceVoiceId.Beacon,
                "bossa" => OpenAIVoiceVoiceId.Bossa,
                "brise" => OpenAIVoiceVoiceId.Brise,
                "cedar" => OpenAIVoiceVoiceId.Cedar,
                "cinder" => OpenAIVoiceVoiceId.Cinder,
                "coral" => OpenAIVoiceVoiceId.Coral,
                "delta" => OpenAIVoiceVoiceId.Delta,
                "echo" => OpenAIVoiceVoiceId.Echo,
                "fable" => OpenAIVoiceVoiceId.Fable,
                "flitz" => OpenAIVoiceVoiceId.Flitz,
                "gleam" => OpenAIVoiceVoiceId.Gleam,
                "harema" => OpenAIVoiceVoiceId.Harema,
                "juni" => OpenAIVoiceVoiceId.Juni,
                "marin" => OpenAIVoiceVoiceId.Marin,
                "meridian" => OpenAIVoiceVoiceId.Meridian,
                "nira" => OpenAIVoiceVoiceId.Nira,
                "noeul" => OpenAIVoiceVoiceId.Noeul,
                "nova" => OpenAIVoiceVoiceId.Nova,
                "nuri" => OpenAIVoiceVoiceId.Nuri,
                "onyx" => OpenAIVoiceVoiceId.Onyx,
                "quartz" => OpenAIVoiceVoiceId.Quartz,
                "ripple" => OpenAIVoiceVoiceId.Ripple,
                "sage" => OpenAIVoiceVoiceId.Sage,
                "shida" => OpenAIVoiceVoiceId.Shida,
                "shimmer" => OpenAIVoiceVoiceId.Shimmer,
                "sillage" => OpenAIVoiceVoiceId.Sillage,
                "stone" => OpenAIVoiceVoiceId.Stone,
                "tempo" => OpenAIVoiceVoiceId.Tempo,
                "verse" => OpenAIVoiceVoiceId.Verse,
                "vesper" => OpenAIVoiceVoiceId.Vesper,
                "willow" => OpenAIVoiceVoiceId.Willow,
                _ => null,
            };
        }
    }
}