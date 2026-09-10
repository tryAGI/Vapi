
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
        public global::System.Collections.Generic.IList<global::Vapi.AnthropicBedrockModelFallbackModel>? Type369 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AnthropicBedrockModelFallbackModel? Type370 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CerebrasModel? Type371 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CerebrasModelModel? Type372 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CerebrasModelProvider? Type373 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CustomLLMModel? Type374 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CustomLLMModelProvider? Type375 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CustomLLMModelMetadataSendMode? Type376 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? Type377 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.DeepInfraModel? Type378 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.DeepInfraModelProvider? Type379 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.DeepSeekModel? Type380 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.DeepSeekModelModel? Type381 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.DeepSeekModelProvider? Type382 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GeminiMultimodalLivePrebuiltVoiceConfig? Type383 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GeminiMultimodalLivePrebuiltVoiceConfigVoiceName? Type384 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GeminiMultimodalLiveVoiceConfig? Type385 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GeminiMultimodalLiveSpeechConfig? Type386 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GoogleRealtimeConfig? Type387 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GoogleModel? Type388 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GoogleModelModel? Type389 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GoogleModelProvider? Type390 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GroqModel? Type391 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GroqModelModel? Type392 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GroqModelProvider? Type393 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.InflectionAIModel? Type394 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.InflectionAIModelModel? Type395 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.InflectionAIModelProvider? Type396 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.MinimaxLLMModel? Type397 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.MinimaxLLMModelProvider? Type398 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.MinimaxLLMModelModel? Type399 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OpenAIModel? Type400 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OpenAIModelProvider? Type401 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OpenAIModelModel? Type402 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.OpenAIModelFallbackModel>? Type403 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OpenAIModelFallbackModel? Type404 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OpenAIModelToolStrictCompatibilityMode? Type405 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OpenAIModelPromptCacheRetention? Type406 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OpenAIModelReasoningEffort? Type407 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OpenRouterModel? Type408 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OpenRouterModelProvider? Type409 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.PerplexityAIModel? Type410 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.PerplexityAIModelProvider? Type411 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TogetherAIModel? Type412 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TogetherAIModelProvider? Type413 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.HangupNode? Type414 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.HangupNodeType? Type415 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.WorkflowOpenAIModel? Type416 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.WorkflowOpenAIModelProvider? Type417 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.WorkflowOpenAIModelModel? Type418 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.WorkflowAnthropicModel? Type419 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.WorkflowAnthropicModelProvider? Type420 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.WorkflowAnthropicModelModel? Type421 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.WorkflowAnthropicBedrockModel? Type422 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.WorkflowAnthropicBedrockModelProvider? Type423 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.WorkflowAnthropicBedrockModelModel? Type424 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.WorkflowGoogleModel? Type425 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.WorkflowGoogleModelProvider? Type426 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.WorkflowGoogleModelModel? Type427 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.WorkflowCustomModel? Type428 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.WorkflowCustomModelProvider? Type429 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.WorkflowCustomModelMetadataSendMode? Type430 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GlobalNodePlan? Type431 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ConversationNode? Type432 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ConversationNodeType? Type433 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ToolNode? Type434 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ToolNodeType? Type435 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.VoicemailDetectionBackoffPlan? Type436 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GoogleVoicemailDetectionPlan? Type437 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GoogleVoicemailDetectionPlanProvider? Type438 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GoogleVoicemailDetectionPlanType? Type439 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OpenAIVoicemailDetectionPlan? Type440 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OpenAIVoicemailDetectionPlanProvider? Type441 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OpenAIVoicemailDetectionPlanType? Type442 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TwilioVoicemailDetectionPlan? Type443 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TwilioVoicemailDetectionPlanProvider? Type444 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.TwilioVoicemailDetectionPlanVoicemailDetectionType>? Type445 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TwilioVoicemailDetectionPlanVoicemailDetectionType? Type446 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.VapiVoicemailDetectionPlan? Type447 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.VapiVoicemailDetectionPlanProvider? Type448 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.VapiVoicemailDetectionPlanType? Type449 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TransferHookAction? Type450 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TransferHookActionType? Type451 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OneOf<global::Vapi.TransferDestinationNumber, global::Vapi.TransferDestinationSip>? Type452 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FunctionCallHookAction? Type453 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FunctionCallHookActionType? Type454 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SayHookAction? Type455 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SayHookActionType? Type456 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OneOf<string, global::System.Collections.Generic.IList<string>>? Type457 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OneOf<string, global::System.Collections.Generic.IList<global::Vapi.OneOf<global::Vapi.SystemMessage, global::Vapi.UserMessage, global::Vapi.AssistantMessage, global::Vapi.ToolMessage, global::Vapi.DeveloperMessage>>>? Type458 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.OneOf<global::Vapi.SystemMessage, global::Vapi.UserMessage, global::Vapi.AssistantMessage, global::Vapi.ToolMessage, global::Vapi.DeveloperMessage>>? Type459 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OneOf<global::Vapi.SystemMessage, global::Vapi.UserMessage, global::Vapi.AssistantMessage, global::Vapi.ToolMessage, global::Vapi.DeveloperMessage>? Type460 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SystemMessage? Type461 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UserMessage? Type462 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AssistantMessage? Type463 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ToolMessage? Type464 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.DeveloperMessage? Type465 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.MessageAddHookAction? Type466 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.MessageAddHookActionType? Type467 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CallHookFilter? Type468 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CallHookFilterType? Type469 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CallHookCallEnding? Type470 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CallHookCallEndingOn? Type471 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.OneOf<global::Vapi.ToolCallHookAction, global::Vapi.MessageAddHookAction>>? Type472 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OneOf<global::Vapi.ToolCallHookAction, global::Vapi.MessageAddHookAction>? Type473 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ToolCallHookAction? Type474 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.CallHookFilter>? Type475 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CallHookAssistantSpeechInterrupted? Type476 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CallHookAssistantSpeechInterruptedOn? Type477 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.OneOf<global::Vapi.SayHookAction, global::Vapi.ToolCallHookAction, global::Vapi.MessageAddHookAction>>? Type478 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OneOf<global::Vapi.SayHookAction, global::Vapi.ToolCallHookAction, global::Vapi.MessageAddHookAction>? Type479 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CallHookCustomerSpeechInterrupted? Type480 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CallHookCustomerSpeechInterruptedOn? Type481 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ToolCallHookActionType? Type482 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CustomerSpeechTimeoutOptions? Type483 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CustomerSpeechTimeoutOptionsTriggerResetMode? Type484 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CallHookCustomerSpeechTimeout? Type485 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CallHookModelResponseTimeout? Type486 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CallHookModelResponseTimeoutOn? Type487 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AIEdgeCondition? Type488 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AIEdgeConditionType? Type489 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.Edge? Type490 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.RecordingConsentPlanStayOnLine? Type491 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.RecordingConsentPlanStayOnLineFirstMessageMode? Type492 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.RecordingConsentPlanStayOnLineType? Type493 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.RecordingConsentPlanVerbal? Type494 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.RecordingConsentPlanVerbalFirstMessageMode? Type495 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.RecordingConsentPlanVerbalType? Type496 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SecurityFilterBase? Type497 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SecurityFilterPlan? Type498 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.SecurityFilterBase>? Type499 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SecurityFilterPlanMode? Type500 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CompliancePlan? Type501 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.RecordingConsentPlan? Type502 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CompliancePlanRecordingConsentPlanDiscriminator? Type503 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CompliancePlanRecordingConsentPlanDiscriminatorType? Type504 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.StructuredDataPlan? Type505 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.StructuredDataMultiPlan? Type506 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SuccessEvaluationPlan? Type507 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SuccessEvaluationPlanRubric? Type508 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AnalysisPlan? Type509 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.StructuredDataMultiPlan>? Type510 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TranscriptPlan? Type511 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.MinMessagesCondition? Type512 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.MinMessagesConditionType? Type513 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.MinCallDurationCondition? Type514 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.MinCallDurationConditionType? Type515 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.EndedReasonCondition? Type516 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.EndedReasonConditionType? Type517 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.EndedReasonConditionOperator? Type518 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ComplianceOverride? Type519 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateStructuredOutputDTO? Type520 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateStructuredOutputDTOType? Type521 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.OneOf<global::Vapi.MinMessagesCondition, global::Vapi.MinCallDurationCondition, global::Vapi.EndedReasonCondition>>? Type522 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OneOf<global::Vapi.MinMessagesCondition, global::Vapi.MinCallDurationCondition, global::Vapi.EndedReasonCondition>? Type523 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.NumberComparatorScorecardMetricCondition? Type524 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.NumberComparatorScorecardMetricConditionType? Type525 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.NumberComparatorScorecardMetricConditionComparator? Type526 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.BooleanComparatorScorecardMetricCondition? Type527 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.BooleanComparatorScorecardMetricConditionType? Type528 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.BooleanComparatorScorecardMetricConditionComparator? Type529 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ScorecardMetric? Type530 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.OneOf<global::Vapi.NumberComparatorScorecardMetricCondition, global::Vapi.BooleanComparatorScorecardMetricCondition>>? Type531 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OneOf<global::Vapi.NumberComparatorScorecardMetricCondition, global::Vapi.BooleanComparatorScorecardMetricCondition>? Type532 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateScorecardDTO? Type533 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.ScorecardMetric>? Type534 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ArtifactPlan? Type535 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ArtifactPlanRecordingFormat? Type536 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.CreateStructuredOutputDTO>? Type537 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.CreateScorecardDTO>? Type538 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.StopSpeakingPlan? Type539 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.MonitorPlan? Type540 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.KeypadInputPlan? Type541 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.KeypadInputPlanDelimiters? Type542 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.WorkflowUserEditable? Type543 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.OneOf<global::Vapi.ConversationNode, global::Vapi.ToolNode>>? Type544 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OneOf<global::Vapi.ConversationNode, global::Vapi.ToolNode>? Type545 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OneOf<global::Vapi.WorkflowUserEditableBackgroundSound?, string>? Type546 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.WorkflowUserEditableBackgroundSound? Type547 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.CredentialsItem>? Type548 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CredentialsItem? Type549 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateAnthropicCredentialDTO? Type550 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateAnthropicBedrockCredentialDTO? Type551 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateAnyscaleCredentialDTO? Type552 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateAssemblyAICredentialDTO? Type553 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateAzureCredentialDTO? Type554 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateAzureOpenAICredentialDTO? Type555 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateByoSipTrunkCredentialDTO? Type556 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateCartesiaCredentialDTO? Type557 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateCerebrasCredentialDTO? Type558 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateCloudflareCredentialDTO? Type559 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateCustomLLMCredentialDTO? Type560 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateDeepgramCredentialDTO? Type561 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateDeepInfraCredentialDTO? Type562 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateDeepSeekCredentialDTO? Type563 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateElevenLabsCredentialDTO? Type564 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateGcpCredentialDTO? Type565 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateGladiaCredentialDTO? Type566 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateGoHighLevelCredentialDTO? Type567 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateGoogleCredentialDTO? Type568 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateGroqCredentialDTO? Type569 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateHumeCredentialDTO? Type570 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateInflectionAICredentialDTO? Type571 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateLangfuseCredentialDTO? Type572 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateLmntCredentialDTO? Type573 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateMakeCredentialDTO? Type574 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateMistralCredentialDTO? Type575 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateNeuphonicCredentialDTO? Type576 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateOpenAICredentialDTO? Type577 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateOpenRouterCredentialDTO? Type578 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreatePerplexityAICredentialDTO? Type579 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreatePlayHTCredentialDTO? Type580 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateRimeAICredentialDTO? Type581 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateRunpodCredentialDTO? Type582 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateS3CredentialDTO? Type583 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateS3CompatibleCredentialDTO? Type584 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateSmallestAICredentialDTO? Type585 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateSpeechmaticsCredentialDTO? Type586 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateSonioxCredentialDTO? Type587 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateSupabaseCredentialDTO? Type588 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateTavusCredentialDTO? Type589 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateTogetherAICredentialDTO? Type590 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateTwilioCredentialDTO? Type591 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateVonageCredentialDTO? Type592 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateWebhookCredentialDTO? Type593 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateCustomCredentialDTO? Type594 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateXAiCredentialDTO? Type595 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateMicrosoftCredentialDTO? Type596 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateGoogleCalendarOAuth2ClientCredentialDTO? Type597 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateGoogleCalendarOAuth2AuthorizationCredentialDTO? Type598 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateGoogleSheetsOAuth2AuthorizationCredentialDTO? Type599 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateSlackOAuth2AuthorizationCredentialDTO? Type600 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateGoHighLevelMCPCredentialDTO? Type601 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateInworldCredentialDTO? Type602 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateMinimaxCredentialDTO? Type603 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateWellSaidCredentialDTO? Type604 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateEmailCredentialDTO? Type605 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateSlackWebhookCredentialDTO? Type606 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.WorkflowUserEditableCredentialDiscriminator? Type607 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.WorkflowUserEditableCredentialDiscriminatorProvider? Type608 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.WorkflowUserEditableVoicemailDetection? Type609 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.Edge>? Type610 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.VapiModel? Type611 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.VapiModelVersion? Type612 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.VapiModelProvider? Type613 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.XaiModel? Type614 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.XaiModelModel? Type615 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.XaiModelProvider? Type616 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ExactReplacement? Type617 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ExactReplacementType? Type618 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.RegexReplacement? Type619 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.RegexReplacementType? Type620 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FormatPlan? Type621 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.OneOf<global::Vapi.ExactReplacement, global::Vapi.RegexReplacement>>? Type622 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OneOf<global::Vapi.ExactReplacement, global::Vapi.RegexReplacement>? Type623 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.FormatPlanFormattersEnabledItem>? Type624 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FormatPlanFormattersEnabledItem? Type625 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ChunkPlan? Type626 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.ChunkPlanPunctuationBoundarie>? Type627 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ChunkPlanPunctuationBoundarie? Type628 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackPlan? Type629 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackAzureVoice? Type630 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackCartesiaVoice? Type631 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackHumeVoice? Type632 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackCustomVoice? Type633 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackDeepgramVoice? Type634 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackElevenLabsVoice? Type635 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackVapiVoice? Type636 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackLMNTVoice? Type637 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackOpenAIVoice? Type638 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackPlayHTVoice? Type639 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackWellSaidVoice? Type640 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackRimeAIVoice? Type641 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackSmallestAIVoice? Type642 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackTavusVoice? Type643 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackNeuphonicVoice? Type644 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackSesameVoice? Type645 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackInworldVoice? Type646 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackXaiVoice? Type647 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackMicrosoftVoice? Type648 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AzureVoiceProvider? Type649 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OneOf<global::Vapi.AzureVoiceVoiceId?, string>? Type650 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AzureVoiceVoiceId? Type651 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CartesiaExperimentalControls? Type652 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OneOf<global::Vapi.CartesiaExperimentalControlsSpeed?, double?>? Type653 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CartesiaExperimentalControlsSpeed? Type654 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CartesiaExperimentalControlsEmotion? Type655 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CartesiaGenerationConfigExperimental? Type656 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public int? Type657 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CartesiaGenerationConfig? Type658 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CartesiaVoiceProvider? Type659 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CartesiaVoiceModel? Type660 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CartesiaVoiceLanguage? Type661 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CustomVoiceProvider? Type662 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.DeepgramVoiceProvider? Type663 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.DeepgramVoiceVoiceId? Type664 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.DeepgramVoiceModel? Type665 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ElevenLabsPronunciationDictionaryLocator? Type666 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ElevenLabsVoiceProvider? Type667 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OneOf<global::Vapi.ElevenLabsVoiceVoiceId?, string>? Type668 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ElevenLabsVoiceVoiceId? Type669 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ElevenLabsVoiceModel? Type670 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.ElevenLabsPronunciationDictionaryLocator>? Type671 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.WellSaidVoiceProvider? Type672 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.WellSaidVoiceModel? Type673 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.HumeVoiceProvider? Type674 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.HumeVoiceModel? Type675 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.LMNTVoiceProvider? Type676 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OneOf<global::Vapi.LMNTVoiceVoiceId?, string>? Type677 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.LMNTVoiceVoiceId? Type678 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.LMNTVoiceLanguage? Type679 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.NeuphonicVoiceProvider? Type680 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.NeuphonicVoiceModel? Type681 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OpenAIVoiceProvider? Type682 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OneOf<global::Vapi.OpenAIVoiceVoiceId?, string>? Type683 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OpenAIVoiceVoiceId? Type684 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OpenAIVoiceModel? Type685 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.PlayHTVoiceProvider? Type686 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OneOf<global::Vapi.PlayHTVoiceVoiceId?, string>? Type687 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.PlayHTVoiceVoiceId? Type688 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.PlayHTVoiceEmotion? Type689 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.PlayHTVoiceModel? Type690 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.PlayHTVoiceLanguage? Type691 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.RimeAIVoiceProvider? Type692 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OneOf<global::Vapi.RimeAIVoiceVoiceId?, string>? Type693 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.RimeAIVoiceVoiceId? Type694 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.RimeAIVoiceModel? Type695 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.RimeAIVoiceLanguage? Type696 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SesameVoiceProvider? Type697 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SesameVoiceModel? Type698 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SmallestAIVoiceProvider? Type699 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OneOf<global::Vapi.SmallestAIVoiceVoiceId?, string>? Type700 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SmallestAIVoiceVoiceId? Type701 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SmallestAIVoiceModel? Type702 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TavusConversationProperties? Type703 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TavusVoiceProvider? Type704 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OneOf<global::Vapi.TavusVoiceVoiceId?, string>? Type705 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TavusVoiceVoiceId? Type706 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.VapiPronunciationDictionaryLocator? Type707 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.VapiPronunciationDictionaryLocatorProvider? Type708 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.VapiVoiceProvider? Type709 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OneOf<global::Vapi.VapiVoiceVersion2?, double?>? Type710 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.VapiVoiceVersion2? Type711 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.VapiVoiceLanguage? Type712 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.VapiPronunciationDictionaryLocator>? Type713 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.InworldVoiceProvider? Type714 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.InworldVoiceVoiceId? Type715 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.InworldVoiceModel? Type716 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.InworldVoiceLanguageCode? Type717 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.MinimaxVoiceProvider? Type718 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.MinimaxVoiceModel? Type719 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.MinimaxVoiceSubtitleType? Type720 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.MinimaxVoiceRegion? Type721 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.MinimaxVoiceLanguageBoost? Type722 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackMinimaxVoice? Type723 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackMinimaxVoiceProvider? Type724 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackMinimaxVoiceModel? Type725 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackMinimaxVoiceSubtitleType? Type726 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackMinimaxVoiceRegion? Type727 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackMinimaxVoiceLanguageBoost? Type728 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackWellSaidVoiceProvider? Type729 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackWellSaidVoiceModel? Type730 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.XaiVoiceProvider? Type731 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.XaiVoiceVoiceId? Type732 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.XaiVoiceLanguage? Type733 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.MicrosoftVoiceProvider? Type734 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.MicrosoftVoiceVoiceId? Type735 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.MicrosoftVoiceStyle? Type736 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.MicrosoftVoiceRole? Type737 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackAzureVoiceProvider? Type738 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OneOf<global::Vapi.FallbackAzureVoiceVoiceId?, string>? Type739 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackAzureVoiceVoiceId? Type740 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackCartesiaVoiceProvider? Type741 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackCartesiaVoiceModel? Type742 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackCartesiaVoiceLanguage? Type743 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackCustomVoiceProvider? Type744 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackDeepgramVoiceProvider? Type745 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackDeepgramVoiceVoiceId? Type746 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackDeepgramVoiceModel? Type747 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackElevenLabsVoiceProvider? Type748 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OneOf<global::Vapi.FallbackElevenLabsVoiceVoiceId?, string>? Type749 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackElevenLabsVoiceVoiceId? Type750 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackElevenLabsVoiceModel? Type751 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackHumeVoiceProvider? Type752 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackHumeVoiceModel? Type753 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackLMNTVoiceProvider? Type754 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OneOf<global::Vapi.FallbackLMNTVoiceVoiceId?, string>? Type755 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackLMNTVoiceVoiceId? Type756 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackLMNTVoiceLanguage? Type757 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackNeuphonicVoiceProvider? Type758 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackNeuphonicVoiceModel? Type759 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackOpenAIVoiceProvider? Type760 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OneOf<global::Vapi.FallbackOpenAIVoiceVoiceId?, string>? Type761 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackOpenAIVoiceVoiceId? Type762 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackOpenAIVoiceModel? Type763 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackPlayHTVoiceProvider? Type764 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OneOf<global::Vapi.FallbackPlayHTVoiceVoiceId?, string>? Type765 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackPlayHTVoiceVoiceId? Type766 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackPlayHTVoiceEmotion? Type767 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackPlayHTVoiceModel? Type768 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackPlayHTVoiceLanguage? Type769 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackRimeAIVoiceProvider? Type770 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OneOf<global::Vapi.FallbackRimeAIVoiceVoiceId?, string>? Type771 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackRimeAIVoiceVoiceId? Type772 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackRimeAIVoiceModel? Type773 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackRimeAIVoiceLanguage? Type774 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackSesameVoiceProvider? Type775 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackSesameVoiceModel? Type776 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackSmallestAIVoiceProvider? Type777 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OneOf<global::Vapi.FallbackSmallestAIVoiceVoiceId?, string>? Type778 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackSmallestAIVoiceVoiceId? Type779 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackSmallestAIVoiceModel? Type780 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackTavusVoiceProvider? Type781 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OneOf<global::Vapi.FallbackTavusVoiceVoiceId?, string>? Type782 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackTavusVoiceVoiceId? Type783 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackVapiVoiceProvider? Type784 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OneOf<global::Vapi.FallbackVapiVoiceVersion2?, double?>? Type785 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackVapiVoiceVersion2? Type786 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackVapiVoiceLanguage? Type787 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackInworldVoiceProvider? Type788 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackInworldVoiceVoiceId? Type789 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackInworldVoiceModel? Type790 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackInworldVoiceLanguageCode? Type791 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackXaiVoiceProvider? Type792 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackXaiVoiceVoiceId? Type793 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackXaiVoiceLanguage? Type794 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackMicrosoftVoiceProvider? Type795 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackMicrosoftVoiceVoiceId? Type796 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackMicrosoftVoiceStyle? Type797 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackMicrosoftVoiceRole? Type798 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TransportConfigurationTwilio? Type799 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TransportConfigurationTwilioProvider? Type800 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TransportConfigurationTwilioRecordingChannels? Type801 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateAnthropicCredentialDTOProvider? Type802 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateAnthropicBedrockCredentialDTOProvider? Type803 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateAnthropicBedrockCredentialDTORegion? Type804 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OneOf<global::Vapi.AWSIAMCredentialsAuthenticationPlan, global::Vapi.AWSStsAuthenticationPlan>? Type805 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AWSIAMCredentialsAuthenticationPlan? Type806 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AWSStsAuthenticationPlan? Type807 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateAnyscaleCredentialDTOProvider? Type808 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateAssemblyAICredentialDTOProvider? Type809 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AzureBlobStorageBucketPlan? Type810 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateAzureCredentialDTOProvider? Type811 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateAzureCredentialDTOService? Type812 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateAzureCredentialDTORegion? Type813 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateAzureOpenAICredentialDTOProvider? Type814 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateAzureOpenAICredentialDTORegion? Type815 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.CreateAzureOpenAICredentialDTOModel>? Type816 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateAzureOpenAICredentialDTOModel? Type817 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SipTrunkGateway? Type818 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SipTrunkGatewayOutboundProtocol? Type819 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SipTrunkOutboundSipRegisterPlan? Type820 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SipTrunkOutboundAuthenticationPlan? Type821 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateByoSipTrunkCredentialDTOProvider? Type822 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.SipTrunkGateway>? Type823 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateCartesiaCredentialDTOProvider? Type824 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CloudflareR2BucketPlan? Type825 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateCloudflareCredentialDTOProvider? Type826 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OAuth2AuthenticationPlan? Type827 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OAuth2AuthenticationPlanType? Type828 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateCustomLLMCredentialDTOProvider? Type829 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateDeepgramCredentialDTOProvider? Type830 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateDeepInfraCredentialDTOProvider? Type831 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateDeepSeekCredentialDTOProvider? Type832 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateElevenLabsCredentialDTOProvider? Type833 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateElevenLabsCredentialDTOApiUrl? Type834 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GcpKey? Type835 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.BucketPlan? Type836 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateGcpCredentialDTOProvider? Type837 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateGladiaCredentialDTOProvider? Type838 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateGoHighLevelCredentialDTOProvider? Type839 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateGroqCredentialDTOProvider? Type840 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateLangfuseCredentialDTOProvider? Type841 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateLmntCredentialDTOProvider? Type842 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateMakeCredentialDTOProvider? Type843 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateOpenAICredentialDTOProvider? Type844 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateOpenRouterCredentialDTOProvider? Type845 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreatePerplexityAICredentialDTOProvider? Type846 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreatePlayHTCredentialDTOProvider? Type847 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateRimeAICredentialDTOProvider? Type848 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateRunpodCredentialDTOProvider? Type849 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateS3CredentialDTOProvider? Type850 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SupabaseBucketPlan? Type851 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SupabaseBucketPlanRegion? Type852 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateSupabaseCredentialDTOProvider? Type853 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateSmallestAICredentialDTOProvider? Type854 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateTavusCredentialDTOProvider? Type855 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateTogetherAICredentialDTOProvider? Type856 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateTwilioCredentialDTOProvider? Type857 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateVonageCredentialDTOProvider? Type858 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateWebhookCredentialDTOProvider? Type859 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AuthenticationPlan2? Type860 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.HMACAuthenticationPlan? Type861 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.BearerAuthenticationPlan? Type862 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateWebhookCredentialDTOAuthenticationPlanDiscriminator? Type863 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateWebhookCredentialDTOAuthenticationPlanDiscriminatorType? Type864 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateXAiCredentialDTOProvider? Type865 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateGoogleCalendarOAuth2ClientCredentialDTOProvider? Type866 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateGoogleCalendarOAuth2AuthorizationCredentialDTOProvider? Type867 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateGoogleSheetsOAuth2AuthorizationCredentialDTOProvider? Type868 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateSlackOAuth2AuthorizationCredentialDTOProvider? Type869 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateMinimaxCredentialDTOProvider? Type870 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.EndpointedSpeechLowConfidenceOptions? Type871 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CallHookTranscriberEndpointedSpeechLowConfidence? Type872 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SessionCreatedHook? Type873 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SessionCreatedHookOn? Type874 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.ToolCallHookAction>? Type875 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SQLInjectionSecurityFilter? Type876 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SQLInjectionSecurityFilterType? Type877 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.XSSSecurityFilter? Type878 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.XSSSecurityFilterType? Type879 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SSRFSecurityFilter? Type880 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SSRFSecurityFilterType? Type881 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.RCESecurityFilter? Type882 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.RCESecurityFilterType? Type883 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.PromptInjectionSecurityFilter? Type884 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.PromptInjectionSecurityFilterType? Type885 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.RegexSecurityFilter? Type886 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.RegexSecurityFilterType? Type887 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AssistantOverridesFirstMessageMode? Type888 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AssistantOverridesVoicemailDetection? Type889 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.AssistantOverridesClientMessage>? Type890 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AssistantOverridesClientMessage? Type891 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.AssistantOverridesServerMessage>? Type892 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AssistantOverridesServerMessage? Type893 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OneOf<global::Vapi.AssistantOverridesBackgroundSound?, string>? Type894 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AssistantOverridesBackgroundSound? Type895 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.TransportConfigurationTwilio>? Type896 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.CredentialsItem2>? Type897 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CredentialsItem2? Type898 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AssistantOverridesCredentialDiscriminator? Type899 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AssistantOverridesCredentialDiscriminatorProvider? Type900 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateAssistantDTOFirstMessageMode? Type901 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateAssistantDTOVoicemailDetection? Type902 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.CreateAssistantDTOClientMessage>? Type903 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateAssistantDTOClientMessage? Type904 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.CreateAssistantDTOServerMessage>? Type905 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateAssistantDTOServerMessage? Type906 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OneOf<global::Vapi.CreateAssistantDTOBackgroundSound?, string>? Type907 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateAssistantDTOBackgroundSound? Type908 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.CredentialsItem3>? Type909 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CredentialsItem3? Type910 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateAssistantDTOCredentialDiscriminator? Type911 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateAssistantDTOCredentialDiscriminatorProvider? Type912 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.Assistant? Type913 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AssistantFirstMessageMode? Type914 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AssistantVoicemailDetection? Type915 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.AssistantClientMessage>? Type916 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AssistantClientMessage? Type917 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.AssistantServerMessage>? Type918 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AssistantServerMessage? Type919 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OneOf<global::Vapi.AssistantBackgroundSound?, string>? Type920 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AssistantBackgroundSound? Type921 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.CredentialsItem4>? Type922 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CredentialsItem4? Type923 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AssistantCredentialDiscriminator? Type924 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AssistantCredentialDiscriminatorProvider? Type925 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.DateTime? Type926 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ValidateBackgroundSoundUrlDTO? Type927 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.BackgroundSoundUrlValidationResult? Type928 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.BackgroundSoundUrlValidationResultReason? Type929 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.PaginationMeta? Type930 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.PaginationMetaSortOrder? Type931 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AssistantPaginatedResponse? Type932 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.Assistant>? Type933 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AssistantDraft? Type934 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AssistantDraftFirstMessageMode? Type935 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AssistantDraftVoicemailDetection? Type936 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.AssistantDraftClientMessage>? Type937 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AssistantDraftClientMessage? Type938 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.AssistantDraftServerMessage>? Type939 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AssistantDraftServerMessage? Type940 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OneOf<global::Vapi.AssistantDraftBackgroundSound?, string>? Type941 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AssistantDraftBackgroundSound? Type942 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.CredentialsItem5>? Type943 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CredentialsItem5? Type944 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AssistantDraftCredentialDiscriminator? Type945 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AssistantDraftCredentialDiscriminatorProvider? Type946 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AssistantDraftPaginatedMetadata? Type947 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AssistantDraftPaginatedResponse? Type948 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.AssistantDraft>? Type949 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.LegacyAssistantVersion? Type950 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.LegacyAssistantVersionPaginatedResponse? Type951 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.LegacyAssistantVersion>? Type952 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AssistantVersion? Type953 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AssistantVersionFirstMessageMode? Type954 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AssistantVersionVoicemailDetection? Type955 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.AssistantVersionClientMessage>? Type956 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AssistantVersionClientMessage? Type957 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.AssistantVersionServerMessage>? Type958 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AssistantVersionServerMessage? Type959 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OneOf<global::Vapi.AssistantVersionBackgroundSound?, string>? Type960 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AssistantVersionBackgroundSound? Type961 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.CredentialsItem6>? Type962 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CredentialsItem6? Type963 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AssistantVersionCredentialDiscriminator? Type964 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AssistantVersionCredentialDiscriminatorProvider? Type965 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AssistantVersionPaginatedMetadata? Type966 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AssistantVersionPaginatedResponse? Type967 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.AssistantVersion>? Type968 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateAssistantVersionMetadataDTO? Type969 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.VersionPinReference? Type970 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.VersionPinReferenceSourceType? Type971 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.VersionPinConflictResponseDTO? Type972 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.VersionPinConflictResponseDTOError? Type973 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.VersionPinReference>? Type974 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateAssistantDraftDTO? Type975 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateAssistantDraftDTOFirstMessageMode? Type976 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateAssistantDraftDTOVoicemailDetection? Type977 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.CreateAssistantDraftDTOClientMessage>? Type978 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateAssistantDraftDTOClientMessage? Type979 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.CreateAssistantDraftDTOServerMessage>? Type980 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateAssistantDraftDTOServerMessage? Type981 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OneOf<global::Vapi.CreateAssistantDraftDTOBackgroundSound?, string>? Type982 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateAssistantDraftDTOBackgroundSound? Type983 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.CredentialsItem7>? Type984 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CredentialsItem7? Type985 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateAssistantDraftDTOCredentialDiscriminator? Type986 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateAssistantDraftDTOCredentialDiscriminatorProvider? Type987 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AssistantDraftConflictResponseDTO? Type988 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateAssistantDraftDTO? Type989 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateAssistantDraftDTOFirstMessageMode? Type990 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateAssistantDraftDTOVoicemailDetection? Type991 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.UpdateAssistantDraftDTOClientMessage>? Type992 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateAssistantDraftDTOClientMessage? Type993 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.UpdateAssistantDraftDTOServerMessage>? Type994 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateAssistantDraftDTOServerMessage? Type995 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OneOf<global::Vapi.UpdateAssistantDraftDTOBackgroundSound?, string>? Type996 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateAssistantDraftDTOBackgroundSound? Type997 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.CredentialsItem8>? Type998 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CredentialsItem8? Type999 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateAssistantDraftDTOCredentialDiscriminator? Type1000 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateAssistantDraftDTOCredentialDiscriminatorProvider? Type1001 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateAssistantDTO? Type1002 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateAssistantDTOFirstMessageMode? Type1003 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateAssistantDTOVoicemailDetection? Type1004 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.UpdateAssistantDTOClientMessage>? Type1005 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateAssistantDTOClientMessage? Type1006 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.UpdateAssistantDTOServerMessage>? Type1007 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateAssistantDTOServerMessage? Type1008 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OneOf<global::Vapi.UpdateAssistantDTOBackgroundSound?, string>? Type1009 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateAssistantDTOBackgroundSound? Type1010 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.CredentialsItem9>? Type1011 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CredentialsItem9? Type1012 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateAssistantDTOCredentialDiscriminator? Type1013 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateAssistantDTOCredentialDiscriminatorProvider? Type1014 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AssistantPinnedConflictResponseDTO? Type1015 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AssistantPinnedConflictResponseDTOError? Type1016 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.Squad? Type1017 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateSquadDTO? Type1018 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.Workflow? Type1019 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OneOf<global::Vapi.WorkflowBackgroundSound?, string>? Type1020 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.WorkflowBackgroundSound? Type1021 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.CredentialsItem10>? Type1022 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CredentialsItem10? Type1023 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.WorkflowCredentialDiscriminator? Type1024 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.WorkflowCredentialDiscriminatorProvider? Type1025 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.WorkflowVoicemailDetection? Type1026 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateWorkflowDTO? Type1027 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OneOf<global::Vapi.CreateWorkflowDTOBackgroundSound?, string>? Type1028 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateWorkflowDTOBackgroundSound? Type1029 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.CredentialsItem11>? Type1030 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CredentialsItem11? Type1031 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateWorkflowDTOCredentialDiscriminator? Type1032 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateWorkflowDTOCredentialDiscriminatorProvider? Type1033 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateWorkflowDTOVoicemailDetection? Type1034 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateWorkflowDTO? Type1035 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OneOf<global::Vapi.UpdateWorkflowDTOBackgroundSound?, string>? Type1036 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateWorkflowDTOBackgroundSound? Type1037 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.CredentialsItem12>? Type1038 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CredentialsItem12? Type1039 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateWorkflowDTOCredentialDiscriminator? Type1040 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateWorkflowDTOCredentialDiscriminatorProvider? Type1041 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateWorkflowDTOVoicemailDetection? Type1042 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SubscriptionLimits? Type1043 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.BotMessage? Type1044 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ToolCallMessage? Type1045 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ToolCallResultMessageWarning? Type1046 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ToolCallResultMessageWarningType? Type1047 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ToolCallResultMessage? Type1048 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.ToolCallResultMessageWarning>? Type1049 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TransportCost? Type1050 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TransportCostType? Type1051 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TransportCostProvider? Type1052 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TranscriberCost? Type1053 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TranscriberCostType? Type1054 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ModelCost? Type1055 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ModelCostType? Type1056 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.VoiceCost? Type1057 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.VoiceCostType? Type1058 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ChatCost? Type1059 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ChatCostType? Type1060 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.VapiCost? Type1061 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.VapiCostType? Type1062 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.VapiCostSubType? Type1063 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.VoicemailDetectionCost? Type1064 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.VoicemailDetectionCostType? Type1065 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.VoicemailDetectionCostProvider? Type1066 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.StructuredOutputCostBreakdown? Type1067 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AnalysisCost? Type1068 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AnalysisCostType? Type1069 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AnalysisCostAnalysisType? Type1070 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.StructuredOutputCostBreakdown>? Type1071 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AudioFormat? Type1072 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AudioFormatContainer? Type1073 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.VapiWebsocketTransport? Type1074 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.VapiWebsocketTransportConversationType? Type1075 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.VapiWebsocketTransportProvider? Type1076 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.VapiWebCallTransport? Type1077 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.VapiWebCallTransportConversationType? Type1078 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.VapiWebCallTransportProvider? Type1079 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TwilioTransport? Type1080 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TwilioTransportConversationType? Type1081 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TwilioTransportProvider? Type1082 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TelnyxTransport? Type1083 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TelnyxTransportConversationType? Type1084 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TelnyxTransportProvider? Type1085 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.VapiSipTransport? Type1086 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.VapiSipTransportConversationType? Type1087 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.VapiSipTransportProvider? Type1088 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.VonageTransport? Type1089 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.VonageTransportConversationType? Type1090 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.VonageTransportProvider? Type1091 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AnalysisCostBreakdown? Type1092 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CostBreakdown? Type1093 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.Analysis? Type1094 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.MonitorResult? Type1095 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.Monitor? Type1096 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.MonitorResult>? Type1097 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SkippedStructuredOutput? Type1098 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TransferArtifact? Type1099 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TransferArtifactMode? Type1100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TransferArtifactStatus? Type1101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.OneOf<global::Vapi.UserMessage, global::Vapi.SystemMessage, global::Vapi.BotMessage, global::Vapi.ToolCallMessage, global::Vapi.ToolCallResultMessage>>? Type1102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OneOf<global::Vapi.UserMessage, global::Vapi.SystemMessage, global::Vapi.BotMessage, global::Vapi.ToolCallMessage, global::Vapi.ToolCallResultMessage>? Type1103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.Mono? Type1104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.Recording? Type1105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.NodeArtifact? Type1106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AssistantActivation? Type1107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TurnLatency? Type1108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.PerformanceMetrics? Type1109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.TurnLatency>? Type1110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.Artifact? Type1111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Vapi.SkippedStructuredOutput>? Type1112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.TransferArtifact>? Type1113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.NodeArtifact>? Type1114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.AssistantActivation>? Type1115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.RecordingConsent? Type1116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.RecordingConsentType? Type1117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.Compliance? Type1118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.WorkflowOverrides? Type1119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TransferPhoneNumberHookAction? Type1120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TransferPhoneNumberHookActionType? Type1121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SayPhoneNumberHookAction? Type1122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SayPhoneNumberHookActionType? Type1123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.PhoneNumberCallRingingHookFilter? Type1124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.PhoneNumberCallRingingHookFilterType? Type1125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.PhoneNumberCallRingingHookFilterKey? Type1126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.PhoneNumberHookCallRinging? Type1127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.PhoneNumberHookCallRingingOn? Type1128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.PhoneNumberCallRingingHookFilter>? Type1129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.OneOf<global::Vapi.TransferPhoneNumberHookAction, global::Vapi.SayPhoneNumberHookAction>>? Type1130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OneOf<global::Vapi.TransferPhoneNumberHookAction, global::Vapi.SayPhoneNumberHookAction>? Type1131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.PhoneNumberCallEndingHookFilter? Type1132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.PhoneNumberCallEndingHookFilterType? Type1133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.PhoneNumberCallEndingHookFilterKey? Type1134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.PhoneNumberCallEndingHookFilterOneOfItem>? Type1135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.PhoneNumberCallEndingHookFilterOneOfItem? Type1136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.PhoneNumberHookCallEnding? Type1137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.PhoneNumberHookCallEndingOn? Type1138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.PhoneNumberCallEndingHookFilter>? Type1139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ImportTwilioPhoneNumberDTO? Type1140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.OneOf<global::Vapi.PhoneNumberHookCallRinging, global::Vapi.PhoneNumberHookCallEnding>>? Type1141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OneOf<global::Vapi.PhoneNumberHookCallRinging, global::Vapi.PhoneNumberHookCallEnding>? Type1142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateCustomerDTO? Type1143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SchedulePlan? Type1144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.Call? Type1145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CallType? Type1146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OneOf<global::Vapi.TransportCost, global::Vapi.TranscriberCost, global::Vapi.ModelCost, global::Vapi.VoiceCost, global::Vapi.VapiCost, global::Vapi.VoicemailDetectionCost, global::Vapi.AnalysisCost, global::Vapi.KnowledgeBaseCost>? Type1147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.KnowledgeBaseCost? Type1148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CallPhoneCallProvider? Type1149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CallPhoneCallTransport? Type1150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CallStatus? Type1151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CallEndedReason? Type1152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OneOf<global::Vapi.VapiWebsocketTransport, global::Vapi.VonageTransport, global::Vapi.TwilioTransport, global::Vapi.VapiSipTransport, global::Vapi.TelnyxTransport, global::Vapi.VapiWebCallTransport>? Type1153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CallBatchError? Type1154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CallBatchResponse? Type1155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.Call>? Type1156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.CallBatchError>? Type1157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AssistantSpeechWordAlignmentTiming? Type1158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AssistantSpeechWordAlignmentTimingType? Type1159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<double>? Type1160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AssistantSpeechWordTimestamp? Type1161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AssistantSpeechWordProgressTiming? Type1162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AssistantSpeechWordProgressTimingType? Type1163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.AssistantSpeechWordTimestamp>? Type1164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateCallDTO? Type1165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.CreateCustomerDTO>? Type1166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.StructuredOutputFilterDTO? Type1167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CallPaginatedResponse? Type1168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateOutboundCallDTO? Type1169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateWebCallDTO? Type1170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateCallDTO? Type1171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.DeleteCallDTO? Type1172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.DeveloperMessageRole? Type1173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ToolCallFunction? Type1174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ToolCall? Type1175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AssistantMessageRole? Type1176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.ToolCall>? Type1177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ToolMessageRole? Type1178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FunctionCall? Type1179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.Chat? Type1180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.OneOf<global::Vapi.ModelCost, global::Vapi.ChatCost>>? Type1181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OneOf<global::Vapi.ModelCost, global::Vapi.ChatCost>? Type1182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TwilioSMSChatTransport? Type1183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TwilioSMSChatTransportConversationType? Type1184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TwilioSMSChatTransportType? Type1185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateChatDTO? Type1186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GetChatPaginatedDTO? Type1187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GetChatPaginatedDTOSortOrder? Type1188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GetChatPaginatedDTOSortBy? Type1189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ChatPaginatedResponse? Type1190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.Chat>? Type1191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateChatStreamResponse? Type1192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OpenAIResponsesRequest? Type1193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ChatAssistantOverrides? Type1194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateWebCustomerDTO? Type1195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateWebChatDTO? Type1196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.WebChat? Type1197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OpenAIWebChatRequest? Type1198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ExportChatDTO? Type1199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ExportChatDTOColumns? Type1200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ExportChatDTOFormat? Type1201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ExportChatDTOSortOrder? Type1202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ExportChatDTOSortBy? Type1203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ResponseOutputText? Type1204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ResponseOutputTextType? Type1205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ResponseOutputMessage? Type1206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.ResponseOutputText>? Type1207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ResponseOutputMessageRole? Type1208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ResponseOutputMessageStatus? Type1209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ResponseOutputMessageType? Type1210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ResponseObject? Type1211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ResponseObjectObject? Type1212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ResponseObjectStatus? Type1213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.ResponseOutputMessage>? Type1214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ResponseTextDeltaEvent? Type1215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ResponseTextDeltaEventType? Type1216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ResponseTextDoneEvent? Type1217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ResponseTextDoneEventType? Type1218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ResponseCompletedEvent? Type1219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ResponseCompletedEventType? Type1220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ResponseErrorEvent? Type1221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ResponseErrorEventType? Type1222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.DialPlanEntry? Type1223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CampaignPredialPlan? Type1224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateCampaignDTO? Type1225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.DialPlanEntry>? Type1226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.CreateCampaignDTOServerMessage>? Type1227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateCampaignDTOServerMessage? Type1228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.Campaign? Type1229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CampaignStatus? Type1230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CampaignEndedReason? Type1231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.CampaignServerMessage>? Type1232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CampaignServerMessage? Type1233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CampaignPaginatedResponse? Type1234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.Campaign>? Type1235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CampaignContactCounters? Type1236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CampaignCallMetrics? Type1237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CampaignSummary? Type1238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CampaignSummaryStatus? Type1239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CampaignSummaryEndedReason? Type1240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.CampaignSummaryServerMessage>? Type1241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CampaignSummaryServerMessage? Type1242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CampaignSummaryPaginatedResponse? Type1243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.CampaignSummary>? Type1244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateCampaignDTO? Type1245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateCampaignDTOStatus? Type1246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CampaignContactWithOutcome? Type1247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CampaignContactWithOutcomeStatus? Type1248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CampaignContactPaginatedResponse? Type1249 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.CampaignContactWithOutcome>? Type1250 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.RelayTargetAssistant? Type1251 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.RelayTargetAssistantType? Type1252 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.RelayTargetSquad? Type1253 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.RelayTargetSquadType? Type1254 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.RelayTargetOptions? Type1255 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.RelayTargetOptionsType? Type1256 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.RelayCommandSay? Type1257 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.RelayCommandSayType? Type1258 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.RelayCommandNote? Type1259 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.RelayCommandNoteType? Type1260 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.RelayCommandOptions? Type1261 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.RelayCommandOptionsType? Type1262 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.RelayRequest? Type1263 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OneOf<global::Vapi.RelayTargetAssistant, global::Vapi.RelayTargetSquad>? Type1264 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.OneOf<global::Vapi.RelayCommandSay, global::Vapi.RelayCommandNote>>? Type1265 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OneOf<global::Vapi.RelayCommandSay, global::Vapi.RelayCommandNote>? Type1266 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.RelayResponse? Type1267 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.RelayResponseStatus? Type1268 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.Session? Type1269 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.OneOf<global::Vapi.ModelCost, global::Vapi.AnalysisCost, global::Vapi.SessionCost>>? Type1270 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OneOf<global::Vapi.ModelCost, global::Vapi.AnalysisCost, global::Vapi.SessionCost>? Type1271 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SessionCost? Type1272 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SessionStatus? Type1273 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateSessionDTO? Type1274 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateSessionDTOStatus? Type1275 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateSessionDTO? Type1276 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateSessionDTOStatus? Type1277 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GetSessionPaginatedDTO? Type1278 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GetSessionPaginatedDTOSortOrder? Type1279 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GetSessionPaginatedDTOSortBy? Type1280 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SessionPaginatedResponse? Type1281 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.Session>? Type1282 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ExportSessionDTO? Type1283 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ExportSessionDTOColumns? Type1284 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ExportSessionDTOFormat? Type1285 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ExportSessionDTOSortOrder? Type1286 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ExportSessionDTOSortBy? Type1287 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ByoPhoneNumber? Type1288 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ByoPhoneNumberProvider? Type1289 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ByoPhoneNumberStatus? Type1290 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TwilioPhoneNumber? Type1291 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TwilioPhoneNumberProvider? Type1292 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TwilioPhoneNumberStatus? Type1293 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.VonagePhoneNumber? Type1294 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.VonagePhoneNumberProvider? Type1295 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.VonagePhoneNumberStatus? Type1296 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SipAuthentication? Type1297 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.VapiPhoneNumber? Type1298 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.VapiPhoneNumberProvider? Type1299 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.VapiPhoneNumberStatus? Type1300 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TelnyxPhoneNumber? Type1301 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TelnyxPhoneNumberProvider? Type1302 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TelnyxPhoneNumberStatus? Type1303 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateByoPhoneNumberDTO? Type1304 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateByoPhoneNumberDTOProvider? Type1305 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateTwilioPhoneNumberDTO? Type1306 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateTwilioPhoneNumberDTOProvider? Type1307 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateVonagePhoneNumberDTO? Type1308 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateVonagePhoneNumberDTOProvider? Type1309 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateVapiPhoneNumberDTO? Type1310 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateVapiPhoneNumberDTOProvider? Type1311 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateTelnyxPhoneNumberDTO? Type1312 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateTelnyxPhoneNumberDTOProvider? Type1313 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateByoPhoneNumberDTO? Type1314 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateByoPhoneNumberDTOProvider? Type1315 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateTwilioPhoneNumberDTO? Type1316 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateTwilioPhoneNumberDTOProvider? Type1317 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateVonagePhoneNumberDTO? Type1318 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateVonagePhoneNumberDTOProvider? Type1319 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateVapiPhoneNumberDTO? Type1320 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateVapiPhoneNumberDTOProvider? Type1321 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateTelnyxPhoneNumberDTO? Type1322 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateTelnyxPhoneNumberDTOProvider? Type1323 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ImportVonagePhoneNumberDTO? Type1324 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.PhoneNumberPaginatedResponse? Type1325 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.OneOf<global::Vapi.ByoPhoneNumber, global::Vapi.TwilioPhoneNumber, global::Vapi.VonagePhoneNumber, global::Vapi.VapiPhoneNumber, global::Vapi.TelnyxPhoneNumber>>? Type1326 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OneOf<global::Vapi.ByoPhoneNumber, global::Vapi.TwilioPhoneNumber, global::Vapi.VonagePhoneNumber, global::Vapi.VapiPhoneNumber, global::Vapi.TelnyxPhoneNumber>? Type1327 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ApiRequestTool? Type1328 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ApiRequestToolType? Type1329 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ApiRequestToolMethod? Type1330 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CodeToolEnvironmentVariable? Type1331 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CodeTool? Type1332 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CodeToolType? Type1333 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.CodeToolEnvironmentVariable>? Type1334 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.DtmfTool? Type1335 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.DtmfToolType? Type1336 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.EndCallTool? Type1337 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.EndCallToolType? Type1338 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FunctionTool? Type1339 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FunctionToolType? Type1340 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.KnowledgeBaseToolFunction? Type1341 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.KnowledgeBaseTool? Type1342 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.KnowledgeBaseToolType? Type1343 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GhlTool? Type1344 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GhlToolType? Type1345 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.MakeTool? Type1346 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.MakeToolType? Type1347 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TransferCallTool? Type1348 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TransferCallToolType? Type1349 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.HandoffTool? Type1350 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.HandoffToolType? Type1351 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OutputTool? Type1352 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OutputToolType? Type1353 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.BashTool? Type1354 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.BashToolType? Type1355 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.BashToolSubType? Type1356 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.BashToolName? Type1357 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ComputerTool? Type1358 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ComputerToolType? Type1359 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ComputerToolSubType? Type1360 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ComputerToolName? Type1361 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TextEditorTool? Type1362 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TextEditorToolType? Type1363 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TextEditorToolSubType? Type1364 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TextEditorToolName? Type1365 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.QueryTool? Type1366 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.QueryToolType? Type1367 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GoogleCalendarCreateEventTool? Type1368 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GoogleCalendarCreateEventToolType? Type1369 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GoogleSheetsRowAppendTool? Type1370 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GoogleSheetsRowAppendToolType? Type1371 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GoogleCalendarCheckAvailabilityTool? Type1372 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GoogleCalendarCheckAvailabilityToolType? Type1373 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SlackSendMessageTool? Type1374 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SlackSendMessageToolType? Type1375 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SmsTool? Type1376 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SmsToolType? Type1377 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.McpTool? Type1378 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.McpToolType? Type1379 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GoHighLevelCalendarAvailabilityTool? Type1380 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GoHighLevelCalendarAvailabilityToolType? Type1381 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GoHighLevelCalendarEventCreateTool? Type1382 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GoHighLevelCalendarEventCreateToolType? Type1383 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GoHighLevelContactCreateTool? Type1384 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GoHighLevelContactCreateToolType? Type1385 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GoHighLevelContactGetTool? Type1386 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GoHighLevelContactGetToolType? Type1387 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SipRequestTool? Type1388 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SipRequestToolType? Type1389 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SipRequestToolVerb? Type1390 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OneOf<string, global::Vapi.JsonSchema>? Type1391 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.VoicemailTool? Type1392 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.VoicemailToolType? Type1393 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateApiRequestToolDTOType? Type1394 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateApiRequestToolDTOMethod? Type1395 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateCodeToolDTOType? Type1396 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateOutputToolDTO? Type1397 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateOutputToolDTOType? Type1398 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateBashToolDTOType? Type1399 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateBashToolDTOSubType? Type1400 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateBashToolDTOName? Type1401 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateComputerToolDTOType? Type1402 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateComputerToolDTOSubType? Type1403 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateComputerToolDTOName? Type1404 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateTextEditorToolDTOType? Type1405 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateTextEditorToolDTOSubType? Type1406 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateTextEditorToolDTOName? Type1407 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateSmsToolDTOType? Type1408 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateSipRequestToolDTOType? Type1409 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateSipRequestToolDTOVerb? Type1410 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateApiRequestToolDTO? Type1411 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateApiRequestToolDTOType? Type1412 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateApiRequestToolDTOMethod? Type1413 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateCodeToolDTO? Type1414 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateCodeToolDTOType? Type1415 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateDtmfToolDTO? Type1416 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateDtmfToolDTOType? Type1417 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateEndCallToolDTO? Type1418 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateEndCallToolDTOType? Type1419 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateFunctionToolDTO? Type1420 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateFunctionToolDTOType? Type1421 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateKnowledgeBaseToolDTO? Type1422 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateKnowledgeBaseToolDTOType? Type1423 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateGhlToolDTO? Type1424 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateGhlToolDTOType? Type1425 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateMakeToolDTO? Type1426 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateMakeToolDTOType? Type1427 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateHandoffToolDTO? Type1428 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateHandoffToolDTOType? Type1429 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateTransferCallToolDTO? Type1430 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateTransferCallToolDTOType? Type1431 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateOutputToolDTO? Type1432 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateOutputToolDTOType? Type1433 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateBashToolDTO? Type1434 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateBashToolDTOType? Type1435 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateBashToolDTOSubType? Type1436 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateBashToolDTOName? Type1437 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateComputerToolDTO? Type1438 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateComputerToolDTOType? Type1439 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateComputerToolDTOSubType? Type1440 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateComputerToolDTOName? Type1441 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateTextEditorToolDTO? Type1442 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateTextEditorToolDTOType? Type1443 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateTextEditorToolDTOSubType? Type1444 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateTextEditorToolDTOName? Type1445 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateQueryToolDTO? Type1446 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateQueryToolDTOType? Type1447 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateGoogleCalendarCreateEventToolDTO? Type1448 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateGoogleCalendarCreateEventToolDTOType? Type1449 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateGoogleSheetsRowAppendToolDTO? Type1450 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateGoogleSheetsRowAppendToolDTOType? Type1451 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateGoogleCalendarCheckAvailabilityToolDTO? Type1452 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateGoogleCalendarCheckAvailabilityToolDTOType? Type1453 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateSlackSendMessageToolDTO? Type1454 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateSlackSendMessageToolDTOType? Type1455 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateSmsToolDTO? Type1456 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateSmsToolDTOType? Type1457 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateMcpToolDTO? Type1458 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateMcpToolDTOType? Type1459 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateGoHighLevelCalendarAvailabilityToolDTO? Type1460 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateGoHighLevelCalendarAvailabilityToolDTOType? Type1461 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateGoHighLevelCalendarEventCreateToolDTO? Type1462 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateGoHighLevelCalendarEventCreateToolDTOType? Type1463 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateGoHighLevelContactCreateToolDTO? Type1464 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateGoHighLevelContactCreateToolDTOType? Type1465 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateGoHighLevelContactGetToolDTO? Type1466 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateGoHighLevelContactGetToolDTOType? Type1467 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateSipRequestToolDTO? Type1468 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateSipRequestToolDTOType? Type1469 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateSipRequestToolDTOVerb? Type1470 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateVoicemailToolDTO? Type1471 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateVoicemailToolDTOType? Type1472 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ToolVersion? Type1473 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ToolVersionPaginatedMetadata? Type1474 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ToolVersionPaginatedResponse? Type1475 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.ToolVersion>? Type1476 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ToolDraft? Type1477 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ToolDraftType? Type1478 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ToolDraftMethod? Type1479 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ToolDraftVerb? Type1480 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateToolDraftDTO? Type1481 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateToolDraftDTOType? Type1482 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateToolDraftDTOMethod? Type1483 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateToolDraftDTOVerb? Type1484 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateToolDraftDTO? Type1485 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateToolDraftDTOType? Type1486 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateToolDraftDTOMethod? Type1487 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateToolDraftDTOVerb? Type1488 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ToolDraftPaginatedMetadata? Type1489 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ToolDraftPaginatedResponse? Type1490 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.ToolDraft>? Type1491 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ToolDraftConflictResponseDTO? Type1492 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GetToolDraftsDTO? Type1493 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateToolVersionMetadataDTO? Type1494 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ToolPinnedConflictResponseDTO? Type1495 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ToolPinnedConflictResponseDTOError? Type1496 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateFileDTO? Type1497 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateFileDTOPurpose? Type1498 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.File? Type1499 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FileObject? Type1500 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FileStatus? Type1501 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateFileDTO? Type1502 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CustomKnowledgeBase? Type1503 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CustomKnowledgeBaseProvider? Type1504 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateCustomKnowledgeBaseDTO? Type1505 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateCustomKnowledgeBaseDTOProvider? Type1506 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateKnowledgeBaseV2DTO? Type1507 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.KnowledgeBaseV2? Type1508 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.KnowledgeBaseV2File? Type1509 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.KnowledgeBaseV2FileStatus? Type1510 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AttachKnowledgeBaseV2FileDTO? Type1511 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateKnowledgeBaseV2DTO? Type1512 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.KnowledgeBaseV2WithFiles? Type1513 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.KnowledgeBaseV2File>? Type1514 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.StructuredOutputRunResult? Type1515 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.StructuredOutputRunPreviewResponse? Type1516 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.StructuredOutputRerunResponse? Type1517 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.StructuredOutput? Type1518 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.StructuredOutputType? Type1519 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.StructuredOutputPaginatedResponse? Type1520 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.StructuredOutput>? Type1521 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateStructuredOutputDTO? Type1522 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateStructuredOutputDTOType? Type1523 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.StructuredOutputRunDTO? Type1524 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TesterPlan? Type1525 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TestSuitePhoneNumber? Type1526 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TestSuitePhoneNumberProvider? Type1527 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TargetPlan? Type1528 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TestSuite? Type1529 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TestSuitesPaginatedResponse? Type1530 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.TestSuite>? Type1531 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateTestSuiteDto? Type1532 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateTestSuiteDto? Type1533 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TestSuiteTestVoice? Type1534 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.TestSuiteTestScorerAI>? Type1535 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TestSuiteTestScorerAI? Type1536 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TestSuiteTestVoiceType? Type1537 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TestSuiteTestChat? Type1538 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TestSuiteTestChatType? Type1539 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateTestSuiteTestVoiceDto? Type1540 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateTestSuiteTestVoiceDtoType? Type1541 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateTestSuiteTestChatDto? Type1542 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateTestSuiteTestChatDtoType? Type1543 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateTestSuiteTestVoiceDto? Type1544 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateTestSuiteTestVoiceDtoType? Type1545 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateTestSuiteTestChatDto? Type1546 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateTestSuiteTestChatDtoType? Type1547 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TestSuiteTestScorerAIType? Type1548 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TestSuiteTestsPaginatedResponse? Type1549 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.OneOf<global::Vapi.TestSuiteTestVoice, global::Vapi.TestSuiteTestChat>>? Type1550 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OneOf<global::Vapi.TestSuiteTestVoice, global::Vapi.TestSuiteTestChat>? Type1551 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TestSuiteRunScorerAI? Type1552 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TestSuiteRunScorerAIType? Type1553 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TestSuiteRunScorerAIResult? Type1554 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TestSuiteRunTestAttemptCall? Type1555 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TestSuiteRunTestAttemptMetadata? Type1556 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TestSuiteRunTestAttempt? Type1557 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.TestSuiteRunScorerAI>? Type1558 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TestSuiteRunTestResult? Type1559 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.TestSuiteRunTestAttempt>? Type1560 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TestSuiteRun? Type1561 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TestSuiteRunStatus? Type1562 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.TestSuiteRunTestResult>? Type1563 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TestSuiteRunsPaginatedResponse? Type1564 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.TestSuiteRun>? Type1565 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateTestSuiteRunDto? Type1566 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateTestSuiteRunDto? Type1567 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreatePersonalityDTO? Type1568 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.Personality? Type1569 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdatePersonalityDTO? Type1570 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.PersonalityInUseConflictResponseDTO? Type1571 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.PersonalityInUseConflictResponseDTOError? Type1572 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SimulationHookInclude? Type1573 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SimulationHookWebhookAction? Type1574 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SimulationHookWebhookActionType? Type1575 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SimulationHookCallStarted? Type1576 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SimulationHookCallStartedOn? Type1577 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.SimulationHookWebhookAction>? Type1578 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SimulationHookCallEnded? Type1579 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SimulationHookCallEndedOn? Type1580 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.EvaluationPlanItem? Type1581 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.EvaluationPlanItemComparator? Type1582 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OneOf<double?, string, bool?>? Type1583 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ScenarioToolMock? Type1584 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateScenarioDTO? Type1585 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.EvaluationPlanItem>? Type1586 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.OneOf<global::Vapi.SimulationHookCallStarted, global::Vapi.SimulationHookCallEnded>>? Type1587 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OneOf<global::Vapi.SimulationHookCallStarted, global::Vapi.SimulationHookCallEnded>? Type1588 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.ScenarioToolMock>? Type1589 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.Scenario? Type1590 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateScenarioDTO? Type1591 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ScenarioInUseConflictResponseDTO? Type1592 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ScenarioInUseConflictResponseDTOError? Type1593 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SimulationRunSimulationEntry? Type1594 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SimulationRunSimulationEntryType? Type1595 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SimulationRunSuiteEntry? Type1596 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SimulationRunSuiteEntryType? Type1597 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SimulationRunTargetAssistant? Type1598 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SimulationRunTargetAssistantType? Type1599 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SimulationRunTargetSquad? Type1600 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SimulationRunTargetSquadType? Type1601 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SimulationRunTransportConfiguration? Type1602 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SimulationRunTransportConfigurationProvider? Type1603 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateSimulationRunDTO? Type1604 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.OneOf<global::Vapi.SimulationRunSimulationEntry, global::Vapi.SimulationRunSuiteEntry>>? Type1605 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OneOf<global::Vapi.SimulationRunSimulationEntry, global::Vapi.SimulationRunSuiteEntry>? Type1606 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OneOf<global::Vapi.SimulationRunTargetAssistant, global::Vapi.SimulationRunTargetSquad>? Type1607 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SimulationRunItemCounts? Type1608 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateSimulationRunResponse? Type1609 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateSimulationRunResponseStatus? Type1610 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SimulationRunPaymentRequiredResponse? Type1611 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SimulationRunPaymentRequiredResponseReason? Type1612 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SimulationRun? Type1613 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SimulationRunStatus? Type1614 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SimulationRunListSource? Type1615 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SimulationRunListSourceType? Type1616 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SimulationRunListSummary? Type1617 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SimulationRunListItem? Type1618 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SimulationRunListItemStatus? Type1619 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SimulationRunsPaginatedResponse? Type1620 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.SimulationRunListItem>? Type1621 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SimulationRunItemCallMonitor? Type1622 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SimulationRunItemCallMetadata? Type1623 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SimulationRunItemMetadata? Type1624 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.StructuredOutputEvaluationResult? Type1625 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OneOf<double?, string, bool?, object>? Type1626 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.StructuredOutputEvaluationResultComparator? Type1627 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.LatencyMetrics? Type1628 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SimulationRunItemResults? Type1629 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.StructuredOutputEvaluationResult>? Type1630 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SimulationRunItemImprovementSuggestion? Type1631 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SimulationRunItemImprovements? Type1632 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.SimulationRunItemImprovementSuggestion>? Type1633 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SimulationRunConfiguration? Type1634 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SimulationRunItem? Type1635 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SimulationRunItemStatus? Type1636 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SimulationSuiteTargetAssignment? Type1637 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SimulationSuiteTargetAssignmentTargetType? Type1638 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateSimulationSuiteDTO? Type1639 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.SimulationSuiteTargetAssignment>? Type1640 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SimulationSuite? Type1641 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateSimulationSuiteDTO? Type1642 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GenerateScenariosDTO? Type1643 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GeneratedScenario? Type1644 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GeneratedScenarioCategory? Type1645 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GenerateScenariosResponse? Type1646 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.GeneratedScenario>? Type1647 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateSimulationDTO? Type1648 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.Simulation? Type1649 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateSimulationDTO? Type1650 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SimulationConcurrencyResponse? Type1651 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.BarInsightMetadata? Type1652 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.InsightTimeRangeWithStep? Type1653 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.InsightTimeRangeWithStepStep? Type1654 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.BarInsight? Type1655 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.BarInsightType? Type1656 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.InsightFormula>? Type1657 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.InsightFormula? Type1658 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.BarInsightGroupBy? Type1659 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.JSONQueryOnCallTableWithStringTypeColumn? Type1660 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.JSONQueryOnCallTableWithNumberTypeColumn? Type1661 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.JSONQueryOnCallTableWithStructuredOutputColumn? Type1662 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.JSONQueryOnEventsTable? Type1663 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.InsightTimeRange? Type1664 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.PieInsight? Type1665 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.PieInsightType? Type1666 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.PieInsightGroupBy? Type1667 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.LineInsightMetadata? Type1668 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.LineInsight? Type1669 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.LineInsightType? Type1670 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.LineInsightGroupBy? Type1671 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TextInsight? Type1672 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TextInsightType? Type1673 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateBarInsightFromCallTableDTO? Type1674 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateBarInsightFromCallTableDTOType? Type1675 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateBarInsightFromCallTableDTOGroupBy? Type1676 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdatePieInsightFromCallTableDTO? Type1677 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdatePieInsightFromCallTableDTOType? Type1678 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdatePieInsightFromCallTableDTOGroupBy? Type1679 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateLineInsightFromCallTableDTO? Type1680 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateLineInsightFromCallTableDTOType? Type1681 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateLineInsightFromCallTableDTOGroupBy? Type1682 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateTextInsightFromCallTableDTO? Type1683 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateTextInsightFromCallTableDTOType? Type1684 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateBarInsightFromCallTableDTO? Type1685 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateBarInsightFromCallTableDTOType? Type1686 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateBarInsightFromCallTableDTOGroupBy? Type1687 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreatePieInsightFromCallTableDTO? Type1688 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreatePieInsightFromCallTableDTOType? Type1689 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreatePieInsightFromCallTableDTOGroupBy? Type1690 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateLineInsightFromCallTableDTO? Type1691 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateLineInsightFromCallTableDTOType? Type1692 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateLineInsightFromCallTableDTOGroupBy? Type1693 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateTextInsightFromCallTableDTO? Type1694 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateTextInsightFromCallTableDTOType? Type1695 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.JSONQueryOnCallTableWithStringTypeColumnType? Type1696 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.JSONQueryOnCallTableWithStringTypeColumnTable? Type1697 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FilterStringTypeColumnOnCallTable? Type1698 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FilterStringArrayTypeColumnOnCallTable? Type1699 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FilterNumberTypeColumnOnCallTable? Type1700 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FilterNumberArrayTypeColumnOnCallTable? Type1701 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FilterDateTypeColumnOnCallTable? Type1702 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FilterStructuredOutputColumnOnCallTable? Type1703 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.JSONQueryOnCallTableWithStringTypeColumnColumn? Type1704 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.JSONQueryOnCallTableWithStringTypeColumnOperation? Type1705 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.JSONQueryOnCallTableWithNumberTypeColumnType? Type1706 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.JSONQueryOnCallTableWithNumberTypeColumnTable? Type1707 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.JSONQueryOnCallTableWithNumberTypeColumnColumn? Type1708 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.JSONQueryOnCallTableWithNumberTypeColumnOperation? Type1709 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.JSONQueryOnCallTableWithStructuredOutputColumnType? Type1710 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.JSONQueryOnCallTableWithStructuredOutputColumnTable? Type1711 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.JSONQueryOnCallTableWithStructuredOutputColumnColumn? Type1712 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.JSONQueryOnCallTableWithStructuredOutputColumnOperation? Type1713 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.JSONQueryOnEventsTableType? Type1714 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.JSONQueryOnEventsTableTable? Type1715 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.JSONQueryOnEventsTableOn? Type1716 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.JSONQueryOnEventsTableOperation? Type1717 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.OneOf<global::Vapi.EventsTableStringCondition, global::Vapi.EventsTableNumberCondition, global::Vapi.EventsTableBooleanCondition>>? Type1718 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OneOf<global::Vapi.EventsTableStringCondition, global::Vapi.EventsTableNumberCondition, global::Vapi.EventsTableBooleanCondition>? Type1719 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.EventsTableStringCondition? Type1720 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.EventsTableNumberCondition? Type1721 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.EventsTableBooleanCondition? Type1722 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FilterStringTypeColumnOnCallTableColumn? Type1723 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FilterStringTypeColumnOnCallTableOperator? Type1724 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FilterNumberTypeColumnOnCallTableColumn? Type1725 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FilterNumberTypeColumnOnCallTableOperator? Type1726 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FilterDateTypeColumnOnCallTableColumn? Type1727 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FilterDateTypeColumnOnCallTableOperator? Type1728 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FilterStructuredOutputColumnOnCallTableColumn? Type1729 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FilterStructuredOutputColumnOnCallTableOperator? Type1730 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FilterStringArrayTypeColumnOnCallTableColumn? Type1731 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FilterStringArrayTypeColumnOnCallTableOperator? Type1732 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FilterNumberArrayTypeColumnOnCallTableColumn? Type1733 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FilterNumberArrayTypeColumnOnCallTableOperator? Type1734 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.EventsTableStringConditionOperator? Type1735 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.EventsTableNumberConditionOperator? Type1736 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.EventsTableBooleanConditionOperator? Type1737 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.BarInsightFromCallTable? Type1738 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.BarInsightFromCallTableType? Type1739 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.BarInsightFromCallTableGroupBy? Type1740 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.PieInsightFromCallTable? Type1741 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.PieInsightFromCallTableType? Type1742 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.PieInsightFromCallTableGroupBy? Type1743 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.LineInsightFromCallTable? Type1744 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.LineInsightFromCallTableType? Type1745 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.LineInsightFromCallTableGroupBy? Type1746 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TextInsightFromCallTable? Type1747 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TextInsightFromCallTableType? Type1748 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.InsightRunFormatPlan? Type1749 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.InsightRunFormatPlanFormat? Type1750 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.InsightRunDTO? Type1751 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.InsightRunResponse? Type1752 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.Insight? Type1753 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.InsightType? Type1754 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.InsightPaginatedResponse? Type1755 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.Insight>? Type1756 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.BoardLayout? Type1757 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.Board? Type1758 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.OneOf<global::Vapi.BoardInsightItem, global::Vapi.BoardMetricWidgetItem>>? Type1759 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OneOf<global::Vapi.BoardInsightItem, global::Vapi.BoardMetricWidgetItem>? Type1760 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.BoardInsightItem? Type1761 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.BoardMetricWidgetItem? Type1762 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.BoardItemPosition? Type1763 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.BoardItemSize? Type1764 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.BoardInsightItemType? Type1765 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.BoardMetricWidgetItemType? Type1766 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateBoardDTO? Type1767 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateBoardDTO? Type1768 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.BoardPaginatedResponse? Type1769 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.Board>? Type1770 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateEvalDTO? Type1771 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ChatEvalAssistantMessageMock? Type1772 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ChatEvalSystemMessageMock? Type1773 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ChatEvalToolResponseMessageMock? Type1774 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ChatEvalToolResponseMessageEvaluation? Type1775 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ChatEvalUserMessageMock? Type1776 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ChatEvalAssistantMessageEvaluation? Type1777 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateEvalDTOType? Type1778 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.Eval? Type1779 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.EvalType? Type1780 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.EvalModelListOptions? Type1781 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.EvalModelListOptionsProvider? Type1782 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.EvalUserEditable? Type1783 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.EvalUserEditableType? Type1784 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ChatEvalAssistantMessageMockToolCall? Type1785 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ChatEvalAssistantMessageMockRole? Type1786 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.ChatEvalAssistantMessageMockToolCall>? Type1787 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ChatEvalSystemMessageMockRole? Type1788 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ChatEvalToolResponseMessageMockRole? Type1789 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ChatEvalUserMessageMockRole? Type1790 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AssistantMessageEvaluationContinuePlan? Type1791 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ChatEvalAssistantMessageEvaluationRole? Type1792 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OneOf<global::Vapi.AssistantMessageJudgePlanExact, global::Vapi.AssistantMessageJudgePlanRegex, global::Vapi.AssistantMessageJudgePlanAI>? Type1793 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AssistantMessageJudgePlanExact? Type1794 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AssistantMessageJudgePlanRegex? Type1795 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AssistantMessageJudgePlanAI? Type1796 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.EvalOpenAIModel? Type1797 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.EvalOpenAIModelProvider? Type1798 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.EvalOpenAIModelModel? Type1799 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.EvalAnthropicModel? Type1800 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.EvalAnthropicModelProvider? Type1801 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.EvalAnthropicModelModel? Type1802 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.EvalGoogleModel? Type1803 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.EvalGoogleModelProvider? Type1804 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.EvalGoogleModelModel? Type1805 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.EvalGroqModel? Type1806 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.EvalGroqModelProvider? Type1807 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.EvalGroqModelModel? Type1808 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.EvalCustomModel? Type1809 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.EvalCustomModelProvider? Type1810 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OneOf<global::Vapi.EvalOpenAIModel, global::Vapi.EvalAnthropicModel, global::Vapi.EvalGoogleModel, global::Vapi.EvalCustomModel>? Type1811 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AssistantMessageJudgePlanAIType? Type1812 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ChatEvalToolResponseMessageEvaluationRole? Type1813 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AssistantMessageJudgePlanExactType? Type1814 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AssistantMessageJudgePlanRegexType? Type1815 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GetEvalPaginatedDTO? Type1816 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GetEvalPaginatedDTOSortOrder? Type1817 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GetEvalPaginatedDTOSortBy? Type1818 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.EvalPaginatedResponse? Type1819 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.Eval>? Type1820 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateEvalDTO? Type1821 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateEvalDTOType? Type1822 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateEvalRunDTO? Type1823 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OneOf<global::Vapi.EvalRunTargetAssistant, global::Vapi.EvalRunTargetSquad>? Type1824 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.EvalRunTargetAssistant? Type1825 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.EvalRunTargetSquad? Type1826 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateEvalRunDTOType? Type1827 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.EvalRunResult? Type1828 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.EvalRunResultStatus? Type1829 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OneOf<global::Vapi.ChatEvalUserMessageMock, global::Vapi.ChatEvalSystemMessageMock, global::Vapi.ChatEvalToolResponseMessageMock, global::Vapi.ChatEvalAssistantMessageMock>? Type1830 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.EvalRun? Type1831 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.EvalRunStatus? Type1832 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.EvalRunEndedReason? Type1833 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.EvalRunResult>? Type1834 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.EvalRunType? Type1835 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.EvalRunPaginatedResponse? Type1836 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.EvalRun>? Type1837 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GetEvalRunPaginatedDTO? Type1838 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GetEvalRunPaginatedDTOSortOrder? Type1839 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GetEvalRunPaginatedDTOSortBy? Type1840 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.EvalRunTargetAssistantType? Type1841 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.EvalRunTargetSquadType? Type1842 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.Scorecard? Type1843 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ScorecardPaginatedResponse? Type1844 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.Scorecard>? Type1845 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateScorecardDTO? Type1846 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateOrgDTO? Type1847 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateOrgDTOChannel? Type1848 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AutoReloadPlan? Type1849 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.InvoicePlan? Type1850 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.Subscription? Type1851 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SubscriptionType? Type1852 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SubscriptionStatus? Type1853 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SubscriptionMinutesIncludedResetFrequency? Type1854 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.Org? Type1855 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OrgChannel? Type1856 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateOrgDTO? Type1857 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateOrgDTOChannel? Type1858 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.User? Type1859 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.InviteUserDTO? Type1860 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OneOf<global::Vapi.InviteUserDTORole?, string>? Type1861 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.InviteUserDTORole? Type1862 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.PendingInvitationDTO? Type1863 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.PendingInvitationsResponseDTO? Type1864 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.PendingInvitationDTO>? Type1865 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.RevokeInvitationResponseDTO? Type1866 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateUserRoleDTO? Type1867 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OneOf<global::Vapi.UpdateUserRoleDTORole?, string>? Type1868 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateUserRoleDTORole? Type1869 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.JwtResponse? Type1870 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TokenRestrictions? Type1871 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateTokenDTO? Type1872 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateTokenDTOTag? Type1873 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.Token? Type1874 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TokenTag? Type1875 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateTokenDTO? Type1876 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateTokenDTOTag? Type1877 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AnthropicCredential? Type1878 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AnthropicCredentialProvider? Type1879 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AWSStsAuthenticationArtifact? Type1880 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AWSStsAssumeRoleUser? Type1881 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AWSStsCredentials? Type1882 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AWSStsAuthenticationSession? Type1883 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AnthropicBedrockCredential? Type1884 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AnthropicBedrockCredentialProvider? Type1885 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AnthropicBedrockCredentialRegion? Type1886 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AnyscaleCredential? Type1887 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AnyscaleCredentialProvider? Type1888 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AssemblyAICredential? Type1889 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AssemblyAICredentialProvider? Type1890 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AzureCredential? Type1891 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AzureCredentialProvider? Type1892 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AzureCredentialService? Type1893 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AzureCredentialRegion? Type1894 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AzureOpenAICredential? Type1895 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AzureOpenAICredentialProvider? Type1896 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AzureOpenAICredentialRegion? Type1897 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.AzureOpenAICredentialModel>? Type1898 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AzureOpenAICredentialModel? Type1899 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ByoSipTrunkCredential? Type1900 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ByoSipTrunkCredentialProvider? Type1901 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CartesiaCredential? Type1902 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CartesiaCredentialProvider? Type1903 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CerebrasCredential? Type1904 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CerebrasCredentialProvider? Type1905 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CloudflareCredential? Type1906 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CloudflareCredentialProvider? Type1907 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.Oauth2AuthenticationSession? Type1908 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CustomLLMCredential? Type1909 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CustomLLMCredentialProvider? Type1910 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.DeepgramCredential? Type1911 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.DeepgramCredentialProvider? Type1912 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.DeepInfraCredential? Type1913 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.DeepInfraCredentialProvider? Type1914 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.DeepSeekCredential? Type1915 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.DeepSeekCredentialProvider? Type1916 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ElevenLabsCredential? Type1917 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ElevenLabsCredentialProvider? Type1918 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ElevenLabsCredentialApiUrl? Type1919 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GcpCredential? Type1920 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GcpCredentialProvider? Type1921 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GladiaCredential? Type1922 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GladiaCredentialProvider? Type1923 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GoHighLevelCredential? Type1924 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GoHighLevelCredentialProvider? Type1925 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GoogleCredential? Type1926 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GoogleCredentialProvider? Type1927 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GroqCredential? Type1928 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GroqCredentialProvider? Type1929 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.HumeCredential? Type1930 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.HumeCredentialProvider? Type1931 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.InflectionAICredential? Type1932 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.InflectionAICredentialProvider? Type1933 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.LangfuseCredential? Type1934 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.LangfuseCredentialProvider? Type1935 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.LmntCredential? Type1936 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.LmntCredentialProvider? Type1937 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.MakeCredential? Type1938 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.MakeCredentialProvider? Type1939 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.MicrosoftCredential? Type1940 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.MicrosoftCredentialProvider? Type1941 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.MistralCredential? Type1942 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.MistralCredentialProvider? Type1943 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.NeuphonicCredential? Type1944 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.NeuphonicCredentialProvider? Type1945 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OpenAICredential? Type1946 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OpenAICredentialProvider? Type1947 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OpenRouterCredential? Type1948 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OpenRouterCredentialProvider? Type1949 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.PerplexityAICredential? Type1950 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.PerplexityAICredentialProvider? Type1951 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.PlayHTCredential? Type1952 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.PlayHTCredentialProvider? Type1953 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.RimeAICredential? Type1954 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.RimeAICredentialProvider? Type1955 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.RunpodCredential? Type1956 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.RunpodCredentialProvider? Type1957 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.WellSaidCredential? Type1958 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.WellSaidCredentialProvider? Type1959 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.S3Credential? Type1960 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.S3CredentialProvider? Type1961 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.S3CompatibleBucketPlan? Type1962 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.S3CompatibleStorageCredential? Type1963 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.S3CompatibleStorageCredentialProvider? Type1964 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SmallestAICredential? Type1965 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SmallestAICredentialProvider? Type1966 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SonioxCredential? Type1967 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SonioxCredentialProvider? Type1968 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SpeechmaticsCredential? Type1969 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SpeechmaticsCredentialProvider? Type1970 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SupabaseCredential? Type1971 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SupabaseCredentialProvider? Type1972 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TavusCredential? Type1973 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TavusCredentialProvider? Type1974 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TogetherAICredential? Type1975 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TogetherAICredentialProvider? Type1976 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TwilioCredential? Type1977 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TwilioCredentialProvider? Type1978 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.VonageCredential? Type1979 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.VonageCredentialProvider? Type1980 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.WebhookCredential? Type1981 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.WebhookCredentialProvider? Type1982 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AuthenticationPlan4? Type1983 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.WebhookCredentialAuthenticationPlanDiscriminator? Type1984 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.WebhookCredentialAuthenticationPlanDiscriminatorType? Type1985 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SpkiPemPublicKeyConfig? Type1986 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SpkiPemPublicKeyConfigFormat? Type1987 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.PublicKeyEncryptionPlan? Type1988 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.PublicKeyEncryptionPlanType? Type1989 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.PublicKeyEncryptionPlanAlgorithm? Type1990 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.PublicKeyEncryptionPlanPublicKeyDiscriminator? Type1991 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.PublicKeyEncryptionPlanPublicKeyDiscriminatorFormat? Type1992 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CustomCredential? Type1993 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CustomCredentialProvider? Type1994 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AuthenticationPlan5? Type1995 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CustomCredentialAuthenticationPlanDiscriminator? Type1996 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CustomCredentialAuthenticationPlanDiscriminatorType? Type1997 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CustomCredentialEncryptionPlanDiscriminator? Type1998 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CustomCredentialEncryptionPlanDiscriminatorType? Type1999 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.XAiCredential? Type2000 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.XAiCredentialProvider? Type2001 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GoogleCalendarOAuth2ClientCredential? Type2002 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GoogleCalendarOAuth2ClientCredentialProvider? Type2003 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GoogleCalendarOAuth2AuthorizationCredential? Type2004 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GoogleCalendarOAuth2AuthorizationCredentialProvider? Type2005 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GoogleSheetsOAuth2AuthorizationCredential? Type2006 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GoogleSheetsOAuth2AuthorizationCredentialProvider? Type2007 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SlackOAuth2AuthorizationCredential? Type2008 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SlackOAuth2AuthorizationCredentialProvider? Type2009 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GoHighLevelMCPCredential? Type2010 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GoHighLevelMCPCredentialProvider? Type2011 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.InworldCredential? Type2012 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.InworldCredentialProvider? Type2013 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.EmailCredential? Type2014 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.EmailCredentialProvider? Type2015 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SlackWebhookCredential? Type2016 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SlackWebhookCredentialProvider? Type2017 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateCerebrasCredentialDTOProvider? Type2018 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateGoogleCredentialDTOProvider? Type2019 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateHumeCredentialDTOProvider? Type2020 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateInflectionAICredentialDTOProvider? Type2021 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateMicrosoftCredentialDTOProvider? Type2022 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateMistralCredentialDTOProvider? Type2023 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateNeuphonicCredentialDTOProvider? Type2024 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateWellSaidCredentialDTOProvider? Type2025 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateS3CompatibleCredentialDTOProvider? Type2026 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateSonioxCredentialDTOProvider? Type2027 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateSpeechmaticsCredentialDTOProvider? Type2028 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateCustomCredentialDTOProvider? Type2029 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AuthenticationPlan6? Type2030 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateCustomCredentialDTOAuthenticationPlanDiscriminator? Type2031 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateCustomCredentialDTOAuthenticationPlanDiscriminatorType? Type2032 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateCustomCredentialDTOEncryptionPlanDiscriminator? Type2033 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateCustomCredentialDTOEncryptionPlanDiscriminatorType? Type2034 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateGoHighLevelMCPCredentialDTOProvider? Type2035 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateInworldCredentialDTOProvider? Type2036 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateEmailCredentialDTOProvider? Type2037 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateSlackWebhookCredentialDTOProvider? Type2038 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateAnthropicCredentialDTO? Type2039 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateAnthropicCredentialDTOProvider? Type2040 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateAnthropicBedrockCredentialDTO? Type2041 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateAnthropicBedrockCredentialDTOProvider? Type2042 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateAnthropicBedrockCredentialDTORegion? Type2043 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateAnyscaleCredentialDTO? Type2044 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateAnyscaleCredentialDTOProvider? Type2045 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateAssemblyAICredentialDTO? Type2046 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateAssemblyAICredentialDTOProvider? Type2047 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateAzureCredentialDTO? Type2048 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateAzureCredentialDTOProvider? Type2049 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateAzureCredentialDTOService? Type2050 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateAzureCredentialDTORegion? Type2051 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateAzureOpenAICredentialDTO? Type2052 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateAzureOpenAICredentialDTOProvider? Type2053 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateAzureOpenAICredentialDTORegion? Type2054 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.UpdateAzureOpenAICredentialDTOModel>? Type2055 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateAzureOpenAICredentialDTOModel? Type2056 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateByoSipTrunkCredentialDTO? Type2057 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateByoSipTrunkCredentialDTOProvider? Type2058 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateCartesiaCredentialDTO? Type2059 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateCartesiaCredentialDTOProvider? Type2060 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateCerebrasCredentialDTO? Type2061 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateCerebrasCredentialDTOProvider? Type2062 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateCloudflareCredentialDTO? Type2063 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateCloudflareCredentialDTOProvider? Type2064 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateCustomLLMCredentialDTO? Type2065 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateCustomLLMCredentialDTOProvider? Type2066 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateDeepgramCredentialDTO? Type2067 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateDeepgramCredentialDTOProvider? Type2068 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateDeepInfraCredentialDTO? Type2069 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateDeepInfraCredentialDTOProvider? Type2070 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateDeepSeekCredentialDTO? Type2071 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateDeepSeekCredentialDTOProvider? Type2072 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateElevenLabsCredentialDTO? Type2073 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateElevenLabsCredentialDTOProvider? Type2074 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateElevenLabsCredentialDTOApiUrl? Type2075 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateGcpCredentialDTO? Type2076 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateGcpCredentialDTOProvider? Type2077 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateGladiaCredentialDTO? Type2078 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateGladiaCredentialDTOProvider? Type2079 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateGoHighLevelCredentialDTO? Type2080 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateGoHighLevelCredentialDTOProvider? Type2081 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateGoogleCredentialDTO? Type2082 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateGoogleCredentialDTOProvider? Type2083 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateGroqCredentialDTO? Type2084 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateGroqCredentialDTOProvider? Type2085 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateHumeCredentialDTO? Type2086 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateHumeCredentialDTOProvider? Type2087 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateInflectionAICredentialDTO? Type2088 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateInflectionAICredentialDTOProvider? Type2089 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateLangfuseCredentialDTO? Type2090 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateLangfuseCredentialDTOProvider? Type2091 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateLmntCredentialDTO? Type2092 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateLmntCredentialDTOProvider? Type2093 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateMakeCredentialDTO? Type2094 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateMakeCredentialDTOProvider? Type2095 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateMicrosoftCredentialDTO? Type2096 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateMicrosoftCredentialDTOProvider? Type2097 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateMistralCredentialDTO? Type2098 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateMistralCredentialDTOProvider? Type2099 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateNeuphonicCredentialDTO? Type2100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateNeuphonicCredentialDTOProvider? Type2101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateOpenAICredentialDTO? Type2102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateOpenAICredentialDTOProvider? Type2103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateOpenRouterCredentialDTO? Type2104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateOpenRouterCredentialDTOProvider? Type2105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdatePerplexityAICredentialDTO? Type2106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdatePerplexityAICredentialDTOProvider? Type2107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdatePlayHTCredentialDTO? Type2108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdatePlayHTCredentialDTOProvider? Type2109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateRimeAICredentialDTO? Type2110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateRimeAICredentialDTOProvider? Type2111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateRunpodCredentialDTO? Type2112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateRunpodCredentialDTOProvider? Type2113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateWellSaidCredentialDTO? Type2114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateWellSaidCredentialDTOProvider? Type2115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateS3CredentialDTO? Type2116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateS3CredentialDTOProvider? Type2117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateS3CompatibleBucketPlanDTO? Type2118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateS3CompatibleCredentialDTO? Type2119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateS3CompatibleCredentialDTOProvider? Type2120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateTogetherAICredentialDTO? Type2121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateTogetherAICredentialDTOProvider? Type2122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateTwilioCredentialDTO? Type2123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateTwilioCredentialDTOProvider? Type2124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateVonageCredentialDTO? Type2125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateVonageCredentialDTOProvider? Type2126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateWebhookCredentialDTO? Type2127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateWebhookCredentialDTOProvider? Type2128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AuthenticationPlan8? Type2129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateWebhookCredentialDTOAuthenticationPlanDiscriminator? Type2130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateWebhookCredentialDTOAuthenticationPlanDiscriminatorType? Type2131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateCustomCredentialDTO? Type2132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateCustomCredentialDTOProvider? Type2133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AuthenticationPlan9? Type2134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateCustomCredentialDTOAuthenticationPlanDiscriminator? Type2135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateCustomCredentialDTOAuthenticationPlanDiscriminatorType? Type2136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateCustomCredentialDTOEncryptionPlanDiscriminator? Type2137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateCustomCredentialDTOEncryptionPlanDiscriminatorType? Type2138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateXAiCredentialDTO? Type2139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateXAiCredentialDTOProvider? Type2140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateGoogleCalendarOAuth2ClientCredentialDTO? Type2141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateGoogleCalendarOAuth2ClientCredentialDTOProvider? Type2142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateGoogleCalendarOAuth2AuthorizationCredentialDTO? Type2143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateGoogleCalendarOAuth2AuthorizationCredentialDTOProvider? Type2144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateGoogleSheetsOAuth2AuthorizationCredentialDTO? Type2145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateGoogleSheetsOAuth2AuthorizationCredentialDTOProvider? Type2146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateSlackOAuth2AuthorizationCredentialDTO? Type2147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateSlackOAuth2AuthorizationCredentialDTOProvider? Type2148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateGoHighLevelMCPCredentialDTO? Type2149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateGoHighLevelMCPCredentialDTOProvider? Type2150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateInworldCredentialDTO? Type2151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateInworldCredentialDTOProvider? Type2152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateEmailCredentialDTO? Type2153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateEmailCredentialDTOProvider? Type2154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateSlackWebhookCredentialDTO? Type2155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateSlackWebhookCredentialDTOProvider? Type2156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateSonioxCredentialDTO? Type2157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateSonioxCredentialDTOProvider? Type2158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CredentialSessionResponse? Type2159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CredentialEndUser? Type2160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CredentialSessionError? Type2161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CredentialWebhookDTO? Type2162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CredentialWebhookDTOType? Type2163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CredentialWebhookDTOOperation? Type2164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CredentialWebhookDTOAuthMode? Type2165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CredentialActionRequest? Type2166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.HMACAuthenticationPlanType? Type2167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.HMACAuthenticationPlanAlgorithm? Type2168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.HMACAuthenticationPlanSignatureEncoding? Type2169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.BearerAuthenticationPlanType? Type2170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AWSIAMCredentialsAuthenticationPlanType? Type2171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AWSStsAuthenticationPlanType? Type2172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ToolTemplateSetup? Type2173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.MakeToolProviderDetails? Type2174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.ToolTemplateSetup>? Type2175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.MakeToolProviderDetailsType? Type2176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GhlToolProviderDetails? Type2177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GhlToolProviderDetailsType? Type2178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FunctionToolProviderDetails? Type2179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FunctionToolProviderDetailsType? Type2180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GoogleCalendarCreateEventToolProviderDetails? Type2181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GoogleCalendarCreateEventToolProviderDetailsType? Type2182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GoogleSheetsRowAppendToolProviderDetails? Type2183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GoogleSheetsRowAppendToolProviderDetailsType? Type2184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GoHighLevelCalendarAvailabilityToolProviderDetails? Type2185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GoHighLevelCalendarAvailabilityToolProviderDetailsType? Type2186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GoHighLevelCalendarEventCreateToolProviderDetails? Type2187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GoHighLevelCalendarEventCreateToolProviderDetailsType? Type2188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GoHighLevelContactCreateToolProviderDetails? Type2189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GoHighLevelContactCreateToolProviderDetailsType? Type2190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GoHighLevelContactGetToolProviderDetails? Type2191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GoHighLevelContactGetToolProviderDetailsType? Type2192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ToolTemplateMetadata? Type2193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateToolTemplateDTO? Type2194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateToolTemplateDTOVisibility? Type2195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateToolTemplateDTOType? Type2196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateToolTemplateDTOProvider? Type2197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.Template? Type2198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TemplateVisibility? Type2199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TemplateType? Type2200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TemplateProvider? Type2201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateToolTemplateDTO? Type2202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateToolTemplateDTOVisibility? Type2203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateToolTemplateDTOType? Type2204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateToolTemplateDTOProvider? Type2205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.VoiceLibrary? Type2206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.VoiceLibraryGender? Type2207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SyncVoiceLibraryDTO? Type2208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.SyncVoiceLibraryDTOProvider>? Type2209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SyncVoiceLibraryDTOProvider? Type2210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateSesameVoiceDTO? Type2211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateVoiceLibraryMetadataDTO? Type2212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CartesiaPronunciationDictItem? Type2213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CartesiaPronunciationDictionary? Type2214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.CartesiaPronunciationDictItem>? Type2215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ElevenLabsPronunciationDictionary? Type2216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ElevenLabsPronunciationDictionaryPermissionOnResource? Type2217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ProviderResource? Type2218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ProviderResourceProvider? Type2219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ProviderResourceResourceName? Type2220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ProviderResourcePaginatedResponse? Type2221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.ProviderResource>? Type2222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.VoiceLibraryVoiceResponse? Type2223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OneOf<string, double?>? Type2224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AddVoiceToProviderDTO? Type2225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CloneVoiceDTO? Type2226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<byte[]>? Type2227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.VapiVoiceCloneDTO? Type2228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.VariableValueGroupBy? Type2229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TimeRange? Type2230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TimeRangeStep? Type2231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AnalyticsOperation? Type2232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AnalyticsOperationOperation? Type2233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AnalyticsOperationColumn? Type2234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AnalyticsQuery? Type2235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AnalyticsQueryTable? Type2236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.AnalyticsQueryGroupByItem>? Type2237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AnalyticsQueryGroupByItem? Type2238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.VariableValueGroupBy>? Type2239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.AnalyticsOperation>? Type2240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AnalyticsQueryDTO? Type2241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.AnalyticsQuery>? Type2242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AnalyticsQueryResult? Type2243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ClientMessageWorkflowNodeStarted? Type2244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ClientMessageWorkflowNodeStartedType? Type2245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ClientMessageAssistantStarted? Type2246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ClientMessageAssistantStartedType? Type2247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ClientMessageConversationUpdate? Type2248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ClientMessageConversationUpdateType? Type2249 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ClientMessageHang? Type2250 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ClientMessageHangType? Type2251 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ClientMessageMetadata? Type2252 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ClientMessageMetadataType? Type2253 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ClientMessageModelOutput? Type2254 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ClientMessageModelOutputType? Type2255 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ClientMessageSpeechUpdate? Type2256 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ClientMessageSpeechUpdateType? Type2257 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ClientMessageSpeechUpdateStatus? Type2258 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ClientMessageSpeechUpdateRole? Type2259 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ClientMessageTranscript? Type2260 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ClientMessageTranscriptType? Type2261 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ClientMessageTranscriptRole? Type2262 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ClientMessageTranscriptTranscriptType? Type2263 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ClientMessageToolCalls? Type2264 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ClientMessageToolCallsType? Type2265 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FunctionToolWithToolCall? Type2266 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GhlToolWithToolCall? Type2267 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.MakeToolWithToolCall? Type2268 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.BashToolWithToolCall? Type2269 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ComputerToolWithToolCall? Type2270 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TextEditorToolWithToolCall? Type2271 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GoogleCalendarCreateEventToolWithToolCall? Type2272 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ClientMessageToolCallsResult? Type2273 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ClientMessageToolCallsResultType? Type2274 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ClientMessageTransferUpdate? Type2275 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ClientMessageTransferUpdateType? Type2276 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ClientMessageUserInterrupted? Type2277 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ClientMessageUserInterruptedType? Type2278 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ClientMessageLanguageChangeDetected? Type2279 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ClientMessageLanguageChangeDetectedType? Type2280 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ClientMessageVoiceInput? Type2281 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ClientMessageVoiceInputType? Type2282 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ClientMessageAssistantSpeech? Type2283 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ClientMessageAssistantSpeechType? Type2284 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ClientMessageAssistantSpeechSource? Type2285 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.Timing? Type2286 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ClientMessageAssistantSpeechTimingDiscriminator? Type2287 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ClientMessageAssistantSpeechTimingDiscriminatorType? Type2288 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ClientMessageChatCreated? Type2289 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ClientMessageChatCreatedType? Type2290 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ClientMessageChatDeleted? Type2291 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ClientMessageChatDeletedType? Type2292 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ClientMessageSessionCreated? Type2293 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ClientMessageSessionCreatedType? Type2294 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ClientMessageSessionUpdated? Type2295 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ClientMessageSessionUpdatedType? Type2296 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ClientMessageSessionDeleted? Type2297 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ClientMessageSessionDeletedType? Type2298 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ClientMessageCallDeleted? Type2299 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ClientMessageCallDeletedType? Type2300 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ClientMessageCallDeleteFailed? Type2301 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ClientMessageCallDeleteFailedType? Type2302 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ClientMessage? Type2303 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ServerMessageAssistantRequest? Type2304 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ServerMessageAssistantRequestType? Type2305 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ServerMessageConversationUpdate? Type2306 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ServerMessageConversationUpdateType? Type2307 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ServerMessageEndOfCallReport? Type2308 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ServerMessageEndOfCallReportType? Type2309 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ServerMessageEndOfCallReportEndedReason? Type2310 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ServerMessageHandoffDestinationRequest? Type2311 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ServerMessageHandoffDestinationRequestType? Type2312 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ServerMessageHang? Type2313 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ServerMessageHangType? Type2314 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ServerMessageKnowledgeBaseRequest? Type2315 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ServerMessageKnowledgeBaseRequestType? Type2316 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ServerMessageModelOutput? Type2317 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ServerMessageModelOutputType? Type2318 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ServerMessagePhoneCallControl? Type2319 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ServerMessagePhoneCallControlType? Type2320 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ServerMessagePhoneCallControlRequest? Type2321 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ServerMessageSpeechUpdate? Type2322 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ServerMessageSpeechUpdateType? Type2323 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ServerMessageSpeechUpdateStatus? Type2324 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ServerMessageSpeechUpdateRole? Type2325 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ServerMessageStatusUpdate? Type2326 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ServerMessageStatusUpdateType? Type2327 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ServerMessageStatusUpdateStatus? Type2328 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ServerMessageStatusUpdateEndedReason? Type2329 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ServerMessageToolCalls? Type2330 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ServerMessageToolCallsType? Type2331 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ServerMessageTransferDestinationRequest? Type2332 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ServerMessageTransferDestinationRequestType? Type2333 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ServerMessageTransferUpdate? Type2334 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ServerMessageTransferUpdateType? Type2335 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ServerMessageTranscript? Type2336 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ServerMessageTranscriptType? Type2337 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ServerMessageTranscriptRole? Type2338 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ServerMessageTranscriptTranscriptType? Type2339 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ServerMessageUserInterrupted? Type2340 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ServerMessageUserInterruptedType? Type2341 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ServerMessageLanguageChangeDetected? Type2342 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ServerMessageLanguageChangeDetectedType? Type2343 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ServerMessageVoiceInput? Type2344 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ServerMessageVoiceInputType? Type2345 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ServerMessageAssistantSpeech? Type2346 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ServerMessageAssistantSpeechType? Type2347 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ServerMessageAssistantSpeechSource? Type2348 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.Timing2? Type2349 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ServerMessageAssistantSpeechTimingDiscriminator? Type2350 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ServerMessageAssistantSpeechTimingDiscriminatorType? Type2351 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ServerMessageVoiceRequest? Type2352 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ServerMessageVoiceRequestType? Type2353 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ServerMessageCallEndpointingRequest? Type2354 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ServerMessageCallEndpointingRequestType? Type2355 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ServerMessageChatCreated? Type2356 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ServerMessageChatCreatedType? Type2357 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ServerMessageChatDeleted? Type2358 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ServerMessageChatDeletedType? Type2359 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ServerMessageSessionCreated? Type2360 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ServerMessageSessionCreatedType? Type2361 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ServerMessageSessionUpdated? Type2362 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ServerMessageSessionUpdatedType? Type2363 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ServerMessageSessionDeleted? Type2364 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ServerMessageSessionDeletedType? Type2365 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ServerMessageCallDeleted? Type2366 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ServerMessageCallDeletedType? Type2367 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ServerMessageCallDeleteFailed? Type2368 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ServerMessageCallDeleteFailedType? Type2369 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CallArtifactUploadItem? Type2370 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CallArtifactUploadItemType? Type2371 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ServerMessageCallArtifactUpload? Type2372 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ServerMessageCallArtifactUploadType? Type2373 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.CallArtifactUploadItem>? Type2374 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CampaignContact? Type2375 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ServerMessageCampaignPredial? Type2376 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ServerMessageCampaignPredialType? Type2377 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ServerMessage? Type2378 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ServerMessageResponseAssistantRequest? Type2379 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ServerMessageResponseHandoffDestinationRequest? Type2380 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.KnowledgeBaseResponseDocument? Type2381 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ServerMessageResponseKnowledgeBaseRequest? Type2382 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.KnowledgeBaseResponseDocument>? Type2383 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ToolCallResult? Type2384 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OneOf<global::Vapi.ToolMessageComplete, global::Vapi.ToolMessageFailed>? Type2385 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ServerMessageResponseToolCalls? Type2386 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.ToolCallResult>? Type2387 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ServerMessageResponseTransferDestinationRequest? Type2388 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ServerMessageResponseVoiceRequest? Type2389 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ServerMessageResponseCallEndpointingRequest? Type2390 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ServerMessageResponseCampaignPredial? Type2391 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ServerMessageResponse? Type2392 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ClientInboundMessageAddMessage? Type2393 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ClientInboundMessageAddMessageType? Type2394 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ClientInboundMessageControl? Type2395 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ClientInboundMessageControlType? Type2396 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ClientInboundMessageControlControl? Type2397 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ClientInboundMessageSay? Type2398 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ClientInboundMessageSayType? Type2399 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ClientInboundMessageEndCall? Type2400 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ClientInboundMessageEndCallType? Type2401 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ClientInboundMessageTransfer? Type2402 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ClientInboundMessageTransferType? Type2403 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ClientInboundMessageSendTransportMessage? Type2404 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ClientInboundMessageSendTransportMessageType? Type2405 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OneOf<global::Vapi.VapiSipTransportMessage, global::Vapi.TwilioTransportMessage>? Type2406 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.VapiSipTransportMessage? Type2407 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TwilioTransportMessage? Type2408 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ClientInboundMessage? Type2409 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.KnowledgeBaseCostType? Type2410 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SessionCostType? Type2411 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FunctionToolWithToolCallType? Type2412 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GhlToolWithToolCallType? Type2413 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.MakeToolWithToolCallType? Type2414 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.BashToolWithToolCallType? Type2415 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.BashToolWithToolCallSubType? Type2416 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.BashToolWithToolCallName? Type2417 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ComputerToolWithToolCallType? Type2418 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ComputerToolWithToolCallSubType? Type2419 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ComputerToolWithToolCallName? Type2420 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TextEditorToolWithToolCallType? Type2421 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TextEditorToolWithToolCallSubType? Type2422 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TextEditorToolWithToolCallName? Type2423 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GoogleCalendarCreateEventToolWithToolCallType? Type2424 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GoogleSheetsRowAppendToolWithToolCall? Type2425 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GoogleSheetsRowAppendToolWithToolCallType? Type2426 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GoHighLevelCalendarAvailabilityToolWithToolCall? Type2427 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GoHighLevelCalendarAvailabilityToolWithToolCallType? Type2428 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GoHighLevelCalendarEventCreateToolWithToolCall? Type2429 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GoHighLevelCalendarEventCreateToolWithToolCallType? Type2430 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GoHighLevelContactCreateToolWithToolCall? Type2431 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GoHighLevelContactCreateToolWithToolCallType? Type2432 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GoHighLevelContactGetToolWithToolCall? Type2433 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GoHighLevelContactGetToolWithToolCallType? Type2434 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.VapiSipTransportMessageTransport? Type2435 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.VapiSipTransportMessageSipVerb? Type2436 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TwilioTransportMessageTransport? Type2437 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.PhoneNumberControllerCreateRequest? Type2438 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.PhoneNumberControllerCreateRequestDiscriminator? Type2439 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.PhoneNumberControllerCreateRequestDiscriminatorProvider? Type2440 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.PhoneNumberControllerUpdateRequest? Type2441 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.PhoneNumberControllerUpdateRequestDiscriminator? Type2442 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.PhoneNumberControllerUpdateRequestDiscriminatorProvider? Type2443 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ToolControllerCreateRequest? Type2444 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ToolControllerCreateRequestDiscriminator? Type2445 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ToolControllerCreateRequestDiscriminatorType? Type2446 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ToolControllerUpdateRequest? Type2447 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ToolControllerUpdateRequestDiscriminator? Type2448 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ToolControllerUpdateRequestDiscriminatorType? Type2449 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.InsightControllerCreateRequest? Type2450 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.InsightControllerCreateRequestDiscriminator? Type2451 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.InsightControllerCreateRequestDiscriminatorType? Type2452 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.InsightControllerUpdateRequest? Type2453 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.InsightControllerUpdateRequestDiscriminator? Type2454 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.InsightControllerUpdateRequestDiscriminatorType? Type2455 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.InsightControllerPreviewRequest? Type2456 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.InsightControllerPreviewRequestDiscriminator? Type2457 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.InsightControllerPreviewRequestDiscriminatorType? Type2458 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ChatControllerListChatsSortOrder? Type2459 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ChatControllerListChatsSortBy? Type2460 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CampaignControllerFindAllStatus? Type2461 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CampaignControllerFindAllSortOrder? Type2462 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CampaignControllerFindAllSortBy? Type2463 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CampaignControllerFindAllV2Status? Type2464 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CampaignControllerFindAllV2SortOrder? Type2465 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CampaignControllerFindAllV2SortBy? Type2466 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.CampaignControllerGetCampaignV2ContactsStatu>? Type2467 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CampaignControllerGetCampaignV2ContactsStatu? Type2468 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CampaignControllerGetCampaignV2ContactsSortBy? Type2469 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SessionControllerFindAllPaginatedSortOrder? Type2470 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SessionControllerFindAllPaginatedSortBy? Type2471 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.PhoneNumberControllerFindAllPaginatedSortOrder? Type2472 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.PhoneNumberControllerFindAllPaginatedSortBy? Type2473 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.StructuredOutputControllerFindAllSortOrder? Type2474 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.StructuredOutputControllerFindAllSortBy? Type2475 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.PersonalityControllerFindAllSortOrder? Type2476 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.PersonalityControllerFindAllSortBy? Type2477 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ScenarioControllerFindAllSortOrder? Type2478 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ScenarioControllerFindAllSortBy? Type2479 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SimulationRunControllerFindAllStatus? Type2480 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SimulationRunControllerFindAllFilterStatus? Type2481 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SimulationRunControllerFindAllTargetType? Type2482 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SimulationRunControllerFindAllSortOrder? Type2483 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SimulationRunControllerFindAllSortBy? Type2484 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SimulationRunControllerFindItemsStatus? Type2485 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SimulationRunControllerFindItemsSortOrder? Type2486 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SimulationRunControllerFindItemsSortBy? Type2487 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SimulationSuiteControllerFindAllSortOrder? Type2488 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SimulationSuiteControllerFindAllSortBy? Type2489 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SimulationControllerFindAllSortOrder? Type2490 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SimulationControllerFindAllSortBy? Type2491 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.InsightControllerFindAllSortOrder? Type2492 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.InsightControllerFindAllSortBy? Type2493 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.BoardControllerFindAllSortOrder? Type2494 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.BoardControllerFindAllSortBy? Type2495 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.EvalControllerGetPaginatedSortOrder? Type2496 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.EvalControllerGetPaginatedSortBy? Type2497 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.EvalControllerGetRunsPaginatedSortOrder? Type2498 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.EvalControllerGetRunsPaginatedSortBy? Type2499 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ScorecardControllerGetPaginatedSortOrder? Type2500 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ScorecardControllerGetPaginatedSortBy? Type2501 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ProviderResourceControllerCreateProviderResourceProvider? Type2502 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ProviderResourceControllerCreateProviderResourceResourceName? Type2503 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ProviderResourceControllerGetProviderResourcesPaginatedProvider? Type2504 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ProviderResourceControllerGetProviderResourcesPaginatedResourceName? Type2505 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ProviderResourceControllerGetProviderResourcesPaginatedSortOrder? Type2506 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ProviderResourceControllerGetProviderResourcesPaginatedSortBy? Type2507 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ProviderResourceControllerGetProviderResourceProvider? Type2508 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ProviderResourceControllerGetProviderResourceResourceName? Type2509 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ProviderResourceControllerDeleteProviderResourceProvider? Type2510 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ProviderResourceControllerDeleteProviderResourceResourceName? Type2511 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ProviderResourceControllerUpdateProviderResourceProvider? Type2512 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ProviderResourceControllerUpdateProviderResourceResourceName? Type2513 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.Squad>? Type2514 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OneOf<global::Vapi.Call, global::Vapi.CallBatchResponse>? Type2515 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OneOf<global::Vapi.Chat, global::Vapi.CreateChatStreamResponse>? Type2516 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OneOf<global::Vapi.ResponseObject, global::Vapi.ResponseTextDeltaEvent, global::Vapi.ResponseTextDoneEvent, global::Vapi.ResponseCompletedEvent, global::Vapi.ResponseErrorEvent>? Type2517 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.PhoneNumberControllerCreateResponse? Type2518 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.PhoneNumberControllerCreateResponseDiscriminator? Type2519 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.PhoneNumberControllerCreateResponseDiscriminatorProvider? Type2520 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.PhoneNumberControllerFindAllResponseItem>? Type2521 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.PhoneNumberControllerFindAllResponseItem? Type2522 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.PhoneNumberControllerFindAllResponseItemDiscriminator? Type2523 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.PhoneNumberControllerFindAllResponseItemDiscriminatorProvider? Type2524 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.PhoneNumberControllerFindOneResponse? Type2525 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.PhoneNumberControllerFindOneResponseDiscriminator? Type2526 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.PhoneNumberControllerFindOneResponseDiscriminatorProvider? Type2527 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.PhoneNumberControllerUpdateResponse? Type2528 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.PhoneNumberControllerUpdateResponseDiscriminator? Type2529 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.PhoneNumberControllerUpdateResponseDiscriminatorProvider? Type2530 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.PhoneNumberControllerRemoveResponse? Type2531 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.PhoneNumberControllerRemoveResponseDiscriminator? Type2532 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.PhoneNumberControllerRemoveResponseDiscriminatorProvider? Type2533 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ToolControllerCreateResponse? Type2534 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ToolControllerCreateResponseDiscriminator? Type2535 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ToolControllerCreateResponseDiscriminatorType? Type2536 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.ToolControllerFindAllResponseItem>? Type2537 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ToolControllerFindAllResponseItem? Type2538 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ToolControllerFindAllResponseItemDiscriminator? Type2539 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ToolControllerFindAllResponseItemDiscriminatorType? Type2540 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ToolControllerFindOneResponse? Type2541 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ToolControllerFindOneResponseDiscriminator? Type2542 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ToolControllerFindOneResponseDiscriminatorType? Type2543 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ToolControllerUpdateResponse? Type2544 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ToolControllerUpdateResponseDiscriminator? Type2545 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ToolControllerUpdateResponseDiscriminatorType? Type2546 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ToolControllerRemoveResponse? Type2547 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ToolControllerRemoveResponseDiscriminator? Type2548 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ToolControllerRemoveResponseDiscriminatorType? Type2549 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.File>? Type2550 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.KnowledgeBaseV2>? Type2551 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OneOf<global::Vapi.AllOf<global::Vapi.StructuredOutputRunPreviewResponse, object>?, global::Vapi.StructuredOutputRerunResponse>? Type2552 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AllOf<global::Vapi.StructuredOutputRunPreviewResponse, object>? Type2553 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.Personality>? Type2554 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.Scenario>? Type2555 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OneOf<global::System.Collections.Generic.IList<global::Vapi.SimulationRun>, global::Vapi.SimulationRunsPaginatedResponse>? Type2556 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.SimulationRun>? Type2557 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.SimulationRunItem>? Type2558 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.SimulationSuite>? Type2559 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.Simulation>? Type2560 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.InsightControllerCreateResponse? Type2561 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.InsightControllerCreateResponseDiscriminator? Type2562 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.InsightControllerCreateResponseDiscriminatorType? Type2563 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.InsightControllerUpdateResponse? Type2564 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.InsightControllerUpdateResponseDiscriminator? Type2565 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.InsightControllerUpdateResponseDiscriminatorType? Type2566 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.InsightControllerFindOneResponse? Type2567 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.InsightControllerFindOneResponseDiscriminator? Type2568 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.InsightControllerFindOneResponseDiscriminatorType? Type2569 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.InsightControllerRemoveResponse? Type2570 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.InsightControllerRemoveResponseDiscriminator? Type2571 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.InsightControllerRemoveResponseDiscriminatorType? Type2572 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.AnalyticsQueryResult>? Type2573 { get; set; }

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
        public global::System.Collections.Generic.List<global::Vapi.AnthropicBedrockModelFallbackModel>? ListType30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.OpenAIModelFallbackModel>? ListType31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.TwilioVoicemailDetectionPlanVoicemailDetectionType>? ListType32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OneOf<string, global::System.Collections.Generic.List<string>>? ListType33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OneOf<string, global::System.Collections.Generic.List<global::Vapi.OneOf<global::Vapi.SystemMessage, global::Vapi.UserMessage, global::Vapi.AssistantMessage, global::Vapi.ToolMessage, global::Vapi.DeveloperMessage>>>? ListType34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.OneOf<global::Vapi.SystemMessage, global::Vapi.UserMessage, global::Vapi.AssistantMessage, global::Vapi.ToolMessage, global::Vapi.DeveloperMessage>>? ListType35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.OneOf<global::Vapi.ToolCallHookAction, global::Vapi.MessageAddHookAction>>? ListType36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.CallHookFilter>? ListType37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.OneOf<global::Vapi.SayHookAction, global::Vapi.ToolCallHookAction, global::Vapi.MessageAddHookAction>>? ListType38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.SecurityFilterBase>? ListType39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.StructuredDataMultiPlan>? ListType40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.OneOf<global::Vapi.MinMessagesCondition, global::Vapi.MinCallDurationCondition, global::Vapi.EndedReasonCondition>>? ListType41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.OneOf<global::Vapi.NumberComparatorScorecardMetricCondition, global::Vapi.BooleanComparatorScorecardMetricCondition>>? ListType42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.ScorecardMetric>? ListType43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.CreateStructuredOutputDTO>? ListType44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.CreateScorecardDTO>? ListType45 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.OneOf<global::Vapi.ConversationNode, global::Vapi.ToolNode>>? ListType46 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.CredentialsItem>? ListType47 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.Edge>? ListType48 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.OneOf<global::Vapi.ExactReplacement, global::Vapi.RegexReplacement>>? ListType49 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.FormatPlanFormattersEnabledItem>? ListType50 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.ChunkPlanPunctuationBoundarie>? ListType51 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.ElevenLabsPronunciationDictionaryLocator>? ListType52 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.VapiPronunciationDictionaryLocator>? ListType53 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.CreateAzureOpenAICredentialDTOModel>? ListType54 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.SipTrunkGateway>? ListType55 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.ToolCallHookAction>? ListType56 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.AssistantOverridesClientMessage>? ListType57 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.AssistantOverridesServerMessage>? ListType58 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.TransportConfigurationTwilio>? ListType59 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.CredentialsItem2>? ListType60 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.CreateAssistantDTOClientMessage>? ListType61 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.CreateAssistantDTOServerMessage>? ListType62 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.CredentialsItem3>? ListType63 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.AssistantClientMessage>? ListType64 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.AssistantServerMessage>? ListType65 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.CredentialsItem4>? ListType66 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.Assistant>? ListType67 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.AssistantDraftClientMessage>? ListType68 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.AssistantDraftServerMessage>? ListType69 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.CredentialsItem5>? ListType70 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.AssistantDraft>? ListType71 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.LegacyAssistantVersion>? ListType72 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.AssistantVersionClientMessage>? ListType73 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.AssistantVersionServerMessage>? ListType74 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.CredentialsItem6>? ListType75 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.AssistantVersion>? ListType76 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.VersionPinReference>? ListType77 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.CreateAssistantDraftDTOClientMessage>? ListType78 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.CreateAssistantDraftDTOServerMessage>? ListType79 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.CredentialsItem7>? ListType80 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.UpdateAssistantDraftDTOClientMessage>? ListType81 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.UpdateAssistantDraftDTOServerMessage>? ListType82 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.CredentialsItem8>? ListType83 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.UpdateAssistantDTOClientMessage>? ListType84 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.UpdateAssistantDTOServerMessage>? ListType85 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.CredentialsItem9>? ListType86 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.CredentialsItem10>? ListType87 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.CredentialsItem11>? ListType88 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.CredentialsItem12>? ListType89 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.ToolCallResultMessageWarning>? ListType90 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.StructuredOutputCostBreakdown>? ListType91 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.MonitorResult>? ListType92 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.OneOf<global::Vapi.UserMessage, global::Vapi.SystemMessage, global::Vapi.BotMessage, global::Vapi.ToolCallMessage, global::Vapi.ToolCallResultMessage>>? ListType93 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.TurnLatency>? ListType94 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.TransferArtifact>? ListType95 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.NodeArtifact>? ListType96 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.AssistantActivation>? ListType97 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.PhoneNumberCallRingingHookFilter>? ListType98 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.OneOf<global::Vapi.TransferPhoneNumberHookAction, global::Vapi.SayPhoneNumberHookAction>>? ListType99 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.PhoneNumberCallEndingHookFilterOneOfItem>? ListType100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.PhoneNumberCallEndingHookFilter>? ListType101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.OneOf<global::Vapi.PhoneNumberHookCallRinging, global::Vapi.PhoneNumberHookCallEnding>>? ListType102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.Call>? ListType103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.CallBatchError>? ListType104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<double>? ListType105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.AssistantSpeechWordTimestamp>? ListType106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.CreateCustomerDTO>? ListType107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.ToolCall>? ListType108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.OneOf<global::Vapi.ModelCost, global::Vapi.ChatCost>>? ListType109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.Chat>? ListType110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.ResponseOutputText>? ListType111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.ResponseOutputMessage>? ListType112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.DialPlanEntry>? ListType113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.CreateCampaignDTOServerMessage>? ListType114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.CampaignServerMessage>? ListType115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.Campaign>? ListType116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.CampaignSummaryServerMessage>? ListType117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.CampaignSummary>? ListType118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.CampaignContactWithOutcome>? ListType119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.OneOf<global::Vapi.RelayCommandSay, global::Vapi.RelayCommandNote>>? ListType120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.OneOf<global::Vapi.ModelCost, global::Vapi.AnalysisCost, global::Vapi.SessionCost>>? ListType121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.Session>? ListType122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.OneOf<global::Vapi.ByoPhoneNumber, global::Vapi.TwilioPhoneNumber, global::Vapi.VonagePhoneNumber, global::Vapi.VapiPhoneNumber, global::Vapi.TelnyxPhoneNumber>>? ListType123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.CodeToolEnvironmentVariable>? ListType124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.ToolVersion>? ListType125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.ToolDraft>? ListType126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.KnowledgeBaseV2File>? ListType127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.StructuredOutput>? ListType128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.TestSuite>? ListType129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.TestSuiteTestScorerAI>? ListType130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.OneOf<global::Vapi.TestSuiteTestVoice, global::Vapi.TestSuiteTestChat>>? ListType131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.TestSuiteRunScorerAI>? ListType132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.TestSuiteRunTestAttempt>? ListType133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.TestSuiteRunTestResult>? ListType134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.TestSuiteRun>? ListType135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.SimulationHookWebhookAction>? ListType136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.EvaluationPlanItem>? ListType137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.OneOf<global::Vapi.SimulationHookCallStarted, global::Vapi.SimulationHookCallEnded>>? ListType138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.ScenarioToolMock>? ListType139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.OneOf<global::Vapi.SimulationRunSimulationEntry, global::Vapi.SimulationRunSuiteEntry>>? ListType140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.SimulationRunListItem>? ListType141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.StructuredOutputEvaluationResult>? ListType142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.SimulationRunItemImprovementSuggestion>? ListType143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.SimulationSuiteTargetAssignment>? ListType144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.GeneratedScenario>? ListType145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.InsightFormula>? ListType146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.OneOf<global::Vapi.EventsTableStringCondition, global::Vapi.EventsTableNumberCondition, global::Vapi.EventsTableBooleanCondition>>? ListType147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.Insight>? ListType148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.OneOf<global::Vapi.BoardInsightItem, global::Vapi.BoardMetricWidgetItem>>? ListType149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.Board>? ListType150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.ChatEvalAssistantMessageMockToolCall>? ListType151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.Eval>? ListType152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.EvalRunResult>? ListType153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.EvalRun>? ListType154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.Scorecard>? ListType155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.PendingInvitationDTO>? ListType156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.AzureOpenAICredentialModel>? ListType157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.UpdateAzureOpenAICredentialDTOModel>? ListType158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.ToolTemplateSetup>? ListType159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.SyncVoiceLibraryDTOProvider>? ListType160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.CartesiaPronunciationDictItem>? ListType161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.ProviderResource>? ListType162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<byte[]>? ListType163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.AnalyticsQueryGroupByItem>? ListType164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.VariableValueGroupBy>? ListType165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.AnalyticsOperation>? ListType166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.AnalyticsQuery>? ListType167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.CallArtifactUploadItem>? ListType168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.KnowledgeBaseResponseDocument>? ListType169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.ToolCallResult>? ListType170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.CampaignControllerGetCampaignV2ContactsStatu>? ListType171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.Squad>? ListType172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.PhoneNumberControllerFindAllResponseItem>? ListType173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.ToolControllerFindAllResponseItem>? ListType174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.File>? ListType175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.KnowledgeBaseV2>? ListType176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.Personality>? ListType177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.Scenario>? ListType178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OneOf<global::System.Collections.Generic.List<global::Vapi.SimulationRun>, global::Vapi.SimulationRunsPaginatedResponse>? ListType179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.SimulationRun>? ListType180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.SimulationRunItem>? ListType181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.SimulationSuite>? ListType182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.Simulation>? ListType183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.AnalyticsQueryResult>? ListType184 { get; set; }
    }
}