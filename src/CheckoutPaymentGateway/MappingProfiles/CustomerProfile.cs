using AutoMapper;
using CheckoutPaymentGateway.DataAccess.Models;

namespace CheckoutPaymentGateway.Requests
{
    public class CustomerProfile : Profile
    {
        public CustomerProfile()
        {
            CreateMap<CustomerRequest, Customer>();
        }
    }
}
