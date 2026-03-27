#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vapi
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct PhoneNumberControllerFindAllResponseItem : global::System.IEquatable<PhoneNumberControllerFindAllResponseItem>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Vapi.PhoneNumberControllerFindAllResponseItemDiscriminatorProvider? Provider { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vapi.ByoPhoneNumber? ByoPhoneNumber { get; init; }
#else
        public global::Vapi.ByoPhoneNumber? ByoPhoneNumber { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ByoPhoneNumber))]
#endif
        public bool IsByoPhoneNumber => ByoPhoneNumber != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vapi.TwilioPhoneNumber? Twilio { get; init; }
#else
        public global::Vapi.TwilioPhoneNumber? Twilio { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Twilio))]
#endif
        public bool IsTwilio => Twilio != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vapi.VonagePhoneNumber? Vonage { get; init; }
#else
        public global::Vapi.VonagePhoneNumber? Vonage { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Vonage))]
#endif
        public bool IsVonage => Vonage != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vapi.VapiPhoneNumber? Vapi { get; init; }
#else
        public global::Vapi.VapiPhoneNumber? Vapi { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Vapi))]
#endif
        public bool IsVapi => Vapi != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vapi.TelnyxPhoneNumber? Telnyx { get; init; }
#else
        public global::Vapi.TelnyxPhoneNumber? Telnyx { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Telnyx))]
