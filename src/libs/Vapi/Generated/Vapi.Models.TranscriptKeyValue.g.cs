
#nullable enable

namespace Vapi
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class TranscriptKeyValue
    {
        /// <summary>
        /// This is the value as the answer key writes it. It matches the same words in<br/>
        /// the same order, ignoring case and punctuation, or the value spelled out letter<br/>
        /// by letter ("Maria" matches "M A R I A"). Split into different words, it<br/>
        /// scores near ("HubSpot" heard as "hub spot"), so list such forms in<br/>
        /// acceptedVariants when the value is required.<br/>
        /// Example: lisinopril
        /// </summary>
        /// <example>lisinopril</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Value { get; set; }

        /// <summary>
        /// These are other spellings that count as the same value, such as "Rayner"<br/>
        /// for "Raynor".
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("acceptedVariants")]
        public global::System.Collections.Generic.IList<string>? AcceptedVariants { get; set; }

        /// <summary>
        /// This is whether the simulation fails unless this value comes through<br/>
        /// exactly. Defaults to false: the verdict is reported but does not decide<br/>
        /// pass or fail.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("required")]
        public bool? Required { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TranscriptKeyValue" /> class.
        /// </summary>
        /// <param name="value">
        /// This is the value as the answer key writes it. It matches the same words in<br/>
        /// the same order, ignoring case and punctuation, or the value spelled out letter<br/>
        /// by letter ("Maria" matches "M A R I A"). Split into different words, it<br/>
        /// scores near ("HubSpot" heard as "hub spot"), so list such forms in<br/>
        /// acceptedVariants when the value is required.<br/>
        /// Example: lisinopril
        /// </param>
        /// <param name="acceptedVariants">
        /// These are other spellings that count as the same value, such as "Rayner"<br/>
        /// for "Raynor".
        /// </param>
        /// <param name="required">
        /// This is whether the simulation fails unless this value comes through<br/>
        /// exactly. Defaults to false: the verdict is reported but does not decide<br/>
        /// pass or fail.<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TranscriptKeyValue(
            string value,
            global::System.Collections.Generic.IList<string>? acceptedVariants,
            bool? required)
        {
            this.Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
            this.AcceptedVariants = acceptedVariants;
            this.Required = required;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TranscriptKeyValue" /> class.
        /// </summary>
        public TranscriptKeyValue()
        {
        }

    }
}