using AutoMapper;
using CheckoutPaymentGateway.DataAccess.Models;
using CheckoutPaymentGateway.Requests;
using System;

namespace CheckoutPaymentGateway.MappingProfiles
{
    public class RiskProfile : Profile
    {
        public RiskProfile()
        {
            CreateMap<RiskRequest, Risk>()
                .ForMember(dest => dest.FlaggedOn, source => source.MapFrom(req => DateTime.Now))
                .ForMember(dest => dest.Id, source => source.MapFrom(req => Guid.NewGuid()));
        }
    }
}
