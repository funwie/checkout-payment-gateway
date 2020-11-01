using AutoMapper;
using CheckoutPaymentGateway.DataAccess.Models;
using System;

namespace CheckoutPaymentGateway.MappingProfiles
{
    public class PhoneProfile : Profile
    {
        public PhoneProfile()
        {
            CreateMap<Common.Phone, Phone>()
                .ForMember(dest => dest.Id, source => source.MapFrom(req => Guid.NewGuid()));
        }
    }
}
