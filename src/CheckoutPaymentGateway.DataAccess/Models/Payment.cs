using System;
using System.ComponentModel.DataAnnotations;

namespace CheckoutPaymentGateway.DataAccess.Models
{
    public class Payment : DatabaseEntity
    {
        [Key]
        public Guid Id { get; set; }

        public DateTimeOffset RequestedOn { get; set; }

        public long? Amount { get; set; }

        public string Currency { get; set; }

        public int PaymentType { get; set; }

        public string Reference { get; set; }

        public string Description { get; set; }

        public bool? Approved { get; set; }

        public int Status { get; set; }

        public string PaymentIp { get; set; }
        public bool MerchantInitiated { get; set; }
        public Guid PreviousPaymentId { get; set; }
        public string SuccessUrl { get; set; }
        public string FailureUrl { get; set; }
        public Guid SourceId { get; set; }
        public string billing_name { get; set; }
        public string billing_city { get; set; }
        public Guid RiskId { get; set; }
        public Guid ThreeDsId { get; set; }
        public Guid CustomerId { get; set; }
        public Guid DestinationId { get; set; }
    }
}
