using System.Threading;
using System.Threading.Tasks;

namespace CheckoutPaymentGateway.Infrastructure
{
    public interface IApiClient
    {
        /// <summary>
        /// Executes a POST request to the specified <paramref="path"/>. 
        /// </summary>
        /// <param name="path">The API resource path.</param>
        /// <param name="credentials">The credentials used to authenticate the request.</param>
        /// <param name="cancellationToken">A cancellation token that can be used to cancel the underlying HTTP request.</param>
        /// <param name="request">Optional data that should be sent in the request body.</param>
        /// <param name="idempotencyKey">Optional idempotency key to safely retry payment requests.</param>
        /// <typeparam name="TResult">The expected response type to be deserialized.</typeparam>
        /// <returns>A task that upon completion contains the specified API response data.</returns>
        Task<TResult> PostAsync<TResult>(string path, IApiCredentials credentials, CancellationToken cancellationToken, object request = null, string idempotencyKey = null);
    }
}
