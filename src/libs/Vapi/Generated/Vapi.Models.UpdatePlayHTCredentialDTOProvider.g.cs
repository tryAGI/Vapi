
#nullable enable

namespace Vapi
{
    /// <summary>
    ///
    /// </summary>
    public enum UpdatePlayHTCredentialDTOProvider
    {
        /// <summary>
        ///
        /// </summary>
        Playht,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdatePlayHTCredentialDTOProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdatePlayHTCredentialDTOProvider value)
        {
            return value switch
            {
                UpdatePlayHTCredentialDTOProvider.Playht => "playht",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdatePlayHTCredentialDTOProvider? ToEnum(string value)
        {
            return value switch
            {
                "playht" => UpdatePlayHTCredentialDTOProvider.Playht,
                _ => null,
            };
        }
    }
}