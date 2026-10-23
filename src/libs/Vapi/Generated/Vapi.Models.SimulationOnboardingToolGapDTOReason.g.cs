
#nullable enable

namespace Vapi
{
    /// <summary>
    /// Why the path is not exercised: a reason the simulations mock the tool, or why a native path is never reached. New reasons may be added.
    /// </summary>
    public enum SimulationOnboardingToolGapDTOReason
    {
        /// <summary>
        ///
        /// </summary>
        DestinationNameUnscoped,
        /// <summary>
        ///
        /// </summary>
        DestinationNotPlain,
        /// <summary>
        ///
        /// </summary>
        DestinationTruncated,
        /// <summary>
        ///
        /// </summary>
        DestinationUnresolved,
        /// <summary>
        ///
        /// </summary>
        DynamicHandoff,
        /// <summary>
        ///
        /// </summary>
        NativeToolShadowed,
        /// <summary>
        ///
        /// </summary>
        TransferExternal,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SimulationOnboardingToolGapDTOReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SimulationOnboardingToolGapDTOReason value)
        {
            return value switch
            {
                SimulationOnboardingToolGapDTOReason.DestinationNameUnscoped => "destination-name-unscoped",
                SimulationOnboardingToolGapDTOReason.DestinationNotPlain => "destination-not-plain",
                SimulationOnboardingToolGapDTOReason.DestinationTruncated => "destination-truncated",
                SimulationOnboardingToolGapDTOReason.DestinationUnresolved => "destination-unresolved",
                SimulationOnboardingToolGapDTOReason.DynamicHandoff => "dynamic-handoff",
                SimulationOnboardingToolGapDTOReason.NativeToolShadowed => "native-tool-shadowed",
                SimulationOnboardingToolGapDTOReason.TransferExternal => "transfer-external",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SimulationOnboardingToolGapDTOReason? ToEnum(string value)
        {
            return value switch
            {
                "destination-name-unscoped" => SimulationOnboardingToolGapDTOReason.DestinationNameUnscoped,
                "destination-not-plain" => SimulationOnboardingToolGapDTOReason.DestinationNotPlain,
                "destination-truncated" => SimulationOnboardingToolGapDTOReason.DestinationTruncated,
                "destination-unresolved" => SimulationOnboardingToolGapDTOReason.DestinationUnresolved,
                "dynamic-handoff" => SimulationOnboardingToolGapDTOReason.DynamicHandoff,
                "native-tool-shadowed" => SimulationOnboardingToolGapDTOReason.NativeToolShadowed,
                "transfer-external" => SimulationOnboardingToolGapDTOReason.TransferExternal,
                _ => null,
            };
        }
    }
}