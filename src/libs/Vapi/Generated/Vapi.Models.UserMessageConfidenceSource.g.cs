
#nullable enable

namespace Vapi
{
    /// <summary>
    /// Whether `confidence` came directly from the transcriber ('provider') or<br/>
    /// was computed by Vapi ('derived').<br/>
    /// 'derived' means Vapi computed the score from the transcriber's per-word<br/>
    /// scores; the exact aggregation is provider-specific (an average, a median<br/>
    /// or a minimum, depending on the transcriber). It is also 'derived' when<br/>
    /// consecutive transcript fragments were merged into one message, where the<br/>
    /// score is the minimum across the fragments.<br/>
    /// Absent means no trustworthy score was available for this message: either<br/>
    /// the transcriber does not report one, or the value it reported was invalid<br/>
    /// and was dropped. A merged message is unmarked whenever any fragment it<br/>
    /// contains was unmarked.
    /// </summary>
    public enum UserMessageConfidenceSource
    {
        /// <summary>
        ///
        /// </summary>
        Derived,
        /// <summary>
        ///
        /// </summary>
        Provider,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UserMessageConfidenceSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserMessageConfidenceSource value)
        {
            return value switch
            {
                UserMessageConfidenceSource.Derived => "derived",
                UserMessageConfidenceSource.Provider => "provider",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserMessageConfidenceSource? ToEnum(string value)
        {
            return value switch
            {
                "derived" => UserMessageConfidenceSource.Derived,
                "provider" => UserMessageConfidenceSource.Provider,
                _ => null,
            };
        }
    }
}