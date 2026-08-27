
#nullable enable

namespace Vapi
{
    /// <summary>
    /// This is optional and defaults to "assistant".<br/>
    /// When role=assistant, `content` is said out loud when the tool call fails.<br/>
    /// When role=system, `content` is passed to the model as a system message<br/>
    /// along with the failure result, and the model's generated response is<br/>
    /// spoken. Example:<br/>
    ///     assistant: tool called<br/>
    ///     tool: error from your server<br/>
    ///     &lt;--- system prompt as hint<br/>
    ///     ---&gt; model generates response which is spoken<br/>
    /// This is useful when you want the model to generate an error-aware<br/>
    /// response instead of speaking a fixed failure message.
    /// </summary>
    public enum ToolMessageFailedRole
    {
        /// <summary>
        /// tool called
        /// </summary>
        Assistant,
        /// <summary>
        ///
        /// </summary>
        System,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ToolMessageFailedRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolMessageFailedRole value)
        {
            return value switch
            {
                ToolMessageFailedRole.Assistant => "assistant",
                ToolMessageFailedRole.System => "system",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolMessageFailedRole? ToEnum(string value)
        {
            return value switch
            {
                "assistant" => ToolMessageFailedRole.Assistant,
                "system" => ToolMessageFailedRole.System,
                _ => null,
            };
        }
    }
}