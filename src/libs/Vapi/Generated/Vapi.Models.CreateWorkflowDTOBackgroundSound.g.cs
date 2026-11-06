
#nullable enable

namespace Vapi
{
    /// <summary>
    /// Example: office
    /// </summary>
    public enum CreateWorkflowDTOBackgroundSound
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
    public static class CreateWorkflowDTOBackgroundSoundExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateWorkflowDTOBackgroundSound value)
        {
            return value switch
            {
                CreateWorkflowDTOBackgroundSound.City => "city",
                CreateWorkflowDTOBackgroundSound.Crowd => "crowd",
                CreateWorkflowDTOBackgroundSound.Farm => "farm",
                CreateWorkflowDTOBackgroundSound.Off => "off",
                CreateWorkflowDTOBackgroundSound.Office => "office",
                CreateWorkflowDTOBackgroundSound.WhiteNoise => "white-noise",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateWorkflowDTOBackgroundSound? ToEnum(string value)
        {
            return value switch
            {
                "city" => CreateWorkflowDTOBackgroundSound.City,
                "crowd" => CreateWorkflowDTOBackgroundSound.Crowd,
                "farm" => CreateWorkflowDTOBackgroundSound.Farm,
                "off" => CreateWorkflowDTOBackgroundSound.Off,
                "office" => CreateWorkflowDTOBackgroundSound.Office,
                "white-noise" => CreateWorkflowDTOBackgroundSound.WhiteNoise,
                _ => null,
            };
        }
    }
}