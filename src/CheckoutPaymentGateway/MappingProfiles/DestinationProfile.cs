using AutoMapper;
using CheckoutPaymentGateway.DataAccess.Models;
using CheckoutPaymentGateway.Responses;

namespace CheckoutPaymentGateway.MappingProfiles
{
    /// <summary>
    /// Map merchant bank details to payment destination
    /// </summary>
    public class DestinationProfile : Profile
    {
        public DestinationProfile()
        {
            CreateMap<Merchant, DestinationResponse>()
                .ForMember(dest => dest.AccountNumber, source => source.MapFrom(res => res.AccountNumber))
                .ForMember(dest => dest.Bank, source => source.MapFrom(res => res.Bank));
        }
    }
}
