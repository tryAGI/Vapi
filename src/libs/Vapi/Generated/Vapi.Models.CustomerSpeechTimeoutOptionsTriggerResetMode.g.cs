
#nullable enable

namespace Vapi
{
    /// <summary>
    /// This is whether the counter for hook trigger resets the user speaks.<br/>
    /// @default never
    /// </summary>
    public enum CustomerSpeechTimeoutOptionsTriggerResetMode
    {
        /// <summary>
        /// 
        /// </summary>
        Never,
        /// <summary>
        /// 
        /// </summary>
        OnUserSpeech,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CustomerSpeechTimeoutOptionsTriggerResetModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CustomerSpeechTimeoutOptionsTriggerResetMode value)
        {
            return value switch
            {
                CustomerSpeechTimeoutOptionsTriggerResetMode.Never => "never",
                CustomerSpeechTimeoutOptionsTriggerResetMode.OnUserSpeech => "onUserSpeech",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CustomerSpeechTimeoutOptionsTriggerResetMode? ToEnum(string value)
        {
            return value switch
            {
                "never" => CustomerSpeechTimeoutOptionsTriggerResetMode.Never,
                "onUserSpeech" => CustomerSpeechTimeoutOptionsTriggerResetMode.OnUserSpeech,
                _ => null,
            };
        }
    }
}