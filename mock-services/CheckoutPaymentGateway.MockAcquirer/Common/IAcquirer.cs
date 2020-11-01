using CheckoutPaymentGateway.MockAcquirer.Requests;
using CheckoutPaymentGateway.MockAcquirer.Responses;
using System.Threading.Tasks;

namespace CheckoutPaymentGateway.MockAcquirer.Common
{
    public interface IAcquirer
    {
        Task<IAcquireResponse> Acquire(IAcquireRequest acquirerRequest);
    }
}
