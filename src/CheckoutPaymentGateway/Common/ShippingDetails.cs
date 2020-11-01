namespace CheckoutPaymentGateway.Common
{
    /// <summary>
    /// The shipping details for a payment request.
    /// </summary>
    public class ShippingDetails
    {
        /// <summary>
        /// Gets or sets the shipping address.
        /// </summary>
        public Address Address { get; set; }

        /// <summary>
        /// Gets or sets the phone number associated with the shipping address.
        /// </summary>
        public Phone Phone { get; set; }
    }
}
