
#nullable enable

namespace Vapi
{
    /// <summary>
    /// This is the type of the message. "call.artifact.upload" is sent after a call<br/>
    /// to report whether each artifact was stored in your own configured storage.
    /// </summary>
    public enum ServerMessageCallArtifactUploadType
    {
        /// <summary>
        /// 
        /// </summary>
        CallArtifactUpload,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ServerMessageCallArtifactUploadTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ServerMessageCallArtifactUploadType value)
        {
            return value switch
            {
                ServerMessageCallArtifactUploadType.CallArtifactUpload => "call.artifact.upload",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ServerMessageCallArtifactUploadType? ToEnum(string value)
        {
            return value switch
            {
                "call.artifact.upload" => ServerMessageCallArtifactUploadType.CallArtifactUpload,
                _ => null,
            };
        }
    }
}