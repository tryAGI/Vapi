
#nullable enable

namespace Vapi
{
    /// <summary>
    /// The type of tool. "gohighlevel.contact.get" for GoHighLevel Contact Get tool.
    /// </summary>
    public enum UpdateGoHighLevelContactGetToolDTOType
    {
        /// <summary>
        /// 
        /// </summary>
        GohighlevelContactGet,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateGoHighLevelContactGetToolDTOTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateGoHighLevelContactGetToolDTOType value)
        {
            return value switch
            {
                UpdateGoHighLevelContactGetToolDTOType.GohighlevelContactGet => "gohighlevel.contact.get",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateGoHighLevelContactGetToolDTOType? ToEnum(string value)
        {
            return value switch
            {
                "gohighlevel.contact.get" => UpdateGoHighLevelContactGetToolDTOType.GohighlevelContactGet,
                _ => null,
            };
        }
    }
}