using CheckoutPaymentGateway.DataAccess;
using CheckoutPaymentGateway.DataAccess.Models;

namespace CheckoutPaymentGateway.Infrastructure
{
    public class MerchantDataProvider : BaseDataProvider<Merchant>
    {
        public MerchantDataProvider(AppDbContext context) : base(context) { }
    }
}
