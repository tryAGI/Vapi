#nullable enable

namespace Vapi.JsonConverters
{
    /// <inheritdoc />
    public sealed class TrafficAllocationControllerMetricsGetBucketJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vapi.TrafficAllocationControllerMetricsGetBucket>
    {
        /// <inheritdoc />
        public override global::Vapi.TrafficAllocationControllerMetricsGetBucket Read(
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
                        return global::Vapi.TrafficAllocationControllerMetricsGetBucketExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Vapi.TrafficAllocationControllerMetricsGetBucket)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Vapi.TrafficAllocationControllerMetricsGetBucket);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vapi.TrafficAllocationControllerMetricsGetBucket value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Vapi.TrafficAllocationControllerMetricsGetBucketExtensions.ToValueString(value));
        }
    }
}
