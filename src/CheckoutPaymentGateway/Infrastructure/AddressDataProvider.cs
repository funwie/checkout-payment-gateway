using CheckoutPaymentGateway.DataAccess;
using CheckoutPaymentGateway.DataAccess.Models;

namespace CheckoutPaymentGateway.Infrastructure
{
    public class AddressDataProvider : BaseDataProvider<Address>
    {
        public AddressDataProvider(AppDbContext context) : base(context) { }
    }
}
