using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CheckoutPaymentGateway.Common
{
    /// <summary>
    /// The billing description to be displayed on the account owner's statement.
    /// </summary>
    public class BillingDescriptor
    {
        /// <summary>
        /// A dynamic description of the charge
        /// </summary>
        [Required]
        public string Name { get; set; }

        /// <summary>
        /// The city from which the charge originated
        /// </summary>
        [Required]
        public string City { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BillingDescriptor {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  City: ").Append(City).Append("\n");
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
            return obj.GetType() == GetType() && Equals((BillingDescriptor)obj);
        }

        /// <summary>
        /// Returns true if BillingDescriptor instances are equal
        /// </summary>
        /// <param name="other">Instance of BillingDescriptor to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BillingDescriptor other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return
                (
                    Name == other.Name ||
                    Name != null &&
                    Name.Equals(other.Name)
                ) &&
                (
                    City == other.City ||
                    City != null &&
                    City.Equals(other.City)
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
                if (Name != null)
                    hashCode = hashCode * 59 + Name.GetHashCode();
                if (City != null)
                    hashCode = hashCode * 59 + City.GetHashCode();
                return hashCode;
            }
        }

        public static bool operator ==(BillingDescriptor left, BillingDescriptor right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(BillingDescriptor left, BillingDescriptor right)
        {
            return !Equals(left, right);
        }
    }
}
