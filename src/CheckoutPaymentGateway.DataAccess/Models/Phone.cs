using System;
using System.ComponentModel.DataAnnotations;

namespace CheckoutPaymentGateway.DataAccess.Models
{
    public class Phone : DatabaseEntity
    {
        [Key]
        public Guid Id { get; set; }
        public string CountryCode { get; set; }

        public string Number { get; set; }

        public Guid Owner { get; set; }

    }
}