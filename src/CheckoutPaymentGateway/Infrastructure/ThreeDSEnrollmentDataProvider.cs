using CheckoutPaymentGateway.DataAccess;
using CheckoutPaymentGateway.DataAccess.Models;

namespace CheckoutPaymentGateway.Infrastructure
{
    public class ThreeDSEnrollmentDataProvider : BaseDataProvider<ThreeDSEnrollment>
    {
        public ThreeDSEnrollmentDataProvider(AppDbContext context) : base(context) { }
    }
}
