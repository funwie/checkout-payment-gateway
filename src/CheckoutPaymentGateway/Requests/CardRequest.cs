using System;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CheckoutPaymentGateway.Requests
{
    public class CardRequest : IRequestSource
    {
        /// <summary>
        /// Gets or Sets CustomerId
        /// </summary>
        public Guid CustomerId { get; set; }

        /// <summary>
        /// Gets or Sets ExpiryMonth
        /// </summary>
        [Required]
        [CreditCard]
        public string Number { get; set; }

        /// <summary>
        /// Gets or Sets ExpiryMonth
        /// </summary>
        [MaxLength(2)]
        public string ExpiryMonth { get; set; }

        /// <summary>
        /// Gets or Sets ExpiryYear
        /// </summary>
        [MaxLength(4)]
        public string ExpiryYear { get; set; }

        /// <summary>
        /// Gets or Sets Id for existing card
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or Sets Last4
        /// </summary>
        [MaxLength(4)]
        public string Last4 { get; set; }

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
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Last4: ").Append(Last4).Append("\n");
            sb.Append("  Fingerprint: ").Append(Fingerprint).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  CvvCheck: ").Append(CvvCheck).Append("\n");
            sb.Append("  AvsCheck: ").Append(AvsCheck).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