#endif
        public bool IsTelnyx => Telnyx != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PhoneNumberControllerFindAllResponseItem(global::Vapi.ByoPhoneNumber value) => new PhoneNumberControllerFindAllResponseItem((global::Vapi.ByoPhoneNumber?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vapi.ByoPhoneNumber?(PhoneNumberControllerFindAllResponseItem @this) => @this.ByoPhoneNumber;

        /// <summary>
        /// 
        /// </summary>
        public PhoneNumberControllerFindAllResponseItem(global::Vapi.ByoPhoneNumber? value)
        {
            ByoPhoneNumber = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PhoneNumberControllerFindAllResponseItem(global::Vapi.TwilioPhoneNumber value) => new PhoneNumberControllerFindAllResponseItem((global::Vapi.TwilioPhoneNumber?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vapi.TwilioPhoneNumber?(PhoneNumberControllerFindAllResponseItem @this) => @this.Twilio;

        /// <summary>
        /// 
        /// </summary>
        public PhoneNumberControllerFindAllResponseItem(global::Vapi.TwilioPhoneNumber? value)
        {
            Twilio = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PhoneNumberControllerFindAllResponseItem(global::Vapi.VonagePhoneNumber value) => new PhoneNumberControllerFindAllResponseItem((global::Vapi.VonagePhoneNumber?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vapi.VonagePhoneNumber?(PhoneNumberControllerFindAllResponseItem @this) => @this.Vonage;

        /// <summary>
        /// 
        /// </summary>
        public PhoneNumberControllerFindAllResponseItem(global::Vapi.VonagePhoneNumber? value)
        {
            Vonage = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PhoneNumberControllerFindAllResponseItem(global::Vapi.VapiPhoneNumber value) => new PhoneNumberControllerFindAllResponseItem((global::Vapi.VapiPhoneNumber?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vapi.VapiPhoneNumber?(PhoneNumberControllerFindAllResponseItem @this) => @this.Vapi;

        /// <summary>
        /// 
        /// </summary>
        public PhoneNumberControllerFindAllResponseItem(global::Vapi.VapiPhoneNumber? value)
        {
            Vapi = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PhoneNumberControllerFindAllResponseItem(global::Vapi.TelnyxPhoneNumber value) => new PhoneNumberControllerFindAllResponseItem((global::Vapi.TelnyxPhoneNumber?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vapi.TelnyxPhoneNumber?(PhoneNumberControllerFindAllResponseItem @this) => @this.Telnyx;

        /// <summary>
        /// 
        /// </summary>
        public PhoneNumberControllerFindAllResponseItem(global::Vapi.TelnyxPhoneNumber? value)
        {
            Telnyx = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public PhoneNumberControllerFindAllResponseItem(
            global::Vapi.PhoneNumberControllerFindAllResponseItemDiscriminatorProvider? provider,
            global::Vapi.ByoPhoneNumber? byoPhoneNumber,
            global::Vapi.TwilioPhoneNumber? twilio,
            global::Vapi.VonagePhoneNumber? vonage,
            global::Vapi.VapiPhoneNumber? vapi,
            global::Vapi.TelnyxPhoneNumber? telnyx
            )
        {
            Provider = provider;

            ByoPhoneNumber = byoPhoneNumber;
            Twilio = twilio;
            Vonage = vonage;
            Vapi = vapi;
            Telnyx = telnyx;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Telnyx as object ??
            Vapi as object ??
            Vonage as object ??
            Twilio as object ??
            ByoPhoneNumber as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ByoPhoneNumber?.ToString() ??
            Twilio?.ToString() ??
            Vonage?.ToString() ??
            Vapi?.ToString() ??
            Telnyx?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsByoPhoneNumber && !IsTwilio && !IsVonage && !IsVapi && !IsTelnyx || !IsByoPhoneNumber && IsTwilio && !IsVonage && !IsVapi && !IsTelnyx || !IsByoPhoneNumber && !IsTwilio && IsVonage && !IsVapi && !IsTelnyx || !IsByoPhoneNumber && !IsTwilio && !IsVonage && IsVapi && !IsTelnyx || !IsByoPhoneNumber && !IsTwilio && !IsVonage && !IsVapi && IsTelnyx;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vapi.ByoPhoneNumber?, TResult>? byoPhoneNumber = null,
            global::System.Func<global::Vapi.TwilioPhoneNumber?, TResult>? twilio = null,
            global::System.Func<global::Vapi.VonagePhoneNumber?, TResult>? vonage = null,
            global::System.Func<global::Vapi.VapiPhoneNumber?, TResult>? vapi = null,
            global::System.Func<global::Vapi.TelnyxPhoneNumber?, TResult>? telnyx = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsByoPhoneNumber && byoPhoneNumber != null)
            {
                return byoPhoneNumber(ByoPhoneNumber!);
            }
            else if (IsTwilio && twilio != null)
            {
                return twilio(Twilio!);
            }
            else if (IsVonage && vonage != null)
            {
                return vonage(Vonage!);
            }
            else if (IsVapi && vapi != null)
            {
                return vapi(Vapi!);
            }
            else if (IsTelnyx && telnyx != null)
            {
                return telnyx(Telnyx!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Vapi.ByoPhoneNumber?>? byoPhoneNumber = null,
            global::System.Action<global::Vapi.TwilioPhoneNumber?>? twilio = null,
            global::System.Action<global::Vapi.VonagePhoneNumber?>? vonage = null,
            global::System.Action<global::Vapi.VapiPhoneNumber?>? vapi = null,
            global::System.Action<global::Vapi.TelnyxPhoneNumber?>? telnyx = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsByoPhoneNumber)
            {
                byoPhoneNumber?.Invoke(ByoPhoneNumber!);
            }
            else if (IsTwilio)
            {
                twilio?.Invoke(Twilio!);
            }
            else if (IsVonage)
            {
                vonage?.Invoke(Vonage!);
            }
            else if (IsVapi)
            {
                vapi?.Invoke(Vapi!);
            }
            else if (IsTelnyx)
            {
                telnyx?.Invoke(Telnyx!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ByoPhoneNumber,
                typeof(global::Vapi.ByoPhoneNumber),
                Twilio,
                typeof(global::Vapi.TwilioPhoneNumber),
                Vonage,
                typeof(global::Vapi.VonagePhoneNumber),
                Vapi,
                typeof(global::Vapi.VapiPhoneNumber),
                Telnyx,
                typeof(global::Vapi.TelnyxPhoneNumber),
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
        public bool Equals(PhoneNumberControllerFindAllResponseItem other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vapi.ByoPhoneNumber?>.Default.Equals(ByoPhoneNumber, other.ByoPhoneNumber) &&
                global::System.Collections.Generic.EqualityComparer<global::Vapi.TwilioPhoneNumber?>.Default.Equals(Twilio, other.Twilio) &&
                global::System.Collections.Generic.EqualityComparer<global::Vapi.VonagePhoneNumber?>.Default.Equals(Vonage, other.Vonage) &&
                global::System.Collections.Generic.EqualityComparer<global::Vapi.VapiPhoneNumber?>.Default.Equals(Vapi, other.Vapi) &&
                global::System.Collections.Generic.EqualityComparer<global::Vapi.TelnyxPhoneNumber?>.Default.Equals(Telnyx, other.Telnyx) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(PhoneNumberControllerFindAllResponseItem obj1, PhoneNumberControllerFindAllResponseItem obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<PhoneNumberControllerFindAllResponseItem>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(PhoneNumberControllerFindAllResponseItem obj1, PhoneNumberControllerFindAllResponseItem obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is PhoneNumberControllerFindAllResponseItem o && Equals(o);
        }
    }
}
