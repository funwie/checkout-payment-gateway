using CheckoutPaymentGateway.DataAccess;
using CheckoutPaymentGateway.DataAccess.Models;

namespace CheckoutPaymentGateway.Infrastructure
{
    public class CustomerDataProvider : BaseDataProvider<Customer>
    {
        public CustomerDataProvider(AppDbContext context) : base(context) { }
    }
}
