
#nullable enable

namespace Vapi
{
    /// <summary>
    /// The type of tool. "gohighlevel.contact.create" for GoHighLevel Contact Create tool.
    /// </summary>
    public enum UpdateGoHighLevelContactCreateToolDTOType
    {
        /// <summary>
        /// 
        /// </summary>
        GohighlevelContactCreate,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateGoHighLevelContactCreateToolDTOTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateGoHighLevelContactCreateToolDTOType value)
        {
            return value switch
            {
                UpdateGoHighLevelContactCreateToolDTOType.GohighlevelContactCreate => "gohighlevel.contact.create",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateGoHighLevelContactCreateToolDTOType? ToEnum(string value)
        {
            return value switch
            {
                "gohighlevel.contact.create" => UpdateGoHighLevelContactCreateToolDTOType.GohighlevelContactCreate,
                _ => null,
            };
        }
    }
}