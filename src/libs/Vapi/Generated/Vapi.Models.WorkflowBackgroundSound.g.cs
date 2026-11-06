
#nullable enable

namespace Vapi
{
    /// <summary>
    /// Example: office
    /// </summary>
    public enum WorkflowBackgroundSound
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
    public static class WorkflowBackgroundSoundExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WorkflowBackgroundSound value)
        {
            return value switch
            {
                WorkflowBackgroundSound.City => "city",
                WorkflowBackgroundSound.Crowd => "crowd",
                WorkflowBackgroundSound.Farm => "farm",
                WorkflowBackgroundSound.Off => "off",
                WorkflowBackgroundSound.Office => "office",
                WorkflowBackgroundSound.WhiteNoise => "white-noise",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WorkflowBackgroundSound? ToEnum(string value)
        {
            return value switch
            {
                "city" => WorkflowBackgroundSound.City,
                "crowd" => WorkflowBackgroundSound.Crowd,
                "farm" => WorkflowBackgroundSound.Farm,
                "off" => WorkflowBackgroundSound.Off,
                "office" => WorkflowBackgroundSound.Office,
                "white-noise" => WorkflowBackgroundSound.WhiteNoise,
                _ => null,
            };
        }
    }
}