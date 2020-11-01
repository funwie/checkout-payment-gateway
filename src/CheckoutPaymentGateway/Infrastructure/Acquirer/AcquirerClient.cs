using CheckoutPaymentGateway.Requests;
using CheckoutPaymentGateway.Responses;
using System.Threading.Tasks;

namespace CheckoutPaymentGateway.Infrastructure.Acquirer
{
    public class AcquirerClient : IAcquirerClient

    {
        Task<AcquirePaymentResponse> IAcquirerClient.Acquire(AcquirePaymentReqest acquirePaymentReqest)
        {
            throw new System.NotImplementedException();
        }
    }
}
