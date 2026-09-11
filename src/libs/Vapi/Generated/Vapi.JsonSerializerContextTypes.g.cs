
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
        public global::Vapi.OpenAISpeaker? Type400 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.OpenAISpeakerPersonalityPack>? Type401 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OpenAISpeakerPersonalityPack? Type402 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OpenAIReasoner? Type403 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OpenAIReasonerProvider? Type404 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OpenAIReasonerModel? Type405 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OpenAIReasonerReasoningEffort? Type406 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OpenAIModel? Type407 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OpenAIModelProvider? Type408 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OpenAIModelModel? Type409 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.OpenAIModelFallbackModel>? Type410 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OpenAIModelFallbackModel? Type411 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OpenAIModelToolStrictCompatibilityMode? Type412 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OpenAIModelPromptCacheRetention? Type413 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OpenAIModelReasoningEffort? Type414 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OpenRouterModel? Type415 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OpenRouterModelProvider? Type416 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.PerplexityAIModel? Type417 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.PerplexityAIModelProvider? Type418 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TogetherAIModel? Type419 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TogetherAIModelProvider? Type420 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.HangupNode? Type421 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.HangupNodeType? Type422 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.WorkflowOpenAIModel? Type423 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.WorkflowOpenAIModelProvider? Type424 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.WorkflowOpenAIModelModel? Type425 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.WorkflowAnthropicModel? Type426 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.WorkflowAnthropicModelProvider? Type427 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.WorkflowAnthropicModelModel? Type428 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.WorkflowAnthropicBedrockModel? Type429 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.WorkflowAnthropicBedrockModelProvider? Type430 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.WorkflowAnthropicBedrockModelModel? Type431 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.WorkflowGoogleModel? Type432 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.WorkflowGoogleModelProvider? Type433 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.WorkflowGoogleModelModel? Type434 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.WorkflowCustomModel? Type435 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.WorkflowCustomModelProvider? Type436 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.WorkflowCustomModelMetadataSendMode? Type437 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GlobalNodePlan? Type438 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ConversationNode? Type439 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ConversationNodeType? Type440 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ToolNode? Type441 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ToolNodeType? Type442 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.VoicemailDetectionBackoffPlan? Type443 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GoogleVoicemailDetectionPlan? Type444 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GoogleVoicemailDetectionPlanProvider? Type445 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GoogleVoicemailDetectionPlanType? Type446 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OpenAIVoicemailDetectionPlan? Type447 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OpenAIVoicemailDetectionPlanProvider? Type448 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OpenAIVoicemailDetectionPlanType? Type449 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TwilioVoicemailDetectionPlan? Type450 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TwilioVoicemailDetectionPlanProvider? Type451 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.TwilioVoicemailDetectionPlanVoicemailDetectionType>? Type452 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TwilioVoicemailDetectionPlanVoicemailDetectionType? Type453 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.VapiVoicemailDetectionPlan? Type454 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.VapiVoicemailDetectionPlanProvider? Type455 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.VapiVoicemailDetectionPlanType? Type456 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TransferHookAction? Type457 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TransferHookActionType? Type458 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OneOf<global::Vapi.TransferDestinationNumber, global::Vapi.TransferDestinationSip>? Type459 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FunctionCallHookAction? Type460 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FunctionCallHookActionType? Type461 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SayHookAction? Type462 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SayHookActionType? Type463 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OneOf<string, global::System.Collections.Generic.IList<string>>? Type464 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OneOf<string, global::System.Collections.Generic.IList<global::Vapi.OneOf<global::Vapi.SystemMessage, global::Vapi.UserMessage, global::Vapi.AssistantMessage, global::Vapi.ToolMessage, global::Vapi.DeveloperMessage>>>? Type465 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.OneOf<global::Vapi.SystemMessage, global::Vapi.UserMessage, global::Vapi.AssistantMessage, global::Vapi.ToolMessage, global::Vapi.DeveloperMessage>>? Type466 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OneOf<global::Vapi.SystemMessage, global::Vapi.UserMessage, global::Vapi.AssistantMessage, global::Vapi.ToolMessage, global::Vapi.DeveloperMessage>? Type467 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SystemMessage? Type468 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UserMessage? Type469 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AssistantMessage? Type470 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ToolMessage? Type471 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.DeveloperMessage? Type472 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.MessageAddHookAction? Type473 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.MessageAddHookActionType? Type474 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CallHookFilter? Type475 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CallHookFilterType? Type476 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CallHookCallEnding? Type477 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CallHookCallEndingOn? Type478 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.OneOf<global::Vapi.ToolCallHookAction, global::Vapi.MessageAddHookAction>>? Type479 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OneOf<global::Vapi.ToolCallHookAction, global::Vapi.MessageAddHookAction>? Type480 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ToolCallHookAction? Type481 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.CallHookFilter>? Type482 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CallHookAssistantSpeechInterrupted? Type483 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CallHookAssistantSpeechInterruptedOn? Type484 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.OneOf<global::Vapi.SayHookAction, global::Vapi.ToolCallHookAction, global::Vapi.MessageAddHookAction>>? Type485 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OneOf<global::Vapi.SayHookAction, global::Vapi.ToolCallHookAction, global::Vapi.MessageAddHookAction>? Type486 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CallHookCustomerSpeechInterrupted? Type487 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CallHookCustomerSpeechInterruptedOn? Type488 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ToolCallHookActionType? Type489 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CustomerSpeechTimeoutOptions? Type490 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CustomerSpeechTimeoutOptionsTriggerResetMode? Type491 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CallHookCustomerSpeechTimeout? Type492 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CallHookModelResponseTimeout? Type493 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CallHookModelResponseTimeoutOn? Type494 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AIEdgeCondition? Type495 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AIEdgeConditionType? Type496 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.Edge? Type497 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.RecordingConsentPlanStayOnLine? Type498 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.RecordingConsentPlanStayOnLineFirstMessageMode? Type499 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.RecordingConsentPlanStayOnLineType? Type500 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.RecordingConsentPlanVerbal? Type501 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.RecordingConsentPlanVerbalFirstMessageMode? Type502 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.RecordingConsentPlanVerbalType? Type503 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SecurityFilterBase? Type504 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SecurityFilterPlan? Type505 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.SecurityFilterBase>? Type506 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SecurityFilterPlanMode? Type507 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CompliancePlan? Type508 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.RecordingConsentPlan? Type509 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CompliancePlanRecordingConsentPlanDiscriminator? Type510 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CompliancePlanRecordingConsentPlanDiscriminatorType? Type511 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.StructuredDataPlan? Type512 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.StructuredDataMultiPlan? Type513 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SuccessEvaluationPlan? Type514 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SuccessEvaluationPlanRubric? Type515 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AnalysisPlan? Type516 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.StructuredDataMultiPlan>? Type517 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TranscriptPlan? Type518 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.MinMessagesCondition? Type519 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.MinMessagesConditionType? Type520 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.MinCallDurationCondition? Type521 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.MinCallDurationConditionType? Type522 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.EndedReasonCondition? Type523 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.EndedReasonConditionType? Type524 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.EndedReasonConditionOperator? Type525 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ComplianceOverride? Type526 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateStructuredOutputDTO? Type527 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateStructuredOutputDTOType? Type528 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.OneOf<global::Vapi.MinMessagesCondition, global::Vapi.MinCallDurationCondition, global::Vapi.EndedReasonCondition>>? Type529 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OneOf<global::Vapi.MinMessagesCondition, global::Vapi.MinCallDurationCondition, global::Vapi.EndedReasonCondition>? Type530 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.NumberComparatorScorecardMetricCondition? Type531 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.NumberComparatorScorecardMetricConditionType? Type532 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.NumberComparatorScorecardMetricConditionComparator? Type533 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.BooleanComparatorScorecardMetricCondition? Type534 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.BooleanComparatorScorecardMetricConditionType? Type535 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.BooleanComparatorScorecardMetricConditionComparator? Type536 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ScorecardMetric? Type537 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.OneOf<global::Vapi.NumberComparatorScorecardMetricCondition, global::Vapi.BooleanComparatorScorecardMetricCondition>>? Type538 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OneOf<global::Vapi.NumberComparatorScorecardMetricCondition, global::Vapi.BooleanComparatorScorecardMetricCondition>? Type539 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateScorecardDTO? Type540 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.ScorecardMetric>? Type541 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ArtifactPlan? Type542 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ArtifactPlanRecordingFormat? Type543 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.CreateStructuredOutputDTO>? Type544 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.CreateScorecardDTO>? Type545 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.StopSpeakingPlan? Type546 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.MonitorPlan? Type547 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.KeypadInputPlan? Type548 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.KeypadInputPlanDelimiters? Type549 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.WorkflowUserEditable? Type550 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.OneOf<global::Vapi.ConversationNode, global::Vapi.ToolNode>>? Type551 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OneOf<global::Vapi.ConversationNode, global::Vapi.ToolNode>? Type552 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OneOf<global::Vapi.WorkflowUserEditableBackgroundSound?, string>? Type553 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.WorkflowUserEditableBackgroundSound? Type554 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.CredentialsItem>? Type555 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CredentialsItem? Type556 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateAnthropicCredentialDTO? Type557 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateAnthropicBedrockCredentialDTO? Type558 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateAnyscaleCredentialDTO? Type559 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateAssemblyAICredentialDTO? Type560 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateAzureCredentialDTO? Type561 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateAzureOpenAICredentialDTO? Type562 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateByoSipTrunkCredentialDTO? Type563 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateCartesiaCredentialDTO? Type564 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateCerebrasCredentialDTO? Type565 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateCloudflareCredentialDTO? Type566 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateCustomLLMCredentialDTO? Type567 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateDeepgramCredentialDTO? Type568 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateDeepInfraCredentialDTO? Type569 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateDeepSeekCredentialDTO? Type570 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateElevenLabsCredentialDTO? Type571 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateGcpCredentialDTO? Type572 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateGladiaCredentialDTO? Type573 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateGoHighLevelCredentialDTO? Type574 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateGoogleCredentialDTO? Type575 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateGroqCredentialDTO? Type576 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateHumeCredentialDTO? Type577 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateInflectionAICredentialDTO? Type578 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateLangfuseCredentialDTO? Type579 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateLmntCredentialDTO? Type580 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateMakeCredentialDTO? Type581 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateMistralCredentialDTO? Type582 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateNeuphonicCredentialDTO? Type583 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateOpenAICredentialDTO? Type584 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateOpenRouterCredentialDTO? Type585 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreatePerplexityAICredentialDTO? Type586 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreatePlayHTCredentialDTO? Type587 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateRimeAICredentialDTO? Type588 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateRunpodCredentialDTO? Type589 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateS3CredentialDTO? Type590 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateS3CompatibleCredentialDTO? Type591 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateSmallestAICredentialDTO? Type592 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateSpeechmaticsCredentialDTO? Type593 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateSonioxCredentialDTO? Type594 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateSupabaseCredentialDTO? Type595 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateTavusCredentialDTO? Type596 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateTogetherAICredentialDTO? Type597 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateTwilioCredentialDTO? Type598 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateVonageCredentialDTO? Type599 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateWebhookCredentialDTO? Type600 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateCustomCredentialDTO? Type601 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateXAiCredentialDTO? Type602 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateMicrosoftCredentialDTO? Type603 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateGoogleCalendarOAuth2ClientCredentialDTO? Type604 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateGoogleCalendarOAuth2AuthorizationCredentialDTO? Type605 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateGoogleSheetsOAuth2AuthorizationCredentialDTO? Type606 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateSlackOAuth2AuthorizationCredentialDTO? Type607 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateGoHighLevelMCPCredentialDTO? Type608 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateInworldCredentialDTO? Type609 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateMinimaxCredentialDTO? Type610 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateWellSaidCredentialDTO? Type611 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateEmailCredentialDTO? Type612 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateSlackWebhookCredentialDTO? Type613 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.WorkflowUserEditableCredentialDiscriminator? Type614 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.WorkflowUserEditableCredentialDiscriminatorProvider? Type615 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.WorkflowUserEditableVoicemailDetection? Type616 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.Edge>? Type617 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.VapiModel? Type618 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.VapiModelVersion? Type619 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.VapiModelProvider? Type620 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.XaiModel? Type621 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.XaiModelModel? Type622 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.XaiModelProvider? Type623 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ExactReplacement? Type624 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ExactReplacementType? Type625 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.RegexReplacement? Type626 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.RegexReplacementType? Type627 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FormatPlan? Type628 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.OneOf<global::Vapi.ExactReplacement, global::Vapi.RegexReplacement>>? Type629 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OneOf<global::Vapi.ExactReplacement, global::Vapi.RegexReplacement>? Type630 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.FormatPlanFormattersEnabledItem>? Type631 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FormatPlanFormattersEnabledItem? Type632 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ChunkPlan? Type633 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.ChunkPlanPunctuationBoundarie>? Type634 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ChunkPlanPunctuationBoundarie? Type635 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackPlan? Type636 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackAzureVoice? Type637 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackCartesiaVoice? Type638 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackHumeVoice? Type639 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackCustomVoice? Type640 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackDeepgramVoice? Type641 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackElevenLabsVoice? Type642 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackVapiVoice? Type643 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackLMNTVoice? Type644 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackOpenAIVoice? Type645 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackPlayHTVoice? Type646 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackWellSaidVoice? Type647 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackRimeAIVoice? Type648 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackSmallestAIVoice? Type649 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackTavusVoice? Type650 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackNeuphonicVoice? Type651 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackSesameVoice? Type652 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackInworldVoice? Type653 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackXaiVoice? Type654 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackMicrosoftVoice? Type655 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AzureVoiceProvider? Type656 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OneOf<global::Vapi.AzureVoiceVoiceId?, string>? Type657 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AzureVoiceVoiceId? Type658 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CartesiaExperimentalControls? Type659 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OneOf<global::Vapi.CartesiaExperimentalControlsSpeed?, double?>? Type660 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CartesiaExperimentalControlsSpeed? Type661 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CartesiaExperimentalControlsEmotion? Type662 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CartesiaGenerationConfigExperimental? Type663 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public int? Type664 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CartesiaGenerationConfig? Type665 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CartesiaVoiceProvider? Type666 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CartesiaVoiceModel? Type667 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CartesiaVoiceLanguage? Type668 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CustomVoiceProvider? Type669 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.DeepgramVoiceProvider? Type670 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.DeepgramVoiceVoiceId? Type671 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.DeepgramVoiceModel? Type672 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ElevenLabsPronunciationDictionaryLocator? Type673 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ElevenLabsVoiceProvider? Type674 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OneOf<global::Vapi.ElevenLabsVoiceVoiceId?, string>? Type675 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ElevenLabsVoiceVoiceId? Type676 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ElevenLabsVoiceModel? Type677 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.ElevenLabsPronunciationDictionaryLocator>? Type678 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.WellSaidVoiceProvider? Type679 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.WellSaidVoiceModel? Type680 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.HumeVoiceProvider? Type681 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.HumeVoiceModel? Type682 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.LMNTVoiceProvider? Type683 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OneOf<global::Vapi.LMNTVoiceVoiceId?, string>? Type684 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.LMNTVoiceVoiceId? Type685 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.LMNTVoiceLanguage? Type686 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.NeuphonicVoiceProvider? Type687 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.NeuphonicVoiceModel? Type688 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OpenAIVoiceProvider? Type689 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OneOf<global::Vapi.OpenAIVoiceVoiceId?, string>? Type690 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OpenAIVoiceVoiceId? Type691 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OpenAIVoiceModel? Type692 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.PlayHTVoiceProvider? Type693 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OneOf<global::Vapi.PlayHTVoiceVoiceId?, string>? Type694 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.PlayHTVoiceVoiceId? Type695 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.PlayHTVoiceEmotion? Type696 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.PlayHTVoiceModel? Type697 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.PlayHTVoiceLanguage? Type698 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.RimeAIVoiceProvider? Type699 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OneOf<global::Vapi.RimeAIVoiceVoiceId?, string>? Type700 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.RimeAIVoiceVoiceId? Type701 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.RimeAIVoiceModel? Type702 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.RimeAIVoiceLanguage? Type703 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SesameVoiceProvider? Type704 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SesameVoiceModel? Type705 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SmallestAIVoiceProvider? Type706 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OneOf<global::Vapi.SmallestAIVoiceVoiceId?, string>? Type707 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SmallestAIVoiceVoiceId? Type708 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SmallestAIVoiceModel? Type709 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TavusConversationProperties? Type710 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TavusVoiceProvider? Type711 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OneOf<global::Vapi.TavusVoiceVoiceId?, string>? Type712 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TavusVoiceVoiceId? Type713 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.VapiPronunciationDictionaryLocator? Type714 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.VapiPronunciationDictionaryLocatorProvider? Type715 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.VapiVoiceProvider? Type716 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OneOf<global::Vapi.VapiVoiceVersion2?, double?>? Type717 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.VapiVoiceVersion2? Type718 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.VapiVoiceLanguage? Type719 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.VapiPronunciationDictionaryLocator>? Type720 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.InworldVoiceProvider? Type721 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.InworldVoiceVoiceId? Type722 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.InworldVoiceModel? Type723 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.InworldVoiceLanguageCode? Type724 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.MinimaxVoiceProvider? Type725 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.MinimaxVoiceModel? Type726 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.MinimaxVoiceSubtitleType? Type727 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.MinimaxVoiceRegion? Type728 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.MinimaxVoiceLanguageBoost? Type729 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackMinimaxVoice? Type730 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackMinimaxVoiceProvider? Type731 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackMinimaxVoiceModel? Type732 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackMinimaxVoiceSubtitleType? Type733 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackMinimaxVoiceRegion? Type734 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackMinimaxVoiceLanguageBoost? Type735 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackWellSaidVoiceProvider? Type736 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackWellSaidVoiceModel? Type737 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.XaiVoiceProvider? Type738 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.XaiVoiceVoiceId? Type739 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.XaiVoiceLanguage? Type740 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.MicrosoftVoiceProvider? Type741 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.MicrosoftVoiceVoiceId? Type742 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.MicrosoftVoiceStyle? Type743 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.MicrosoftVoiceRole? Type744 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackAzureVoiceProvider? Type745 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OneOf<global::Vapi.FallbackAzureVoiceVoiceId?, string>? Type746 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackAzureVoiceVoiceId? Type747 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackCartesiaVoiceProvider? Type748 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackCartesiaVoiceModel? Type749 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackCartesiaVoiceLanguage? Type750 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackCustomVoiceProvider? Type751 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackDeepgramVoiceProvider? Type752 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackDeepgramVoiceVoiceId? Type753 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackDeepgramVoiceModel? Type754 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackElevenLabsVoiceProvider? Type755 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OneOf<global::Vapi.FallbackElevenLabsVoiceVoiceId?, string>? Type756 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackElevenLabsVoiceVoiceId? Type757 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackElevenLabsVoiceModel? Type758 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackHumeVoiceProvider? Type759 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackHumeVoiceModel? Type760 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackLMNTVoiceProvider? Type761 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OneOf<global::Vapi.FallbackLMNTVoiceVoiceId?, string>? Type762 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackLMNTVoiceVoiceId? Type763 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackLMNTVoiceLanguage? Type764 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackNeuphonicVoiceProvider? Type765 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackNeuphonicVoiceModel? Type766 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackOpenAIVoiceProvider? Type767 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OneOf<global::Vapi.FallbackOpenAIVoiceVoiceId?, string>? Type768 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackOpenAIVoiceVoiceId? Type769 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackOpenAIVoiceModel? Type770 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackPlayHTVoiceProvider? Type771 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OneOf<global::Vapi.FallbackPlayHTVoiceVoiceId?, string>? Type772 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackPlayHTVoiceVoiceId? Type773 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackPlayHTVoiceEmotion? Type774 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackPlayHTVoiceModel? Type775 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackPlayHTVoiceLanguage? Type776 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackRimeAIVoiceProvider? Type777 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OneOf<global::Vapi.FallbackRimeAIVoiceVoiceId?, string>? Type778 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackRimeAIVoiceVoiceId? Type779 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackRimeAIVoiceModel? Type780 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackRimeAIVoiceLanguage? Type781 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackSesameVoiceProvider? Type782 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackSesameVoiceModel? Type783 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackSmallestAIVoiceProvider? Type784 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OneOf<global::Vapi.FallbackSmallestAIVoiceVoiceId?, string>? Type785 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackSmallestAIVoiceVoiceId? Type786 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackSmallestAIVoiceModel? Type787 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackTavusVoiceProvider? Type788 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OneOf<global::Vapi.FallbackTavusVoiceVoiceId?, string>? Type789 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackTavusVoiceVoiceId? Type790 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackVapiVoiceProvider? Type791 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OneOf<global::Vapi.FallbackVapiVoiceVersion2?, double?>? Type792 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackVapiVoiceVersion2? Type793 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackVapiVoiceLanguage? Type794 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackInworldVoiceProvider? Type795 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackInworldVoiceVoiceId? Type796 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackInworldVoiceModel? Type797 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackInworldVoiceLanguageCode? Type798 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackXaiVoiceProvider? Type799 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackXaiVoiceVoiceId? Type800 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackXaiVoiceLanguage? Type801 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackMicrosoftVoiceProvider? Type802 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackMicrosoftVoiceVoiceId? Type803 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackMicrosoftVoiceStyle? Type804 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FallbackMicrosoftVoiceRole? Type805 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TransportConfigurationTwilio? Type806 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TransportConfigurationTwilioProvider? Type807 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TransportConfigurationTwilioRecordingChannels? Type808 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateAnthropicCredentialDTOProvider? Type809 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateAnthropicBedrockCredentialDTOProvider? Type810 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateAnthropicBedrockCredentialDTORegion? Type811 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OneOf<global::Vapi.AWSIAMCredentialsAuthenticationPlan, global::Vapi.AWSStsAuthenticationPlan>? Type812 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AWSIAMCredentialsAuthenticationPlan? Type813 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AWSStsAuthenticationPlan? Type814 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateAnyscaleCredentialDTOProvider? Type815 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateAssemblyAICredentialDTOProvider? Type816 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AzureBlobStorageBucketPlan? Type817 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateAzureCredentialDTOProvider? Type818 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateAzureCredentialDTOService? Type819 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateAzureCredentialDTORegion? Type820 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateAzureOpenAICredentialDTOProvider? Type821 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateAzureOpenAICredentialDTORegion? Type822 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.CreateAzureOpenAICredentialDTOModel>? Type823 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateAzureOpenAICredentialDTOModel? Type824 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SipTrunkGateway? Type825 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SipTrunkGatewayOutboundProtocol? Type826 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SipTrunkOutboundSipRegisterPlan? Type827 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SipTrunkOutboundAuthenticationPlan? Type828 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateByoSipTrunkCredentialDTOProvider? Type829 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.SipTrunkGateway>? Type830 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateCartesiaCredentialDTOProvider? Type831 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CloudflareR2BucketPlan? Type832 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateCloudflareCredentialDTOProvider? Type833 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OAuth2AuthenticationPlan? Type834 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OAuth2AuthenticationPlanType? Type835 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateCustomLLMCredentialDTOProvider? Type836 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateDeepgramCredentialDTOProvider? Type837 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateDeepInfraCredentialDTOProvider? Type838 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateDeepSeekCredentialDTOProvider? Type839 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateElevenLabsCredentialDTOProvider? Type840 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateElevenLabsCredentialDTOApiUrl? Type841 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GcpKey? Type842 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.BucketPlan? Type843 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateGcpCredentialDTOProvider? Type844 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateGladiaCredentialDTOProvider? Type845 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateGoHighLevelCredentialDTOProvider? Type846 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateGroqCredentialDTOProvider? Type847 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateLangfuseCredentialDTOProvider? Type848 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateLmntCredentialDTOProvider? Type849 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateMakeCredentialDTOProvider? Type850 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateOpenAICredentialDTOProvider? Type851 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateOpenRouterCredentialDTOProvider? Type852 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreatePerplexityAICredentialDTOProvider? Type853 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreatePlayHTCredentialDTOProvider? Type854 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateRimeAICredentialDTOProvider? Type855 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateRunpodCredentialDTOProvider? Type856 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateS3CredentialDTOProvider? Type857 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SupabaseBucketPlan? Type858 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SupabaseBucketPlanRegion? Type859 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateSupabaseCredentialDTOProvider? Type860 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateSmallestAICredentialDTOProvider? Type861 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateTavusCredentialDTOProvider? Type862 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateTogetherAICredentialDTOProvider? Type863 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateTwilioCredentialDTOProvider? Type864 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateVonageCredentialDTOProvider? Type865 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateWebhookCredentialDTOProvider? Type866 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AuthenticationPlan2? Type867 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.HMACAuthenticationPlan? Type868 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.BearerAuthenticationPlan? Type869 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateWebhookCredentialDTOAuthenticationPlanDiscriminator? Type870 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateWebhookCredentialDTOAuthenticationPlanDiscriminatorType? Type871 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateXAiCredentialDTOProvider? Type872 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateGoogleCalendarOAuth2ClientCredentialDTOProvider? Type873 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateGoogleCalendarOAuth2AuthorizationCredentialDTOProvider? Type874 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateGoogleSheetsOAuth2AuthorizationCredentialDTOProvider? Type875 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateSlackOAuth2AuthorizationCredentialDTOProvider? Type876 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateMinimaxCredentialDTOProvider? Type877 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.EndpointedSpeechLowConfidenceOptions? Type878 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CallHookTranscriberEndpointedSpeechLowConfidence? Type879 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SessionCreatedHook? Type880 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SessionCreatedHookOn? Type881 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.ToolCallHookAction>? Type882 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SQLInjectionSecurityFilter? Type883 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SQLInjectionSecurityFilterType? Type884 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.XSSSecurityFilter? Type885 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.XSSSecurityFilterType? Type886 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SSRFSecurityFilter? Type887 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SSRFSecurityFilterType? Type888 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.RCESecurityFilter? Type889 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.RCESecurityFilterType? Type890 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.PromptInjectionSecurityFilter? Type891 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.PromptInjectionSecurityFilterType? Type892 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.RegexSecurityFilter? Type893 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.RegexSecurityFilterType? Type894 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AssistantOverridesFirstMessageMode? Type895 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AssistantOverridesVoicemailDetection? Type896 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.AssistantOverridesClientMessage>? Type897 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AssistantOverridesClientMessage? Type898 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.AssistantOverridesServerMessage>? Type899 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AssistantOverridesServerMessage? Type900 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OneOf<global::Vapi.AssistantOverridesBackgroundSound?, string>? Type901 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AssistantOverridesBackgroundSound? Type902 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.TransportConfigurationTwilio>? Type903 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.CredentialsItem2>? Type904 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CredentialsItem2? Type905 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AssistantOverridesCredentialDiscriminator? Type906 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AssistantOverridesCredentialDiscriminatorProvider? Type907 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateAssistantDTOFirstMessageMode? Type908 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateAssistantDTOVoicemailDetection? Type909 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.CreateAssistantDTOClientMessage>? Type910 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateAssistantDTOClientMessage? Type911 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.CreateAssistantDTOServerMessage>? Type912 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateAssistantDTOServerMessage? Type913 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OneOf<global::Vapi.CreateAssistantDTOBackgroundSound?, string>? Type914 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateAssistantDTOBackgroundSound? Type915 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.CredentialsItem3>? Type916 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CredentialsItem3? Type917 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateAssistantDTOCredentialDiscriminator? Type918 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateAssistantDTOCredentialDiscriminatorProvider? Type919 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.Assistant? Type920 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AssistantFirstMessageMode? Type921 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AssistantVoicemailDetection? Type922 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.AssistantClientMessage>? Type923 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AssistantClientMessage? Type924 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.AssistantServerMessage>? Type925 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AssistantServerMessage? Type926 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OneOf<global::Vapi.AssistantBackgroundSound?, string>? Type927 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AssistantBackgroundSound? Type928 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.CredentialsItem4>? Type929 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CredentialsItem4? Type930 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AssistantCredentialDiscriminator? Type931 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AssistantCredentialDiscriminatorProvider? Type932 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.DateTime? Type933 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ValidateBackgroundSoundUrlDTO? Type934 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.BackgroundSoundUrlValidationResult? Type935 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.BackgroundSoundUrlValidationResultReason? Type936 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.PaginationMeta? Type937 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.PaginationMetaSortOrder? Type938 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AssistantPaginatedResponse? Type939 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.Assistant>? Type940 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AssistantDraft? Type941 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AssistantDraftFirstMessageMode? Type942 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AssistantDraftVoicemailDetection? Type943 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.AssistantDraftClientMessage>? Type944 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AssistantDraftClientMessage? Type945 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.AssistantDraftServerMessage>? Type946 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AssistantDraftServerMessage? Type947 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OneOf<global::Vapi.AssistantDraftBackgroundSound?, string>? Type948 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AssistantDraftBackgroundSound? Type949 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.CredentialsItem5>? Type950 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CredentialsItem5? Type951 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AssistantDraftCredentialDiscriminator? Type952 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AssistantDraftCredentialDiscriminatorProvider? Type953 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AssistantDraftPaginatedMetadata? Type954 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AssistantDraftPaginatedResponse? Type955 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.AssistantDraft>? Type956 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.LegacyAssistantVersion? Type957 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.LegacyAssistantVersionPaginatedResponse? Type958 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.LegacyAssistantVersion>? Type959 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AssistantVersion? Type960 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AssistantVersionFirstMessageMode? Type961 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AssistantVersionVoicemailDetection? Type962 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.AssistantVersionClientMessage>? Type963 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AssistantVersionClientMessage? Type964 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.AssistantVersionServerMessage>? Type965 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AssistantVersionServerMessage? Type966 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OneOf<global::Vapi.AssistantVersionBackgroundSound?, string>? Type967 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AssistantVersionBackgroundSound? Type968 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.CredentialsItem6>? Type969 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CredentialsItem6? Type970 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AssistantVersionCredentialDiscriminator? Type971 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AssistantVersionCredentialDiscriminatorProvider? Type972 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AssistantVersionPaginatedMetadata? Type973 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AssistantVersionPaginatedResponse? Type974 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.AssistantVersion>? Type975 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateAssistantVersionMetadataDTO? Type976 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.VersionPinReference? Type977 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.VersionPinReferenceSourceType? Type978 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.VersionPinConflictResponseDTO? Type979 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.VersionPinConflictResponseDTOError? Type980 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.VersionPinReference>? Type981 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateAssistantDraftDTO? Type982 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateAssistantDraftDTOFirstMessageMode? Type983 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateAssistantDraftDTOVoicemailDetection? Type984 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.CreateAssistantDraftDTOClientMessage>? Type985 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateAssistantDraftDTOClientMessage? Type986 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.CreateAssistantDraftDTOServerMessage>? Type987 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateAssistantDraftDTOServerMessage? Type988 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OneOf<global::Vapi.CreateAssistantDraftDTOBackgroundSound?, string>? Type989 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateAssistantDraftDTOBackgroundSound? Type990 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.CredentialsItem7>? Type991 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CredentialsItem7? Type992 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateAssistantDraftDTOCredentialDiscriminator? Type993 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateAssistantDraftDTOCredentialDiscriminatorProvider? Type994 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AssistantDraftConflictResponseDTO? Type995 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateAssistantDraftDTO? Type996 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateAssistantDraftDTOFirstMessageMode? Type997 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateAssistantDraftDTOVoicemailDetection? Type998 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.UpdateAssistantDraftDTOClientMessage>? Type999 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateAssistantDraftDTOClientMessage? Type1000 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.UpdateAssistantDraftDTOServerMessage>? Type1001 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateAssistantDraftDTOServerMessage? Type1002 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OneOf<global::Vapi.UpdateAssistantDraftDTOBackgroundSound?, string>? Type1003 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateAssistantDraftDTOBackgroundSound? Type1004 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.CredentialsItem8>? Type1005 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CredentialsItem8? Type1006 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateAssistantDraftDTOCredentialDiscriminator? Type1007 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateAssistantDraftDTOCredentialDiscriminatorProvider? Type1008 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateAssistantDTO? Type1009 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateAssistantDTOFirstMessageMode? Type1010 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateAssistantDTOVoicemailDetection? Type1011 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.UpdateAssistantDTOClientMessage>? Type1012 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateAssistantDTOClientMessage? Type1013 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.UpdateAssistantDTOServerMessage>? Type1014 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateAssistantDTOServerMessage? Type1015 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OneOf<global::Vapi.UpdateAssistantDTOBackgroundSound?, string>? Type1016 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateAssistantDTOBackgroundSound? Type1017 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.CredentialsItem9>? Type1018 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CredentialsItem9? Type1019 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateAssistantDTOCredentialDiscriminator? Type1020 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateAssistantDTOCredentialDiscriminatorProvider? Type1021 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AssistantPinnedConflictResponseDTO? Type1022 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AssistantPinnedConflictResponseDTOError? Type1023 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.Squad? Type1024 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateSquadDTO? Type1025 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.Workflow? Type1026 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OneOf<global::Vapi.WorkflowBackgroundSound?, string>? Type1027 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.WorkflowBackgroundSound? Type1028 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.CredentialsItem10>? Type1029 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CredentialsItem10? Type1030 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.WorkflowCredentialDiscriminator? Type1031 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.WorkflowCredentialDiscriminatorProvider? Type1032 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.WorkflowVoicemailDetection? Type1033 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateWorkflowDTO? Type1034 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OneOf<global::Vapi.CreateWorkflowDTOBackgroundSound?, string>? Type1035 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateWorkflowDTOBackgroundSound? Type1036 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.CredentialsItem11>? Type1037 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CredentialsItem11? Type1038 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateWorkflowDTOCredentialDiscriminator? Type1039 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateWorkflowDTOCredentialDiscriminatorProvider? Type1040 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateWorkflowDTOVoicemailDetection? Type1041 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateWorkflowDTO? Type1042 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OneOf<global::Vapi.UpdateWorkflowDTOBackgroundSound?, string>? Type1043 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateWorkflowDTOBackgroundSound? Type1044 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.CredentialsItem12>? Type1045 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CredentialsItem12? Type1046 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateWorkflowDTOCredentialDiscriminator? Type1047 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateWorkflowDTOCredentialDiscriminatorProvider? Type1048 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateWorkflowDTOVoicemailDetection? Type1049 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SubscriptionLimits? Type1050 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.BotMessage? Type1051 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ToolCallMessage? Type1052 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ToolCallResultMessageWarning? Type1053 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ToolCallResultMessageWarningType? Type1054 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ToolCallResultMessage? Type1055 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.ToolCallResultMessageWarning>? Type1056 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TransportCost? Type1057 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TransportCostType? Type1058 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TransportCostProvider? Type1059 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TranscriberCost? Type1060 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TranscriberCostType? Type1061 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ModelCost? Type1062 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ModelCostType? Type1063 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.VoiceCost? Type1064 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.VoiceCostType? Type1065 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ChatCost? Type1066 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ChatCostType? Type1067 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.VapiCost? Type1068 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.VapiCostType? Type1069 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.VapiCostSubType? Type1070 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.VoicemailDetectionCost? Type1071 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.VoicemailDetectionCostType? Type1072 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.VoicemailDetectionCostProvider? Type1073 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.StructuredOutputCostBreakdown? Type1074 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AnalysisCost? Type1075 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AnalysisCostType? Type1076 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AnalysisCostAnalysisType? Type1077 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.StructuredOutputCostBreakdown>? Type1078 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AudioFormat? Type1079 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AudioFormatContainer? Type1080 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.VapiWebsocketTransport? Type1081 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.VapiWebsocketTransportConversationType? Type1082 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.VapiWebsocketTransportProvider? Type1083 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.VapiWebCallTransport? Type1084 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.VapiWebCallTransportConversationType? Type1085 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.VapiWebCallTransportProvider? Type1086 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TwilioTransport? Type1087 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TwilioTransportConversationType? Type1088 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TwilioTransportProvider? Type1089 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TelnyxTransport? Type1090 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TelnyxTransportConversationType? Type1091 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TelnyxTransportProvider? Type1092 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.VapiSipTransport? Type1093 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.VapiSipTransportConversationType? Type1094 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.VapiSipTransportProvider? Type1095 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.VonageTransport? Type1096 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.VonageTransportConversationType? Type1097 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.VonageTransportProvider? Type1098 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AnalysisCostBreakdown? Type1099 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CostBreakdown? Type1100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.Analysis? Type1101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.MonitorResult? Type1102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.Monitor? Type1103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.MonitorResult>? Type1104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SkippedStructuredOutput? Type1105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TransferArtifact? Type1106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TransferArtifactMode? Type1107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TransferArtifactStatus? Type1108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.OneOf<global::Vapi.UserMessage, global::Vapi.SystemMessage, global::Vapi.BotMessage, global::Vapi.ToolCallMessage, global::Vapi.ToolCallResultMessage>>? Type1109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OneOf<global::Vapi.UserMessage, global::Vapi.SystemMessage, global::Vapi.BotMessage, global::Vapi.ToolCallMessage, global::Vapi.ToolCallResultMessage>? Type1110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.Mono? Type1111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.Recording? Type1112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.NodeArtifact? Type1113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AssistantActivation? Type1114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TurnLatency? Type1115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.PerformanceMetrics? Type1116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.TurnLatency>? Type1117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.Artifact? Type1118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Vapi.SkippedStructuredOutput>? Type1119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.TransferArtifact>? Type1120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.NodeArtifact>? Type1121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.AssistantActivation>? Type1122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.RecordingConsent? Type1123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.RecordingConsentType? Type1124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.Compliance? Type1125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.WorkflowOverrides? Type1126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TransferPhoneNumberHookAction? Type1127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TransferPhoneNumberHookActionType? Type1128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SayPhoneNumberHookAction? Type1129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SayPhoneNumberHookActionType? Type1130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.PhoneNumberCallRingingHookFilter? Type1131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.PhoneNumberCallRingingHookFilterType? Type1132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.PhoneNumberCallRingingHookFilterKey? Type1133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.PhoneNumberHookCallRinging? Type1134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.PhoneNumberHookCallRingingOn? Type1135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.PhoneNumberCallRingingHookFilter>? Type1136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.OneOf<global::Vapi.TransferPhoneNumberHookAction, global::Vapi.SayPhoneNumberHookAction>>? Type1137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OneOf<global::Vapi.TransferPhoneNumberHookAction, global::Vapi.SayPhoneNumberHookAction>? Type1138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.PhoneNumberCallEndingHookFilter? Type1139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.PhoneNumberCallEndingHookFilterType? Type1140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.PhoneNumberCallEndingHookFilterKey? Type1141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.PhoneNumberCallEndingHookFilterOneOfItem>? Type1142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.PhoneNumberCallEndingHookFilterOneOfItem? Type1143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.PhoneNumberHookCallEnding? Type1144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.PhoneNumberHookCallEndingOn? Type1145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.PhoneNumberCallEndingHookFilter>? Type1146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ImportTwilioPhoneNumberDTO? Type1147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.OneOf<global::Vapi.PhoneNumberHookCallRinging, global::Vapi.PhoneNumberHookCallEnding>>? Type1148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OneOf<global::Vapi.PhoneNumberHookCallRinging, global::Vapi.PhoneNumberHookCallEnding>? Type1149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateCustomerDTO? Type1150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SchedulePlan? Type1151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.Call? Type1152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CallType? Type1153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OneOf<global::Vapi.TransportCost, global::Vapi.TranscriberCost, global::Vapi.ModelCost, global::Vapi.VoiceCost, global::Vapi.VapiCost, global::Vapi.VoicemailDetectionCost, global::Vapi.AnalysisCost, global::Vapi.KnowledgeBaseCost>? Type1154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.KnowledgeBaseCost? Type1155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CallPhoneCallProvider? Type1156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CallPhoneCallTransport? Type1157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CallStatus? Type1158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CallEndedReason? Type1159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OneOf<global::Vapi.VapiWebsocketTransport, global::Vapi.VonageTransport, global::Vapi.TwilioTransport, global::Vapi.VapiSipTransport, global::Vapi.TelnyxTransport, global::Vapi.VapiWebCallTransport>? Type1160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CallBatchError? Type1161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CallBatchResponse? Type1162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.Call>? Type1163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.CallBatchError>? Type1164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AssistantSpeechWordAlignmentTiming? Type1165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AssistantSpeechWordAlignmentTimingType? Type1166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<double>? Type1167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AssistantSpeechWordTimestamp? Type1168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AssistantSpeechWordProgressTiming? Type1169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AssistantSpeechWordProgressTimingType? Type1170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.AssistantSpeechWordTimestamp>? Type1171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateCallDTO? Type1172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.CreateCustomerDTO>? Type1173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.StructuredOutputFilterDTO? Type1174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CallPaginatedResponse? Type1175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateOutboundCallDTO? Type1176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateWebCallDTO? Type1177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateCallDTO? Type1178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.DeleteCallDTO? Type1179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.DeveloperMessageRole? Type1180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ToolCallFunction? Type1181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ToolCall? Type1182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AssistantMessageRole? Type1183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.ToolCall>? Type1184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ToolMessageRole? Type1185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FunctionCall? Type1186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.Chat? Type1187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.OneOf<global::Vapi.ModelCost, global::Vapi.ChatCost>>? Type1188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OneOf<global::Vapi.ModelCost, global::Vapi.ChatCost>? Type1189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TwilioSMSChatTransport? Type1190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TwilioSMSChatTransportConversationType? Type1191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TwilioSMSChatTransportType? Type1192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateChatDTO? Type1193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GetChatPaginatedDTO? Type1194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GetChatPaginatedDTOSortOrder? Type1195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GetChatPaginatedDTOSortBy? Type1196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ChatPaginatedResponse? Type1197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.Chat>? Type1198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateChatStreamResponse? Type1199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OpenAIResponsesRequest? Type1200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ChatAssistantOverrides? Type1201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateWebCustomerDTO? Type1202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateWebChatDTO? Type1203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.WebChat? Type1204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OpenAIWebChatRequest? Type1205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ExportChatDTO? Type1206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ExportChatDTOColumns? Type1207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ExportChatDTOFormat? Type1208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ExportChatDTOSortOrder? Type1209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ExportChatDTOSortBy? Type1210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ResponseOutputText? Type1211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ResponseOutputTextType? Type1212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ResponseOutputMessage? Type1213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.ResponseOutputText>? Type1214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ResponseOutputMessageRole? Type1215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ResponseOutputMessageStatus? Type1216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ResponseOutputMessageType? Type1217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ResponseObject? Type1218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ResponseObjectObject? Type1219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ResponseObjectStatus? Type1220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.ResponseOutputMessage>? Type1221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ResponseTextDeltaEvent? Type1222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ResponseTextDeltaEventType? Type1223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ResponseTextDoneEvent? Type1224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ResponseTextDoneEventType? Type1225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ResponseCompletedEvent? Type1226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ResponseCompletedEventType? Type1227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ResponseErrorEvent? Type1228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ResponseErrorEventType? Type1229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.DialPlanEntry? Type1230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CampaignPredialPlan? Type1231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateCampaignDTO? Type1232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.DialPlanEntry>? Type1233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.CreateCampaignDTOServerMessage>? Type1234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateCampaignDTOServerMessage? Type1235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.Campaign? Type1236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CampaignStatus? Type1237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CampaignEndedReason? Type1238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.CampaignServerMessage>? Type1239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CampaignServerMessage? Type1240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CampaignPaginatedResponse? Type1241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.Campaign>? Type1242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CampaignContactCounters? Type1243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CampaignCallMetrics? Type1244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CampaignSummary? Type1245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CampaignSummaryStatus? Type1246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CampaignSummaryEndedReason? Type1247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.CampaignSummaryServerMessage>? Type1248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CampaignSummaryServerMessage? Type1249 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CampaignSummaryPaginatedResponse? Type1250 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.CampaignSummary>? Type1251 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateCampaignDTO? Type1252 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateCampaignDTOStatus? Type1253 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CampaignContactWithOutcome? Type1254 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CampaignContactWithOutcomeStatus? Type1255 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CampaignContactPaginatedResponse? Type1256 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.CampaignContactWithOutcome>? Type1257 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.RelayTargetAssistant? Type1258 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.RelayTargetAssistantType? Type1259 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.RelayTargetSquad? Type1260 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.RelayTargetSquadType? Type1261 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.RelayTargetOptions? Type1262 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.RelayTargetOptionsType? Type1263 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.RelayCommandSay? Type1264 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.RelayCommandSayType? Type1265 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.RelayCommandNote? Type1266 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.RelayCommandNoteType? Type1267 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.RelayCommandOptions? Type1268 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.RelayCommandOptionsType? Type1269 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.RelayRequest? Type1270 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OneOf<global::Vapi.RelayTargetAssistant, global::Vapi.RelayTargetSquad>? Type1271 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.OneOf<global::Vapi.RelayCommandSay, global::Vapi.RelayCommandNote>>? Type1272 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OneOf<global::Vapi.RelayCommandSay, global::Vapi.RelayCommandNote>? Type1273 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.RelayResponse? Type1274 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.RelayResponseStatus? Type1275 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.Session? Type1276 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.OneOf<global::Vapi.ModelCost, global::Vapi.AnalysisCost, global::Vapi.SessionCost>>? Type1277 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OneOf<global::Vapi.ModelCost, global::Vapi.AnalysisCost, global::Vapi.SessionCost>? Type1278 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SessionCost? Type1279 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SessionStatus? Type1280 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateSessionDTO? Type1281 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateSessionDTOStatus? Type1282 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateSessionDTO? Type1283 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateSessionDTOStatus? Type1284 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GetSessionPaginatedDTO? Type1285 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GetSessionPaginatedDTOSortOrder? Type1286 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GetSessionPaginatedDTOSortBy? Type1287 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SessionPaginatedResponse? Type1288 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.Session>? Type1289 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ExportSessionDTO? Type1290 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ExportSessionDTOColumns? Type1291 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ExportSessionDTOFormat? Type1292 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ExportSessionDTOSortOrder? Type1293 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ExportSessionDTOSortBy? Type1294 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ByoPhoneNumber? Type1295 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ByoPhoneNumberProvider? Type1296 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ByoPhoneNumberStatus? Type1297 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TwilioPhoneNumber? Type1298 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TwilioPhoneNumberProvider? Type1299 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TwilioPhoneNumberStatus? Type1300 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.VonagePhoneNumber? Type1301 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.VonagePhoneNumberProvider? Type1302 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.VonagePhoneNumberStatus? Type1303 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SipAuthentication? Type1304 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.VapiPhoneNumber? Type1305 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.VapiPhoneNumberProvider? Type1306 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.VapiPhoneNumberStatus? Type1307 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TelnyxPhoneNumber? Type1308 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TelnyxPhoneNumberProvider? Type1309 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TelnyxPhoneNumberStatus? Type1310 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateByoPhoneNumberDTO? Type1311 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateByoPhoneNumberDTOProvider? Type1312 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateTwilioPhoneNumberDTO? Type1313 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateTwilioPhoneNumberDTOProvider? Type1314 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateVonagePhoneNumberDTO? Type1315 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateVonagePhoneNumberDTOProvider? Type1316 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateVapiPhoneNumberDTO? Type1317 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateVapiPhoneNumberDTOProvider? Type1318 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateTelnyxPhoneNumberDTO? Type1319 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateTelnyxPhoneNumberDTOProvider? Type1320 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateByoPhoneNumberDTO? Type1321 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateByoPhoneNumberDTOProvider? Type1322 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateTwilioPhoneNumberDTO? Type1323 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateTwilioPhoneNumberDTOProvider? Type1324 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateVonagePhoneNumberDTO? Type1325 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateVonagePhoneNumberDTOProvider? Type1326 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateVapiPhoneNumberDTO? Type1327 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateVapiPhoneNumberDTOProvider? Type1328 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateTelnyxPhoneNumberDTO? Type1329 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateTelnyxPhoneNumberDTOProvider? Type1330 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ImportVonagePhoneNumberDTO? Type1331 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.PhoneNumberPaginatedResponse? Type1332 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.OneOf<global::Vapi.ByoPhoneNumber, global::Vapi.TwilioPhoneNumber, global::Vapi.VonagePhoneNumber, global::Vapi.VapiPhoneNumber, global::Vapi.TelnyxPhoneNumber>>? Type1333 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OneOf<global::Vapi.ByoPhoneNumber, global::Vapi.TwilioPhoneNumber, global::Vapi.VonagePhoneNumber, global::Vapi.VapiPhoneNumber, global::Vapi.TelnyxPhoneNumber>? Type1334 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ApiRequestTool? Type1335 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ApiRequestToolType? Type1336 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ApiRequestToolMethod? Type1337 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CodeToolEnvironmentVariable? Type1338 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CodeTool? Type1339 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CodeToolType? Type1340 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.CodeToolEnvironmentVariable>? Type1341 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.DtmfTool? Type1342 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.DtmfToolType? Type1343 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.EndCallTool? Type1344 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.EndCallToolType? Type1345 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FunctionTool? Type1346 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FunctionToolType? Type1347 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.KnowledgeBaseToolFunction? Type1348 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.KnowledgeBaseTool? Type1349 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.KnowledgeBaseToolType? Type1350 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GhlTool? Type1351 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GhlToolType? Type1352 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.MakeTool? Type1353 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.MakeToolType? Type1354 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TransferCallTool? Type1355 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TransferCallToolType? Type1356 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.HandoffTool? Type1357 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.HandoffToolType? Type1358 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OutputTool? Type1359 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OutputToolType? Type1360 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.BashTool? Type1361 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.BashToolType? Type1362 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.BashToolSubType? Type1363 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.BashToolName? Type1364 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ComputerTool? Type1365 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ComputerToolType? Type1366 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ComputerToolSubType? Type1367 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ComputerToolName? Type1368 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TextEditorTool? Type1369 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TextEditorToolType? Type1370 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TextEditorToolSubType? Type1371 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TextEditorToolName? Type1372 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.QueryTool? Type1373 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.QueryToolType? Type1374 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GoogleCalendarCreateEventTool? Type1375 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GoogleCalendarCreateEventToolType? Type1376 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GoogleSheetsRowAppendTool? Type1377 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GoogleSheetsRowAppendToolType? Type1378 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GoogleCalendarCheckAvailabilityTool? Type1379 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GoogleCalendarCheckAvailabilityToolType? Type1380 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SlackSendMessageTool? Type1381 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SlackSendMessageToolType? Type1382 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SmsTool? Type1383 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SmsToolType? Type1384 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.McpTool? Type1385 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.McpToolType? Type1386 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GoHighLevelCalendarAvailabilityTool? Type1387 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GoHighLevelCalendarAvailabilityToolType? Type1388 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GoHighLevelCalendarEventCreateTool? Type1389 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GoHighLevelCalendarEventCreateToolType? Type1390 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GoHighLevelContactCreateTool? Type1391 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GoHighLevelContactCreateToolType? Type1392 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GoHighLevelContactGetTool? Type1393 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GoHighLevelContactGetToolType? Type1394 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SipRequestTool? Type1395 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SipRequestToolType? Type1396 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SipRequestToolVerb? Type1397 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OneOf<string, global::Vapi.JsonSchema>? Type1398 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.VoicemailTool? Type1399 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.VoicemailToolType? Type1400 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateApiRequestToolDTOType? Type1401 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateApiRequestToolDTOMethod? Type1402 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateCodeToolDTOType? Type1403 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateOutputToolDTO? Type1404 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateOutputToolDTOType? Type1405 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateBashToolDTOType? Type1406 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateBashToolDTOSubType? Type1407 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateBashToolDTOName? Type1408 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateComputerToolDTOType? Type1409 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateComputerToolDTOSubType? Type1410 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateComputerToolDTOName? Type1411 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateTextEditorToolDTOType? Type1412 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateTextEditorToolDTOSubType? Type1413 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateTextEditorToolDTOName? Type1414 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateSmsToolDTOType? Type1415 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateSipRequestToolDTOType? Type1416 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateSipRequestToolDTOVerb? Type1417 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateApiRequestToolDTO? Type1418 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateApiRequestToolDTOType? Type1419 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateApiRequestToolDTOMethod? Type1420 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateCodeToolDTO? Type1421 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateCodeToolDTOType? Type1422 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateDtmfToolDTO? Type1423 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateDtmfToolDTOType? Type1424 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateEndCallToolDTO? Type1425 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateEndCallToolDTOType? Type1426 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateFunctionToolDTO? Type1427 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateFunctionToolDTOType? Type1428 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateKnowledgeBaseToolDTO? Type1429 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateKnowledgeBaseToolDTOType? Type1430 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateGhlToolDTO? Type1431 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateGhlToolDTOType? Type1432 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateMakeToolDTO? Type1433 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateMakeToolDTOType? Type1434 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateHandoffToolDTO? Type1435 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateHandoffToolDTOType? Type1436 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateTransferCallToolDTO? Type1437 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateTransferCallToolDTOType? Type1438 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateOutputToolDTO? Type1439 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateOutputToolDTOType? Type1440 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateBashToolDTO? Type1441 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateBashToolDTOType? Type1442 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateBashToolDTOSubType? Type1443 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateBashToolDTOName? Type1444 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateComputerToolDTO? Type1445 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateComputerToolDTOType? Type1446 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateComputerToolDTOSubType? Type1447 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateComputerToolDTOName? Type1448 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateTextEditorToolDTO? Type1449 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateTextEditorToolDTOType? Type1450 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateTextEditorToolDTOSubType? Type1451 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateTextEditorToolDTOName? Type1452 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateQueryToolDTO? Type1453 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateQueryToolDTOType? Type1454 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateGoogleCalendarCreateEventToolDTO? Type1455 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateGoogleCalendarCreateEventToolDTOType? Type1456 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateGoogleSheetsRowAppendToolDTO? Type1457 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateGoogleSheetsRowAppendToolDTOType? Type1458 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateGoogleCalendarCheckAvailabilityToolDTO? Type1459 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateGoogleCalendarCheckAvailabilityToolDTOType? Type1460 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateSlackSendMessageToolDTO? Type1461 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateSlackSendMessageToolDTOType? Type1462 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateSmsToolDTO? Type1463 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateSmsToolDTOType? Type1464 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateMcpToolDTO? Type1465 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateMcpToolDTOType? Type1466 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateGoHighLevelCalendarAvailabilityToolDTO? Type1467 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateGoHighLevelCalendarAvailabilityToolDTOType? Type1468 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateGoHighLevelCalendarEventCreateToolDTO? Type1469 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateGoHighLevelCalendarEventCreateToolDTOType? Type1470 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateGoHighLevelContactCreateToolDTO? Type1471 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateGoHighLevelContactCreateToolDTOType? Type1472 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateGoHighLevelContactGetToolDTO? Type1473 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateGoHighLevelContactGetToolDTOType? Type1474 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateSipRequestToolDTO? Type1475 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateSipRequestToolDTOType? Type1476 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateSipRequestToolDTOVerb? Type1477 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateVoicemailToolDTO? Type1478 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateVoicemailToolDTOType? Type1479 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ToolVersion? Type1480 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ToolVersionPaginatedMetadata? Type1481 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ToolVersionPaginatedResponse? Type1482 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.ToolVersion>? Type1483 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ToolDraft? Type1484 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ToolDraftType? Type1485 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ToolDraftMethod? Type1486 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ToolDraftVerb? Type1487 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateToolDraftDTO? Type1488 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateToolDraftDTOType? Type1489 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateToolDraftDTOMethod? Type1490 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateToolDraftDTOVerb? Type1491 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateToolDraftDTO? Type1492 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateToolDraftDTOType? Type1493 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateToolDraftDTOMethod? Type1494 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateToolDraftDTOVerb? Type1495 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ToolDraftPaginatedMetadata? Type1496 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ToolDraftPaginatedResponse? Type1497 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.ToolDraft>? Type1498 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ToolDraftConflictResponseDTO? Type1499 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GetToolDraftsDTO? Type1500 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateToolVersionMetadataDTO? Type1501 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ToolPinnedConflictResponseDTO? Type1502 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ToolPinnedConflictResponseDTOError? Type1503 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateFileDTO? Type1504 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateFileDTOPurpose? Type1505 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.File? Type1506 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FileObject? Type1507 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FileStatus? Type1508 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateFileDTO? Type1509 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CustomKnowledgeBase? Type1510 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CustomKnowledgeBaseProvider? Type1511 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateCustomKnowledgeBaseDTO? Type1512 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateCustomKnowledgeBaseDTOProvider? Type1513 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateKnowledgeBaseV2DTO? Type1514 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.KnowledgeBaseV2? Type1515 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.KnowledgeBaseV2File? Type1516 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.KnowledgeBaseV2FileStatus? Type1517 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AttachKnowledgeBaseV2FileDTO? Type1518 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateKnowledgeBaseV2DTO? Type1519 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.KnowledgeBaseV2WithFiles? Type1520 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.KnowledgeBaseV2File>? Type1521 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.StructuredOutputRunResult? Type1522 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.StructuredOutputRunPreviewResponse? Type1523 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.StructuredOutputRerunResponse? Type1524 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.StructuredOutput? Type1525 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.StructuredOutputType? Type1526 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.StructuredOutputPaginatedResponse? Type1527 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.StructuredOutput>? Type1528 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateStructuredOutputDTO? Type1529 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateStructuredOutputDTOType? Type1530 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.StructuredOutputRunDTO? Type1531 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TesterPlan? Type1532 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TestSuitePhoneNumber? Type1533 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TestSuitePhoneNumberProvider? Type1534 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TargetPlan? Type1535 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TestSuite? Type1536 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TestSuitesPaginatedResponse? Type1537 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.TestSuite>? Type1538 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateTestSuiteDto? Type1539 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateTestSuiteDto? Type1540 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TestSuiteTestVoice? Type1541 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.TestSuiteTestScorerAI>? Type1542 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TestSuiteTestScorerAI? Type1543 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TestSuiteTestVoiceType? Type1544 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TestSuiteTestChat? Type1545 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TestSuiteTestChatType? Type1546 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateTestSuiteTestVoiceDto? Type1547 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateTestSuiteTestVoiceDtoType? Type1548 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateTestSuiteTestChatDto? Type1549 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateTestSuiteTestChatDtoType? Type1550 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateTestSuiteTestVoiceDto? Type1551 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateTestSuiteTestVoiceDtoType? Type1552 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateTestSuiteTestChatDto? Type1553 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateTestSuiteTestChatDtoType? Type1554 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TestSuiteTestScorerAIType? Type1555 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TestSuiteTestsPaginatedResponse? Type1556 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.OneOf<global::Vapi.TestSuiteTestVoice, global::Vapi.TestSuiteTestChat>>? Type1557 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OneOf<global::Vapi.TestSuiteTestVoice, global::Vapi.TestSuiteTestChat>? Type1558 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TestSuiteRunScorerAI? Type1559 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TestSuiteRunScorerAIType? Type1560 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TestSuiteRunScorerAIResult? Type1561 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TestSuiteRunTestAttemptCall? Type1562 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TestSuiteRunTestAttemptMetadata? Type1563 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TestSuiteRunTestAttempt? Type1564 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.TestSuiteRunScorerAI>? Type1565 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TestSuiteRunTestResult? Type1566 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.TestSuiteRunTestAttempt>? Type1567 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TestSuiteRun? Type1568 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TestSuiteRunStatus? Type1569 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.TestSuiteRunTestResult>? Type1570 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TestSuiteRunsPaginatedResponse? Type1571 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.TestSuiteRun>? Type1572 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateTestSuiteRunDto? Type1573 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateTestSuiteRunDto? Type1574 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreatePersonalityDTO? Type1575 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.Personality? Type1576 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdatePersonalityDTO? Type1577 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.PersonalityInUseConflictResponseDTO? Type1578 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.PersonalityInUseConflictResponseDTOError? Type1579 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SimulationHookInclude? Type1580 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SimulationHookWebhookAction? Type1581 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SimulationHookWebhookActionType? Type1582 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SimulationHookCallStarted? Type1583 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SimulationHookCallStartedOn? Type1584 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.SimulationHookWebhookAction>? Type1585 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SimulationHookCallEnded? Type1586 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SimulationHookCallEndedOn? Type1587 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.EvaluationPlanItem? Type1588 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.EvaluationPlanItemComparator? Type1589 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OneOf<double?, string, bool?>? Type1590 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ScenarioToolMock? Type1591 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateScenarioDTO? Type1592 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.EvaluationPlanItem>? Type1593 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.OneOf<global::Vapi.SimulationHookCallStarted, global::Vapi.SimulationHookCallEnded>>? Type1594 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OneOf<global::Vapi.SimulationHookCallStarted, global::Vapi.SimulationHookCallEnded>? Type1595 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.ScenarioToolMock>? Type1596 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.Scenario? Type1597 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateScenarioDTO? Type1598 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ScenarioInUseConflictResponseDTO? Type1599 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ScenarioInUseConflictResponseDTOError? Type1600 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SimulationRunSimulationEntry? Type1601 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SimulationRunSimulationEntryType? Type1602 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SimulationRunSuiteEntry? Type1603 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SimulationRunSuiteEntryType? Type1604 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SimulationRunTargetAssistant? Type1605 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SimulationRunTargetAssistantType? Type1606 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SimulationRunTargetSquad? Type1607 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SimulationRunTargetSquadType? Type1608 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SimulationRunTransportConfiguration? Type1609 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SimulationRunTransportConfigurationProvider? Type1610 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateSimulationRunDTO? Type1611 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.OneOf<global::Vapi.SimulationRunSimulationEntry, global::Vapi.SimulationRunSuiteEntry>>? Type1612 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OneOf<global::Vapi.SimulationRunSimulationEntry, global::Vapi.SimulationRunSuiteEntry>? Type1613 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OneOf<global::Vapi.SimulationRunTargetAssistant, global::Vapi.SimulationRunTargetSquad>? Type1614 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SimulationRunItemCounts? Type1615 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateSimulationRunResponse? Type1616 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateSimulationRunResponseStatus? Type1617 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SimulationRunPaymentRequiredResponse? Type1618 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SimulationRunPaymentRequiredResponseReason? Type1619 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SimulationRun? Type1620 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SimulationRunStatus? Type1621 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SimulationRunListSource? Type1622 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SimulationRunListSourceType? Type1623 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SimulationRunListSummary? Type1624 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SimulationRunListItem? Type1625 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SimulationRunListItemStatus? Type1626 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SimulationRunsPaginatedResponse? Type1627 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.SimulationRunListItem>? Type1628 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SimulationRunItemCallMonitor? Type1629 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SimulationRunItemCallMetadata? Type1630 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SimulationRunItemMetadata? Type1631 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.StructuredOutputEvaluationResult? Type1632 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OneOf<double?, string, bool?, object>? Type1633 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.StructuredOutputEvaluationResultComparator? Type1634 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.LatencyMetrics? Type1635 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SimulationRunItemResults? Type1636 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.StructuredOutputEvaluationResult>? Type1637 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SimulationRunItemImprovementSuggestion? Type1638 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SimulationRunItemImprovements? Type1639 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.SimulationRunItemImprovementSuggestion>? Type1640 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SimulationRunConfiguration? Type1641 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SimulationRunItem? Type1642 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SimulationRunItemStatus? Type1643 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SimulationSuiteTargetAssignment? Type1644 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SimulationSuiteTargetAssignmentTargetType? Type1645 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateSimulationSuiteDTO? Type1646 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.SimulationSuiteTargetAssignment>? Type1647 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SimulationSuite? Type1648 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateSimulationSuiteDTO? Type1649 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GenerateScenariosDTO? Type1650 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GeneratedScenario? Type1651 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GeneratedScenarioCategory? Type1652 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GenerateScenariosResponse? Type1653 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.GeneratedScenario>? Type1654 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateSimulationDTO? Type1655 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.Simulation? Type1656 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateSimulationDTO? Type1657 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SimulationConcurrencyResponse? Type1658 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.BarInsightMetadata? Type1659 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.InsightTimeRangeWithStep? Type1660 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.InsightTimeRangeWithStepStep? Type1661 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.BarInsight? Type1662 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.BarInsightType? Type1663 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.InsightFormula>? Type1664 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.InsightFormula? Type1665 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.BarInsightGroupBy? Type1666 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.JSONQueryOnCallTableWithStringTypeColumn? Type1667 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.JSONQueryOnCallTableWithNumberTypeColumn? Type1668 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.JSONQueryOnCallTableWithStructuredOutputColumn? Type1669 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.JSONQueryOnEventsTable? Type1670 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.InsightTimeRange? Type1671 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.PieInsight? Type1672 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.PieInsightType? Type1673 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.PieInsightGroupBy? Type1674 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.LineInsightMetadata? Type1675 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.LineInsight? Type1676 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.LineInsightType? Type1677 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.LineInsightGroupBy? Type1678 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TextInsight? Type1679 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TextInsightType? Type1680 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateBarInsightFromCallTableDTO? Type1681 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateBarInsightFromCallTableDTOType? Type1682 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateBarInsightFromCallTableDTOGroupBy? Type1683 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdatePieInsightFromCallTableDTO? Type1684 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdatePieInsightFromCallTableDTOType? Type1685 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdatePieInsightFromCallTableDTOGroupBy? Type1686 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateLineInsightFromCallTableDTO? Type1687 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateLineInsightFromCallTableDTOType? Type1688 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateLineInsightFromCallTableDTOGroupBy? Type1689 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateTextInsightFromCallTableDTO? Type1690 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateTextInsightFromCallTableDTOType? Type1691 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateBarInsightFromCallTableDTO? Type1692 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateBarInsightFromCallTableDTOType? Type1693 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateBarInsightFromCallTableDTOGroupBy? Type1694 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreatePieInsightFromCallTableDTO? Type1695 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreatePieInsightFromCallTableDTOType? Type1696 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreatePieInsightFromCallTableDTOGroupBy? Type1697 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateLineInsightFromCallTableDTO? Type1698 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateLineInsightFromCallTableDTOType? Type1699 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateLineInsightFromCallTableDTOGroupBy? Type1700 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateTextInsightFromCallTableDTO? Type1701 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateTextInsightFromCallTableDTOType? Type1702 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.JSONQueryOnCallTableWithStringTypeColumnType? Type1703 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.JSONQueryOnCallTableWithStringTypeColumnTable? Type1704 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FilterStringTypeColumnOnCallTable? Type1705 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FilterStringArrayTypeColumnOnCallTable? Type1706 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FilterNumberTypeColumnOnCallTable? Type1707 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FilterNumberArrayTypeColumnOnCallTable? Type1708 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FilterDateTypeColumnOnCallTable? Type1709 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FilterStructuredOutputColumnOnCallTable? Type1710 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.JSONQueryOnCallTableWithStringTypeColumnColumn? Type1711 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.JSONQueryOnCallTableWithStringTypeColumnOperation? Type1712 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.JSONQueryOnCallTableWithNumberTypeColumnType? Type1713 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.JSONQueryOnCallTableWithNumberTypeColumnTable? Type1714 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.JSONQueryOnCallTableWithNumberTypeColumnColumn? Type1715 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.JSONQueryOnCallTableWithNumberTypeColumnOperation? Type1716 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.JSONQueryOnCallTableWithStructuredOutputColumnType? Type1717 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.JSONQueryOnCallTableWithStructuredOutputColumnTable? Type1718 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.JSONQueryOnCallTableWithStructuredOutputColumnColumn? Type1719 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.JSONQueryOnCallTableWithStructuredOutputColumnOperation? Type1720 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.JSONQueryOnEventsTableType? Type1721 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.JSONQueryOnEventsTableTable? Type1722 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.JSONQueryOnEventsTableOn? Type1723 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.JSONQueryOnEventsTableOperation? Type1724 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.OneOf<global::Vapi.EventsTableStringCondition, global::Vapi.EventsTableNumberCondition, global::Vapi.EventsTableBooleanCondition>>? Type1725 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OneOf<global::Vapi.EventsTableStringCondition, global::Vapi.EventsTableNumberCondition, global::Vapi.EventsTableBooleanCondition>? Type1726 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.EventsTableStringCondition? Type1727 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.EventsTableNumberCondition? Type1728 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.EventsTableBooleanCondition? Type1729 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FilterStringTypeColumnOnCallTableColumn? Type1730 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FilterStringTypeColumnOnCallTableOperator? Type1731 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FilterNumberTypeColumnOnCallTableColumn? Type1732 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FilterNumberTypeColumnOnCallTableOperator? Type1733 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FilterDateTypeColumnOnCallTableColumn? Type1734 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FilterDateTypeColumnOnCallTableOperator? Type1735 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FilterStructuredOutputColumnOnCallTableColumn? Type1736 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FilterStructuredOutputColumnOnCallTableOperator? Type1737 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FilterStringArrayTypeColumnOnCallTableColumn? Type1738 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FilterStringArrayTypeColumnOnCallTableOperator? Type1739 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FilterNumberArrayTypeColumnOnCallTableColumn? Type1740 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FilterNumberArrayTypeColumnOnCallTableOperator? Type1741 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.EventsTableStringConditionOperator? Type1742 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.EventsTableNumberConditionOperator? Type1743 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.EventsTableBooleanConditionOperator? Type1744 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.BarInsightFromCallTable? Type1745 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.BarInsightFromCallTableType? Type1746 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.BarInsightFromCallTableGroupBy? Type1747 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.PieInsightFromCallTable? Type1748 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.PieInsightFromCallTableType? Type1749 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.PieInsightFromCallTableGroupBy? Type1750 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.LineInsightFromCallTable? Type1751 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.LineInsightFromCallTableType? Type1752 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.LineInsightFromCallTableGroupBy? Type1753 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TextInsightFromCallTable? Type1754 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TextInsightFromCallTableType? Type1755 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.InsightRunFormatPlan? Type1756 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.InsightRunFormatPlanFormat? Type1757 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.InsightRunDTO? Type1758 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.InsightRunResponse? Type1759 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.Insight? Type1760 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.InsightType? Type1761 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.InsightPaginatedResponse? Type1762 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.Insight>? Type1763 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.BoardLayout? Type1764 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.Board? Type1765 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.OneOf<global::Vapi.BoardInsightItem, global::Vapi.BoardMetricWidgetItem>>? Type1766 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OneOf<global::Vapi.BoardInsightItem, global::Vapi.BoardMetricWidgetItem>? Type1767 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.BoardInsightItem? Type1768 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.BoardMetricWidgetItem? Type1769 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.BoardItemPosition? Type1770 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.BoardItemSize? Type1771 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.BoardInsightItemType? Type1772 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.BoardMetricWidgetItemType? Type1773 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateBoardDTO? Type1774 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateBoardDTO? Type1775 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.BoardPaginatedResponse? Type1776 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.Board>? Type1777 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateEvalDTO? Type1778 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ChatEvalAssistantMessageMock? Type1779 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ChatEvalSystemMessageMock? Type1780 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ChatEvalToolResponseMessageMock? Type1781 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ChatEvalToolResponseMessageEvaluation? Type1782 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ChatEvalUserMessageMock? Type1783 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ChatEvalAssistantMessageEvaluation? Type1784 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateEvalDTOType? Type1785 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.Eval? Type1786 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.EvalType? Type1787 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.EvalModelListOptions? Type1788 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.EvalModelListOptionsProvider? Type1789 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.EvalUserEditable? Type1790 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.EvalUserEditableType? Type1791 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ChatEvalAssistantMessageMockToolCall? Type1792 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ChatEvalAssistantMessageMockRole? Type1793 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.ChatEvalAssistantMessageMockToolCall>? Type1794 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ChatEvalSystemMessageMockRole? Type1795 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ChatEvalToolResponseMessageMockRole? Type1796 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ChatEvalUserMessageMockRole? Type1797 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AssistantMessageEvaluationContinuePlan? Type1798 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ChatEvalAssistantMessageEvaluationRole? Type1799 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OneOf<global::Vapi.AssistantMessageJudgePlanExact, global::Vapi.AssistantMessageJudgePlanRegex, global::Vapi.AssistantMessageJudgePlanAI>? Type1800 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AssistantMessageJudgePlanExact? Type1801 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AssistantMessageJudgePlanRegex? Type1802 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AssistantMessageJudgePlanAI? Type1803 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.EvalOpenAIModel? Type1804 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.EvalOpenAIModelProvider? Type1805 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.EvalOpenAIModelModel? Type1806 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.EvalAnthropicModel? Type1807 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.EvalAnthropicModelProvider? Type1808 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.EvalAnthropicModelModel? Type1809 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.EvalGoogleModel? Type1810 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.EvalGoogleModelProvider? Type1811 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.EvalGoogleModelModel? Type1812 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.EvalGroqModel? Type1813 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.EvalGroqModelProvider? Type1814 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.EvalGroqModelModel? Type1815 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.EvalCustomModel? Type1816 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.EvalCustomModelProvider? Type1817 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OneOf<global::Vapi.EvalOpenAIModel, global::Vapi.EvalAnthropicModel, global::Vapi.EvalGoogleModel, global::Vapi.EvalCustomModel>? Type1818 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AssistantMessageJudgePlanAIType? Type1819 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ChatEvalToolResponseMessageEvaluationRole? Type1820 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AssistantMessageJudgePlanExactType? Type1821 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AssistantMessageJudgePlanRegexType? Type1822 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GetEvalPaginatedDTO? Type1823 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GetEvalPaginatedDTOSortOrder? Type1824 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GetEvalPaginatedDTOSortBy? Type1825 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.EvalPaginatedResponse? Type1826 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.Eval>? Type1827 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateEvalDTO? Type1828 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateEvalDTOType? Type1829 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateEvalRunDTO? Type1830 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OneOf<global::Vapi.EvalRunTargetAssistant, global::Vapi.EvalRunTargetSquad>? Type1831 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.EvalRunTargetAssistant? Type1832 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.EvalRunTargetSquad? Type1833 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateEvalRunDTOType? Type1834 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.EvalRunResult? Type1835 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.EvalRunResultStatus? Type1836 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OneOf<global::Vapi.ChatEvalUserMessageMock, global::Vapi.ChatEvalSystemMessageMock, global::Vapi.ChatEvalToolResponseMessageMock, global::Vapi.ChatEvalAssistantMessageMock>? Type1837 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.EvalRun? Type1838 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.EvalRunStatus? Type1839 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.EvalRunEndedReason? Type1840 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.EvalRunResult>? Type1841 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.EvalRunType? Type1842 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.EvalRunPaginatedResponse? Type1843 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.EvalRun>? Type1844 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GetEvalRunPaginatedDTO? Type1845 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GetEvalRunPaginatedDTOSortOrder? Type1846 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GetEvalRunPaginatedDTOSortBy? Type1847 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.EvalRunTargetAssistantType? Type1848 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.EvalRunTargetSquadType? Type1849 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.Scorecard? Type1850 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ScorecardPaginatedResponse? Type1851 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.Scorecard>? Type1852 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateScorecardDTO? Type1853 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateOrgDTO? Type1854 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateOrgDTOChannel? Type1855 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AutoReloadPlan? Type1856 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.InvoicePlan? Type1857 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.Subscription? Type1858 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SubscriptionType? Type1859 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SubscriptionStatus? Type1860 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SubscriptionMinutesIncludedResetFrequency? Type1861 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.Org? Type1862 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OrgChannel? Type1863 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateOrgDTO? Type1864 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateOrgDTOChannel? Type1865 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.User? Type1866 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.InviteUserDTO? Type1867 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OneOf<global::Vapi.InviteUserDTORole?, string>? Type1868 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.InviteUserDTORole? Type1869 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.PendingInvitationDTO? Type1870 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.PendingInvitationsResponseDTO? Type1871 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.PendingInvitationDTO>? Type1872 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.RevokeInvitationResponseDTO? Type1873 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateUserRoleDTO? Type1874 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OneOf<global::Vapi.UpdateUserRoleDTORole?, string>? Type1875 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateUserRoleDTORole? Type1876 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.JwtResponse? Type1877 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TokenRestrictions? Type1878 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateTokenDTO? Type1879 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateTokenDTOTag? Type1880 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.Token? Type1881 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TokenTag? Type1882 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateTokenDTO? Type1883 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateTokenDTOTag? Type1884 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AnthropicCredential? Type1885 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AnthropicCredentialProvider? Type1886 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AWSStsAuthenticationArtifact? Type1887 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AWSStsAssumeRoleUser? Type1888 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AWSStsCredentials? Type1889 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AWSStsAuthenticationSession? Type1890 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AnthropicBedrockCredential? Type1891 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AnthropicBedrockCredentialProvider? Type1892 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AnthropicBedrockCredentialRegion? Type1893 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AnyscaleCredential? Type1894 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AnyscaleCredentialProvider? Type1895 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AssemblyAICredential? Type1896 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AssemblyAICredentialProvider? Type1897 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AzureCredential? Type1898 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AzureCredentialProvider? Type1899 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AzureCredentialService? Type1900 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AzureCredentialRegion? Type1901 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AzureOpenAICredential? Type1902 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AzureOpenAICredentialProvider? Type1903 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AzureOpenAICredentialRegion? Type1904 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.AzureOpenAICredentialModel>? Type1905 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AzureOpenAICredentialModel? Type1906 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ByoSipTrunkCredential? Type1907 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ByoSipTrunkCredentialProvider? Type1908 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CartesiaCredential? Type1909 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CartesiaCredentialProvider? Type1910 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CerebrasCredential? Type1911 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CerebrasCredentialProvider? Type1912 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CloudflareCredential? Type1913 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CloudflareCredentialProvider? Type1914 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.Oauth2AuthenticationSession? Type1915 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CustomLLMCredential? Type1916 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CustomLLMCredentialProvider? Type1917 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.DeepgramCredential? Type1918 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.DeepgramCredentialProvider? Type1919 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.DeepInfraCredential? Type1920 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.DeepInfraCredentialProvider? Type1921 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.DeepSeekCredential? Type1922 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.DeepSeekCredentialProvider? Type1923 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ElevenLabsCredential? Type1924 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ElevenLabsCredentialProvider? Type1925 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ElevenLabsCredentialApiUrl? Type1926 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GcpCredential? Type1927 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GcpCredentialProvider? Type1928 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GladiaCredential? Type1929 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GladiaCredentialProvider? Type1930 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GoHighLevelCredential? Type1931 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GoHighLevelCredentialProvider? Type1932 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GoogleCredential? Type1933 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GoogleCredentialProvider? Type1934 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GroqCredential? Type1935 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GroqCredentialProvider? Type1936 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.HumeCredential? Type1937 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.HumeCredentialProvider? Type1938 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.InflectionAICredential? Type1939 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.InflectionAICredentialProvider? Type1940 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.LangfuseCredential? Type1941 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.LangfuseCredentialProvider? Type1942 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.LmntCredential? Type1943 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.LmntCredentialProvider? Type1944 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.MakeCredential? Type1945 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.MakeCredentialProvider? Type1946 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.MicrosoftCredential? Type1947 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.MicrosoftCredentialProvider? Type1948 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.MistralCredential? Type1949 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.MistralCredentialProvider? Type1950 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.NeuphonicCredential? Type1951 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.NeuphonicCredentialProvider? Type1952 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OpenAICredential? Type1953 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OpenAICredentialProvider? Type1954 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OpenRouterCredential? Type1955 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OpenRouterCredentialProvider? Type1956 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.PerplexityAICredential? Type1957 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.PerplexityAICredentialProvider? Type1958 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.PlayHTCredential? Type1959 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.PlayHTCredentialProvider? Type1960 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.RimeAICredential? Type1961 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.RimeAICredentialProvider? Type1962 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.RunpodCredential? Type1963 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.RunpodCredentialProvider? Type1964 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.WellSaidCredential? Type1965 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.WellSaidCredentialProvider? Type1966 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.S3Credential? Type1967 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.S3CredentialProvider? Type1968 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.S3CompatibleBucketPlan? Type1969 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.S3CompatibleStorageCredential? Type1970 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.S3CompatibleStorageCredentialProvider? Type1971 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SmallestAICredential? Type1972 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SmallestAICredentialProvider? Type1973 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SonioxCredential? Type1974 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SonioxCredentialProvider? Type1975 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SpeechmaticsCredential? Type1976 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SpeechmaticsCredentialProvider? Type1977 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SupabaseCredential? Type1978 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SupabaseCredentialProvider? Type1979 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TavusCredential? Type1980 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TavusCredentialProvider? Type1981 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TogetherAICredential? Type1982 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TogetherAICredentialProvider? Type1983 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TwilioCredential? Type1984 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TwilioCredentialProvider? Type1985 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.VonageCredential? Type1986 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.VonageCredentialProvider? Type1987 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.WebhookCredential? Type1988 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.WebhookCredentialProvider? Type1989 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AuthenticationPlan4? Type1990 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.WebhookCredentialAuthenticationPlanDiscriminator? Type1991 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.WebhookCredentialAuthenticationPlanDiscriminatorType? Type1992 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SpkiPemPublicKeyConfig? Type1993 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SpkiPemPublicKeyConfigFormat? Type1994 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.PublicKeyEncryptionPlan? Type1995 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.PublicKeyEncryptionPlanType? Type1996 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.PublicKeyEncryptionPlanAlgorithm? Type1997 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.PublicKeyEncryptionPlanPublicKeyDiscriminator? Type1998 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.PublicKeyEncryptionPlanPublicKeyDiscriminatorFormat? Type1999 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CustomCredential? Type2000 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CustomCredentialProvider? Type2001 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AuthenticationPlan5? Type2002 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CustomCredentialAuthenticationPlanDiscriminator? Type2003 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CustomCredentialAuthenticationPlanDiscriminatorType? Type2004 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CustomCredentialEncryptionPlanDiscriminator? Type2005 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CustomCredentialEncryptionPlanDiscriminatorType? Type2006 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.XAiCredential? Type2007 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.XAiCredentialProvider? Type2008 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GoogleCalendarOAuth2ClientCredential? Type2009 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GoogleCalendarOAuth2ClientCredentialProvider? Type2010 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GoogleCalendarOAuth2AuthorizationCredential? Type2011 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GoogleCalendarOAuth2AuthorizationCredentialProvider? Type2012 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GoogleSheetsOAuth2AuthorizationCredential? Type2013 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GoogleSheetsOAuth2AuthorizationCredentialProvider? Type2014 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SlackOAuth2AuthorizationCredential? Type2015 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SlackOAuth2AuthorizationCredentialProvider? Type2016 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GoHighLevelMCPCredential? Type2017 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GoHighLevelMCPCredentialProvider? Type2018 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.InworldCredential? Type2019 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.InworldCredentialProvider? Type2020 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.EmailCredential? Type2021 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.EmailCredentialProvider? Type2022 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SlackWebhookCredential? Type2023 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SlackWebhookCredentialProvider? Type2024 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateCerebrasCredentialDTOProvider? Type2025 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateGoogleCredentialDTOProvider? Type2026 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateHumeCredentialDTOProvider? Type2027 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateInflectionAICredentialDTOProvider? Type2028 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateMicrosoftCredentialDTOProvider? Type2029 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateMistralCredentialDTOProvider? Type2030 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateNeuphonicCredentialDTOProvider? Type2031 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateWellSaidCredentialDTOProvider? Type2032 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateS3CompatibleCredentialDTOProvider? Type2033 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateSonioxCredentialDTOProvider? Type2034 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateSpeechmaticsCredentialDTOProvider? Type2035 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateCustomCredentialDTOProvider? Type2036 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AuthenticationPlan6? Type2037 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateCustomCredentialDTOAuthenticationPlanDiscriminator? Type2038 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateCustomCredentialDTOAuthenticationPlanDiscriminatorType? Type2039 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateCustomCredentialDTOEncryptionPlanDiscriminator? Type2040 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateCustomCredentialDTOEncryptionPlanDiscriminatorType? Type2041 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateGoHighLevelMCPCredentialDTOProvider? Type2042 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateInworldCredentialDTOProvider? Type2043 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateEmailCredentialDTOProvider? Type2044 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateSlackWebhookCredentialDTOProvider? Type2045 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateAnthropicCredentialDTO? Type2046 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateAnthropicCredentialDTOProvider? Type2047 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateAnthropicBedrockCredentialDTO? Type2048 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateAnthropicBedrockCredentialDTOProvider? Type2049 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateAnthropicBedrockCredentialDTORegion? Type2050 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateAnyscaleCredentialDTO? Type2051 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateAnyscaleCredentialDTOProvider? Type2052 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateAssemblyAICredentialDTO? Type2053 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateAssemblyAICredentialDTOProvider? Type2054 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateAzureCredentialDTO? Type2055 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateAzureCredentialDTOProvider? Type2056 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateAzureCredentialDTOService? Type2057 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateAzureCredentialDTORegion? Type2058 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateAzureOpenAICredentialDTO? Type2059 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateAzureOpenAICredentialDTOProvider? Type2060 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateAzureOpenAICredentialDTORegion? Type2061 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.UpdateAzureOpenAICredentialDTOModel>? Type2062 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateAzureOpenAICredentialDTOModel? Type2063 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateByoSipTrunkCredentialDTO? Type2064 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateByoSipTrunkCredentialDTOProvider? Type2065 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateCartesiaCredentialDTO? Type2066 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateCartesiaCredentialDTOProvider? Type2067 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateCerebrasCredentialDTO? Type2068 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateCerebrasCredentialDTOProvider? Type2069 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateCloudflareCredentialDTO? Type2070 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateCloudflareCredentialDTOProvider? Type2071 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateCustomLLMCredentialDTO? Type2072 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateCustomLLMCredentialDTOProvider? Type2073 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateDeepgramCredentialDTO? Type2074 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateDeepgramCredentialDTOProvider? Type2075 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateDeepInfraCredentialDTO? Type2076 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateDeepInfraCredentialDTOProvider? Type2077 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateDeepSeekCredentialDTO? Type2078 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateDeepSeekCredentialDTOProvider? Type2079 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateElevenLabsCredentialDTO? Type2080 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateElevenLabsCredentialDTOProvider? Type2081 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateElevenLabsCredentialDTOApiUrl? Type2082 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateGcpCredentialDTO? Type2083 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateGcpCredentialDTOProvider? Type2084 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateGladiaCredentialDTO? Type2085 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateGladiaCredentialDTOProvider? Type2086 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateGoHighLevelCredentialDTO? Type2087 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateGoHighLevelCredentialDTOProvider? Type2088 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateGoogleCredentialDTO? Type2089 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateGoogleCredentialDTOProvider? Type2090 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateGroqCredentialDTO? Type2091 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateGroqCredentialDTOProvider? Type2092 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateHumeCredentialDTO? Type2093 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateHumeCredentialDTOProvider? Type2094 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateInflectionAICredentialDTO? Type2095 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateInflectionAICredentialDTOProvider? Type2096 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateLangfuseCredentialDTO? Type2097 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateLangfuseCredentialDTOProvider? Type2098 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateLmntCredentialDTO? Type2099 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateLmntCredentialDTOProvider? Type2100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateMakeCredentialDTO? Type2101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateMakeCredentialDTOProvider? Type2102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateMicrosoftCredentialDTO? Type2103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateMicrosoftCredentialDTOProvider? Type2104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateMistralCredentialDTO? Type2105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateMistralCredentialDTOProvider? Type2106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateNeuphonicCredentialDTO? Type2107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateNeuphonicCredentialDTOProvider? Type2108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateOpenAICredentialDTO? Type2109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateOpenAICredentialDTOProvider? Type2110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateOpenRouterCredentialDTO? Type2111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateOpenRouterCredentialDTOProvider? Type2112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdatePerplexityAICredentialDTO? Type2113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdatePerplexityAICredentialDTOProvider? Type2114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdatePlayHTCredentialDTO? Type2115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdatePlayHTCredentialDTOProvider? Type2116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateRimeAICredentialDTO? Type2117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateRimeAICredentialDTOProvider? Type2118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateRunpodCredentialDTO? Type2119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateRunpodCredentialDTOProvider? Type2120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateWellSaidCredentialDTO? Type2121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateWellSaidCredentialDTOProvider? Type2122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateS3CredentialDTO? Type2123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateS3CredentialDTOProvider? Type2124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateS3CompatibleBucketPlanDTO? Type2125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateS3CompatibleCredentialDTO? Type2126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateS3CompatibleCredentialDTOProvider? Type2127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateTogetherAICredentialDTO? Type2128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateTogetherAICredentialDTOProvider? Type2129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateTwilioCredentialDTO? Type2130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateTwilioCredentialDTOProvider? Type2131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateVonageCredentialDTO? Type2132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateVonageCredentialDTOProvider? Type2133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateWebhookCredentialDTO? Type2134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateWebhookCredentialDTOProvider? Type2135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AuthenticationPlan8? Type2136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateWebhookCredentialDTOAuthenticationPlanDiscriminator? Type2137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateWebhookCredentialDTOAuthenticationPlanDiscriminatorType? Type2138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateCustomCredentialDTO? Type2139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateCustomCredentialDTOProvider? Type2140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AuthenticationPlan9? Type2141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateCustomCredentialDTOAuthenticationPlanDiscriminator? Type2142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateCustomCredentialDTOAuthenticationPlanDiscriminatorType? Type2143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateCustomCredentialDTOEncryptionPlanDiscriminator? Type2144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateCustomCredentialDTOEncryptionPlanDiscriminatorType? Type2145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateXAiCredentialDTO? Type2146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateXAiCredentialDTOProvider? Type2147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateGoogleCalendarOAuth2ClientCredentialDTO? Type2148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateGoogleCalendarOAuth2ClientCredentialDTOProvider? Type2149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateGoogleCalendarOAuth2AuthorizationCredentialDTO? Type2150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateGoogleCalendarOAuth2AuthorizationCredentialDTOProvider? Type2151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateGoogleSheetsOAuth2AuthorizationCredentialDTO? Type2152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateGoogleSheetsOAuth2AuthorizationCredentialDTOProvider? Type2153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateSlackOAuth2AuthorizationCredentialDTO? Type2154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateSlackOAuth2AuthorizationCredentialDTOProvider? Type2155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateGoHighLevelMCPCredentialDTO? Type2156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateGoHighLevelMCPCredentialDTOProvider? Type2157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateInworldCredentialDTO? Type2158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateInworldCredentialDTOProvider? Type2159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateEmailCredentialDTO? Type2160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateEmailCredentialDTOProvider? Type2161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateSlackWebhookCredentialDTO? Type2162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateSlackWebhookCredentialDTOProvider? Type2163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateSonioxCredentialDTO? Type2164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateSonioxCredentialDTOProvider? Type2165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CredentialSessionResponse? Type2166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CredentialEndUser? Type2167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CredentialSessionError? Type2168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CredentialWebhookDTO? Type2169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CredentialWebhookDTOType? Type2170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CredentialWebhookDTOOperation? Type2171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CredentialWebhookDTOAuthMode? Type2172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CredentialActionRequest? Type2173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.HMACAuthenticationPlanType? Type2174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.HMACAuthenticationPlanAlgorithm? Type2175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.HMACAuthenticationPlanSignatureEncoding? Type2176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.BearerAuthenticationPlanType? Type2177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AWSIAMCredentialsAuthenticationPlanType? Type2178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AWSStsAuthenticationPlanType? Type2179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ToolTemplateSetup? Type2180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.MakeToolProviderDetails? Type2181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.ToolTemplateSetup>? Type2182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.MakeToolProviderDetailsType? Type2183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GhlToolProviderDetails? Type2184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GhlToolProviderDetailsType? Type2185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FunctionToolProviderDetails? Type2186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FunctionToolProviderDetailsType? Type2187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GoogleCalendarCreateEventToolProviderDetails? Type2188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GoogleCalendarCreateEventToolProviderDetailsType? Type2189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GoogleSheetsRowAppendToolProviderDetails? Type2190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GoogleSheetsRowAppendToolProviderDetailsType? Type2191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GoHighLevelCalendarAvailabilityToolProviderDetails? Type2192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GoHighLevelCalendarAvailabilityToolProviderDetailsType? Type2193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GoHighLevelCalendarEventCreateToolProviderDetails? Type2194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GoHighLevelCalendarEventCreateToolProviderDetailsType? Type2195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GoHighLevelContactCreateToolProviderDetails? Type2196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GoHighLevelContactCreateToolProviderDetailsType? Type2197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GoHighLevelContactGetToolProviderDetails? Type2198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GoHighLevelContactGetToolProviderDetailsType? Type2199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ToolTemplateMetadata? Type2200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateToolTemplateDTO? Type2201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateToolTemplateDTOVisibility? Type2202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateToolTemplateDTOType? Type2203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateToolTemplateDTOProvider? Type2204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.Template? Type2205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TemplateVisibility? Type2206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TemplateType? Type2207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TemplateProvider? Type2208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateToolTemplateDTO? Type2209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateToolTemplateDTOVisibility? Type2210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateToolTemplateDTOType? Type2211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateToolTemplateDTOProvider? Type2212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.VoiceLibrary? Type2213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.VoiceLibraryGender? Type2214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SyncVoiceLibraryDTO? Type2215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.SyncVoiceLibraryDTOProvider>? Type2216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SyncVoiceLibraryDTOProvider? Type2217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateSesameVoiceDTO? Type2218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateVoiceLibraryMetadataDTO? Type2219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CartesiaPronunciationDictItem? Type2220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CartesiaPronunciationDictionary? Type2221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.CartesiaPronunciationDictItem>? Type2222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ElevenLabsPronunciationDictionary? Type2223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ElevenLabsPronunciationDictionaryPermissionOnResource? Type2224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ProviderResource? Type2225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ProviderResourceProvider? Type2226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ProviderResourceResourceName? Type2227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ProviderResourcePaginatedResponse? Type2228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.ProviderResource>? Type2229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.VoiceLibraryVoiceResponse? Type2230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OneOf<string, double?>? Type2231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AddVoiceToProviderDTO? Type2232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CloneVoiceDTO? Type2233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<byte[]>? Type2234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.VapiVoiceCloneDTO? Type2235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.VariableValueGroupBy? Type2236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TimeRange? Type2237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TimeRangeStep? Type2238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AnalyticsOperation? Type2239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AnalyticsOperationOperation? Type2240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AnalyticsOperationColumn? Type2241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AnalyticsQuery? Type2242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AnalyticsQueryTable? Type2243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.AnalyticsQueryGroupByItem>? Type2244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AnalyticsQueryGroupByItem? Type2245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.VariableValueGroupBy>? Type2246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.AnalyticsOperation>? Type2247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AnalyticsQueryDTO? Type2248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.AnalyticsQuery>? Type2249 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AnalyticsQueryResult? Type2250 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ClientMessageWorkflowNodeStarted? Type2251 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ClientMessageWorkflowNodeStartedType? Type2252 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ClientMessageAssistantStarted? Type2253 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ClientMessageAssistantStartedType? Type2254 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ClientMessageConversationUpdate? Type2255 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ClientMessageConversationUpdateType? Type2256 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ClientMessageHang? Type2257 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ClientMessageHangType? Type2258 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ClientMessageMetadata? Type2259 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ClientMessageMetadataType? Type2260 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ClientMessageModelOutput? Type2261 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ClientMessageModelOutputType? Type2262 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ClientMessageSpeechUpdate? Type2263 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ClientMessageSpeechUpdateType? Type2264 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ClientMessageSpeechUpdateStatus? Type2265 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ClientMessageSpeechUpdateRole? Type2266 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ClientMessageTranscript? Type2267 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ClientMessageTranscriptType? Type2268 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ClientMessageTranscriptRole? Type2269 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ClientMessageTranscriptTranscriptType? Type2270 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ClientMessageToolCalls? Type2271 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ClientMessageToolCallsType? Type2272 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FunctionToolWithToolCall? Type2273 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GhlToolWithToolCall? Type2274 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.MakeToolWithToolCall? Type2275 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.BashToolWithToolCall? Type2276 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ComputerToolWithToolCall? Type2277 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TextEditorToolWithToolCall? Type2278 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GoogleCalendarCreateEventToolWithToolCall? Type2279 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ClientMessageToolCallsResult? Type2280 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ClientMessageToolCallsResultType? Type2281 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ClientMessageTransferUpdate? Type2282 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ClientMessageTransferUpdateType? Type2283 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ClientMessageUserInterrupted? Type2284 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ClientMessageUserInterruptedType? Type2285 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ClientMessageLanguageChangeDetected? Type2286 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ClientMessageLanguageChangeDetectedType? Type2287 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ClientMessageVoiceInput? Type2288 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ClientMessageVoiceInputType? Type2289 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ClientMessageAssistantSpeech? Type2290 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ClientMessageAssistantSpeechType? Type2291 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ClientMessageAssistantSpeechSource? Type2292 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.Timing? Type2293 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ClientMessageAssistantSpeechTimingDiscriminator? Type2294 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ClientMessageAssistantSpeechTimingDiscriminatorType? Type2295 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ClientMessageChatCreated? Type2296 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ClientMessageChatCreatedType? Type2297 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ClientMessageChatDeleted? Type2298 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ClientMessageChatDeletedType? Type2299 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ClientMessageSessionCreated? Type2300 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ClientMessageSessionCreatedType? Type2301 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ClientMessageSessionUpdated? Type2302 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ClientMessageSessionUpdatedType? Type2303 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ClientMessageSessionDeleted? Type2304 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ClientMessageSessionDeletedType? Type2305 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ClientMessageCallDeleted? Type2306 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ClientMessageCallDeletedType? Type2307 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ClientMessageCallDeleteFailed? Type2308 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ClientMessageCallDeleteFailedType? Type2309 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ClientMessage? Type2310 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ServerMessageAssistantRequest? Type2311 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ServerMessageAssistantRequestType? Type2312 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ServerMessageConversationUpdate? Type2313 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ServerMessageConversationUpdateType? Type2314 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ServerMessageEndOfCallReport? Type2315 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ServerMessageEndOfCallReportType? Type2316 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ServerMessageEndOfCallReportEndedReason? Type2317 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ServerMessageHandoffDestinationRequest? Type2318 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ServerMessageHandoffDestinationRequestType? Type2319 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ServerMessageHang? Type2320 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ServerMessageHangType? Type2321 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ServerMessageKnowledgeBaseRequest? Type2322 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ServerMessageKnowledgeBaseRequestType? Type2323 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ServerMessageModelOutput? Type2324 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ServerMessageModelOutputType? Type2325 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ServerMessagePhoneCallControl? Type2326 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ServerMessagePhoneCallControlType? Type2327 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ServerMessagePhoneCallControlRequest? Type2328 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ServerMessageSpeechUpdate? Type2329 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ServerMessageSpeechUpdateType? Type2330 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ServerMessageSpeechUpdateStatus? Type2331 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ServerMessageSpeechUpdateRole? Type2332 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ServerMessageStatusUpdate? Type2333 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ServerMessageStatusUpdateType? Type2334 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ServerMessageStatusUpdateStatus? Type2335 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ServerMessageStatusUpdateEndedReason? Type2336 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ServerMessageToolCalls? Type2337 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ServerMessageToolCallsType? Type2338 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ServerMessageTransferDestinationRequest? Type2339 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ServerMessageTransferDestinationRequestType? Type2340 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ServerMessageTransferUpdate? Type2341 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ServerMessageTransferUpdateType? Type2342 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ServerMessageTranscript? Type2343 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ServerMessageTranscriptType? Type2344 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ServerMessageTranscriptRole? Type2345 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ServerMessageTranscriptTranscriptType? Type2346 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ServerMessageUserInterrupted? Type2347 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ServerMessageUserInterruptedType? Type2348 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ServerMessageLanguageChangeDetected? Type2349 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ServerMessageLanguageChangeDetectedType? Type2350 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ServerMessageVoiceInput? Type2351 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ServerMessageVoiceInputType? Type2352 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ServerMessageAssistantSpeech? Type2353 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ServerMessageAssistantSpeechType? Type2354 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ServerMessageAssistantSpeechSource? Type2355 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.Timing2? Type2356 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ServerMessageAssistantSpeechTimingDiscriminator? Type2357 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ServerMessageAssistantSpeechTimingDiscriminatorType? Type2358 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ServerMessageVoiceRequest? Type2359 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ServerMessageVoiceRequestType? Type2360 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ServerMessageCallEndpointingRequest? Type2361 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ServerMessageCallEndpointingRequestType? Type2362 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ServerMessageChatCreated? Type2363 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ServerMessageChatCreatedType? Type2364 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ServerMessageChatDeleted? Type2365 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ServerMessageChatDeletedType? Type2366 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ServerMessageSessionCreated? Type2367 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ServerMessageSessionCreatedType? Type2368 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ServerMessageSessionUpdated? Type2369 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ServerMessageSessionUpdatedType? Type2370 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ServerMessageSessionDeleted? Type2371 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ServerMessageSessionDeletedType? Type2372 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ServerMessageCallDeleted? Type2373 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ServerMessageCallDeletedType? Type2374 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ServerMessageCallDeleteFailed? Type2375 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ServerMessageCallDeleteFailedType? Type2376 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CallArtifactUploadItem? Type2377 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CallArtifactUploadItemType? Type2378 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ServerMessageCallArtifactUpload? Type2379 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ServerMessageCallArtifactUploadType? Type2380 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.CallArtifactUploadItem>? Type2381 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CampaignContact? Type2382 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ServerMessageCampaignPredial? Type2383 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ServerMessageCampaignPredialType? Type2384 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ServerMessage? Type2385 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ServerMessageResponseAssistantRequest? Type2386 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ServerMessageResponseHandoffDestinationRequest? Type2387 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.KnowledgeBaseResponseDocument? Type2388 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ServerMessageResponseKnowledgeBaseRequest? Type2389 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.KnowledgeBaseResponseDocument>? Type2390 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ToolCallResult? Type2391 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OneOf<global::Vapi.ToolMessageComplete, global::Vapi.ToolMessageFailed>? Type2392 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ServerMessageResponseToolCalls? Type2393 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.ToolCallResult>? Type2394 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ServerMessageResponseTransferDestinationRequest? Type2395 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ServerMessageResponseVoiceRequest? Type2396 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ServerMessageResponseCallEndpointingRequest? Type2397 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ServerMessageResponseCampaignPredial? Type2398 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ServerMessageResponse? Type2399 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ClientInboundMessageAddMessage? Type2400 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ClientInboundMessageAddMessageType? Type2401 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ClientInboundMessageControl? Type2402 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ClientInboundMessageControlType? Type2403 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ClientInboundMessageControlControl? Type2404 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ClientInboundMessageSay? Type2405 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ClientInboundMessageSayType? Type2406 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ClientInboundMessageEndCall? Type2407 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ClientInboundMessageEndCallType? Type2408 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ClientInboundMessageTransfer? Type2409 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ClientInboundMessageTransferType? Type2410 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ClientInboundMessageSendTransportMessage? Type2411 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ClientInboundMessageSendTransportMessageType? Type2412 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OneOf<global::Vapi.VapiSipTransportMessage, global::Vapi.TwilioTransportMessage>? Type2413 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.VapiSipTransportMessage? Type2414 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TwilioTransportMessage? Type2415 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ClientInboundMessage? Type2416 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.KnowledgeBaseCostType? Type2417 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SessionCostType? Type2418 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.FunctionToolWithToolCallType? Type2419 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GhlToolWithToolCallType? Type2420 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.MakeToolWithToolCallType? Type2421 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.BashToolWithToolCallType? Type2422 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.BashToolWithToolCallSubType? Type2423 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.BashToolWithToolCallName? Type2424 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ComputerToolWithToolCallType? Type2425 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ComputerToolWithToolCallSubType? Type2426 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ComputerToolWithToolCallName? Type2427 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TextEditorToolWithToolCallType? Type2428 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TextEditorToolWithToolCallSubType? Type2429 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TextEditorToolWithToolCallName? Type2430 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GoogleCalendarCreateEventToolWithToolCallType? Type2431 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GoogleSheetsRowAppendToolWithToolCall? Type2432 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GoogleSheetsRowAppendToolWithToolCallType? Type2433 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GoHighLevelCalendarAvailabilityToolWithToolCall? Type2434 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GoHighLevelCalendarAvailabilityToolWithToolCallType? Type2435 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GoHighLevelCalendarEventCreateToolWithToolCall? Type2436 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GoHighLevelCalendarEventCreateToolWithToolCallType? Type2437 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GoHighLevelContactCreateToolWithToolCall? Type2438 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GoHighLevelContactCreateToolWithToolCallType? Type2439 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GoHighLevelContactGetToolWithToolCall? Type2440 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.GoHighLevelContactGetToolWithToolCallType? Type2441 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.VapiSipTransportMessageTransport? Type2442 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.VapiSipTransportMessageSipVerb? Type2443 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TwilioTransportMessageTransport? Type2444 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.PhoneNumberControllerCreateRequest? Type2445 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.PhoneNumberControllerCreateRequestDiscriminator? Type2446 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.PhoneNumberControllerCreateRequestDiscriminatorProvider? Type2447 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.PhoneNumberControllerUpdateRequest? Type2448 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.PhoneNumberControllerUpdateRequestDiscriminator? Type2449 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.PhoneNumberControllerUpdateRequestDiscriminatorProvider? Type2450 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ToolControllerCreateRequest? Type2451 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ToolControllerCreateRequestDiscriminator? Type2452 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ToolControllerCreateRequestDiscriminatorType? Type2453 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ToolControllerUpdateRequest? Type2454 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ToolControllerUpdateRequestDiscriminator? Type2455 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ToolControllerUpdateRequestDiscriminatorType? Type2456 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.InsightControllerCreateRequest? Type2457 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.InsightControllerCreateRequestDiscriminator? Type2458 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.InsightControllerCreateRequestDiscriminatorType? Type2459 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.InsightControllerUpdateRequest? Type2460 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.InsightControllerUpdateRequestDiscriminator? Type2461 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.InsightControllerUpdateRequestDiscriminatorType? Type2462 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.InsightControllerPreviewRequest? Type2463 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.InsightControllerPreviewRequestDiscriminator? Type2464 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.InsightControllerPreviewRequestDiscriminatorType? Type2465 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ChatControllerListChatsSortOrder? Type2466 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ChatControllerListChatsSortBy? Type2467 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CampaignControllerFindAllStatus? Type2468 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CampaignControllerFindAllSortOrder? Type2469 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CampaignControllerFindAllSortBy? Type2470 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CampaignControllerFindAllV2Status? Type2471 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CampaignControllerFindAllV2SortOrder? Type2472 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CampaignControllerFindAllV2SortBy? Type2473 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.CampaignControllerGetCampaignV2ContactsStatu>? Type2474 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CampaignControllerGetCampaignV2ContactsStatu? Type2475 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CampaignControllerGetCampaignV2ContactsSortBy? Type2476 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SessionControllerFindAllPaginatedSortOrder? Type2477 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SessionControllerFindAllPaginatedSortBy? Type2478 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.PhoneNumberControllerFindAllPaginatedSortOrder? Type2479 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.PhoneNumberControllerFindAllPaginatedSortBy? Type2480 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.StructuredOutputControllerFindAllSortOrder? Type2481 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.StructuredOutputControllerFindAllSortBy? Type2482 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.PersonalityControllerFindAllSortOrder? Type2483 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.PersonalityControllerFindAllSortBy? Type2484 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ScenarioControllerFindAllSortOrder? Type2485 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ScenarioControllerFindAllSortBy? Type2486 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SimulationRunControllerFindAllStatus? Type2487 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SimulationRunControllerFindAllFilterStatus? Type2488 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SimulationRunControllerFindAllTargetType? Type2489 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SimulationRunControllerFindAllSortOrder? Type2490 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SimulationRunControllerFindAllSortBy? Type2491 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SimulationRunControllerFindItemsStatus? Type2492 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SimulationRunControllerFindItemsSortOrder? Type2493 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SimulationRunControllerFindItemsSortBy? Type2494 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SimulationSuiteControllerFindAllSortOrder? Type2495 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SimulationSuiteControllerFindAllSortBy? Type2496 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SimulationControllerFindAllSortOrder? Type2497 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.SimulationControllerFindAllSortBy? Type2498 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.InsightControllerFindAllSortOrder? Type2499 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.InsightControllerFindAllSortBy? Type2500 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.BoardControllerFindAllSortOrder? Type2501 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.BoardControllerFindAllSortBy? Type2502 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.EvalControllerGetPaginatedSortOrder? Type2503 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.EvalControllerGetPaginatedSortBy? Type2504 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.EvalControllerGetRunsPaginatedSortOrder? Type2505 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.EvalControllerGetRunsPaginatedSortBy? Type2506 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ScorecardControllerGetPaginatedSortOrder? Type2507 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ScorecardControllerGetPaginatedSortBy? Type2508 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ProviderResourceControllerCreateProviderResourceProvider? Type2509 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ProviderResourceControllerCreateProviderResourceResourceName? Type2510 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ProviderResourceControllerGetProviderResourcesPaginatedProvider? Type2511 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ProviderResourceControllerGetProviderResourcesPaginatedResourceName? Type2512 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ProviderResourceControllerGetProviderResourcesPaginatedSortOrder? Type2513 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ProviderResourceControllerGetProviderResourcesPaginatedSortBy? Type2514 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ProviderResourceControllerGetProviderResourceProvider? Type2515 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ProviderResourceControllerGetProviderResourceResourceName? Type2516 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ProviderResourceControllerDeleteProviderResourceProvider? Type2517 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ProviderResourceControllerDeleteProviderResourceResourceName? Type2518 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ProviderResourceControllerUpdateProviderResourceProvider? Type2519 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ProviderResourceControllerUpdateProviderResourceResourceName? Type2520 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.Squad>? Type2521 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OneOf<global::Vapi.Call, global::Vapi.CallBatchResponse>? Type2522 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OneOf<global::Vapi.Chat, global::Vapi.CreateChatStreamResponse>? Type2523 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OneOf<global::Vapi.ResponseObject, global::Vapi.ResponseTextDeltaEvent, global::Vapi.ResponseTextDoneEvent, global::Vapi.ResponseCompletedEvent, global::Vapi.ResponseErrorEvent>? Type2524 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.PhoneNumberControllerCreateResponse? Type2525 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.PhoneNumberControllerCreateResponseDiscriminator? Type2526 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.PhoneNumberControllerCreateResponseDiscriminatorProvider? Type2527 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.PhoneNumberControllerFindAllResponseItem>? Type2528 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.PhoneNumberControllerFindAllResponseItem? Type2529 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.PhoneNumberControllerFindAllResponseItemDiscriminator? Type2530 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.PhoneNumberControllerFindAllResponseItemDiscriminatorProvider? Type2531 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.PhoneNumberControllerFindOneResponse? Type2532 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.PhoneNumberControllerFindOneResponseDiscriminator? Type2533 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.PhoneNumberControllerFindOneResponseDiscriminatorProvider? Type2534 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.PhoneNumberControllerUpdateResponse? Type2535 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.PhoneNumberControllerUpdateResponseDiscriminator? Type2536 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.PhoneNumberControllerUpdateResponseDiscriminatorProvider? Type2537 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.PhoneNumberControllerRemoveResponse? Type2538 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.PhoneNumberControllerRemoveResponseDiscriminator? Type2539 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.PhoneNumberControllerRemoveResponseDiscriminatorProvider? Type2540 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ToolControllerCreateResponse? Type2541 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ToolControllerCreateResponseDiscriminator? Type2542 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ToolControllerCreateResponseDiscriminatorType? Type2543 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.ToolControllerFindAllResponseItem>? Type2544 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ToolControllerFindAllResponseItem? Type2545 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ToolControllerFindAllResponseItemDiscriminator? Type2546 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ToolControllerFindAllResponseItemDiscriminatorType? Type2547 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ToolControllerFindOneResponse? Type2548 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ToolControllerFindOneResponseDiscriminator? Type2549 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ToolControllerFindOneResponseDiscriminatorType? Type2550 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ToolControllerUpdateResponse? Type2551 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ToolControllerUpdateResponseDiscriminator? Type2552 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ToolControllerUpdateResponseDiscriminatorType? Type2553 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ToolControllerRemoveResponse? Type2554 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ToolControllerRemoveResponseDiscriminator? Type2555 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ToolControllerRemoveResponseDiscriminatorType? Type2556 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.File>? Type2557 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.KnowledgeBaseV2>? Type2558 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OneOf<global::Vapi.AllOf<global::Vapi.StructuredOutputRunPreviewResponse, object>?, global::Vapi.StructuredOutputRerunResponse>? Type2559 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AllOf<global::Vapi.StructuredOutputRunPreviewResponse, object>? Type2560 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.Personality>? Type2561 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.Scenario>? Type2562 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OneOf<global::System.Collections.Generic.IList<global::Vapi.SimulationRun>, global::Vapi.SimulationRunsPaginatedResponse>? Type2563 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.SimulationRun>? Type2564 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.SimulationRunItem>? Type2565 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.SimulationSuite>? Type2566 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.Simulation>? Type2567 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.InsightControllerCreateResponse? Type2568 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.InsightControllerCreateResponseDiscriminator? Type2569 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.InsightControllerCreateResponseDiscriminatorType? Type2570 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.InsightControllerUpdateResponse? Type2571 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.InsightControllerUpdateResponseDiscriminator? Type2572 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.InsightControllerUpdateResponseDiscriminatorType? Type2573 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.InsightControllerFindOneResponse? Type2574 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.InsightControllerFindOneResponseDiscriminator? Type2575 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.InsightControllerFindOneResponseDiscriminatorType? Type2576 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.InsightControllerRemoveResponse? Type2577 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.InsightControllerRemoveResponseDiscriminator? Type2578 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.InsightControllerRemoveResponseDiscriminatorType? Type2579 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vapi.AnalyticsQueryResult>? Type2580 { get; set; }

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
        public global::System.Collections.Generic.List<global::Vapi.OpenAISpeakerPersonalityPack>? ListType31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.OpenAIModelFallbackModel>? ListType32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.TwilioVoicemailDetectionPlanVoicemailDetectionType>? ListType33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OneOf<string, global::System.Collections.Generic.List<string>>? ListType34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OneOf<string, global::System.Collections.Generic.List<global::Vapi.OneOf<global::Vapi.SystemMessage, global::Vapi.UserMessage, global::Vapi.AssistantMessage, global::Vapi.ToolMessage, global::Vapi.DeveloperMessage>>>? ListType35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.OneOf<global::Vapi.SystemMessage, global::Vapi.UserMessage, global::Vapi.AssistantMessage, global::Vapi.ToolMessage, global::Vapi.DeveloperMessage>>? ListType36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.OneOf<global::Vapi.ToolCallHookAction, global::Vapi.MessageAddHookAction>>? ListType37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.CallHookFilter>? ListType38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.OneOf<global::Vapi.SayHookAction, global::Vapi.ToolCallHookAction, global::Vapi.MessageAddHookAction>>? ListType39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.SecurityFilterBase>? ListType40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.StructuredDataMultiPlan>? ListType41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.OneOf<global::Vapi.MinMessagesCondition, global::Vapi.MinCallDurationCondition, global::Vapi.EndedReasonCondition>>? ListType42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.OneOf<global::Vapi.NumberComparatorScorecardMetricCondition, global::Vapi.BooleanComparatorScorecardMetricCondition>>? ListType43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.ScorecardMetric>? ListType44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.CreateStructuredOutputDTO>? ListType45 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.CreateScorecardDTO>? ListType46 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.OneOf<global::Vapi.ConversationNode, global::Vapi.ToolNode>>? ListType47 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.CredentialsItem>? ListType48 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.Edge>? ListType49 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.OneOf<global::Vapi.ExactReplacement, global::Vapi.RegexReplacement>>? ListType50 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.FormatPlanFormattersEnabledItem>? ListType51 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.ChunkPlanPunctuationBoundarie>? ListType52 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.ElevenLabsPronunciationDictionaryLocator>? ListType53 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.VapiPronunciationDictionaryLocator>? ListType54 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.CreateAzureOpenAICredentialDTOModel>? ListType55 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.SipTrunkGateway>? ListType56 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.ToolCallHookAction>? ListType57 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.AssistantOverridesClientMessage>? ListType58 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.AssistantOverridesServerMessage>? ListType59 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.TransportConfigurationTwilio>? ListType60 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.CredentialsItem2>? ListType61 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.CreateAssistantDTOClientMessage>? ListType62 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.CreateAssistantDTOServerMessage>? ListType63 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.CredentialsItem3>? ListType64 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.AssistantClientMessage>? ListType65 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.AssistantServerMessage>? ListType66 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.CredentialsItem4>? ListType67 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.Assistant>? ListType68 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.AssistantDraftClientMessage>? ListType69 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.AssistantDraftServerMessage>? ListType70 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.CredentialsItem5>? ListType71 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.AssistantDraft>? ListType72 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.LegacyAssistantVersion>? ListType73 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.AssistantVersionClientMessage>? ListType74 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.AssistantVersionServerMessage>? ListType75 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.CredentialsItem6>? ListType76 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.AssistantVersion>? ListType77 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.VersionPinReference>? ListType78 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.CreateAssistantDraftDTOClientMessage>? ListType79 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.CreateAssistantDraftDTOServerMessage>? ListType80 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.CredentialsItem7>? ListType81 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.UpdateAssistantDraftDTOClientMessage>? ListType82 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.UpdateAssistantDraftDTOServerMessage>? ListType83 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.CredentialsItem8>? ListType84 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.UpdateAssistantDTOClientMessage>? ListType85 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.UpdateAssistantDTOServerMessage>? ListType86 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.CredentialsItem9>? ListType87 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.CredentialsItem10>? ListType88 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.CredentialsItem11>? ListType89 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.CredentialsItem12>? ListType90 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.ToolCallResultMessageWarning>? ListType91 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.StructuredOutputCostBreakdown>? ListType92 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.MonitorResult>? ListType93 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.OneOf<global::Vapi.UserMessage, global::Vapi.SystemMessage, global::Vapi.BotMessage, global::Vapi.ToolCallMessage, global::Vapi.ToolCallResultMessage>>? ListType94 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.TurnLatency>? ListType95 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.TransferArtifact>? ListType96 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.NodeArtifact>? ListType97 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.AssistantActivation>? ListType98 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.PhoneNumberCallRingingHookFilter>? ListType99 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.OneOf<global::Vapi.TransferPhoneNumberHookAction, global::Vapi.SayPhoneNumberHookAction>>? ListType100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.PhoneNumberCallEndingHookFilterOneOfItem>? ListType101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.PhoneNumberCallEndingHookFilter>? ListType102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.OneOf<global::Vapi.PhoneNumberHookCallRinging, global::Vapi.PhoneNumberHookCallEnding>>? ListType103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.Call>? ListType104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.CallBatchError>? ListType105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<double>? ListType106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.AssistantSpeechWordTimestamp>? ListType107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.CreateCustomerDTO>? ListType108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.ToolCall>? ListType109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.OneOf<global::Vapi.ModelCost, global::Vapi.ChatCost>>? ListType110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.Chat>? ListType111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.ResponseOutputText>? ListType112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.ResponseOutputMessage>? ListType113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.DialPlanEntry>? ListType114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.CreateCampaignDTOServerMessage>? ListType115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.CampaignServerMessage>? ListType116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.Campaign>? ListType117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.CampaignSummaryServerMessage>? ListType118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.CampaignSummary>? ListType119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.CampaignContactWithOutcome>? ListType120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.OneOf<global::Vapi.RelayCommandSay, global::Vapi.RelayCommandNote>>? ListType121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.OneOf<global::Vapi.ModelCost, global::Vapi.AnalysisCost, global::Vapi.SessionCost>>? ListType122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.Session>? ListType123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.OneOf<global::Vapi.ByoPhoneNumber, global::Vapi.TwilioPhoneNumber, global::Vapi.VonagePhoneNumber, global::Vapi.VapiPhoneNumber, global::Vapi.TelnyxPhoneNumber>>? ListType124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.CodeToolEnvironmentVariable>? ListType125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.ToolVersion>? ListType126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.ToolDraft>? ListType127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.KnowledgeBaseV2File>? ListType128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.StructuredOutput>? ListType129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.TestSuite>? ListType130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.TestSuiteTestScorerAI>? ListType131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.OneOf<global::Vapi.TestSuiteTestVoice, global::Vapi.TestSuiteTestChat>>? ListType132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.TestSuiteRunScorerAI>? ListType133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.TestSuiteRunTestAttempt>? ListType134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.TestSuiteRunTestResult>? ListType135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.TestSuiteRun>? ListType136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.SimulationHookWebhookAction>? ListType137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.EvaluationPlanItem>? ListType138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.OneOf<global::Vapi.SimulationHookCallStarted, global::Vapi.SimulationHookCallEnded>>? ListType139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.ScenarioToolMock>? ListType140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.OneOf<global::Vapi.SimulationRunSimulationEntry, global::Vapi.SimulationRunSuiteEntry>>? ListType141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.SimulationRunListItem>? ListType142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.StructuredOutputEvaluationResult>? ListType143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.SimulationRunItemImprovementSuggestion>? ListType144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.SimulationSuiteTargetAssignment>? ListType145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.GeneratedScenario>? ListType146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.InsightFormula>? ListType147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.OneOf<global::Vapi.EventsTableStringCondition, global::Vapi.EventsTableNumberCondition, global::Vapi.EventsTableBooleanCondition>>? ListType148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.Insight>? ListType149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.OneOf<global::Vapi.BoardInsightItem, global::Vapi.BoardMetricWidgetItem>>? ListType150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.Board>? ListType151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.ChatEvalAssistantMessageMockToolCall>? ListType152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.Eval>? ListType153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.EvalRunResult>? ListType154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.EvalRun>? ListType155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.Scorecard>? ListType156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.PendingInvitationDTO>? ListType157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.AzureOpenAICredentialModel>? ListType158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.UpdateAzureOpenAICredentialDTOModel>? ListType159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.ToolTemplateSetup>? ListType160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.SyncVoiceLibraryDTOProvider>? ListType161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.CartesiaPronunciationDictItem>? ListType162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.ProviderResource>? ListType163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<byte[]>? ListType164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.AnalyticsQueryGroupByItem>? ListType165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.VariableValueGroupBy>? ListType166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.AnalyticsOperation>? ListType167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.AnalyticsQuery>? ListType168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.CallArtifactUploadItem>? ListType169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.KnowledgeBaseResponseDocument>? ListType170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.ToolCallResult>? ListType171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.CampaignControllerGetCampaignV2ContactsStatu>? ListType172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.Squad>? ListType173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.PhoneNumberControllerFindAllResponseItem>? ListType174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.ToolControllerFindAllResponseItem>? ListType175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.File>? ListType176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.KnowledgeBaseV2>? ListType177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.Personality>? ListType178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.Scenario>? ListType179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.OneOf<global::System.Collections.Generic.List<global::Vapi.SimulationRun>, global::Vapi.SimulationRunsPaginatedResponse>? ListType180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.SimulationRun>? ListType181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.SimulationRunItem>? ListType182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.SimulationSuite>? ListType183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.Simulation>? ListType184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vapi.AnalyticsQueryResult>? ListType185 { get; set; }
    }
}