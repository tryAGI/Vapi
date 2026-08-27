
#nullable enable

namespace Vapi
{
    /// <summary>
    /// The type of tool. "ghl" for GHL tool.
    /// </summary>
    public enum UpdateGhlToolDTOType
    {
        /// <summary>
        ///
        /// </summary>
        Ghl,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateGhlToolDTOTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateGhlToolDTOType value)
        {
            return value switch
            {
                UpdateGhlToolDTOType.Ghl => "ghl",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateGhlToolDTOType? ToEnum(string value)
        {
            return value switch
            {
                "ghl" => UpdateGhlToolDTOType.Ghl,
                _ => null,
            };
        }
    }
}