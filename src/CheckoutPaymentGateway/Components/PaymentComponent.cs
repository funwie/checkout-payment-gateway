using AutoMapper;
using CheckoutPaymentGateway.DataAccess.Models;
using CheckoutPaymentGateway.Infrastructure;
using CheckoutPaymentGateway.Requests;
using CheckoutPaymentGateway.Responses;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;

namespace CheckoutPaymentGateway.Components
{
    /// <summary>
    /// Component to aggregate payment data and services
    /// It's too big, should be broken into smaller components
    /// </summary>
    public class PaymentComponent : IPaymentComponent
    {
        // This should definitely be improved to have separate interface for each provider (good for testing)
        // we can also put all these in a wrapper
        private readonly IBaseDataProvider<Payment> _paymentDataProvider;
        private readonly IBaseDataProvider<Merchant> _merchantDataProvider;
        private readonly IBaseDataProvider<Card> _sourceDataProvider;
        private readonly IBaseDataProvider<Customer> _customerDataProvider;
        private readonly IBaseDataProvider<Address> _addressDataProvider;
        private readonly IBaseDataProvider<Phone> _phoneDataProvider;
        private readonly IBaseDataProvider<Risk> _riskDataProvider;
        private readonly IBaseDataProvider<ThreeDSEnrollment> _threeDsDataProvider;
        private readonly IMapper _mapper;
        private readonly ILogger<PaymentComponent> _logger;

        public PaymentComponent(

            IBaseDataProvider<Payment> paymentDataProvider,
            IBaseDataProvider<Merchant> merchantDataProvider,
            IBaseDataProvider<Card> sourceDataProvider,
            IBaseDataProvider<Customer> customerDataProvider,
            IBaseDataProvider<Address> addressDataProvider,
            IBaseDataProvider<Phone> phoneDataProvider,
            IBaseDataProvider<Risk> riskDataProvider,
            IBaseDataProvider<ThreeDSEnrollment> threeDsDataProvider,
            IMapper mapper,
            ILogger<PaymentComponent> logger)
        {

            _paymentDataProvider = paymentDataProvider ?? throw new ArgumentNullException(nameof(paymentDataProvider));
            _merchantDataProvider = merchantDataProvider ?? throw new ArgumentNullException(nameof(merchantDataProvider));
            _sourceDataProvider = sourceDataProvider ?? throw new ArgumentNullException(nameof(sourceDataProvider));
            _customerDataProvider = customerDataProvider ?? throw new ArgumentNullException(nameof(customerDataProvider));
            _addressDataProvider = addressDataProvider ?? throw new ArgumentNullException(nameof(addressDataProvider));
            _phoneDataProvider = phoneDataProvider ?? throw new ArgumentNullException(nameof(phoneDataProvider));
            _riskDataProvider = riskDataProvider ?? throw new ArgumentNullException(nameof(riskDataProvider));
            _threeDsDataProvider = threeDsDataProvider ?? throw new ArgumentNullException(nameof(threeDsDataProvider));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        /// <summary>
        /// Create a payment
        /// Mapping to CardRequest source for now. Should be IRequestSource
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<PaymentResponse> CreatePaymentAsync(PaymentRequest<CardRequest> request)
        {
            if (request == null) throw new ArgumentNullException(nameof(request));

            // TO DO
            // assuming that request is already athuthenticated and authorized
            // Validate request data
            // perform threeDS if enrolled
            // create payment request Id (for retries)
            // Verify Payment source (Card details)
            // Perform Risk Analysis (paymentIp and more)
            // Get marchant details from merchant service
            // Store payment information with merchant details attached,
            // Create acquire request with merchant and payment details payment
            // Forward acquire request to Acquiring Bank
            // Accept acquire response from Bank
            // Update payment 

            // Send response to merchant or errors


            // This is just demostration to for now. It requires proper implementation
            // Needs to be broken into small units
            try
            {

                var payment = _mapper.Map<Payment>(request);
                var card = _mapper.Map<Card>(request.Source);
                var shippingAddress = _mapper.Map<Address>(request.Shipping.Address);
                var shippingPhone = _mapper.Map<Phone>(request.Shipping.Phone);
                var risk = _mapper.Map<Risk>(request.Risk);
                var threeDs = _mapper.Map<ThreeDSEnrollment>(request.ThreeDS);
                var customer = _mapper.Map<Customer>(request.Customer);
                card.CustomerId = customer.Id;
                shippingAddress.Owner = customer.Id;
                shippingPhone.Owner = customer.Id;
                payment.SourceId = card.Id;
                payment.RiskId = risk.Id;
                payment.ThreeDsId = threeDs.Id;
                payment.CustomerId = customer.Id;

                var savedAddress = _addressDataProvider.Insert(shippingAddress);
                var savedPhone = _phoneDataProvider.Insert(shippingPhone);
                var savedRisk = _riskDataProvider.Insert(risk);
                var savedThreeDs = _threeDsDataProvider.Insert(threeDs);
                var savedCustomer = _customerDataProvider.Insert(customer);
                var savedCard = _sourceDataProvider.Insert(card);
                

                // Receive the id after authentication is successful
                var merchantId = Guid.Parse("64feefe6-ccc9-4f75-a532-156b874d61c1");
                payment.DestinationId = merchantId;
                var savePayment =  _paymentDataProvider.Insert(payment);

                // Get merchant data from merchant saving or data store
                var merchant = await _merchantDataProvider.GetAsync(merchantId);

                //BuildAcquireRequest();

                // Send Acquire Request

                // Acquire resposne

                // update payment using action

                // Send Response to merchant client


            }
            catch(Exception ex)
            {
                _logger.LogCritical("Payment could not be created with id");
            }

            



            return new PaymentResponse();
        }

        public async Task<PaymentDetails> RetrievePaymentAsync(Guid paymentId)
        {
            // TO DO
            // assuming that request is already athuthenticated and authorized
            // get payment details
            var payment = await _paymentDataProvider.GetAsync(paymentId);
            // if not found return null  and null in coontrollerr and  return Not Found
            if (payment == null) return null;

            // Found - get related entities for response

            var savedCard = _sourceDataProvider.GetAsync(payment.SourceId);

            // Map entities to Response objects


            // return PaymentDetails

            return new PaymentDetails();
        }
    }
}
