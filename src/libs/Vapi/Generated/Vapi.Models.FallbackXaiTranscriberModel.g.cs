
#nullable enable

namespace Vapi
{
    /// <summary>
    /// The xAI speech-to-text model to use. xAI currently exposes a single STT model — placeholder for future model selection.
    /// </summary>
    public enum FallbackXaiTranscriberModel
    {
        /// <summary>
        /// 
        /// </summary>
        Default,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FallbackXaiTranscriberModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FallbackXaiTranscriberModel value)
        {
            return value switch
            {
                FallbackXaiTranscriberModel.Default => "default",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FallbackXaiTranscriberModel? ToEnum(string value)
        {
            return value switch
            {
                "default" => FallbackXaiTranscriberModel.Default,
                _ => null,
            };
        }
    }
}