#nullable enable

namespace Vapi.JsonConverters
{
    /// <inheritdoc />
    public sealed class CallHealthDashboardIssueCoverageDTOStateJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vapi.CallHealthDashboardIssueCoverageDTOState>
    {
        /// <inheritdoc />
        public override global::Vapi.CallHealthDashboardIssueCoverageDTOState Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case global::System.Text.Json.JsonTokenType.String:
                {
                    var stringValue = reader.GetString();
                    if (stringValue != null)
                    {
                        return global::Vapi.CallHealthDashboardIssueCoverageDTOStateExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Vapi.CallHealthDashboardIssueCoverageDTOState)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Vapi.CallHealthDashboardIssueCoverageDTOState);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vapi.CallHealthDashboardIssueCoverageDTOState value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Vapi.CallHealthDashboardIssueCoverageDTOStateExtensions.ToValueString(value));
        }
    }
}
