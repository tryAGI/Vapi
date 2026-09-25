
#nullable enable

namespace Vapi
{
    /// <summary>
    /// This is how payment is collected for the subscription: charged to the card<br/>
    /// on file, or invoiced.
    /// </summary>
    public enum SubscriptionBillingCollectionMethod
    {
        /// <summary>
        ///
        /// </summary>
        ChargeAutomatically,
        /// <summary>
        ///
        /// </summary>
        SendInvoice,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubscriptionBillingCollectionMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionBillingCollectionMethod value)
        {
            return value switch
            {
                SubscriptionBillingCollectionMethod.ChargeAutomatically => "charge_automatically",
                SubscriptionBillingCollectionMethod.SendInvoice => "send_invoice",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionBillingCollectionMethod? ToEnum(string value)
        {
            return value switch
            {
                "charge_automatically" => SubscriptionBillingCollectionMethod.ChargeAutomatically,
                "send_invoice" => SubscriptionBillingCollectionMethod.SendInvoice,
                _ => null,
            };
        }
    }
}