using System;
using System.ComponentModel.DataAnnotations;

namespace CheckoutPaymentGateway.DataAccess.Models
{
    public class Card : DatabaseEntity
    {
        [Key]
        public Guid Id { get; set; }

        public string  Token { get; set; }

        public Guid CustomerId { get; set; }

        public string ExpiryMonth { get; set; }

        public string ExpiryYear { get; set; }

        public string Last4 { get; set; }

        public string PaymentMethod { get; set; }

        public string Fingerprint { get; set; }

        public string Name { get; set; }

        public string CvvCheck { get; set; }

        public string AvsCheck { get; set; }
        public int SourceType { get; set; }

    }
}
