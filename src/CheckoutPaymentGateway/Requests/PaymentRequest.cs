using CheckoutPaymentGateway.Common;
using CheckoutPaymentGateway.Enums;
using System;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CheckoutPaymentGateway.Requests
{
    /// <summary>
    /// A request for a payment.
    /// </summary>
    /// <typeparam name="TPaymentSource">The source of payment.</typeparam>
    public class PaymentRequest<TPaymentSource> where TPaymentSource : IRequestSource
    {
        /// <summary>
        /// Gets or Sets Source.
        /// Use card source for now. Should be TPaymentSource
        /// </summary>
        [Required]
        public CardRequest Source { get; set; }

        /// <summary>
        /// The payment amount to charge from the source. The exact format depends on the currency 
        /// </summary>
        [Required]
        [Range(0, long.MaxValue)]
        public long Amount { get; set; }

        /// <summary>
        /// The three-letter ISO currency code.
        /// </summary>
        [Required]
        public string Currency { get; set; }

        /// <summary>
        /// Gets or sets the payment type. 
        /// </summary>
        public PaymentType? PaymentType { get; set; } = Enums.PaymentType.Regular;

        /// <summary>
        /// Flags the payment as a merchant-initiated transaction (MIT).
        /// </summary>
        public bool? MerchantInitiated { get; set; }

        /// <summary>
        /// Gets or sets a reference you can later use to identify this payment such as an invoice number.
        /// </summary>
        public string Reference { get; set; }

        /// <summary>
        /// A description of the payment
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets Customer for the payment
        /// </summary>
        public CustomerRequest Customer { get; set; }

        /// <summary>
        /// Gets or Sets Billing Description
        /// </summary>
        public BillingDescriptor BillingDescriptor { get; set; }

        /// <summary>
        /// Gets or Sets Shipping
        /// </summary>
        public ShippingDetails Shipping { get; set; }

        /// <summary>
        /// Gets or Sets 3ds secure to indicate whether to process this payment as a 3D-Secure.
        /// </summary>
        public ThreeDSRequest ThreeDS { get; set; }

        /// <summary>
        /// For recurring payments – an existing payment identifier from the recurring series or the Scheme Transaction Id 
        /// </summary>
        public Guid PreviousPaymentId { get; set; }

        /// <summary>
        /// Gets or Sets Risk
        /// </summary>
        public RiskRequest Risk { get; set; }

        /// <summary>
        /// For redirect payment methods, this overrides the default success redirect URL configured on merchant account
        /// </summary>
        public string SuccessUrl { get; set; }

        /// <summary>
        /// For redirect payment methods, this overrides the default failure redirect URL configured on merchant account
        /// </summary>
        public string FailureUrl { get; set; }

        /// <summary>
        /// The IP address used to make the payment. Required for some risk analysis
        /// </summary>
        public string PaymentIp { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PaymentRequest {\n");
            sb.Append("  Source: ").Append(Source).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  PaymentType: ").Append(PaymentType).Append("\n");
            sb.Append("  Reference: ").Append(Reference).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Customer: ").Append(Customer).Append("\n");
            sb.Append("  BillingDescriptor: ").Append(BillingDescriptor).Append("\n");
            sb.Append("  Shipping: ").Append(Shipping).Append("\n");
            sb.Append("  _3ds: ").Append(ThreeDS).Append("\n");
            sb.Append("  PreviousPaymentId: ").Append(PreviousPaymentId).Append("\n");
            sb.Append("  Risk: ").Append(Risk).Append("\n");
            sb.Append("  SuccessUrl: ").Append(SuccessUrl).Append("\n");
            sb.Append("  FailureUrl: ").Append(FailureUrl).Append("\n");
            sb.Append("  PaymentIp: ").Append(PaymentIp).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj.GetType() == GetType() && Equals((PaymentRequest<TPaymentSource>)obj);
        }

        /// <summary>
        /// Returns true if PaymentRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of PaymentRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentRequest<TPaymentSource> other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return
                (
                    Source == other.Source ||
                    Source != null &&
                    Source.Equals(other.Source)
                ) &&
                (
                    Amount == other.Amount ||
                    Amount != null &&
                    Amount.Equals(other.Amount)
                ) &&
                (
                    Currency == other.Currency ||
                    Currency != null &&
                    Currency.Equals(other.Currency)
                ) &&
                (
                    PaymentType == other.PaymentType ||
                    PaymentType != null &&
                    PaymentType.Equals(other.PaymentType)
                ) &&
                (
                    Reference == other.Reference ||
                    Reference != null &&
                    Reference.Equals(other.Reference)
                ) &&
                (
                    Description == other.Description ||
                    Description != null &&
                    Description.Equals(other.Description)
                ) &&
                (
                    Customer == other.Customer ||
                    Customer != null &&
                    Customer.Equals(other.Customer)
                ) &&
                (
                    BillingDescriptor == other.BillingDescriptor ||
                    BillingDescriptor != null &&
                    BillingDescriptor.Equals(other.BillingDescriptor)
                ) &&
                (
                    Shipping == other.Shipping ||
                    Shipping != null &&
                    Shipping.Equals(other.Shipping)
                ) &&
                (
                    ThreeDS == other.ThreeDS ||
                    ThreeDS != null &&
                    ThreeDS.Equals(other.ThreeDS)
                ) &&
                (
                    PreviousPaymentId == other.PreviousPaymentId ||
                    PreviousPaymentId != null &&
                    PreviousPaymentId.Equals(other.PreviousPaymentId)
                ) &&
                (
                    Risk == other.Risk ||
                    Risk != null &&
                    Risk.Equals(other.Risk)
                ) &&
                (
                    SuccessUrl == other.SuccessUrl ||
                    SuccessUrl != null &&
                    SuccessUrl.Equals(other.SuccessUrl)
                ) &&
                (
                    FailureUrl == other.FailureUrl ||
                    FailureUrl != null &&
                    FailureUrl.Equals(other.FailureUrl)
                ) &&
                (
                    PaymentIp == other.PaymentIp ||
                    PaymentIp != null &&
                    PaymentIp.Equals(other.PaymentIp)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                // Suitable nullity checks etc, of course :)
                if (Source != null)
                    hashCode = hashCode * 59 + Source.GetHashCode();
                if (Amount != null)
                    hashCode = hashCode * 59 + Amount.GetHashCode();
                if (Currency != null)
                    hashCode = hashCode * 59 + Currency.GetHashCode();
                if (PaymentType != null)
                    hashCode = hashCode * 59 + PaymentType.GetHashCode();
                    hashCode = hashCode * 59 + Reference.GetHashCode();
                if (Description != null)
                    hashCode = hashCode * 59 + Description.GetHashCode();
                if (Customer != null)
                    hashCode = hashCode * 59 + Customer.GetHashCode();
                if (BillingDescriptor != null)
                    hashCode = hashCode * 59 + BillingDescriptor.GetHashCode();
                if (Shipping != null)
                    hashCode = hashCode * 59 + Shipping.GetHashCode();
                if (ThreeDS != null)
                    hashCode = hashCode * 59 + ThreeDS.GetHashCode();
                if (PreviousPaymentId != null)
                    hashCode = hashCode * 59 + PreviousPaymentId.GetHashCode();
                if (Risk != null)
                    hashCode = hashCode * 59 + Risk.GetHashCode();
                if (SuccessUrl != null)
                    hashCode = hashCode * 59 + SuccessUrl.GetHashCode();
                if (FailureUrl != null)
                    hashCode = hashCode * 59 + FailureUrl.GetHashCode();
                if (PaymentIp != null)
                    hashCode = hashCode * 59 + PaymentIp.GetHashCode();
                return hashCode;
            }
        }

        public static bool operator ==(PaymentRequest<TPaymentSource> left, PaymentRequest<TPaymentSource> right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(PaymentRequest<TPaymentSource> left, PaymentRequest<TPaymentSource> right)
        {
            return !Equals(left, right);
        }
    }
}
