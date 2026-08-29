
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace Vapi
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class JsonSerializerContextTypes
    {
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? StringStringDictionary { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, object>? StringObjectDictionary { get; set; }

        /// <summary>
        /// Runtime object lists used by dynamic JSON payloads such as tool arguments.
        /// </summary>
        public global::System.Collections.Generic.List<object>? ObjectList { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Text.Json.JsonElement? JsonElement { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackTranscriberPlan? Type0 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackAssemblyAITranscriber? Type1 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackAzureSpeechTranscriber? Type2 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackCustomTranscriber? Type3 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackDeepgramTranscriber? Type4 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackElevenLabsTranscriber? Type5 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackGladiaTranscriber? Type6 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackGoogleTranscriber? Type7 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackTalkscriberTranscriber? Type8 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackSpeechmaticsTranscriber? Type9 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackOpenAITranscriber? Type10 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackCartesiaTranscriber? Type11 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackSonioxTranscriber? Type12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackXaiTranscriber? Type13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AssemblyAITranscriber? Type14 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AssemblyAITranscriberProvider? Type15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AssemblyAITranscriberLanguage? Type16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public double? Type17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public bool? Type18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AssemblyAITranscriberMode? Type19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public string? Type20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.AssemblyAITranscriberLanguageCode>? Type21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AssemblyAITranscriberLanguageCode? Type22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AssemblyAITranscriberSpeechModel? Type23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<string>? Type24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AzureSpeechTranscriber? Type25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AzureSpeechTranscriberProvider? Type26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AzureSpeechTranscriberLanguage? Type27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AzureSpeechTranscriberSegmentationStrategy? Type28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CartesiaTranscriber? Type29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CartesiaTranscriberProvider? Type30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CartesiaTranscriberModel? Type31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CartesiaTranscriberLanguage? Type32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.BackoffPlan? Type33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public object? Type34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<object>? Type35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.Server? Type36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CustomTranscriber? Type37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CustomTranscriberProvider? Type38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.DeepgramTranscriber? Type39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.DeepgramTranscriberProvider? Type40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OneOf<global::Vapi.DeepgramTranscriberModel?, string>? Type41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.DeepgramTranscriberModel? Type42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.DeepgramTranscriberLanguage? Type43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.DeepgramTranscriberRedactionItem>? Type44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.DeepgramTranscriberRedactionItem? Type45 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ElevenLabsTranscriber? Type46 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ElevenLabsTranscriberProvider? Type47 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ElevenLabsTranscriberModel? Type48 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ElevenLabsTranscriberLanguage? Type49 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GladiaCustomVocabularyConfigDTO? Type50 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.OneOf<string, global::Vapi.GladiaVocabularyItemDTO>>? Type51 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OneOf<string, global::Vapi.GladiaVocabularyItemDTO>? Type52 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GladiaVocabularyItemDTO? Type53 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GladiaTranscriber? Type54 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GladiaTranscriberProvider? Type55 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GladiaTranscriberModel? Type56 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GladiaTranscriberLanguageBehaviour? Type57 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GladiaTranscriberLanguage? Type58 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.GladiaTranscriberLanguage2>? Type59 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GladiaTranscriberLanguage2? Type60 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GladiaTranscriberRegion? Type61 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SonioxContextGeneralItem? Type62 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SonioxTranscriber? Type63 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SonioxTranscriberProvider? Type64 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SonioxTranscriberModel? Type65 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SonioxTranscriberLanguage? Type66 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.SonioxTranscriberLanguage2>? Type67 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SonioxTranscriberLanguage2? Type68 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.SonioxContextGeneralItem>? Type69 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SpeechmaticsCustomVocabularyItem? Type70 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SpeechmaticsTranscriber? Type71 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SpeechmaticsTranscriberProvider? Type72 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SpeechmaticsTranscriberModel? Type73 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SpeechmaticsTranscriberLanguage? Type74 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SpeechmaticsTranscriberOperatingPoint? Type75 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SpeechmaticsTranscriberRegion? Type76 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.SpeechmaticsCustomVocabularyItem>? Type77 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SpeechmaticsTranscriberNumeralStyle? Type78 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TalkscriberTranscriber? Type79 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TalkscriberTranscriberProvider? Type80 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TalkscriberTranscriberModel? Type81 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TalkscriberTranscriberLanguage? Type82 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GoogleTranscriber? Type83 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GoogleTranscriberProvider? Type84 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GoogleTranscriberModel? Type85 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GoogleTranscriberLanguage? Type86 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OpenAITranscriber? Type87 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OpenAITranscriberProvider? Type88 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OpenAITranscriberModel? Type89 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OpenAITranscriberLanguage? Type90 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.XaiTranscriber? Type91 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.XaiTranscriberProvider? Type92 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.XaiTranscriberModel? Type93 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.XaiTranscriberLanguage? Type94 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.VapiTranscriber? Type95 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.VapiTranscriberProvider? Type96 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.VapiTranscriberVersion? Type97 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.VapiTranscriberLanguage? Type98 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.VapiTranscriberLanguage2>? Type99 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.VapiTranscriberLanguage2? Type100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.VapiTranscriberTurnTaking? Type101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackAssemblyAITranscriberProvider? Type102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackAssemblyAITranscriberLanguage? Type103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackAssemblyAITranscriberMode? Type104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.FallbackAssemblyAITranscriberLanguageCode>? Type105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackAssemblyAITranscriberLanguageCode? Type106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackAssemblyAITranscriberSpeechModel? Type107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackAzureSpeechTranscriberProvider? Type108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackAzureSpeechTranscriberLanguage? Type109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackAzureSpeechTranscriberSegmentationStrategy? Type110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackCartesiaTranscriberProvider? Type111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackCartesiaTranscriberModel? Type112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackCartesiaTranscriberLanguage? Type113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackCustomTranscriberProvider? Type114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackDeepgramTranscriberProvider? Type115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OneOf<global::Vapi.FallbackDeepgramTranscriberModel?, string>? Type116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackDeepgramTranscriberModel? Type117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackDeepgramTranscriberLanguage? Type118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.FallbackDeepgramTranscriberRedactionItem>? Type119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackDeepgramTranscriberRedactionItem? Type120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackElevenLabsTranscriberProvider? Type121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackElevenLabsTranscriberModel? Type122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackElevenLabsTranscriberLanguage? Type123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackGladiaTranscriberProvider? Type124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackGladiaTranscriberModel? Type125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackGladiaTranscriberLanguageBehaviour? Type126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackGladiaTranscriberLanguage? Type127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.FallbackGladiaTranscriberLanguage2>? Type128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackGladiaTranscriberLanguage2? Type129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackGladiaTranscriberRegion? Type130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackSonioxTranscriberProvider? Type131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackSonioxTranscriberModel? Type132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackSonioxTranscriberLanguage? Type133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.FallbackSonioxTranscriberLanguage2>? Type134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackSonioxTranscriberLanguage2? Type135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackSpeechmaticsTranscriberProvider? Type136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackSpeechmaticsTranscriberModel? Type137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackSpeechmaticsTranscriberLanguage? Type138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackSpeechmaticsTranscriberOperatingPoint? Type139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackSpeechmaticsTranscriberRegion? Type140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackSpeechmaticsTranscriberNumeralStyle? Type141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackTalkscriberTranscriberProvider? Type142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackTalkscriberTranscriberModel? Type143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackTalkscriberTranscriberLanguage? Type144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackGoogleTranscriberProvider? Type145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackGoogleTranscriberModel? Type146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackGoogleTranscriberLanguage? Type147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackOpenAITranscriberProvider? Type148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackOpenAITranscriberModel? Type149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackOpenAITranscriberLanguage? Type150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackXaiTranscriberProvider? Type151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackXaiTranscriberModel? Type152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackXaiTranscriberLanguage? Type153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.LangfuseObservabilityPlan? Type154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.LangfuseObservabilityPlanProvider? Type155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TextContent? Type156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TextContentType? Type157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TextContentLanguage? Type158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.Condition? Type159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ConditionOperator? Type160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ToolMessageStart? Type161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.TextContent>? Type162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ToolMessageStartType? Type163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.Condition>? Type164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ToolMessageComplete? Type165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ToolMessageCompleteType? Type166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ToolMessageCompleteRole? Type167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ToolMessageFailed? Type168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ToolMessageFailedType? Type169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ToolMessageFailedRole? Type170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ToolMessageDelayed? Type171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ToolMessageDelayedType? Type172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.MessageTarget? Type173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.MessageTargetRole? Type174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.RegexCondition? Type175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.RegexConditionType? Type176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.LiquidCondition? Type177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.LiquidConditionType? Type178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GroupCondition? Type179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GroupConditionType? Type180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GroupConditionOperator? Type181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.OneOf<global::Vapi.RegexCondition, global::Vapi.LiquidCondition, global::Vapi.GroupCondition>>? Type182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OneOf<global::Vapi.RegexCondition, global::Vapi.LiquidCondition, global::Vapi.GroupCondition>? Type183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ToolRejectionPlan? Type184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateDtmfToolDTO? Type185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.OneOf<global::Vapi.ToolMessageStart, global::Vapi.ToolMessageComplete, global::Vapi.ToolMessageFailed, global::Vapi.ToolMessageDelayed>>? Type186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OneOf<global::Vapi.ToolMessageStart, global::Vapi.ToolMessageComplete, global::Vapi.ToolMessageFailed, global::Vapi.ToolMessageDelayed>? Type187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateDtmfToolDTOType? Type188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateEndCallToolDTO? Type189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateEndCallToolDTOType? Type190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateVoicemailToolDTO? Type191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateVoicemailToolDTOType? Type192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.JsonSchema? Type193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.JsonSchemaType? Type194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Vapi.JsonSchema>? Type195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.JsonSchemaFormat? Type196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.VariableExtractionAlias? Type197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.VariableExtractionPlan? Type198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.VariableExtractionAlias>? Type199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ToolParameter? Type200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OneOf<string, double?, bool?, object, byte[]>? Type201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public byte[]? Type202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OpenAIFunctionParameters? Type203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OpenAIFunctionParametersType? Type204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OpenAIFunction? Type205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateFunctionToolDTO? Type206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateFunctionToolDTOType? Type207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.ToolParameter>? Type208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GhlToolMetadata? Type209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateGhlToolDTO? Type210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateGhlToolDTOType? Type211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.MakeToolMetadata? Type212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateMakeToolDTO? Type213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateMakeToolDTOType? Type214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CustomMessage? Type215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CustomMessageType? Type216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TransferDestinationAssistant? Type217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OneOf<string, global::Vapi.CustomMessage>? Type218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TransferDestinationAssistantType? Type219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TransferDestinationAssistantTransferMode? Type220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TransferFallbackPlan? Type221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TransferAssistantModel? Type222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TransferAssistantModelProvider? Type223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.RegexOption? Type224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.RegexOptionType? Type225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AssistantCustomEndpointingRule? Type226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AssistantCustomEndpointingRuleType? Type227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.RegexOption>? Type228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CustomerCustomEndpointingRule? Type229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CustomerCustomEndpointingRuleType? Type230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.BothCustomEndpointingRule? Type231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.BothCustomEndpointingRuleType? Type232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.VapiSmartEndpointingPlan? Type233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.VapiSmartEndpointingPlanProvider? Type234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.LivekitSmartEndpointingPlan? Type235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.LivekitSmartEndpointingPlanProvider? Type236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CustomEndpointingModelSmartEndpointingPlan? Type237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CustomEndpointingModelSmartEndpointingPlanProvider? Type238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TranscriptionEndpointingPlan? Type239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.StartSpeakingPlan? Type240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OneOf<bool?, global::Vapi.StartSpeakingPlanSmartEndpointingEnabled?>? Type241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.StartSpeakingPlanSmartEndpointingEnabled? Type242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OneOf<global::Vapi.VapiSmartEndpointingPlan, global::Vapi.LivekitSmartEndpointingPlan, global::Vapi.CustomEndpointingModelSmartEndpointingPlan>? Type243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.OneOf<global::Vapi.AssistantCustomEndpointingRule, global::Vapi.CustomerCustomEndpointingRule, global::Vapi.BothCustomEndpointingRule>>? Type244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OneOf<global::Vapi.AssistantCustomEndpointingRule, global::Vapi.CustomerCustomEndpointingRule, global::Vapi.BothCustomEndpointingRule>? Type245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SmartDenoisingPlan? Type246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FourierDenoisingPlan? Type247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.BackgroundSpeechDenoisingPlan? Type248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TransferAssistant? Type249 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AzureVoice? Type250 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CartesiaVoice? Type251 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CustomVoice? Type252 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.DeepgramVoice? Type253 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ElevenLabsVoice? Type254 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.HumeVoice? Type255 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.LMNTVoice? Type256 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.NeuphonicVoice? Type257 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OpenAIVoice? Type258 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.PlayHTVoice? Type259 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.WellSaidVoice? Type260 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.RimeAIVoice? Type261 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SmallestAIVoice? Type262 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TavusVoice? Type263 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.VapiVoice? Type264 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SesameVoice? Type265 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.InworldVoice? Type266 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.MinimaxVoice? Type267 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.XaiVoice? Type268 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.MicrosoftVoice? Type269 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OneOf<global::Vapi.TransferAssistantBackgroundSound?, string>? Type270 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TransferAssistantBackgroundSound? Type271 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TransferAssistantFirstMessageMode? Type272 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TransferCancelToolUserEditable? Type273 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TransferCancelToolUserEditableType? Type274 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TransferSuccessfulToolUserEditable? Type275 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TransferSuccessfulToolUserEditableType? Type276 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SummaryPlan? Type277 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TransferPlan? Type278 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TransferPlanMode? Type279 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OneOf<global::Vapi.ContextEngineeringPlanLastNMessages, global::Vapi.ContextEngineeringPlanNone, global::Vapi.ContextEngineeringPlanAll>? Type280 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ContextEngineeringPlanLastNMessages? Type281 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ContextEngineeringPlanNone? Type282 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ContextEngineeringPlanAll? Type283 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TransferDestinationNumber? Type284 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TransferDestinationNumberType? Type285 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TransferDestinationSip? Type286 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TransferDestinationSipType? Type287 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateTransferCallToolDTO? Type288 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateTransferCallToolDTOType? Type289 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.OneOf<global::Vapi.TransferDestinationAssistant, global::Vapi.TransferDestinationNumber, global::Vapi.TransferDestinationSip>>? Type290 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OneOf<global::Vapi.TransferDestinationAssistant, global::Vapi.TransferDestinationNumber, global::Vapi.TransferDestinationSip>? Type291 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ContextEngineeringPlanLastNMessagesType? Type292 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ContextEngineeringPlanNoneType? Type293 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ContextEngineeringPlanAllType? Type294 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ContextEngineeringPlanUserAndAssistantMessages? Type295 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ContextEngineeringPlanUserAndAssistantMessagesType? Type296 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ContextEngineeringPlanPreviousAssistantMessages? Type297 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ContextEngineeringPlanPreviousAssistantMessagesType? Type298 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.HandoffDestinationAssistant? Type299 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.HandoffDestinationAssistantType? Type300 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateAssistantDTO? Type301 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AssistantOverrides? Type302 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.HandoffDestinationDynamic? Type303 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.HandoffDestinationDynamicType? Type304 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SquadMemberDTO? Type305 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.OneOf<global::Vapi.TransferDestinationAssistant, global::Vapi.HandoffDestinationAssistant>>? Type306 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OneOf<global::Vapi.TransferDestinationAssistant, global::Vapi.HandoffDestinationAssistant>? Type307 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateSquadDTO? Type308 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.SquadMemberDTO>? Type309 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.HandoffDestinationSquad? Type310 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.HandoffDestinationSquadType? Type311 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateHandoffToolDTO? Type312 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateHandoffToolDTOType? Type313 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.OneOf<global::Vapi.HandoffDestinationAssistant, global::Vapi.HandoffDestinationDynamic, global::Vapi.HandoffDestinationSquad>>? Type314 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OneOf<global::Vapi.HandoffDestinationAssistant, global::Vapi.HandoffDestinationDynamic, global::Vapi.HandoffDestinationSquad>? Type315 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateCustomKnowledgeBaseDTO? Type316 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateCustomKnowledgeBaseDTOProvider? Type317 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.KnowledgeBase? Type318 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.KnowledgeBaseProvider? Type319 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.KnowledgeBaseModel? Type320 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateQueryToolDTO? Type321 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateQueryToolDTOType? Type322 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.KnowledgeBase>? Type323 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateGoogleCalendarCreateEventToolDTO? Type324 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateGoogleCalendarCreateEventToolDTOType? Type325 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateGoogleSheetsRowAppendToolDTO? Type326 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateGoogleSheetsRowAppendToolDTOType? Type327 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateGoogleCalendarCheckAvailabilityToolDTO? Type328 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateGoogleCalendarCheckAvailabilityToolDTOType? Type329 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateSlackSendMessageToolDTO? Type330 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateSlackSendMessageToolDTOType? Type331 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.McpToolMessages? Type332 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.McpToolMetadata? Type333 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.McpToolMetadataProtocol? Type334 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateMcpToolDTO? Type335 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateMcpToolDTOType? Type336 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.McpToolMessages>? Type337 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateGoHighLevelCalendarAvailabilityToolDTO? Type338 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateGoHighLevelCalendarAvailabilityToolDTOType? Type339 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateGoHighLevelCalendarEventCreateToolDTO? Type340 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateGoHighLevelCalendarEventCreateToolDTOType? Type341 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateGoHighLevelContactCreateToolDTO? Type342 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateGoHighLevelContactCreateToolDTOType? Type343 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateGoHighLevelContactGetToolDTO? Type344 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateGoHighLevelContactGetToolDTOType? Type345 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OpenAIMessage? Type346 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OpenAIMessageRole? Type347 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ToolRef? Type348 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Guid? Type349 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AnyscaleModel? Type350 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.OpenAIMessage>? Type351 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateApiRequestToolDTO? Type352 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateBashToolDTO? Type353 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateCodeToolDTO? Type354 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateComputerToolDTO? Type355 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateSmsToolDTO? Type356 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateTextEditorToolDTO? Type357 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateSipRequestToolDTO? Type358 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.ToolRef>? Type359 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AnyscaleModelProvider? Type360 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AnthropicThinkingConfig? Type361 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AnthropicThinkingConfigType? Type362 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AnthropicModel? Type363 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AnthropicModelModel? Type364 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AnthropicModelProvider? Type365 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AnthropicBedrockModel? Type366 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AnthropicBedrockModelProvider? Type367 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AnthropicBedrockModelModel? Type368 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CerebrasModel? Type369 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CerebrasModelModel? Type370 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CerebrasModelProvider? Type371 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CustomLLMModel? Type372 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CustomLLMModelProvider? Type373 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CustomLLMModelMetadataSendMode? Type374 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? Type375 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.DeepInfraModel? Type376 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.DeepInfraModelProvider? Type377 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.DeepSeekModel? Type378 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.DeepSeekModelModel? Type379 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.DeepSeekModelProvider? Type380 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GeminiMultimodalLivePrebuiltVoiceConfig? Type381 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GeminiMultimodalLivePrebuiltVoiceConfigVoiceName? Type382 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GeminiMultimodalLiveVoiceConfig? Type383 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GeminiMultimodalLiveSpeechConfig? Type384 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GoogleRealtimeConfig? Type385 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GoogleModel? Type386 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GoogleModelModel? Type387 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GoogleModelProvider? Type388 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GroqModel? Type389 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GroqModelModel? Type390 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GroqModelProvider? Type391 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.InflectionAIModel? Type392 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.InflectionAIModelModel? Type393 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.InflectionAIModelProvider? Type394 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.MinimaxLLMModel? Type395 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.MinimaxLLMModelProvider? Type396 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.MinimaxLLMModelModel? Type397 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OpenAIModel? Type398 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OpenAIModelProvider? Type399 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OpenAIModelModel? Type400 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.OpenAIModelFallbackModel>? Type401 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OpenAIModelFallbackModel? Type402 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OpenAIModelToolStrictCompatibilityMode? Type403 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OpenAIModelPromptCacheRetention? Type404 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OpenAIModelReasoningEffort? Type405 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OpenRouterModel? Type406 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OpenRouterModelProvider? Type407 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.PerplexityAIModel? Type408 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.PerplexityAIModelProvider? Type409 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TogetherAIModel? Type410 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TogetherAIModelProvider? Type411 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.HangupNode? Type412 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.HangupNodeType? Type413 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.WorkflowOpenAIModel? Type414 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.WorkflowOpenAIModelProvider? Type415 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.WorkflowOpenAIModelModel? Type416 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.WorkflowAnthropicModel? Type417 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.WorkflowAnthropicModelProvider? Type418 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.WorkflowAnthropicModelModel? Type419 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.WorkflowAnthropicBedrockModel? Type420 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.WorkflowAnthropicBedrockModelProvider? Type421 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.WorkflowAnthropicBedrockModelModel? Type422 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.WorkflowGoogleModel? Type423 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.WorkflowGoogleModelProvider? Type424 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.WorkflowGoogleModelModel? Type425 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.WorkflowCustomModel? Type426 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.WorkflowCustomModelProvider? Type427 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.WorkflowCustomModelMetadataSendMode? Type428 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GlobalNodePlan? Type429 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ConversationNode? Type430 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ConversationNodeType? Type431 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ToolNode? Type432 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ToolNodeType? Type433 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.VoicemailDetectionBackoffPlan? Type434 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GoogleVoicemailDetectionPlan? Type435 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GoogleVoicemailDetectionPlanProvider? Type436 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GoogleVoicemailDetectionPlanType? Type437 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OpenAIVoicemailDetectionPlan? Type438 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OpenAIVoicemailDetectionPlanProvider? Type439 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OpenAIVoicemailDetectionPlanType? Type440 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TwilioVoicemailDetectionPlan? Type441 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TwilioVoicemailDetectionPlanProvider? Type442 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.TwilioVoicemailDetectionPlanVoicemailDetectionType>? Type443 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TwilioVoicemailDetectionPlanVoicemailDetectionType? Type444 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.VapiVoicemailDetectionPlan? Type445 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.VapiVoicemailDetectionPlanProvider? Type446 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.VapiVoicemailDetectionPlanType? Type447 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TransferHookAction? Type448 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TransferHookActionType? Type449 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OneOf<global::Vapi.TransferDestinationNumber, global::Vapi.TransferDestinationSip>? Type450 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FunctionCallHookAction? Type451 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FunctionCallHookActionType? Type452 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SayHookAction? Type453 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SayHookActionType? Type454 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OneOf<string, global::System.Collections.Generic.IList<string>>? Type455 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OneOf<string, global::System.Collections.Generic.IList<global::Vapi.OneOf<global::Vapi.SystemMessage, global::Vapi.UserMessage, global::Vapi.AssistantMessage, global::Vapi.ToolMessage, global::Vapi.DeveloperMessage>>>? Type456 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.OneOf<global::Vapi.SystemMessage, global::Vapi.UserMessage, global::Vapi.AssistantMessage, global::Vapi.ToolMessage, global::Vapi.DeveloperMessage>>? Type457 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OneOf<global::Vapi.SystemMessage, global::Vapi.UserMessage, global::Vapi.AssistantMessage, global::Vapi.ToolMessage, global::Vapi.DeveloperMessage>? Type458 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SystemMessage? Type459 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UserMessage? Type460 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AssistantMessage? Type461 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ToolMessage? Type462 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.DeveloperMessage? Type463 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.MessageAddHookAction? Type464 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.MessageAddHookActionType? Type465 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CallHookFilter? Type466 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CallHookFilterType? Type467 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CallHookCallEnding? Type468 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CallHookCallEndingOn? Type469 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.OneOf<global::Vapi.ToolCallHookAction, global::Vapi.MessageAddHookAction>>? Type470 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OneOf<global::Vapi.ToolCallHookAction, global::Vapi.MessageAddHookAction>? Type471 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ToolCallHookAction? Type472 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.CallHookFilter>? Type473 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CallHookAssistantSpeechInterrupted? Type474 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CallHookAssistantSpeechInterruptedOn? Type475 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.OneOf<global::Vapi.SayHookAction, global::Vapi.ToolCallHookAction, global::Vapi.MessageAddHookAction>>? Type476 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OneOf<global::Vapi.SayHookAction, global::Vapi.ToolCallHookAction, global::Vapi.MessageAddHookAction>? Type477 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CallHookCustomerSpeechInterrupted? Type478 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CallHookCustomerSpeechInterruptedOn? Type479 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ToolCallHookActionType? Type480 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CustomerSpeechTimeoutOptions? Type481 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CustomerSpeechTimeoutOptionsTriggerResetMode? Type482 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CallHookCustomerSpeechTimeout? Type483 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CallHookModelResponseTimeout? Type484 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CallHookModelResponseTimeoutOn? Type485 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AIEdgeCondition? Type486 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AIEdgeConditionType? Type487 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.Edge? Type488 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.RecordingConsentPlanStayOnLine? Type489 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.RecordingConsentPlanStayOnLineFirstMessageMode? Type490 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.RecordingConsentPlanStayOnLineType? Type491 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.RecordingConsentPlanVerbal? Type492 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.RecordingConsentPlanVerbalFirstMessageMode? Type493 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.RecordingConsentPlanVerbalType? Type494 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SecurityFilterBase? Type495 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SecurityFilterPlan? Type496 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.SecurityFilterBase>? Type497 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SecurityFilterPlanMode? Type498 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CompliancePlan? Type499 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.RecordingConsentPlan? Type500 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CompliancePlanRecordingConsentPlanDiscriminator? Type501 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CompliancePlanRecordingConsentPlanDiscriminatorType? Type502 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.StructuredDataPlan? Type503 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.StructuredDataMultiPlan? Type504 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SuccessEvaluationPlan? Type505 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SuccessEvaluationPlanRubric? Type506 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AnalysisPlan? Type507 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.StructuredDataMultiPlan>? Type508 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TranscriptPlan? Type509 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.MinMessagesCondition? Type510 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.MinMessagesConditionType? Type511 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.MinCallDurationCondition? Type512 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.MinCallDurationConditionType? Type513 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.EndedReasonCondition? Type514 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.EndedReasonConditionType? Type515 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.EndedReasonConditionOperator? Type516 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ComplianceOverride? Type517 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateStructuredOutputDTO? Type518 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateStructuredOutputDTOType? Type519 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.OneOf<global::Vapi.MinMessagesCondition, global::Vapi.MinCallDurationCondition, global::Vapi.EndedReasonCondition>>? Type520 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OneOf<global::Vapi.MinMessagesCondition, global::Vapi.MinCallDurationCondition, global::Vapi.EndedReasonCondition>? Type521 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.NumberComparatorScorecardMetricCondition? Type522 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.NumberComparatorScorecardMetricConditionType? Type523 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.NumberComparatorScorecardMetricConditionComparator? Type524 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.BooleanComparatorScorecardMetricCondition? Type525 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.BooleanComparatorScorecardMetricConditionType? Type526 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.BooleanComparatorScorecardMetricConditionComparator? Type527 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ScorecardMetric? Type528 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.OneOf<global::Vapi.NumberComparatorScorecardMetricCondition, global::Vapi.BooleanComparatorScorecardMetricCondition>>? Type529 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OneOf<global::Vapi.NumberComparatorScorecardMetricCondition, global::Vapi.BooleanComparatorScorecardMetricCondition>? Type530 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateScorecardDTO? Type531 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.ScorecardMetric>? Type532 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ArtifactPlan? Type533 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ArtifactPlanRecordingFormat? Type534 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.CreateStructuredOutputDTO>? Type535 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.CreateScorecardDTO>? Type536 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.StopSpeakingPlan? Type537 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.MonitorPlan? Type538 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.KeypadInputPlan? Type539 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.KeypadInputPlanDelimiters? Type540 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.WorkflowUserEditable? Type541 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.OneOf<global::Vapi.ConversationNode, global::Vapi.ToolNode>>? Type542 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OneOf<global::Vapi.ConversationNode, global::Vapi.ToolNode>? Type543 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OneOf<global::Vapi.WorkflowUserEditableBackgroundSound?, string>? Type544 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.WorkflowUserEditableBackgroundSound? Type545 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.CredentialsItem>? Type546 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CredentialsItem? Type547 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateAnthropicCredentialDTO? Type548 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateAnthropicBedrockCredentialDTO? Type549 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateAnyscaleCredentialDTO? Type550 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateAssemblyAICredentialDTO? Type551 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateAzureCredentialDTO? Type552 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateAzureOpenAICredentialDTO? Type553 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateByoSipTrunkCredentialDTO? Type554 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateCartesiaCredentialDTO? Type555 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateCerebrasCredentialDTO? Type556 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateCloudflareCredentialDTO? Type557 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateCustomLLMCredentialDTO? Type558 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateDeepgramCredentialDTO? Type559 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateDeepInfraCredentialDTO? Type560 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateDeepSeekCredentialDTO? Type561 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateElevenLabsCredentialDTO? Type562 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateGcpCredentialDTO? Type563 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateGladiaCredentialDTO? Type564 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateGoHighLevelCredentialDTO? Type565 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateGoogleCredentialDTO? Type566 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateGroqCredentialDTO? Type567 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateHumeCredentialDTO? Type568 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateInflectionAICredentialDTO? Type569 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateLangfuseCredentialDTO? Type570 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateLmntCredentialDTO? Type571 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateMakeCredentialDTO? Type572 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateMistralCredentialDTO? Type573 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateNeuphonicCredentialDTO? Type574 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateOpenAICredentialDTO? Type575 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateOpenRouterCredentialDTO? Type576 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreatePerplexityAICredentialDTO? Type577 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreatePlayHTCredentialDTO? Type578 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateRimeAICredentialDTO? Type579 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateRunpodCredentialDTO? Type580 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateS3CredentialDTO? Type581 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateS3CompatibleCredentialDTO? Type582 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateSmallestAICredentialDTO? Type583 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateSpeechmaticsCredentialDTO? Type584 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateSonioxCredentialDTO? Type585 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateSupabaseCredentialDTO? Type586 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateTavusCredentialDTO? Type587 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateTogetherAICredentialDTO? Type588 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateTwilioCredentialDTO? Type589 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateVonageCredentialDTO? Type590 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateWebhookCredentialDTO? Type591 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateCustomCredentialDTO? Type592 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateXAiCredentialDTO? Type593 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateMicrosoftCredentialDTO? Type594 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateGoogleCalendarOAuth2ClientCredentialDTO? Type595 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateGoogleCalendarOAuth2AuthorizationCredentialDTO? Type596 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateGoogleSheetsOAuth2AuthorizationCredentialDTO? Type597 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateSlackOAuth2AuthorizationCredentialDTO? Type598 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateGoHighLevelMCPCredentialDTO? Type599 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateInworldCredentialDTO? Type600 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateMinimaxCredentialDTO? Type601 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateWellSaidCredentialDTO? Type602 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateEmailCredentialDTO? Type603 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateSlackWebhookCredentialDTO? Type604 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.WorkflowUserEditableCredentialDiscriminator? Type605 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.WorkflowUserEditableCredentialDiscriminatorProvider? Type606 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.WorkflowUserEditableVoicemailDetection? Type607 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.Edge>? Type608 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.VapiModel? Type609 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.VapiModelVersion? Type610 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.VapiModelProvider? Type611 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.XaiModel? Type612 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.XaiModelModel? Type613 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.XaiModelProvider? Type614 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ExactReplacement? Type615 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ExactReplacementType? Type616 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.RegexReplacement? Type617 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.RegexReplacementType? Type618 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FormatPlan? Type619 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.OneOf<global::Vapi.ExactReplacement, global::Vapi.RegexReplacement>>? Type620 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OneOf<global::Vapi.ExactReplacement, global::Vapi.RegexReplacement>? Type621 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.FormatPlanFormattersEnabledItem>? Type622 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FormatPlanFormattersEnabledItem? Type623 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ChunkPlan? Type624 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.ChunkPlanPunctuationBoundarie>? Type625 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ChunkPlanPunctuationBoundarie? Type626 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackPlan? Type627 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackAzureVoice? Type628 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackCartesiaVoice? Type629 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackHumeVoice? Type630 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackCustomVoice? Type631 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackDeepgramVoice? Type632 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackElevenLabsVoice? Type633 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackVapiVoice? Type634 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackLMNTVoice? Type635 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackOpenAIVoice? Type636 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackPlayHTVoice? Type637 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackWellSaidVoice? Type638 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackRimeAIVoice? Type639 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackSmallestAIVoice? Type640 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackTavusVoice? Type641 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackNeuphonicVoice? Type642 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackSesameVoice? Type643 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackInworldVoice? Type644 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackXaiVoice? Type645 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackMicrosoftVoice? Type646 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AzureVoiceProvider? Type647 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OneOf<global::Vapi.AzureVoiceVoiceId?, string>? Type648 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AzureVoiceVoiceId? Type649 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CartesiaExperimentalControls? Type650 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OneOf<global::Vapi.CartesiaExperimentalControlsSpeed?, double?>? Type651 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CartesiaExperimentalControlsSpeed? Type652 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CartesiaExperimentalControlsEmotion? Type653 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CartesiaGenerationConfigExperimental? Type654 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public int? Type655 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CartesiaGenerationConfig? Type656 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CartesiaVoiceProvider? Type657 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CartesiaVoiceModel? Type658 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CartesiaVoiceLanguage? Type659 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CustomVoiceProvider? Type660 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.DeepgramVoiceProvider? Type661 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.DeepgramVoiceVoiceId? Type662 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.DeepgramVoiceModel? Type663 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ElevenLabsPronunciationDictionaryLocator? Type664 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ElevenLabsVoiceProvider? Type665 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OneOf<global::Vapi.ElevenLabsVoiceVoiceId?, string>? Type666 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ElevenLabsVoiceVoiceId? Type667 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ElevenLabsVoiceModel? Type668 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.ElevenLabsPronunciationDictionaryLocator>? Type669 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.WellSaidVoiceProvider? Type670 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.WellSaidVoiceModel? Type671 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.HumeVoiceProvider? Type672 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.HumeVoiceModel? Type673 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.LMNTVoiceProvider? Type674 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OneOf<global::Vapi.LMNTVoiceVoiceId?, string>? Type675 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.LMNTVoiceVoiceId? Type676 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.LMNTVoiceLanguage? Type677 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.NeuphonicVoiceProvider? Type678 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.NeuphonicVoiceModel? Type679 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OpenAIVoiceProvider? Type680 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OneOf<global::Vapi.OpenAIVoiceVoiceId?, string>? Type681 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OpenAIVoiceVoiceId? Type682 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OpenAIVoiceModel? Type683 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.PlayHTVoiceProvider? Type684 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OneOf<global::Vapi.PlayHTVoiceVoiceId?, string>? Type685 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.PlayHTVoiceVoiceId? Type686 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.PlayHTVoiceEmotion? Type687 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.PlayHTVoiceModel? Type688 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.PlayHTVoiceLanguage? Type689 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.RimeAIVoiceProvider? Type690 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OneOf<global::Vapi.RimeAIVoiceVoiceId?, string>? Type691 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.RimeAIVoiceVoiceId? Type692 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.RimeAIVoiceModel? Type693 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.RimeAIVoiceLanguage? Type694 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SesameVoiceProvider? Type695 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SesameVoiceModel? Type696 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SmallestAIVoiceProvider? Type697 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OneOf<global::Vapi.SmallestAIVoiceVoiceId?, string>? Type698 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SmallestAIVoiceVoiceId? Type699 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SmallestAIVoiceModel? Type700 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TavusConversationProperties? Type701 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TavusVoiceProvider? Type702 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OneOf<global::Vapi.TavusVoiceVoiceId?, string>? Type703 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TavusVoiceVoiceId? Type704 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.VapiPronunciationDictionaryLocator? Type705 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.VapiPronunciationDictionaryLocatorProvider? Type706 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.VapiVoiceProvider? Type707 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OneOf<global::Vapi.VapiVoiceVersion2?, double?>? Type708 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.VapiVoiceVersion2? Type709 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.VapiVoiceLanguage? Type710 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.VapiPronunciationDictionaryLocator>? Type711 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.InworldVoiceProvider? Type712 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.InworldVoiceVoiceId? Type713 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.InworldVoiceModel? Type714 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.InworldVoiceLanguageCode? Type715 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.MinimaxVoiceProvider? Type716 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.MinimaxVoiceModel? Type717 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.MinimaxVoiceSubtitleType? Type718 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.MinimaxVoiceRegion? Type719 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.MinimaxVoiceLanguageBoost? Type720 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackMinimaxVoice? Type721 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackMinimaxVoiceProvider? Type722 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackMinimaxVoiceModel? Type723 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackMinimaxVoiceSubtitleType? Type724 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackMinimaxVoiceRegion? Type725 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackMinimaxVoiceLanguageBoost? Type726 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackWellSaidVoiceProvider? Type727 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackWellSaidVoiceModel? Type728 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.XaiVoiceProvider? Type729 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.XaiVoiceVoiceId? Type730 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.XaiVoiceLanguage? Type731 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.MicrosoftVoiceProvider? Type732 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.MicrosoftVoiceVoiceId? Type733 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.MicrosoftVoiceStyle? Type734 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.MicrosoftVoiceRole? Type735 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackAzureVoiceProvider? Type736 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OneOf<global::Vapi.FallbackAzureVoiceVoiceId?, string>? Type737 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackAzureVoiceVoiceId? Type738 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackCartesiaVoiceProvider? Type739 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackCartesiaVoiceModel? Type740 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackCartesiaVoiceLanguage? Type741 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackCustomVoiceProvider? Type742 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackDeepgramVoiceProvider? Type743 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackDeepgramVoiceVoiceId? Type744 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackDeepgramVoiceModel? Type745 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackElevenLabsVoiceProvider? Type746 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OneOf<global::Vapi.FallbackElevenLabsVoiceVoiceId?, string>? Type747 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackElevenLabsVoiceVoiceId? Type748 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackElevenLabsVoiceModel? Type749 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackHumeVoiceProvider? Type750 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackHumeVoiceModel? Type751 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackLMNTVoiceProvider? Type752 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OneOf<global::Vapi.FallbackLMNTVoiceVoiceId?, string>? Type753 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackLMNTVoiceVoiceId? Type754 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackLMNTVoiceLanguage? Type755 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackNeuphonicVoiceProvider? Type756 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackNeuphonicVoiceModel? Type757 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackOpenAIVoiceProvider? Type758 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OneOf<global::Vapi.FallbackOpenAIVoiceVoiceId?, string>? Type759 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackOpenAIVoiceVoiceId? Type760 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackOpenAIVoiceModel? Type761 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackPlayHTVoiceProvider? Type762 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OneOf<global::Vapi.FallbackPlayHTVoiceVoiceId?, string>? Type763 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackPlayHTVoiceVoiceId? Type764 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackPlayHTVoiceEmotion? Type765 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackPlayHTVoiceModel? Type766 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackPlayHTVoiceLanguage? Type767 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackRimeAIVoiceProvider? Type768 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OneOf<global::Vapi.FallbackRimeAIVoiceVoiceId?, string>? Type769 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackRimeAIVoiceVoiceId? Type770 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackRimeAIVoiceModel? Type771 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackRimeAIVoiceLanguage? Type772 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackSesameVoiceProvider? Type773 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackSesameVoiceModel? Type774 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackSmallestAIVoiceProvider? Type775 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OneOf<global::Vapi.FallbackSmallestAIVoiceVoiceId?, string>? Type776 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackSmallestAIVoiceVoiceId? Type777 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackSmallestAIVoiceModel? Type778 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackTavusVoiceProvider? Type779 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OneOf<global::Vapi.FallbackTavusVoiceVoiceId?, string>? Type780 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackTavusVoiceVoiceId? Type781 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackVapiVoiceProvider? Type782 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OneOf<global::Vapi.FallbackVapiVoiceVersion2?, double?>? Type783 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackVapiVoiceVersion2? Type784 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackVapiVoiceLanguage? Type785 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackInworldVoiceProvider? Type786 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackInworldVoiceVoiceId? Type787 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackInworldVoiceModel? Type788 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackInworldVoiceLanguageCode? Type789 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackXaiVoiceProvider? Type790 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackXaiVoiceVoiceId? Type791 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackXaiVoiceLanguage? Type792 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackMicrosoftVoiceProvider? Type793 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackMicrosoftVoiceVoiceId? Type794 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackMicrosoftVoiceStyle? Type795 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackMicrosoftVoiceRole? Type796 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TransportConfigurationTwilio? Type797 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TransportConfigurationTwilioProvider? Type798 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TransportConfigurationTwilioRecordingChannels? Type799 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateAnthropicCredentialDTOProvider? Type800 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateAnthropicBedrockCredentialDTOProvider? Type801 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateAnthropicBedrockCredentialDTORegion? Type802 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OneOf<global::Vapi.AWSIAMCredentialsAuthenticationPlan, global::Vapi.AWSStsAuthenticationPlan>? Type803 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AWSIAMCredentialsAuthenticationPlan? Type804 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AWSStsAuthenticationPlan? Type805 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateAnyscaleCredentialDTOProvider? Type806 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateAssemblyAICredentialDTOProvider? Type807 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AzureBlobStorageBucketPlan? Type808 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateAzureCredentialDTOProvider? Type809 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateAzureCredentialDTOService? Type810 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateAzureCredentialDTORegion? Type811 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateAzureOpenAICredentialDTOProvider? Type812 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateAzureOpenAICredentialDTORegion? Type813 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.CreateAzureOpenAICredentialDTOModel>? Type814 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateAzureOpenAICredentialDTOModel? Type815 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SipTrunkGateway? Type816 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SipTrunkGatewayOutboundProtocol? Type817 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SipTrunkOutboundSipRegisterPlan? Type818 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SipTrunkOutboundAuthenticationPlan? Type819 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateByoSipTrunkCredentialDTOProvider? Type820 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.SipTrunkGateway>? Type821 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateCartesiaCredentialDTOProvider? Type822 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CloudflareR2BucketPlan? Type823 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateCloudflareCredentialDTOProvider? Type824 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OAuth2AuthenticationPlan? Type825 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OAuth2AuthenticationPlanType? Type826 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateCustomLLMCredentialDTOProvider? Type827 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateDeepgramCredentialDTOProvider? Type828 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateDeepInfraCredentialDTOProvider? Type829 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateDeepSeekCredentialDTOProvider? Type830 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateElevenLabsCredentialDTOProvider? Type831 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateElevenLabsCredentialDTOApiUrl? Type832 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GcpKey? Type833 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.BucketPlan? Type834 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateGcpCredentialDTOProvider? Type835 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateGladiaCredentialDTOProvider? Type836 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateGoHighLevelCredentialDTOProvider? Type837 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateGroqCredentialDTOProvider? Type838 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateLangfuseCredentialDTOProvider? Type839 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateLmntCredentialDTOProvider? Type840 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateMakeCredentialDTOProvider? Type841 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateOpenAICredentialDTOProvider? Type842 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateOpenRouterCredentialDTOProvider? Type843 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreatePerplexityAICredentialDTOProvider? Type844 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreatePlayHTCredentialDTOProvider? Type845 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateRimeAICredentialDTOProvider? Type846 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateRunpodCredentialDTOProvider? Type847 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateS3CredentialDTOProvider? Type848 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SupabaseBucketPlan? Type849 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SupabaseBucketPlanRegion? Type850 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateSupabaseCredentialDTOProvider? Type851 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateSmallestAICredentialDTOProvider? Type852 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateTavusCredentialDTOProvider? Type853 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateTogetherAICredentialDTOProvider? Type854 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateTwilioCredentialDTOProvider? Type855 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateVonageCredentialDTOProvider? Type856 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateWebhookCredentialDTOProvider? Type857 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AuthenticationPlan2? Type858 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.HMACAuthenticationPlan? Type859 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.BearerAuthenticationPlan? Type860 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateWebhookCredentialDTOAuthenticationPlanDiscriminator? Type861 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateWebhookCredentialDTOAuthenticationPlanDiscriminatorType? Type862 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateXAiCredentialDTOProvider? Type863 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateGoogleCalendarOAuth2ClientCredentialDTOProvider? Type864 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateGoogleCalendarOAuth2AuthorizationCredentialDTOProvider? Type865 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateGoogleSheetsOAuth2AuthorizationCredentialDTOProvider? Type866 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateSlackOAuth2AuthorizationCredentialDTOProvider? Type867 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateMinimaxCredentialDTOProvider? Type868 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.EndpointedSpeechLowConfidenceOptions? Type869 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CallHookTranscriberEndpointedSpeechLowConfidence? Type870 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SessionCreatedHook? Type871 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SessionCreatedHookOn? Type872 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.ToolCallHookAction>? Type873 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SQLInjectionSecurityFilter? Type874 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SQLInjectionSecurityFilterType? Type875 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.XSSSecurityFilter? Type876 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.XSSSecurityFilterType? Type877 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SSRFSecurityFilter? Type878 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SSRFSecurityFilterType? Type879 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.RCESecurityFilter? Type880 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.RCESecurityFilterType? Type881 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.PromptInjectionSecurityFilter? Type882 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.PromptInjectionSecurityFilterType? Type883 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.RegexSecurityFilter? Type884 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.RegexSecurityFilterType? Type885 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AssistantOverridesFirstMessageMode? Type886 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AssistantOverridesVoicemailDetection? Type887 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.AssistantOverridesClientMessage>? Type888 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AssistantOverridesClientMessage? Type889 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.AssistantOverridesServerMessage>? Type890 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AssistantOverridesServerMessage? Type891 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OneOf<global::Vapi.AssistantOverridesBackgroundSound?, string>? Type892 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AssistantOverridesBackgroundSound? Type893 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.TransportConfigurationTwilio>? Type894 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.CredentialsItem2>? Type895 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CredentialsItem2? Type896 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AssistantOverridesCredentialDiscriminator? Type897 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AssistantOverridesCredentialDiscriminatorProvider? Type898 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateAssistantDTOFirstMessageMode? Type899 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateAssistantDTOVoicemailDetection? Type900 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.CreateAssistantDTOClientMessage>? Type901 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateAssistantDTOClientMessage? Type902 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.CreateAssistantDTOServerMessage>? Type903 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateAssistantDTOServerMessage? Type904 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OneOf<global::Vapi.CreateAssistantDTOBackgroundSound?, string>? Type905 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateAssistantDTOBackgroundSound? Type906 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.CredentialsItem3>? Type907 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CredentialsItem3? Type908 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateAssistantDTOCredentialDiscriminator? Type909 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateAssistantDTOCredentialDiscriminatorProvider? Type910 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.Assistant? Type911 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AssistantFirstMessageMode? Type912 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AssistantVoicemailDetection? Type913 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.AssistantClientMessage>? Type914 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AssistantClientMessage? Type915 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.AssistantServerMessage>? Type916 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AssistantServerMessage? Type917 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OneOf<global::Vapi.AssistantBackgroundSound?, string>? Type918 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AssistantBackgroundSound? Type919 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.CredentialsItem4>? Type920 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CredentialsItem4? Type921 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AssistantCredentialDiscriminator? Type922 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AssistantCredentialDiscriminatorProvider? Type923 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.DateTime? Type924 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.PaginationMeta? Type925 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.PaginationMetaSortOrder? Type926 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AssistantPaginatedResponse? Type927 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.Assistant>? Type928 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AssistantDraft? Type929 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AssistantDraftFirstMessageMode? Type930 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AssistantDraftVoicemailDetection? Type931 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.AssistantDraftClientMessage>? Type932 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AssistantDraftClientMessage? Type933 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.AssistantDraftServerMessage>? Type934 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AssistantDraftServerMessage? Type935 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OneOf<global::Vapi.AssistantDraftBackgroundSound?, string>? Type936 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AssistantDraftBackgroundSound? Type937 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.CredentialsItem5>? Type938 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CredentialsItem5? Type939 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AssistantDraftCredentialDiscriminator? Type940 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AssistantDraftCredentialDiscriminatorProvider? Type941 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AssistantDraftPaginatedMetadata? Type942 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AssistantDraftPaginatedResponse? Type943 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.AssistantDraft>? Type944 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.LegacyAssistantVersion? Type945 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.LegacyAssistantVersionPaginatedResponse? Type946 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.LegacyAssistantVersion>? Type947 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AssistantVersion? Type948 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AssistantVersionFirstMessageMode? Type949 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AssistantVersionVoicemailDetection? Type950 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.AssistantVersionClientMessage>? Type951 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AssistantVersionClientMessage? Type952 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.AssistantVersionServerMessage>? Type953 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AssistantVersionServerMessage? Type954 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OneOf<global::Vapi.AssistantVersionBackgroundSound?, string>? Type955 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AssistantVersionBackgroundSound? Type956 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.CredentialsItem6>? Type957 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CredentialsItem6? Type958 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AssistantVersionCredentialDiscriminator? Type959 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AssistantVersionCredentialDiscriminatorProvider? Type960 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AssistantVersionPaginatedMetadata? Type961 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AssistantVersionPaginatedResponse? Type962 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.AssistantVersion>? Type963 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateAssistantVersionMetadataDTO? Type964 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.VersionPinReference? Type965 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.VersionPinReferenceSourceType? Type966 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.VersionPinConflictResponseDTO? Type967 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.VersionPinConflictResponseDTOError? Type968 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.VersionPinReference>? Type969 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateAssistantDraftDTO? Type970 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateAssistantDraftDTOFirstMessageMode? Type971 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateAssistantDraftDTOVoicemailDetection? Type972 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.CreateAssistantDraftDTOClientMessage>? Type973 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateAssistantDraftDTOClientMessage? Type974 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.CreateAssistantDraftDTOServerMessage>? Type975 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateAssistantDraftDTOServerMessage? Type976 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OneOf<global::Vapi.CreateAssistantDraftDTOBackgroundSound?, string>? Type977 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateAssistantDraftDTOBackgroundSound? Type978 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.CredentialsItem7>? Type979 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CredentialsItem7? Type980 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateAssistantDraftDTOCredentialDiscriminator? Type981 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateAssistantDraftDTOCredentialDiscriminatorProvider? Type982 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AssistantDraftConflictResponseDTO? Type983 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateAssistantDraftDTO? Type984 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateAssistantDraftDTOFirstMessageMode? Type985 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateAssistantDraftDTOVoicemailDetection? Type986 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.UpdateAssistantDraftDTOClientMessage>? Type987 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateAssistantDraftDTOClientMessage? Type988 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.UpdateAssistantDraftDTOServerMessage>? Type989 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateAssistantDraftDTOServerMessage? Type990 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OneOf<global::Vapi.UpdateAssistantDraftDTOBackgroundSound?, string>? Type991 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateAssistantDraftDTOBackgroundSound? Type992 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.CredentialsItem8>? Type993 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CredentialsItem8? Type994 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateAssistantDraftDTOCredentialDiscriminator? Type995 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateAssistantDraftDTOCredentialDiscriminatorProvider? Type996 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateAssistantDTO? Type997 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateAssistantDTOFirstMessageMode? Type998 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateAssistantDTOVoicemailDetection? Type999 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.UpdateAssistantDTOClientMessage>? Type1000 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateAssistantDTOClientMessage? Type1001 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.UpdateAssistantDTOServerMessage>? Type1002 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateAssistantDTOServerMessage? Type1003 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OneOf<global::Vapi.UpdateAssistantDTOBackgroundSound?, string>? Type1004 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateAssistantDTOBackgroundSound? Type1005 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.CredentialsItem9>? Type1006 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CredentialsItem9? Type1007 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateAssistantDTOCredentialDiscriminator? Type1008 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateAssistantDTOCredentialDiscriminatorProvider? Type1009 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AssistantPinnedConflictResponseDTO? Type1010 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AssistantPinnedConflictResponseDTOError? Type1011 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.Squad? Type1012 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateSquadDTO? Type1013 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.Workflow? Type1014 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OneOf<global::Vapi.WorkflowBackgroundSound?, string>? Type1015 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.WorkflowBackgroundSound? Type1016 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.CredentialsItem10>? Type1017 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CredentialsItem10? Type1018 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.WorkflowCredentialDiscriminator? Type1019 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.WorkflowCredentialDiscriminatorProvider? Type1020 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.WorkflowVoicemailDetection? Type1021 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateWorkflowDTO? Type1022 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OneOf<global::Vapi.CreateWorkflowDTOBackgroundSound?, string>? Type1023 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateWorkflowDTOBackgroundSound? Type1024 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.CredentialsItem11>? Type1025 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CredentialsItem11? Type1026 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateWorkflowDTOCredentialDiscriminator? Type1027 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateWorkflowDTOCredentialDiscriminatorProvider? Type1028 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateWorkflowDTOVoicemailDetection? Type1029 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateWorkflowDTO? Type1030 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OneOf<global::Vapi.UpdateWorkflowDTOBackgroundSound?, string>? Type1031 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateWorkflowDTOBackgroundSound? Type1032 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.CredentialsItem12>? Type1033 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CredentialsItem12? Type1034 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateWorkflowDTOCredentialDiscriminator? Type1035 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateWorkflowDTOCredentialDiscriminatorProvider? Type1036 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateWorkflowDTOVoicemailDetection? Type1037 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SubscriptionLimits? Type1038 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.BotMessage? Type1039 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ToolCallMessage? Type1040 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ToolCallResultMessageWarning? Type1041 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ToolCallResultMessageWarningType? Type1042 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ToolCallResultMessage? Type1043 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.ToolCallResultMessageWarning>? Type1044 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TransportCost? Type1045 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TransportCostType? Type1046 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TransportCostProvider? Type1047 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TranscriberCost? Type1048 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TranscriberCostType? Type1049 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ModelCost? Type1050 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ModelCostType? Type1051 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.VoiceCost? Type1052 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.VoiceCostType? Type1053 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ChatCost? Type1054 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ChatCostType? Type1055 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.VapiCost? Type1056 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.VapiCostType? Type1057 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.VapiCostSubType? Type1058 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.VoicemailDetectionCost? Type1059 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.VoicemailDetectionCostType? Type1060 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.VoicemailDetectionCostProvider? Type1061 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.StructuredOutputCostBreakdown? Type1062 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AnalysisCost? Type1063 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AnalysisCostType? Type1064 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AnalysisCostAnalysisType? Type1065 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.StructuredOutputCostBreakdown>? Type1066 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AudioFormat? Type1067 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AudioFormatContainer? Type1068 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.VapiWebsocketTransport? Type1069 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.VapiWebsocketTransportConversationType? Type1070 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.VapiWebsocketTransportProvider? Type1071 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.VapiWebCallTransport? Type1072 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.VapiWebCallTransportConversationType? Type1073 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.VapiWebCallTransportProvider? Type1074 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TwilioTransport? Type1075 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TwilioTransportConversationType? Type1076 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TwilioTransportProvider? Type1077 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TelnyxTransport? Type1078 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TelnyxTransportConversationType? Type1079 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TelnyxTransportProvider? Type1080 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.VapiSipTransport? Type1081 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.VapiSipTransportConversationType? Type1082 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.VapiSipTransportProvider? Type1083 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.VonageTransport? Type1084 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.VonageTransportConversationType? Type1085 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.VonageTransportProvider? Type1086 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AnalysisCostBreakdown? Type1087 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CostBreakdown? Type1088 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.Analysis? Type1089 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.MonitorResult? Type1090 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.Monitor? Type1091 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.MonitorResult>? Type1092 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SkippedStructuredOutput? Type1093 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TransferArtifact? Type1094 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TransferArtifactMode? Type1095 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TransferArtifactStatus? Type1096 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.OneOf<global::Vapi.UserMessage, global::Vapi.SystemMessage, global::Vapi.BotMessage, global::Vapi.ToolCallMessage, global::Vapi.ToolCallResultMessage>>? Type1097 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OneOf<global::Vapi.UserMessage, global::Vapi.SystemMessage, global::Vapi.BotMessage, global::Vapi.ToolCallMessage, global::Vapi.ToolCallResultMessage>? Type1098 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.Mono? Type1099 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.Recording? Type1100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.NodeArtifact? Type1101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AssistantActivation? Type1102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TurnLatency? Type1103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.PerformanceMetrics? Type1104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.TurnLatency>? Type1105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.Artifact? Type1106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Vapi.SkippedStructuredOutput>? Type1107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.TransferArtifact>? Type1108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.NodeArtifact>? Type1109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.AssistantActivation>? Type1110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.RecordingConsent? Type1111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.RecordingConsentType? Type1112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.Compliance? Type1113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.WorkflowOverrides? Type1114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TransferPhoneNumberHookAction? Type1115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TransferPhoneNumberHookActionType? Type1116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SayPhoneNumberHookAction? Type1117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SayPhoneNumberHookActionType? Type1118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.PhoneNumberCallRingingHookFilter? Type1119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.PhoneNumberCallRingingHookFilterType? Type1120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.PhoneNumberCallRingingHookFilterKey? Type1121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.PhoneNumberHookCallRinging? Type1122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.PhoneNumberHookCallRingingOn? Type1123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.PhoneNumberCallRingingHookFilter>? Type1124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.OneOf<global::Vapi.TransferPhoneNumberHookAction, global::Vapi.SayPhoneNumberHookAction>>? Type1125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OneOf<global::Vapi.TransferPhoneNumberHookAction, global::Vapi.SayPhoneNumberHookAction>? Type1126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.PhoneNumberCallEndingHookFilter? Type1127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.PhoneNumberCallEndingHookFilterType? Type1128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.PhoneNumberCallEndingHookFilterKey? Type1129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.PhoneNumberCallEndingHookFilterOneOfItem>? Type1130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.PhoneNumberCallEndingHookFilterOneOfItem? Type1131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.PhoneNumberHookCallEnding? Type1132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.PhoneNumberHookCallEndingOn? Type1133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.PhoneNumberCallEndingHookFilter>? Type1134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ImportTwilioPhoneNumberDTO? Type1135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.OneOf<global::Vapi.PhoneNumberHookCallRinging, global::Vapi.PhoneNumberHookCallEnding>>? Type1136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OneOf<global::Vapi.PhoneNumberHookCallRinging, global::Vapi.PhoneNumberHookCallEnding>? Type1137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateCustomerDTO? Type1138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SchedulePlan? Type1139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.Call? Type1140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CallType? Type1141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OneOf<global::Vapi.TransportCost, global::Vapi.TranscriberCost, global::Vapi.ModelCost, global::Vapi.VoiceCost, global::Vapi.VapiCost, global::Vapi.VoicemailDetectionCost, global::Vapi.AnalysisCost, global::Vapi.KnowledgeBaseCost>? Type1142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.KnowledgeBaseCost? Type1143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CallPhoneCallProvider? Type1144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CallPhoneCallTransport? Type1145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CallStatus? Type1146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CallEndedReason? Type1147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OneOf<global::Vapi.VapiWebsocketTransport, global::Vapi.VonageTransport, global::Vapi.TwilioTransport, global::Vapi.VapiSipTransport, global::Vapi.TelnyxTransport, global::Vapi.VapiWebCallTransport>? Type1148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CallBatchError? Type1149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CallBatchResponse? Type1150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.Call>? Type1151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.CallBatchError>? Type1152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AssistantSpeechWordAlignmentTiming? Type1153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AssistantSpeechWordAlignmentTimingType? Type1154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<double>? Type1155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AssistantSpeechWordTimestamp? Type1156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AssistantSpeechWordProgressTiming? Type1157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AssistantSpeechWordProgressTimingType? Type1158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.AssistantSpeechWordTimestamp>? Type1159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateCallDTO? Type1160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.CreateCustomerDTO>? Type1161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.StructuredOutputFilterDTO? Type1162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CallPaginatedResponse? Type1163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateOutboundCallDTO? Type1164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateWebCallDTO? Type1165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateCallDTO? Type1166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.DeleteCallDTO? Type1167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.DeveloperMessageRole? Type1168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ToolCallFunction? Type1169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ToolCall? Type1170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AssistantMessageRole? Type1171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.ToolCall>? Type1172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ToolMessageRole? Type1173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FunctionCall? Type1174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.Chat? Type1175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.OneOf<global::Vapi.ModelCost, global::Vapi.ChatCost>>? Type1176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OneOf<global::Vapi.ModelCost, global::Vapi.ChatCost>? Type1177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TwilioSMSChatTransport? Type1178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TwilioSMSChatTransportConversationType? Type1179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TwilioSMSChatTransportType? Type1180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateChatDTO? Type1181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GetChatPaginatedDTO? Type1182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GetChatPaginatedDTOSortOrder? Type1183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GetChatPaginatedDTOSortBy? Type1184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ChatPaginatedResponse? Type1185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.Chat>? Type1186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateChatStreamResponse? Type1187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OpenAIResponsesRequest? Type1188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ChatAssistantOverrides? Type1189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateWebCustomerDTO? Type1190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateWebChatDTO? Type1191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.WebChat? Type1192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OpenAIWebChatRequest? Type1193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ExportChatDTO? Type1194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ExportChatDTOColumns? Type1195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ExportChatDTOFormat? Type1196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ExportChatDTOSortOrder? Type1197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ExportChatDTOSortBy? Type1198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ResponseOutputText? Type1199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ResponseOutputTextType? Type1200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ResponseOutputMessage? Type1201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.ResponseOutputText>? Type1202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ResponseOutputMessageRole? Type1203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ResponseOutputMessageStatus? Type1204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ResponseOutputMessageType? Type1205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ResponseObject? Type1206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ResponseObjectObject? Type1207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ResponseObjectStatus? Type1208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.ResponseOutputMessage>? Type1209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ResponseTextDeltaEvent? Type1210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ResponseTextDeltaEventType? Type1211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ResponseTextDoneEvent? Type1212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ResponseTextDoneEventType? Type1213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ResponseCompletedEvent? Type1214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ResponseCompletedEventType? Type1215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ResponseErrorEvent? Type1216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ResponseErrorEventType? Type1217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.DialPlanEntry? Type1218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CampaignPredialPlan? Type1219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateCampaignDTO? Type1220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.DialPlanEntry>? Type1221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.CreateCampaignDTOServerMessage>? Type1222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateCampaignDTOServerMessage? Type1223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.Campaign? Type1224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CampaignStatus? Type1225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CampaignEndedReason? Type1226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.CampaignServerMessage>? Type1227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CampaignServerMessage? Type1228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CampaignPaginatedResponse? Type1229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.Campaign>? Type1230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CampaignContactCounters? Type1231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CampaignCallMetrics? Type1232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CampaignSummary? Type1233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CampaignSummaryStatus? Type1234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CampaignSummaryEndedReason? Type1235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.CampaignSummaryServerMessage>? Type1236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CampaignSummaryServerMessage? Type1237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CampaignSummaryPaginatedResponse? Type1238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.CampaignSummary>? Type1239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateCampaignDTO? Type1240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateCampaignDTOStatus? Type1241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CampaignContactWithOutcome? Type1242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CampaignContactWithOutcomeStatus? Type1243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CampaignContactPaginatedResponse? Type1244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.CampaignContactWithOutcome>? Type1245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.RelayTargetAssistant? Type1246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.RelayTargetAssistantType? Type1247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.RelayTargetSquad? Type1248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.RelayTargetSquadType? Type1249 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.RelayTargetOptions? Type1250 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.RelayTargetOptionsType? Type1251 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.RelayCommandSay? Type1252 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.RelayCommandSayType? Type1253 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.RelayCommandNote? Type1254 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.RelayCommandNoteType? Type1255 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.RelayCommandOptions? Type1256 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.RelayCommandOptionsType? Type1257 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.RelayRequest? Type1258 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OneOf<global::Vapi.RelayTargetAssistant, global::Vapi.RelayTargetSquad>? Type1259 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.OneOf<global::Vapi.RelayCommandSay, global::Vapi.RelayCommandNote>>? Type1260 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OneOf<global::Vapi.RelayCommandSay, global::Vapi.RelayCommandNote>? Type1261 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.RelayResponse? Type1262 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.RelayResponseStatus? Type1263 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.Session? Type1264 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.OneOf<global::Vapi.ModelCost, global::Vapi.AnalysisCost, global::Vapi.SessionCost>>? Type1265 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OneOf<global::Vapi.ModelCost, global::Vapi.AnalysisCost, global::Vapi.SessionCost>? Type1266 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SessionCost? Type1267 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SessionStatus? Type1268 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateSessionDTO? Type1269 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateSessionDTOStatus? Type1270 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateSessionDTO? Type1271 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateSessionDTOStatus? Type1272 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GetSessionPaginatedDTO? Type1273 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GetSessionPaginatedDTOSortOrder? Type1274 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GetSessionPaginatedDTOSortBy? Type1275 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SessionPaginatedResponse? Type1276 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.Session>? Type1277 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ExportSessionDTO? Type1278 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ExportSessionDTOColumns? Type1279 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ExportSessionDTOFormat? Type1280 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ExportSessionDTOSortOrder? Type1281 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ExportSessionDTOSortBy? Type1282 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ByoPhoneNumber? Type1283 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ByoPhoneNumberProvider? Type1284 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ByoPhoneNumberStatus? Type1285 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TwilioPhoneNumber? Type1286 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TwilioPhoneNumberProvider? Type1287 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TwilioPhoneNumberStatus? Type1288 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.VonagePhoneNumber? Type1289 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.VonagePhoneNumberProvider? Type1290 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.VonagePhoneNumberStatus? Type1291 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SipAuthentication? Type1292 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.VapiPhoneNumber? Type1293 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.VapiPhoneNumberProvider? Type1294 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.VapiPhoneNumberStatus? Type1295 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TelnyxPhoneNumber? Type1296 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TelnyxPhoneNumberProvider? Type1297 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TelnyxPhoneNumberStatus? Type1298 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateByoPhoneNumberDTO? Type1299 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateByoPhoneNumberDTOProvider? Type1300 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateTwilioPhoneNumberDTO? Type1301 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateTwilioPhoneNumberDTOProvider? Type1302 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateVonagePhoneNumberDTO? Type1303 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateVonagePhoneNumberDTOProvider? Type1304 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateVapiPhoneNumberDTO? Type1305 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateVapiPhoneNumberDTOProvider? Type1306 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateTelnyxPhoneNumberDTO? Type1307 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateTelnyxPhoneNumberDTOProvider? Type1308 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateByoPhoneNumberDTO? Type1309 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateByoPhoneNumberDTOProvider? Type1310 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateTwilioPhoneNumberDTO? Type1311 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateTwilioPhoneNumberDTOProvider? Type1312 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateVonagePhoneNumberDTO? Type1313 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateVonagePhoneNumberDTOProvider? Type1314 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateVapiPhoneNumberDTO? Type1315 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateVapiPhoneNumberDTOProvider? Type1316 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateTelnyxPhoneNumberDTO? Type1317 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateTelnyxPhoneNumberDTOProvider? Type1318 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ImportVonagePhoneNumberDTO? Type1319 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.PhoneNumberPaginatedResponse? Type1320 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.OneOf<global::Vapi.ByoPhoneNumber, global::Vapi.TwilioPhoneNumber, global::Vapi.VonagePhoneNumber, global::Vapi.VapiPhoneNumber, global::Vapi.TelnyxPhoneNumber>>? Type1321 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OneOf<global::Vapi.ByoPhoneNumber, global::Vapi.TwilioPhoneNumber, global::Vapi.VonagePhoneNumber, global::Vapi.VapiPhoneNumber, global::Vapi.TelnyxPhoneNumber>? Type1322 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ApiRequestTool? Type1323 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ApiRequestToolType? Type1324 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ApiRequestToolMethod? Type1325 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CodeToolEnvironmentVariable? Type1326 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CodeTool? Type1327 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CodeToolType? Type1328 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.CodeToolEnvironmentVariable>? Type1329 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.DtmfTool? Type1330 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.DtmfToolType? Type1331 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.EndCallTool? Type1332 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.EndCallToolType? Type1333 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FunctionTool? Type1334 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FunctionToolType? Type1335 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.KnowledgeBaseToolFunction? Type1336 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.KnowledgeBaseTool? Type1337 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.KnowledgeBaseToolType? Type1338 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GhlTool? Type1339 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GhlToolType? Type1340 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.MakeTool? Type1341 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.MakeToolType? Type1342 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TransferCallTool? Type1343 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TransferCallToolType? Type1344 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.HandoffTool? Type1345 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.HandoffToolType? Type1346 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OutputTool? Type1347 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OutputToolType? Type1348 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.BashTool? Type1349 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.BashToolType? Type1350 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.BashToolSubType? Type1351 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.BashToolName? Type1352 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ComputerTool? Type1353 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ComputerToolType? Type1354 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ComputerToolSubType? Type1355 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ComputerToolName? Type1356 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TextEditorTool? Type1357 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TextEditorToolType? Type1358 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TextEditorToolSubType? Type1359 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TextEditorToolName? Type1360 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.QueryTool? Type1361 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.QueryToolType? Type1362 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GoogleCalendarCreateEventTool? Type1363 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GoogleCalendarCreateEventToolType? Type1364 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GoogleSheetsRowAppendTool? Type1365 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GoogleSheetsRowAppendToolType? Type1366 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GoogleCalendarCheckAvailabilityTool? Type1367 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GoogleCalendarCheckAvailabilityToolType? Type1368 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SlackSendMessageTool? Type1369 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SlackSendMessageToolType? Type1370 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SmsTool? Type1371 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SmsToolType? Type1372 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.McpTool? Type1373 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.McpToolType? Type1374 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GoHighLevelCalendarAvailabilityTool? Type1375 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GoHighLevelCalendarAvailabilityToolType? Type1376 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GoHighLevelCalendarEventCreateTool? Type1377 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GoHighLevelCalendarEventCreateToolType? Type1378 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GoHighLevelContactCreateTool? Type1379 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GoHighLevelContactCreateToolType? Type1380 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GoHighLevelContactGetTool? Type1381 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GoHighLevelContactGetToolType? Type1382 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SipRequestTool? Type1383 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SipRequestToolType? Type1384 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SipRequestToolVerb? Type1385 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OneOf<string, global::Vapi.JsonSchema>? Type1386 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.VoicemailTool? Type1387 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.VoicemailToolType? Type1388 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateApiRequestToolDTOType? Type1389 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateApiRequestToolDTOMethod? Type1390 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateCodeToolDTOType? Type1391 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateOutputToolDTO? Type1392 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateOutputToolDTOType? Type1393 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateBashToolDTOType? Type1394 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateBashToolDTOSubType? Type1395 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateBashToolDTOName? Type1396 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateComputerToolDTOType? Type1397 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateComputerToolDTOSubType? Type1398 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateComputerToolDTOName? Type1399 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateTextEditorToolDTOType? Type1400 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateTextEditorToolDTOSubType? Type1401 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateTextEditorToolDTOName? Type1402 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateSmsToolDTOType? Type1403 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateSipRequestToolDTOType? Type1404 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateSipRequestToolDTOVerb? Type1405 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateApiRequestToolDTO? Type1406 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateApiRequestToolDTOType? Type1407 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateApiRequestToolDTOMethod? Type1408 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateCodeToolDTO? Type1409 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateCodeToolDTOType? Type1410 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateDtmfToolDTO? Type1411 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateDtmfToolDTOType? Type1412 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateEndCallToolDTO? Type1413 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateEndCallToolDTOType? Type1414 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateFunctionToolDTO? Type1415 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateFunctionToolDTOType? Type1416 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateKnowledgeBaseToolDTO? Type1417 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateKnowledgeBaseToolDTOType? Type1418 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateGhlToolDTO? Type1419 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateGhlToolDTOType? Type1420 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateMakeToolDTO? Type1421 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateMakeToolDTOType? Type1422 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateHandoffToolDTO? Type1423 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateHandoffToolDTOType? Type1424 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateTransferCallToolDTO? Type1425 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateTransferCallToolDTOType? Type1426 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateOutputToolDTO? Type1427 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateOutputToolDTOType? Type1428 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateBashToolDTO? Type1429 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateBashToolDTOType? Type1430 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateBashToolDTOSubType? Type1431 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateBashToolDTOName? Type1432 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateComputerToolDTO? Type1433 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateComputerToolDTOType? Type1434 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateComputerToolDTOSubType? Type1435 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateComputerToolDTOName? Type1436 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateTextEditorToolDTO? Type1437 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateTextEditorToolDTOType? Type1438 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateTextEditorToolDTOSubType? Type1439 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateTextEditorToolDTOName? Type1440 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateQueryToolDTO? Type1441 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateQueryToolDTOType? Type1442 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateGoogleCalendarCreateEventToolDTO? Type1443 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateGoogleCalendarCreateEventToolDTOType? Type1444 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateGoogleSheetsRowAppendToolDTO? Type1445 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateGoogleSheetsRowAppendToolDTOType? Type1446 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateGoogleCalendarCheckAvailabilityToolDTO? Type1447 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateGoogleCalendarCheckAvailabilityToolDTOType? Type1448 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateSlackSendMessageToolDTO? Type1449 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateSlackSendMessageToolDTOType? Type1450 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateSmsToolDTO? Type1451 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateSmsToolDTOType? Type1452 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateMcpToolDTO? Type1453 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateMcpToolDTOType? Type1454 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateGoHighLevelCalendarAvailabilityToolDTO? Type1455 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateGoHighLevelCalendarAvailabilityToolDTOType? Type1456 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateGoHighLevelCalendarEventCreateToolDTO? Type1457 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateGoHighLevelCalendarEventCreateToolDTOType? Type1458 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateGoHighLevelContactCreateToolDTO? Type1459 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateGoHighLevelContactCreateToolDTOType? Type1460 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateGoHighLevelContactGetToolDTO? Type1461 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateGoHighLevelContactGetToolDTOType? Type1462 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateSipRequestToolDTO? Type1463 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateSipRequestToolDTOType? Type1464 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateSipRequestToolDTOVerb? Type1465 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateVoicemailToolDTO? Type1466 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateVoicemailToolDTOType? Type1467 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ToolVersion? Type1468 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ToolVersionPaginatedMetadata? Type1469 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ToolVersionPaginatedResponse? Type1470 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.ToolVersion>? Type1471 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ToolDraft? Type1472 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ToolDraftType? Type1473 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ToolDraftMethod? Type1474 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ToolDraftVerb? Type1475 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateToolDraftDTO? Type1476 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateToolDraftDTOType? Type1477 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateToolDraftDTOMethod? Type1478 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateToolDraftDTOVerb? Type1479 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateToolDraftDTO? Type1480 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateToolDraftDTOType? Type1481 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateToolDraftDTOMethod? Type1482 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateToolDraftDTOVerb? Type1483 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ToolDraftPaginatedMetadata? Type1484 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ToolDraftPaginatedResponse? Type1485 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.ToolDraft>? Type1486 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ToolDraftConflictResponseDTO? Type1487 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GetToolDraftsDTO? Type1488 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateToolVersionMetadataDTO? Type1489 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ToolPinnedConflictResponseDTO? Type1490 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ToolPinnedConflictResponseDTOError? Type1491 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateFileDTO? Type1492 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateFileDTOPurpose? Type1493 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.File? Type1494 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FileObject? Type1495 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FileStatus? Type1496 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateFileDTO? Type1497 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CustomKnowledgeBase? Type1498 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CustomKnowledgeBaseProvider? Type1499 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateCustomKnowledgeBaseDTO? Type1500 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateCustomKnowledgeBaseDTOProvider? Type1501 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateKnowledgeBaseV2DTO? Type1502 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.KnowledgeBaseV2? Type1503 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.KnowledgeBaseV2File? Type1504 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.KnowledgeBaseV2FileStatus? Type1505 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AttachKnowledgeBaseV2FileDTO? Type1506 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateKnowledgeBaseV2DTO? Type1507 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.KnowledgeBaseV2WithFiles? Type1508 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.KnowledgeBaseV2File>? Type1509 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.StructuredOutputRunResult? Type1510 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.StructuredOutputRunPreviewResponse? Type1511 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.StructuredOutputRerunResponse? Type1512 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.StructuredOutput? Type1513 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.StructuredOutputType? Type1514 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.StructuredOutputPaginatedResponse? Type1515 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.StructuredOutput>? Type1516 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateStructuredOutputDTO? Type1517 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateStructuredOutputDTOType? Type1518 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.StructuredOutputRunDTO? Type1519 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TesterPlan? Type1520 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TestSuitePhoneNumber? Type1521 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TestSuitePhoneNumberProvider? Type1522 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TargetPlan? Type1523 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TestSuite? Type1524 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TestSuitesPaginatedResponse? Type1525 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.TestSuite>? Type1526 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateTestSuiteDto? Type1527 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateTestSuiteDto? Type1528 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TestSuiteTestVoice? Type1529 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.TestSuiteTestScorerAI>? Type1530 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TestSuiteTestScorerAI? Type1531 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TestSuiteTestVoiceType? Type1532 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TestSuiteTestChat? Type1533 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TestSuiteTestChatType? Type1534 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateTestSuiteTestVoiceDto? Type1535 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateTestSuiteTestVoiceDtoType? Type1536 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateTestSuiteTestChatDto? Type1537 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateTestSuiteTestChatDtoType? Type1538 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateTestSuiteTestVoiceDto? Type1539 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateTestSuiteTestVoiceDtoType? Type1540 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateTestSuiteTestChatDto? Type1541 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateTestSuiteTestChatDtoType? Type1542 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TestSuiteTestScorerAIType? Type1543 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TestSuiteTestsPaginatedResponse? Type1544 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.OneOf<global::Vapi.TestSuiteTestVoice, global::Vapi.TestSuiteTestChat>>? Type1545 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OneOf<global::Vapi.TestSuiteTestVoice, global::Vapi.TestSuiteTestChat>? Type1546 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TestSuiteRunScorerAI? Type1547 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TestSuiteRunScorerAIType? Type1548 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TestSuiteRunScorerAIResult? Type1549 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TestSuiteRunTestAttemptCall? Type1550 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TestSuiteRunTestAttemptMetadata? Type1551 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TestSuiteRunTestAttempt? Type1552 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.TestSuiteRunScorerAI>? Type1553 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TestSuiteRunTestResult? Type1554 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.TestSuiteRunTestAttempt>? Type1555 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TestSuiteRun? Type1556 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TestSuiteRunStatus? Type1557 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.TestSuiteRunTestResult>? Type1558 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TestSuiteRunsPaginatedResponse? Type1559 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.TestSuiteRun>? Type1560 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateTestSuiteRunDto? Type1561 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateTestSuiteRunDto? Type1562 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreatePersonalityDTO? Type1563 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.Personality? Type1564 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdatePersonalityDTO? Type1565 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SimulationHookInclude? Type1566 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SimulationHookWebhookAction? Type1567 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SimulationHookWebhookActionType? Type1568 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SimulationHookCallStarted? Type1569 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SimulationHookCallStartedOn? Type1570 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.SimulationHookWebhookAction>? Type1571 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SimulationHookCallEnded? Type1572 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SimulationHookCallEndedOn? Type1573 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.EvaluationPlanItem? Type1574 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.EvaluationPlanItemComparator? Type1575 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OneOf<double?, string, bool?>? Type1576 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ScenarioToolMock? Type1577 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateScenarioDTO? Type1578 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.EvaluationPlanItem>? Type1579 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.OneOf<global::Vapi.SimulationHookCallStarted, global::Vapi.SimulationHookCallEnded>>? Type1580 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OneOf<global::Vapi.SimulationHookCallStarted, global::Vapi.SimulationHookCallEnded>? Type1581 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.ScenarioToolMock>? Type1582 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.Scenario? Type1583 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateScenarioDTO? Type1584 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SimulationRunSimulationEntry? Type1585 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SimulationRunSimulationEntryType? Type1586 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SimulationRunSuiteEntry? Type1587 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SimulationRunSuiteEntryType? Type1588 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SimulationRunTargetAssistant? Type1589 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SimulationRunTargetAssistantType? Type1590 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SimulationRunTargetSquad? Type1591 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SimulationRunTargetSquadType? Type1592 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SimulationRunTransportConfiguration? Type1593 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SimulationRunTransportConfigurationProvider? Type1594 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateSimulationRunDTO? Type1595 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.OneOf<global::Vapi.SimulationRunSimulationEntry, global::Vapi.SimulationRunSuiteEntry>>? Type1596 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OneOf<global::Vapi.SimulationRunSimulationEntry, global::Vapi.SimulationRunSuiteEntry>? Type1597 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OneOf<global::Vapi.SimulationRunTargetAssistant, global::Vapi.SimulationRunTargetSquad>? Type1598 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SimulationRunItemCounts? Type1599 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateSimulationRunResponse? Type1600 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateSimulationRunResponseStatus? Type1601 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SimulationRunPaymentRequiredResponse? Type1602 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SimulationRunPaymentRequiredResponseReason? Type1603 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SimulationRun? Type1604 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SimulationRunStatus? Type1605 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SimulationRunListSource? Type1606 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SimulationRunListSourceType? Type1607 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SimulationRunListSummary? Type1608 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SimulationRunListItem? Type1609 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SimulationRunListItemStatus? Type1610 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SimulationRunsPaginatedResponse? Type1611 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.SimulationRunListItem>? Type1612 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SimulationRunItemCallMonitor? Type1613 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SimulationRunItemCallMetadata? Type1614 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SimulationRunItemMetadata? Type1615 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.StructuredOutputEvaluationResult? Type1616 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OneOf<double?, string, bool?, object>? Type1617 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.StructuredOutputEvaluationResultComparator? Type1618 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.LatencyMetrics? Type1619 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SimulationRunItemResults? Type1620 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.StructuredOutputEvaluationResult>? Type1621 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SimulationRunItemImprovementSuggestion? Type1622 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SimulationRunItemImprovements? Type1623 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.SimulationRunItemImprovementSuggestion>? Type1624 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SimulationRunConfiguration? Type1625 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SimulationRunItem? Type1626 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SimulationRunItemStatus? Type1627 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SimulationSuiteTargetAssignment? Type1628 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SimulationSuiteTargetAssignmentTargetType? Type1629 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateSimulationSuiteDTO? Type1630 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.SimulationSuiteTargetAssignment>? Type1631 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SimulationSuite? Type1632 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateSimulationSuiteDTO? Type1633 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GenerateScenariosDTO? Type1634 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GeneratedScenario? Type1635 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GeneratedScenarioCategory? Type1636 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GenerateScenariosResponse? Type1637 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.GeneratedScenario>? Type1638 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateSimulationDTO? Type1639 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.Simulation? Type1640 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateSimulationDTO? Type1641 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SimulationConcurrencyResponse? Type1642 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.BarInsightMetadata? Type1643 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.InsightTimeRangeWithStep? Type1644 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.InsightTimeRangeWithStepStep? Type1645 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.BarInsight? Type1646 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.BarInsightType? Type1647 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.InsightFormula>? Type1648 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.InsightFormula? Type1649 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.BarInsightGroupBy? Type1650 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.JSONQueryOnCallTableWithStringTypeColumn? Type1651 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.JSONQueryOnCallTableWithNumberTypeColumn? Type1652 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.JSONQueryOnCallTableWithStructuredOutputColumn? Type1653 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.JSONQueryOnEventsTable? Type1654 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.InsightTimeRange? Type1655 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.PieInsight? Type1656 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.PieInsightType? Type1657 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.PieInsightGroupBy? Type1658 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.LineInsightMetadata? Type1659 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.LineInsight? Type1660 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.LineInsightType? Type1661 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.LineInsightGroupBy? Type1662 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TextInsight? Type1663 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TextInsightType? Type1664 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateBarInsightFromCallTableDTO? Type1665 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateBarInsightFromCallTableDTOType? Type1666 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateBarInsightFromCallTableDTOGroupBy? Type1667 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdatePieInsightFromCallTableDTO? Type1668 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdatePieInsightFromCallTableDTOType? Type1669 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdatePieInsightFromCallTableDTOGroupBy? Type1670 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateLineInsightFromCallTableDTO? Type1671 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateLineInsightFromCallTableDTOType? Type1672 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateLineInsightFromCallTableDTOGroupBy? Type1673 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateTextInsightFromCallTableDTO? Type1674 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateTextInsightFromCallTableDTOType? Type1675 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateBarInsightFromCallTableDTO? Type1676 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateBarInsightFromCallTableDTOType? Type1677 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateBarInsightFromCallTableDTOGroupBy? Type1678 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreatePieInsightFromCallTableDTO? Type1679 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreatePieInsightFromCallTableDTOType? Type1680 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreatePieInsightFromCallTableDTOGroupBy? Type1681 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateLineInsightFromCallTableDTO? Type1682 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateLineInsightFromCallTableDTOType? Type1683 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateLineInsightFromCallTableDTOGroupBy? Type1684 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateTextInsightFromCallTableDTO? Type1685 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateTextInsightFromCallTableDTOType? Type1686 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.JSONQueryOnCallTableWithStringTypeColumnType? Type1687 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.JSONQueryOnCallTableWithStringTypeColumnTable? Type1688 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FilterStringTypeColumnOnCallTable? Type1689 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FilterStringArrayTypeColumnOnCallTable? Type1690 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FilterNumberTypeColumnOnCallTable? Type1691 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FilterNumberArrayTypeColumnOnCallTable? Type1692 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FilterDateTypeColumnOnCallTable? Type1693 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FilterStructuredOutputColumnOnCallTable? Type1694 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.JSONQueryOnCallTableWithStringTypeColumnColumn? Type1695 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.JSONQueryOnCallTableWithStringTypeColumnOperation? Type1696 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.JSONQueryOnCallTableWithNumberTypeColumnType? Type1697 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.JSONQueryOnCallTableWithNumberTypeColumnTable? Type1698 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.JSONQueryOnCallTableWithNumberTypeColumnColumn? Type1699 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.JSONQueryOnCallTableWithNumberTypeColumnOperation? Type1700 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.JSONQueryOnCallTableWithStructuredOutputColumnType? Type1701 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.JSONQueryOnCallTableWithStructuredOutputColumnTable? Type1702 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.JSONQueryOnCallTableWithStructuredOutputColumnColumn? Type1703 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.JSONQueryOnCallTableWithStructuredOutputColumnOperation? Type1704 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.JSONQueryOnEventsTableType? Type1705 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.JSONQueryOnEventsTableTable? Type1706 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.JSONQueryOnEventsTableOn? Type1707 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.JSONQueryOnEventsTableOperation? Type1708 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.OneOf<global::Vapi.EventsTableStringCondition, global::Vapi.EventsTableNumberCondition, global::Vapi.EventsTableBooleanCondition>>? Type1709 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OneOf<global::Vapi.EventsTableStringCondition, global::Vapi.EventsTableNumberCondition, global::Vapi.EventsTableBooleanCondition>? Type1710 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.EventsTableStringCondition? Type1711 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.EventsTableNumberCondition? Type1712 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.EventsTableBooleanCondition? Type1713 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FilterStringTypeColumnOnCallTableColumn? Type1714 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FilterStringTypeColumnOnCallTableOperator? Type1715 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FilterNumberTypeColumnOnCallTableColumn? Type1716 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FilterNumberTypeColumnOnCallTableOperator? Type1717 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FilterDateTypeColumnOnCallTableColumn? Type1718 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FilterDateTypeColumnOnCallTableOperator? Type1719 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FilterStructuredOutputColumnOnCallTableColumn? Type1720 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FilterStructuredOutputColumnOnCallTableOperator? Type1721 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FilterStringArrayTypeColumnOnCallTableColumn? Type1722 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FilterStringArrayTypeColumnOnCallTableOperator? Type1723 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FilterNumberArrayTypeColumnOnCallTableColumn? Type1724 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FilterNumberArrayTypeColumnOnCallTableOperator? Type1725 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.EventsTableStringConditionOperator? Type1726 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.EventsTableNumberConditionOperator? Type1727 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.EventsTableBooleanConditionOperator? Type1728 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.BarInsightFromCallTable? Type1729 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.BarInsightFromCallTableType? Type1730 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.BarInsightFromCallTableGroupBy? Type1731 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.PieInsightFromCallTable? Type1732 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.PieInsightFromCallTableType? Type1733 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.PieInsightFromCallTableGroupBy? Type1734 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.LineInsightFromCallTable? Type1735 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.LineInsightFromCallTableType? Type1736 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.LineInsightFromCallTableGroupBy? Type1737 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TextInsightFromCallTable? Type1738 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TextInsightFromCallTableType? Type1739 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.InsightRunFormatPlan? Type1740 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.InsightRunFormatPlanFormat? Type1741 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.InsightRunDTO? Type1742 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.InsightRunResponse? Type1743 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.Insight? Type1744 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.InsightType? Type1745 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.InsightPaginatedResponse? Type1746 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.Insight>? Type1747 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.BoardLayout? Type1748 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.Board? Type1749 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.OneOf<global::Vapi.BoardInsightItem, global::Vapi.BoardMetricWidgetItem>>? Type1750 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OneOf<global::Vapi.BoardInsightItem, global::Vapi.BoardMetricWidgetItem>? Type1751 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.BoardInsightItem? Type1752 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.BoardMetricWidgetItem? Type1753 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.BoardItemPosition? Type1754 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.BoardItemSize? Type1755 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.BoardInsightItemType? Type1756 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.BoardMetricWidgetItemType? Type1757 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateBoardDTO? Type1758 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateBoardDTO? Type1759 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.BoardPaginatedResponse? Type1760 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.Board>? Type1761 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateEvalDTO? Type1762 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ChatEvalAssistantMessageMock? Type1763 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ChatEvalSystemMessageMock? Type1764 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ChatEvalToolResponseMessageMock? Type1765 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ChatEvalToolResponseMessageEvaluation? Type1766 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ChatEvalUserMessageMock? Type1767 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ChatEvalAssistantMessageEvaluation? Type1768 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateEvalDTOType? Type1769 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.Eval? Type1770 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.EvalType? Type1771 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.EvalModelListOptions? Type1772 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.EvalModelListOptionsProvider? Type1773 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.EvalUserEditable? Type1774 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.EvalUserEditableType? Type1775 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ChatEvalAssistantMessageMockToolCall? Type1776 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ChatEvalAssistantMessageMockRole? Type1777 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.ChatEvalAssistantMessageMockToolCall>? Type1778 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ChatEvalSystemMessageMockRole? Type1779 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ChatEvalToolResponseMessageMockRole? Type1780 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ChatEvalUserMessageMockRole? Type1781 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AssistantMessageEvaluationContinuePlan? Type1782 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ChatEvalAssistantMessageEvaluationRole? Type1783 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OneOf<global::Vapi.AssistantMessageJudgePlanExact, global::Vapi.AssistantMessageJudgePlanRegex, global::Vapi.AssistantMessageJudgePlanAI>? Type1784 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AssistantMessageJudgePlanExact? Type1785 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AssistantMessageJudgePlanRegex? Type1786 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AssistantMessageJudgePlanAI? Type1787 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.EvalOpenAIModel? Type1788 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.EvalOpenAIModelProvider? Type1789 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.EvalOpenAIModelModel? Type1790 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.EvalAnthropicModel? Type1791 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.EvalAnthropicModelProvider? Type1792 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.EvalAnthropicModelModel? Type1793 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.EvalGoogleModel? Type1794 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.EvalGoogleModelProvider? Type1795 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.EvalGoogleModelModel? Type1796 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.EvalGroqModel? Type1797 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.EvalGroqModelProvider? Type1798 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.EvalGroqModelModel? Type1799 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.EvalCustomModel? Type1800 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.EvalCustomModelProvider? Type1801 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OneOf<global::Vapi.EvalOpenAIModel, global::Vapi.EvalAnthropicModel, global::Vapi.EvalGoogleModel, global::Vapi.EvalCustomModel>? Type1802 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AssistantMessageJudgePlanAIType? Type1803 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ChatEvalToolResponseMessageEvaluationRole? Type1804 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AssistantMessageJudgePlanExactType? Type1805 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AssistantMessageJudgePlanRegexType? Type1806 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GetEvalPaginatedDTO? Type1807 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GetEvalPaginatedDTOSortOrder? Type1808 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GetEvalPaginatedDTOSortBy? Type1809 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.EvalPaginatedResponse? Type1810 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.Eval>? Type1811 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateEvalDTO? Type1812 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateEvalDTOType? Type1813 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateEvalRunDTO? Type1814 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OneOf<global::Vapi.EvalRunTargetAssistant, global::Vapi.EvalRunTargetSquad>? Type1815 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.EvalRunTargetAssistant? Type1816 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.EvalRunTargetSquad? Type1817 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateEvalRunDTOType? Type1818 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.EvalRunResult? Type1819 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.EvalRunResultStatus? Type1820 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OneOf<global::Vapi.ChatEvalUserMessageMock, global::Vapi.ChatEvalSystemMessageMock, global::Vapi.ChatEvalToolResponseMessageMock, global::Vapi.ChatEvalAssistantMessageMock>? Type1821 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.EvalRun? Type1822 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.EvalRunStatus? Type1823 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.EvalRunEndedReason? Type1824 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.EvalRunResult>? Type1825 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.EvalRunType? Type1826 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.EvalRunPaginatedResponse? Type1827 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.EvalRun>? Type1828 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GetEvalRunPaginatedDTO? Type1829 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GetEvalRunPaginatedDTOSortOrder? Type1830 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GetEvalRunPaginatedDTOSortBy? Type1831 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.EvalRunTargetAssistantType? Type1832 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.EvalRunTargetSquadType? Type1833 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.Scorecard? Type1834 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ScorecardPaginatedResponse? Type1835 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.Scorecard>? Type1836 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateScorecardDTO? Type1837 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateOrgDTO? Type1838 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateOrgDTOChannel? Type1839 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AutoReloadPlan? Type1840 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.InvoicePlan? Type1841 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.Subscription? Type1842 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SubscriptionType? Type1843 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SubscriptionStatus? Type1844 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SubscriptionMinutesIncludedResetFrequency? Type1845 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.Org? Type1846 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OrgChannel? Type1847 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateOrgDTO? Type1848 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateOrgDTOChannel? Type1849 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.User? Type1850 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.InviteUserDTO? Type1851 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OneOf<global::Vapi.InviteUserDTORole?, string>? Type1852 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.InviteUserDTORole? Type1853 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.PendingInvitationDTO? Type1854 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.PendingInvitationsResponseDTO? Type1855 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.PendingInvitationDTO>? Type1856 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.RevokeInvitationResponseDTO? Type1857 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateUserRoleDTO? Type1858 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OneOf<global::Vapi.UpdateUserRoleDTORole?, string>? Type1859 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateUserRoleDTORole? Type1860 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.JwtResponse? Type1861 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TokenRestrictions? Type1862 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateTokenDTO? Type1863 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateTokenDTOTag? Type1864 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.Token? Type1865 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TokenTag? Type1866 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateTokenDTO? Type1867 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateTokenDTOTag? Type1868 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AnthropicCredential? Type1869 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AnthropicCredentialProvider? Type1870 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AWSStsAuthenticationArtifact? Type1871 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AWSStsAssumeRoleUser? Type1872 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AWSStsCredentials? Type1873 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AWSStsAuthenticationSession? Type1874 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AnthropicBedrockCredential? Type1875 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AnthropicBedrockCredentialProvider? Type1876 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AnthropicBedrockCredentialRegion? Type1877 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AnyscaleCredential? Type1878 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AnyscaleCredentialProvider? Type1879 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AssemblyAICredential? Type1880 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AssemblyAICredentialProvider? Type1881 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AzureCredential? Type1882 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AzureCredentialProvider? Type1883 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AzureCredentialService? Type1884 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AzureCredentialRegion? Type1885 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AzureOpenAICredential? Type1886 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AzureOpenAICredentialProvider? Type1887 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AzureOpenAICredentialRegion? Type1888 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.AzureOpenAICredentialModel>? Type1889 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AzureOpenAICredentialModel? Type1890 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ByoSipTrunkCredential? Type1891 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ByoSipTrunkCredentialProvider? Type1892 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CartesiaCredential? Type1893 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CartesiaCredentialProvider? Type1894 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CerebrasCredential? Type1895 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CerebrasCredentialProvider? Type1896 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CloudflareCredential? Type1897 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CloudflareCredentialProvider? Type1898 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.Oauth2AuthenticationSession? Type1899 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CustomLLMCredential? Type1900 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CustomLLMCredentialProvider? Type1901 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.DeepgramCredential? Type1902 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.DeepgramCredentialProvider? Type1903 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.DeepInfraCredential? Type1904 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.DeepInfraCredentialProvider? Type1905 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.DeepSeekCredential? Type1906 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.DeepSeekCredentialProvider? Type1907 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ElevenLabsCredential? Type1908 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ElevenLabsCredentialProvider? Type1909 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ElevenLabsCredentialApiUrl? Type1910 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GcpCredential? Type1911 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GcpCredentialProvider? Type1912 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GladiaCredential? Type1913 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GladiaCredentialProvider? Type1914 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GoHighLevelCredential? Type1915 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GoHighLevelCredentialProvider? Type1916 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GoogleCredential? Type1917 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GoogleCredentialProvider? Type1918 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GroqCredential? Type1919 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GroqCredentialProvider? Type1920 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.HumeCredential? Type1921 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.HumeCredentialProvider? Type1922 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.InflectionAICredential? Type1923 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.InflectionAICredentialProvider? Type1924 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.LangfuseCredential? Type1925 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.LangfuseCredentialProvider? Type1926 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.LmntCredential? Type1927 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.LmntCredentialProvider? Type1928 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.MakeCredential? Type1929 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.MakeCredentialProvider? Type1930 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.MicrosoftCredential? Type1931 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.MicrosoftCredentialProvider? Type1932 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.MistralCredential? Type1933 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.MistralCredentialProvider? Type1934 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.NeuphonicCredential? Type1935 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.NeuphonicCredentialProvider? Type1936 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OpenAICredential? Type1937 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OpenAICredentialProvider? Type1938 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OpenRouterCredential? Type1939 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OpenRouterCredentialProvider? Type1940 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.PerplexityAICredential? Type1941 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.PerplexityAICredentialProvider? Type1942 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.PlayHTCredential? Type1943 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.PlayHTCredentialProvider? Type1944 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.RimeAICredential? Type1945 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.RimeAICredentialProvider? Type1946 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.RunpodCredential? Type1947 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.RunpodCredentialProvider? Type1948 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.WellSaidCredential? Type1949 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.WellSaidCredentialProvider? Type1950 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.S3Credential? Type1951 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.S3CredentialProvider? Type1952 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.S3CompatibleBucketPlan? Type1953 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.S3CompatibleStorageCredential? Type1954 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.S3CompatibleStorageCredentialProvider? Type1955 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SmallestAICredential? Type1956 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SmallestAICredentialProvider? Type1957 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SonioxCredential? Type1958 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SonioxCredentialProvider? Type1959 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SpeechmaticsCredential? Type1960 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SpeechmaticsCredentialProvider? Type1961 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SupabaseCredential? Type1962 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SupabaseCredentialProvider? Type1963 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TavusCredential? Type1964 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TavusCredentialProvider? Type1965 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TogetherAICredential? Type1966 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TogetherAICredentialProvider? Type1967 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TwilioCredential? Type1968 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TwilioCredentialProvider? Type1969 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.VonageCredential? Type1970 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.VonageCredentialProvider? Type1971 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.WebhookCredential? Type1972 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.WebhookCredentialProvider? Type1973 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AuthenticationPlan4? Type1974 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.WebhookCredentialAuthenticationPlanDiscriminator? Type1975 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.WebhookCredentialAuthenticationPlanDiscriminatorType? Type1976 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SpkiPemPublicKeyConfig? Type1977 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SpkiPemPublicKeyConfigFormat? Type1978 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.PublicKeyEncryptionPlan? Type1979 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.PublicKeyEncryptionPlanType? Type1980 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.PublicKeyEncryptionPlanAlgorithm? Type1981 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.PublicKeyEncryptionPlanPublicKeyDiscriminator? Type1982 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.PublicKeyEncryptionPlanPublicKeyDiscriminatorFormat? Type1983 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CustomCredential? Type1984 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CustomCredentialProvider? Type1985 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AuthenticationPlan5? Type1986 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CustomCredentialAuthenticationPlanDiscriminator? Type1987 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CustomCredentialAuthenticationPlanDiscriminatorType? Type1988 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CustomCredentialEncryptionPlanDiscriminator? Type1989 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CustomCredentialEncryptionPlanDiscriminatorType? Type1990 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.XAiCredential? Type1991 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.XAiCredentialProvider? Type1992 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GoogleCalendarOAuth2ClientCredential? Type1993 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GoogleCalendarOAuth2ClientCredentialProvider? Type1994 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GoogleCalendarOAuth2AuthorizationCredential? Type1995 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GoogleCalendarOAuth2AuthorizationCredentialProvider? Type1996 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GoogleSheetsOAuth2AuthorizationCredential? Type1997 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GoogleSheetsOAuth2AuthorizationCredentialProvider? Type1998 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SlackOAuth2AuthorizationCredential? Type1999 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SlackOAuth2AuthorizationCredentialProvider? Type2000 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GoHighLevelMCPCredential? Type2001 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GoHighLevelMCPCredentialProvider? Type2002 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.InworldCredential? Type2003 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.InworldCredentialProvider? Type2004 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.EmailCredential? Type2005 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.EmailCredentialProvider? Type2006 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SlackWebhookCredential? Type2007 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SlackWebhookCredentialProvider? Type2008 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateCerebrasCredentialDTOProvider? Type2009 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateGoogleCredentialDTOProvider? Type2010 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateHumeCredentialDTOProvider? Type2011 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateInflectionAICredentialDTOProvider? Type2012 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateMicrosoftCredentialDTOProvider? Type2013 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateMistralCredentialDTOProvider? Type2014 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateNeuphonicCredentialDTOProvider? Type2015 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateWellSaidCredentialDTOProvider? Type2016 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateS3CompatibleCredentialDTOProvider? Type2017 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateSonioxCredentialDTOProvider? Type2018 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateSpeechmaticsCredentialDTOProvider? Type2019 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateCustomCredentialDTOProvider? Type2020 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AuthenticationPlan6? Type2021 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateCustomCredentialDTOAuthenticationPlanDiscriminator? Type2022 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateCustomCredentialDTOAuthenticationPlanDiscriminatorType? Type2023 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateCustomCredentialDTOEncryptionPlanDiscriminator? Type2024 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateCustomCredentialDTOEncryptionPlanDiscriminatorType? Type2025 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateGoHighLevelMCPCredentialDTOProvider? Type2026 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateInworldCredentialDTOProvider? Type2027 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateEmailCredentialDTOProvider? Type2028 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateSlackWebhookCredentialDTOProvider? Type2029 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateAnthropicCredentialDTO? Type2030 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateAnthropicCredentialDTOProvider? Type2031 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateAnthropicBedrockCredentialDTO? Type2032 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateAnthropicBedrockCredentialDTOProvider? Type2033 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateAnthropicBedrockCredentialDTORegion? Type2034 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateAnyscaleCredentialDTO? Type2035 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateAnyscaleCredentialDTOProvider? Type2036 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateAssemblyAICredentialDTO? Type2037 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateAssemblyAICredentialDTOProvider? Type2038 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateAzureCredentialDTO? Type2039 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateAzureCredentialDTOProvider? Type2040 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateAzureCredentialDTOService? Type2041 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateAzureCredentialDTORegion? Type2042 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateAzureOpenAICredentialDTO? Type2043 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateAzureOpenAICredentialDTOProvider? Type2044 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateAzureOpenAICredentialDTORegion? Type2045 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.UpdateAzureOpenAICredentialDTOModel>? Type2046 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateAzureOpenAICredentialDTOModel? Type2047 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateByoSipTrunkCredentialDTO? Type2048 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateByoSipTrunkCredentialDTOProvider? Type2049 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateCartesiaCredentialDTO? Type2050 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateCartesiaCredentialDTOProvider? Type2051 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateCerebrasCredentialDTO? Type2052 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateCerebrasCredentialDTOProvider? Type2053 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateCloudflareCredentialDTO? Type2054 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateCloudflareCredentialDTOProvider? Type2055 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateCustomLLMCredentialDTO? Type2056 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateCustomLLMCredentialDTOProvider? Type2057 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateDeepgramCredentialDTO? Type2058 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateDeepgramCredentialDTOProvider? Type2059 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateDeepInfraCredentialDTO? Type2060 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateDeepInfraCredentialDTOProvider? Type2061 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateDeepSeekCredentialDTO? Type2062 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateDeepSeekCredentialDTOProvider? Type2063 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateElevenLabsCredentialDTO? Type2064 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateElevenLabsCredentialDTOProvider? Type2065 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateElevenLabsCredentialDTOApiUrl? Type2066 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateGcpCredentialDTO? Type2067 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateGcpCredentialDTOProvider? Type2068 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateGladiaCredentialDTO? Type2069 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateGladiaCredentialDTOProvider? Type2070 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateGoHighLevelCredentialDTO? Type2071 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateGoHighLevelCredentialDTOProvider? Type2072 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateGoogleCredentialDTO? Type2073 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateGoogleCredentialDTOProvider? Type2074 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateGroqCredentialDTO? Type2075 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateGroqCredentialDTOProvider? Type2076 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateHumeCredentialDTO? Type2077 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateHumeCredentialDTOProvider? Type2078 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateInflectionAICredentialDTO? Type2079 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateInflectionAICredentialDTOProvider? Type2080 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateLangfuseCredentialDTO? Type2081 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateLangfuseCredentialDTOProvider? Type2082 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateLmntCredentialDTO? Type2083 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateLmntCredentialDTOProvider? Type2084 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateMakeCredentialDTO? Type2085 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateMakeCredentialDTOProvider? Type2086 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateMicrosoftCredentialDTO? Type2087 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateMicrosoftCredentialDTOProvider? Type2088 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateMistralCredentialDTO? Type2089 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateMistralCredentialDTOProvider? Type2090 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateNeuphonicCredentialDTO? Type2091 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateNeuphonicCredentialDTOProvider? Type2092 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateOpenAICredentialDTO? Type2093 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateOpenAICredentialDTOProvider? Type2094 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateOpenRouterCredentialDTO? Type2095 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateOpenRouterCredentialDTOProvider? Type2096 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdatePerplexityAICredentialDTO? Type2097 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdatePerplexityAICredentialDTOProvider? Type2098 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdatePlayHTCredentialDTO? Type2099 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdatePlayHTCredentialDTOProvider? Type2100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateRimeAICredentialDTO? Type2101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateRimeAICredentialDTOProvider? Type2102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateRunpodCredentialDTO? Type2103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateRunpodCredentialDTOProvider? Type2104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateWellSaidCredentialDTO? Type2105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateWellSaidCredentialDTOProvider? Type2106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateS3CredentialDTO? Type2107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateS3CredentialDTOProvider? Type2108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateS3CompatibleBucketPlanDTO? Type2109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateS3CompatibleCredentialDTO? Type2110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateS3CompatibleCredentialDTOProvider? Type2111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateTogetherAICredentialDTO? Type2112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateTogetherAICredentialDTOProvider? Type2113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateTwilioCredentialDTO? Type2114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateTwilioCredentialDTOProvider? Type2115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateVonageCredentialDTO? Type2116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateVonageCredentialDTOProvider? Type2117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateWebhookCredentialDTO? Type2118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateWebhookCredentialDTOProvider? Type2119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AuthenticationPlan8? Type2120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateWebhookCredentialDTOAuthenticationPlanDiscriminator? Type2121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateWebhookCredentialDTOAuthenticationPlanDiscriminatorType? Type2122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateCustomCredentialDTO? Type2123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateCustomCredentialDTOProvider? Type2124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AuthenticationPlan9? Type2125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateCustomCredentialDTOAuthenticationPlanDiscriminator? Type2126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateCustomCredentialDTOAuthenticationPlanDiscriminatorType? Type2127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateCustomCredentialDTOEncryptionPlanDiscriminator? Type2128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateCustomCredentialDTOEncryptionPlanDiscriminatorType? Type2129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateXAiCredentialDTO? Type2130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateXAiCredentialDTOProvider? Type2131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateGoogleCalendarOAuth2ClientCredentialDTO? Type2132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateGoogleCalendarOAuth2ClientCredentialDTOProvider? Type2133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateGoogleCalendarOAuth2AuthorizationCredentialDTO? Type2134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateGoogleCalendarOAuth2AuthorizationCredentialDTOProvider? Type2135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateGoogleSheetsOAuth2AuthorizationCredentialDTO? Type2136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateGoogleSheetsOAuth2AuthorizationCredentialDTOProvider? Type2137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateSlackOAuth2AuthorizationCredentialDTO? Type2138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateSlackOAuth2AuthorizationCredentialDTOProvider? Type2139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateGoHighLevelMCPCredentialDTO? Type2140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateGoHighLevelMCPCredentialDTOProvider? Type2141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateInworldCredentialDTO? Type2142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateInworldCredentialDTOProvider? Type2143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateEmailCredentialDTO? Type2144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateEmailCredentialDTOProvider? Type2145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateSlackWebhookCredentialDTO? Type2146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateSlackWebhookCredentialDTOProvider? Type2147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateSonioxCredentialDTO? Type2148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateSonioxCredentialDTOProvider? Type2149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CredentialSessionResponse? Type2150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CredentialEndUser? Type2151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CredentialSessionError? Type2152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CredentialWebhookDTO? Type2153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CredentialWebhookDTOType? Type2154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CredentialWebhookDTOOperation? Type2155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CredentialWebhookDTOAuthMode? Type2156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CredentialActionRequest? Type2157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.HMACAuthenticationPlanType? Type2158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.HMACAuthenticationPlanAlgorithm? Type2159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.HMACAuthenticationPlanSignatureEncoding? Type2160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.BearerAuthenticationPlanType? Type2161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AWSIAMCredentialsAuthenticationPlanType? Type2162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AWSStsAuthenticationPlanType? Type2163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ToolTemplateSetup? Type2164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.MakeToolProviderDetails? Type2165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.ToolTemplateSetup>? Type2166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.MakeToolProviderDetailsType? Type2167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GhlToolProviderDetails? Type2168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GhlToolProviderDetailsType? Type2169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FunctionToolProviderDetails? Type2170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FunctionToolProviderDetailsType? Type2171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GoogleCalendarCreateEventToolProviderDetails? Type2172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GoogleCalendarCreateEventToolProviderDetailsType? Type2173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GoogleSheetsRowAppendToolProviderDetails? Type2174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GoogleSheetsRowAppendToolProviderDetailsType? Type2175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GoHighLevelCalendarAvailabilityToolProviderDetails? Type2176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GoHighLevelCalendarAvailabilityToolProviderDetailsType? Type2177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GoHighLevelCalendarEventCreateToolProviderDetails? Type2178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GoHighLevelCalendarEventCreateToolProviderDetailsType? Type2179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GoHighLevelContactCreateToolProviderDetails? Type2180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GoHighLevelContactCreateToolProviderDetailsType? Type2181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GoHighLevelContactGetToolProviderDetails? Type2182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GoHighLevelContactGetToolProviderDetailsType? Type2183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ToolTemplateMetadata? Type2184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateToolTemplateDTO? Type2185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateToolTemplateDTOVisibility? Type2186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateToolTemplateDTOType? Type2187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateToolTemplateDTOProvider? Type2188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.Template? Type2189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TemplateVisibility? Type2190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TemplateType? Type2191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TemplateProvider? Type2192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateToolTemplateDTO? Type2193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateToolTemplateDTOVisibility? Type2194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateToolTemplateDTOType? Type2195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateToolTemplateDTOProvider? Type2196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.VoiceLibrary? Type2197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.VoiceLibraryGender? Type2198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SyncVoiceLibraryDTO? Type2199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.SyncVoiceLibraryDTOProvider>? Type2200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SyncVoiceLibraryDTOProvider? Type2201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateSesameVoiceDTO? Type2202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateVoiceLibraryMetadataDTO? Type2203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CartesiaPronunciationDictItem? Type2204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CartesiaPronunciationDictionary? Type2205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.CartesiaPronunciationDictItem>? Type2206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ElevenLabsPronunciationDictionary? Type2207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ElevenLabsPronunciationDictionaryPermissionOnResource? Type2208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ProviderResource? Type2209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ProviderResourceProvider? Type2210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ProviderResourceResourceName? Type2211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ProviderResourcePaginatedResponse? Type2212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.ProviderResource>? Type2213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.VoiceLibraryVoiceResponse? Type2214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OneOf<string, double?>? Type2215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AddVoiceToProviderDTO? Type2216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CloneVoiceDTO? Type2217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<byte[]>? Type2218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.VapiVoiceCloneDTO? Type2219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.VariableValueGroupBy? Type2220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TimeRange? Type2221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TimeRangeStep? Type2222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AnalyticsOperation? Type2223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AnalyticsOperationOperation? Type2224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AnalyticsOperationColumn? Type2225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AnalyticsQuery? Type2226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AnalyticsQueryTable? Type2227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.AnalyticsQueryGroupByItem>? Type2228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AnalyticsQueryGroupByItem? Type2229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.VariableValueGroupBy>? Type2230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.AnalyticsOperation>? Type2231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AnalyticsQueryDTO? Type2232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.AnalyticsQuery>? Type2233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AnalyticsQueryResult? Type2234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ClientMessageWorkflowNodeStarted? Type2235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ClientMessageWorkflowNodeStartedType? Type2236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ClientMessageAssistantStarted? Type2237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ClientMessageAssistantStartedType? Type2238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ClientMessageConversationUpdate? Type2239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ClientMessageConversationUpdateType? Type2240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ClientMessageHang? Type2241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ClientMessageHangType? Type2242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ClientMessageMetadata? Type2243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ClientMessageMetadataType? Type2244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ClientMessageModelOutput? Type2245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ClientMessageModelOutputType? Type2246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ClientMessageSpeechUpdate? Type2247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ClientMessageSpeechUpdateType? Type2248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ClientMessageSpeechUpdateStatus? Type2249 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ClientMessageSpeechUpdateRole? Type2250 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ClientMessageTranscript? Type2251 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ClientMessageTranscriptType? Type2252 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ClientMessageTranscriptRole? Type2253 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ClientMessageTranscriptTranscriptType? Type2254 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ClientMessageToolCalls? Type2255 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ClientMessageToolCallsType? Type2256 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FunctionToolWithToolCall? Type2257 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GhlToolWithToolCall? Type2258 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.MakeToolWithToolCall? Type2259 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.BashToolWithToolCall? Type2260 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ComputerToolWithToolCall? Type2261 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TextEditorToolWithToolCall? Type2262 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GoogleCalendarCreateEventToolWithToolCall? Type2263 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ClientMessageToolCallsResult? Type2264 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ClientMessageToolCallsResultType? Type2265 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ClientMessageTransferUpdate? Type2266 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ClientMessageTransferUpdateType? Type2267 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ClientMessageUserInterrupted? Type2268 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ClientMessageUserInterruptedType? Type2269 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ClientMessageLanguageChangeDetected? Type2270 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ClientMessageLanguageChangeDetectedType? Type2271 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ClientMessageVoiceInput? Type2272 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ClientMessageVoiceInputType? Type2273 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ClientMessageAssistantSpeech? Type2274 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ClientMessageAssistantSpeechType? Type2275 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ClientMessageAssistantSpeechSource? Type2276 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.Timing? Type2277 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ClientMessageAssistantSpeechTimingDiscriminator? Type2278 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ClientMessageAssistantSpeechTimingDiscriminatorType? Type2279 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ClientMessageChatCreated? Type2280 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ClientMessageChatCreatedType? Type2281 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ClientMessageChatDeleted? Type2282 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ClientMessageChatDeletedType? Type2283 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ClientMessageSessionCreated? Type2284 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ClientMessageSessionCreatedType? Type2285 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ClientMessageSessionUpdated? Type2286 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ClientMessageSessionUpdatedType? Type2287 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ClientMessageSessionDeleted? Type2288 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ClientMessageSessionDeletedType? Type2289 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ClientMessageCallDeleted? Type2290 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ClientMessageCallDeletedType? Type2291 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ClientMessageCallDeleteFailed? Type2292 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ClientMessageCallDeleteFailedType? Type2293 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ClientMessage? Type2294 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ServerMessageAssistantRequest? Type2295 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ServerMessageAssistantRequestType? Type2296 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ServerMessageConversationUpdate? Type2297 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ServerMessageConversationUpdateType? Type2298 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ServerMessageEndOfCallReport? Type2299 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ServerMessageEndOfCallReportType? Type2300 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ServerMessageEndOfCallReportEndedReason? Type2301 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ServerMessageHandoffDestinationRequest? Type2302 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ServerMessageHandoffDestinationRequestType? Type2303 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ServerMessageHang? Type2304 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ServerMessageHangType? Type2305 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ServerMessageKnowledgeBaseRequest? Type2306 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ServerMessageKnowledgeBaseRequestType? Type2307 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ServerMessageModelOutput? Type2308 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ServerMessageModelOutputType? Type2309 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ServerMessagePhoneCallControl? Type2310 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ServerMessagePhoneCallControlType? Type2311 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ServerMessagePhoneCallControlRequest? Type2312 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ServerMessageSpeechUpdate? Type2313 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ServerMessageSpeechUpdateType? Type2314 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ServerMessageSpeechUpdateStatus? Type2315 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ServerMessageSpeechUpdateRole? Type2316 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ServerMessageStatusUpdate? Type2317 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ServerMessageStatusUpdateType? Type2318 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ServerMessageStatusUpdateStatus? Type2319 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ServerMessageStatusUpdateEndedReason? Type2320 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ServerMessageToolCalls? Type2321 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ServerMessageToolCallsType? Type2322 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ServerMessageTransferDestinationRequest? Type2323 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ServerMessageTransferDestinationRequestType? Type2324 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ServerMessageTransferUpdate? Type2325 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ServerMessageTransferUpdateType? Type2326 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ServerMessageTranscript? Type2327 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ServerMessageTranscriptType? Type2328 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ServerMessageTranscriptRole? Type2329 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ServerMessageTranscriptTranscriptType? Type2330 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ServerMessageUserInterrupted? Type2331 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ServerMessageUserInterruptedType? Type2332 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ServerMessageLanguageChangeDetected? Type2333 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ServerMessageLanguageChangeDetectedType? Type2334 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ServerMessageVoiceInput? Type2335 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ServerMessageVoiceInputType? Type2336 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ServerMessageAssistantSpeech? Type2337 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ServerMessageAssistantSpeechType? Type2338 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ServerMessageAssistantSpeechSource? Type2339 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.Timing2? Type2340 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ServerMessageAssistantSpeechTimingDiscriminator? Type2341 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ServerMessageAssistantSpeechTimingDiscriminatorType? Type2342 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ServerMessageVoiceRequest? Type2343 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ServerMessageVoiceRequestType? Type2344 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ServerMessageCallEndpointingRequest? Type2345 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ServerMessageCallEndpointingRequestType? Type2346 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ServerMessageChatCreated? Type2347 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ServerMessageChatCreatedType? Type2348 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ServerMessageChatDeleted? Type2349 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ServerMessageChatDeletedType? Type2350 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ServerMessageSessionCreated? Type2351 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ServerMessageSessionCreatedType? Type2352 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ServerMessageSessionUpdated? Type2353 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ServerMessageSessionUpdatedType? Type2354 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ServerMessageSessionDeleted? Type2355 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ServerMessageSessionDeletedType? Type2356 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ServerMessageCallDeleted? Type2357 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ServerMessageCallDeletedType? Type2358 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ServerMessageCallDeleteFailed? Type2359 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ServerMessageCallDeleteFailedType? Type2360 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CallArtifactUploadItem? Type2361 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CallArtifactUploadItemType? Type2362 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ServerMessageCallArtifactUpload? Type2363 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ServerMessageCallArtifactUploadType? Type2364 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.CallArtifactUploadItem>? Type2365 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CampaignContact? Type2366 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ServerMessageCampaignPredial? Type2367 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ServerMessageCampaignPredialType? Type2368 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ServerMessage? Type2369 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ServerMessageResponseAssistantRequest? Type2370 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ServerMessageResponseHandoffDestinationRequest? Type2371 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.KnowledgeBaseResponseDocument? Type2372 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ServerMessageResponseKnowledgeBaseRequest? Type2373 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.KnowledgeBaseResponseDocument>? Type2374 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ToolCallResult? Type2375 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OneOf<global::Vapi.ToolMessageComplete, global::Vapi.ToolMessageFailed>? Type2376 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ServerMessageResponseToolCalls? Type2377 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.ToolCallResult>? Type2378 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ServerMessageResponseTransferDestinationRequest? Type2379 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ServerMessageResponseVoiceRequest? Type2380 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ServerMessageResponseCallEndpointingRequest? Type2381 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ServerMessageResponseCampaignPredial? Type2382 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ServerMessageResponse? Type2383 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ClientInboundMessageAddMessage? Type2384 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ClientInboundMessageAddMessageType? Type2385 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ClientInboundMessageControl? Type2386 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ClientInboundMessageControlType? Type2387 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ClientInboundMessageControlControl? Type2388 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ClientInboundMessageSay? Type2389 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ClientInboundMessageSayType? Type2390 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ClientInboundMessageEndCall? Type2391 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ClientInboundMessageEndCallType? Type2392 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ClientInboundMessageTransfer? Type2393 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ClientInboundMessageTransferType? Type2394 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ClientInboundMessageSendTransportMessage? Type2395 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ClientInboundMessageSendTransportMessageType? Type2396 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OneOf<global::Vapi.VapiSipTransportMessage, global::Vapi.TwilioTransportMessage>? Type2397 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.VapiSipTransportMessage? Type2398 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TwilioTransportMessage? Type2399 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ClientInboundMessage? Type2400 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.KnowledgeBaseCostType? Type2401 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SessionCostType? Type2402 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FunctionToolWithToolCallType? Type2403 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GhlToolWithToolCallType? Type2404 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.MakeToolWithToolCallType? Type2405 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.BashToolWithToolCallType? Type2406 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.BashToolWithToolCallSubType? Type2407 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.BashToolWithToolCallName? Type2408 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ComputerToolWithToolCallType? Type2409 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ComputerToolWithToolCallSubType? Type2410 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ComputerToolWithToolCallName? Type2411 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TextEditorToolWithToolCallType? Type2412 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TextEditorToolWithToolCallSubType? Type2413 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TextEditorToolWithToolCallName? Type2414 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GoogleCalendarCreateEventToolWithToolCallType? Type2415 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GoogleSheetsRowAppendToolWithToolCall? Type2416 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GoogleSheetsRowAppendToolWithToolCallType? Type2417 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GoHighLevelCalendarAvailabilityToolWithToolCall? Type2418 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GoHighLevelCalendarAvailabilityToolWithToolCallType? Type2419 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GoHighLevelCalendarEventCreateToolWithToolCall? Type2420 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GoHighLevelCalendarEventCreateToolWithToolCallType? Type2421 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GoHighLevelContactCreateToolWithToolCall? Type2422 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GoHighLevelContactCreateToolWithToolCallType? Type2423 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GoHighLevelContactGetToolWithToolCall? Type2424 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GoHighLevelContactGetToolWithToolCallType? Type2425 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.VapiSipTransportMessageTransport? Type2426 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.VapiSipTransportMessageSipVerb? Type2427 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TwilioTransportMessageTransport? Type2428 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.PhoneNumberControllerCreateRequest? Type2429 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.PhoneNumberControllerCreateRequestDiscriminator? Type2430 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.PhoneNumberControllerCreateRequestDiscriminatorProvider? Type2431 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.PhoneNumberControllerUpdateRequest? Type2432 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.PhoneNumberControllerUpdateRequestDiscriminator? Type2433 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.PhoneNumberControllerUpdateRequestDiscriminatorProvider? Type2434 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ToolControllerCreateRequest? Type2435 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ToolControllerCreateRequestDiscriminator? Type2436 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ToolControllerCreateRequestDiscriminatorType? Type2437 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ToolControllerUpdateRequest? Type2438 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ToolControllerUpdateRequestDiscriminator? Type2439 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ToolControllerUpdateRequestDiscriminatorType? Type2440 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.InsightControllerCreateRequest? Type2441 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.InsightControllerCreateRequestDiscriminator? Type2442 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.InsightControllerCreateRequestDiscriminatorType? Type2443 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.InsightControllerUpdateRequest? Type2444 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.InsightControllerUpdateRequestDiscriminator? Type2445 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.InsightControllerUpdateRequestDiscriminatorType? Type2446 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.InsightControllerPreviewRequest? Type2447 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.InsightControllerPreviewRequestDiscriminator? Type2448 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.InsightControllerPreviewRequestDiscriminatorType? Type2449 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ChatControllerListChatsSortOrder? Type2450 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ChatControllerListChatsSortBy? Type2451 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CampaignControllerFindAllStatus? Type2452 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CampaignControllerFindAllSortOrder? Type2453 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CampaignControllerFindAllSortBy? Type2454 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CampaignControllerFindAllV2Status? Type2455 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CampaignControllerFindAllV2SortOrder? Type2456 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CampaignControllerFindAllV2SortBy? Type2457 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.CampaignControllerGetCampaignV2ContactsStatu>? Type2458 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CampaignControllerGetCampaignV2ContactsStatu? Type2459 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CampaignControllerGetCampaignV2ContactsSortBy? Type2460 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SessionControllerFindAllPaginatedSortOrder? Type2461 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SessionControllerFindAllPaginatedSortBy? Type2462 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.PhoneNumberControllerFindAllPaginatedSortOrder? Type2463 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.PhoneNumberControllerFindAllPaginatedSortBy? Type2464 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.StructuredOutputControllerFindAllSortOrder? Type2465 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.StructuredOutputControllerFindAllSortBy? Type2466 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.PersonalityControllerFindAllSortOrder? Type2467 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.PersonalityControllerFindAllSortBy? Type2468 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ScenarioControllerFindAllSortOrder? Type2469 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ScenarioControllerFindAllSortBy? Type2470 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SimulationRunControllerFindAllStatus? Type2471 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SimulationRunControllerFindAllFilterStatus? Type2472 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SimulationRunControllerFindAllTargetType? Type2473 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SimulationRunControllerFindAllSortOrder? Type2474 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SimulationRunControllerFindAllSortBy? Type2475 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SimulationRunControllerFindItemsStatus? Type2476 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SimulationRunControllerFindItemsSortOrder? Type2477 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SimulationRunControllerFindItemsSortBy? Type2478 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SimulationSuiteControllerFindAllSortOrder? Type2479 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SimulationSuiteControllerFindAllSortBy? Type2480 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SimulationControllerFindAllSortOrder? Type2481 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SimulationControllerFindAllSortBy? Type2482 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.InsightControllerFindAllSortOrder? Type2483 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.InsightControllerFindAllSortBy? Type2484 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.BoardControllerFindAllSortOrder? Type2485 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.BoardControllerFindAllSortBy? Type2486 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.EvalControllerGetPaginatedSortOrder? Type2487 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.EvalControllerGetPaginatedSortBy? Type2488 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.EvalControllerGetRunsPaginatedSortOrder? Type2489 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.EvalControllerGetRunsPaginatedSortBy? Type2490 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ScorecardControllerGetPaginatedSortOrder? Type2491 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ScorecardControllerGetPaginatedSortBy? Type2492 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ProviderResourceControllerCreateProviderResourceProvider? Type2493 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ProviderResourceControllerCreateProviderResourceResourceName? Type2494 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ProviderResourceControllerGetProviderResourcesPaginatedProvider? Type2495 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ProviderResourceControllerGetProviderResourcesPaginatedResourceName? Type2496 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ProviderResourceControllerGetProviderResourcesPaginatedSortOrder? Type2497 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ProviderResourceControllerGetProviderResourcesPaginatedSortBy? Type2498 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ProviderResourceControllerGetProviderResourceProvider? Type2499 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ProviderResourceControllerGetProviderResourceResourceName? Type2500 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ProviderResourceControllerDeleteProviderResourceProvider? Type2501 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ProviderResourceControllerDeleteProviderResourceResourceName? Type2502 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ProviderResourceControllerUpdateProviderResourceProvider? Type2503 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ProviderResourceControllerUpdateProviderResourceResourceName? Type2504 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.Squad>? Type2505 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OneOf<global::Vapi.Call, global::Vapi.CallBatchResponse>? Type2506 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OneOf<global::Vapi.Chat, global::Vapi.CreateChatStreamResponse>? Type2507 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OneOf<global::Vapi.ResponseObject, global::Vapi.ResponseTextDeltaEvent, global::Vapi.ResponseTextDoneEvent, global::Vapi.ResponseCompletedEvent, global::Vapi.ResponseErrorEvent>? Type2508 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.PhoneNumberControllerCreateResponse? Type2509 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.PhoneNumberControllerCreateResponseDiscriminator? Type2510 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.PhoneNumberControllerCreateResponseDiscriminatorProvider? Type2511 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.PhoneNumberControllerFindAllResponseItem>? Type2512 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.PhoneNumberControllerFindAllResponseItem? Type2513 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.PhoneNumberControllerFindAllResponseItemDiscriminator? Type2514 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.PhoneNumberControllerFindAllResponseItemDiscriminatorProvider? Type2515 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.PhoneNumberControllerFindOneResponse? Type2516 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.PhoneNumberControllerFindOneResponseDiscriminator? Type2517 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.PhoneNumberControllerFindOneResponseDiscriminatorProvider? Type2518 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.PhoneNumberControllerUpdateResponse? Type2519 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.PhoneNumberControllerUpdateResponseDiscriminator? Type2520 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.PhoneNumberControllerUpdateResponseDiscriminatorProvider? Type2521 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.PhoneNumberControllerRemoveResponse? Type2522 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.PhoneNumberControllerRemoveResponseDiscriminator? Type2523 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.PhoneNumberControllerRemoveResponseDiscriminatorProvider? Type2524 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ToolControllerCreateResponse? Type2525 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ToolControllerCreateResponseDiscriminator? Type2526 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ToolControllerCreateResponseDiscriminatorType? Type2527 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.ToolControllerFindAllResponseItem>? Type2528 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ToolControllerFindAllResponseItem? Type2529 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ToolControllerFindAllResponseItemDiscriminator? Type2530 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ToolControllerFindAllResponseItemDiscriminatorType? Type2531 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ToolControllerFindOneResponse? Type2532 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ToolControllerFindOneResponseDiscriminator? Type2533 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ToolControllerFindOneResponseDiscriminatorType? Type2534 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ToolControllerUpdateResponse? Type2535 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ToolControllerUpdateResponseDiscriminator? Type2536 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ToolControllerUpdateResponseDiscriminatorType? Type2537 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ToolControllerRemoveResponse? Type2538 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ToolControllerRemoveResponseDiscriminator? Type2539 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ToolControllerRemoveResponseDiscriminatorType? Type2540 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.File>? Type2541 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.KnowledgeBaseV2>? Type2542 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OneOf<global::Vapi.AllOf<global::Vapi.StructuredOutputRunPreviewResponse, object>?, global::Vapi.StructuredOutputRerunResponse>? Type2543 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AllOf<global::Vapi.StructuredOutputRunPreviewResponse, object>? Type2544 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.Personality>? Type2545 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.Scenario>? Type2546 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OneOf<global::System.Collections.Generic.IList<global::Vapi.SimulationRun>, global::Vapi.SimulationRunsPaginatedResponse>? Type2547 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.SimulationRun>? Type2548 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.SimulationRunItem>? Type2549 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.SimulationSuite>? Type2550 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.Simulation>? Type2551 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.InsightControllerCreateResponse? Type2552 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.InsightControllerCreateResponseDiscriminator? Type2553 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.InsightControllerCreateResponseDiscriminatorType? Type2554 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.InsightControllerUpdateResponse? Type2555 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.InsightControllerUpdateResponseDiscriminator? Type2556 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.InsightControllerUpdateResponseDiscriminatorType? Type2557 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.InsightControllerFindOneResponse? Type2558 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.InsightControllerFindOneResponseDiscriminator? Type2559 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.InsightControllerFindOneResponseDiscriminatorType? Type2560 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.InsightControllerRemoveResponse? Type2561 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.InsightControllerRemoveResponseDiscriminator? Type2562 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.InsightControllerRemoveResponseDiscriminatorType? Type2563 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.AnalyticsQueryResult>? Type2564 { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.AssemblyAITranscriberLanguageCode>? ListType0 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<string>? ListType1 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<object>? ListType2 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.DeepgramTranscriberRedactionItem>? ListType3 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.OneOf<string, global::Vapi.GladiaVocabularyItemDTO>>? ListType4 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.GladiaTranscriberLanguage2>? ListType5 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.SonioxTranscriberLanguage2>? ListType6 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.SonioxContextGeneralItem>? ListType7 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.SpeechmaticsCustomVocabularyItem>? ListType8 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.VapiTranscriberLanguage2>? ListType9 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.FallbackAssemblyAITranscriberLanguageCode>? ListType10 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.FallbackDeepgramTranscriberRedactionItem>? ListType11 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.FallbackGladiaTranscriberLanguage2>? ListType12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.FallbackSonioxTranscriberLanguage2>? ListType13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.TextContent>? ListType14 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.Condition>? ListType15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.OneOf<global::Vapi.RegexCondition, global::Vapi.LiquidCondition, global::Vapi.GroupCondition>>? ListType16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.OneOf<global::Vapi.ToolMessageStart, global::Vapi.ToolMessageComplete, global::Vapi.ToolMessageFailed, global::Vapi.ToolMessageDelayed>>? ListType17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.VariableExtractionAlias>? ListType18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.ToolParameter>? ListType19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.RegexOption>? ListType20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.OneOf<global::Vapi.AssistantCustomEndpointingRule, global::Vapi.CustomerCustomEndpointingRule, global::Vapi.BothCustomEndpointingRule>>? ListType21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.OneOf<global::Vapi.TransferDestinationAssistant, global::Vapi.TransferDestinationNumber, global::Vapi.TransferDestinationSip>>? ListType22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.OneOf<global::Vapi.TransferDestinationAssistant, global::Vapi.HandoffDestinationAssistant>>? ListType23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.SquadMemberDTO>? ListType24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.OneOf<global::Vapi.HandoffDestinationAssistant, global::Vapi.HandoffDestinationDynamic, global::Vapi.HandoffDestinationSquad>>? ListType25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.KnowledgeBase>? ListType26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.McpToolMessages>? ListType27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.OpenAIMessage>? ListType28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.ToolRef>? ListType29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.OpenAIModelFallbackModel>? ListType30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.TwilioVoicemailDetectionPlanVoicemailDetectionType>? ListType31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OneOf<string, global::System.Collections.Generic.List<string>>? ListType32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OneOf<string, global::System.Collections.Generic.List<global::Vapi.OneOf<global::Vapi.SystemMessage, global::Vapi.UserMessage, global::Vapi.AssistantMessage, global::Vapi.ToolMessage, global::Vapi.DeveloperMessage>>>? ListType33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.OneOf<global::Vapi.SystemMessage, global::Vapi.UserMessage, global::Vapi.AssistantMessage, global::Vapi.ToolMessage, global::Vapi.DeveloperMessage>>? ListType34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.OneOf<global::Vapi.ToolCallHookAction, global::Vapi.MessageAddHookAction>>? ListType35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.CallHookFilter>? ListType36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.OneOf<global::Vapi.SayHookAction, global::Vapi.ToolCallHookAction, global::Vapi.MessageAddHookAction>>? ListType37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.SecurityFilterBase>? ListType38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.StructuredDataMultiPlan>? ListType39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.OneOf<global::Vapi.MinMessagesCondition, global::Vapi.MinCallDurationCondition, global::Vapi.EndedReasonCondition>>? ListType40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.OneOf<global::Vapi.NumberComparatorScorecardMetricCondition, global::Vapi.BooleanComparatorScorecardMetricCondition>>? ListType41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.ScorecardMetric>? ListType42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.CreateStructuredOutputDTO>? ListType43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.CreateScorecardDTO>? ListType44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.OneOf<global::Vapi.ConversationNode, global::Vapi.ToolNode>>? ListType45 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.CredentialsItem>? ListType46 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.Edge>? ListType47 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.OneOf<global::Vapi.ExactReplacement, global::Vapi.RegexReplacement>>? ListType48 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.FormatPlanFormattersEnabledItem>? ListType49 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.ChunkPlanPunctuationBoundarie>? ListType50 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.ElevenLabsPronunciationDictionaryLocator>? ListType51 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.VapiPronunciationDictionaryLocator>? ListType52 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.CreateAzureOpenAICredentialDTOModel>? ListType53 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.SipTrunkGateway>? ListType54 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.ToolCallHookAction>? ListType55 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.AssistantOverridesClientMessage>? ListType56 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.AssistantOverridesServerMessage>? ListType57 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.TransportConfigurationTwilio>? ListType58 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.CredentialsItem2>? ListType59 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.CreateAssistantDTOClientMessage>? ListType60 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.CreateAssistantDTOServerMessage>? ListType61 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.CredentialsItem3>? ListType62 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.AssistantClientMessage>? ListType63 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.AssistantServerMessage>? ListType64 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.CredentialsItem4>? ListType65 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.Assistant>? ListType66 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.AssistantDraftClientMessage>? ListType67 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.AssistantDraftServerMessage>? ListType68 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.CredentialsItem5>? ListType69 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.AssistantDraft>? ListType70 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.LegacyAssistantVersion>? ListType71 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.AssistantVersionClientMessage>? ListType72 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.AssistantVersionServerMessage>? ListType73 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.CredentialsItem6>? ListType74 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.AssistantVersion>? ListType75 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.VersionPinReference>? ListType76 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.CreateAssistantDraftDTOClientMessage>? ListType77 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.CreateAssistantDraftDTOServerMessage>? ListType78 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.CredentialsItem7>? ListType79 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.UpdateAssistantDraftDTOClientMessage>? ListType80 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.UpdateAssistantDraftDTOServerMessage>? ListType81 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.CredentialsItem8>? ListType82 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.UpdateAssistantDTOClientMessage>? ListType83 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.UpdateAssistantDTOServerMessage>? ListType84 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.CredentialsItem9>? ListType85 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.CredentialsItem10>? ListType86 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.CredentialsItem11>? ListType87 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.CredentialsItem12>? ListType88 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.ToolCallResultMessageWarning>? ListType89 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.StructuredOutputCostBreakdown>? ListType90 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.MonitorResult>? ListType91 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.OneOf<global::Vapi.UserMessage, global::Vapi.SystemMessage, global::Vapi.BotMessage, global::Vapi.ToolCallMessage, global::Vapi.ToolCallResultMessage>>? ListType92 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.TurnLatency>? ListType93 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.TransferArtifact>? ListType94 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.NodeArtifact>? ListType95 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.AssistantActivation>? ListType96 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.PhoneNumberCallRingingHookFilter>? ListType97 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.OneOf<global::Vapi.TransferPhoneNumberHookAction, global::Vapi.SayPhoneNumberHookAction>>? ListType98 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.PhoneNumberCallEndingHookFilterOneOfItem>? ListType99 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.PhoneNumberCallEndingHookFilter>? ListType100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.OneOf<global::Vapi.PhoneNumberHookCallRinging, global::Vapi.PhoneNumberHookCallEnding>>? ListType101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.Call>? ListType102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.CallBatchError>? ListType103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<double>? ListType104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.AssistantSpeechWordTimestamp>? ListType105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.CreateCustomerDTO>? ListType106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.ToolCall>? ListType107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.OneOf<global::Vapi.ModelCost, global::Vapi.ChatCost>>? ListType108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.Chat>? ListType109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.ResponseOutputText>? ListType110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.ResponseOutputMessage>? ListType111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.DialPlanEntry>? ListType112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.CreateCampaignDTOServerMessage>? ListType113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.CampaignServerMessage>? ListType114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.Campaign>? ListType115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.CampaignSummaryServerMessage>? ListType116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.CampaignSummary>? ListType117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.CampaignContactWithOutcome>? ListType118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.OneOf<global::Vapi.RelayCommandSay, global::Vapi.RelayCommandNote>>? ListType119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.OneOf<global::Vapi.ModelCost, global::Vapi.AnalysisCost, global::Vapi.SessionCost>>? ListType120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.Session>? ListType121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.OneOf<global::Vapi.ByoPhoneNumber, global::Vapi.TwilioPhoneNumber, global::Vapi.VonagePhoneNumber, global::Vapi.VapiPhoneNumber, global::Vapi.TelnyxPhoneNumber>>? ListType122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.CodeToolEnvironmentVariable>? ListType123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.ToolVersion>? ListType124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.ToolDraft>? ListType125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.KnowledgeBaseV2File>? ListType126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.StructuredOutput>? ListType127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.TestSuite>? ListType128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.TestSuiteTestScorerAI>? ListType129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.OneOf<global::Vapi.TestSuiteTestVoice, global::Vapi.TestSuiteTestChat>>? ListType130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.TestSuiteRunScorerAI>? ListType131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.TestSuiteRunTestAttempt>? ListType132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.TestSuiteRunTestResult>? ListType133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.TestSuiteRun>? ListType134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.SimulationHookWebhookAction>? ListType135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.EvaluationPlanItem>? ListType136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.OneOf<global::Vapi.SimulationHookCallStarted, global::Vapi.SimulationHookCallEnded>>? ListType137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.ScenarioToolMock>? ListType138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.OneOf<global::Vapi.SimulationRunSimulationEntry, global::Vapi.SimulationRunSuiteEntry>>? ListType139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.SimulationRunListItem>? ListType140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.StructuredOutputEvaluationResult>? ListType141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.SimulationRunItemImprovementSuggestion>? ListType142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.SimulationSuiteTargetAssignment>? ListType143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.GeneratedScenario>? ListType144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.InsightFormula>? ListType145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.OneOf<global::Vapi.EventsTableStringCondition, global::Vapi.EventsTableNumberCondition, global::Vapi.EventsTableBooleanCondition>>? ListType146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.Insight>? ListType147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.OneOf<global::Vapi.BoardInsightItem, global::Vapi.BoardMetricWidgetItem>>? ListType148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.Board>? ListType149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.ChatEvalAssistantMessageMockToolCall>? ListType150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.Eval>? ListType151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.EvalRunResult>? ListType152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.EvalRun>? ListType153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.Scorecard>? ListType154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.PendingInvitationDTO>? ListType155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.AzureOpenAICredentialModel>? ListType156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.UpdateAzureOpenAICredentialDTOModel>? ListType157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.ToolTemplateSetup>? ListType158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.SyncVoiceLibraryDTOProvider>? ListType159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.CartesiaPronunciationDictItem>? ListType160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.ProviderResource>? ListType161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<byte[]>? ListType162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.AnalyticsQueryGroupByItem>? ListType163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.VariableValueGroupBy>? ListType164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.AnalyticsOperation>? ListType165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.AnalyticsQuery>? ListType166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.CallArtifactUploadItem>? ListType167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.KnowledgeBaseResponseDocument>? ListType168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.ToolCallResult>? ListType169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.CampaignControllerGetCampaignV2ContactsStatu>? ListType170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.Squad>? ListType171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.PhoneNumberControllerFindAllResponseItem>? ListType172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.ToolControllerFindAllResponseItem>? ListType173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.File>? ListType174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.KnowledgeBaseV2>? ListType175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.Personality>? ListType176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.Scenario>? ListType177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OneOf<global::System.Collections.Generic.List<global::Vapi.SimulationRun>, global::Vapi.SimulationRunsPaginatedResponse>? ListType178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.SimulationRun>? ListType179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.SimulationRunItem>? ListType180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.SimulationSuite>? ListType181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.Simulation>? ListType182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.AnalyticsQueryResult>? ListType183 { get; set; }
    }
}