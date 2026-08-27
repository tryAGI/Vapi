
#nullable enable

namespace Vapi
{
    /// <summary>
    /// The transfer mode (e.g. warm-transfer-experimental, blind-transfer).
    /// </summary>
    public enum TransferArtifactMode
    {
        /// <summary>
        ///
        /// </summary>
        BlindTransfer,
        /// <summary>
        ///
        /// </summary>
        BlindTransferAddSummaryToSipHeader,
        /// <summary>
        ///
        /// </summary>
        WarmTransferExperimental,
        /// <summary>
        ///
        /// </summary>
        WarmTransferSayMessage,
        /// <summary>
        ///
        /// </summary>
        WarmTransferSaySummary,
        /// <summary>
        ///
        /// </summary>
        WarmTransferTwiml,
        /// <summary>
        ///
        /// </summary>
        WarmTransferWaitForOperatorToSpeakFirstAndThenSayMessage,
        /// <summary>
        ///
        /// </summary>
        WarmTransferWaitForOperatorToSpeakFirstAndThenSaySummary,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TransferArtifactModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TransferArtifactMode value)
        {
            return value switch
            {
                TransferArtifactMode.BlindTransfer => "blind-transfer",
                TransferArtifactMode.BlindTransferAddSummaryToSipHeader => "blind-transfer-add-summary-to-sip-header",
                TransferArtifactMode.WarmTransferExperimental => "warm-transfer-experimental",
                TransferArtifactMode.WarmTransferSayMessage => "warm-transfer-say-message",
                TransferArtifactMode.WarmTransferSaySummary => "warm-transfer-say-summary",
                TransferArtifactMode.WarmTransferTwiml => "warm-transfer-twiml",
                TransferArtifactMode.WarmTransferWaitForOperatorToSpeakFirstAndThenSayMessage => "warm-transfer-wait-for-operator-to-speak-first-and-then-say-message",
                TransferArtifactMode.WarmTransferWaitForOperatorToSpeakFirstAndThenSaySummary => "warm-transfer-wait-for-operator-to-speak-first-and-then-say-summary",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TransferArtifactMode? ToEnum(string value)
        {
            return value switch
            {
                "blind-transfer" => TransferArtifactMode.BlindTransfer,
                "blind-transfer-add-summary-to-sip-header" => TransferArtifactMode.BlindTransferAddSummaryToSipHeader,
                "warm-transfer-experimental" => TransferArtifactMode.WarmTransferExperimental,
                "warm-transfer-say-message" => TransferArtifactMode.WarmTransferSayMessage,
                "warm-transfer-say-summary" => TransferArtifactMode.WarmTransferSaySummary,
                "warm-transfer-twiml" => TransferArtifactMode.WarmTransferTwiml,
                "warm-transfer-wait-for-operator-to-speak-first-and-then-say-message" => TransferArtifactMode.WarmTransferWaitForOperatorToSpeakFirstAndThenSayMessage,
                "warm-transfer-wait-for-operator-to-speak-first-and-then-say-summary" => TransferArtifactMode.WarmTransferWaitForOperatorToSpeakFirstAndThenSaySummary,
                _ => null,
            };
        }
    }
}