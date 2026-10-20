
#nullable enable

namespace Vapi
{
    /// <summary>
    ///
    /// </summary>
    public enum TrafficTabStructuredOutputDTOType
    {
        /// <summary>
        ///
        /// </summary>
        Boolean,
        /// <summary>
        ///
        /// </summary>
        Number,
        /// <summary>
        ///
        /// </summary>
        String,
        /// <summary>
        ///
        /// </summary>
        Unknown,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TrafficTabStructuredOutputDTOTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TrafficTabStructuredOutputDTOType value)
        {
            return value switch
            {
                TrafficTabStructuredOutputDTOType.Boolean => "boolean",
                TrafficTabStructuredOutputDTOType.Number => "number",
                TrafficTabStructuredOutputDTOType.String => "string",
                TrafficTabStructuredOutputDTOType.Unknown => "unknown",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TrafficTabStructuredOutputDTOType? ToEnum(string value)
        {
            return value switch
            {
                "boolean" => TrafficTabStructuredOutputDTOType.Boolean,
                "number" => TrafficTabStructuredOutputDTOType.Number,
                "string" => TrafficTabStructuredOutputDTOType.String,
                "unknown" => TrafficTabStructuredOutputDTOType.Unknown,
                _ => null,
            };
        }
    }
}