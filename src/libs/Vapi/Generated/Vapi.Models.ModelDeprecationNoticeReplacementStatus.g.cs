
#nullable enable

namespace Vapi
{
    /// <summary>
    /// Whether a replacement can be recommended for this configuration.<br/>
    /// Example: manual-action-required
    /// </summary>
    public enum ModelDeprecationNoticeReplacementStatus
    {
        /// <summary>
        ///
        /// </summary>
        Available,
        /// <summary>
        ///
        /// </summary>
        ManualActionRequired,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ModelDeprecationNoticeReplacementStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModelDeprecationNoticeReplacementStatus value)
        {
            return value switch
            {
                ModelDeprecationNoticeReplacementStatus.Available => "available",
                ModelDeprecationNoticeReplacementStatus.ManualActionRequired => "manual-action-required",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModelDeprecationNoticeReplacementStatus? ToEnum(string value)
        {
            return value switch
            {
                "available" => ModelDeprecationNoticeReplacementStatus.Available,
                "manual-action-required" => ModelDeprecationNoticeReplacementStatus.ManualActionRequired,
                _ => null,
            };
        }
    }
}