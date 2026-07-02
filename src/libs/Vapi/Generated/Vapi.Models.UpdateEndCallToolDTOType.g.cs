
#nullable enable

namespace Vapi
{
    /// <summary>
    /// The type of tool. "endCall" for End Call tool.
    /// </summary>
    public enum UpdateEndCallToolDTOType
    {
        /// <summary>
        /// 
        /// </summary>
        EndCall,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateEndCallToolDTOTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateEndCallToolDTOType value)
        {
            return value switch
            {
                UpdateEndCallToolDTOType.EndCall => "endCall",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateEndCallToolDTOType? ToEnum(string value)
        {
            return value switch
            {
                "endCall" => UpdateEndCallToolDTOType.EndCall,
                _ => null,
            };
        }
    }
}