using CheckoutPaymentGateway.Enums;
using Newtonsoft.Json;
using System;
using System.Runtime.Serialization;
using System.Text;

namespace CheckoutPaymentGateway.Responses
{
    /// <summary>
    /// Payment accepted response.
    /// </summary>
    public class PaymentAcceptedResponse
    {

        /// <summary>
        /// The payment's unique identifier
        /// </summary>
        [DataMember(Name = "id")]
        public Guid Id { get; private set; }

        /// <summary>
        /// The status of the payment
        /// </summary>
        [DataMember(Name = "status")]
        public PaymentStatus? Status { get; set; }

        /// <summary>
        /// Your reference for the payment request
        /// </summary>
        /// <value>Your reference for the payment request</value>
        [DataMember(Name = "reference")]
        public string Reference { get; set; }

        /// <summary>
        /// The customer associated with the payment, if provided in the request
        /// </summary>
        [DataMember(Name = "customer")]
        public CustomerResponse Customer { get; set; }

        /// <summary>
        /// Provides 3D Secure enrollment status
        /// </summary>
        [DataMember(Name = "3ds")]
        public ThreeDSResponse ThreeDS { get; set; }

        /// <summary>
        /// Gets or Sets Links
        /// </summary>
        [DataMember(Name = "_links")]
        public PaymentAcceptedResponseLinks Links { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PaymentAcceptedResponse {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Reference: ").Append(Reference).Append("\n");
            sb.Append("  Customer: ").Append(Customer).Append("\n");
            sb.Append("  _3ds: ").Append(ThreeDS).Append("\n");
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
            return obj.GetType() == GetType() && Equals((PaymentAcceptedResponse)obj);
        }

        /// <summary>
        /// Returns true if PaymentAcceptedResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of PaymentAcceptedResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentAcceptedResponse other)
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
                    Status == other.Status ||
                    Status != null &&
                    Status.Equals(other.Status)
                ) &&
                (
                    Reference == other.Reference ||
                    Reference != null &&
                    Reference.Equals(other.Reference)
                ) &&
                (
                    Customer == other.Customer ||
                    Customer != null &&
                    Customer.Equals(other.Customer)
                ) &&
                (
                    ThreeDS == other.ThreeDS ||
                    ThreeDS != null &&
                    ThreeDS.Equals(other.ThreeDS)
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
                if (Status != null)
                    hashCode = hashCode * 59 + Status.GetHashCode();
                if (Reference != null)
                    hashCode = hashCode * 59 + Reference.GetHashCode();
                if (Customer != null)
                    hashCode = hashCode * 59 + Customer.GetHashCode();
                if (ThreeDS != null)
                    hashCode = hashCode * 59 + ThreeDS.GetHashCode();
                if (Links != null)
                    hashCode = hashCode * 59 + Links.GetHashCode();
                return hashCode;
            }
        }

        public static bool operator ==(PaymentAcceptedResponse left, PaymentAcceptedResponse right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(PaymentAcceptedResponse left, PaymentAcceptedResponse right)
        {
            return !Equals(left, right);
        }
    }
}
