using CarBook.Application.RepositoryInterfaces;
using CarBook.Persistence.Context;
using CarBook.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;

namespace CarBook.API.Extensions;

public static class RepositoryExtensions
{
    public static IServiceCollection AddRepositories(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<CarBookContext>(options =>
        {
            options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"),
                b => b.MigrationsAssembly("CarBook.Persistence"));

        });
        // Veritabanı migrationlarını otomatik olarak uygulama
        var serviceProvider = services.BuildServiceProvider();
        using (var scope = serviceProvider.CreateScope())
        {
            var dbContext = scope.ServiceProvider.GetRequiredService<CarBookContext>();
            dbContext.Database.Migrate();
        }
        services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
        services.AddScoped(typeof(ICarRepository), typeof(CarRepository));
        services.AddScoped(typeof(IBlogRepository), typeof(BlogRepository));
        services.AddScoped(typeof(ICarPricingRepository), typeof(CarPricingRepository));

        return services;
    }
}
