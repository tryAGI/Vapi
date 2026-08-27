
#nullable enable

namespace Vapi
{
    /// <summary>
    /// The type of tool. "textEditor" for Text Editor tool.
    /// </summary>
    public enum UpdateTextEditorToolDTOType
    {
        /// <summary>
        ///
        /// </summary>
        TextEditor,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateTextEditorToolDTOTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateTextEditorToolDTOType value)
        {
            return value switch
            {
                UpdateTextEditorToolDTOType.TextEditor => "textEditor",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateTextEditorToolDTOType? ToEnum(string value)
        {
            return value switch
            {
                "textEditor" => UpdateTextEditorToolDTOType.TextEditor,
                _ => null,
            };
        }
    }
}