#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vapi
{
    /// <summary>
    /// Optional timing metadata. Shape depends on `timing.type`:<br/>
    /// - `word-alignment` (ElevenLabs): per-character timing at playback<br/>
    ///   cadence. words[] includes space entries. Best consumed by tracking<br/>
    ///   a running character count: join timing.words, add to a char cursor,<br/>
    ///   and highlight text up to that position. No interpolation needed.<br/>
    /// - `word-progress` (Minimax with voice.subtitleType: 'word'): cursor-<br/>
    ///   based word count per TTS segment. Use wordsSpoken as the anchor,<br/>
    ///   interpolate forward using segmentDurationMs or timing.words until<br/>
    ///   the next event arrives.<br/>
    /// When absent, the event is a text-only fallback for providers without<br/>
    /// word-level timing (e.g. Cartesia, Deepgram, Azure). Text emits once<br/>
    /// per TTS chunk when audio is playing. Optionally interpolate a word<br/>
    /// cursor at ~3.5 words/sec between events for approximate tracking.
    /// </summary>
    public readonly partial struct Timing : global::System.IEquatable<Timing>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vapi.AssistantSpeechWordAlignmentTiming? WordAlignment { get; init; }
#else
        public global::Vapi.AssistantSpeechWordAlignmentTiming? WordAlignment { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WordAlignment))]
#endif
        public bool IsWordAlignment => WordAlignment != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vapi.AssistantSpeechWordProgressTiming? WordProgress { get; init; }
#else
        public global::Vapi.AssistantSpeechWordProgressTiming? WordProgress { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WordProgress))]
#endif
        public bool IsWordProgress => WordProgress != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Timing(global::Vapi.AssistantSpeechWordAlignmentTiming value) => new Timing((global::Vapi.AssistantSpeechWordAlignmentTiming?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vapi.AssistantSpeechWordAlignmentTiming?(Timing @this) => @this.WordAlignment;

        /// <summary>
        /// 
        /// </summary>
        public Timing(global::Vapi.AssistantSpeechWordAlignmentTiming? value)
        {
            WordAlignment = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Timing(global::Vapi.AssistantSpeechWordProgressTiming value) => new Timing((global::Vapi.AssistantSpeechWordProgressTiming?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vapi.AssistantSpeechWordProgressTiming?(Timing @this) => @this.WordProgress;

        /// <summary>
        /// 
        /// </summary>
        public Timing(global::Vapi.AssistantSpeechWordProgressTiming? value)
        {
            WordProgress = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public Timing(
            global::Vapi.AssistantSpeechWordAlignmentTiming? wordAlignment,
            global::Vapi.AssistantSpeechWordProgressTiming? wordProgress
            )
        {
            WordAlignment = wordAlignment;
            WordProgress = wordProgress;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            WordProgress as object ??
            WordAlignment as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            WordAlignment?.ToString() ??
            WordProgress?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsWordAlignment && !IsWordProgress || !IsWordAlignment && IsWordProgress;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vapi.AssistantSpeechWordAlignmentTiming?, TResult>? wordAlignment = null,
            global::System.Func<global::Vapi.AssistantSpeechWordProgressTiming?, TResult>? wordProgress = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsWordAlignment && wordAlignment != null)
            {
                return wordAlignment(WordAlignment!);
            }
            else if (IsWordProgress && wordProgress != null)
            {
                return wordProgress(WordProgress!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Vapi.AssistantSpeechWordAlignmentTiming?>? wordAlignment = null,
            global::System.Action<global::Vapi.AssistantSpeechWordProgressTiming?>? wordProgress = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsWordAlignment)
            {
                wordAlignment?.Invoke(WordAlignment!);
            }
            else if (IsWordProgress)
            {
                wordProgress?.Invoke(WordProgress!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                WordAlignment,
                typeof(global::Vapi.AssistantSpeechWordAlignmentTiming),
                WordProgress,
                typeof(global::Vapi.AssistantSpeechWordProgressTiming),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;

            return global::System.Linq.Enumerable.Aggregate(fields, offset, HashCodeAggregator);
        }

        /// <summary>
        /// 
        /// </summary>
        public bool Equals(Timing other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vapi.AssistantSpeechWordAlignmentTiming?>.Default.Equals(WordAlignment, other.WordAlignment) &&
                global::System.Collections.Generic.EqualityComparer<global::Vapi.AssistantSpeechWordProgressTiming?>.Default.Equals(WordProgress, other.WordProgress) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(Timing obj1, Timing obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Timing>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(Timing obj1, Timing obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Timing o && Equals(o);
        }
    }
}
