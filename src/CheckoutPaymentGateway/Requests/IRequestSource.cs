namespace CheckoutPaymentGateway.Requests
{
    /// <summary>
    /// A payment source in a payment request.
    /// Source is payment method dependant.
    /// </summary>
    public class IRequestSource
    {
        /// <summary>
        /// The payment source type. 
        /// </summary>
        string Type { get; }
    }
}
