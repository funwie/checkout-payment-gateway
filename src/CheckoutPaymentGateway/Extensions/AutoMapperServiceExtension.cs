using AutoMapper;
using CheckoutPaymentGateway.MappingProfiles;
using CheckoutPaymentGateway.Requests;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace CheckoutPaymentGateway.Extensions
{
    public static class AutoMapperServiceExtension
    {
        public static IServiceCollection AddAutoMapper(this IServiceCollection services)
        {
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
            return services;
        }
    }
}
