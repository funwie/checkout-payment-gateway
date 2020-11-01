using Newtonsoft.Json;
using System.Text;

namespace CheckoutPaymentGateway.Common
{
    /// <summary>
    /// A phone number.
    /// </summary>
    public class Phone
    {
        /// <summary>
        /// The international country calling code.
        /// </summary>
        public string CountryCode { get; set; }

        /// <summary>
        /// The phone number
        /// </summary>
        public string Number { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Phone {\n");
            sb.Append("  CountryCode: ").Append(CountryCode).Append("\n");
            sb.Append("  Number: ").Append(Number).Append("\n");
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
            return obj.GetType() == GetType() && Equals((Phone)obj);
        }

        /// <summary>
        /// Returns true if Phone instances are equal
        /// </summary>
        /// <param name="other">Instance of Phone to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Phone other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return
                (
                    CountryCode == other.CountryCode ||
                    CountryCode != null &&
                    CountryCode.Equals(other.CountryCode)
                ) &&
                (
                    Number == other.Number ||
                    Number != null &&
                    Number.Equals(other.Number)
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
                if (CountryCode != null)
                    hashCode = hashCode * 59 + CountryCode.GetHashCode();
                if (Number != null)
                    hashCode = hashCode * 59 + Number.GetHashCode();
                return hashCode;
            }
        }

        public static bool operator ==(Phone left, Phone right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Phone left, Phone right)
        {
            return !Equals(left, right);
        }

    }
}