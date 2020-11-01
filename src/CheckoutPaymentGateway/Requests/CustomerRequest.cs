using System;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CheckoutPaymentGateway.Requests
{
    /// <summary>
    /// A customer in a payment request.
    /// </summary>
    public class CustomerRequest
    {
        /// <summary>
        /// The unique identifier of the customer. This can be passed as a source when making a payment.
        /// Th customers default payment will  be used when customer id is passed as a source.
        /// </summary>
        [Required]
        public Guid Id { get; set; }

        /// <summary>
        /// The customer&#x27;s email address
        /// </summary>
        /// <value>The customer&#x27;s email address</value>
        public string Email { get; set; }

        /// <summary>
        /// The customer&#x27;s name
        /// </summary>
        /// <value>The customer&#x27;s name</value>
        public string Name { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PaymentCustomer {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
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
            return obj.GetType() == GetType() && Equals((CustomerRequest)obj);
        }

        /// <summary>
        /// Returns true if PaymentCustomer instances are equal
        /// </summary>
        /// <param name="other">Instance of PaymentCustomer to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CustomerRequest other)
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
                    Email == other.Email ||
                    Email != null &&
                    Email.Equals(other.Email)
                ) &&
                (
                    Name == other.Name ||
                    Name != null &&
                    Name.Equals(other.Name)
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
                if (Email != null)
                    hashCode = hashCode * 59 + Email.GetHashCode();
                if (Name != null)
                    hashCode = hashCode * 59 + Name.GetHashCode();
                return hashCode;
            }
        }

        public static bool operator ==(CustomerRequest left, CustomerRequest right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(CustomerRequest left, CustomerRequest right)
        {
            return !Equals(left, right);
        }
    }
}
