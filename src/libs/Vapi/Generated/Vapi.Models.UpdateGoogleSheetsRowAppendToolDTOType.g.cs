
#nullable enable

namespace Vapi
{
    /// <summary>
    /// The type of tool. "google.sheets.row.append" for Google Sheets Row Append tool.
    /// </summary>
    public enum UpdateGoogleSheetsRowAppendToolDTOType
    {
        /// <summary>
        ///
        /// </summary>
        GoogleSheetsRowAppend,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateGoogleSheetsRowAppendToolDTOTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateGoogleSheetsRowAppendToolDTOType value)
        {
            return value switch
            {
                UpdateGoogleSheetsRowAppendToolDTOType.GoogleSheetsRowAppend => "google.sheets.row.append",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateGoogleSheetsRowAppendToolDTOType? ToEnum(string value)
        {
            return value switch
            {
                "google.sheets.row.append" => UpdateGoogleSheetsRowAppendToolDTOType.GoogleSheetsRowAppend,
                _ => null,
            };
        }
    }
}