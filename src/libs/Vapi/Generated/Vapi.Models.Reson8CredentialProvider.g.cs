
#nullable enable

namespace Vapi
{
    /// <summary>
    ///
    /// </summary>
    public enum Reson8CredentialProvider
    {
        /// <summary>
        ///
        /// </summary>
        Reson8,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class Reson8CredentialProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this Reson8CredentialProvider value)
        {
            return value switch
            {
                Reson8CredentialProvider.Reson8 => "reson8",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static Reson8CredentialProvider? ToEnum(string value)
        {
            return value switch
            {
                "reson8" => Reson8CredentialProvider.Reson8,
                _ => null,
            };
        }
    }
}