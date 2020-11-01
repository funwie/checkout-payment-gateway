using Newtonsoft.Json;
using Serilog.Core;
using System;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CheckoutPaymentGateway.Infrastructure
{
    public class ApiClient : IApiClient
    {
        public Task<TResult> PostAsync<TResult>(string path, IApiCredentials credentials, CancellationToken cancellationToken, object request = null, string idempotencyKey = null)
        {
            throw new NotImplementedException();
        }
    }
}
