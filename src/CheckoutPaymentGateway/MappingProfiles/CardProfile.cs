using AutoMapper;
using CheckoutPaymentGateway.DataAccess.Models;
using CheckoutPaymentGateway.Requests;
using System;

namespace CheckoutPaymentGateway.MappingProfiles
{
    public class CardProfile : Profile
    {
        public CardProfile()
        {
            CreateMap<CardRequest, Card>()
                .ForMember(dest => dest.Id, source => source.MapFrom(req => IsValidGuid(req.Id) ? req.Id : Guid.NewGuid()))
                .ForMember(dest => dest.Token, source => source.MapFrom(req => Guid.NewGuid()));
        }

        private bool IsValidGuid(Guid guid)
        {
            return guid != null && !Guid.Equals(guid, Guid.Empty);
        }
    }
}
