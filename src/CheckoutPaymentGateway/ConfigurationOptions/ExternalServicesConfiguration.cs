using CheckoutPaymentGateway.ConfigurationOptions;

namespace CheckoutPaymentGateway.Options
{
    public class ExternalServicesConfiguration
    {
        public ServiceOptions Acquirer { get; set; }
        public ServiceOptions Identity { get; set; }
    }
}
