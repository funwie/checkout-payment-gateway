using CheckoutPaymentGateway.DataAccess;
using CheckoutPaymentGateway.DataAccess.Models;

namespace CheckoutPaymentGateway.Infrastructure
{
    public class RiskDataProvider : BaseDataProvider<Risk>
    {
        public RiskDataProvider(AppDbContext context) : base(context) { }
    }
}
