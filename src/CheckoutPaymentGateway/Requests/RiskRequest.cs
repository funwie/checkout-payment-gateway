using System.Text;

namespace CheckoutPaymentGateway.Requests
{
    /// <summary>
    /// The risk assessment performed during the processing of a payment.
    /// </summary>
    public class RiskRequest
    {
        /// <summary>
        /// Whether the payment was flagged by a risk check
        /// </summary>
        /// <value>Whether the payment was flagged by a risk check</value>
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
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj.GetType() == GetType() && Equals((RiskRequest)obj);
        }

        /// <summary>
        /// Returns true if PaymentRisk instances are equal
        /// </summary>
        /// <param name="other">Instance of PaymentRisk to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RiskRequest other)
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

        public static bool operator ==(RiskRequest left, RiskRequest right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(RiskRequest left, RiskRequest right)
        {
            return !Equals(left, right);
        }
    }
}
