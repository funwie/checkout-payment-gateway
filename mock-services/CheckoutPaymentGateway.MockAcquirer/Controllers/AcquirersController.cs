using CheckoutPaymentGateway.MockAcquirer.Requests;
using CheckoutPaymentGateway.MockAcquirer.Responses;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using System.Text.Json;
using System.Threading.Tasks;

namespace CheckoutPaymentGateway.MockAcquirer.Controllers
{
    [Route("acquire")]
    [ApiController]
    [Consumes("application/json")]
    [Produces("application/json")]

    public class AcquirersController : ControllerBase
    {
        /// <summary>
        /// Acquire a payment
        /// </summary>
        /// <param name="idempotencyKey">An optional idempotency key for safely retrying acquire requests </param>
        /// <response code="201">Payment acquired successfully</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="422">Invalid data was sent</response>
        /// <response code="429">Too many requests or duplicate request detected</response>
        /// <response code="502">Bad Acquirer</response>
        [HttpPost]
        [Route("")]
        [SwaggerOperation("AcquirePayment")]
        [SwaggerResponse(statusCode: 201, type: typeof(AcquirePaymentResponse), description: "Payment Acquired successfully")]
        [SwaggerResponse(statusCode: 401, description: "Unauthorized")]
        [SwaggerResponse(statusCode: 422, description: "Invalid data was sent")]
        [SwaggerResponse(statusCode: 429, description: "Too many requests or duplicate request detected")]
        [SwaggerResponse(statusCode: 502, description: "Bad Acquirer")]
        public async Task<JsonResult> AcquirePayment([FromBody] AcquirePaymentResquest acquireRequest, [FromHeader] string? idempotencyKey)
        {
            var testData = "{\n\"acquire_id\":\"ed45d7b1-387f-43be-9650-f74cb07bacb6\"\n\"status\": \"Approved\"\n}";
            var testReponse = JsonSerializer.Deserialize<AcquirePaymentResponse>(testData);
            return new JsonResult(testReponse);

        }
    }
}
