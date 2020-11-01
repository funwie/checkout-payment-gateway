namespace CheckoutPaymentGateway.Responses
{
    /// <summary>
    /// A payment source returned in a payment response.
    /// </summary>
    public class IResponseSource
    {
        /// <summary>
        /// Gets the final payment source type. For payment request sources that result in a card payment (token, source ID etc.) 
        /// this will be card otherwise the name of the alternative payment method.
        /// </summary>
        string Type { get; }
    }
}
