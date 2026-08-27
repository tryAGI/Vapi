
#nullable enable

namespace Vapi
{
    /// <summary>
    /// Kind of source row the pin originates from.
    /// </summary>
    public enum VersionPinReferenceSourceType
    {
        /// <summary>
        ///
        /// </summary>
        AssistantVersion,
        /// <summary>
        ///
        /// </summary>
        Squad,
        /// <summary>
        ///
        /// </summary>
        ToolVersion,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VersionPinReferenceSourceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VersionPinReferenceSourceType value)
        {
            return value switch
            {
                VersionPinReferenceSourceType.AssistantVersion => "assistant_version",
                VersionPinReferenceSourceType.Squad => "squad",
                VersionPinReferenceSourceType.ToolVersion => "tool_version",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VersionPinReferenceSourceType? ToEnum(string value)
        {
            return value switch
            {
                "assistant_version" => VersionPinReferenceSourceType.AssistantVersion,
                "squad" => VersionPinReferenceSourceType.Squad,
                "tool_version" => VersionPinReferenceSourceType.ToolVersion,
                _ => null,
            };
        }
    }
}