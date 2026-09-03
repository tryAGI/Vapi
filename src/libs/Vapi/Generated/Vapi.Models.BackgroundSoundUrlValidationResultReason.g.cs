
#nullable enable

namespace Vapi
{
    /// <summary>
    /// Why validation failed. Only present when valid is false.
    /// </summary>
    public enum BackgroundSoundUrlValidationResultReason
    {
        /// <summary>
        ///
        /// </summary>
        BlockedAddress,
        /// <summary>
        ///
        /// </summary>
        HttpError,
        /// <summary>
        ///
        /// </summary>
        InvalidUrl,
        /// <summary>
        ///
        /// </summary>
        NotAudio,
        /// <summary>
        ///
        /// </summary>
        Timeout,
        /// <summary>
        ///
        /// </summary>
        TooManyRedirects,
        /// <summary>
        ///
        /// </summary>
        Unreachable,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BackgroundSoundUrlValidationResultReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BackgroundSoundUrlValidationResultReason value)
        {
            return value switch
            {
                BackgroundSoundUrlValidationResultReason.BlockedAddress => "blocked-address",
                BackgroundSoundUrlValidationResultReason.HttpError => "http-error",
                BackgroundSoundUrlValidationResultReason.InvalidUrl => "invalid-url",
                BackgroundSoundUrlValidationResultReason.NotAudio => "not-audio",
                BackgroundSoundUrlValidationResultReason.Timeout => "timeout",
                BackgroundSoundUrlValidationResultReason.TooManyRedirects => "too-many-redirects",
                BackgroundSoundUrlValidationResultReason.Unreachable => "unreachable",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BackgroundSoundUrlValidationResultReason? ToEnum(string value)
        {
            return value switch
            {
                "blocked-address" => BackgroundSoundUrlValidationResultReason.BlockedAddress,
                "http-error" => BackgroundSoundUrlValidationResultReason.HttpError,
                "invalid-url" => BackgroundSoundUrlValidationResultReason.InvalidUrl,
                "not-audio" => BackgroundSoundUrlValidationResultReason.NotAudio,
                "timeout" => BackgroundSoundUrlValidationResultReason.Timeout,
                "too-many-redirects" => BackgroundSoundUrlValidationResultReason.TooManyRedirects,
                "unreachable" => BackgroundSoundUrlValidationResultReason.Unreachable,
                _ => null,
            };
        }
    }
}