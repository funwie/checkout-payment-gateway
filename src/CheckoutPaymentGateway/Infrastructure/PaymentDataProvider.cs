using CheckoutPaymentGateway.DataAccess;
using CheckoutPaymentGateway.DataAccess.Models;

namespace CheckoutPaymentGateway.Infrastructure
{
    public class PaymentDataProvider : BaseDataProvider<Payment>
    {
        public PaymentDataProvider(AppDbContext context) : base(context) { }
    }
}
