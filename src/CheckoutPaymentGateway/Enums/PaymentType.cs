using System.Runtime.Serialization;

namespace CheckoutPaymentGateway.Enums
{
    /// <summary>
    /// Payment types
    /// </summary>
    public enum PaymentType
    {
        /// <summary>
        /// Regular (one-time) payment.
        /// </summary>
        [EnumMember(Value = "Regular")]
        Regular = 0,

        /// <summary>
        /// Recurring payment.
        /// </summary>
        [EnumMember(Value = "Recurring")]
        Recurring = 1
    }
}
