
#nullable enable

namespace Vapi
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateNeuphonicCredentialDTOProvider
    {
        /// <summary>
        /// 
        /// </summary>
        Neuphonic,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateNeuphonicCredentialDTOProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateNeuphonicCredentialDTOProvider value)
        {
            return value switch
            {
                UpdateNeuphonicCredentialDTOProvider.Neuphonic => "neuphonic",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateNeuphonicCredentialDTOProvider? ToEnum(string value)
        {
            return value switch
            {
                "neuphonic" => UpdateNeuphonicCredentialDTOProvider.Neuphonic,
                _ => null,
            };
        }
    }
}