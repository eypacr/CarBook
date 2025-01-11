using Microsoft.AspNetCore.Authentication.JwtBearer;

namespace CarBook.WebUI.Extensions;

public static class JwtAuthenticationExtensions
{
    public static IServiceCollection AddJwtUIAuthentication(this IServiceCollection services)
    {
        services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
            .AddCookie(JwtBearerDefaults.AuthenticationScheme, opt =>
            {
                opt.LoginPath = "/Login/Index"; // Kullanıcı login olmadığında yönlendirilecek path
                opt.LogoutPath = "/Login/LogOut"; // Kullanıcı logout olduğunda yönlendirilecek path
                opt.AccessDeniedPath = "/ErrorPage/AccessDenied"; // Yetkisiz erişimde yönlendirilecek path
                opt.Cookie.SameSite = SameSiteMode.Strict; 
                opt.Cookie.HttpOnly = true; 
                opt.Cookie.SecurePolicy = CookieSecurePolicy.SameAsRequest;
                opt.Cookie.Name = "CarBookJwt"; // Cookie'nin adı
            });

        return services;
    }
}
