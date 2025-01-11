using CarBookProject.WebApi.Hubs;

namespace CarBook.API.Extensions;

public static class ConfigurePipelineExtensions
{
    public static IApplicationBuilder UseConfigurePipelineExt(this WebApplication app)
    {
        app.UseExceptionHandler(x => { });
        // Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment())
        {
            app.UseSwaggerExt();
        }
        app.UseCors("CorsPolicy"); //Cors Konfigürasyonu
        app.UseHttpsRedirection();
        app.MapHub<CarHub>("/carhub"); //SignalR tarafına istek yapmayı sağlayan yapı.
        return app;
    }
}
