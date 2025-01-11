using CarBook.Application.Tools.AuthenticationTools;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace CarBook.API.Extensions;

public static class JwtAuthenticationExtensions
{
    public static IServiceCollection AddJwtAuthentication(this IServiceCollection services)
    {
        services.AddHttpClient();
        services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
            .AddJwtBearer(opt =>
            {
                opt.RequireHttpsMetadata = false;
                opt.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidAudience = JwtTokenDefaults.ValidAudience,
                    ValidIssuer = JwtTokenDefaults.ValidIssuer,
                    ClockSkew = TimeSpan.Zero,
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(JwtTokenDefaults.Key)),
                    ValidateLifetime = true,
                    ValidateIssuerSigningKey = true,
                };
            });

        return services;
    }
    public static IServiceCollection AddCorsPolicy(this IServiceCollection services)
    {
        services.AddCors(opt =>
        {
            opt.AddPolicy("CorsPolicy", builder =>
            {
                builder.AllowAnyHeader()
                       .AllowAnyMethod()
                       .SetIsOriginAllowed(host => true) // Tüm kaynaklardan gelen isteklere izin verir
                       .AllowCredentials(); // Kimlik doğrulama bilgilerini iletmek için izin verir
            });
        });
        services.AddSignalR();
        return services;
    }
}
