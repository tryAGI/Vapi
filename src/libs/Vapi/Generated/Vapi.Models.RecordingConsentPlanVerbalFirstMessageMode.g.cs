
#nullable enable

namespace Vapi
{
    /// <summary>
    /// This controls whether the consent assistant speaks first or waits for the caller to speak first.<br/>
    /// Use:<br/>
    /// - `assistant-speaks-first` (default) to have the consent assistant play the consent message as soon as the call is answered.<br/>
    /// - `assistant-waits-for-user` to have the consent assistant wait for the caller to speak before playing the consent message.<br/>
    /// We strongly recommend `assistant-waits-for-user` for outbound calls. Some telephony providers signal "answered" while the line is still ringing, which can cause the consent message to play into a ringing line and be missed by the caller. Waiting for the caller to speak first guarantees they hear the full consent message.<br/>
    /// Note: when combined with `type: 'stay-on-line'`, silence only counts toward consent after the caller has spoken at least once.<br/>
    /// @default 'assistant-speaks-first'<br/>
    /// Default Value: assistant-speaks-first<br/>
    /// Example: assistant-speaks-first
    /// </summary>
    public enum RecordingConsentPlanVerbalFirstMessageMode
    {
        /// <summary>
        /// 
        /// </summary>
        AssistantSpeaksFirst,
        /// <summary>
        /// 
        /// </summary>
        AssistantWaitsForUser,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RecordingConsentPlanVerbalFirstMessageModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RecordingConsentPlanVerbalFirstMessageMode value)
        {
            return value switch
            {
                RecordingConsentPlanVerbalFirstMessageMode.AssistantSpeaksFirst => "assistant-speaks-first",
                RecordingConsentPlanVerbalFirstMessageMode.AssistantWaitsForUser => "assistant-waits-for-user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RecordingConsentPlanVerbalFirstMessageMode? ToEnum(string value)
        {
            return value switch
            {
                "assistant-speaks-first" => RecordingConsentPlanVerbalFirstMessageMode.AssistantSpeaksFirst,
                "assistant-waits-for-user" => RecordingConsentPlanVerbalFirstMessageMode.AssistantWaitsForUser,
                _ => null,
            };
        }
    }
}