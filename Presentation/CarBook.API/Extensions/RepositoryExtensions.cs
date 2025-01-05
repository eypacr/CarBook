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
        services.AddScoped<ICarRepository, CarRepository>();
        services.AddScoped<IBlogRepository, BlogRepository>();
        services.AddScoped<ICarPricingRepository, CarPricingRepository>();
        services.AddScoped<ICarPricingRepository, CarPricingRepository>();
        services.AddScoped<ICategoryRepository, CategoryRepository>();
        services.AddScoped<ITagCloudRepository, TagCloudRepository>();
        services.AddScoped<ICommentRepository, CommentRepository>();
        services.AddScoped<IAuthorRepository, AuthorRepository>();
        services.AddScoped<IStatisticRepository, StatisticRepository>();
        services.AddScoped<IRentACarRepository, RentACarRepository>();

        return services;
    }
}
