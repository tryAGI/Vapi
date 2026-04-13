
#nullable enable

namespace Vapi
{
    /// <summary>
    /// 
    /// </summary>
    public enum ChatControllerListChatsSortBy
    {
        /// <summary>
        /// 
        /// </summary>
        Cost,
        /// <summary>
        /// 
        /// </summary>
        CreatedAt,
        /// <summary>
        /// 
        /// </summary>
        Duration,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatControllerListChatsSortByExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatControllerListChatsSortBy value)
        {
            return value switch
            {
                ChatControllerListChatsSortBy.Cost => "cost",
                ChatControllerListChatsSortBy.CreatedAt => "createdAt",
                ChatControllerListChatsSortBy.Duration => "duration",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatControllerListChatsSortBy? ToEnum(string value)
        {
            return value switch
            {
                "cost" => ChatControllerListChatsSortBy.Cost,
                "createdAt" => ChatControllerListChatsSortBy.CreatedAt,
                "duration" => ChatControllerListChatsSortBy.Duration,
                _ => null,
            };
        }
    }
}