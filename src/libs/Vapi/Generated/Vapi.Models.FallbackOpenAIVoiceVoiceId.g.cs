
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
        Gleam,
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
        Nova,
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
        Shimmer,
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
                FallbackOpenAIVoiceVoiceId.Cedar => "cedar",
                FallbackOpenAIVoiceVoiceId.Cinder => "cinder",
                FallbackOpenAIVoiceVoiceId.Coral => "coral",
                FallbackOpenAIVoiceVoiceId.Delta => "delta",
                FallbackOpenAIVoiceVoiceId.Echo => "echo",
                FallbackOpenAIVoiceVoiceId.Fable => "fable",
                FallbackOpenAIVoiceVoiceId.Gleam => "gleam",
                FallbackOpenAIVoiceVoiceId.Marin => "marin",
                FallbackOpenAIVoiceVoiceId.Meridian => "meridian",
                FallbackOpenAIVoiceVoiceId.Nova => "nova",
                FallbackOpenAIVoiceVoiceId.Onyx => "onyx",
                FallbackOpenAIVoiceVoiceId.Quartz => "quartz",
                FallbackOpenAIVoiceVoiceId.Ripple => "ripple",
                FallbackOpenAIVoiceVoiceId.Sage => "sage",
                FallbackOpenAIVoiceVoiceId.Shimmer => "shimmer",
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
                "cedar" => FallbackOpenAIVoiceVoiceId.Cedar,
                "cinder" => FallbackOpenAIVoiceVoiceId.Cinder,
                "coral" => FallbackOpenAIVoiceVoiceId.Coral,
                "delta" => FallbackOpenAIVoiceVoiceId.Delta,
                "echo" => FallbackOpenAIVoiceVoiceId.Echo,
                "fable" => FallbackOpenAIVoiceVoiceId.Fable,
                "gleam" => FallbackOpenAIVoiceVoiceId.Gleam,
                "marin" => FallbackOpenAIVoiceVoiceId.Marin,
                "meridian" => FallbackOpenAIVoiceVoiceId.Meridian,
                "nova" => FallbackOpenAIVoiceVoiceId.Nova,
                "onyx" => FallbackOpenAIVoiceVoiceId.Onyx,
                "quartz" => FallbackOpenAIVoiceVoiceId.Quartz,
                "ripple" => FallbackOpenAIVoiceVoiceId.Ripple,
                "sage" => FallbackOpenAIVoiceVoiceId.Sage,
                "shimmer" => FallbackOpenAIVoiceVoiceId.Shimmer,
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