using System;
using System.ComponentModel.DataAnnotations;

namespace CheckoutPaymentGateway.DataAccess.Models
{
    public class Customer : DatabaseEntity
    {
        [Key]
        public Guid Id { get; set; }

        [EmailAddress]
        [Required]
        public string Email { get; set; }

        public string Name { get; set; }

    }
}
