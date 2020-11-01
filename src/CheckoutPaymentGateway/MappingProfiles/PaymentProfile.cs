using AutoMapper;
using CheckoutPaymentGateway.DataAccess.Models;
using CheckoutPaymentGateway.Requests;
using System;

namespace CheckoutPaymentGateway.MappingProfiles
{
    public class PaymentProfile : Profile
    {
        public PaymentProfile()
        {
            CreateMap<PaymentRequest<CardRequest>, Payment>()
                .ForMember(dest => dest.Id, src => src.MapFrom(req => Guid.NewGuid()))
                .ForMember(dest => dest.Amount, src => src.MapFrom(req => req.Amount))
                .ForMember(dest => dest.RequestedOn, src => src.MapFrom(req => DateTime.Now))
                .ForMember(dest => dest.Currency, src => src.MapFrom(req => req.Currency))
                .ForMember(dest => dest.PaymentType, src => src.MapFrom(req => req.PaymentType))
                .ForMember(dest => dest.Reference, src => src.MapFrom(req => req.Reference))
                .ForMember(dest => dest.Description, src => src.MapFrom(req => req.Description))
                .ForMember(dest => dest.PaymentIp, src => src.MapFrom(req => req.PaymentIp))
                .ForMember(dest => dest.MerchantInitiated, src => src.MapFrom(req => req.MerchantInitiated))
                .ForMember(dest => dest.PreviousPaymentId, src => src.MapFrom(req => req.PreviousPaymentId))
                .ForMember(dest => dest.SuccessUrl, src => src.MapFrom(req => req.FailureUrl))
                .ForMember(dest => dest.FailureUrl, src => src.MapFrom(req => req.FailureUrl));
        }
    }
}
