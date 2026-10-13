#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vapi
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct AssistantControllerRemoveResponse : global::System.IEquatable<AssistantControllerRemoveResponse>
    {
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AssistantControllerRemoveResponseDiscriminatorError? Error { get; }

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vapi.AssistantPinnedConflictResponseDTO? AssistantPinned { get; init; }
#else
        public global::Vapi.AssistantPinnedConflictResponseDTO? AssistantPinned { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AssistantPinned))]
#endif
        public bool IsAssistantPinned => AssistantPinned != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAssistantPinned(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vapi.AssistantPinnedConflictResponseDTO? value)
        {
            value = AssistantPinned;
            return IsAssistantPinned;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AssistantPinnedConflictResponseDTO PickAssistantPinned() => AssistantPinned is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'AssistantPinned' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vapi.AssistantManagedConflictResponseDTO? AssistantManagedByVapiAgents { get; init; }
#else
        public global::Vapi.AssistantManagedConflictResponseDTO? AssistantManagedByVapiAgents { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AssistantManagedByVapiAgents))]
#endif
        public bool IsAssistantManagedByVapiAgents => AssistantManagedByVapiAgents != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAssistantManagedByVapiAgents(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vapi.AssistantManagedConflictResponseDTO? value)
        {
            value = AssistantManagedByVapiAgents;
            return IsAssistantManagedByVapiAgents;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AssistantManagedConflictResponseDTO PickAssistantManagedByVapiAgents() => AssistantManagedByVapiAgents is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'AssistantManagedByVapiAgents' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator AssistantControllerRemoveResponse(global::Vapi.AssistantPinnedConflictResponseDTO value) => new AssistantControllerRemoveResponse((global::Vapi.AssistantPinnedConflictResponseDTO?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vapi.AssistantPinnedConflictResponseDTO?(AssistantControllerRemoveResponse @this) => @this.AssistantPinned;

        /// <summary>
        ///
        /// </summary>
        public AssistantControllerRemoveResponse(global::Vapi.AssistantPinnedConflictResponseDTO? value)
        {
            AssistantPinned = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AssistantControllerRemoveResponse FromAssistantPinned(global::Vapi.AssistantPinnedConflictResponseDTO? value) => new AssistantControllerRemoveResponse(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator AssistantControllerRemoveResponse(global::Vapi.AssistantManagedConflictResponseDTO value) => new AssistantControllerRemoveResponse((global::Vapi.AssistantManagedConflictResponseDTO?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vapi.AssistantManagedConflictResponseDTO?(AssistantControllerRemoveResponse @this) => @this.AssistantManagedByVapiAgents;

        /// <summary>
        ///
        /// </summary>
        public AssistantControllerRemoveResponse(global::Vapi.AssistantManagedConflictResponseDTO? value)
        {
            AssistantManagedByVapiAgents = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AssistantControllerRemoveResponse FromAssistantManagedByVapiAgents(global::Vapi.AssistantManagedConflictResponseDTO? value) => new AssistantControllerRemoveResponse(value);

        /// <summary>
        ///
        /// </summary>
        public AssistantControllerRemoveResponse(
            global::Vapi.AssistantControllerRemoveResponseDiscriminatorError? error,
            global::Vapi.AssistantPinnedConflictResponseDTO? assistantPinned,
            global::Vapi.AssistantManagedConflictResponseDTO? assistantManagedByVapiAgents
            )
        {
            Error = error;

            AssistantPinned = assistantPinned;
            AssistantManagedByVapiAgents = assistantManagedByVapiAgents;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            AssistantManagedByVapiAgents as object ??
            AssistantPinned as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            AssistantPinned?.ToString() ??
            AssistantManagedByVapiAgents?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsAssistantPinned && !IsAssistantManagedByVapiAgents || !IsAssistantPinned && IsAssistantManagedByVapiAgents;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vapi.AssistantPinnedConflictResponseDTO, TResult>? assistantPinned = null,
            global::System.Func<global::Vapi.AssistantManagedConflictResponseDTO, TResult>? assistantManagedByVapiAgents = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (AssistantPinned is { } __value0 && assistantPinned != null)
            {
                return assistantPinned(__value0);
            }
            else if (AssistantManagedByVapiAgents is { } __value1 && assistantManagedByVapiAgents != null)
            {
                return assistantManagedByVapiAgents(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Vapi.AssistantPinnedConflictResponseDTO>? assistantPinned = null,

            global::System.Action<global::Vapi.AssistantManagedConflictResponseDTO>? assistantManagedByVapiAgents = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (AssistantPinned is { } __value0)
            {
                assistantPinned?.Invoke(__value0);
            }
            else if (AssistantManagedByVapiAgents is { } __value1)
            {
                assistantManagedByVapiAgents?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Vapi.AssistantPinnedConflictResponseDTO>? assistantPinned = null,
            global::System.Action<global::Vapi.AssistantManagedConflictResponseDTO>? assistantManagedByVapiAgents = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (AssistantPinned is { } __value0)
            {
                assistantPinned?.Invoke(__value0);
            }
            else if (AssistantManagedByVapiAgents is { } __value1)
            {
                assistantManagedByVapiAgents?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                AssistantPinned,
                typeof(global::Vapi.AssistantPinnedConflictResponseDTO),
                AssistantManagedByVapiAgents,
                typeof(global::Vapi.AssistantManagedConflictResponseDTO),
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
        public bool Equals(AssistantControllerRemoveResponse other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vapi.AssistantPinnedConflictResponseDTO?>.Default.Equals(AssistantPinned, other.AssistantPinned) &&
                global::System.Collections.Generic.EqualityComparer<global::Vapi.AssistantManagedConflictResponseDTO?>.Default.Equals(AssistantManagedByVapiAgents, other.AssistantManagedByVapiAgents)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(AssistantControllerRemoveResponse obj1, AssistantControllerRemoveResponse obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<AssistantControllerRemoveResponse>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(AssistantControllerRemoveResponse obj1, AssistantControllerRemoveResponse obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AssistantControllerRemoveResponse o && Equals(o);
        }
    }
}
