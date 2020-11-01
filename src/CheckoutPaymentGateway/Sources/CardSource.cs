using CheckoutPaymentGateway.Common;
using CheckoutPaymentGateway.Requests;
using System;
using System.Text;

namespace CheckoutPaymentGateway.Sources
{
    public class CardSource : IRequestSource
    {
        /// <summary>
        /// Gets or Sets CustomerId
        /// </summary>
        public Guid CustomerId { get; set; }

        /// <summary>
        /// Gets or Sets ExpiryMonth
        /// </summary>
        public string ExpiryMonth { get; set; }

        /// <summary>
        /// Gets or Sets ExpiryYear
        /// </summary>
        public string ExpiryYear { get; set; }

        /// <summary>
        /// Gets or Sets BillingDetails
        /// </summary>
        public ShippingDetails BillingDetails { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Last4
        /// </summary>
        public string Last4 { get; set; }

        /// <summary>
        /// Gets or Sets PaymentMethod
        /// </summary>
        public string PaymentMethod { get; set; }

        /// <summary>
        /// Gets or Sets Fingerprint
        /// </summary>
        public string Fingerprint { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets CvvCheck
        /// </summary>
        public string CvvCheck { get; set; }

        /// <summary>
        /// Gets or Sets AvsCheck
        /// </summary>
        public string AvsCheck { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Card {\n");
            sb.Append("  CustomerId: ").Append(CustomerId).Append("\n");
            sb.Append("  ExpiryMonth: ").Append(ExpiryMonth).Append("\n");
            sb.Append("  ExpiryYear: ").Append(ExpiryYear).Append("\n");
            sb.Append("  BillingDetails: ").Append(BillingDetails).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Last4: ").Append(Last4).Append("\n");
            sb.Append("  PaymentMethod: ").Append(PaymentMethod).Append("\n");
            sb.Append("  Fingerprint: ").Append(Fingerprint).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  CvvCheck: ").Append(CvvCheck).Append("\n");
            sb.Append("  AvsCheck: ").Append(AvsCheck).Append("\n");
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
            return obj.GetType() == GetType() && Equals((CardSource)obj);
        }

        /// <summary>
        /// Returns true if Card instances are equal
        /// </summary>
        /// <param name="other">Instance of Card to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CardSource other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return
                (
                    CustomerId == other.CustomerId ||
                    CustomerId != null &&
                    CustomerId.Equals(other.CustomerId)
                ) &&
                (
                    ExpiryMonth == other.ExpiryMonth ||
                    ExpiryMonth != null &&
                    ExpiryMonth.Equals(other.ExpiryMonth)
                ) &&
                (
                    ExpiryYear == other.ExpiryYear ||
                    ExpiryYear != null &&
                    ExpiryYear.Equals(other.ExpiryYear)
                ) &&
                (
                    BillingDetails == other.BillingDetails ||
                    BillingDetails != null &&
                    BillingDetails.Equals(other.BillingDetails)
                ) &&
                (
                    Id == other.Id ||
                    Id != null &&
                    Id.Equals(other.Id)
                ) &&
                (
                    Last4 == other.Last4 ||
                    Last4 != null &&
                    Last4.Equals(other.Last4)
                ) &&
                (
                    PaymentMethod == other.PaymentMethod ||
                    PaymentMethod != null &&
                    PaymentMethod.Equals(other.PaymentMethod)
                ) &&
                (
                    Fingerprint == other.Fingerprint ||
                    Fingerprint != null &&
                    Fingerprint.Equals(other.Fingerprint)
                ) &&
                (
                    Name == other.Name ||
                    Name != null &&
                    Name.Equals(other.Name)
                ) &&
                (
                    CvvCheck == other.CvvCheck ||
                    CvvCheck != null &&
                    CvvCheck.Equals(other.CvvCheck)
                ) &&
                (
                    AvsCheck == other.AvsCheck ||
                    AvsCheck != null &&
                    AvsCheck.Equals(other.AvsCheck)
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
                if (CustomerId != null)
                    hashCode = hashCode * 59 + CustomerId.GetHashCode();
                if (ExpiryMonth != null)
                    hashCode = hashCode * 59 + ExpiryMonth.GetHashCode();
                if (ExpiryYear != null)
                    hashCode = hashCode * 59 + ExpiryYear.GetHashCode();
                if (BillingDetails != null)
                    hashCode = hashCode * 59 + BillingDetails.GetHashCode();
                if (Id != null)
                    hashCode = hashCode * 59 + Id.GetHashCode();
                if (Last4 != null)
                    hashCode = hashCode * 59 + Last4.GetHashCode();
                if (PaymentMethod != null)
                    hashCode = hashCode * 59 + PaymentMethod.GetHashCode();
                if (Fingerprint != null)
                    hashCode = hashCode * 59 + Fingerprint.GetHashCode();
                if (Name != null)
                    hashCode = hashCode * 59 + Name.GetHashCode();
                if (CvvCheck != null)
                    hashCode = hashCode * 59 + CvvCheck.GetHashCode();
                if (AvsCheck != null)
                    hashCode = hashCode * 59 + AvsCheck.GetHashCode();
                return hashCode;
            }
        }

        public static bool operator ==(CardSource left, CardSource right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(CardSource left, CardSource right)
        {
            return !Equals(left, right);
        }
    }
}
