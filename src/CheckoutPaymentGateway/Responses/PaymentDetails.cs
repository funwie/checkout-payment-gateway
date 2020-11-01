using CheckoutPaymentGateway.Common;
using CheckoutPaymentGateway.Enums;
using Newtonsoft.Json;
using System;
using System.Runtime.Serialization;
using System.Text;

namespace CheckoutPaymentGateway.Responses
{
    [DataContract]
    public class PaymentDetails
    {
        // <summary>
        /// Payment unique identifier
        /// </summary>
        [DataMember(Name = "id")]
        public Guid Id { get; set; }

        /// <summary>
        /// The date/time the payment was requested
        /// </summary>
        [DataMember(Name = "requested_on")]
        public DateTimeOffset RequestedOn { get; set; }

        /// <summary>
        /// The source of the payment
        /// </summary>
        [DataMember(Name = "source")]
        public IResponseSource Source { get; set; }

        /// <summary>
        /// The destination of the payment
        /// </summary>
        [DataMember(Name = "destination")]
        public PaymentDetailsDestination Destination { get; set; }

        /// <summary>
        /// The original payment amount
        /// </summary>
        [DataMember(Name = "amount")]
        public long? Amount { get; set; }

        /// <summary>
        /// The three-letter ISO currency code of the payment
        /// </summary>
        /// <value>The three-letter ISO currency code&lt; of the payment</value>
        [DataMember(Name = "currency")]
        public string Currency { get; set; }

        /// <summary>
        /// This must be specified for card payments where the cardholder is not present (i.e., recurring or mail order / telephone order)
        /// </summary>
        [DataMember(Name = "payment_type")]
        public PaymentType? PaymentType { get; set; }

        /// <summary>
        /// Your reference for the payment
        /// </summary>
        [DataMember(Name = "reference")]
        public string Reference { get; set; }

        /// <summary>
        /// A description of the payment
        /// </summary>
        [DataMember(Name = "description")]
        public string Description { get; set; }

        /// <summary>
        /// Whether the payment was successful
        /// </summary>
        [DataMember(Name = "approved")]
        public bool? Approved { get; set; }

        /// <summary>
        /// The status of the payment
        /// </summary>
        [DataMember(Name = "status")]
        public PaymentStatus? Status { get; set; }

        /// <summary>
        /// Provides information relating to the processing of 3D Secure payments
        /// </summary>
        [DataMember(Name = "3ds")]
        public ThreeDSResponse ThreeDS { get; set; }

        /// <summary>
        /// Gets or Sets Risk
        /// </summary>
        [DataMember(Name = "risk")]
        public RiskResponse Risk { get; set; }

        /// <summary>
        /// Gets or Sets Customer
        /// </summary>
        [DataMember(Name = "customer")]
        public CustomerResponse Customer { get; set; }

        /// <summary>
        /// Gets or Sets BillingDescriptor
        /// </summary>
        [DataMember(Name = "billing_descriptor")]
        public BillingDescriptor BillingDescriptor { get; set; }

        /// <summary>
        /// Gets or Sets Shipping
        /// </summary>
        [DataMember(Name = "shipping")]
        public ShippingDetails Shipping { get; set; }

        /// <summary>
        /// The IP address used to make the payment
        /// </summary>
        /// <value>The IP address used to make the payment</value>
        [DataMember(Name = "payment_ip")]
        public string PaymentIp { get; set; }

        /// <summary>
        /// The final Electronic Commerce Indicator (ECI) security level used to authorize the payment.  Applicable for 3D Secure, digital wallets, and network token payments 
        /// </summary>
        [DataMember(Name = "eci")]
        public string Eci { get; set; }

        /// <summary>
        /// The scheme transaction identifier 
        /// </summary>
        [DataMember(Name = "scheme_id")]
        public string SchemeId { get; set; }

