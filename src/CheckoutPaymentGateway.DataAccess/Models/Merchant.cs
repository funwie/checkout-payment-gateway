using System;
using System.ComponentModel.DataAnnotations;

namespace CheckoutPaymentGateway.DataAccess.Models
{
    public class Merchant : DatabaseEntity
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }

        public string AccountNumber { get; set; }
        public string Bank { get; set; }

        // This will never be stored this way
        // It's just a simple solution for now
        public string PublickKey { get; set; }
        public string SecretKey { get; set; }
    }
}
