
#nullable enable

namespace Vapi
{
    /// <summary>
    /// 
    /// </summary>
    public enum SimulationRunPaymentRequiredResponseReason
    {
        /// <summary>
        /// 
        /// </summary>
        BillingLimit,
        /// <summary>
        /// 
        /// </summary>
        InitialPaymentMissing,
        /// <summary>
        /// 
        /// </summary>
        InsufficientCredits,
        /// <summary>
        /// 
        /// </summary>
        PaymentMethodMissing,
        /// <summary>
        /// 
        /// </summary>
        SubscriptionFrozen,
        /// <summary>
        /// 
        /// </summary>
        WalletMissing,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SimulationRunPaymentRequiredResponseReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SimulationRunPaymentRequiredResponseReason value)
        {
            return value switch
            {
                SimulationRunPaymentRequiredResponseReason.BillingLimit => "billing_limit",
                SimulationRunPaymentRequiredResponseReason.InitialPaymentMissing => "initial_payment_missing",
                SimulationRunPaymentRequiredResponseReason.InsufficientCredits => "insufficient_credits",
                SimulationRunPaymentRequiredResponseReason.PaymentMethodMissing => "payment_method_missing",
                SimulationRunPaymentRequiredResponseReason.SubscriptionFrozen => "subscription_frozen",
                SimulationRunPaymentRequiredResponseReason.WalletMissing => "wallet_missing",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SimulationRunPaymentRequiredResponseReason? ToEnum(string value)
        {
            return value switch
            {
                "billing_limit" => SimulationRunPaymentRequiredResponseReason.BillingLimit,
                "initial_payment_missing" => SimulationRunPaymentRequiredResponseReason.InitialPaymentMissing,
                "insufficient_credits" => SimulationRunPaymentRequiredResponseReason.InsufficientCredits,
                "payment_method_missing" => SimulationRunPaymentRequiredResponseReason.PaymentMethodMissing,
                "subscription_frozen" => SimulationRunPaymentRequiredResponseReason.SubscriptionFrozen,
                "wallet_missing" => SimulationRunPaymentRequiredResponseReason.WalletMissing,
                _ => null,
            };
        }
    }
}