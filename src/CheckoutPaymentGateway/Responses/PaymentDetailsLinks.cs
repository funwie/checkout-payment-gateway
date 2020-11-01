using CheckoutPaymentGateway.Common;
using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace CheckoutPaymentGateway.Responses
{
    public class PaymentDetailsLinks
    {
        /// <summary>
        /// The URI of the payment
        /// </summary>
        /// <value>The URI of the payment</value>
        [DataMember(Name = "self")]
        public Link Self { get; set; }

        /// <summary>
        /// A link to the payment&#x27;s associated actions
        /// </summary>
        /// <value>A link to the payment&#x27;s associated actions</value>
        [DataMember(Name = "actions")]
        public Link Actions { get; set; }

        /// <summary>
        /// A link to void the payment, where applicable
        /// </summary>
        /// <value>A link to void the payment, where applicable</value>
        [DataMember(Name = "void")]
        public Link Void { get; set; }

        /// <summary>
        /// A link to refund the payment, where applicable
        /// </summary>
        public Link Refund { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PaymentLinks {\n");
            sb.Append("  Self: ").Append(Self).Append("\n");
            sb.Append("  Actions: ").Append(Actions).Append("\n");
            sb.Append("  Void: ").Append(Void).Append("\n");
            sb.Append("  Refund: ").Append(Refund).Append("\n");
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
            return obj.GetType() == GetType() && Equals((PaymentDetailsLinks)obj);
        }

        /// <summary>
        /// Returns true if PaymentLinks instances are equal
        /// </summary>
        /// <param name="other">Instance of PaymentLinks to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentDetailsLinks other)
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
                    Actions == other.Actions ||
                    Actions != null &&
                    Actions.Equals(other.Actions)
                ) &&
                (
                    Void == other.Void ||
                    Void != null &&
                    Void.Equals(other.Void)
                ) &&
                (
                    Refund == other.Refund ||
                    Refund != null &&
                    Refund.Equals(other.Refund)
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
                if (Actions != null)
                    hashCode = hashCode * 59 + Actions.GetHashCode();
                if (Void != null)
                    hashCode = hashCode * 59 + Void.GetHashCode();
                if (Refund != null)
                    hashCode = hashCode * 59 + Refund.GetHashCode();
                return hashCode;
            }
        }

        public static bool operator ==(PaymentDetailsLinks left, PaymentDetailsLinks right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(PaymentDetailsLinks left, PaymentDetailsLinks right)
        {
            return !Equals(left, right);
        }
    }
}
