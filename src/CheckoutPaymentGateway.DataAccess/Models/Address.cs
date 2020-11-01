using System;
using System.ComponentModel.DataAnnotations;

namespace CheckoutPaymentGateway.DataAccess.Models
{
    public class Address : DatabaseEntity
    {
        [Key]
        public Guid Id { get; set; }
        public string AddressLine1 { get; set; }

        public string AddressLine2 { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string Zip { get; set; }

        public string Country { get; set; }
        public Guid Owner { get; set; }
    }
}
