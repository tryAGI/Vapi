
#nullable enable

namespace Vapi
{
    /// <summary>
    /// This determines who starts the video recording. Only applies when video<br/>
    /// recording is enabled (`artifactPlan.videoRecordingEnabled`).<br/>
    /// - `client`: the web client starts the recording when it joins.<br/>
    /// - `server`: Vapi starts the recording once when the user first joins, so a<br/>
    ///   weak client connection can't stop it from starting. The returned<br/>
    ///   `transport.callToken` doesn't start the recording, and the client should<br/>
    ///   not start it either. If Vapi can't set up the server-side start, no token<br/>
    ///   is returned. If the start itself fails, the client is told during the<br/>
    ///   call.<br/>
    /// Defaults to `client`.<br/>
    /// Default Value: client<br/>
    /// Example: server
    /// </summary>
    public enum CreateWebCallDTOVideoRecordingStartMode
    {
        /// <summary>
        /// the web client starts the recording when it joins.
        /// </summary>
        Client,
        /// <summary>
        /// Vapi starts the recording once when the user first joins, so a
        /// </summary>
        Server,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateWebCallDTOVideoRecordingStartModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateWebCallDTOVideoRecordingStartMode value)
        {
            return value switch
            {
                CreateWebCallDTOVideoRecordingStartMode.Client => "client",
                CreateWebCallDTOVideoRecordingStartMode.Server => "server",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateWebCallDTOVideoRecordingStartMode? ToEnum(string value)
        {
            return value switch
            {
                "client" => CreateWebCallDTOVideoRecordingStartMode.Client,
                "server" => CreateWebCallDTOVideoRecordingStartMode.Server,
                _ => null,
            };
        }
    }
}