using CheckoutPaymentGateway.Components;
using CheckoutPaymentGateway.Requests;
using CheckoutPaymentGateway.Responses;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Swashbuckle.AspNetCore.Annotations;
using System;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace CheckoutPaymentGateway.Controllers
{

    /// <summary>
    /// Payments
    /// </summary>
    [Route("payments")]
    [ApiController]
    [Consumes("application/json")]
    [Produces("application/json")]
    public class PaymentsController : ControllerBase
    {
        private readonly IPaymentComponent _paymentComponent;

        public PaymentsController(IPaymentComponent paymentComponent)
        {
            _paymentComponent = paymentComponent;
        }

        /// <summary>
        /// Request a payment
        /// </summary>
        /// <remarks>To request a payment from a payment source. Send the payment source type and the required data to process a payment from the source</remarks>
        /// <param name="idempotencyKey">An optional idempotency key for safely retrying payment requests</param>
        /// <response code="201">Payment processed successfully</response>
        /// <response code="202">Payment asynchronous or further action required</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="422">Invalid data was sent</response>
        /// <response code="429">Too many requests or duplicate request detected</response>
        /// <response code="502">Bad gateway</response>
        [HttpPost]
        [Route("")]
        [SwaggerOperation("RequestAsync")]
        [SwaggerResponse(statusCode: 201, type: typeof(PaymentResponse), description: "Payment processed successfully")]
        [SwaggerResponse(statusCode: 202, type: typeof(PaymentAcceptedResponse), description: "Payment asynchronous or further action required")]
        [SwaggerResponse(statusCode: 401, description: "Unauthorized")]
        [SwaggerResponse(statusCode: 422, type: typeof(ValidationError), description: "Invalid data was sent")]
        [SwaggerResponse(statusCode: 429, type: typeof(ValidationError), description: "Too many requests or duplicate request detected")]
        [SwaggerResponse(statusCode: 502, type: typeof(ValidationError), description: "Bad gateway")]

        public async Task<JsonResult> RequestAsync([FromBody] PaymentRequest<CardRequest> paymentRequest, [FromHeader] string? idempotencyKey)
        {
            //TODO: Implement request auth
            // return StatusCode(401);

            //TODO: Implement request idempotencyKey check
            // return StatusCode(429, (ValidationError));

            //TODO: Implement request data validation
            // return StatusCode(422, (ValidationError));

            //TODO: Above passed, now process the payment
            // return StatusCode(201, default(PaymentResponse)); OR
            // return StatusCode(202, default(PaymentAcceptedResponse));
            
            var paymentReponse = _paymentComponent.CreatePaymentAsync(paymentRequest);
            
            //TODO: When expectional cases occur. Try to handle these cases by using Retry and Circuit Breakers
            // return StatusCode(502);


            string testingData = "{\n\"source\": {\n\"type\": \"token\",\n\"token\": \"tok_4gzeau5o2uqubbk6fufs3m7p54\"\n},\n\"amount\": 6540,\n\"currency\": \"USD\",\n\"payment_type\": \"Recurring\",\n\"reference\": \"ORD-5023-4E89\",\n\"description\": \"Set of 3 masks\",\n\"customer\": {\n\"id\": \"1ab3256d-e5da-4a97-a599-05c82154a5eb\",\n\"email\": \"jokershere@gmail.com\",\n\"name\": \"Jack Napier\"\n},\n\"billing_descriptor\": {\n\"name\": \"SUPERHEROES.COM\",\n\"city\": \"GOTHAM\"\n},\n\"shipping\": {\n\"address\": {},\n\"phone\": {}\n},\n\"3ds\": {\n\"enabled\": true,\n\"attempt_n3d\": true,\n\"eci\": \"05\",\n\"cryptogram\": \"AgAAAAAAAIR8CQrXcIhbQAAAAAA=\",\n\"xid\": \"MDAwMDAwMDAwMDAwMDAwMzIyNzY=\",\n\"version\": \"2.0.1\"\n},\n\"previous_payment_id\": \"pay_fun26akvvjjerahhctaq2uzhu4\",\n\"risk\": {\n\"enabled\": false\n},\n\"success_url\": \"http://example.com/payments/success\",\n\"failure_url\": \"http://example.com/payments/fail\",\n\"payment_ip\": \"90.197.169.245\",\n\"recipient\": {\n\"dob\": \"1985-05-15\",\n\"account_number\": \"5555554444\",\n\"zip\": \"W1T\",\n\"last_name\": \"Jones\"\n}\n}";

            var testHappyPathReponse = JsonConvert.DeserializeObject<PaymentResponse>(testingData);
            return new JsonResult(testHappyPathReponse);
        }

        /// <summary>
        /// Get payment details.
        /// </summary>
        /// <remarks>Returns the details of the payment with the specified identifier. </remarks>
        /// <param name="id">The payment or payment session identifier</param>
        /// <response code="200">Payment retrieved successfully</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="404">Payment not found</response>
        [HttpGet]
        [Route("{id}")]
        [SwaggerOperation("GetAsync")]
        [SwaggerResponse(statusCode: 200, type: typeof(PaymentDetails), description: "Payment retrieved successfully")]
        [SwaggerResponse(statusCode: 401, description: "Unauthorized")]
        [SwaggerResponse(statusCode: 404, description: "Payment not found")]
        public async Task<JsonResult> GetAsync([FromRoute][Required] Guid id)
        {
            //TODO: Implement request auth
            // return StatusCode(401);

            //TODO: Implement request data validation
            // return StatusCode(422, (ValidationError));

            //TODO: Get the payment
            // return StatusCode(200, (PaymentDetails)); OR
            // return StatusCode(404) we did not find a paymeent with that matches given id

            string testingData = "{\n  \"id\": \"1ab3256d-e5da-4a97-a599-05c82154a5eb\",\n  \"requested_on\": \"2020-10-28T17:05:18.816Z\",\n  \"source\": {\n    \"type\": \"card\",\n    \"id\": \"src_nwd3m4in3hkuddfpjsaevunhdy\",\n    \"billing_address\": {\n      \"address_line1\": \"Checkout.com\",\n      \"address_line2\": \"90 Tottenham Court Road\",\n      \"city\": \"London\",\n      \"state\": \"London\",\n      \"zip\": \"W1T 4TJ\",\n      \"country\": \"GB\"\n    },\n    \"phone\": {\n      \"country_code\": \"+1\",\n      \"number\": \"415 555 2671\"\n    }\n  },\n  \"destination\": {\n    \"type\": \"card\",\n    \"id\": \"1ab3256d-e5da-4a97-a599-05c82154a5eb \",\n    \"billing_address\": {\n      \"address_line1\": \"Checkout.com\",\n      \"address_line2\": \"90 Tottenham Court Road\",\n      \"city\": \"London\",\n      \"state\": \"London\",\n      \"zip\": \"W1T 4TJ\",\n      \"country\": \"GB\"\n    },\n    \"phone\": {\n      \"country_code\": \"+1\",\n      \"number\": \"415 555 2671\"\n    }\n  },\n  \"amount\": 6540,\n  \"currency\": \"USD\",\n  \"payment_type\": \"Recurring\",\n  \"reference\": \"ORD-5023-4E89\",\n  \"description\": \"Set of 3 masks\",\n  \"approved\": true,\n  \"status\": \"Authorized\",\n  \"3ds\": {\n    \"downgraded\": false,\n    \"enrolled\": \"Y\",\n    \"signature_valid\": \"Y\",\n    \"authentication_response\": \"Y\",\n    \"cryptogram\": \"hv8mUFzPzRZoCAAAAAEQBDMAAAA=\",\n    \"xid\": \"MDAwMDAwMDAwMDAwMDAwMzIyNzY=\",\n    \"version\": \"2.1.0\"\n  },\n  \"risk\": {\n    \"flagged\": true\n  },\n  \"customer\": {\n    \"id\": \"1ab3256d-e5da-4a97-a599-05c82154a5eb\",\n    \"email\": \"jokershere@gmail.com\",\n    \"name\": \"Jack Napier\"\n  },\n  \"billing_descriptor\": {\n    \"name\": \"SUPERHEROES.COM\",\n    \"city\": \"GOTHAM\"\n  },\n  \"shipping\": {\n    \"address\": {\n      \"address_line1\": \"Checkout.com\",\n      \"address_line2\": \"90 Tottenham Court Road\",\n      \"city\": \"London\",\n      \"state\": \"London\",\n      \"zip\": \"W1T 4TJ\",\n      \"country\": \"GB\"\n    },\n    \"phone\": {\n      \"country_code\": \"+1\",\n      \"number\": \"415 555 2671\"\n    }\n  },\n  \"payment_ip\": \"90.197.169.245\",\n  \"recipient\": {\n    \"dob\": \"1985-05-15\",\n    \"account_number\": \"5555554444\",\n    \"zip\": \"W1T\",\n    \"first_name\": \"John\",\n    \"last_name\": \"Jones\"\n  },\n  \"metadata\": {\n    \"coupon_code\": \"NY2018\",\n    \"partner_id\": 123989\n  },\n  \"eci\": \"06\",\n  \"scheme_id\": \"488341541494658\",\n  \"actions\": [\n    {\n      \"id\": \"act_y3oqhf46pyzuxjbcn2giaqnb44\",\n      \"type\": \"Authorization\",\n      \"response_code\": \"10000\",\n      \"response_summary\": \"Approved\"\n    }\n  ],\n  \"_links\": {\n    \"self\": {\n      \"href\": \"https://api.checkout.com/payments/pay_y3oqhf46pyzuxjbcn2giaqnb44\"\n    },\n    \"actions\": {\n      \"href\": \"https://api.checkout.com/payments/pay_y3oqhf46pyzuxjbcn2giaqnb44/actions\"\n    },\n    \"refund\": {\n      \"href\": \"https://api.checkout.com/payments/pay_y3oqhf46pyzuxjbcn2giaqnb44/refund\"\n    }\n  }\n}";
            var testHappyPathReponse = JsonConvert.DeserializeObject<PaymentDetails>(testingData);
            return new JsonResult(testHappyPathReponse);
        }

        
        //TODO: Implement Refund and Void if there is enough time

        ///// <summary>
        ///// Void a payment
        ///// </summary>
        ///// <remarks>Voids a payment if supported by the payment method.  For card payments, void requests are processed asynchronously. You can use [webhooks](#tag/Webhooks) to be notified if the void is successful. </remarks>
        ///// <param name="id">The payment identifier</param>
        ///// <param name="body"></param>
        ///// <param name="ckoIdempotencyKey">An optional idempotency key for safely retrying payment requests</param>
        ///// <response code="202">Void accepted</response>
        ///// <response code="401">Unauthorized</response>
        ///// <response code="403">Void not allowed</response>
        ///// <response code="404">Payment not found</response>
        ///// <response code="422">Invalid data was sent</response>
        ///// <response code="502">Bad gateway</response>
        //[HttpPost]
        //[Route("{id}/voids")]
        //[SwaggerOperation("VoidAsync")]
        //[SwaggerResponse(statusCode: 202, type: typeof(VoidAcceptedResponse), description: "Void accepted")]
        //[SwaggerResponse(statusCode: 401, description: "Unauthorized")]
        //[SwaggerResponse(statusCode: 403, description: "Void not allowed")]
        //[SwaggerResponse(statusCode: 404, description: "Payment not found")]
        //[SwaggerResponse(statusCode: 422, type: typeof(ValidationError), description: "Invalid data was sent")]
        //[SwaggerResponse(statusCode: 502, description: "Bad gateway")]
        //public async Task<JsonResult> VoidAsync([FromRoute][Required] Guid id, [FromBody] VoidRequest body, [FromHeader] string ckoIdempotencyKey)
        //{
        //    //TODO: Uncomment the next line to return response 202 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
        //    // return StatusCode(202, default(VoidAcceptedResponse));

        //    //TODO: Uncomment the next line to return response 401 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
        //    // return StatusCode(401);

        //    //TODO: Uncomment the next line to return response 403 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
        //    // return StatusCode(403);

        //    //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
        //    // return StatusCode(404);

        //    //TODO: Uncomment the next line to return response 422 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
        //    // return StatusCode(422, default(ValidationError));

        //    //TODO: Uncomment the next line to return response 502 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
        //    // return StatusCode(502);
        //    string exampleJson = null;
        //    exampleJson = "{\n  \"action_id\": \"act_y3oqhf46pyzuxjbcn2giaqnb44\",\n  \"reference\": \"ORD-5023-4E89\",\n  \"_links\": {\n    \"payment\": {\n      \"href\": \"https://api.checkout.com/payments/pay_y3oqhf46pyzuxjbcn2giaqnb44\"\n    }\n  }\n}";

        //    var example = JsonConvert.DeserializeObject<VoidAcceptedResponse>(exampleJson);
        //    return new JsonResult(example);
        //}

        ///// <summary>
        ///// Refund a payment
        ///// </summary>
        ///// <remarks>Refunds a payment if supported by the payment method.  For card payments, refund requests are processed asynchronously. You can use [webhooks](#tag/Webhooks) to be notified if the refund is successful. </remarks>
        ///// <param name="id">The payment identifier</param>
        ///// <param name="body"></param>
        ///// <param name="ckoIdempotencyKey">An optional idempotency key for safely retrying payment requests</param>
        ///// <response code="202">Refund accepted</response>
        ///// <response code="401">Unauthorized</response>
        ///// <response code="403">Refund not allowed</response>
        ///// <response code="404">Payment not found</response>
        ///// <response code="422">Invalid data was sent</response>
        ///// <response code="502">Bad gateway</response>
        //[HttpPost]
        //[Route("{id}/refunds")]
        //[SwaggerOperation("RefundAsync")]
        //[SwaggerResponse(statusCode: 202, type: typeof(RefundAcceptedResponse), description: "Refund accepted")]
        //[SwaggerResponse(statusCode: 401, description: "Unauthorized")]
        //[SwaggerResponse(statusCode: 403, description: "Refund not allowed")]
        //[SwaggerResponse(statusCode: 404, description: "Payment not found")]
        //[SwaggerResponse(statusCode: 422, type: typeof(ValidationError), description: "Invalid data was sent")]
        //[SwaggerResponse(statusCode: 502, description: "Bad gateway")]
        //public async Task<JsonResult> RefundAsync([FromRoute][Required] Guid id, [FromBody] RefundRequest body, [FromHeader] string ckoIdempotencyKey)
        //{
        //    //TODO: Uncomment the next line to return response 202 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
        //    // return StatusCode(202, default(RefundAcceptedResponse));

        //    //TODO: Uncomment the next line to return response 401 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
        //    // return StatusCode(401);

        //    //TODO: Uncomment the next line to return response 403 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
        //    // return StatusCode(403);

        //    //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
        //    // return StatusCode(404);

        //    //TODO: Uncomment the next line to return response 422 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
        //    // return StatusCode(422, default(ValidationError));

        //    //TODO: Uncomment the next line to return response 502 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
        //    // return StatusCode(502);
        //    string exampleJson = null;
        //    exampleJson = "{\n  \"action_id\": \"act_y3oqhf46pyzuxjbcn2giaqnb44\",\n  \"reference\": \"ORD-5023-4E89\",\n  \"_links\": {\n    \"payment\": {\n      \"href\": \"https://api.checkout.com/payments/pay_y3oqhf46pyzuxjbcn2giaqnb44\"\n    }\n  }\n}";

        //    var example = JsonConvert.DeserializeObject<RefundAcceptedResponse>(exampleJson);
        //    return new JsonResult(example);
        //}
    }
}
