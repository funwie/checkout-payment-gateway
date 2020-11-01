using CheckoutPaymentGateway.Enums;
using Newtonsoft.Json;
using System;
using System.Runtime.Serialization;
using System.Text;

namespace CheckoutPaymentGateway.Responses
{
    /// <summary>
    /// A payment response from the processing of a request.
    /// </summary>
    [DataContract]
    public class PaymentResponse
    {
        /// <summary>
        /// The payment's unique identifier.
        /// </summary>
        [DataMember(Name = "id")]
        public Guid Id { get; set; }

        /// <summary>
        /// The unique identifier for the action performed against this payment.
        /// </summary>
        [DataMember(Name = "action_id")]
        public Guid ActionId { get; set; }

        /// <summary>
        /// The payment amount.
        /// </summary>
        /// <value>The payment amount</value>
        [DataMember(Name = "amount")]
        public long? Amount { get; set; }

        /// <summary>
        /// The three-letter ISO currency code of the payment.
        /// </summary>
        [DataMember(Name = "currency")]
        public string Currency { get; set; }

        /// <summary>
        /// Whether or not the authorization or capture was successful
        /// </summary>
        [DataMember(Name = "approved")]
        public bool? Approved { get; set; }

        /// <summary>
        /// The status of the payment
        /// </summary>
        [DataMember(Name = "status")]
        public PaymentStatus? Status { get; set; }

        /// <summary>
        /// The acquirer authorization code if the payment was authorized
        /// </summary>
        [DataMember(Name = "auth_code")]
        public string AuthCode { get; set; }

        /// <summary>
        /// The Gateway response code
        /// </summary>
        [DataMember(Name = "response_code")]
        public string ResponseCode { get; set; }

        /// <summary>
        /// The Gateway response summary
        /// </summary>
        [DataMember(Name = "response_summary")]
        public string ResponseSummary { get; set; }

        /// <summary>
        /// Provides 3D Secure enrollment status if the payment was downgraded to non-3D Secure
        /// </summary>
        [DataMember(Name = "3ds")]
        public ThreeDSResponse ThreeDS { get; set; }

        /// <summary>
        /// Gets or Sets Risk
        /// </summary>
        [DataMember(Name = "risk")]
        public RiskResponse Risk { get; set; }

        /// <summary>
        /// The source of the payment
        /// </summary>
        [DataMember(Name = "source")]
        public IResponseSource Source { get; set; }

        /// <summary>
        /// The customer associated with the payment, if provided in the request
        /// </summary>
        [DataMember(Name = "customer")]
        public CustomerResponse Customer { get; set; }

        /// <summary>
        /// The date/time the payment was processed
        /// </summary>
        [DataMember(Name = "processed_on")]
        public DateTimeOffset ProcessedOn { get; set; }

        /// <summary>
        /// Your reference for the payment
        /// </summary>
        [DataMember(Name = "reference")]
        public string Reference { get; set; }

        /// <summary>
        /// The final Electronic Commerce Indicator (ECI) security level used to authorize the payment. Applicable for 3D Secure, digital wallet, and network token payments
        /// </summary>
        [DataMember(Name = "eci")]
        public string Eci { get; set; }

        /// <summary>
        /// The scheme transaction identifier
        /// </summary>
        /// <value>The scheme transaction identifier</value>
        [DataMember(Name = "scheme_id")]
        public string SchemeId { get; set; }

        /// <summary>
        /// Gets or Sets Links
        /// </summary>
        [DataMember(Name = "_links")]
        public PaymentResponseLinks Links { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PaymentResponse {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ActionId: ").Append(ActionId).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  Approved: ").Append(Approved).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  AuthCode: ").Append(AuthCode).Append("\n");
            sb.Append("  ResponseCode: ").Append(ResponseCode).Append("\n");
            sb.Append("  ResponseSummary: ").Append(ResponseSummary).Append("\n");
            sb.Append("  _3ds: ").Append(ThreeDS).Append("\n");
            sb.Append("  Risk: ").Append(Risk).Append("\n");
            sb.Append("  Source: ").Append(Source).Append("\n");
            sb.Append("  Customer: ").Append(Customer).Append("\n");
            sb.Append("  ProcessedOn: ").Append(ProcessedOn).Append("\n");
            sb.Append("  Reference: ").Append(Reference).Append("\n");
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
            return obj.GetType() == GetType() && Equals((PaymentResponse)obj);
        }

        /// <summary>
        /// Returns true if PaymentResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of PaymentResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentResponse other)
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
                    ActionId == other.ActionId ||
                    ActionId != null &&
                    ActionId.Equals(other.ActionId)
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
                    AuthCode == other.AuthCode ||
                    AuthCode != null &&
                    AuthCode.Equals(other.AuthCode)
                ) &&
                (
                    ResponseCode == other.ResponseCode ||
                    ResponseCode != null &&
                    ResponseCode.Equals(other.ResponseCode)
                ) &&
                (
                    ResponseSummary == other.ResponseSummary ||
                    ResponseSummary != null &&
                    ResponseSummary.Equals(other.ResponseSummary)
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
                    Source == other.Source ||
                    Source != null &&
                    Source.Equals(other.Source)
                ) &&
                (
                    Customer == other.Customer ||
                    Customer != null &&
                    Customer.Equals(other.Customer)
                ) &&
                (
                    ProcessedOn == other.ProcessedOn ||
                    ProcessedOn != null &&
                    ProcessedOn.Equals(other.ProcessedOn)
                ) &&
                (
                    Reference == other.Reference ||
                    Reference != null &&
                    Reference.Equals(other.Reference)
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
                if (ActionId != null)
                    hashCode = hashCode * 59 + ActionId.GetHashCode();
                if (Amount != null)
                    hashCode = hashCode * 59 + Amount.GetHashCode();
                if (Currency != null)
                    hashCode = hashCode * 59 + Currency.GetHashCode();
                if (Approved != null)
                    hashCode = hashCode * 59 + Approved.GetHashCode();
                if (Status != null)
                    hashCode = hashCode * 59 + Status.GetHashCode();
                if (AuthCode != null)
                    hashCode = hashCode * 59 + AuthCode.GetHashCode();
                if (ResponseCode != null)
                    hashCode = hashCode * 59 + ResponseCode.GetHashCode();
                if (ResponseSummary != null)
                    hashCode = hashCode * 59 + ResponseSummary.GetHashCode();
                if (ThreeDS != null)
                    hashCode = hashCode * 59 + ThreeDS.GetHashCode();
                if (Risk != null)
                    hashCode = hashCode * 59 + Risk.GetHashCode();
                if (Source != null)
                    hashCode = hashCode * 59 + Source.GetHashCode();
                if (Customer != null)
                    hashCode = hashCode * 59 + Customer.GetHashCode();
                if (ProcessedOn != null)
                    hashCode = hashCode * 59 + ProcessedOn.GetHashCode();
                if (Reference != null)
                    hashCode = hashCode * 59 + Reference.GetHashCode();
                if (Eci != null)
                    hashCode = hashCode * 59 + Eci.GetHashCode();
                if (SchemeId != null)
                    hashCode = hashCode * 59 + SchemeId.GetHashCode();
                if (Links != null)
                    hashCode = hashCode * 59 + Links.GetHashCode();
                return hashCode;
            }
        }

        public static bool operator ==(PaymentResponse left, PaymentResponse right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(PaymentResponse left, PaymentResponse right)
        {
            return !Equals(left, right);
        }
    }
}
