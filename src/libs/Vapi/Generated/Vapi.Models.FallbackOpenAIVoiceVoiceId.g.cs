
#nullable enable

namespace Vapi
{
    /// <summary>
    ///
    /// </summary>
    public enum FallbackOpenAIVoiceVoiceId
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
    public static class FallbackOpenAIVoiceVoiceIdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FallbackOpenAIVoiceVoiceId value)
        {
            return value switch
            {
                FallbackOpenAIVoiceVoiceId.Alloy => "alloy",
                FallbackOpenAIVoiceVoiceId.Ash => "ash",
                FallbackOpenAIVoiceVoiceId.Ballad => "ballad",
                FallbackOpenAIVoiceVoiceId.Beacon => "beacon",
                FallbackOpenAIVoiceVoiceId.Bossa => "bossa",
                FallbackOpenAIVoiceVoiceId.Brise => "brise",
                FallbackOpenAIVoiceVoiceId.Cedar => "cedar",
                FallbackOpenAIVoiceVoiceId.Cinder => "cinder",
                FallbackOpenAIVoiceVoiceId.Coral => "coral",
                FallbackOpenAIVoiceVoiceId.Delta => "delta",
                FallbackOpenAIVoiceVoiceId.Echo => "echo",
                FallbackOpenAIVoiceVoiceId.Fable => "fable",
                FallbackOpenAIVoiceVoiceId.Flitz => "flitz",
                FallbackOpenAIVoiceVoiceId.Gleam => "gleam",
                FallbackOpenAIVoiceVoiceId.Harema => "harema",
                FallbackOpenAIVoiceVoiceId.Juni => "juni",
                FallbackOpenAIVoiceVoiceId.Marin => "marin",
                FallbackOpenAIVoiceVoiceId.Meridian => "meridian",
                FallbackOpenAIVoiceVoiceId.Nira => "nira",
                FallbackOpenAIVoiceVoiceId.Noeul => "noeul",
                FallbackOpenAIVoiceVoiceId.Nova => "nova",
                FallbackOpenAIVoiceVoiceId.Nuri => "nuri",
                FallbackOpenAIVoiceVoiceId.Onyx => "onyx",
                FallbackOpenAIVoiceVoiceId.Quartz => "quartz",
                FallbackOpenAIVoiceVoiceId.Ripple => "ripple",
                FallbackOpenAIVoiceVoiceId.Sage => "sage",
                FallbackOpenAIVoiceVoiceId.Shida => "shida",
                FallbackOpenAIVoiceVoiceId.Shimmer => "shimmer",
                FallbackOpenAIVoiceVoiceId.Sillage => "sillage",
                FallbackOpenAIVoiceVoiceId.Stone => "stone",
                FallbackOpenAIVoiceVoiceId.Tempo => "tempo",
                FallbackOpenAIVoiceVoiceId.Verse => "verse",
                FallbackOpenAIVoiceVoiceId.Vesper => "vesper",
                FallbackOpenAIVoiceVoiceId.Willow => "willow",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FallbackOpenAIVoiceVoiceId? ToEnum(string value)
        {
            return value switch
            {
                "alloy" => FallbackOpenAIVoiceVoiceId.Alloy,
                "ash" => FallbackOpenAIVoiceVoiceId.Ash,
                "ballad" => FallbackOpenAIVoiceVoiceId.Ballad,
                "beacon" => FallbackOpenAIVoiceVoiceId.Beacon,
                "bossa" => FallbackOpenAIVoiceVoiceId.Bossa,
                "brise" => FallbackOpenAIVoiceVoiceId.Brise,
                "cedar" => FallbackOpenAIVoiceVoiceId.Cedar,
                "cinder" => FallbackOpenAIVoiceVoiceId.Cinder,
                "coral" => FallbackOpenAIVoiceVoiceId.Coral,
                "delta" => FallbackOpenAIVoiceVoiceId.Delta,
                "echo" => FallbackOpenAIVoiceVoiceId.Echo,
                "fable" => FallbackOpenAIVoiceVoiceId.Fable,
                "flitz" => FallbackOpenAIVoiceVoiceId.Flitz,
                "gleam" => FallbackOpenAIVoiceVoiceId.Gleam,
                "harema" => FallbackOpenAIVoiceVoiceId.Harema,
                "juni" => FallbackOpenAIVoiceVoiceId.Juni,
                "marin" => FallbackOpenAIVoiceVoiceId.Marin,
                "meridian" => FallbackOpenAIVoiceVoiceId.Meridian,
                "nira" => FallbackOpenAIVoiceVoiceId.Nira,
                "noeul" => FallbackOpenAIVoiceVoiceId.Noeul,
                "nova" => FallbackOpenAIVoiceVoiceId.Nova,
                "nuri" => FallbackOpenAIVoiceVoiceId.Nuri,
                "onyx" => FallbackOpenAIVoiceVoiceId.Onyx,
                "quartz" => FallbackOpenAIVoiceVoiceId.Quartz,
                "ripple" => FallbackOpenAIVoiceVoiceId.Ripple,
                "sage" => FallbackOpenAIVoiceVoiceId.Sage,
                "shida" => FallbackOpenAIVoiceVoiceId.Shida,
                "shimmer" => FallbackOpenAIVoiceVoiceId.Shimmer,
                "sillage" => FallbackOpenAIVoiceVoiceId.Sillage,
                "stone" => FallbackOpenAIVoiceVoiceId.Stone,
                "tempo" => FallbackOpenAIVoiceVoiceId.Tempo,
                "verse" => FallbackOpenAIVoiceVoiceId.Verse,
                "vesper" => FallbackOpenAIVoiceVoiceId.Vesper,
                "willow" => FallbackOpenAIVoiceVoiceId.Willow,
                _ => null,
            };
        }
    }
}