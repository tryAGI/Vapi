
#nullable enable

namespace Vapi
{
    /// <summary>
    /// Whether `confidence` came directly from the transcriber ('provider') or<br/>
    /// was computed by Vapi ('derived').<br/>
    /// 'derived' means Vapi computed the score from the transcriber's per-word<br/>
    /// scores; the exact aggregation is provider-specific (an average, a median<br/>
    /// or a minimum, depending on the transcriber).<br/>
    /// Absent means no trustworthy score was available for this transcript:<br/>
    /// either the transcriber does not report one, or the value it reported was<br/>
    /// invalid and was dropped.
    /// </summary>
    public enum ClientMessageTranscriptConfidenceSource
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
    public static class ClientMessageTranscriptConfidenceSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ClientMessageTranscriptConfidenceSource value)
        {
            return value switch
            {
                ClientMessageTranscriptConfidenceSource.Derived => "derived",
                ClientMessageTranscriptConfidenceSource.Provider => "provider",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ClientMessageTranscriptConfidenceSource? ToEnum(string value)
        {
            return value switch
            {
                "derived" => ClientMessageTranscriptConfidenceSource.Derived,
                "provider" => ClientMessageTranscriptConfidenceSource.Provider,
                _ => null,
            };
        }
    }
}