        /// <summary>
        /// Gets or Sets Links
        /// </summary>
        [DataMember(Name = "_links")]
        public PaymentDetailsLinks Links { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Payment {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  RequestedOn: ").Append(RequestedOn).Append("\n");
            sb.Append("  Source: ").Append(Source).Append("\n");
            sb.Append("  Destination: ").Append(Destination).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  PaymentType: ").Append(PaymentType).Append("\n");
            sb.Append("  Reference: ").Append(Reference).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Approved: ").Append(Approved).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  _3ds: ").Append(ThreeDS).Append("\n");
            sb.Append("  Risk: ").Append(Risk).Append("\n");
            sb.Append("  Customer: ").Append(Customer).Append("\n");
            sb.Append("  BillingDescriptor: ").Append(BillingDescriptor).Append("\n");
            sb.Append("  Shipping: ").Append(Shipping).Append("\n");
            sb.Append("  PaymentIp: ").Append(PaymentIp).Append("\n");
            sb.Append("  Eci: ").Append(Eci).Append("\n");
            sb.Append("  SchemeId: ").Append(SchemeId).Append("\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
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
            return obj.GetType() == GetType() && Equals((PaymentDetails)obj);
        }

        /// <summary>
        /// Returns true if Payment instances are equal
        /// </summary>
        /// <param name="other">Instance of Payment to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentDetails other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return
                (
                    Id == other.Id ||
                    Id != null &&
                    Id.Equals(other.Id)
                ) &&
                (
                    RequestedOn == other.RequestedOn ||
                    RequestedOn != null &&
                    RequestedOn.Equals(other.RequestedOn)
                ) &&
                (
                    Source == other.Source ||
                    Source != null &&
                    Source.Equals(other.Source)
                ) &&
                (
                    Destination == other.Destination ||
                    Destination != null &&
                    Destination.Equals(other.Destination)
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
                    Approved == other.Approved ||
                    Approved != null &&
                    Approved.Equals(other.Approved)
                ) &&
                (
                    Status == other.Status ||
                    Status != null &&
                    Status.Equals(other.Status)
                ) &&
                (
                    ThreeDS == other.ThreeDS ||
                    ThreeDS != null &&
                    ThreeDS.Equals(other.ThreeDS)
                ) &&
                (
                    Risk == other.Risk ||
                    Risk != null &&
                    Risk.Equals(other.Risk)
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
                    PaymentIp == other.PaymentIp ||
                    PaymentIp != null &&
                    PaymentIp.Equals(other.PaymentIp)
                ) &&
                (
                    Eci == other.Eci ||
                    Eci != null &&
                    Eci.Equals(other.Eci)
                ) &&
                (
                    SchemeId == other.SchemeId ||
                    SchemeId != null &&
                    SchemeId.Equals(other.SchemeId)
                ) &&
                (
                    Links == other.Links ||
                    Links != null &&
                    Links.Equals(other.Links)
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
                if (Id != null)
                    hashCode = hashCode * 59 + Id.GetHashCode();
                if (RequestedOn != null)
                    hashCode = hashCode * 59 + RequestedOn.GetHashCode();
                if (Source != null)
                    hashCode = hashCode * 59 + Source.GetHashCode();
                if (Destination != null)
                    hashCode = hashCode * 59 + Destination.GetHashCode();
                if (Amount != null)
                    hashCode = hashCode * 59 + Amount.GetHashCode();
                if (Currency != null)
                    hashCode = hashCode * 59 + Currency.GetHashCode();
                if (PaymentType != null)
                    hashCode = hashCode * 59 + PaymentType.GetHashCode();
                if (Reference != null)
                    hashCode = hashCode * 59 + Reference.GetHashCode();
                if (Description != null)
                    hashCode = hashCode * 59 + Description.GetHashCode();
                if (Approved != null)
                    hashCode = hashCode * 59 + Approved.GetHashCode();
                if (Status != null)
                    hashCode = hashCode * 59 + Status.GetHashCode();
                if (ThreeDS != null)
                    hashCode = hashCode * 59 + ThreeDS.GetHashCode();
                if (Risk != null)
                    hashCode = hashCode * 59 + Risk.GetHashCode();
                if (Customer != null)
                    hashCode = hashCode * 59 + Customer.GetHashCode();
                if (BillingDescriptor != null)
                    hashCode = hashCode * 59 + BillingDescriptor.GetHashCode();
                if (Shipping != null)
                    hashCode = hashCode * 59 + Shipping.GetHashCode();
                if (PaymentIp != null)
                    hashCode = hashCode * 59 + PaymentIp.GetHashCode();
                if (Eci != null)
                    hashCode = hashCode * 59 + Eci.GetHashCode();
                if (SchemeId != null)
                    hashCode = hashCode * 59 + SchemeId.GetHashCode();
                if (Links != null)
                    hashCode = hashCode * 59 + Links.GetHashCode();
                return hashCode;
            }
        }

        public static bool operator ==(PaymentDetails left, PaymentDetails right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(PaymentDetails left, PaymentDetails right)
        {
            return !Equals(left, right);
        }
    }
}
