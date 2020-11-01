using AutoMapper;
using CheckoutPaymentGateway.Requests;
using System;

namespace CheckoutPaymentGateway.MappingProfiles
{
    public class ThreeDSEnrollmentProfile : Profile
    {
        public ThreeDSEnrollmentProfile()
        {
            CreateMap<ThreeDSRequest, DataAccess.Models.ThreeDSEnrollment>()
                .ForMember(dest => dest.Id, source => source.MapFrom(req => Guid.NewGuid()));
        }
    }
}
