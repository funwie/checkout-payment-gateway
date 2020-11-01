using Newtonsoft.Json;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace CheckoutPaymentGateway.Responses
{

    /// <summary>
    /// The Links related to an Accepted payment
    /// </summary>
    public class PaymentAcceptedResponseLinks
    {
        /// <summary>
        /// The URI of the payment
        /// </summary>
        [DataMember(Name = "self")]
        public PaymentResponseLinks Self { get; set; }

        /// <summary>
        /// The URI that the customer should be redirected to in order to complete the payment
        /// </summary>
        [DataMember(Name = "redirect")]
        public PaymentResponseLinks Redirect { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PaymentAcceptedResponseLinks {\n");
            sb.Append("  Self: ").Append(Self).Append("\n");
            sb.Append("  Redirect: ").Append(Redirect).Append("\n");
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
            return obj.GetType() == GetType() && Equals((PaymentAcceptedResponseLinks)obj);
        }

        /// <summary>
        /// Returns true if PaymentAcceptedResponseLinks instances are equal
        /// </summary>
        /// <param name="other">Instance of PaymentAcceptedResponseLinks to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentAcceptedResponseLinks other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return
                (
                    Self == other.Self ||
                    Self != null &&
                    Self.Equals(other.Self)
                ) &&
                (
                    Redirect == other.Redirect ||
                    Redirect != null &&
                    Redirect.Equals(other.Redirect)
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
                if (Self != null)
                    hashCode = hashCode * 59 + Self.GetHashCode();
                if (Redirect != null)
                    hashCode = hashCode * 59 + Redirect.GetHashCode();
                return hashCode;
            }
        }

        public static bool operator ==(PaymentAcceptedResponseLinks left, PaymentAcceptedResponseLinks right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(PaymentAcceptedResponseLinks left, PaymentAcceptedResponseLinks right)
        {
            return !Equals(left, right);
        }
    }
}
