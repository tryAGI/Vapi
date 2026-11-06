
#nullable enable

namespace Vapi
{
    /// <summary>
    /// Example: office
    /// </summary>
    public enum UpdateWorkflowDTOBackgroundSound
    {
        /// <summary>
        ///
        /// </summary>
        City,
        /// <summary>
        ///
        /// </summary>
        Crowd,
        /// <summary>
        ///
        /// </summary>
        Farm,
        /// <summary>
        ///
        /// </summary>
        Off,
        /// <summary>
        ///
        /// </summary>
        Office,
        /// <summary>
        ///
        /// </summary>
        WhiteNoise,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateWorkflowDTOBackgroundSoundExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateWorkflowDTOBackgroundSound value)
        {
            return value switch
            {
                UpdateWorkflowDTOBackgroundSound.City => "city",
                UpdateWorkflowDTOBackgroundSound.Crowd => "crowd",
                UpdateWorkflowDTOBackgroundSound.Farm => "farm",
                UpdateWorkflowDTOBackgroundSound.Off => "off",
                UpdateWorkflowDTOBackgroundSound.Office => "office",
                UpdateWorkflowDTOBackgroundSound.WhiteNoise => "white-noise",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateWorkflowDTOBackgroundSound? ToEnum(string value)
        {
            return value switch
            {
                "city" => UpdateWorkflowDTOBackgroundSound.City,
                "crowd" => UpdateWorkflowDTOBackgroundSound.Crowd,
                "farm" => UpdateWorkflowDTOBackgroundSound.Farm,
                "off" => UpdateWorkflowDTOBackgroundSound.Off,
                "office" => UpdateWorkflowDTOBackgroundSound.Office,
                "white-noise" => UpdateWorkflowDTOBackgroundSound.WhiteNoise,
                _ => null,
            };
        }
    }
}