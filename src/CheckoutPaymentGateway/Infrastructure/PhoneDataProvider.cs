using CheckoutPaymentGateway.DataAccess;
using CheckoutPaymentGateway.DataAccess.Models;

namespace CheckoutPaymentGateway.Infrastructure
{
    public class PhoneDataProvider : BaseDataProvider<Phone>
    {
        public PhoneDataProvider(AppDbContext context) : base(context) { }
    }
}
