using CheckoutPaymentGateway.Requests;
using CheckoutPaymentGateway.Responses;
using System;
using System.Threading.Tasks;

namespace CheckoutPaymentGateway.Components
{
    public interface IPaymentComponent
    {
        /// <summary>
        /// Create a payment from a request
        /// Mapping to CardRequest source for now. Should be IRequestSource
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<PaymentResponse> CreatePaymentAsync(PaymentRequest<CardRequest> request);
        Task<PaymentDetails> RetrievePaymentAsync(Guid paymentId);
    }
}
