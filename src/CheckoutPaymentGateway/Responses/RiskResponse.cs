using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace CheckoutPaymentGateway.Responses
{
    /// <summary>
    /// The risk assessment response after risk analysis during payment processing.
    /// </summary>
    public class RiskResponse
    {
        /// <summary>
        /// Whether the payment was flagged by a risk check
        /// </summary>
        [DataMember(Name = "flagged")]
        public bool? Flagged { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PaymentRisk {\n");
            sb.Append("  Flagged: ").Append(Flagged).Append("\n");
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
            return obj.GetType() == GetType() && Equals((RiskResponse)obj);
        }

        /// <summary>
        /// Returns true if PaymentRisk instances are equal
        /// </summary>
        /// <param name="other">Instance of PaymentRisk to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RiskResponse other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return
                (
                    Flagged == other.Flagged ||
                    Flagged != null &&
                    Flagged.Equals(other.Flagged)
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
                if (Flagged != null)
                    hashCode = hashCode * 59 + Flagged.GetHashCode();
                return hashCode;
            }
        }

        public static bool operator ==(RiskResponse left, RiskResponse right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(RiskResponse left, RiskResponse right)
        {
            return !Equals(left, right);
        }
    }

}
