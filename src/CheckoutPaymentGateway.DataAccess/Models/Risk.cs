using System;

namespace CheckoutPaymentGateway.DataAccess.Models
{
    public class Risk : DatabaseEntity
    {
        public Guid Id { get; set; }
        public bool? Flagged { get; set; }
        public DateTimeOffset FlaggedOn { get; set; }
    }
}
