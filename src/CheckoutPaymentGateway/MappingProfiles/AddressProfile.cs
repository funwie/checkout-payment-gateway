using AutoMapper;
using CheckoutPaymentGateway.DataAccess.Models;
using System;

namespace CheckoutPaymentGateway.MappingProfiles
{
    public class AddressProfile : Profile
    {
        public AddressProfile()
        {
            CreateMap<Common.Address, Address>()
                .ForMember(dest => dest.Id, source => source.MapFrom(req => Guid.NewGuid()));
        }
    }
}
