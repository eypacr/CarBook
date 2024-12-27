using CarBook.Application.Features.CQRS.Handlers.AboutHandlers;
using CarBook.Application.Features.CQRS.Handlers.BannerHandlers;
using CarBook.Application.Features.CQRS.Handlers.BrandHandlers;
using CarBook.Application.Features.CQRS.Handlers.CarHandlers;
using CarBook.Application.Features.CQRS.Handlers.CategoryHandlers;
using CarBook.Application.Features.CQRS.Handlers.ContactHandlers;

namespace CarBook.API.Extensions;

public static class CQRSHandlersExtensions
{
    public static IServiceCollection CQRSHandlersExt(this IServiceCollection services)
    {
        services.AddScoped<GetAboutQueryHandler>();
        services.AddScoped<GetAboutByIdQueryHandler>();
        services.AddScoped<CreateAboutCommandHandler>();
        services.AddScoped<UpdateAboutCommandHandler>();
        services.AddScoped<RemoveAboutCommandHandler>();

        services.AddScoped<GetBannerQueryHandler>();
        services.AddScoped<GetBannerByIdQueryHandler>();
        services.AddScoped<CreateBannerCommandHandler>();
        services.AddScoped<UpdateBannerCommandHandler>();
        services.AddScoped<RemoveBannerCommandHandler>();

        services.AddScoped<GetBrandQueryHandler>();
        services.AddScoped<GetBrandByIdQueryHandler>();
        services.AddScoped<CreateBrandCommandHandler>();
        services.AddScoped<UpdateBrandCommandHandler>();
        services.AddScoped<RemoveBrandCommandHandler>();

        services.AddScoped<GetCarQueryHandler>();
        services.AddScoped<GetCarByIdQueryHandler>();
        services.AddScoped<CreateCarCommandHandler>();
        services.AddScoped<UpdateCarCommandHandler>();
        services.AddScoped<RemoveCarCommandHandler>();
        services.AddScoped<GetCarWithBrandQueryHandler>();
        services.AddScoped<GetLast5CarsWithBrandQueryHandler>();
        services.AddScoped<GetCarsByBrandQueryHandler>();

        services.AddScoped<GetCategoryQueryHandler>();
        services.AddScoped<GetCategoryByIdQueryHandler>();
        services.AddScoped<CreateCategoryCommandHandler>();
        services.AddScoped<UpdateCategoryCommandHandler>();
        services.AddScoped<RemoveCategoryCommandHandler>();
        services.AddScoped<GetCategoryWithBlogCountQueryHandler>();

        services.AddScoped<GetContactQueryHandler>();
        services.AddScoped<GetContactByIdQueryHandler>();
        services.AddScoped<CreateContactCommandHandler>();
        services.AddScoped<UpdateContactCommandHandler>();
        services.AddScoped<RemoveContactCommandHandler>();


        return services;
    }
}
