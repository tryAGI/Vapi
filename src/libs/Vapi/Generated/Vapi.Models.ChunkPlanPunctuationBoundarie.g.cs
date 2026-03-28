
#nullable enable

namespace Vapi
{
    /// <summary>
    /// 
    /// </summary>
    public enum ChunkPlanPunctuationBoundarie
    {
        /// <summary>
        /// 
        /// </summary>
        x_3,
        /// <summary>
        /// 
        /// </summary>
        x,
        /// <summary>
        /// 
        /// </summary>
        x_11,
        /// <summary>
        /// 
        /// </summary>
        x_12,
        /// <summary>
        /// 
        /// </summary>
        x_5,
        /// <summary>
        /// 
        /// </summary>
        x_4,
        /// <summary>
        /// 
        /// </summary>
        x_10,
        /// <summary>
        /// 
        /// </summary>
        x__,
        /// <summary>
        /// 
        /// </summary>
        x_6,
        /// <summary>
        /// 
        /// </summary>
        x_7,
        /// <summary>
        /// 
        /// </summary>
        x_8,
        /// <summary>
        /// 
        /// </summary>
        x_9,
        /// <summary>
        /// 
        /// </summary>
        x_,
        /// <summary>
        /// 
        /// </summary>
        x_2,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChunkPlanPunctuationBoundarieExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChunkPlanPunctuationBoundarie value)
        {
            return value switch
            {
                ChunkPlanPunctuationBoundarie.x_3 => "!",
                ChunkPlanPunctuationBoundarie.x => ")",
                ChunkPlanPunctuationBoundarie.x_11 => ",",
                ChunkPlanPunctuationBoundarie.x_12 => ":",
                ChunkPlanPunctuationBoundarie.x_5 => ";",
                ChunkPlanPunctuationBoundarie.x_4 => "?",
                ChunkPlanPunctuationBoundarie.x_10 => "|",
                ChunkPlanPunctuationBoundarie.x__ => "||",
                ChunkPlanPunctuationBoundarie.x_6 => "،",
                ChunkPlanPunctuationBoundarie.x_7 => "۔",
                ChunkPlanPunctuationBoundarie.x_8 => "।",
                ChunkPlanPunctuationBoundarie.x_9 => "॥",
                ChunkPlanPunctuationBoundarie.x_ => "。",
                ChunkPlanPunctuationBoundarie.x_2 => "，",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChunkPlanPunctuationBoundarie? ToEnum(string value)
        {
            return value switch
            {
                "!" => ChunkPlanPunctuationBoundarie.x_3,
                ")" => ChunkPlanPunctuationBoundarie.x,
                "," => ChunkPlanPunctuationBoundarie.x_11,
                ":" => ChunkPlanPunctuationBoundarie.x_12,
                ";" => ChunkPlanPunctuationBoundarie.x_5,
                "?" => ChunkPlanPunctuationBoundarie.x_4,
                "|" => ChunkPlanPunctuationBoundarie.x_10,
                "||" => ChunkPlanPunctuationBoundarie.x__,
                "،" => ChunkPlanPunctuationBoundarie.x_6,
                "۔" => ChunkPlanPunctuationBoundarie.x_7,
                "।" => ChunkPlanPunctuationBoundarie.x_8,
                "॥" => ChunkPlanPunctuationBoundarie.x_9,
                "。" => ChunkPlanPunctuationBoundarie.x_,
                "，" => ChunkPlanPunctuationBoundarie.x_2,
                _ => null,
            };
        }
    }
}