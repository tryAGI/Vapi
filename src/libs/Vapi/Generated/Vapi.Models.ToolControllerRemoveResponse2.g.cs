#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vapi
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct ToolControllerRemoveResponse2 : global::System.IEquatable<ToolControllerRemoveResponse2>
    {
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ToolControllerRemoveResponseDiscriminatorError? Error { get; }

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vapi.ToolPinnedConflictResponseDTO? ToolPinned { get; init; }
#else
        public global::Vapi.ToolPinnedConflictResponseDTO? ToolPinned { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ToolPinned))]
#endif
        public bool IsToolPinned => ToolPinned != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickToolPinned(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vapi.ToolPinnedConflictResponseDTO? value)
        {
            value = ToolPinned;
            return IsToolPinned;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ToolPinnedConflictResponseDTO PickToolPinned() => IsToolPinned
            ? ToolPinned!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ToolPinned' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vapi.ToolWriteConflictResponseDTO? ToolWriteConflict { get; init; }
#else
        public global::Vapi.ToolWriteConflictResponseDTO? ToolWriteConflict { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ToolWriteConflict))]
#endif
        public bool IsToolWriteConflict => ToolWriteConflict != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickToolWriteConflict(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vapi.ToolWriteConflictResponseDTO? value)
        {
            value = ToolWriteConflict;
            return IsToolWriteConflict;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ToolWriteConflictResponseDTO PickToolWriteConflict() => IsToolWriteConflict
            ? ToolWriteConflict!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ToolWriteConflict' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator ToolControllerRemoveResponse2(global::Vapi.ToolPinnedConflictResponseDTO value) => new ToolControllerRemoveResponse2((global::Vapi.ToolPinnedConflictResponseDTO?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vapi.ToolPinnedConflictResponseDTO?(ToolControllerRemoveResponse2 @this) => @this.ToolPinned;

        /// <summary>
        ///
        /// </summary>
        public ToolControllerRemoveResponse2(global::Vapi.ToolPinnedConflictResponseDTO? value)
        {
            ToolPinned = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ToolControllerRemoveResponse2 FromToolPinned(global::Vapi.ToolPinnedConflictResponseDTO? value) => new ToolControllerRemoveResponse2(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ToolControllerRemoveResponse2(global::Vapi.ToolWriteConflictResponseDTO value) => new ToolControllerRemoveResponse2((global::Vapi.ToolWriteConflictResponseDTO?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vapi.ToolWriteConflictResponseDTO?(ToolControllerRemoveResponse2 @this) => @this.ToolWriteConflict;

        /// <summary>
        ///
        /// </summary>
        public ToolControllerRemoveResponse2(global::Vapi.ToolWriteConflictResponseDTO? value)
        {
            ToolWriteConflict = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ToolControllerRemoveResponse2 FromToolWriteConflict(global::Vapi.ToolWriteConflictResponseDTO? value) => new ToolControllerRemoveResponse2(value);

        /// <summary>
        ///
        /// </summary>
        public ToolControllerRemoveResponse2(
            global::Vapi.ToolControllerRemoveResponseDiscriminatorError? error,
            global::Vapi.ToolPinnedConflictResponseDTO? toolPinned,
            global::Vapi.ToolWriteConflictResponseDTO? toolWriteConflict
            )
        {
            Error = error;

            ToolPinned = toolPinned;
            ToolWriteConflict = toolWriteConflict;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            ToolWriteConflict as object ??
            ToolPinned as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            ToolPinned?.ToString() ??
            ToolWriteConflict?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsToolPinned && !IsToolWriteConflict || !IsToolPinned && IsToolWriteConflict;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vapi.ToolPinnedConflictResponseDTO, TResult>? toolPinned = null,
            global::System.Func<global::Vapi.ToolWriteConflictResponseDTO, TResult>? toolWriteConflict = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsToolPinned && toolPinned != null)
            {
                return toolPinned(ToolPinned!);
            }
            else if (IsToolWriteConflict && toolWriteConflict != null)
            {
                return toolWriteConflict(ToolWriteConflict!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Vapi.ToolPinnedConflictResponseDTO>? toolPinned = null,

            global::System.Action<global::Vapi.ToolWriteConflictResponseDTO>? toolWriteConflict = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsToolPinned)
            {
                toolPinned?.Invoke(ToolPinned!);
            }
            else if (IsToolWriteConflict)
            {
                toolWriteConflict?.Invoke(ToolWriteConflict!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Vapi.ToolPinnedConflictResponseDTO>? toolPinned = null,
            global::System.Action<global::Vapi.ToolWriteConflictResponseDTO>? toolWriteConflict = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsToolPinned)
            {
                toolPinned?.Invoke(ToolPinned!);
            }
            else if (IsToolWriteConflict)
            {
                toolWriteConflict?.Invoke(ToolWriteConflict!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ToolPinned,
                typeof(global::Vapi.ToolPinnedConflictResponseDTO),
                ToolWriteConflict,
                typeof(global::Vapi.ToolWriteConflictResponseDTO),
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
        public bool Equals(ToolControllerRemoveResponse2 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vapi.ToolPinnedConflictResponseDTO?>.Default.Equals(ToolPinned, other.ToolPinned) &&
                global::System.Collections.Generic.EqualityComparer<global::Vapi.ToolWriteConflictResponseDTO?>.Default.Equals(ToolWriteConflict, other.ToolWriteConflict)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(ToolControllerRemoveResponse2 obj1, ToolControllerRemoveResponse2 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ToolControllerRemoveResponse2>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ToolControllerRemoveResponse2 obj1, ToolControllerRemoveResponse2 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ToolControllerRemoveResponse2 o && Equals(o);
        }
    }
}
