
#nullable enable

namespace Vapi
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RegexReplacement
    {
        /// <summary>
        /// This is the regex replacement type. You can use this to replace a word or phrase that matches a pattern.<br/>
        /// Usage:<br/>
        /// - Replace all numbers with "some number": { type: 'regex', regex: '\\d+', value: 'some number' }<br/>
        /// - Replace email addresses with "[EMAIL]": { type: 'regex', regex: '\\b[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\\.[A-Z|a-z]{2,}\\b', value: '[EMAIL]' }<br/>
        /// - Replace phone numbers with a formatted version: { type: 'regex', regex: '(\\d{3})(\\d{3})(\\d{4})', value: '($1) $2-$3' }<br/>
        /// - Replace all instances of "color" or "colour" with "hue": { type: 'regex', regex: 'colou?r', value: 'hue' }<br/>
        /// - Capitalize the first letter of every sentence: { type: 'regex', regex: '(?&lt;=\\. |^)[a-z]', value: (match) =&gt; match.toUpperCase() }
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.RegexReplacementTypeJsonConverter))]
        public global::Vapi.RegexReplacementType Type { get; set; }

        /// <summary>
        /// This is the regex pattern to replace.<br/>
        /// Note:<br/>
        /// - This works by using the `string.replace` method in Node.JS. Eg. `"hello there".replace(/hello/g, "hi")` will return `"hi there"`.<br/>
        /// Hot tip:<br/>
        /// - In JavaScript, escape `\` when sending the regex pattern. Eg. `"hello\sthere"` will be sent over the wire as `"hellosthere"`. Send `"hello\\sthere"` instead.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("regex")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Regex { get; set; }

        /// <summary>
        /// These are the options for the regex replacement. Defaults to all disabled.<br/>
        /// @default []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("options")]
        public global::System.Collections.Generic.IList<global::Vapi.RegexOption>? Options { get; set; }

        /// <summary>
        /// This is the value that will replace the match.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RegexReplacement" /> class.
        /// </summary>
        /// <param name="type">
        /// This is the regex replacement type. You can use this to replace a word or phrase that matches a pattern.<br/>
        /// Usage:<br/>
        /// - Replace all numbers with "some number": { type: 'regex', regex: '\\d+', value: 'some number' }<br/>
        /// - Replace email addresses with "[EMAIL]": { type: 'regex', regex: '\\b[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\\.[A-Z|a-z]{2,}\\b', value: '[EMAIL]' }<br/>
        /// - Replace phone numbers with a formatted version: { type: 'regex', regex: '(\\d{3})(\\d{3})(\\d{4})', value: '($1) $2-$3' }<br/>
        /// - Replace all instances of "color" or "colour" with "hue": { type: 'regex', regex: 'colou?r', value: 'hue' }<br/>
        /// - Capitalize the first letter of every sentence: { type: 'regex', regex: '(?&lt;=\\. |^)[a-z]', value: (match) =&gt; match.toUpperCase() }
        /// </param>
        /// <param name="regex">
        /// This is the regex pattern to replace.<br/>
        /// Note:<br/>
        /// - This works by using the `string.replace` method in Node.JS. Eg. `"hello there".replace(/hello/g, "hi")` will return `"hi there"`.<br/>
        /// Hot tip:<br/>
        /// - In JavaScript, escape `\` when sending the regex pattern. Eg. `"hello\sthere"` will be sent over the wire as `"hellosthere"`. Send `"hello\\sthere"` instead.
        /// </param>
        /// <param name="options">
        /// These are the options for the regex replacement. Defaults to all disabled.<br/>
        /// @default []
        /// </param>
        /// <param name="value">
        /// This is the value that will replace the match.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RegexReplacement(
            string regex,
            string value,
            global::Vapi.RegexReplacementType type,
            global::System.Collections.Generic.IList<global::Vapi.RegexOption>? options)
        {
            this.Regex = regex ?? throw new global::System.ArgumentNullException(nameof(regex));
            this.Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
            this.Type = type;
            this.Options = options;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RegexReplacement" /> class.
        /// </summary>
        public RegexReplacement()
        {
        }
    }
}