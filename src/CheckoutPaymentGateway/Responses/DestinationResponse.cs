namespace CheckoutPaymentGateway.Responses
{
    /// <summary>
    /// Destination for the payment.
    /// Destination is Payment source going in reverse? pay in, instead of pay out
    /// Again. There are many destinations so base interface will be used
    /// </summary>
    public class DestinationResponse
    {
        /// <summary>
        /// Account Number
        /// </summary>
        public string AccountNumber { get; set; }

        /// <summary>
        /// Account Bank
        /// </summary>
        public string Bank { get; set; }

    }
}
