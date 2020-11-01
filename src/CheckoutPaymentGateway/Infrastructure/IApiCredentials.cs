using System.Net.Http;
using System.Threading.Tasks;

namespace CheckoutPaymentGateway.Infrastructure
{
    public interface IApiCredentials
    {
        /// <summary>
        /// Authorizes the request.
        /// </summary>
        /// <param name="httpRequest">The HTTP request to authorize.</param>
        Task AuthorizeAsync(HttpRequestMessage httpRequest);
    }
}
