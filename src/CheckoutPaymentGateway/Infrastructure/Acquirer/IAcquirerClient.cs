using CheckoutPaymentGateway.Requests;
using CheckoutPaymentGateway.Responses;
using System.Threading.Tasks;

namespace CheckoutPaymentGateway.Infrastructure.Acquirer
{
    /// <summary>
    /// Interface for Acquirer services consumed by the gateway
    /// </summary>
    public interface IAcquirerClient
    {
        Task<AcquirePaymentResponse> Acquire(AcquirePaymentReqest acquirePaymentReqest);
    }
}
