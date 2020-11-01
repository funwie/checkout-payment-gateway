using CheckoutPaymentGateway.DataAccess;
using CheckoutPaymentGateway.DataAccess.Models;

namespace CheckoutPaymentGateway.Infrastructure
{
    public class SourceDataProvider : BaseDataProvider<Card>
    {
        public SourceDataProvider(AppDbContext context) : base(context) { }
    }
}
