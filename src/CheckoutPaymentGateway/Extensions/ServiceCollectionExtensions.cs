using CheckoutPaymentGateway.Components;
using CheckoutPaymentGateway.DataAccess;
using CheckoutPaymentGateway.DataAccess.Models;
using CheckoutPaymentGateway.Infrastructure;
using CheckoutPaymentGateway.Infrastructure.Acquirer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Diagnostics.HealthChecks;
using Microsoft.OpenApi.Models;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.IO;

namespace CheckoutPaymentGateway.Extensions
{
    /// <summary>
    /// IServiceCollection Extensions
    /// </summary>
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddDbContext(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<AppDbContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("PaymentGatewayConString"),
                    x => x.MigrationsAssembly("CheckoutPaymentGateway"));
            });

            return services;
        }

        public static IServiceCollection AddDepencies(this IServiceCollection services)
        {
            if (services == null) throw new ArgumentNullException(nameof(services));
            //if (configuration == null) throw new ArgumentNullException(nameof(configuration));

            services.AddTransient<IAcquirerClient, AcquirerClient>();
            services.AddTransient<IAcquirerClient, AcquirerClient>();
            services.AddTransient<IPaymentComponent, PaymentComponent>();
            services.AddTransient<IBaseDataProvider<Payment>, PaymentDataProvider>();
            services.AddTransient<IBaseDataProvider<Address>, AddressDataProvider>();
            services.AddTransient<IBaseDataProvider<Customer>, CustomerDataProvider>();
            services.AddTransient<IBaseDataProvider<Merchant>, MerchantDataProvider>();
            services.AddTransient<IBaseDataProvider<Phone>, PhoneDataProvider>();
            services.AddTransient<IBaseDataProvider<ThreeDSEnrollment>, ThreeDSEnrollmentDataProvider>();
            services.AddTransient<IBaseDataProvider<Risk>, RiskDataProvider>();
            services.AddTransient<IBaseDataProvider<Card>, SourceDataProvider>();


            return services;
        }

        public static IServiceCollection AddCustomMvc(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddOptions();

            services.AddControllers(options =>
            {
                options.InputFormatters.RemoveType<Microsoft.AspNetCore.Mvc.Formatters.SystemTextJsonInputFormatter>();
                options.OutputFormatters.RemoveType<Microsoft.AspNetCore.Mvc.Formatters.SystemTextJsonOutputFormatter>();
            })
            .AddNewtonsoftJson(options =>
            {
                DefaultContractResolver contractResolver = new DefaultContractResolver
                {
                    NamingStrategy = new SnakeCaseNamingStrategy()
                };

                options.SerializerSettings.ContractResolver = contractResolver;
                options.SerializerSettings.Converters.Add(new StringEnumConverter(new CamelCaseNamingStrategy()));
            });

            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy",
                    builder => builder
                    .SetIsOriginAllowed((host) => true)
                    .AllowAnyMethod()
                    .AllowAnyHeader()
                    .AllowCredentials());
            });

            return services;
        }

        public static IServiceCollection AddCustomSwagger(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddSwaggerGen(options =>
            {
                options.SwaggerDoc("v1", new OpenApiInfo
                {
                    Title = "Payment Gateway API",
                    Version = "v1",
                    Description = "Payment Gateway API"
                });

                options.AddSecurityDefinition("oauth2", new OpenApiSecurityScheme
                {
                    Type = SecuritySchemeType.OAuth2,
                    Flows = new OpenApiOAuthFlows()
                    {
                        Implicit = new OpenApiOAuthFlow()
                        {
                            AuthorizationUrl = new Uri($"{configuration.GetValue<string>("urls:identity")}/connect/authorize"),
                            TokenUrl = new Uri($"{configuration.GetValue<string>("urls:identity")}/connect/token"),

                            Scopes = new Dictionary<string, string>()
                            {
                                { "payments", "Payment Gateway API" }
                            }
                        }
                    }
                });

                options.EnableAnnotations();
                // options.CustomSchemaIds(type => type.);
                options.IncludeXmlComments($"{AppContext.BaseDirectory}{Path.DirectorySeparatorChar}CheckoutPaymentGateway.xml");


                //options.OperationFilter<GeneratePathParamsValidationFilter>();
                //options.OperationFilter<AuthorizeCheckOperationFilter>();
            });

            return services;
        }

        public static IServiceCollection AddHealthChecks(this IServiceCollection services, IConfiguration configuration)
        {
            var hcBuilder = services.AddHealthChecks();

            hcBuilder.AddCheck("self", () => HealthCheckResult.Healthy());

            return services;
        }
    }
}
