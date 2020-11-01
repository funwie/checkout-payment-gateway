using System.Runtime.Serialization;

namespace CheckoutPaymentGateway.Enums
{
    /// <summary>
    /// The type of payment.
    /// </summary>
    public enum PaymentStatus
    {
        /// <summary>
        /// Pending - further processing required.
        /// </summary>
        [EnumMember(Value = "Pending")]
        Pending = 0,

        /// <summary>
        /// Authorized
        /// </summary>
        [EnumMember(Value = "Authorized")]
        Authorized = 1,

        /// <summary>
        /// Card Verified
        /// </summary>
        [EnumMember(Value = "Card Verified")]
        CardVerified = 2,

        /// <summary>
        /// Voided
        /// </summary>
        [EnumMember(Value = "Voided")]
        Voided = 3,

        /// <summary>
        /// Refunded
        /// </summary>
        [EnumMember(Value = "Refunded")]
        Refunded = 7,

        /// <summary>
        /// Declined
        /// </summary>
        [EnumMember(Value = "Declined")]
        Declined = 8,

        /// <summary>
        /// Cancelled
        /// </summary>
        [EnumMember(Value = "Cancelled")]
        Cancelled = 9,

        /// <summary>
        /// Paid
        /// </summary>
        [EnumMember(Value = "Paid")]
        Paid = 10
    }
}
