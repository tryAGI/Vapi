
#nullable enable

namespace Vapi
{
    /// <summary>
    /// The artifact this result refers to.
    /// </summary>
    public enum CallArtifactUploadItemType
    {
        /// <summary>
        /// 
        /// </summary>
        EndOfCallReport,
        /// <summary>
        /// 
        /// </summary>
        Log,
        /// <summary>
        /// 
        /// </summary>
        Pcap,
        /// <summary>
        /// 
        /// </summary>
        RecordingAssistant,
        /// <summary>
        /// 
        /// </summary>
        RecordingCustomer,
        /// <summary>
        /// 
        /// </summary>
        RecordingMono,
        /// <summary>
        /// 
        /// </summary>
        RecordingStereo,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CallArtifactUploadItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CallArtifactUploadItemType value)
        {
            return value switch
            {
                CallArtifactUploadItemType.EndOfCallReport => "end-of-call-report",
                CallArtifactUploadItemType.Log => "log",
                CallArtifactUploadItemType.Pcap => "pcap",
                CallArtifactUploadItemType.RecordingAssistant => "recording-assistant",
                CallArtifactUploadItemType.RecordingCustomer => "recording-customer",
                CallArtifactUploadItemType.RecordingMono => "recording-mono",
                CallArtifactUploadItemType.RecordingStereo => "recording-stereo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CallArtifactUploadItemType? ToEnum(string value)
        {
            return value switch
            {
                "end-of-call-report" => CallArtifactUploadItemType.EndOfCallReport,
                "log" => CallArtifactUploadItemType.Log,
                "pcap" => CallArtifactUploadItemType.Pcap,
                "recording-assistant" => CallArtifactUploadItemType.RecordingAssistant,
                "recording-customer" => CallArtifactUploadItemType.RecordingCustomer,
                "recording-mono" => CallArtifactUploadItemType.RecordingMono,
                "recording-stereo" => CallArtifactUploadItemType.RecordingStereo,
                _ => null,
            };
        }
    }
}