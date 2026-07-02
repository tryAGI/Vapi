
#nullable enable

namespace Vapi
{
    /// <summary>
    /// The type of tool. "slack.message.send" for Slack Send Message tool.
    /// </summary>
    public enum UpdateSlackSendMessageToolDTOType
    {
        /// <summary>
        /// 
        /// </summary>
        SlackMessageSend,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateSlackSendMessageToolDTOTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateSlackSendMessageToolDTOType value)
        {
            return value switch
            {
                UpdateSlackSendMessageToolDTOType.SlackMessageSend => "slack.message.send",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateSlackSendMessageToolDTOType? ToEnum(string value)
        {
            return value switch
            {
                "slack.message.send" => UpdateSlackSendMessageToolDTOType.SlackMessageSend,
                _ => null,
            };
        }
    }
}