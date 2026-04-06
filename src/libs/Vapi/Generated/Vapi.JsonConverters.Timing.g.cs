#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Vapi.JsonConverters
{
    /// <inheritdoc />
    public class TimingJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vapi.Timing>
    {
        /// <inheritdoc />
        public override global::Vapi.Timing Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            using var __jsonDocument = global::System.Text.Json.JsonDocument.ParseValue(ref reader);
            var __rawJson = __jsonDocument.RootElement.GetRawText();
            var __jsonProps = new global::System.Collections.Generic.HashSet<string>();
            if (__jsonDocument.RootElement.ValueKind == global::System.Text.Json.JsonValueKind.Object)
            {
                foreach (var __jsonProp in __jsonDocument.RootElement.EnumerateObject())
                {
                    __jsonProps.Add(__jsonProp.Name);
                }
            }

            var __score0 = 0;
            if (__jsonProps.Contains("type")) __score0++;
            if (__jsonProps.Contains("words")) __score0++;
            if (__jsonProps.Contains("wordsEndTimesMs")) __score0++;
            if (__jsonProps.Contains("wordsStartTimesMs")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("segment")) __score1++;
            if (__jsonProps.Contains("segmentDurationMs")) __score1++;
            if (__jsonProps.Contains("totalWords")) __score1++;
            if (__jsonProps.Contains("type")) __score1++;
            if (__jsonProps.Contains("words")) __score1++;
            if (__jsonProps.Contains("wordsSpoken")) __score1++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }

            global::Vapi.AssistantSpeechWordAlignmentTiming? wordAlignment = default;
            global::Vapi.AssistantSpeechWordProgressTiming? wordProgress = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.AssistantSpeechWordAlignmentTiming), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.AssistantSpeechWordAlignmentTiming> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vapi.AssistantSpeechWordAlignmentTiming).Name}");
                        wordAlignment = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 1)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.AssistantSpeechWordProgressTiming), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.AssistantSpeechWordProgressTiming> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vapi.AssistantSpeechWordProgressTiming).Name}");
                        wordProgress = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (wordAlignment == null && wordProgress == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.AssistantSpeechWordAlignmentTiming), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.AssistantSpeechWordAlignmentTiming> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vapi.AssistantSpeechWordAlignmentTiming).Name}");
                    wordAlignment = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.AssistantSpeechWordProgressTiming), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.AssistantSpeechWordProgressTiming> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vapi.AssistantSpeechWordProgressTiming).Name}");
                    wordProgress = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Vapi.Timing(
                wordAlignment,

                wordProgress
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vapi.Timing value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsWordAlignment)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.AssistantSpeechWordAlignmentTiming), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.AssistantSpeechWordAlignmentTiming?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vapi.AssistantSpeechWordAlignmentTiming).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.WordAlignment!, typeInfo);
            }
            else if (value.IsWordProgress)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.AssistantSpeechWordProgressTiming), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.AssistantSpeechWordProgressTiming?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vapi.AssistantSpeechWordProgressTiming).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.WordProgress!, typeInfo);
            }
        }
    }
}