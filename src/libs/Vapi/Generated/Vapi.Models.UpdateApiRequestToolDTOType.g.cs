
#nullable enable

namespace Vapi
{
    /// <summary>
    /// The type of tool. "apiRequest" for API request tool.
    /// </summary>
    public enum UpdateApiRequestToolDTOType
    {
        /// <summary>
        ///
        /// </summary>
        ApiRequest,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateApiRequestToolDTOTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateApiRequestToolDTOType value)
        {
            return value switch
            {
                UpdateApiRequestToolDTOType.ApiRequest => "apiRequest",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateApiRequestToolDTOType? ToEnum(string value)
        {
            return value switch
            {
                "apiRequest" => UpdateApiRequestToolDTOType.ApiRequest,
                _ => null,
            };
        }
    }
}