using CheckoutPaymentGateway.MockAcquirer.Common;
using System;

namespace CheckoutPaymentGateway.MockAcquirer.Responses
{
    public class AcquirePaymentResponse
    {
        public Guid AcquireId { get; set; }
        public PaymentStatus Status { get; set; }
    }
}
