
#nullable enable

namespace Vapi
{
    /// <summary>
    /// This is to use numbers bought on Telnyx.
    /// </summary>
    public enum UpdateTelnyxPhoneNumberDTOProvider
    {
        /// <summary>
        /// 
        /// </summary>
        Telnyx,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateTelnyxPhoneNumberDTOProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateTelnyxPhoneNumberDTOProvider value)
        {
            return value switch
            {
                UpdateTelnyxPhoneNumberDTOProvider.Telnyx => "telnyx",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateTelnyxPhoneNumberDTOProvider? ToEnum(string value)
        {
            return value switch
            {
                "telnyx" => UpdateTelnyxPhoneNumberDTOProvider.Telnyx,
                _ => null,
            };
        }
    }
}