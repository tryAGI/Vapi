
#nullable enable

namespace Vapi
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateVapiPhoneNumberDTOProvider
    {
        /// <summary>
        /// 
        /// </summary>
        Vapi,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateVapiPhoneNumberDTOProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateVapiPhoneNumberDTOProvider value)
        {
            return value switch
            {
                UpdateVapiPhoneNumberDTOProvider.Vapi => "vapi",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateVapiPhoneNumberDTOProvider? ToEnum(string value)
        {
            return value switch
            {
                "vapi" => UpdateVapiPhoneNumberDTOProvider.Vapi,
                _ => null,
            };
        }
    }
}