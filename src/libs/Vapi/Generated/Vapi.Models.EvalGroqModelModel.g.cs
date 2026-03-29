
#nullable enable

namespace Vapi
{
    /// <summary>
    /// This is the name of the model. Ex. gpt-4o
    /// </summary>
    public enum EvalGroqModelModel
    {
        /// <summary>
        /// 
        /// </summary>
        CompoundBeta,
        /// <summary>
        /// 
        /// </summary>
        CompoundBetaMini,
        /// <summary>
        /// 
        /// </summary>
        DeepseekR1DistillLlama70b,
        /// <summary>
        /// 
        /// </summary>
        Gemma29bIt,
        /// <summary>
        /// 
        /// </summary>
        Llama31405bReasoning,
        /// <summary>
        /// 
        /// </summary>
        Llama318bInstant,
        /// <summary>
        /// 
        /// </summary>
        Llama3370bVersatile,
        /// <summary>
        /// 
        /// </summary>
        Llama370b8192,
        /// <summary>
        /// 
        /// </summary>
        Llama38b8192,
        /// <summary>
        /// 
        /// </summary>
        MetaLlamaDividellama4Maverick17b128eInstruct,
        /// <summary>
        /// 
        /// </summary>
        MetaLlamaDividellama4Scout17b16eInstruct,
        /// <summary>
        /// 
        /// </summary>
        MistralSaba24b,
        /// <summary>
        /// 
        /// </summary>
        MoonshotaiDividekimiK2Instruct0905,
        /// <summary>
        /// 
        /// </summary>
        OpenaiDividegptOss120b,
        /// <summary>
        /// 
        /// </summary>
        OpenaiDividegptOss20b,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EvalGroqModelModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EvalGroqModelModel value)
        {
            return value switch
            {
                EvalGroqModelModel.CompoundBeta => "compound-beta",
                EvalGroqModelModel.CompoundBetaMini => "compound-beta-mini",
                EvalGroqModelModel.DeepseekR1DistillLlama70b => "deepseek-r1-distill-llama-70b",
                EvalGroqModelModel.Gemma29bIt => "gemma2-9b-it",
                EvalGroqModelModel.Llama31405bReasoning => "llama-3.1-405b-reasoning",
                EvalGroqModelModel.Llama318bInstant => "llama-3.1-8b-instant",
                EvalGroqModelModel.Llama3370bVersatile => "llama-3.3-70b-versatile",
                EvalGroqModelModel.Llama370b8192 => "llama3-70b-8192",
                EvalGroqModelModel.Llama38b8192 => "llama3-8b-8192",
                EvalGroqModelModel.MetaLlamaDividellama4Maverick17b128eInstruct => "meta-llama/llama-4-maverick-17b-128e-instruct",
                EvalGroqModelModel.MetaLlamaDividellama4Scout17b16eInstruct => "meta-llama/llama-4-scout-17b-16e-instruct",
                EvalGroqModelModel.MistralSaba24b => "mistral-saba-24b",
                EvalGroqModelModel.MoonshotaiDividekimiK2Instruct0905 => "moonshotai/kimi-k2-instruct-0905",
                EvalGroqModelModel.OpenaiDividegptOss120b => "openai/gpt-oss-120b",
                EvalGroqModelModel.OpenaiDividegptOss20b => "openai/gpt-oss-20b",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EvalGroqModelModel? ToEnum(string value)
        {
            return value switch
            {
                "compound-beta" => EvalGroqModelModel.CompoundBeta,
                "compound-beta-mini" => EvalGroqModelModel.CompoundBetaMini,
                "deepseek-r1-distill-llama-70b" => EvalGroqModelModel.DeepseekR1DistillLlama70b,
                "gemma2-9b-it" => EvalGroqModelModel.Gemma29bIt,
                "llama-3.1-405b-reasoning" => EvalGroqModelModel.Llama31405bReasoning,
                "llama-3.1-8b-instant" => EvalGroqModelModel.Llama318bInstant,
                "llama-3.3-70b-versatile" => EvalGroqModelModel.Llama3370bVersatile,
                "llama3-70b-8192" => EvalGroqModelModel.Llama370b8192,
                "llama3-8b-8192" => EvalGroqModelModel.Llama38b8192,
                "meta-llama/llama-4-maverick-17b-128e-instruct" => EvalGroqModelModel.MetaLlamaDividellama4Maverick17b128eInstruct,
                "meta-llama/llama-4-scout-17b-16e-instruct" => EvalGroqModelModel.MetaLlamaDividellama4Scout17b16eInstruct,
                "mistral-saba-24b" => EvalGroqModelModel.MistralSaba24b,
                "moonshotai/kimi-k2-instruct-0905" => EvalGroqModelModel.MoonshotaiDividekimiK2Instruct0905,
                "openai/gpt-oss-120b" => EvalGroqModelModel.OpenaiDividegptOss120b,
                "openai/gpt-oss-20b" => EvalGroqModelModel.OpenaiDividegptOss20b,
                _ => null,
            };
        }
    }
}