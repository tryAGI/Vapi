
#nullable enable

namespace Vapi
{
    /// <summary>
    /// The terminal status of the transfer, rendered as the status line.
    /// </summary>
    public enum TransferArtifactStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Busy,
        /// <summary>
        /// 
        /// </summary>
        Cancelled,
        /// <summary>
        /// 
        /// </summary>
        Completed,
        /// <summary>
        /// 
        /// </summary>
        Connected,
        /// <summary>
        /// 
        /// </summary>
        Failed,
        /// <summary>
        /// 
        /// </summary>
        NoAnswer,
        /// <summary>
        /// 
        /// </summary>
        Voicemail,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TransferArtifactStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TransferArtifactStatus value)
        {
            return value switch
            {
                TransferArtifactStatus.Busy => "busy",
                TransferArtifactStatus.Cancelled => "cancelled",
                TransferArtifactStatus.Completed => "completed",
                TransferArtifactStatus.Connected => "connected",
                TransferArtifactStatus.Failed => "failed",
                TransferArtifactStatus.NoAnswer => "no-answer",
                TransferArtifactStatus.Voicemail => "voicemail",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TransferArtifactStatus? ToEnum(string value)
        {
            return value switch
            {
                "busy" => TransferArtifactStatus.Busy,
                "cancelled" => TransferArtifactStatus.Cancelled,
                "completed" => TransferArtifactStatus.Completed,
                "connected" => TransferArtifactStatus.Connected,
                "failed" => TransferArtifactStatus.Failed,
                "no-answer" => TransferArtifactStatus.NoAnswer,
                "voicemail" => TransferArtifactStatus.Voicemail,
                _ => null,
            };
        }
    }
}