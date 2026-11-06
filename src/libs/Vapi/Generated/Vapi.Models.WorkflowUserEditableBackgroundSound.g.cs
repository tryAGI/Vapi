
#nullable enable

namespace Vapi
{
    /// <summary>
    /// Example: office
    /// </summary>
    public enum WorkflowUserEditableBackgroundSound
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
    public static class WorkflowUserEditableBackgroundSoundExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WorkflowUserEditableBackgroundSound value)
        {
            return value switch
            {
                WorkflowUserEditableBackgroundSound.City => "city",
                WorkflowUserEditableBackgroundSound.Crowd => "crowd",
                WorkflowUserEditableBackgroundSound.Farm => "farm",
                WorkflowUserEditableBackgroundSound.Off => "off",
                WorkflowUserEditableBackgroundSound.Office => "office",
                WorkflowUserEditableBackgroundSound.WhiteNoise => "white-noise",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WorkflowUserEditableBackgroundSound? ToEnum(string value)
        {
            return value switch
            {
                "city" => WorkflowUserEditableBackgroundSound.City,
                "crowd" => WorkflowUserEditableBackgroundSound.Crowd,
                "farm" => WorkflowUserEditableBackgroundSound.Farm,
                "off" => WorkflowUserEditableBackgroundSound.Off,
                "office" => WorkflowUserEditableBackgroundSound.Office,
                "white-noise" => WorkflowUserEditableBackgroundSound.WhiteNoise,
                _ => null,
            };
        }
    }
}