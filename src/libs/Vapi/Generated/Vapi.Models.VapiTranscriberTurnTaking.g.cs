
#nullable enable

namespace Vapi
{
    /// <summary>
    /// This is the turn-taking mode. `intelligent` uses the underlying model's<br/>
    /// native end-of-turn detection; `manual` ignores it and waits a fixed<br/>
    /// end-of-turn delay. Defaults to `intelligent`.
    /// </summary>
    public enum VapiTranscriberTurnTaking
    {
        /// <summary>
        /// 
        /// </summary>
        Intelligent,
        /// <summary>
        /// 
        /// </summary>
        Manual,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VapiTranscriberTurnTakingExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VapiTranscriberTurnTaking value)
        {
            return value switch
            {
                VapiTranscriberTurnTaking.Intelligent => "intelligent",
                VapiTranscriberTurnTaking.Manual => "manual",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VapiTranscriberTurnTaking? ToEnum(string value)
        {
            return value switch
            {
                "intelligent" => VapiTranscriberTurnTaking.Intelligent,
                "manual" => VapiTranscriberTurnTaking.Manual,
                _ => null,
            };
        }
    }
}