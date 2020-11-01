using CheckoutPaymentGateway.Enums;
using System;

namespace CheckoutPaymentGateway.Responses
{
    public class AcquirePaymentResponse
    {
        public Guid AcquireId { get; set; }
        public PaymentStatus Status { get; set; }
    }
}
