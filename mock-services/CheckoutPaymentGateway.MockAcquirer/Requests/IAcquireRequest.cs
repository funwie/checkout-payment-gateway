namespace CheckoutPaymentGateway.MockAcquirer.Requests
{
    public interface IAcquireRequest
    {
        public long Amount { get; set; }
        //public ISource Source { get; set; }
        //public ISource Destination { get; set; }
    }
}
