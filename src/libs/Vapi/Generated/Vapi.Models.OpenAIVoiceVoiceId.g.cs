
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
                OpenAIVoiceVoiceId.Cedar => "cedar",
                OpenAIVoiceVoiceId.Cinder => "cinder",
                OpenAIVoiceVoiceId.Coral => "coral",
                OpenAIVoiceVoiceId.Delta => "delta",
                OpenAIVoiceVoiceId.Echo => "echo",
                OpenAIVoiceVoiceId.Fable => "fable",
                OpenAIVoiceVoiceId.Gleam => "gleam",
                OpenAIVoiceVoiceId.Marin => "marin",
                OpenAIVoiceVoiceId.Meridian => "meridian",
                OpenAIVoiceVoiceId.Nova => "nova",
                OpenAIVoiceVoiceId.Onyx => "onyx",
                OpenAIVoiceVoiceId.Quartz => "quartz",
                OpenAIVoiceVoiceId.Ripple => "ripple",
                OpenAIVoiceVoiceId.Sage => "sage",
                OpenAIVoiceVoiceId.Shimmer => "shimmer",
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
                "cedar" => OpenAIVoiceVoiceId.Cedar,
                "cinder" => OpenAIVoiceVoiceId.Cinder,
                "coral" => OpenAIVoiceVoiceId.Coral,
                "delta" => OpenAIVoiceVoiceId.Delta,
                "echo" => OpenAIVoiceVoiceId.Echo,
                "fable" => OpenAIVoiceVoiceId.Fable,
                "gleam" => OpenAIVoiceVoiceId.Gleam,
                "marin" => OpenAIVoiceVoiceId.Marin,
                "meridian" => OpenAIVoiceVoiceId.Meridian,
                "nova" => OpenAIVoiceVoiceId.Nova,
                "onyx" => OpenAIVoiceVoiceId.Onyx,
                "quartz" => OpenAIVoiceVoiceId.Quartz,
                "ripple" => OpenAIVoiceVoiceId.Ripple,
                "sage" => OpenAIVoiceVoiceId.Sage,
                "shimmer" => OpenAIVoiceVoiceId.Shimmer,
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