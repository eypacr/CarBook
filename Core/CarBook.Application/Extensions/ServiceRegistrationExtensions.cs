using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CarBook.Application.Extensions;

public static class ServiceRegistrationExtensions
{
    public static IServiceCollection ApplicationMediaExt(this IServiceCollection services, IConfiguration configuration)
    {
        // MediatR servislerini kaydediyoruz
        services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(ServiceRegistrationExtensions).Assembly));

        return services;
    }
}
