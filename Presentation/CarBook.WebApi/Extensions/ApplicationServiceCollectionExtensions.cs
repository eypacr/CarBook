using CarBook.Application.Features.CQRS.Handlers.AboutHandlers;
using CarBook.Application.Features.CQRS.Handlers.BannerHandlers;
using CarBook.Application.Features.CQRS.Handlers.BrandHandlers;
using CarBook.Application.Features.CQRS.Handlers.CarHandlers;
using CarBook.Application.Features.CQRS.Handlers.CategoryHandlers;
using CarBook.Application.Features.CQRS.Handlers.ContactHandlers;
using CarBook.Application.Interfaces;
using CarBook.Application.Interfaces.BlogInterfaces;
using CarBook.Application.Interfaces.CarInterfaces;
using CarBook.Application.Interfaces.CarPricingInterfaces;
using CarBook.Persistence.Context;
using CarBook.Persistence.Repositories;
using CarBook.Persistence.Repositories.BlogRepositories;
using CarBook.Persistence.Repositories.CarPricingRepositories;
using CarBook.Persistence.Repositories.CarRepositories;

namespace CarBook.WebApi.Extensions
{
	public static class ApplicationServiceCollectionExtensions
	{
		public static IServiceCollection AddDbContexts(this IServiceCollection services, IConfiguration configuration)
		{
			// Burada gerekli connection string veya ayarları kullanarak DbContext'i ekleyebilirsiniz
			services.AddScoped<CarBookContext>();

			// Diğer DbContext'ler varsa onları da burada ekleyebilirsiniz.
			// services.AddScoped<AnotherDbContext>();

			return services;
		}
		public static IServiceCollection AddRepositoryServices(this IServiceCollection services)
		{
			services.AddScoped<CarBookContext>();
			services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
			services.AddScoped(typeof(ICarRepository), typeof(CarRepository));
			services.AddScoped(typeof(IBlogRepository), typeof(BlogRepository));
			services.AddScoped(typeof(ICarPricingRepository), typeof(CarPricingRepository));

			return services;
		}

		public static IServiceCollection AddAboutCQRSHandlers(this IServiceCollection services)
		{
			services.AddScoped<GetAboutQueryHandler>();
			services.AddScoped<GetAboutByIdQueryHandler>();
			services.AddScoped<CreateAboutCommandHandler>();
			services.AddScoped<UpdateAboutCommandHandler>();
			services.AddScoped<RemoveAboutCommandHandler>();

			return services;
		}

		public static IServiceCollection AddBannerCQRSHandlers(this IServiceCollection services)
		{
			services.AddScoped<GetBannerQueryHandler>();
			services.AddScoped<GetBannerByIdQueryHandler>();
			services.AddScoped<CreateBannerCommandHandler>();
			services.AddScoped<UpdateBannerCommandHandler>();
			services.AddScoped<RemoveBannerCommandHandler>();

			return services;
		}

		public static IServiceCollection AddBrandCQRSHandlers(this IServiceCollection services)
		{
			services.AddScoped<GetBrandQueryHandler>();
			services.AddScoped<GetBrandByIdQueryHandler>();
			services.AddScoped<CreateBrandCommandHandler>();
			services.AddScoped<UpdateBrandCommandHandler>();
			services.AddScoped<RemoveBrandCommandHandler>();

			return services;
		}

		public static IServiceCollection AddCarCQRSHandlers(this IServiceCollection services)
		{
			services.AddScoped<GetCarQueryHandler>();
			services.AddScoped<GetCarByIdQueryHandler>();
			services.AddScoped<CreateCarCommandHandler>();
			services.AddScoped<UpdateCarCommandHandler>();
			services.AddScoped<RemoveCarCommandHandler>();
			services.AddScoped<GetCarWithBrandQueryHandler>();
			services.AddScoped<GetLast5CarsWithBrandQueryHandler>();

			return services;
		}

		public static IServiceCollection AddCategoryCQRSHandlers(this IServiceCollection services)
		{
			services.AddScoped<GetCategoryQueryHandler>();
			services.AddScoped<GetCategoryByIdQueryHandler>();
			services.AddScoped<CreateCategoryCommandHandler>();
			services.AddScoped<UpdateCategoryCommandHandler>();
			services.AddScoped<RemoveCategoryCommandHandler>();

			return services;
		}

		public static IServiceCollection AddContactCQRSHandlers(this IServiceCollection services)
		{
			services.AddScoped<GetContactQueryHandler>();
			services.AddScoped<GetContactByIdQueryHandler>();
			services.AddScoped<CreateContactCommandHandler>();
			services.AddScoped<UpdateContactCommandHandler>();
			services.AddScoped<RemoveContactCommandHandler>();

			return services;
		}
	}
}
