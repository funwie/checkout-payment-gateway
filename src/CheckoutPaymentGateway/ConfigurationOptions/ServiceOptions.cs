using System;

namespace CheckoutPaymentGateway.ConfigurationOptions
{
    /// <summary>
    /// Options to access other services
    /// Assumes that these services use Client key and secret key for auth
    /// </summary>
    public class ServiceOptions
    {
        /// <summary>
        /// Url of the service.
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// Client Key for auth.
        /// </summary>
        public string ClientKey { get; set; }

        /// <summary>
        /// Secret Key for auth.
        /// </summary>
        public string SecretKey { get; set; }
    }
}
